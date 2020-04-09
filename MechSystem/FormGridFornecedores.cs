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
  public partial class FormGridFornecedores : Form
  {
    //Atributos
    private DataSet ds;
    private BancoDados bd;
    private FormCadFornecedores frm;
    private FormCadProdutos frmprod;

    //Construtor
    public FormGridFornecedores(object frm1, string tipoobj)
    {
      InitializeComponent();
      bd = new BancoDados();
      if (tipoobj == "produtos")
      {
        frmprod = (FormCadProdutos)frm1;
      }
      else if (tipoobj == "fornecedores")
      {
        frm = (FormCadFornecedores)frm1;
      }
      txtPesquisa.Select();
    }

    //Métodos Gerais
    private delegate void PosicionaCursorDelegate(int posicao);

    private void PosicionaCursor(int posicao)
    {
      this.txtPesquisaCnpj.SelectionStart = posicao;
    }

    //Métodos_Eventos
    private void FormGridFornecedores_Load(object sender, EventArgs e)
    {
      string SQL = "SELECT * FROM fornecedor ORDER BY razaosocial";
      string tabela = "fornecedor";
      ds = new DataSet();
      ds = bd.ConsultarParaGrid(SQL, tabela);
      dataGridView1.DataSource = ds.Tables["fornecedor"];
    }

    private void butSair_Click(object sender, EventArgs e)
    {
      if (frm != null)
      {
        frm.tbCodigo.Focus();
      }
      else if (frmprod != null)
      {
        frmprod.tbCodigoFornecedor.Focus();
      }
      this.Close();
    }

    private void dataGridView1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
    {

    }

    private void dataGridView1_KeyDown(object sender, KeyEventArgs e)
    {
      if (e.KeyCode == Keys.Enter)
      {
        DataGridViewRow linhaAtual = dataGridView1.CurrentRow;
        int i = linhaAtual.Index;
        if (frm != null)
        {
          frm.tbCodigo.Text = dataGridView1.Rows[i].Cells[0].Value.ToString();
          frm.tbRazaoSocial.Text = dataGridView1.Rows[i].Cells[1].Value.ToString();
          frm.tbFantasia.Text = dataGridView1.Rows[i].Cells[2].Value.ToString();
          frm.tbCpfCnpj.Text = dataGridView1.Rows[i].Cells[3].Value.ToString();
          frm.tbIE.Text = dataGridView1.Rows[i].Cells[4].Value.ToString();
          frm.tbCep.Text = dataGridView1.Rows[i].Cells[5].Value.ToString();
          frm.tbEndereco.Text = dataGridView1.Rows[i].Cells[6].Value.ToString();
          frm.tbNumero.Text = dataGridView1.Rows[i].Cells[7].Value.ToString();
          frm.tbBairro.Text = dataGridView1.Rows[i].Cells[8].Value.ToString();
          frm.tbCidade.Text = dataGridView1.Rows[i].Cells[9].Value.ToString();
          frm.tbUF.Text = dataGridView1.Rows[i].Cells[10].Value.ToString();
          frm.tbTel1.Text = dataGridView1.Rows[i].Cells[11].Value.ToString();
          frm.tbRamal1.Text = dataGridView1.Rows[i].Cells[12].Value.ToString();
          frm.tbTel2.Text = dataGridView1.Rows[i].Cells[13].Value.ToString();
          frm.tbRamal2.Text = dataGridView1.Rows[i].Cells[14].Value.ToString();
          frm.tbEmail.Text = dataGridView1.Rows[i].Cells[15].Value.ToString();
          frm.tbObs.Text = dataGridView1.Rows[i].Cells[16].Value.ToString();

          frm.butAlterar.Enabled = true;
          frm.butExcluir.Enabled = true;
          frm.butNovo.Focus();
        }
        else if (frmprod != null)
        {
          frmprod.tbCodigoFornecedor.Text = dataGridView1.Rows[i].Cells[0].Value.ToString();
          frmprod.tbNomeFornecedor.Text = dataGridView1.Rows[i].Cells[1].Value.ToString();
          frmprod.tbCodigoFornecedor.Select();
        }

        this.Dispose();
      }
      else if (e.KeyCode == Keys.Escape)
      {
        radRazaoSocial.Checked = true;
        txtPesquisa.Clear();
        txtPesquisa.Focus();
        this.CancelButton = butSair;
      }
    }

    private void btnPesquisar_Click(object sender, EventArgs e)
    {
      if (radRazaoSocial.Checked)
      {
        bool encontrado = false;
        for (int i = 0; i < dataGridView1.RowCount; i++)
        {
          if (dataGridView1.Rows[i].Cells[1].Value.ToString().Contains(txtPesquisa.Text))
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
          txtPesquisa.SelectAll();
        }
      }
      else if (radCnpj.Checked)
      {
        bool encontrado = false;
        for (int i = 0; i < dataGridView1.RowCount; i++)
        {
          if (dataGridView1.Rows[i].Cells[3].Value.ToString().Contains(txtPesquisaCnpj.Text))
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
          txtPesquisaCnpj.SelectAll();
        }
      }
      else if (radNomeFantasia.Checked)
      {
        bool encontrado = false;
        for (int i = 0; i < dataGridView1.RowCount; i++)
        {
          if (dataGridView1.Rows[i].Cells[2].Value.ToString().Contains(txtNomeFantasia.Text))
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
          txtNomeFantasia.SelectAll();
        }
      }
    }

    private void dataGridView1_Leave(object sender, EventArgs e)
    {
      this.CancelButton = butSair;
    }

    private void radRazaoSocial_CheckedChanged(object sender, EventArgs e)
    {
      txtPesquisaCnpj.Clear();
      txtPesquisaCnpj.Enabled = false;
      txtNomeFantasia.Clear();
      txtNomeFantasia.Enabled = false;
      txtPesquisa.Clear();
      txtPesquisa.Enabled = true;
      txtPesquisa.Focus();
    }

    private void radCnpj_CheckedChanged(object sender, EventArgs e)
    {
      txtPesquisa.Clear();
      txtPesquisa.Enabled = false;
      txtNomeFantasia.Clear();
      txtNomeFantasia.Enabled = false;
      txtPesquisaCnpj.Clear();
      txtPesquisaCnpj.Enabled = true;
      txtPesquisaCnpj.Focus();
    }

    private void radNomeFantasia_CheckedChanged(object sender, EventArgs e)
    {
      txtPesquisa.Clear();
      txtPesquisaCnpj.Clear();
      txtPesquisa.Enabled = false;
      txtPesquisaCnpj.Enabled = false;
      txtNomeFantasia.Clear();
      txtNomeFantasia.Enabled = true;
      txtNomeFantasia.Focus();
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
          frm.tbCodigo.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
          frm.tbRazaoSocial.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
          frm.tbFantasia.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
          frm.tbCpfCnpj.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
          frm.tbIE.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
          frm.tbCep.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
          frm.tbEndereco.Text = dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString();
          frm.tbNumero.Text = dataGridView1.Rows[e.RowIndex].Cells[7].Value.ToString();
          frm.tbBairro.Text = dataGridView1.Rows[e.RowIndex].Cells[8].Value.ToString();
          frm.tbCidade.Text = dataGridView1.Rows[e.RowIndex].Cells[9].Value.ToString();
          frm.tbUF.Text = dataGridView1.Rows[e.RowIndex].Cells[10].Value.ToString();
          frm.tbTel1.Text = dataGridView1.Rows[e.RowIndex].Cells[11].Value.ToString();
          frm.tbRamal1.Text = dataGridView1.Rows[e.RowIndex].Cells[12].Value.ToString();
          frm.tbTel2.Text = dataGridView1.Rows[e.RowIndex].Cells[13].Value.ToString();
          frm.tbRamal2.Text = dataGridView1.Rows[e.RowIndex].Cells[14].Value.ToString();
          frm.tbEmail.Text = dataGridView1.Rows[e.RowIndex].Cells[15].Value.ToString();
          frm.tbObs.Text = dataGridView1.Rows[e.RowIndex].Cells[16].Value.ToString();

          frm.butAlterar.Enabled = true;
          frm.butExcluir.Enabled = true;
          frm.butNovo.Focus();
        }
        else if (frmprod != null)
        {
          frmprod.tbCodigoFornecedor.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
          frmprod.tbNomeFornecedor.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
          frmprod.tbCodigoFornecedor.Select();
        }

        this.Dispose();
      }
    }
  }
}
