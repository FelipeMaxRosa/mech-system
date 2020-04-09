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
  public partial class FormGridClientePF : Form
  {
    private DataSet ds;
    private BancoDados bd;

    FormCadClientes frm = null;
    PessoaFisica pf;
    FormCadVeiculos frmvei = null;
    Veiculo vei;
    
    //Construtor
    public FormGridClientePF(object frm1, string tipoobj)
    {
      InitializeComponent();
      bd = new BancoDados();
      pf = new PessoaFisica();
      vei = new Veiculo();
      if (tipoobj == "clientes")
      {
        frm = (FormCadClientes)frm1;
      }
      else if(tipoobj == "veiculos")
      {
        frmvei = (FormCadVeiculos)frm1;
      }
      txtPesquisaNome.Focus();
    }

    //Métodos Gerais
    private delegate void PosicionaCursorDelegate(int posicao);

    private void PosicionaCursor(int posicao)
    {
      this.txtPesquisaCpf.SelectionStart = posicao;
    }

    //Métodos_Eventos
    private void FormGridClientes_Load(object sender, EventArgs e)
    {
      string SQL = "SELECT * FROM clientespf";
      string tabela = "pessoafisica";
      ds = new DataSet();
      ds = bd.ConsultarParaGrid(SQL, tabela);
      dataGridView1.DataSource = ds.Tables["pessoafisica"];
    }

    private void button1_Click(object sender, EventArgs e)
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

    private void maskedTextBox1_TextChanged(object sender, EventArgs e)
    {
      if (txtPesquisaCpf.Text.Length == 14)
      {
        bool encontrado = false;
        for (int i = 0; i < dataGridView1.RowCount; i++)
        {
          if (dataGridView1.Rows[i].Cells[4].Value.ToString().Contains(txtPesquisaCpf.Text))
          {
            dataGridView1.Rows[i].Cells[1].Selected = true;
            dataGridView1.Focus();
            encontrado = true;
            this.CancelButton = null;
            break;
          }
        }

        if (!encontrado)
        {
          MessageBox.Show("CPF não cadastrado!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
          this.BeginInvoke(new PosicionaCursorDelegate(PosicionaCursor), new object[] { this.txtPesquisaCpf.TextLength });
        }
      }
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
          frm.tbCodigoCliente.Text = Convert.ToString(dataGridView1.Rows[e.RowIndex].Cells[0].Value);
          frm.tbNome.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
          frm.tbApelido.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
          frm.tbRgIe.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
          frm.tbCpfCnpj.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
          frm.tbCep.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
          frm.tbEndereco.Text = dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString();
          frm.tbNumero.Text = dataGridView1.Rows[e.RowIndex].Cells[7].Value.ToString();
          frm.tbBairro.Text = dataGridView1.Rows[e.RowIndex].Cells[8].Value.ToString();
          frm.tbCidade.Text = dataGridView1.Rows[e.RowIndex].Cells[9].Value.ToString();
          frm.tbEstado.Text = dataGridView1.Rows[e.RowIndex].Cells[10].Value.ToString();
          frm.dtDataNascimento.Value = Convert.ToDateTime(dataGridView1.Rows[e.RowIndex].Cells[11].Value);
          frm.tbNomePai.Text = dataGridView1.Rows[e.RowIndex].Cells[12].Value.ToString();
          frm.tbNomeMae.Text = dataGridView1.Rows[e.RowIndex].Cells[13].Value.ToString();
          frm.tbEmail.Text = dataGridView1.Rows[e.RowIndex].Cells[14].Value.ToString();
          frm.tbTelefone1.Text = dataGridView1.Rows[e.RowIndex].Cells[15].Value.ToString();
          frm.tbRamal1.Text = dataGridView1.Rows[e.RowIndex].Cells[16].Value.ToString();
          frm.tbTelefone2.Text = dataGridView1.Rows[e.RowIndex].Cells[17].Value.ToString();
          frm.tbRamal2.Text = dataGridView1.Rows[e.RowIndex].Cells[18].Value.ToString();
          frm.tbObs.Text = dataGridView1.Rows[e.RowIndex].Cells[19].Value.ToString();
          frm.cbxSituacao.Text = dataGridView1.Rows[e.RowIndex].Cells[20].Value.ToString();

          frm.tbCodigoCliente.Focus();
          frm.tbCodigoCliente.SelectAll();
          frm.butAlterar.Enabled = true;
          frm.butExcluir.Enabled = true;
        }
        else if (frmvei != null)
        {
          frmvei.tbCodigoProprietario.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
          frmvei.tbNomeProprietario.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
          frmvei.tbApelidoProprietario.Text = Convert.ToString(dataGridView1.Rows[e.RowIndex].Cells[2].Value);
          frmvei.tbRgIeProprietario.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
          frmvei.tbCpfCnpj.Text = Convert.ToString(dataGridView1.Rows[e.RowIndex].Cells[4].Value);
          frmvei.tbTelefone1.Text = dataGridView1.Rows[e.RowIndex].Cells[15].Value.ToString();
          frmvei.tbRamal1.Text = dataGridView1.Rows[e.RowIndex].Cells[16].Value.ToString();
          frmvei.tbTelefone2.Text = dataGridView1.Rows[e.RowIndex].Cells[17].Value.ToString();
          frmvei.tbRamal2.Text = dataGridView1.Rows[e.RowIndex].Cells[18].Value.ToString();
          frmvei.tbObs.Text = dataGridView1.Rows[e.RowIndex].Cells[19].Value.ToString();

          frmvei.tbCodigoProprietario.Focus();
          frmvei.tbCodigoProprietario.SelectAll();
          frmvei.butSalvar.Enabled = true;
        }
        this.Dispose();
      }
      
    }

    private void btnPesquisar_Click(object sender, EventArgs e)
    {
      bool encontrado = false;
      for (int i = 0; i < dataGridView1.RowCount; i++)
      {
        if (dataGridView1.Rows[i].Cells[1].Value.ToString().Contains(txtPesquisaNome.Text) || dataGridView1.Rows[i].Cells[2].Value.ToString().Contains(txtPesquisaNome.Text))
        {
          dataGridView1.FirstDisplayedScrollingRowIndex = i;
          dataGridView1.Refresh();
          dataGridView1.CurrentCell = dataGridView1.Rows[i].Cells[0];
          dataGridView1.Rows[i].Selected = true;
          dataGridView1.Focus();
          encontrado = true;
          this.CancelButton = null;
          break;
        }
      }
      if (!encontrado)
      {
        MessageBox.Show("Cliente não encontrado!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        txtPesquisaNome.SelectAll();
      }
    }

    private void dataGridView1_KeyDown(object sender, KeyEventArgs e)
    {
      if (e.KeyCode == Keys.Enter)
      {
        DataGridViewRow linhaAtual = dataGridView1.CurrentRow;
        int i = linhaAtual.Index;

        {
          if (frm != null)
          {
            frm.tbCodigoCliente.Text = dataGridView1.Rows[i].Cells[0].Value.ToString();
            frm.tbNome.Text = dataGridView1.Rows[i].Cells[1].Value.ToString();
            frm.tbApelido.Text = dataGridView1.Rows[i].Cells[2].Value.ToString();
            frm.tbRgIe.Text = dataGridView1.Rows[i].Cells[3].Value.ToString();
            frm.tbCpfCnpj.Text = dataGridView1.Rows[i].Cells[4].Value.ToString();
            frm.tbCep.Text = dataGridView1.Rows[i].Cells[5].Value.ToString();
            frm.tbEndereco.Text = dataGridView1.Rows[i].Cells[6].Value.ToString();
            frm.tbNumero.Text = dataGridView1.Rows[i].Cells[7].Value.ToString();
            frm.tbBairro.Text = dataGridView1.Rows[i].Cells[8].Value.ToString();
            frm.tbCidade.Text = dataGridView1.Rows[i].Cells[9].Value.ToString();
            frm.tbEstado.Text = dataGridView1.Rows[i].Cells[10].Value.ToString();
            frm.dtDataNascimento.Value = Convert.ToDateTime(dataGridView1.Rows[i].Cells[11].Value);
            frm.tbNomePai.Text = dataGridView1.Rows[i].Cells[12].Value.ToString();
            frm.tbNomeMae.Text = dataGridView1.Rows[i].Cells[13].Value.ToString();
            frm.tbEmail.Text = dataGridView1.Rows[i].Cells[14].Value.ToString();
            frm.tbTelefone1.Text = dataGridView1.Rows[i].Cells[15].Value.ToString();
            frm.tbRamal1.Text = dataGridView1.Rows[i].Cells[16].Value.ToString();
            frm.tbTelefone2.Text = dataGridView1.Rows[i].Cells[17].Value.ToString();
            frm.tbRamal2.Text = dataGridView1.Rows[i].Cells[18].Value.ToString();
            frm.tbObs.Text = dataGridView1.Rows[i].Cells[19].Value.ToString();
            frm.cbxSituacao.Text = dataGridView1.Rows[i].Cells[20].Value.ToString();

            frm.tbCodigoCliente.Focus();
            frm.tbCodigoCliente.SelectAll();
            frm.butAlterar.Enabled = true;
            frm.butExcluir.Enabled = true;
          }
          else if (frmvei != null)
          {
            frmvei.tbCodigoProprietario.Text = dataGridView1.Rows[i].Cells[0].Value.ToString();
            frmvei.tbNomeProprietario.Text = dataGridView1.Rows[i].Cells[1].Value.ToString();
            frmvei.tbApelidoProprietario.Text = Convert.ToString(dataGridView1.Rows[i].Cells[2].Value);
            frmvei.tbRgIeProprietario.Text = dataGridView1.Rows[i].Cells[3].Value.ToString();
            frmvei.tbCpfCnpj.Text = Convert.ToString(dataGridView1.Rows[i].Cells[4].Value);
            frmvei.tbTelefone1.Text = dataGridView1.Rows[i].Cells[15].Value.ToString();
            frmvei.tbRamal1.Text = dataGridView1.Rows[i].Cells[16].Value.ToString();
            frmvei.tbTelefone2.Text = dataGridView1.Rows[i].Cells[17].Value.ToString();
            frmvei.tbRamal2.Text = dataGridView1.Rows[i].Cells[18].Value.ToString();
            frmvei.tbObs.Text = dataGridView1.Rows[i].Cells[19].Value.ToString();

            frmvei.tbCodigoProprietario.Focus();
            frmvei.tbCodigoProprietario.SelectAll();
            frmvei.butSalvar.Enabled = true;
          }

          this.Dispose();
        }
      }
      else if (e.KeyCode == Keys.Escape)
      {
        txtPesquisaNome.Clear();
        txtPesquisaCpf.Clear();
        txtPesquisaNome.Focus();        
        this.CancelButton = butSair;
      }
    }

    private void dataGridView1_Leave(object sender, EventArgs e)
    {
      this.CancelButton = butSair;
    }
  }
}
