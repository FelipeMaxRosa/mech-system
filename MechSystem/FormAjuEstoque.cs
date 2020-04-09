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
  public partial class FormAjuEstoque : Form
  {
    //Atributos
    private Produtos prod;
    private FormGridProdutos gridProd;
    private string usuario;

    //Propriedades
    public string Usuario
    {
      get { return usuario; }
      set { usuario = value; }
    }

    //Construtor
    public FormAjuEstoque(FormPrincipal parent)
    {
      InitializeComponent();
      this.MdiParent = parent;
      cbxAjuste.Text = "POSITIVO";
    }

    //Métodos Gerais
    private void LimparCampos()
    {
      tbCodigo.Clear();
      tbQtde.Clear();
      tbEmb.Clear();
      tbObs.Clear();
      cbxAjuste.Text = "";
      lblDescricao.Text = "";
      lblTotalAjuste.Text = "";
    }

    private void OrganizaBotoes()
    {
      butCancelar.Enabled = false;
      butNovo.Enabled = true;
      butSair.Enabled = true;
      butSalvar.Enabled = false;
    }

    private void HabiDesaCampos(bool flag)
    {
      grbAjuste.Enabled = flag;
      grbObs.Enabled = flag;
      grbProduto.Enabled = flag;
    }

    //Métodos Eventos
    private void butNovo_Click(object sender, EventArgs e)
    {
      this.HabiDesaCampos(true);
      cbxAjuste.Text = "POSITIVO";
      tbQtde.Text = "1";
      tbEmb.Text = "1";
      lblTotalAjuste.Text = "1";
      tbCodigo.Focus();
      butNovo.Enabled = false;
      butCancelar.Enabled = true;
      this.CancelButton = butCancelar;
    }

    private void butCancelar_Click(object sender, EventArgs e)
    {
      DialogResult res = MessageBox.Show("Deseja realmente cancelar a operação?", "Cancelar Operação", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
      if (res == DialogResult.Yes)
      {
        this.LimparCampos();
        this.HabiDesaCampos(false);
        this.OrganizaBotoes();
        this.CancelButton = butSair;
        butNovo.Focus();
      }
    }

    private void btnPesquisar_Click(object sender, EventArgs e)
    {
      tbCodigo.Clear();
      lblDescricao.Text = "";
      gridProd = new FormGridProdutos(this, "ajuste");
      gridProd.MdiParent = this.ParentForm;
      gridProd.Show();
    }

    private void tbQtde_TextChanged(object sender, EventArgs e)
    {
      if (tbQtde.Text.Length != 0 && tbEmb.Text.Length != 0)
      {
        int total = Convert.ToInt32(tbQtde.Text) * Convert.ToInt32(tbEmb.Text);
        lblTotalAjuste.Text = Convert.ToString(total);
        if (tbCodigo.Text.Length > 0 && lblDescricao.Text.Length > 0)
        {
          butSalvar.Enabled = true;
        }
      }
      else
      {
        butSalvar.Enabled = false;
      }
    }

    private void tbEmb_TextChanged(object sender, EventArgs e)
    {
      if (tbQtde.Text.Length != 0 && tbEmb.Text.Length != 0)
      {
        int total = Convert.ToInt32(tbQtde.Text) * Convert.ToInt32(tbEmb.Text);
        lblTotalAjuste.Text = Convert.ToString(total);
        if (tbCodigo.Text.Length > 0 && lblDescricao.Text.Length > 0)
        {
          butSalvar.Enabled = true;
        }
      }
      else
      {
        butSalvar.Enabled = false;
      }
    }

    private void butSair_Click(object sender, EventArgs e)
    {
      this.Close();
    }

    private void tbCodigo_Leave(object sender, EventArgs e)
    {
      if (tbCodigo.Text.Length != 0)
      {
        prod = new Produtos();
        prod.Id = Convert.ToInt32(tbCodigo.Text);
        prod.LocalizaProduto();
        if (prod.Descricao != null)
        {
          lblDescricao.Text = prod.Descricao;
          cbxAjuste.Focus();
          butSalvar.Enabled = true;
        }
        else
        {
          tbCodigo.Clear();
          lblDescricao.Text = "";
          butSalvar.Enabled = false;
          tbCodigo.Select();
        }
      }
    }

    private void tbQtde_KeyPress(object sender, KeyPressEventArgs e)
    {
      if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8)
      {
        e.Handled = true;
      }
    }

    private void tbEmb_KeyPress(object sender, KeyPressEventArgs e)
    {
      if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8)
      {
        e.Handled = true;
      }
    }

    private void butSalvar_Click(object sender, EventArgs e)
    {
      DialogResult res = MessageBox.Show("Confirma o ajuste de estoque?", "Ajuste de Estoque", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
      if (res == DialogResult.Yes)
      {
        prod = new Produtos();
        prod.Id = Convert.ToInt32(tbCodigo.Text);
        prod.Usuario = usuario;
        prod.AtualizarEstoque("AJUSTE MANUAL - " + cbxAjuste.Text + ", " + tbObs.Text, cbxAjuste.Text, Convert.ToInt32(lblTotalAjuste.Text));
        prod.Call_SP_EstadoProduto();

        this.LimparCampos();
        this.HabiDesaCampos(false);
        this.OrganizaBotoes();
        this.CancelButton = butSair;
        butNovo.Focus();
      }
    }

    private void FormAjuEstoque_KeyDown(object sender, KeyEventArgs e)
    {
      if (e.KeyCode == Keys.F6)
      {
        if (btnPesquisar.Enabled)
        {
          gridProd = new FormGridProdutos(this, "ajuste");
          gridProd.MdiParent = this.ParentForm;
          gridProd.Show();
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

    private void tbCodigo_KeyPress(object sender, KeyPressEventArgs e)
    {
      if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8)
      {
        e.Handled = true;
      }
    }

    private void cbxAjuste_DropDownClosed(object sender, EventArgs e)
    {
      tbQtde.Focus();
    }
  }
}
