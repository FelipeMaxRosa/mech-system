using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MechSystem
{
  public partial class FormCadServicos : Form
  {
    //Atributos
    //--------------------------------------------------------------------------
    private Servicos ser;
    private bool novoServico = false;
    private bool req_valor = false;
    private bool req_descricao = false;

    //Construtor
    //--------------------------------------------------------------------------
    public FormCadServicos(FormPrincipal parent)
    {
      InitializeComponent();
      this.MdiParent = parent;
      tbCodigo.Focus();
    }

    //Metodos_Gerais
    //--------------------------------------------------------------------------
    private void LimparCampos()
    {
      tbCodigo.Clear();
      tbDescricao.Clear();
      tbDetalhes.Clear();
      tbValor.Clear();
    }

    private void HabiDesaCampos(bool flag)
    {
      //Read_Only
      tbCodigo.ReadOnly = flag;
      tbDescricao.ReadOnly = !flag;
      tbDetalhes.ReadOnly = !flag;
      tbValor.ReadOnly = !flag;

      //TabStop
      tbCodigo.TabStop = !flag;
      tbDescricao.TabStop = flag;
      tbDetalhes.TabStop = flag;
      tbValor.TabStop = flag;
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

    private void ValidaDados()
    {
      if (req_valor == true && req_descricao == true)
      {
        butSalvar.Enabled = true;
      }
      else
      {
        butSalvar.Enabled = false;
      }
    }

    //Metodos_Eventos
    //--------------------------------------------------------------------------
    private void butNovo_Click(object sender, EventArgs e)
    {
      novoServico = true;
      this.LimparCampos();
      this.HabiDesaCampos(true);

      butNovo.Enabled = false;
      butCancelar.Enabled = true;
      butConsultar.Enabled = false;
      butAlterar.Enabled = false;
      butExcluir.Enabled = false;
      btnConsultaGeral.Enabled = false;
      this.CancelButton = butCancelar;
      tbDescricao.Focus();
    }

    private void butCancelar_Click(object sender, EventArgs e)
    {
      DialogResult res = MessageBox.Show("Deseja realmente cancelar a operação?", "Cancelar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
      if (res == DialogResult.Yes)
      {
        this.LimparCampos();
        this.HabiDesaCampos(false);
        this.OrganizaBotoes();
        tbCodigo.Focus();
        this.CancelButton = butSair;
        novoServico = false;
        req_valor = false;
        req_descricao = false;
      }
    }

    private void tbValor_KeyPress(object sender, KeyPressEventArgs e)
    {
      if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8 && e.KeyChar != '.')
      {
        e.Handled = true;
      }
    }

    private void butSair_Click(object sender, EventArgs e)
    {
      this.Close();
    }

    private void tbCodigo_KeyPress(object sender, KeyPressEventArgs e)
    {
      if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8)
      {
        e.Handled = true;
      }
    }

    private void butSalvar_Click(object sender, EventArgs e)
    {

      if (novoServico)
      {
        DialogResult res = MessageBox.Show("Confirma a inserção do registro?", "Novo Registro", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
        if (res == DialogResult.Yes)
        {
          ser = new Servicos();
          ser.Descricao = tbDescricao.Text;
          ser.Detalhes = tbDetalhes.Text;
          ser.Valor = Convert.ToDecimal(tbValor.Text);

          ser.InserirServico();
          ser.RetornaCodigo();
          tbCodigo.Text = Convert.ToString(ser.Id); 

          this.HabiDesaCampos(false);
          this.OrganizaBotoes();
          this.CancelButton = butSair;
          butAlterar.Enabled = true;
          novoServico = false;
          tbCodigo.Focus();
          tbCodigo.SelectAll();
        }
      }
      else
      { 
        DialogResult res = MessageBox.Show("Confirma a alteração do registro?", "Atualização", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
        if (res == DialogResult.Yes)
        {
          ser = new Servicos();
          ser.Id = Convert.ToInt32(tbCodigo.Text);
          ser.Descricao = tbDescricao.Text;
          ser.Detalhes = tbDetalhes.Text;
          ser.Valor = Convert.ToDecimal(tbValor.Text);
          ser.AtualizarServico();

          this.HabiDesaCampos(false);
          this.OrganizaBotoes();
          this.CancelButton = butSair;
          butAlterar.Enabled = true;
          butExcluir.Enabled = true;
          novoServico = false;
          tbCodigo.Focus();
          tbCodigo.SelectAll();
        }
      }
    }

    private void butAlterar_Click(object sender, EventArgs e)
    {
      novoServico = false;
      req_descricao = true;
      req_valor = true;
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
        FormGridServicos grid = new FormGridServicos(this);
        grid.MdiParent = this.ParentForm;
        grid.Show();        
      }
      else
      {
        ser = new Servicos();
        ser.Id = Convert.ToInt32(tbCodigo.Text);
        ser.ConsultaServico();
        if (ser.Descricao != null)
        {
          tbDescricao.Text = ser.Descricao;
          tbDetalhes.Text = ser.Detalhes;
          tbValor.Text = Convert.ToString(ser.Valor);

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
        ser = new Servicos();
        ser.Id = Convert.ToInt32(tbCodigo.Text);
        ser.DeletarServico();
        this.LimparCampos();
        this.HabiDesaCampos(false);
        this.OrganizaBotoes();
        tbCodigo.Focus();
      }
    }

    private void tbValor_Leave(object sender, EventArgs e)
    {
      if (tbValor.Text.Length > 0)
      {
        decimal valor = decimal.Parse(tbValor.Text);
        tbValor.Text = valor.ToString("0.00");
        req_valor = true;
        this.ValidaDados();
      }
      else
      {
        req_valor = false;
        this.ValidaDados();
      }
    }

    private void tbDescricao_Leave(object sender, EventArgs e)
    {
      if (tbDescricao.Text.Length > 0)
      {
        req_descricao = true;
        this.ValidaDados();
      }
      else
      {
        req_descricao = false;
        this.ValidaDados();
      }
    }

    private void btnConsultaGeral_Click(object sender, EventArgs e)
    {
      LimparCampos();
      OrganizaBotoes();
      butAlterar.Enabled = false;
      FormGridServicos grid = new FormGridServicos(this);
      grid.MdiParent = this.ParentForm;
      grid.Show();
    }

    private void FormCadServicos_KeyDown(object sender, KeyEventArgs e)
    {
      if (e.KeyCode == Keys.F6)
      {
        if (btnConsultaGeral.Enabled)
        {
          LimparCampos();
          OrganizaBotoes();
          butAlterar.Enabled = false;
          FormGridServicos grid = new FormGridServicos(this);
          grid.MdiParent = this.ParentForm;
          grid.Show();
        }
      }
      else if (e.KeyCode == Keys.Enter)
      {
        if (e.Shift)
        {
          e.SuppressKeyPress = true;
          SendKeys.Send("+{TAB}");
        }
        else
        {
          e.SuppressKeyPress = true;
          SendKeys.Send("{TAB}");
        }
      }
    }

    private void tbCodigo_Leave(object sender, EventArgs e)
    {
      if (tbCodigo.Text.Length != 0)
      {
        ser = new Servicos();
        ser.Id = Convert.ToInt32(tbCodigo.Text);
        ser.ConsultaServico();
        if (ser.Descricao != null)
        {
          tbDescricao.Text = ser.Descricao;
          tbDetalhes.Text = ser.Detalhes;
          tbValor.Text = Convert.ToString(ser.Valor);

          butAlterar.Enabled = true;
          butExcluir.Enabled = true;
          butNovo.Focus();
        }
        else
        {
          this.LimparCampos();
          this.OrganizaBotoes();
          tbCodigo.Focus();
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
