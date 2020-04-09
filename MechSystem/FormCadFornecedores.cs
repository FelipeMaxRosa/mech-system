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
  public partial class FormCadFornecedores : Form
  {
    //Atributos
    //-----------------------------------------------------------------------
    private bool novoFornecedor = false;
    int cadastrovalido = 0;

    //Construtor
    //-----------------------------------------------------------------------
    public FormCadFornecedores(FormPrincipal parent)
    {
        InitializeComponent();
        this.MdiParent = parent;
        tbCodigo.Focus();
    }

    //Metodos_Gerais
    //-----------------------------------------------------------------------
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

    private void LimparCampos()
    {
      tbBairro.Clear();
      tbCep.Clear();
      tbCidade.Clear();
      tbCodigo.Clear();
      tbCpfCnpj.Clear();
      tbEmail.Clear();
      tbEndereco.Clear();
      tbFantasia.Clear();
      tbIE.Clear();
      tbNumero.Clear();
      tbObs.Clear();
      tbRamal1.Clear();
      tbRamal2.Clear();
      tbRazaoSocial.Clear();
      tbTel1.Clear();
      tbTel2.Clear();
      tbUF.Clear();
    }

    private void HabiDesaCampos(bool flag)
    {
      //Read_Only
      tbBairro.ReadOnly = !flag;
      tbCep.ReadOnly = !flag;
      tbCidade.ReadOnly = !flag;
      tbCodigo.ReadOnly = flag;
      tbCpfCnpj.ReadOnly = !flag;
      tbEmail.ReadOnly = !flag;
      tbEndereco.ReadOnly = !flag;
      tbFantasia.ReadOnly = !flag;
      tbIE.ReadOnly = !flag;
      tbNumero.ReadOnly = !flag;
      tbObs.ReadOnly = !flag;
      tbRamal1.ReadOnly = !flag;
      tbRamal2.ReadOnly = !flag;
      tbRazaoSocial.ReadOnly = !flag;
      tbTel1.ReadOnly = !flag;
      tbTel2.ReadOnly = !flag;
      tbUF.ReadOnly = !flag;

      //Tab_Stop
      tbBairro.TabStop = flag;
      tbCep.TabStop = flag;
      tbCidade.TabStop = flag;
      tbCodigo.TabStop = !flag;
      tbCpfCnpj.TabStop = flag;
      tbEmail.TabStop = flag;
      tbEndereco.TabStop = flag;
      tbFantasia.TabStop = flag;
      tbIE.TabStop = flag;
      tbNumero.TabStop = flag;
      tbObs.TabStop = flag;
      tbRamal1.TabStop = flag;
      tbRamal2.TabStop = flag;
      tbRazaoSocial.TabStop = flag;
      tbTel1.TabStop = flag;
      tbTel2.TabStop = flag;
      tbUF.TabStop = flag;
    }

    //Metodos_Eventos
    //-----------------------------------------------------------------------
    private void butSair_Click(object sender, EventArgs e)
    {
      this.Close();
    }

    private void butNovo_Click(object sender, EventArgs e)
    {
      novoFornecedor = true;
      this.LimparCampos();
      this.HabiDesaCampos(true);
      butNovo.Enabled = false;
      butCancelar.Enabled = true;
      butConsultar.Enabled = false;
      butAlterar.Enabled = false;
      butExcluir.Enabled = false;
      btnConsultaGeral.Enabled = false;
      tbRazaoSocial.Focus();
      this.CancelButton = butCancelar;
    }

    private void butCancelar_Click(object sender, EventArgs e)
    {
        DialogResult res = MessageBox.Show("Deseja realmente cancelar a operação?", "AutoMecanica JM", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
        if (res == DialogResult.Yes)
        {
          this.LimparCampos();
          this.HabiDesaCampos(false);
          this.OrganizaBotoes();
          tbCodigo.Focus();
          this.CancelButton = butSair;
          novoFornecedor = false;
        }
    }

    private void butSalvar_Click(object sender, EventArgs e)
    {
      Fornecedor forn = new Fornecedor();

      forn.Bairro = tbBairro.Text;
      forn.Cep = tbCep.Text;
      forn.Cidade = tbCidade.Text;
      forn.Cnpj = tbCpfCnpj.Text;
      forn.Email = tbEmail.Text;
      forn.Endereco = tbEndereco.Text;
      forn.Ie = tbIE.Text;
      forn.NomeFantasia = tbFantasia.Text;
      forn.Numero = tbNumero.Text;
      forn.Obs = tbObs.Text;
      forn.Ramal1 = tbRamal1.Text;
      forn.Ramal2 = tbRamal2.Text;
      forn.RazaoSocial = tbRazaoSocial.Text;
      forn.Tel1 = tbTel1.Text;
      forn.Tel2 = tbTel2.Text;
      forn.Uf = tbUF.Text;

      if (novoFornecedor)
      {
        DialogResult res = MessageBox.Show("Confirma inclusão do registro?", "Novo Registro", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
        if (res == DialogResult.Yes)
        {
          forn.InserirFornecedor();

          DataSet ds = forn.BuscaCodigo();
          tbCodigo.Text = Convert.ToString(ds.Tables[0].Rows[0]["id"]);
          this.HabiDesaCampos(false);
          this.OrganizaBotoes();
          tbCodigo.Focus();
          tbCodigo.SelectAll();
          this.CancelButton = butSair;
          butAlterar.Enabled = true;
          butExcluir.Enabled = true;
        }
      }
      else
      {
        DialogResult res = MessageBox.Show("Confirma a alteração do registro?", "Atualização", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
        if (res == DialogResult.Yes)
        {
          forn.AlterarCadastro();
          this.HabiDesaCampos(false);
          this.OrganizaBotoes();
          tbCodigo.Focus();
          tbCodigo.SelectAll();
          this.CancelButton = butSair;
          butAlterar.Enabled = true;
          butExcluir.Enabled = true;
        }
      }
    }

    private void tbCpfCnpj_Leave(object sender, EventArgs e)
    {
      if (tbCpfCnpj.Text.Length == 18)
      {
        Fornecedor forn = new Fornecedor();
        forn.Cnpj = tbCpfCnpj.Text;
        bool cadastrado = forn.VerificaCadastro();

        if (cadastrado)
        {
          MessageBox.Show("CNPJ já cadastrado para outro fornecedor!", "Validação de CNPJ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
          tbCpfCnpj.Focus();
          tbCpfCnpj.SelectAll();
        }
        else
        {
          ValidaCNPJ val = new ValidaCNPJ();
          bool valido = val.ValidaCnpj(tbCpfCnpj.Text);
          if (valido)
          {
            butSalvar.Enabled = true;
          }
          else
          {
            MessageBox.Show("Número de CNPJ inválido, digite novamente...", "Validação de CNPJ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            tbCpfCnpj.Focus();
            tbCpfCnpj.SelectAll();
            butSalvar.Enabled = false;
          }
        }
      }
      else
      {
        tbCpfCnpj.Clear();
        butSalvar.Enabled = false;
      }
    }

    private void butConsultar_Click(object sender, EventArgs e)
    {
      Fornecedor forn = new Fornecedor();

      if (tbCodigo.Text.Length == 0)
      {
        LimparCampos();
        OrganizaBotoes();
        butAlterar.Enabled = false;
        FormGridFornecedores grid = new FormGridFornecedores(this, "fornecedores");
        grid.MdiParent = this.ParentForm;
        grid.Show();
      }
      else
      {
        forn.IdFornecedor = Convert.ToInt32(tbCodigo.Text);
        forn.LocalizaFornecedor();
        if (forn.Cnpj != null)
        {
          tbBairro.Text = forn.Bairro;
          tbCep.Text = forn.Cep;
          tbCidade.Text = forn.Cidade;
          tbCpfCnpj.Text = forn.Cnpj;
          tbEmail.Text = forn.Email;
          tbEndereco.Text = forn.Endereco;
          tbFantasia.Text = forn.NomeFantasia;
          tbIE.Text = forn.Ie;
          tbNumero.Text = forn.Numero;
          tbObs.Text = forn.Obs;
          tbRamal1.Text = forn.Ramal1;
          tbRamal2.Text = forn.Ramal2;
          tbRazaoSocial.Text = forn.RazaoSocial;
          tbTel1.Text = forn.Tel1;
          tbTel2.Text = forn.Tel2;
          tbUF.Text = forn.Uf;
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

    private void tbCodigo_KeyPress(object sender, KeyPressEventArgs e)
    {
      if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8)
      {
        e.Handled = true;
      }
    }

    private void tbIE_KeyPress(object sender, KeyPressEventArgs e)
    {
      if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8 && e.KeyChar != '.')
      {
        e.Handled = true;
      }
    }

    private void tbNumero_KeyPress(object sender, KeyPressEventArgs e)
    {
      if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8)
      {
        e.Handled = true;
      }
    }

    private void tbRamal1_KeyPress(object sender, KeyPressEventArgs e)
    {
      if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8)
      {
        e.Handled = true;
      }
    }

    private void tbRamal2_KeyPress(object sender, KeyPressEventArgs e)
    {
      if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8)
      {
        e.Handled = true;
      }
    }

    private void butAlterar_Click(object sender, EventArgs e)
    {
      novoFornecedor = false;
      this.HabiDesaCampos(true);
      tbCpfCnpj.ReadOnly = true;
      tbCpfCnpj.TabStop = false;
      butAlterar.Enabled = false;
      butCancelar.Enabled = true;
      butConsultar.Enabled = false;
      butExcluir.Enabled = false;
      butNovo.Enabled = false;
      butSalvar.Enabled = true;
      btnConsultaGeral.Enabled = false;
      tbRazaoSocial.Focus();
      this.CancelButton = butCancelar;
    }

    private void butExcluir_Click(object sender, EventArgs e)
    {
      DialogResult res = MessageBox.Show("Confirma a exclusão do registro?", "Exclusão", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
      if (res == DialogResult.Yes)
      {
        Fornecedor forn = new Fornecedor();
        forn.IdFornecedor = Convert.ToInt32(tbCodigo.Text);
        forn.ExcluirFornecedor();
        this.LimparCampos();
        this.HabiDesaCampos(false);
        this.OrganizaBotoes();
        tbCodigo.Focus();
      }
    }

    private void btnConsGeral_Click(object sender, EventArgs e)
    {
      LimparCampos();
      OrganizaBotoes();
      butAlterar.Enabled = false;
      FormGridFornecedores grid = new FormGridFornecedores(this, "fornecedores");
      grid.MdiParent = this.ParentForm;
      grid.Show();
    }

    private void FormCadFornecedores_KeyDown(object sender, KeyEventArgs e)
    {
      if (e.KeyCode == Keys.F6)
      {
        if (btnConsultaGeral.Enabled)
        {
          LimparCampos();
          OrganizaBotoes();
          butAlterar.Enabled = false;
          FormGridFornecedores grid = new FormGridFornecedores(this, "fornecedores");
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
        Fornecedor forn = new Fornecedor();
        forn.IdFornecedor = Convert.ToInt32(tbCodigo.Text);
        forn.LocalizaFornecedor();
        if (forn.Cnpj != null)
        {
          tbBairro.Text = forn.Bairro;
          tbCep.Text = forn.Cep;
          tbCidade.Text = forn.Cidade;
          tbCpfCnpj.Text = forn.Cnpj;
          tbEmail.Text = forn.Email;
          tbEndereco.Text = forn.Endereco;
          tbFantasia.Text = forn.NomeFantasia;
          tbIE.Text = forn.Ie;
          tbNumero.Text = forn.Numero;
          tbObs.Text = forn.Obs;
          tbRamal1.Text = forn.Ramal1;
          tbRamal2.Text = forn.Ramal2;
          tbRazaoSocial.Text = forn.RazaoSocial;
          tbTel1.Text = forn.Tel1;
          tbTel2.Text = forn.Tel2;
          tbUF.Text = forn.Uf;
          butAlterar.Enabled = true;
          butExcluir.Enabled = true;
          butNovo.Focus();
        }
        else
        {
          this.LimparCampos();
          this.OrganizaBotoes();
          tbCodigo.Select();
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

    private void tbUF_KeyPress(object sender, KeyPressEventArgs e)
    {
      if (!Char.IsLetter(e.KeyChar) && e.KeyChar != (char)8)
      {
        e.Handled = true;
      }
    }
  }
}
