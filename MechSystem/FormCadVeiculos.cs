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
  public partial class FormCadVeiculos : Form
  {
    //Atributos
    //--------------------------------------------------------------------------
    private bool novoVeiculo = false;
    public bool req_placa = false;
    public bool req_codProp = false;
    public string usuarioAtual;
    private FormPrincipal frmPri;

    //Construtor
    //--------------------------------------------------------------------------
    public FormCadVeiculos(FormPrincipal parent)
    {
      InitializeComponent();
      frmPri = parent;
      this.MdiParent = parent;
      tbPlacaCarro.Focus();
    }

    //Metodos Gerais
    //--------------------------------------------------------------------------
    private void OrganizaBotoes()
    {
      butAlterar.Enabled = false;
      butCancelar.Enabled = false;
      butConsultar.Enabled = true;
      butExcluir.Enabled = false;
      butNovo.Enabled = true;
      butSair.Enabled = true;
      butSalvar.Enabled = false;
      butAbrirOs.Enabled = false;
      btnConsGeral.Enabled = true;
    }

    private void LimparCamposVeiculo()
    {
      tbPlacaCarro.Clear();
      tbAnoCarro.Clear();
      tbCorCarro.Clear();
      tbMarcaCarro.Clear();
      tbModeloCarro.Clear();
    }

    private void LimparCamposProprietario()
    {
      tbApelidoProprietario.Clear();
      //tbCodigoProprietario.Clear();
      tbCpfCnpj.Clear();
      tbNomeProprietario.Clear();
      tbObs.Clear();
      tbRamal1.Clear();
      tbRamal2.Clear();
      tbRgIeProprietario.Clear();
      tbTelefone1.Clear();
      tbTelefone2.Clear();
    }

    private void HabiDesaCampos(bool flag)
    { 
      //Read_Only
      tbAnoCarro.ReadOnly = !flag;
      tbCodigoProprietario.ReadOnly = !flag;
      tbCorCarro.ReadOnly = !flag;
      tbMarcaCarro.ReadOnly = !flag;
      tbModeloCarro.ReadOnly = !flag;

      //Tab_Stop
      tbAnoCarro.TabStop = flag;
      tbCodigoProprietario.TabStop = flag;
      tbCorCarro.TabStop = flag;
      tbMarcaCarro.TabStop = flag;
      tbModeloCarro.TabStop = flag;


      //Enabled
      radPessoaFisica.Enabled = flag;
      radPessoaJuridica.Enabled = flag;
      btnConsProprietario.Enabled = flag;
    }

    public void VerificaRequisitos()
    {
      if (req_codProp == true && req_placa == true)
      {
        butSalvar.Enabled = true;
      }
      else
      {
        butSalvar.Enabled = false;
      }
    }

    //Metodos Eventos
    //--------------------------------------------------------------------------
    private void butSair_Click(object sender, EventArgs e)
    {
      this.Close();
    }

    private void tbPlacaCarro_TextChanged(object sender, EventArgs e)
    {
      if (tbPlacaCarro.Text.Length == 8)
      {
        tbMarcaCarro.Focus();
      }
    }

    private void butConsultar_Click(object sender, EventArgs e)
    {
      Cliente cli = new Cliente();
      PessoaFisica cliPf = new PessoaFisica();
      PessoaJuridica cliPj = new PessoaJuridica();
      Veiculo vei = new Veiculo();

      if (tbPlacaCarro.Text.Length < 8)
      {
        this.LimparCamposProprietario();
        this.LimparCamposVeiculo();
        this.OrganizaBotoes();
        tbCodigoProprietario.Clear();
        tbPlacaCarro.Focus();
        FormGridVeiculos grid = new FormGridVeiculos(this, "veiculos");
        grid.MdiParent = this.ParentForm;
        grid.Show();
      }
      else
      {
        vei.Placa = tbPlacaCarro.Text;
        vei.ConsultarVeiculo();

        if (vei.Marca != null)
        {
          tbCorCarro.Text = vei.Cor;
          tbAnoCarro.Text = vei.Ano;
          tbCodigoProprietario.Text = Convert.ToString(vei.IdCliente);
          tbMarcaCarro.Text = vei.Marca;
          tbModeloCarro.Text = vei.Modelo;
          tbPlacaCarro.Text = vei.Placa.ToUpper();

          cli.IdCliente = vei.IdCliente;
          cli.LocalizaCliente();

          if (cli.Cnpj == "")
          {
            cliPf.Cpf = cli.Cpf;
            cliPf.ConsultarRegistro();
            radPessoaFisica.Checked = true;
            tbApelidoProprietario.Text = cliPf.Apelido;
            tbCpfCnpj.Text = cliPf.Cpf;
            tbNomeProprietario.Text = cliPf.Nome;
            tbObs.Text = cli.Obs;
            tbRamal1.Text = cli.Ramal1;
            tbRamal2.Text = cli.Ramal2;
            tbRgIeProprietario.Text = cliPf.Rg;
            tbTelefone1.Text = cli.Telefone1;
            tbTelefone2.Text = cli.Telefone2;

            butExcluir.Enabled = true;
            butAlterar.Enabled = true;
            butSalvar.Enabled = false;
            butAbrirOs.Enabled = true;
            tbPlacaCarro.Focus();
            tbPlacaCarro.SelectAll();
          }
          else if (cli.Cpf == "")
          {
            cliPj.Cnpj = cli.Cnpj;
            cliPj.ConsultarRegistro();
            radPessoaJuridica.Checked = true;
            tbApelidoProprietario.Text = cliPj.Nomefantasia;
            tbCpfCnpj.Text = cliPj.Cnpj;
            tbNomeProprietario.Text = cliPj.Razaosocial;
            tbObs.Text = cli.Obs;
            tbRamal1.Text = cli.Ramal1;
            tbRamal2.Text = cli.Ramal2;
            tbRgIeProprietario.Text = cliPf.Rg;
            tbTelefone1.Text = cli.Telefone1;
            tbTelefone2.Text = cli.Telefone2;

            butExcluir.Enabled = true;
            butAlterar.Enabled = true;
            butSalvar.Enabled = false;
            butAbrirOs.Enabled = true;
            tbPlacaCarro.Focus();
            tbPlacaCarro.SelectAll();
          }
          else
          {
            this.LimparCamposProprietario();
            this.LimparCamposVeiculo();
            this.OrganizaBotoes();
          }
          tbPlacaCarro.SelectAll();
        }
        else
        {
          this.LimparCamposProprietario();
          this.LimparCamposVeiculo();
          tbCodigoProprietario.Clear();
          this.OrganizaBotoes();
        }
      }
    }

    private void radPessoaJuridica_CheckedChanged(object sender, EventArgs e)
    {
      lblNomeRS.Text = "Razão Social:";
      lblNomeRS.Location = new Point(4, 51);
      lblApelidoNF.Text = "N. Fantasia:";
      lblApelidoNF.Location = new Point(9, 82);
      lblRgIe.Text = "IE:";
      lblRgIe.Location = new Point(234, 114);
      lblCpfCnpj.Text = "CNPJ:";
      lblCpfCnpj.Location = new Point(39, 114);
      tbCpfCnpj.Mask = "00,000,000/0000-00";
      tbRgIeProprietario.MaxLength = 15;
      this.LimparCamposProprietario();
    }

    private void radPessoaFisica_CheckedChanged(object sender, EventArgs e)
    {
      lblNomeRS.Text = "Nome:";
      lblNomeRS.Location = new Point(37, 51);
      lblApelidoNF.Text = "Apelido:";
      lblApelidoNF.Location = new Point(29, 82);
      lblRgIe.Text = "RG:";
      lblRgIe.Location = new Point(230, 114);
      lblCpfCnpj.Text = "CPF:";
      lblCpfCnpj.Location = new Point(45, 114);
      tbCpfCnpj.Mask = "000,000,000-00";
      tbRgIeProprietario.MaxLength = 12;
      this.LimparCamposProprietario();
    }

    private void FormCadVeiculos_KeyDown(object sender, KeyEventArgs e)
    {
      if (e.KeyCode == Keys.F6)
      {
        if (btnConsGeral.Enabled)
        {
          this.LimparCamposProprietario();
          this.LimparCamposVeiculo();
          this.OrganizaBotoes();
          tbCodigoProprietario.Clear();
          tbPlacaCarro.Focus();
          FormGridVeiculos grid = new FormGridVeiculos(this, "veiculos");
          grid.MdiParent = this.ParentForm;
          grid.Show();
        }
        else if (tbCodigoProprietario.Focused == true || radPessoaFisica.Focused == true || radPessoaJuridica.Focused == true)
        {
          FormGridClientes grid = new FormGridClientes(this, "veiculos");
          grid.MdiParent = this.ParentForm;
          grid.Show();
        }
      }
      else if (e.KeyCode == Keys.F2)
      {
        if (tbCodigoProprietario.Focused == true || radPessoaFisica.Focused == true || radPessoaJuridica.Focused == true)
        {
          FormCadClientes cadCli = new FormCadClientes((FormPrincipal)this.MdiParent);
          cadCli.MdiParent = this.ParentForm;
          cadCli.Show();
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

    private void butCancelar_Click(object sender, EventArgs e)
    {
      DialogResult res = MessageBox.Show("Deseja realmente cancelar a operação?", "Cancela", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
      if (res == DialogResult.Yes)
      {
        this.LimparCamposVeiculo();
        this.LimparCamposProprietario();
        tbCodigoProprietario.Clear();
        this.HabiDesaCampos(false);
        this.OrganizaBotoes();
        tbPlacaCarro.ReadOnly = false;
        tbPlacaCarro.TabStop = true;
        tbPlacaCarro.Focus();
        this.CancelButton = butSair;
        novoVeiculo = false;
      }
    }

    private void butNovo_Click(object sender, EventArgs e)
    {
      novoVeiculo = true;
      req_codProp = false;
      req_placa = false;
      this.LimparCamposVeiculo();
      this.LimparCamposProprietario();
      tbCodigoProprietario.Clear();
      this.HabiDesaCampos(true);
      radPessoaFisica.Enabled = false;
      radPessoaJuridica.Enabled = false;
      butNovo.Enabled = false;
      butCancelar.Enabled = true;
      butConsultar.Enabled = false;
      butAlterar.Enabled = false;
      butExcluir.Enabled = false;
      btnConsGeral.Enabled = false;
      butAbrirOs.Enabled = false;
      tbPlacaCarro.Focus();
      this.CancelButton = butCancelar;
    }

    private void tbCodigoProprietario_Leave_1(object sender, EventArgs e)
    {
      if (tbCodigoProprietario.Text.Length != 0)
      {
        Veiculo vei = new Veiculo();
        Cliente cli = new Cliente();
        PessoaFisica cliPf = new PessoaFisica();
        PessoaJuridica cliPj = new PessoaJuridica();

        cli.IdCliente = Convert.ToInt32(tbCodigoProprietario.Text);
        cli.LocalizaCliente();

        if (cli.Cnpj == "")
        {
          cliPf.Cpf = cli.Cpf;
          cliPf.ConsultarRegistro();
          radPessoaFisica.Checked = true;
          tbCodigoProprietario.Text = Convert.ToString(cli.IdCliente);
          tbApelidoProprietario.Text = cliPf.Apelido;
          tbCpfCnpj.Text = cliPf.Cpf;
          tbNomeProprietario.Text = cliPf.Nome;
          tbRamal1.Text = cli.Ramal1;
          tbRamal2.Text = cli.Ramal2;
          tbRgIeProprietario.Text = cliPf.Rg;
          tbTelefone1.Text = cli.Telefone1;
          tbTelefone2.Text = cli.Telefone2;
          tbObs.Text = cli.Obs;

          req_codProp = true;
          this.VerificaRequisitos();
          butSalvar.Focus();
        }
        else if (cli.Cpf == "")
        {
          cliPj.Cnpj = cli.Cnpj;
          cliPj.ConsultarRegistro();
          radPessoaJuridica.Checked = true;
          tbCodigoProprietario.Text = Convert.ToString(cli.IdCliente);
          tbCpfCnpj.Text = cliPj.Cnpj;
          tbNomeProprietario.Text = cliPj.Razaosocial;
          tbApelidoProprietario.Text = cliPj.Nomefantasia;
          tbObs.Text = cli.Obs;
          tbRamal1.Text = cli.Ramal1;
          tbRamal2.Text = cli.Ramal2;
          tbRgIeProprietario.Text = cliPj.Ie;
          tbTelefone1.Text = cli.Telefone1;
          tbTelefone2.Text = cli.Telefone2;

          req_codProp = true;
          this.VerificaRequisitos();
          butSalvar.Focus();
        }
        else
        {
          this.LimparCamposProprietario();
          tbCodigoProprietario.Focus();
          tbCodigoProprietario.SelectAll();
          req_codProp = false;
          this.VerificaRequisitos();
        }
      }
      else
      {
        this.LimparCamposProprietario();
        req_codProp = false;
        this.VerificaRequisitos();
      }
    }

    private void butSalvar_Click(object sender, EventArgs e)
    {
      Veiculo vei = new Veiculo();
      vei.Ano = tbAnoCarro.Text;
      vei.Cor = tbCorCarro.Text;
      vei.Marca = tbMarcaCarro.Text;
      vei.Modelo = tbModeloCarro.Text;
      vei.Placa = tbPlacaCarro.Text;
      vei.IdCliente = Convert.ToInt32(tbCodigoProprietario.Text);

      if (novoVeiculo)
      {
        DialogResult res = MessageBox.Show("Confirma a inserção do registro?", "Novo Registro", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
        if (res == DialogResult.Yes)
        {
          vei.InserirVeiculo();
          this.HabiDesaCampos(false);
          tbPlacaCarro.Focus();
          tbPlacaCarro.SelectAll();
          this.OrganizaBotoes();
          this.CancelButton = butSair;
          butAlterar.Enabled = true;
          butExcluir.Enabled = true;
          butAbrirOs.Enabled = true;
          novoVeiculo = false;
        }
      }
      else
      {
        DialogResult res = MessageBox.Show("Confirma a alteração do registro?", "Alteração do Registro", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
        if (res == DialogResult.Yes)
        {
          vei.AtualizarVeiculo();
          this.HabiDesaCampos(false);

          tbPlacaCarro.ReadOnly = false;
          tbPlacaCarro.TabStop = true;
          this.CancelButton = butSair;
          tbPlacaCarro.Focus();
          tbPlacaCarro.SelectAll();
          this.OrganizaBotoes();
          butAlterar.Enabled = true;
          butExcluir.Enabled = true;
          butAbrirOs.Enabled = true;
        }
      }
    }

    private void tbAnoCarro_KeyPress(object sender, KeyPressEventArgs e)
    {
      if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8)
      {
        e.Handled = true;
      }
    }

    private void tbCodigoProprietario_KeyPress(object sender, KeyPressEventArgs e)
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

    private void tbPlacaCarro_Leave_1(object sender, EventArgs e)
    {
      string placa = tbPlacaCarro.Text;
      tbPlacaCarro.Text = placa.ToUpper();
      if (tbPlacaCarro.Text.Length == 8)
      {
        Cliente cli = new Cliente();
        PessoaFisica cliPf = new PessoaFisica();
        PessoaJuridica cliPj = new PessoaJuridica();
        Veiculo vei = new Veiculo();
        vei.Placa = tbPlacaCarro.Text;
        vei.ConsultarVeiculo();
        if (novoVeiculo)
        {
          if (vei.Marca != null)
          {
            MessageBox.Show("Placa já está Cadastrada para outro Veículo!", "Consulta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            req_placa = false;
            this.VerificaRequisitos();
            tbPlacaCarro.SelectAll();
            tbPlacaCarro.Focus();
          }
          else
          {
            req_placa = true;
            this.VerificaRequisitos();
          }
        }
        else
        {
          if (vei.Marca != null)
          {
            tbCorCarro.Text = vei.Cor;
            tbAnoCarro.Text = vei.Ano;
            tbCodigoProprietario.Text = Convert.ToString(vei.IdCliente);
            tbMarcaCarro.Text = vei.Marca;
            tbModeloCarro.Text = vei.Modelo;
            tbPlacaCarro.Text = vei.Placa.ToUpper();

            cli.IdCliente = vei.IdCliente;
            cli.LocalizaCliente();
            if (cli.Cnpj == "")
            {
              cliPf.Cpf = cli.Cpf;
              cliPf.ConsultarRegistro();
              radPessoaFisica.Checked = true;
              tbApelidoProprietario.Text = cliPf.Apelido;
              tbCpfCnpj.Text = cliPf.Cpf;
              tbNomeProprietario.Text = cliPf.Nome;
              tbObs.Text = cli.Obs;
              tbRamal1.Text = cli.Ramal1;
              tbRamal2.Text = cli.Ramal2;
              tbRgIeProprietario.Text = cliPf.Rg;
              tbTelefone1.Text = cli.Telefone1;
              tbTelefone2.Text = cli.Telefone2;

              butExcluir.Enabled = true;
              butAlterar.Enabled = true;
              butSalvar.Enabled = false;
              butAbrirOs.Enabled = true;
              butNovo.Focus();
            }
            else if (cli.Cpf == "")
            {
              cliPj.Cnpj = cli.Cnpj;
              cliPj.ConsultarRegistro();
              radPessoaJuridica.Checked = true;
              tbApelidoProprietario.Text = cliPj.Nomefantasia;
              tbCpfCnpj.Text = cliPj.Cnpj;
              tbNomeProprietario.Text = cliPj.Razaosocial;
              tbObs.Text = cli.Obs;
              tbRamal1.Text = cli.Ramal1;
              tbRamal2.Text = cli.Ramal2;
              tbRgIeProprietario.Text = cliPf.Rg;
              tbTelefone1.Text = cli.Telefone1;
              tbTelefone2.Text = cli.Telefone2;

              butExcluir.Enabled = true;
              butAlterar.Enabled = true;
              butSalvar.Enabled = false;
              butAbrirOs.Enabled = true;
              butNovo.Focus();
            }
            else
            {
              this.LimparCamposProprietario();
              this.LimparCamposVeiculo();
              this.OrganizaBotoes();
            }
          }
          else
          {
            MessageBox.Show("Veículo não cadastrado!", "Mech System", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            this.LimparCamposProprietario();
            this.LimparCamposVeiculo();
            tbCodigoProprietario.Clear();
            this.OrganizaBotoes();
            tbPlacaCarro.Focus();
          }
        }
      }
      else
      {
        this.LimparCamposProprietario();
        this.LimparCamposVeiculo();
        tbCodigoProprietario.Clear();
        //this.OrganizaBotoes();
      }
    }

    private void butAlterar_Click(object sender, EventArgs e)
    {
      novoVeiculo = false;
      req_placa = true;
      this.HabiDesaCampos(true);
      radPessoaFisica.Enabled = false;
      radPessoaJuridica.Enabled = false;
      tbPlacaCarro.ReadOnly = true;
      tbPlacaCarro.TabStop = false;
      butNovo.Enabled = false;
      butCancelar.Enabled = true;
      butConsultar.Enabled = false;
      butAlterar.Enabled = false;
      butExcluir.Enabled = false;
      butSalvar.Enabled = true;
      butAbrirOs.Enabled = false;
      btnConsGeral.Enabled = false;
      tbMarcaCarro.Focus();
      this.CancelButton = butCancelar;
    }

    private void butExcluir_Click(object sender, EventArgs e)
    {
      DialogResult res = MessageBox.Show("Confirma a exclusão do registro?", "Exclusão do Registro", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
      if (res == DialogResult.Yes)
      {
        Veiculo vei = new Veiculo();

        vei.Placa = tbPlacaCarro.Text;
        vei.DeletarVeiculo();
        this.LimparCamposProprietario() ;
        this.LimparCamposVeiculo();
        tbCodigoProprietario.Clear();
        this.HabiDesaCampos(false);
        this.OrganizaBotoes();
        tbPlacaCarro.Focus();
      }
    }

    private void butAbrirOs_Click(object sender, EventArgs e)
    {
      FormCadOs os = new FormCadOs((FormPrincipal)this.ParentForm);
      os.usuarioAtual = usuarioAtual;
      os.MdiParent = this.ParentForm;
      os.Show();
      os.tbPlacaCarro.Text = tbPlacaCarro.Text;
      os.tbCodigoProprietario.Text = tbCodigoProprietario.Text;
      os.tbNomeProprietario.Text = tbNomeProprietario.Text;
      os.tbMarcaCarro.Text = tbMarcaCarro.Text;
      os.tbModeloCarro.Text = tbModeloCarro.Text;

      os.novaOs = true;
      os.HabiDesaCampoOs(true);
      os.CancelButton = butCancelar;
      os.tabControl1.SelectedTab = os.tabPage1;
      os.dtOs.Value = DateTime.Now;
      os.butNovo.Enabled = false;
      os.butCancelar.Enabled = true;
      os.butConsultar.Enabled = false;
      os.butAlterar.Enabled = false;
      os.butFinalizarOs.Enabled = false;
      os.butSalvar.Enabled = true;
      os.btnConsultaGeral.Enabled = false;
      os.tbResponsavel.Focus();
      os.CancelButton = os.butCancelar;
      this.Dispose();
    }

    private void btnConsultaGeral_Click(object sender, EventArgs e)
    {
      tbCodigoProprietario.Clear();
      this.LimparCamposProprietario();
      this.LimparCamposVeiculo();
      FormGridVeiculos grid = new FormGridVeiculos(this, "veiculos");
      grid.MdiParent = this.ParentForm;
      grid.Show();
    }

    private void tbCodigoProprietario_Enter(object sender, EventArgs e)
    {
    }

    private void btnConsGeral_Click(object sender, EventArgs e)
    {
      this.LimparCamposProprietario();
      this.LimparCamposVeiculo();
      this.OrganizaBotoes();
      tbCodigoProprietario.Clear();
      //tbPlacaCarro.Focus();
      FormGridVeiculos grid = new FormGridVeiculos(this, "veiculos");
      grid.MdiParent = this.ParentForm;
      grid.Show();
    }

    private void btnConsProprietario_Click(object sender, EventArgs e)
    {
      FormGridClientes grid = new FormGridClientes(this, "veiculos");
      grid.MdiParent = this.ParentForm;
      grid.Show();
      /*
      if (radPessoaFisica.Checked)
      {
        FormGridClientePF gridPf = new FormGridClientePF(this, "veiculos");
        gridPf.MdiParent = this.ParentForm;
        gridPf.Show();
      }
      else if (radPessoaJuridica.Checked)
      {
        FormGridClientesPJ gridPJ = new FormGridClientesPJ(this, "veiculos");
        gridPJ.MdiParent = this.ParentForm;
        gridPJ.Show();
      }
       */
    }

    private void tbPlacaCarro_Enter(object sender, EventArgs e)
    {
      tbPlacaCarro.SelectAll();
    }
  }
}
