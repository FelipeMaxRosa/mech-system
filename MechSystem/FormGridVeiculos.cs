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
  public partial class FormGridVeiculos : Form
  {
    private DataSet ds;
    private BancoDados bd;
    private FormCadVeiculos frm;
    private FormCadOs frmOs;

    public FormGridVeiculos(object frm1, string tipoobj)
    {
      InitializeComponent();
      bd = new BancoDados();
      if (tipoobj == "veiculos")
      {
        frm = (FormCadVeiculos)frm1;
      }
      else if (tipoobj == "os")
      {
        frmOs = (FormCadOs)frm1;
      }
      tbPlacaCarro.Focus();
    }

    private void FormGridVeiculos_Load(object sender, EventArgs e)
    {
      string SQL = "SELECT * FROM carro ORDER BY placa";
      string tabela = "carro";
      ds = new DataSet();
      ds = bd.ConsultarParaGrid(SQL, tabela);
      dataGridView1.DataSource = ds.Tables["carro"];
    }

    private void butSair_Click(object sender, EventArgs e)
    {
      if (frm != null)
      {
        frm.butAbrirOs.Enabled = false;
        frm.tbPlacaCarro.Focus();
      }
      else if (frmOs != null)
      {
        frmOs.tbPlacaCarro.Focus();
      }
      this.Close();
    }

    private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
    {
      if (e.RowIndex < 0)
      {
      }
      else
      {
        if (frm != null)
        {
          frm.tbPlacaCarro.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
          frm.tbMarcaCarro.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
          frm.tbModeloCarro.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
          frm.tbCorCarro.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
          frm.tbAnoCarro.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
          frm.tbCodigoProprietario.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
          Cliente cli = new Cliente();
          PessoaFisica cliPf = new PessoaFisica();
          PessoaJuridica cliPj = new PessoaJuridica();
          cli.IdCliente = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[5].Value);
          cli.LocalizaCliente();

          if (cli.Cnpj == "")
          {
            cliPf.Cpf = cli.Cpf;
            cliPf.ConsultarRegistro();
            frm.radPessoaFisica.Checked = true;
            frm.tbApelidoProprietario.Text = cliPf.Apelido;
            frm.tbCpfCnpj.Text = cliPf.Cpf;
            frm.tbNomeProprietario.Text = cliPf.Nome;
            frm.tbObs.Text = cli.Obs;
            frm.tbRamal1.Text = cli.Ramal1;
            frm.tbRamal2.Text = cli.Ramal2;
            frm.tbRgIeProprietario.Text = cliPf.Rg;
            frm.tbTelefone1.Text = cli.Telefone1;
            frm.tbTelefone2.Text = cli.Telefone2;
            frm.req_codProp = true;
            frm.VerificaRequisitos();
          }
          else if (cli.Cpf == "")
          {
            cliPj.Cnpj = cli.Cnpj;
            cliPj.ConsultarRegistro();
            frm.radPessoaJuridica.Checked = true;
            frm.tbApelidoProprietario.Text = cliPj.Nomefantasia;
            frm.tbCpfCnpj.Text = cliPj.Cnpj;
            frm.tbNomeProprietario.Text = cliPj.Razaosocial;
            frm.tbObs.Text = cli.Obs;
            frm.tbRamal1.Text = cli.Ramal1;
            frm.tbRamal2.Text = cli.Ramal2;
            frm.tbRgIeProprietario.Text = cliPf.Rg;
            frm.tbTelefone1.Text = cli.Telefone1;
            frm.tbTelefone2.Text = cli.Telefone2;
            frm.req_codProp = true;
            frm.VerificaRequisitos();
          }

          frm.butAlterar.Enabled = true;
          frm.butExcluir.Enabled = true;
          frm.butSalvar.Enabled = false;
          frm.butAbrirOs.Enabled = true;
          frm.butNovo.Focus();
        }
        else if (frmOs != null)
        { 
          frmOs.tbPlacaCarro.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
          frmOs.tbMarcaCarro.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
          frmOs.tbModeloCarro.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
          frmOs.tbCodigoProprietario.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
          Cliente cli = new Cliente();
          cli.IdCliente = Convert.ToInt32(frmOs.tbCodigoProprietario.Text);
          cli.LocalizaCliente();
          if (cli.Cnpj == "")
          {
            PessoaFisica cliPf = new PessoaFisica();
            cliPf.Cpf = cli.Cpf;
            cliPf.ConsultarRegistro();
            frmOs.tbNomeProprietario.Text = cliPf.Nome;
          }
          else if (cli.Cpf == "")
          {
            PessoaJuridica cliPj = new PessoaJuridica();
            cliPj.Cnpj = cli.Cnpj;
            cliPj.ConsultarRegistro();
            frmOs.tbNomeProprietario.Text = cliPj.Razaosocial;
          }

          frmOs.tbResponsavel.Focus();
          frmOs.req_placa = true;
          frmOs.ValidarRequisitos();
        }
        this.Dispose();
      }
    }

    private void btnPesquisar_Click(object sender, EventArgs e)
    {
      if (radPlaca.Checked)
      {
        bool encontrado = false;
        for (int i = 0; i < dataGridView1.RowCount; i++)
        {
          if (dataGridView1.Rows[i].Cells[0].Value.ToString().Contains(tbPlacaCarro.Text))
          {
            dataGridView1.Focus();
            dataGridView1.FirstDisplayedScrollingRowIndex = i;
            dataGridView1.Refresh();
            dataGridView1.CurrentCell = dataGridView1.Rows[i].Cells[0];
            dataGridView1.Rows[i].Selected = true;
            encontrado = true;
            this.CancelButton = null;
            break;
          }
        }
        if (!encontrado)
        {
          MessageBox.Show("Nenhum registro encontrado com essas informações!", "Pesquisa", MessageBoxButtons.OK, MessageBoxIcon.Warning);
          tbPlacaCarro.SelectAll();
        }
      } 
    }

    private void dataGridView1_KeyDown(object sender, KeyEventArgs e)
    {
      if (e.KeyCode == Keys.Enter)
      {
        DataGridViewRow linhaAtual = dataGridView1.CurrentRow;
        int i = linhaAtual.Index;
        if (frm != null)
        {
          frm.tbPlacaCarro.Text = dataGridView1.Rows[i].Cells[0].Value.ToString();
          frm.tbMarcaCarro.Text = dataGridView1.Rows[i].Cells[1].Value.ToString();
          frm.tbModeloCarro.Text = dataGridView1.Rows[i].Cells[2].Value.ToString();
          frm.tbCorCarro.Text = dataGridView1.Rows[i].Cells[3].Value.ToString();
          frm.tbAnoCarro.Text = dataGridView1.Rows[i].Cells[4].Value.ToString();
          frm.tbCodigoProprietario.Text = dataGridView1.Rows[i].Cells[5].Value.ToString();
          
          //Preenche dados do proprietario...
          Cliente cli = new Cliente();
          PessoaFisica cliPf = new PessoaFisica();
          PessoaJuridica cliPj = new PessoaJuridica();
          cli.IdCliente = Convert.ToInt32(dataGridView1.Rows[i].Cells[5].Value);
          cli.LocalizaCliente();
          if (cli.Cnpj == "")
          {
            cliPf.Cpf = cli.Cpf;
            cliPf.ConsultarRegistro();
            frm.radPessoaFisica.Checked = true;
            frm.tbApelidoProprietario.Text = cliPf.Apelido;
            frm.tbCpfCnpj.Text = cliPf.Cpf;
            frm.tbNomeProprietario.Text = cliPf.Nome;
            frm.tbObs.Text = cli.Obs;
            frm.tbRamal1.Text = cli.Ramal1;
            frm.tbRamal2.Text = cli.Ramal2;
            frm.tbRgIeProprietario.Text = cliPf.Rg;
            frm.tbTelefone1.Text = cli.Telefone1;
            frm.tbTelefone2.Text = cli.Telefone2;
            frm.req_codProp = true;
            frm.VerificaRequisitos();
          }
          else if (cli.Cpf == "")
          {
            cliPj.Cnpj = cli.Cnpj;
            cliPj.ConsultarRegistro();
            frm.radPessoaJuridica.Checked = true;
            frm.tbApelidoProprietario.Text = cliPj.Nomefantasia;
            frm.tbCpfCnpj.Text = cliPj.Cnpj;
            frm.tbNomeProprietario.Text = cliPj.Razaosocial;
            frm.tbObs.Text = cli.Obs;
            frm.tbRamal1.Text = cli.Ramal1;
            frm.tbRamal2.Text = cli.Ramal2;
            frm.tbRgIeProprietario.Text = cliPf.Rg;
            frm.tbTelefone1.Text = cli.Telefone1;
            frm.tbTelefone2.Text = cli.Telefone2;
            frm.req_codProp = true;
            frm.VerificaRequisitos();
          }
          frm.butAlterar.Enabled = true;
          frm.butExcluir.Enabled = true;
          frm.butSalvar.Enabled = false;
          frm.butAbrirOs.Enabled = true;
          frm.butNovo.Focus();
        }
        else if (frmOs != null)
        {
          frmOs.tbPlacaCarro.Text = dataGridView1.Rows[i].Cells[0].Value.ToString();
          frmOs.tbMarcaCarro.Text = dataGridView1.Rows[i].Cells[1].Value.ToString();
          frmOs.tbModeloCarro.Text = dataGridView1.Rows[i].Cells[2].Value.ToString();
          frmOs.tbCodigoProprietario.Text = dataGridView1.Rows[i].Cells[5].Value.ToString();
          Cliente cli = new Cliente();
          cli.IdCliente = Convert.ToInt32(frmOs.tbCodigoProprietario.Text);
          cli.LocalizaCliente();
          if (cli.Cnpj == "")
          {
            PessoaFisica cliPf = new PessoaFisica();
            cliPf.Cpf = cli.Cpf;
            cliPf.ConsultarRegistro();
            frmOs.tbNomeProprietario.Text = cliPf.Nome;
          }
          else if (cli.Cpf == "")
          {
            PessoaJuridica cliPj = new PessoaJuridica();
            cliPj.Cnpj = cli.Cnpj;
            cliPj.ConsultarRegistro();
            frmOs.tbNomeProprietario.Text = cliPj.Razaosocial;
          }
          frmOs.tbResponsavel.Focus();
          frmOs.req_placa = true;
          frmOs.ValidarRequisitos();
        }
        this.Dispose();
      }
      else if (e.KeyCode == Keys.Escape)
      {
        tbPlacaCarro.Clear();
        tbPlacaCarro.Focus();
        this.CancelButton = butSair;
      }
    }

    private void dataGridView1_Leave(object sender, EventArgs e)
    {
      this.CancelButton = butSair;
    }

    private void radPlaca_CheckedChanged(object sender, EventArgs e)
    {
      tbPlacaCarro.Clear();
      tbPlacaCarro.Focus();
    }
  }
}
