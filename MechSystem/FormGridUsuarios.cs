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
  public partial class FormGridUsuarios : Form
  {
    #region Atributos
    //------------------------------------------------------------------------
    private DataSet ds;
    private BancoDados bd;
    private FormCadUsuarios frm;

    #endregion

    #region Construtor
    //------------------------------------------------------------------------
    public FormGridUsuarios(FormCadUsuarios frm1)
    {
      InitializeComponent();
      bd = new BancoDados();
      frm = frm1;
      tbPesquisa.Focus();
    }
    #endregion

    #region Metodos_Eventos
    //------------------------------------------------------------------------
    private void butSair_Click(object sender, EventArgs e)
    {
      if (frm != null)
      {
        frm.tbCodigo.Focus();
      }
      this.Close();
    }

    private void FormGridUsuarios_Load(object sender, EventArgs e)
    {
      string SQL = "SELECT * FROM usuarios ORDER BY id";
      string tabela = "usuarios";
      ds = new DataSet();
      ds = bd.ConsultarParaGrid(SQL, tabela);
      dataGridView1.DataSource = ds.Tables["usuarios"];
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
          frm.tbLogin.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
          frm.tbSenha.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
          frm.tbSenhaC.Text = frm.tbSenha.Text;
          frm.cbxPerfil.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();

          frm.butAlterar.Enabled = true;
          frm.butExcluir.Enabled = true;
          frm.butSalvar.Enabled = false;
          frm.butNovo.Focus();
        }
        this.Dispose();
      }
    }

    private void btnPesquisar_Click(object sender, EventArgs e)
    {
      bool encontrado = false;
      for (int i = 0; i < dataGridView1.RowCount; i++)
      {
        if (dataGridView1.Rows[i].Cells[1].Value.ToString().Contains(tbPesquisa.Text))
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
        tbPesquisa.SelectAll();
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
          frm.tbCodigo.Text = dataGridView1.Rows[i].Cells[0].Value.ToString();
          frm.tbLogin.Text = dataGridView1.Rows[i].Cells[1].Value.ToString();
          frm.tbSenha.Text = dataGridView1.Rows[i].Cells[2].Value.ToString();
          frm.tbSenhaC.Text = frm.tbSenha.Text;
          frm.cbxPerfil.Text = dataGridView1.Rows[i].Cells[3].Value.ToString();

          frm.butAlterar.Enabled = true;
          frm.butExcluir.Enabled = true;
          frm.butSalvar.Enabled = false;
          frm.butNovo.Focus();
        }
        this.Dispose();
      }
      else if (e.KeyCode == Keys.Escape)
      {
        tbPesquisa.Clear();
        tbPesquisa.Focus();
        this.CancelButton = butSair;
      }
    }

    #endregion

    private void dataGridView1_Leave(object sender, EventArgs e)
    {
      this.CancelButton = butSair;
    }
  }
}
