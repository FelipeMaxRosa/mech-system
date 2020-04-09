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
  public partial class FormGridClientes : Form
  {
    private DataSet dsPf;
    private DataSet dsPj;
    private BancoDados bd;

    FormCadClientes frm = null;
    PessoaFisica pf;
    FormCadVeiculos frmvei = null;
    Veiculo vei;

    //Construtor
    //------------------------------------------------------------------------------
    public FormGridClientes(object frm1, string tipoobj)
    {
      InitializeComponent();
      bd = new BancoDados();
      pf = new PessoaFisica();
      vei = new Veiculo();
      if (tipoobj == "clientes")
      {
        frm = (FormCadClientes)frm1;
      }
      else if (tipoobj == "veiculos")
      {
        frmvei = (FormCadVeiculos)frm1;
      }
      txtPesquisaNome.Focus();
    }

    //Metodos Gerais
    //------------------------------------------------------------------------------
    private delegate void PosicionaCursorDelegate(int posicao);

    private void PosicionaCursor(int posicao)
    {
      this.txtPesquisaCpf.SelectionStart = posicao;
    }

    private void FormGridClientes_Load(object sender, EventArgs e)
    {
      //Grid - Pessoa Fisica
      //----------------------------------------------------------------
      string SQL = "SELECT * FROM clientespf WHERE c_status = 'ATIVO'";
      string tabela = "pessoafisica";
      dsPf = new DataSet();
      dsPf = bd.ConsultarParaGrid(SQL, tabela);
      dataGridViewPF.DataSource = dsPf.Tables["pessoafisica"];

      //Grid - Pessoa Juridica
      //-----------------------------------------------------------------
      string SQL2 = "SELECT * FROM clientespj WHERE c_status = 'ATIVO'";
      string tabela2 = "pessoajuridica";
      dsPj = new DataSet();
      dsPj = bd.ConsultarParaGrid(SQL2, tabela2);
      dataGridViewPJ.DataSource = dsPj.Tables["pessoajuridica"];

      cbxSituacao.Text = "ATIVO";
    }

    private void butSair_Click(object sender, EventArgs e)
    {
      if (frm != null)
      {
        frm.tbCodigoCliente.Focus();
      }
      else if (frmvei != null)
      {
        frmvei.tbCodigoProprietario.Focus();
      }
      this.Close();
    }

    private void tabPagePF_Enter(object sender, EventArgs e)
    {
      txtPesquisaCpf.Mask = "000,000,000-00";
      radCpfCnpj.Text = "C&PF:";

      //Grid - Pessoa Fisica
      //----------------------------------------------------------------
      string SQL = "";
      if (cbxSituacao.Text == "TODOS")
      {
        SQL = "SELECT * FROM clientespf";
      }
      else
      {
        SQL = "SELECT * FROM clientespf WHERE c_status = '" + cbxSituacao.Text + "'";
      }
      string tabela = "pessoafisica";
      dsPf = new DataSet();
      dsPf = bd.ConsultarParaGrid(SQL, tabela);
      dataGridViewPF.DataSource = dsPf.Tables["pessoafisica"];
    }

    private void tabPagePJ_Enter(object sender, EventArgs e)
    {
      txtPesquisaCpf.Mask = "00,000,000/0000-00";
      radCpfCnpj.Text = "CN&PJ:";

      //Grid - Pessoa Juridica
      //-----------------------------------------------------------------
      string SQL2 = "";
      if (cbxSituacao.Text == "TODOS")
      {
        SQL2 = "SELECT * FROM clientespj";
      }
      else
      {
        SQL2 = "SELECT * FROM clientespj WHERE c_status = '" + cbxSituacao.Text + "'";
      }
      string tabela2 = "pessoajuridica";
      dsPj = new DataSet();
      dsPj = bd.ConsultarParaGrid(SQL2, tabela2);
      dataGridViewPJ.DataSource = dsPj.Tables["pessoajuridica"];
    }

    private void radNome_CheckedChanged(object sender, EventArgs e)
    {
      txtPesquisaCpf.Clear();
      txtPesquisaNome.ReadOnly = false;
      txtPesquisaNome.TabStop = true;
      txtPesquisaCpf.ReadOnly = true;
      txtPesquisaNome.TabStop = false;
      txtPesquisaNome.Select();
    }

    private void radCpfCnpj_CheckedChanged(object sender, EventArgs e)
    {
      txtPesquisaNome.Clear();
      txtPesquisaNome.ReadOnly = true;
      txtPesquisaNome.TabStop = false;
      txtPesquisaCpf.ReadOnly = false;
      txtPesquisaNome.TabStop = true;
      txtPesquisaCpf.Focus();
    }

    private void dataGridViewPF_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
    {
      if (e.RowIndex < 0)
      {
      }
      else
      {
        if (frm != null)
        {
          frm.radPessoaFisica.Checked = true;
          frm.tbCodigoCliente.Text = Convert.ToString(dataGridViewPF.Rows[e.RowIndex].Cells[0].Value);
          frm.tbNome.Text = dataGridViewPF.Rows[e.RowIndex].Cells[1].Value.ToString();
          frm.tbApelido.Text = dataGridViewPF.Rows[e.RowIndex].Cells[2].Value.ToString();
          frm.tbRgIe.Text = dataGridViewPF.Rows[e.RowIndex].Cells[3].Value.ToString();
          frm.tbCpfCnpj.Text = dataGridViewPF.Rows[e.RowIndex].Cells[4].Value.ToString();
          frm.tbCep.Text = dataGridViewPF.Rows[e.RowIndex].Cells[5].Value.ToString();
          frm.tbEndereco.Text = dataGridViewPF.Rows[e.RowIndex].Cells[6].Value.ToString();
          frm.tbNumero.Text = dataGridViewPF.Rows[e.RowIndex].Cells[7].Value.ToString();
          frm.tbBairro.Text = dataGridViewPF.Rows[e.RowIndex].Cells[8].Value.ToString();
          frm.tbCidade.Text = dataGridViewPF.Rows[e.RowIndex].Cells[9].Value.ToString();
          frm.tbEstado.Text = dataGridViewPF.Rows[e.RowIndex].Cells[10].Value.ToString();
          frm.dtDataNascimento.Value = Convert.ToDateTime(dataGridViewPF.Rows[e.RowIndex].Cells[11].Value);
          frm.tbNomePai.Text = dataGridViewPF.Rows[e.RowIndex].Cells[12].Value.ToString();
          frm.tbNomeMae.Text = dataGridViewPF.Rows[e.RowIndex].Cells[13].Value.ToString();
          frm.tbEmail.Text = dataGridViewPF.Rows[e.RowIndex].Cells[14].Value.ToString();
          frm.tbTelefone1.Text = dataGridViewPF.Rows[e.RowIndex].Cells[15].Value.ToString();
          frm.tbRamal1.Text = dataGridViewPF.Rows[e.RowIndex].Cells[16].Value.ToString();
          frm.tbTelefone2.Text = dataGridViewPF.Rows[e.RowIndex].Cells[17].Value.ToString();
          frm.tbRamal2.Text = dataGridViewPF.Rows[e.RowIndex].Cells[18].Value.ToString();
          frm.tbObs.Text = dataGridViewPF.Rows[e.RowIndex].Cells[19].Value.ToString();
          frm.cbxSituacao.Text = dataGridViewPF.Rows[e.RowIndex].Cells[20].Value.ToString();

          //frmvei.tbCodigoProprietario.Focus();
          //frm.tbCodigoCliente.SelectAll();
          frm.butAlterar.Enabled = true;
          frm.butExcluir.Enabled = true;
          frm.butNovo.Focus();
        }
        else if (frmvei != null)
        {
          frmvei.radPessoaFisica.Checked = true;
          frmvei.tbCodigoProprietario.Text = dataGridViewPF.Rows[e.RowIndex].Cells[0].Value.ToString();
          frmvei.tbNomeProprietario.Text = dataGridViewPF.Rows[e.RowIndex].Cells[1].Value.ToString();
          frmvei.tbApelidoProprietario.Text = Convert.ToString(dataGridViewPF.Rows[e.RowIndex].Cells[2].Value);
          frmvei.tbRgIeProprietario.Text = dataGridViewPF.Rows[e.RowIndex].Cells[3].Value.ToString();
          frmvei.tbCpfCnpj.Text = Convert.ToString(dataGridViewPF.Rows[e.RowIndex].Cells[4].Value);
          frmvei.tbTelefone1.Text = dataGridViewPF.Rows[e.RowIndex].Cells[15].Value.ToString();
          frmvei.tbRamal1.Text = dataGridViewPF.Rows[e.RowIndex].Cells[16].Value.ToString();
          frmvei.tbTelefone2.Text = dataGridViewPF.Rows[e.RowIndex].Cells[17].Value.ToString();
          frmvei.tbRamal2.Text = dataGridViewPF.Rows[e.RowIndex].Cells[18].Value.ToString();
          frmvei.tbObs.Text = dataGridViewPF.Rows[e.RowIndex].Cells[19].Value.ToString();

          //frmvei.tbCodigoProprietario.Focus();
          //frmvei.tbCodigoProprietario.SelectAll();
          frmvei.butSalvar.Enabled = true;
          frmvei.butSalvar.Focus();
        }
        this.Dispose();
      }
    }

    private void dataGridViewPJ_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
    {
      if (e.RowIndex < 0)
      {
      }
      else
      {
        if (frm != null)
        {
          frm.radPessoaJuridica.Checked = true;
          frm.tbCodigoCliente.Text = dataGridViewPJ.Rows[e.RowIndex].Cells[0].Value.ToString();
          frm.tbNome.Text = dataGridViewPJ.Rows[e.RowIndex].Cells[1].Value.ToString();
          frm.tbApelido.Text = dataGridViewPJ.Rows[e.RowIndex].Cells[2].Value.ToString();
          frm.tbRgIe.Text = dataGridViewPJ.Rows[e.RowIndex].Cells[3].Value.ToString();
          frm.tbCpfCnpj.Text = dataGridViewPJ.Rows[e.RowIndex].Cells[4].Value.ToString();
          frm.tbCep.Text = dataGridViewPJ.Rows[e.RowIndex].Cells[5].Value.ToString();
          frm.tbEndereco.Text = dataGridViewPJ.Rows[e.RowIndex].Cells[6].Value.ToString();
          frm.tbNumero.Text = dataGridViewPJ.Rows[e.RowIndex].Cells[7].Value.ToString();
          frm.tbBairro.Text = dataGridViewPJ.Rows[e.RowIndex].Cells[8].Value.ToString();
          frm.tbCidade.Text = dataGridViewPJ.Rows[e.RowIndex].Cells[9].Value.ToString();
          frm.tbEstado.Text = dataGridViewPJ.Rows[e.RowIndex].Cells[10].Value.ToString();
          frm.tbEmail.Text = dataGridViewPJ.Rows[e.RowIndex].Cells[11].Value.ToString();
          frm.tbTelefone1.Text = dataGridViewPJ.Rows[e.RowIndex].Cells[12].Value.ToString();
          frm.tbRamal1.Text = dataGridViewPJ.Rows[e.RowIndex].Cells[13].Value.ToString();
          frm.tbTelefone2.Text = dataGridViewPJ.Rows[e.RowIndex].Cells[14].Value.ToString();
          frm.tbRamal2.Text = dataGridViewPJ.Rows[e.RowIndex].Cells[15].Value.ToString();
          frm.tbObs.Text = dataGridViewPJ.Rows[e.RowIndex].Cells[16].Value.ToString();
          frm.cbxSituacao.Text = dataGridViewPJ.Rows[e.RowIndex].Cells[17].Value.ToString();

          //frm.tbCodigoCliente.Focus();
          //frm.tbCodigoCliente.SelectAll();
          frm.butAlterar.Enabled = true;
          frm.butExcluir.Enabled = true;
          frm.butNovo.Focus();
        }
        else if (frmvei != null)
        {
          frmvei.radPessoaJuridica.Checked = true;
          frmvei.tbCodigoProprietario.Text = dataGridViewPJ.Rows[e.RowIndex].Cells[0].Value.ToString();
          frmvei.tbNomeProprietario.Text = dataGridViewPJ.Rows[e.RowIndex].Cells[1].Value.ToString();
          frmvei.tbApelidoProprietario.Text = Convert.ToString(dataGridViewPJ.Rows[e.RowIndex].Cells[2].Value);
          frmvei.tbRgIeProprietario.Text = dataGridViewPJ.Rows[e.RowIndex].Cells[3].Value.ToString();
          frmvei.tbCpfCnpj.Text = Convert.ToString(dataGridViewPJ.Rows[e.RowIndex].Cells[4].Value);
          frmvei.tbTelefone1.Text = dataGridViewPJ.Rows[e.RowIndex].Cells[12].Value.ToString();
          frmvei.tbRamal1.Text = dataGridViewPJ.Rows[e.RowIndex].Cells[13].Value.ToString();
          frmvei.tbTelefone2.Text = dataGridViewPJ.Rows[e.RowIndex].Cells[14].Value.ToString();
          frmvei.tbRamal2.Text = dataGridViewPJ.Rows[e.RowIndex].Cells[15].Value.ToString();
          frmvei.tbObs.Text = dataGridViewPJ.Rows[e.RowIndex].Cells[16].Value.ToString();

          //frmvei.tbCodigoProprietario.Focus();
          //frmvei.tbCodigoProprietario.SelectAll();
          frmvei.butSalvar.Enabled = true;
          frmvei.butSalvar.Focus();
        }
        this.Dispose();
      }
    }

    private void btnPesquisar_Click(object sender, EventArgs e)
    {
      if (tabControl1.SelectedTab == tabPagePF)
      {
        if (radNome.Checked)
        {
          bool encontrado = false;
          for (int i = 0; i < dataGridViewPF.RowCount; i++)
          {
            if (dataGridViewPF.Rows[i].Cells[1].Value.ToString().Contains(txtPesquisaNome.Text) || dataGridViewPF.Rows[i].Cells["apelido"].Value.ToString().Contains(txtPesquisaNome.Text))
            {
              dataGridViewPF.Focus();
              dataGridViewPF.FirstDisplayedScrollingRowIndex = i;
              dataGridViewPF.Refresh();
              dataGridViewPF.CurrentCell = dataGridViewPF.Rows[i].Cells[0];
              dataGridViewPF.Rows[i].Selected = true;              
              encontrado = true;
              this.CancelButton = null;
              break;
            }
          }
          if (!encontrado)
          {
            MessageBox.Show("Nenhum registro encontrado com essas informações!", "Pesquisa", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            txtPesquisaNome.SelectAll();
          }
        }
        else if (radCpfCnpj.Checked)
        {
          bool encontrado = false;
          for (int i = 0; i < dataGridViewPF.RowCount; i++)
          {
            if (dataGridViewPF.Rows[i].Cells[4].Value.ToString().Contains(txtPesquisaCpf.Text))
            {
              dataGridViewPF.Focus();
              dataGridViewPF.FirstDisplayedScrollingRowIndex = i;
              dataGridViewPF.Refresh();
              dataGridViewPF.CurrentCell = dataGridViewPF.Rows[i].Cells[0];
              dataGridViewPF.Rows[i].Selected = true;
              encontrado = true;
              this.CancelButton = null;
              break;
            }
          }
          if (!encontrado)
          {
            MessageBox.Show("Nenhum registro encontrado com essas informações!", "Pesquisa", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            this.BeginInvoke(new PosicionaCursorDelegate(PosicionaCursor), new object[] { this.txtPesquisaCpf.TextLength });
          }
        }
      }
      else if (tabControl1.SelectedTab == tabPagePJ)
      {
        if (radNome.Checked)
        {
          if (txtPesquisaNome.Text.Length > 0)
          {
            bool encontrado = false;
            for (int i = 0; i < dataGridViewPJ.RowCount; i++)
            {
              if (dataGridViewPJ.Rows[i].Cells[1].Value.ToString().Contains(txtPesquisaNome.Text) || dataGridViewPJ.Rows[i].Cells[2].Value.ToString().Contains(txtPesquisaNome.Text))
              {
                dataGridViewPJ.Focus();
                dataGridViewPJ.FirstDisplayedScrollingRowIndex = i;
                dataGridViewPJ.Refresh();
                dataGridViewPJ.CurrentCell = dataGridViewPJ.Rows[i].Cells[0];
                dataGridViewPJ.Rows[i].Selected = true;
                encontrado = true;
                this.CancelButton = null;
                break;
              }
            }
            if (!encontrado)
            {
              MessageBox.Show("Nenhum registro encontrado com essas informações!", "Pesquisa", MessageBoxButtons.OK, MessageBoxIcon.Warning);
              txtPesquisaNome.Focus();
              txtPesquisaNome.SelectAll();
            }
          }
        }
        else if (radCpfCnpj.Checked)
        {
          if (txtPesquisaCpf.Text.Length == 18)
          {
            bool encontrado = false;
            for (int i = 0; i < dataGridViewPJ.RowCount; i++)
            {
              if (dataGridViewPJ.Rows[i].Cells[4].Value.ToString().Contains(txtPesquisaCpf.Text))
              {
                dataGridViewPJ.Focus();
                dataGridViewPJ.FirstDisplayedScrollingRowIndex = i;
                dataGridViewPJ.Refresh();
                dataGridViewPJ.CurrentCell = dataGridViewPJ.Rows[i].Cells[0];
                dataGridViewPJ.Rows[i].Selected = true;
                encontrado = true;
                this.CancelButton = null;
                break;
              }
            }
            if (!encontrado)
            {
              MessageBox.Show("Nenhum registro encontrado com essas informações!", "Pesquisa", MessageBoxButtons.OK, MessageBoxIcon.Warning);
              this.BeginInvoke(new PosicionaCursorDelegate(PosicionaCursor), new object[] { this.txtPesquisaCpf.TextLength });
            }
          }
        }
      }
    }

    private void dataGridViewPF_KeyDown(object sender, KeyEventArgs e)
    {
      if (e.KeyCode == Keys.Enter)
      {
        DataGridViewRow linhaAtual = dataGridViewPF.CurrentRow;
        int i = linhaAtual.Index;
        {
          if (frm != null)
          {
            frm.radPessoaFisica.Checked = true;
            frm.tbCodigoCliente.Text = dataGridViewPF.Rows[i].Cells[0].Value.ToString();
            frm.tbNome.Text = dataGridViewPF.Rows[i].Cells[1].Value.ToString();
            frm.tbApelido.Text = dataGridViewPF.Rows[i].Cells[2].Value.ToString();
            frm.tbRgIe.Text = dataGridViewPF.Rows[i].Cells[3].Value.ToString();
            frm.tbCpfCnpj.Text = dataGridViewPF.Rows[i].Cells[4].Value.ToString();
            frm.tbCep.Text = dataGridViewPF.Rows[i].Cells[5].Value.ToString();
            frm.tbEndereco.Text = dataGridViewPF.Rows[i].Cells[6].Value.ToString();
            frm.tbNumero.Text = dataGridViewPF.Rows[i].Cells[7].Value.ToString();
            frm.tbBairro.Text = dataGridViewPF.Rows[i].Cells[8].Value.ToString();
            frm.tbCidade.Text = dataGridViewPF.Rows[i].Cells[9].Value.ToString();
            frm.tbEstado.Text = dataGridViewPF.Rows[i].Cells[10].Value.ToString();
            frm.dtDataNascimento.Value = Convert.ToDateTime(dataGridViewPF.Rows[i].Cells[11].Value);
            frm.tbNomePai.Text = dataGridViewPF.Rows[i].Cells[12].Value.ToString();
            frm.tbNomeMae.Text = dataGridViewPF.Rows[i].Cells[13].Value.ToString();
            frm.tbEmail.Text = dataGridViewPF.Rows[i].Cells[14].Value.ToString();
            frm.tbTelefone1.Text = dataGridViewPF.Rows[i].Cells[15].Value.ToString();
            frm.tbRamal1.Text = dataGridViewPF.Rows[i].Cells[16].Value.ToString();
            frm.tbTelefone2.Text = dataGridViewPF.Rows[i].Cells[17].Value.ToString();
            frm.tbRamal2.Text = dataGridViewPF.Rows[i].Cells[18].Value.ToString();
            frm.tbObs.Text = dataGridViewPF.Rows[i].Cells[19].Value.ToString();
            frm.cbxSituacao.Text = dataGridViewPF.Rows[i].Cells[20].Value.ToString();

            //frm.tbCodigoCliente.Focus();
            //frm.tbCodigoCliente.SelectAll();
            frm.butAlterar.Enabled = true;
            frm.butExcluir.Enabled = true;
            frm.butNovo.Focus();
          }
          else if (frmvei != null)
          {
            frmvei.radPessoaFisica.Checked = true;
            frmvei.tbCodigoProprietario.Text = dataGridViewPF.Rows[i].Cells[0].Value.ToString();
            frmvei.tbNomeProprietario.Text = dataGridViewPF.Rows[i].Cells[1].Value.ToString();
            frmvei.tbApelidoProprietario.Text = Convert.ToString(dataGridViewPF.Rows[i].Cells[2].Value);
            frmvei.tbRgIeProprietario.Text = dataGridViewPF.Rows[i].Cells[3].Value.ToString();
            frmvei.tbCpfCnpj.Text = Convert.ToString(dataGridViewPF.Rows[i].Cells[4].Value);
            frmvei.tbTelefone1.Text = dataGridViewPF.Rows[i].Cells[15].Value.ToString();
            frmvei.tbRamal1.Text = dataGridViewPF.Rows[i].Cells[16].Value.ToString();
            frmvei.tbTelefone2.Text = dataGridViewPF.Rows[i].Cells[17].Value.ToString();
            frmvei.tbRamal2.Text = dataGridViewPF.Rows[i].Cells[18].Value.ToString();
            frmvei.tbObs.Text = dataGridViewPF.Rows[i].Cells[19].Value.ToString();

            //frmvei.tbCodigoProprietario.Focus();
            //frmvei.tbCodigoProprietario.SelectAll();
            frmvei.butSalvar.Enabled = true;
            frmvei.butSalvar.Focus();
          }

          this.Dispose();
        }
      }
      else if (e.KeyCode == Keys.Escape)
      {
        txtPesquisaNome.Clear();
        txtPesquisaCpf.Clear();        
        radNome.Select();
        txtPesquisaNome.Focus();
        this.CancelButton = butSair;
      }
    }

    private void dataGridViewPF_Leave(object sender, EventArgs e)
    {
      this.CancelButton = butSair;
    }

    private void dataGridViewPJ_KeyDown(object sender, KeyEventArgs e)
    {
      if (e.KeyCode == Keys.Enter)
      {
        DataGridViewRow linhaAtual = dataGridViewPJ.CurrentRow;
        int i = linhaAtual.Index;
        if (frm != null)
        {
          frm.radPessoaJuridica.Checked = true;
          frm.tbCodigoCliente.Text = dataGridViewPJ.Rows[i].Cells[0].Value.ToString();
          frm.tbNome.Text = dataGridViewPJ.Rows[i].Cells[1].Value.ToString();
          frm.tbApelido.Text = dataGridViewPJ.Rows[i].Cells[2].Value.ToString();
          frm.tbRgIe.Text = dataGridViewPJ.Rows[i].Cells[3].Value.ToString();
          frm.tbCpfCnpj.Text = dataGridViewPJ.Rows[i].Cells[4].Value.ToString();
          frm.tbCep.Text = dataGridViewPJ.Rows[i].Cells[5].Value.ToString();
          frm.tbEndereco.Text = dataGridViewPJ.Rows[i].Cells[6].Value.ToString();
          frm.tbNumero.Text = dataGridViewPJ.Rows[i].Cells[7].Value.ToString();
          frm.tbBairro.Text = dataGridViewPJ.Rows[i].Cells[8].Value.ToString();
          frm.tbCidade.Text = dataGridViewPJ.Rows[i].Cells[9].Value.ToString();
          frm.tbEstado.Text = dataGridViewPJ.Rows[i].Cells[10].Value.ToString();
          frm.tbEmail.Text = dataGridViewPJ.Rows[i].Cells[11].Value.ToString();
          frm.tbTelefone1.Text = dataGridViewPJ.Rows[i].Cells[12].Value.ToString();
          frm.tbRamal1.Text = dataGridViewPJ.Rows[i].Cells[13].Value.ToString();
          frm.tbTelefone2.Text = dataGridViewPJ.Rows[i].Cells[14].Value.ToString();
          frm.tbRamal2.Text = dataGridViewPJ.Rows[i].Cells[15].Value.ToString();
          frm.tbObs.Text = dataGridViewPJ.Rows[i].Cells[16].Value.ToString();
          frm.cbxSituacao.Text = dataGridViewPJ.Rows[i].Cells[17].Value.ToString();

          //frm.tbCodigoCliente.Focus();
          //frm.tbCodigoCliente.SelectAll();
          frm.butAlterar.Enabled = true;
          frm.butExcluir.Enabled = true;
          frm.butNovo.Focus();
        }
        else if (frmvei != null)
        {
          frmvei.radPessoaJuridica.Checked = true;
          frmvei.tbCodigoProprietario.Text = dataGridViewPJ.Rows[i].Cells[0].Value.ToString();
          frmvei.tbNomeProprietario.Text = dataGridViewPJ.Rows[i].Cells[1].Value.ToString();
          frmvei.tbApelidoProprietario.Text = Convert.ToString(dataGridViewPJ.Rows[i].Cells[2].Value);
          frmvei.tbRgIeProprietario.Text = dataGridViewPJ.Rows[i].Cells[3].Value.ToString();
          frmvei.tbCpfCnpj.Text = Convert.ToString(dataGridViewPJ.Rows[i].Cells[4].Value);
          frmvei.tbTelefone1.Text = dataGridViewPJ.Rows[i].Cells[12].Value.ToString();
          frmvei.tbRamal1.Text = dataGridViewPJ.Rows[i].Cells[13].Value.ToString();
          frmvei.tbTelefone2.Text = dataGridViewPJ.Rows[i].Cells[14].Value.ToString();
          frmvei.tbRamal2.Text = dataGridViewPJ.Rows[i].Cells[15].Value.ToString();
          frmvei.tbObs.Text = dataGridViewPJ.Rows[i].Cells[16].Value.ToString();

          //frmvei.tbCodigoProprietario.Focus();
          //frmvei.tbCodigoProprietario.SelectAll();
          frmvei.butSalvar.Enabled = true;
          frmvei.butSalvar.Focus();
        }
        this.Dispose();
      }
      else if (e.KeyCode == Keys.Escape)
      {
        txtPesquisaNome.Clear();
        txtPesquisaCpf.Clear();
        radNome.Checked = true;
        txtPesquisaNome.Focus();
        this.CancelButton = butSair;
      }
    }

    private void dataGridViewPJ_Leave(object sender, EventArgs e)
    {
      this.CancelButton = butSair;
    }

    private void tabPagePF_Click(object sender, EventArgs e)
    {
      radNome.Checked = true;
      txtPesquisaNome.Select();
    }

    private void tabPagePJ_Click(object sender, EventArgs e)
    {
      radNome.Checked = true;
      txtPesquisaNome.Select();
    }

    private void cbxSituacao_DropDownClosed(object sender, EventArgs e)
    {
      if (tabControl1.SelectedTab == tabPagePF)
      {
        string SQL = "";
        if (cbxSituacao.Text == "TODOS")
        {
          SQL = "SELECT * FROM clientespf";
        }
        else
        {
          SQL = "SELECT * FROM clientespf WHERE c_status = '" + cbxSituacao.Text + "'";
        }
        string tabela = "pessoafisica";
        dsPf = new DataSet();
        dsPf = bd.ConsultarParaGrid(SQL, tabela);
        dataGridViewPF.DataSource = dsPf.Tables["pessoafisica"];
        radNome.Checked = true;
        txtPesquisaNome.Focus();
      }
      else if (tabControl1.SelectedTab == tabPagePJ)
      {
        string SQL = "";
        if (cbxSituacao.Text == "TODOS")
        {
          SQL = "SELECT * FROM clientespj";
        }
        else
        {
          SQL = "SELECT * FROM clientespj WHERE c_status = '" + cbxSituacao.Text + "'";
        }
        string tabela = "pessoajuridica";
        dsPj = new DataSet();
        dsPj = bd.ConsultarParaGrid(SQL, tabela);
        dataGridViewPJ.DataSource = dsPj.Tables["pessoajuridica"];
        radNome.Checked = true;
        txtPesquisaNome.Focus();
      }
    }

  }
}
