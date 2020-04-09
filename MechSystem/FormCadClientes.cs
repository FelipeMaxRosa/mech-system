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
  public partial class FormCadClientes : Form
  {
    private bool novoCliente = false;
    private string cpfAnterior;
    private bool req_cpf = false;

    public FormCadClientes(FormPrincipal parent)
    {
      InitializeComponent();
      this.MdiParent = parent;
      cbxSituacao.Text = "ATIVO";
      tbCodigoCliente.Select();
    }

    //Métodos Gerais
    private void LimparCampos()
    {
      tbApelido.Clear();
      tbBairro.Clear();
      tbCep.Clear();
      tbCidade.Clear();
      tbCodigoCliente.Clear();
      tbCpfCnpj.Clear();
      tbEmail.Clear();
      tbEndereco.Clear();
      tbEstado.Clear();
      tbNome.Clear();
      tbNomeMae.Clear();
      tbNomePai.Clear();
      tbNumero.Clear();
      tbRamal1.Clear();
      tbRamal2.Clear();
      tbRgIe.Clear();
      tbTelefone1.Clear();
      tbTelefone2.Clear();
      tbObs.Clear();
      dtDataNascimento.Value = Convert.ToDateTime("01/01/1900");
    }

    private void HabiDesaCampos(bool flag)
    {
      //Enabled
      dtDataNascimento.Enabled = flag;
      cbxSituacao.Enabled = flag;
      radPessoaFisica.Enabled = flag;
      radPessoaJuridica.Enabled = flag;

      //Read-Only
      tbApelido.ReadOnly = !flag;
      tbBairro.ReadOnly = !flag;
      tbCep.ReadOnly = !flag;
      tbCidade.ReadOnly = !flag;
      tbCodigoCliente.ReadOnly = flag;
      tbCpfCnpj.ReadOnly = !flag;
      tbEmail.ReadOnly = !flag;
      tbEndereco.ReadOnly = !flag;
      tbEstado.ReadOnly = !flag;
      tbNome.ReadOnly = !flag;
      tbNomeMae.ReadOnly = !flag;
      tbNomePai.ReadOnly = !flag;
      tbNumero.ReadOnly = !flag;
      tbRamal1.ReadOnly = !flag;
      tbRamal2.ReadOnly = !flag;
      tbRgIe.ReadOnly = !flag;
      tbTelefone1.ReadOnly = !flag;
      tbTelefone2.ReadOnly = !flag;
      tbObs.ReadOnly = !flag;

      //TabStop
      cbxSituacao.TabStop = flag;
      tbApelido.TabStop = flag;
      tbBairro.TabStop = flag;
      tbCep.TabStop = flag;
      tbCidade.TabStop = flag;
      tbCodigoCliente.TabStop = !flag;
      tbCpfCnpj.TabStop = flag;
      dtDataNascimento.TabStop = flag;
      tbEmail.TabStop = flag;
      tbEndereco.TabStop = flag;
      tbEstado.TabStop = flag;
      tbNome.TabStop = flag;
      tbNomeMae.TabStop = flag;
      tbNomePai.TabStop = flag;
      tbNumero.TabStop = flag;
      tbRamal1.TabStop = flag;
      tbRamal2.TabStop = flag;
      tbRgIe.TabStop = flag;
      tbTelefone1.TabStop = flag;
      tbTelefone2.TabStop = flag;
      tbObs.TabStop = flag;
    }

    public void ValidarRequisitos()
    {
      if (req_cpf == true)
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

    //Métodos Eventos
    private void butSair_Click(object sender, EventArgs e)
    {
      this.Close();
    }

    private void radPessoaFisica_CheckedChanged(object sender, EventArgs e)
    {
      labNome.Text = "Nome:";
      labNome.Location = new Point(43, 53);
      labApelidoNFantasia.Text = "Apelido:";
      labApelidoNFantasia.Location = new Point(35, 81);
      labRgIe.Text = "RG:";
      labRgIe.Location = new Point(56, 109);
      labCpfCnpj.Text = "CPF:";
      labCpfCnpj.Location = new Point(227, 109);
      lblDataNasc.Visible = true;
      dtDataNascimento.Visible = true;
      tbNomeMae.Visible = true;
      lblNomeMae.Visible = true;
      tbNomeMae.Visible = true;
      lblNomePai.Visible = true;
      tbNomePai.Visible = true;
      tbCpfCnpj.Mask = "000,000,000-00";
      tbRgIe.MaxLength = 12;
      if (novoCliente)
      {
        tbNome.Focus();
      }      
    }

    private void radPessoaJuridica_CheckedChanged(object sender, EventArgs e)
    {
      labNome.Text = "Razão Social:";
      labNome.Location = new Point(10, 53);
      labApelidoNFantasia.Text = "N. Fantasia:";
      labApelidoNFantasia.Location = new Point(15, 81);
      labRgIe.Text = "IE:";
      labRgIe.Location = new Point(60, 109);
      labCpfCnpj.Text = "CNPJ:";
      labCpfCnpj.Location = new Point(220, 109);
      lblDataNasc.Visible = false;
      dtDataNascimento.Visible = false;
      tbNomeMae.Visible = false;
      lblNomeMae.Visible = false;
      tbNomeMae.Visible = false;
      lblNomePai.Visible = false;
      tbNomePai.Visible = false;
      lblRamal1.Visible = true;
      lblRamal2.Visible = true;
      tbRamal1.Visible = true;
      tbRamal2.Visible = true;
      tbCpfCnpj.Mask = "00,000,000/0000-00";
      tbRgIe.MaxLength = 15;
      if (novoCliente)
      {
        tbNome.Focus();
      }
    }

    private void butSalvar_Click(object sender, EventArgs e)
    {
      if(radPessoaFisica.Checked)
      {
        PessoaFisica cli = new PessoaFisica();
        //Armazena os Dados na Classe Cliente            
        cli.Cpf = tbCpfCnpj.Text;
        cli.Nome = tbNome.Text;
        cli.Apelido = tbApelido.Text;
        cli.Rg = tbRgIe.Text;
        cli.Cep = tbCep.Text;
        cli.Logradouro = tbEndereco.Text;
        cli.Numero = tbNumero.Text;
        cli.Bairro = tbBairro.Text;
        cli.Cidade = tbCidade.Text;
        cli.Estado = tbEstado.Text;
        cli.Nascimento = dtDataNascimento.Value;
        cli.Nomepai = tbNomePai.Text;
        cli.Nomemae = tbNomeMae.Text;
        cli.Email = tbEmail.Text;
        cli.Telefone1 = tbTelefone1.Text;
        cli.Telefone2 = tbTelefone2.Text;
        cli.Ramal1 = tbRamal1.Text;
        cli.Ramal2 = tbRamal2.Text;
        cli.Obs = tbObs.Text;
        cli.CpfAnterior = cpfAnterior;
        cli.Situacao = cbxSituacao.Text;

        if (novoCliente)
        {
          DialogResult res = MessageBox.Show("Confirma inserção do registro?", "Novo Registro", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
          if (res == DialogResult.Yes)
          {
            cli.InserirCliente();
            DataSet ds = cli.BuscaCodigo();
            tbCodigoCliente.Text = Convert.ToString(ds.Tables[0].Rows[0]["ID"]);
            this.HabiDesaCampos(false);
            this.OrganizaBotoes();
            tbCodigoCliente.Focus();
            tbCodigoCliente.SelectAll();
            this.CancelButton = butSair;
            butAlterar.Enabled = true;
            butExcluir.Enabled = true;
          }
        }
        else
        {
          DialogResult res = MessageBox.Show("Confirma alteração do registro?", "Alteração", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
          if (res == DialogResult.Yes)
          {
            cli.IdCliente = Convert.ToInt32(tbCodigoCliente.Text);
            cli.AtualizarCliente();
            this.HabiDesaCampos(false);
            this.OrganizaBotoes();
            tbCodigoCliente.Focus();
            tbCodigoCliente.SelectAll();
            this.CancelButton = butSair;
            butAlterar.Enabled = true;
            butExcluir.Enabled = true;
          }
          else
          { 
          }
        }
      }
      else
      {
        PessoaJuridica cli = new PessoaJuridica();
        //Armazena os Dados na Classe Cliente
        cli.Razaosocial = tbNome.Text;
        cli.Nomefantasia = tbApelido.Text;
        cli.Cnpj = tbCpfCnpj.Text;
        cli.Ie = tbRgIe.Text;
        cli.Cep = tbCep.Text;
        cli.Logradouro = tbEndereco.Text;
        cli.Numero = tbNumero.Text;
        cli.Bairro = tbBairro.Text;
        cli.Cidade = tbCidade.Text;
        cli.Estado = tbEstado.Text;
        cli.Email = tbEmail.Text;
        cli.Telefone1 = tbTelefone1.Text;
        cli.Ramal1 = tbRamal1.Text;
        cli.Telefone2 = tbTelefone2.Text;
        cli.Ramal2 = tbRamal2.Text;
        cli.Obs = tbObs.Text;
        cli.Situacao = cbxSituacao.Text;
        if (novoCliente)
        {
          DialogResult res = MessageBox.Show("Confirma inserção do registro?", "Novo Registro", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
          if (res == DialogResult.Yes)
          {
            cli.InserirCliente();
            DataSet ds = cli.BuscaCodigo();
            tbCodigoCliente.Text = Convert.ToString(ds.Tables[0].Rows[0]["ID"]);
            this.HabiDesaCampos(false);
            this.OrganizaBotoes();
            tbCodigoCliente.Focus();
            tbCodigoCliente.SelectAll();
            this.CancelButton = butSair;
            butAlterar.Enabled = true;
          }
        }
        else
        {
          DialogResult res = MessageBox.Show("Confirma alteração do registro?", "Alteração", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
          if (res == DialogResult.Yes)
          {
            cli.IdCliente = Convert.ToInt32(tbCodigoCliente.Text);
            cli.AtualizarCliente();
            this.HabiDesaCampos(false);
            this.OrganizaBotoes();
            tbCodigoCliente.Focus();
            tbCodigoCliente.SelectAll();
            this.CancelButton = butSair;
            butAlterar.Enabled = true;
            butExcluir.Enabled = true;
          }
          else
          {
          }
        }
      }
      //radPessoaFisica.Enabled = true;
      //radPessoaJuridica.Enabled = true;
    }

    private void butNovo_Click(object sender, EventArgs e)
    {
      novoCliente = true;
      cbxSituacao.Text = "ATIVO";
      this.LimparCampos();
      this.HabiDesaCampos(true);
      butNovo.Enabled = false;
      butCancelar.Enabled = true;
      butConsultar.Enabled = false;
      butAlterar.Enabled = false;
      butExcluir.Enabled = false;
      btnConsultaGeral.Enabled = false;
      tbNome.Focus();
      this.CancelButton = butCancelar;;
    }

    private void butCancelar_Click(object sender, EventArgs e)
    {
      DialogResult res = MessageBox.Show("Deseja realmente cancelar a operação?", "Cancelar Operação", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
      if (res == DialogResult.Yes)
      {
        this.LimparCampos();
        this.HabiDesaCampos(false);
        this.OrganizaBotoes();
        tbCodigoCliente.Focus();
        this.CancelButton = butSair;
        novoCliente = false;
      }
    }

    private void tbCpfCnpj_Leave(object sender, EventArgs e)
    {
      if (novoCliente)
      {
        if (tbCpfCnpj.Text.Length == 14 || tbCpfCnpj.Text.Length == 18)
        {
          if (radPessoaFisica.Checked)
          {
            PessoaFisica cli = new PessoaFisica();
            cli.Cpf = tbCpfCnpj.Text;
            bool cadastrado = cli.VerificaCadastro();

            if (cadastrado)
            {
              MessageBox.Show("CPF já cadastrado para outro cliente!", "Validação de CPF", MessageBoxButtons.OK, MessageBoxIcon.Warning);
              tbCpfCnpj.Focus();
              tbCpfCnpj.SelectAll();
            }
            else
            {
              ValidaCPF val = new ValidaCPF();
              bool valido = val.Valida(tbCpfCnpj.Text);
              if (valido)
              {
                req_cpf = true;
                this.ValidarRequisitos();
              }
              else
              {
                MessageBox.Show("Número de CPF inválido, digite novamente...", "Validação de CPF", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                req_cpf = false;
                this.ValidarRequisitos();
                tbCpfCnpj.Focus();
                tbCpfCnpj.SelectAll();
              }

            }

          }
          else
          {
            PessoaJuridica cli = new PessoaJuridica();
            cli.Cnpj = tbCpfCnpj.Text;
            bool cadastrado = cli.VerificaCadastro();

            if (cadastrado)
            {
              MessageBox.Show("CNPJ já cadastrado para outro cliente!", "Validação de CNPJ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
              tbCpfCnpj.Focus();
              tbCpfCnpj.SelectAll();
            }
            else
            {
              ValidaCNPJ val = new ValidaCNPJ();
              bool valido = val.ValidaCnpj(tbCpfCnpj.Text);
              if (valido)
              {
                req_cpf = true;
                this.ValidarRequisitos();
              }
              else
              {
                MessageBox.Show("Número de CNPJ inválido, digite novamente...", "Validação de CNPJ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                req_cpf = false;
                this.ValidarRequisitos();
                tbCpfCnpj.Focus();
                tbCpfCnpj.SelectAll();
              }
            }
          }
        }
        else
        {
          tbCpfCnpj.Clear();
          req_cpf = false;
          this.ValidarRequisitos();
        }
      }
      else
      { 

      }
    }

    private void butConsultar_Click(object sender, EventArgs e)
    {
      Cliente cli = new Cliente();
      PessoaFisica cliPf = new PessoaFisica();
      PessoaJuridica cliPj = new PessoaJuridica();
      
      if (tbCodigoCliente.Text.Length == 0)
      {
        LimparCampos();
        OrganizaBotoes();
        FormGridClientes grid = new FormGridClientes(this, "clientes");
        grid.MdiParent = this.ParentForm;
        grid.Show();
      }
      else
      {
        cli.IdCliente = Convert.ToInt32(tbCodigoCliente.Text);
        cli.LocalizaCliente();
        if (cli.Cnpj == "")
        {
          cliPf.Cpf = cli.Cpf;
          cliPf.ConsultarRegistro();
          radPessoaFisica.Checked = true;
          tbApelido.Text = cliPf.Apelido;
          tbBairro.Text = cli.Bairro;
          tbCep.Text = cli.Cep;
          tbCidade.Text = cli.Cidade;
          tbCpfCnpj.Text = cliPf.Cpf;
          dtDataNascimento.Value = cliPf.Nascimento;
          tbEmail.Text = cli.Email;
          tbEndereco.Text = cli.Logradouro;
          tbEstado.Text = cli.Estado;
          tbNome.Text = cliPf.Nome;
          tbNomeMae.Text = cliPf.Nomemae;
          tbNomePai.Text = cliPf.Nomepai;
          tbNumero.Text = cli.Numero;
          tbRamal1.Text = cli.Ramal1;
          tbRamal2.Text = cli.Ramal2;
          tbRgIe.Text = cliPf.Rg;
          tbTelefone1.Text = cli.Telefone1;
          tbTelefone2.Text = cli.Telefone2;
          tbObs.Text = cli.Obs;
          cbxSituacao.Text = cli.Situacao;

          butAlterar.Enabled = true;
          butExcluir.Enabled = true;
        }
        else if (cli.Cpf == "")
        {
          cliPj.Cnpj = cli.Cnpj;
          cliPj.ConsultarRegistro();
          radPessoaJuridica.Checked = true;
          tbBairro.Text = cli.Bairro;
          tbCep.Text = cli.Cep;
          tbCidade.Text = cli.Cidade;
          tbCpfCnpj.Text = cliPj.Cnpj;
          tbEmail.Text = cli.Email;
          tbEndereco.Text = cli.Logradouro;
          tbEstado.Text = cli.Estado;
          tbNome.Text = cliPj.Razaosocial;
          tbApelido.Text = cliPj.Nomefantasia;
          tbNumero.Text = cli.Numero;
          tbObs.Text = cli.Obs;
          tbRamal1.Text = cli.Ramal1;
          tbRamal2.Text = cli.Ramal2;
          tbRgIe.Text = cliPj.Ie;
          tbTelefone1.Text = cli.Telefone1;
          tbTelefone2.Text = cli.Telefone2;
          cbxSituacao.Text = cli.Situacao;

          butAlterar.Enabled = true;
          butExcluir.Enabled = true;
        }
        else 
        {
            this.LimparCampos();
            this.OrganizaBotoes();
        }
        tbCodigoCliente.SelectAll();
      }  
    }

    private void butAlterar_Click(object sender, EventArgs e)
    {
      cpfAnterior = tbCpfCnpj.Text;
      novoCliente = false;
      butAlterar.Enabled = false;
      butCancelar.Enabled = true;
      butConsultar.Enabled = false;
      butExcluir.Enabled = false;
      butNovo.Enabled = false;
      butSalvar.Enabled = true;
      btnConsultaGeral.Enabled = false;
      HabiDesaCampos(true);
      radPessoaFisica.Enabled = false;
      radPessoaJuridica.Enabled = false;
      tbCpfCnpj.ReadOnly = true;
      tbCpfCnpj.TabStop = false;
      cbxSituacao.Focus();
      this.CancelButton = butCancelar;
    }

    private void butExcluir_Click(object sender, EventArgs e)
    {
      if (radPessoaFisica.Checked)
      {
        DialogResult res = MessageBox.Show("Confirma exclusão do registro?", "Exclusão", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
        if (res == DialogResult.Yes)
        {
          PessoaFisica cli = new PessoaFisica();
          cli.IdCliente = Convert.ToInt32(tbCodigoCliente.Text);
          cli.Cpf = tbCpfCnpj.Text;
          cli.ExcluirCliente();

          this.LimparCampos();
          this.HabiDesaCampos(false);
          this.OrganizaBotoes();
          tbCodigoCliente.Focus();
        }
      }
      else if (radPessoaJuridica.Checked)
      {
        DialogResult res = MessageBox.Show("Confirma exclusão do registro?", "Exclusão", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
        if (res == DialogResult.Yes)
        {
          PessoaJuridica cli = new PessoaJuridica();
          cli.IdCliente = Convert.ToInt32(tbCodigoCliente.Text);
          cli.Cnpj = tbCpfCnpj.Text;
          cli.ExcluirCliente();
          this.LimparCampos();
          this.HabiDesaCampos(false);
          this.OrganizaBotoes();
          tbCodigoCliente.Focus();
        }
      }
    }

    private void tbCodigoCliente_KeyPress(object sender, KeyPressEventArgs e)
    {
      if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8)
      {
        e.Handled = true;
      }
    }

    private void tbRgIe_KeyPress(object sender, KeyPressEventArgs e)
    {
      if (!Char.IsLetterOrDigit(e.KeyChar) && e.KeyChar != (char)8)
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

    private void btnConsultaGeral_Click(object sender, EventArgs e)
    {
      LimparCampos();
      OrganizaBotoes();
      FormGridClientes grid = new FormGridClientes(this, "clientes");
      grid.MdiParent = this.ParentForm;
      grid.Show();
    }

    private void FormCadClientes_KeyDown(object sender, KeyEventArgs e)
    {
      if (e.KeyCode == Keys.F6)
      {
        if (btnConsultaGeral.Enabled == true)
        {
          LimparCampos();
          OrganizaBotoes();
          FormGridClientes grid = new FormGridClientes(this, "clientes");
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

    private void tbCodigoCliente_Leave(object sender, EventArgs e)
    {
      if (tbCodigoCliente.Text.Length != 0)
      {
        Cliente cli = new Cliente();
        PessoaFisica cliPf = new PessoaFisica();
        PessoaJuridica cliPj = new PessoaJuridica();
        cli.IdCliente = Convert.ToInt32(tbCodigoCliente.Text);
        cli.LocalizaCliente();
        if (cli.Cnpj == "")
        {
          cliPf.Cpf = cli.Cpf;
          cliPf.ConsultarRegistro();
          radPessoaFisica.Checked = true;
          tbApelido.Text = cliPf.Apelido;
          tbBairro.Text = cli.Bairro;
          tbCep.Text = cli.Cep;
          tbCidade.Text = cli.Cidade;
          tbCpfCnpj.Text = cliPf.Cpf;
          dtDataNascimento.Value = cliPf.Nascimento;
          tbEmail.Text = cli.Email;
          tbEndereco.Text = cli.Logradouro;
          tbEstado.Text = cli.Estado;
          tbNome.Text = cliPf.Nome;
          tbNomeMae.Text = cliPf.Nomemae;
          tbNomePai.Text = cliPf.Nomepai;
          tbNumero.Text = cli.Numero;
          tbRamal1.Text = cli.Ramal1;
          tbRamal2.Text = cli.Ramal2;
          tbRgIe.Text = cliPf.Rg;
          tbTelefone1.Text = cli.Telefone1;
          tbTelefone2.Text = cli.Telefone2;
          tbObs.Text = cli.Obs;
          cbxSituacao.Text = cli.Situacao;

          butAlterar.Enabled = true;
          butExcluir.Enabled = true;
          butNovo.Focus();
        }
        else if (cli.Cpf == "")
        {
          cliPj.Cnpj = cli.Cnpj;
          cliPj.ConsultarRegistro();
          radPessoaJuridica.Checked = true;
          tbBairro.Text = cli.Bairro;
          tbCep.Text = cli.Cep;
          tbCidade.Text = cli.Cidade;
          tbCpfCnpj.Text = cliPj.Cnpj;
          tbEmail.Text = cli.Email;
          tbEndereco.Text = cli.Logradouro;
          tbEstado.Text = cli.Estado;
          tbNome.Text = cliPj.Razaosocial;
          tbApelido.Text = cliPj.Nomefantasia;
          tbNumero.Text = cli.Numero;
          tbObs.Text = cli.Obs;
          tbRamal1.Text = cli.Ramal1;
          tbRamal2.Text = cli.Ramal2;
          tbRgIe.Text = cliPj.Ie;
          tbTelefone1.Text = cli.Telefone1;
          tbTelefone2.Text = cli.Telefone2;
          cbxSituacao.Text = cli.Situacao;

          butAlterar.Enabled = true;
          butExcluir.Enabled = true;
          butNovo.Focus();
        }
        else 
        {
          this.LimparCampos();
          this.OrganizaBotoes();
          tbCodigoCliente.Focus();
        }
      }
      else
      {
        this.LimparCampos();
        this.OrganizaBotoes();
      }
    }

    private void tbCodigoCliente_Enter(object sender, EventArgs e)
    {
      tbCodigoCliente.SelectAll();
    }

    private void tbEstado_KeyPress(object sender, KeyPressEventArgs e)
    {
      if (!Char.IsLetter(e.KeyChar) && e.KeyChar != (char)8)
      {
        e.Handled = true;
      }
    }
  }
}
