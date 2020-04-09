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
  public partial class FormLogin : Form
  {
    private FormPrincipal fPri;
    private BancoDados bd;
    private Usuario usuario;

    public FormLogin()
    {
      InitializeComponent();
      bd = new BancoDados();
    }

    private void butAcessar_Click(object sender, EventArgs e)
    {
      usuario = new Usuario();
      usuario.ValidarUsuario(txtLogin.Text, txtSenha.Text);
      if (usuario.Nome != null)
      {
        this.Visible = false;
        fPri = new FormPrincipal();
        fPri.lblUsuario.Text = usuario.Nome;
        if (usuario.Perfil != "ADMINISTRADOR")
        {
          fPri.usuáriosToolStripMenuItem.Visible = false; 
        }
        fPri.ShowDialog();
        this.Close();
      }
      else
      {
        MessageBox.Show("Login ou Senha inválidos, digite novamente...", "Erro de Acesso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        txtLogin.Clear();
        txtSenha.Clear();
        txtLogin.Focus();
      }
    }

    private void butSair_Click(object sender, EventArgs e)
    {
      this.Close();
    }

    private void FormLogin_KeyDown(object sender, KeyEventArgs e)
    {
      if (e.KeyCode == Keys.Enter)
      {
        if (e.Shift)
        {
          SendKeys.Send("+{TAB}");
        }
        else
        {
          SendKeys.Send("{TAB}");
        }
      }
    }

    private void txtLogin_KeyPress(object sender, KeyPressEventArgs e)
    {
      if (!Char.IsLetterOrDigit(e.KeyChar) && e.KeyChar != (char)8)
      {
        e.Handled = true;
      }
    }

    private void txtSenha_KeyPress(object sender, KeyPressEventArgs e)
    {
      if (!Char.IsLetterOrDigit(e.KeyChar) && e.KeyChar != (char)8)
      {
        e.Handled = true;
      }
    }
  }
}
