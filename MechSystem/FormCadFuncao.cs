using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace MechSystem
{
  public partial class FormCadFuncao : Form
  {
    //Atributos
    //----------------------------------------------------------------
    private Funcao func;
    private DataSet ds;
    private bool novaFuncao;
    private bool req_descricao = false;

    //Construtor
    //----------------------------------------------------------------
    public FormCadFuncao(FormPrincipal parent)
    {
      InitializeComponent();
      this.MdiParent = parent;
      tbCodigo.Focus();
    }

    //Métodos_Gerais
    //----------------------------------------------------------------
    public void LimparCampos()
    {
      tbCodigo.Clear();
      tbDescricao.Clear();
    }

    public void HabiDesaCampos(bool flag)
    { 
      //Read_Only
      tbCodigo.ReadOnly = flag;
      tbDescricao.ReadOnly = !flag;

      //TabStop
      tbCodigo.TabStop = !flag;
      tbDescricao.TabStop = flag;
    }

    public void ValidarRequisitos()
    {
      if (req_descricao == true)
      {
        butSalvar.Enabled = true;
      }
      else
      {
        butSalvar.Enabled = false;
      }
    }

    private void OrganizaBotoes()
    {
      butAlterar.Enabled = false;
      butCancelar.Enabled = false;
      butConsultar.Enabled = true;
      butExcluir.Enabled = false;
      butNovo.Enabled = true;
      butSair.Enabled = true;
      butSalvar.Enabled = false;
      btnConsultaGeral.Enabled = true;
    }

    //Métodos_Eventos
    //----------------------------------------------------------------
    private void butNovo_Click(object sender, EventArgs e)
    {
      btnConsultaGeral.Enabled = false;
      novaFuncao = true;
      this.LimparCampos();
      this.HabiDesaCampos(true);
      this.CancelButton = butCancelar;
      butNovo.Enabled = false;
      butCancelar.Enabled = true;
      butConsultar.Enabled = false;
      butAlterar.Enabled = false;
      butExcluir.Enabled = false;
      butSalvar.Enabled = true;
      tbDescricao.Focus();
    }

    private void butCancelar_Click(object sender, EventArgs e)
    {
      DialogResult res = MessageBox.Show("Deseja realmente cancelar a operação?", "Cancelar Operação", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
      if (res == DialogResult.Yes)
      {
        this.LimparCampos();
        this.HabiDesaCampos(false);
        this.OrganizaBotoes();
        tbCodigo.Focus();
        this.CancelButton = butSair;
        novaFuncao = false;
      }
    }

    private void butSair_Click(object sender, EventArgs e)
    {
      this.Close();
    }

    private void butSalvar_Click(object sender, EventArgs e)
    {
      if (tbDescricao.Text.Length == 0)
      {
        MessageBox.Show("Digite a descrição da função que deseja cadastrar!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        tbDescricao.Focus();
      }
      else
      {
        if (novaFuncao)
        {
          DialogResult res = MessageBox.Show("Confirma a inserção do registro?", "Novo Registro", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
          if (res == DialogResult.Yes)
          {
            func = new Funcao();
            func.Descricao = tbDescricao.Text;
            func.InserirFuncao();

            //Retorna o id do novo registro inserido
            ds = func.RetornaCodigo();
            tbCodigo.Text = Convert.ToString(ds.Tables[0].Rows[0]["id"]);

            this.HabiDesaCampos(false);
            this.OrganizaBotoes();
            this.CancelButton = butSair;
            butAlterar.Enabled = true;
            butExcluir.Enabled = true;
            novaFuncao = false;
            tbCodigo.Focus();
            tbCodigo.SelectAll();
          }
        }
        else
        {
          DialogResult res = MessageBox.Show("Confirma a alteração do registro?", "Atualização", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
          if (res == DialogResult.Yes)
          {
            func = new Funcao();
            func.Id = Convert.ToInt32(tbCodigo.Text);
            func.Descricao = tbDescricao.Text;
            func.AlterarFuncao();

            this.HabiDesaCampos(false);
            this.OrganizaBotoes();
            this.CancelButton = butSair;
            butAlterar.Enabled = true;
            butExcluir.Enabled = true;
            novaFuncao = false;
            tbCodigo.Focus();
            tbCodigo.SelectAll();
          }
        }
      }
    }

    private void butAlterar_Click(object sender, EventArgs e)
    {
      novaFuncao = false;
      this.HabiDesaCampos(true);
      butAlterar.Enabled = false;
      butCancelar.Enabled = true;
      butConsultar.Enabled = false;
      butExcluir.Enabled = false;
      butNovo.Enabled = false;
      butSalvar.Enabled = true;
      btnConsultaGeral.Enabled = false;
      this.CancelButton = butCancelar;
      tbDescricao.Focus();
      tbDescricao.SelectAll();
    }

    private void butConsultar_Click(object sender, EventArgs e)
    {
      if (tbCodigo.Text.Length == 0)
      {
        LimparCampos();
        OrganizaBotoes();
        butAlterar.Enabled = false;
        FormGridFuncao grid = new FormGridFuncao(this);
        grid.MdiParent = this.ParentForm;
        grid.Show();
      }
      else
      {
        func = new Funcao();
        func.Id = Convert.ToInt32(tbCodigo.Text);
        func.ConsultaFuncao();
        if (func.Descricao != null)
        {
          tbDescricao.Text = func.Descricao;

          butAlterar.Enabled = true;
          butExcluir.Enabled = true;
        }
        else
        {
          this.LimparCampos();
          this.OrganizaBotoes();
        }
        tbCodigo.SelectAll();
      }
    }

    private void butExcluir_Click(object sender, EventArgs e)
    {
      DialogResult res = MessageBox.Show("Confirma a exclusão do registro?", "Exclusão", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
      if (res == DialogResult.Yes)
      {
        func = new Funcao();
        func.Id = Convert.ToInt32(tbCodigo.Text);
        func.ExcluirFuncao();
        this.LimparCampos();
        this.HabiDesaCampos(false);
        this.OrganizaBotoes();
        tbCodigo.Focus();
      }
    }

    private void tbCodigo_KeyPress(object sender, KeyPressEventArgs e)
    {
      if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8)
      {
          e.Handled = true;
      }
    }

    private void tbDescricao_KeyPress(object sender, KeyPressEventArgs e)
    {
      if (!Char.IsLetter(e.KeyChar) && e.KeyChar != (char)8)
      {
        e.Handled = true;
      }
    }

    private void btnConsultaGeral_Click(object sender, EventArgs e)
    {
      LimparCampos();
      OrganizaBotoes();
      butAlterar.Enabled = false;
      FormGridFuncao grid = new FormGridFuncao(this);
      grid.MdiParent = this.ParentForm;
      grid.Show();
    }

    private void FormCadFuncao_KeyDown(object sender, KeyEventArgs e)
    {
      if (e.KeyCode == Keys.F6)
      {
        if (btnConsultaGeral.Enabled)
        {
          LimparCampos();
          OrganizaBotoes();
          butAlterar.Enabled = false;
          FormGridFuncao grid = new FormGridFuncao(this);
          grid.MdiParent = this.ParentForm;
          grid.Show();
        }
      }
      else if (e.KeyCode == Keys.Enter)
      {
        if (e.Shift)
        {
          SendKeys.Send("+{TAB}");
          e.SuppressKeyPress = true;          
        }
        else
        {
          SendKeys.Send("{TAB}");
          e.SuppressKeyPress = true;          
        }
      }
    }

    private void tbCodigo_Leave(object sender, EventArgs e)
    {
      if (tbCodigo.Text.Length != 0)
      {
        func = new Funcao();
        func.Id = Convert.ToInt32(tbCodigo.Text);
        func.ConsultaFuncao();
        //if (func.Descricao != null)
        if (string.IsNullOrEmpty(func.Descricao) == false)
        {
          tbDescricao.Text = func.Descricao;

          butAlterar.Enabled = true;
          butExcluir.Enabled = true;
          butNovo.Focus();
        }
        else
        {
          this.LimparCampos();
          this.OrganizaBotoes();
          tbCodigo.Focus();
          tbCodigo.SelectAll();
        }
      }
      else
      {
        this.LimparCampos();
        this.OrganizaBotoes();
      }
    }

    private void tbCodigo_Enter(object sender, EventArgs e)
    {
      tbCodigo.SelectAll();
    }
  }
}
