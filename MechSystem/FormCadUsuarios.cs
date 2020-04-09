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
  public partial class FormCadUsuarios : Form
  {
    //Atributos
    //----------------------------------------------------------------------------
    private Usuario usu;
    private bool novoUsuario = false;
    
    //Construtor
    //----------------------------------------------------------------------------
    public FormCadUsuarios(FormPrincipal parent)
    {
      InitializeComponent();
      this.MdiParent = parent;
      tbCodigo.Focus();
      cbxPerfil.Text = "USUARIO";
    }

    //Metodos_Gerais
    //----------------------------------------------------------------------------
    private void LimparCampos()
    {
      tbCodigo.Clear();
      tbLogin.Clear();
      tbSenha.Clear();
      tbSenhaC.Clear();
      cbxPerfil.DataSource = null;
      chkMostraCaracteres.Checked = false;
    }

    private void HabiDesaCampos(bool flag)
    { 
      //Read_Only
      tbCodigo.ReadOnly = flag;
      tbLogin.ReadOnly = !flag;
      tbSenha.ReadOnly = !flag;
      tbSenhaC.ReadOnly = !flag;

      //Enabled
      cbxPerfil.Enabled = flag;
      chkMostraCaracteres.Enabled = flag;

      //TabStop
      tbCodigo.TabStop = !flag;
      tbLogin.TabStop = flag;
      tbSenha.TabStop = flag;
      tbSenhaC.TabStop = flag;
      cbxPerfil.TabStop = flag;
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

    //Eventos
    //----------------------------------------------------------------------------
    private void butSair_Click(object sender, EventArgs e)
    {
      this.Close();
    }

    private void butNovo_Click(object sender, EventArgs e)
    {
      novoUsuario = true;
      this.LimparCampos();
      this.HabiDesaCampos(true);
      butNovo.Enabled = false;
      butCancelar.Enabled = true;
      butConsultar.Enabled = false;
      butAlterar.Enabled = false;
      butExcluir.Enabled = false;
      btnConsultaGeral.Enabled = false;
      cbxPerfil.Text = "USUARIO";
      this.CancelButton = butCancelar;
      tbLogin.Focus();
    }

    private void tbSenhaC_Leave(object sender, EventArgs e)
    {
      if (butNovo.Enabled == false)
      {
        if (tbSenhaC.Text.Length > 0)
        {
          if (tbSenha.Text == tbSenhaC.Text)
          {
            if (tbLogin.Text.Length > 0)
            {
              butSalvar.Enabled = true;
              lblSenha.Visible = false;
              butSalvar.Focus();
            }
            else
            {
              butSalvar.Enabled = false;
              lblSenha.Visible = false;
            }
          }
          else
          {
            butSalvar.Enabled = false;
            lblSenha.Visible = true;
          }
        }
        else
        {
          butSalvar.Enabled = false;
          lblSenha.Visible = false;
        }
      }
      else
      {
        butSalvar.Enabled = false;
      }
    }

    private void tbLogin_Leave(object sender, EventArgs e)
    {
      if (tbLogin.Text.Length == 0)
      {
        butSalvar.Enabled = false;
      }
    }

    private void tbSenha_Leave(object sender, EventArgs e)
    {
      if (butNovo.Enabled == false)
      {
        if (tbSenhaC.Text.Length > 0)
        {
          if (tbSenha.Text == tbSenhaC.Text)
          {
            if (tbLogin.Text.Length > 0)
            {
              butSalvar.Enabled = true;
              lblSenha.Visible = false;
            }
            else
            {
              butSalvar.Enabled = false;
              lblSenha.Visible = false;
            }
          }
          else
          {
            butSalvar.Enabled = false;
            lblSenha.Visible = true;
          }
        }
        else
        {
          butSalvar.Enabled = false;
          lblSenha.Visible = false;
        }
      }
      else
      {
        butSalvar.Enabled = false;
      }
    }

    private void checkBox1_CheckedChanged(object sender, EventArgs e)
    {
      if (chkMostraCaracteres.Checked)
      {
        tbSenha.PasswordChar = '\0';
        tbSenhaC.PasswordChar = '\0';
        tbSenha.Focus();
        tbSenha.SelectAll();
      }
      else
      {
        tbSenha.PasswordChar = '*';
        tbSenhaC.PasswordChar = '*';
        tbSenha.Focus();
        tbSenha.SelectAll();
      }
    }

    private void butSalvar_Click(object sender, EventArgs e)
    {
      usu = new Usuario();
      usu.Nome = tbLogin.Text;
      usu.Senha = tbSenha.Text;
      usu.Perfil = cbxPerfil.Text;

      if (novoUsuario)
      {
        DialogResult res = MessageBox.Show("Confirma a inserção do registro?", "Inserção", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
        if (res == DialogResult.Yes)
        {
          usu.InserirUsuario();

          DataSet ds = usu.RetornaCodigo();
          tbCodigo.Text = Convert.ToString(ds.Tables[0].Rows[0]["id"]);
          this.HabiDesaCampos(false);
          this.OrganizaBotoes();
          this.CancelButton = butSair;
          butAlterar.Enabled = true;
          butExcluir.Enabled = true;
          novoUsuario = false;
          chkMostraCaracteres.Checked = false;
          tbCodigo.Focus();
          tbCodigo.SelectAll();
        }
      }
      else
      {
        DialogResult res = MessageBox.Show("Confirma a alteração do registro?", "Atualização", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
        if (res == DialogResult.Yes)
        {
          usu.Id = Convert.ToInt32(tbCodigo.Text);
          usu.AtualizarUsuario();

          this.HabiDesaCampos(false);
          this.OrganizaBotoes();
          this.CancelButton = butSair;
          butAlterar.Enabled = true;
          butExcluir.Enabled = true;
          novoUsuario = false;
          chkMostraCaracteres.Checked = false;
          tbCodigo.Focus();
          tbCodigo.SelectAll();
        }
      }
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
        novoUsuario = false;
      }
    }

    private void butConsultar_Click(object sender, EventArgs e)
    {
      if (tbCodigo.Text.Length == 0)
      {
        LimparCampos();
        OrganizaBotoes();
        butAlterar.Enabled = false;
        FormGridUsuarios grid = new FormGridUsuarios(this);
        grid.MdiParent = this.ParentForm;
        grid.Show();
      }
      else
      {
        usu = new Usuario();
        usu.Id = Convert.ToInt32(tbCodigo.Text);
        usu.ConsutarUsuario();
        if (usu.Nome != null)
        {
          tbLogin.Text = usu.Nome;
          tbSenha.Text = usu.Senha;
          tbSenhaC.Text = tbSenha.Text;
          cbxPerfil.Text = usu.Perfil;

          tbCodigo.Focus();
          tbCodigo.SelectAll();
          butAlterar.Enabled = true;
          butExcluir.Enabled = true;
          butSalvar.Enabled = false;
        }
        else
        {
          this.LimparCampos();
          this.OrganizaBotoes();
        }
      }
    }

    private void butAlterar_Click(object sender, EventArgs e)
    {
      novoUsuario = false;
      this.HabiDesaCampos(true);
      butAlterar.Enabled = false;
      butCancelar.Enabled = true;
      butConsultar.Enabled = false;
      butExcluir.Enabled = false;
      butNovo.Enabled = false;
      butSalvar.Enabled = true;
      btnConsultaGeral.Enabled = false;
      this.CancelButton = butCancelar;
      tbLogin.Focus();
      tbLogin.SelectAll();
    }

    private void butExcluir_Click(object sender, EventArgs e)
    {
      DialogResult res = MessageBox.Show("Confirma a exclusão do registro?", "Exclusão", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
      if (res == DialogResult.Yes)
      {
        usu = new Usuario();
        usu.Id = Convert.ToInt32(tbCodigo.Text);
        usu.DeletarUsuario();
        this.LimparCampos();
        this.HabiDesaCampos(false);
        this.OrganizaBotoes();
        chkMostraCaracteres.Checked = false;
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

    private void tbSenhaC_TextChanged(object sender, EventArgs e)
    {
      if (tbSenhaC.Text == tbSenha.Text)
      {
        butSalvar.Enabled = true;
      }
      else
      {
        butSalvar.Enabled = false;
      }
    }

    private void btnConsultaGeral_Click(object sender, EventArgs e)
    {
      LimparCampos();
      OrganizaBotoes();
      butAlterar.Enabled = false;
      FormGridUsuarios grid = new FormGridUsuarios(this);
      grid.MdiParent = this.ParentForm;
      grid.Show();
    }

    private void FormCadUsuarios_KeyDown(object sender, KeyEventArgs e)
    {
      if (e.KeyCode == Keys.F6)
      {
        if (btnConsultaGeral.Enabled)
        {
          LimparCampos();
          OrganizaBotoes();
          butAlterar.Enabled = false;
          FormGridUsuarios grid = new FormGridUsuarios(this);
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

    private void cbxPerfil_SelectedIndexChanged(object sender, EventArgs e)
    {
      tbLogin.Focus();
    }

    private void tbCodigo_Leave(object sender, EventArgs e)
    {
      if (tbCodigo.Text.Length != 0)
      {
        usu = new Usuario();
        usu.Id = Convert.ToInt32(tbCodigo.Text);
        usu.ConsutarUsuario();
        if (usu.Nome != null)
        {
          tbLogin.Text = usu.Nome;
          tbSenha.Text = usu.Senha;
          tbSenhaC.Text = tbSenha.Text;
          cbxPerfil.Text = usu.Perfil;

          butAlterar.Enabled = true;
          butExcluir.Enabled = true;
          butSalvar.Enabled = false;
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

    private void cbxPerfil_DropDownClosed(object sender, EventArgs e)
    {
      tbLogin.Focus();
    }
  }
}
