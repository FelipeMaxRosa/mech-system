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
  public partial class FormGridFuncionarios : Form
  {
    private DataSet ds;
    private DataTable dt;
    private BancoDados bd;
    private FormCadFuncionarios frm;

    public FormGridFuncionarios(FormCadFuncionarios frm1)
    {
      InitializeComponent();
      bd = new BancoDados();
      frm = frm1;
      txtNome.Focus();
    }

    private void FormGridFuncionarios_Load(object sender, EventArgs e)
    {
      string SQL = "SELECT * FROM mecanico ORDER BY id";
      string table = "mecanico";
      ds = new DataSet();
      ds = bd.ConsultarParaGrid(SQL, table);
      dataGridView1.DataSource = ds.Tables[table];
    }

    private void butSair_Click(object sender, EventArgs e)
    {
      if (frm != null)
      {
        frm.tbCodigoFuncionario.Focus();
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
          frm.tbCodigoFuncionario.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
          frm.tbNome.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
          frm.tbCpfCnpj.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
          frm.tbRgIe.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
          frm.tbEndereco.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
          frm.tbNumero.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
          frm.tbBairro.Text = dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString();
          frm.tbCidade.Text = dataGridView1.Rows[e.RowIndex].Cells[7].Value.ToString();
          frm.tbEstado.Text = dataGridView1.Rows[e.RowIndex].Cells[8].Value.ToString();
          frm.tbCep.Text = dataGridView1.Rows[e.RowIndex].Cells[9].Value.ToString();
          frm.dtNascimento.Value = Convert.ToDateTime(dataGridView1.Rows[e.RowIndex].Cells[10].Value);
          frm.dtAdmissao.Value = Convert.ToDateTime(dataGridView1.Rows[e.RowIndex].Cells[11].Value);
          frm.tbSalario.Text = dataGridView1.Rows[e.RowIndex].Cells[12].Value.ToString();
          frm.tbTelefone1.Text = dataGridView1.Rows[e.RowIndex].Cells[13].Value.ToString();
          frm.tbCelular.Text = dataGridView1.Rows[e.RowIndex].Cells[14].Value.ToString();
          
          dt = new DataTable();
          Funcao fun = new Funcao();
          fun.Id = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[15].Value);
          fun.ConsultaFuncao();

          //Preenche ComboBox
          dt = new DataTable();
          dt = fun.PreencherCbx();
          frm.cbxFuncao.DisplayMember = "descricao";
          frm.cbxFuncao.ValueMember = "id";
          frm.cbxFuncao.DataSource = dt;
          frm.cbxFuncao.Text = fun.Descricao;          

          frm.butAlterar.Enabled = true;
          frm.butExcluir.Enabled = true;
          //frm.butSalvar.Enabled = false;
          frm.butNovo.Focus();
        }
        this.Dispose();
      }
    }

    private void btnPesquisar_Click(object sender, EventArgs e)
    {
      if (radNome.Checked)
      {
        bool encontrado = false;
        for (int i = 0; i < dataGridView1.RowCount; i++)
        {
          if (dataGridView1.Rows[i].Cells[1].Value.ToString().Contains(txtNome.Text))
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
          txtNome.SelectAll();
        }        
      }
      else if (radCpf.Checked)
      {
        bool encontrado = false;
        for (int i = 0; i < dataGridView1.RowCount; i++)
        {
          if (dataGridView1.Rows[i].Cells[2].Value.ToString().Contains(txtCpf.Text))
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
          txtCpf.SelectAll();
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
          frm.tbCodigoFuncionario.Text = dataGridView1.Rows[i].Cells[0].Value.ToString();
          frm.tbNome.Text = dataGridView1.Rows[i].Cells[1].Value.ToString();
          frm.tbCpfCnpj.Text = dataGridView1.Rows[i].Cells[2].Value.ToString();
          frm.tbRgIe.Text = dataGridView1.Rows[i].Cells[3].Value.ToString();
          frm.tbEndereco.Text = dataGridView1.Rows[i].Cells[4].Value.ToString();
          frm.tbNumero.Text = dataGridView1.Rows[i].Cells[5].Value.ToString();
          frm.tbBairro.Text = dataGridView1.Rows[i].Cells[6].Value.ToString();
          frm.tbCidade.Text = dataGridView1.Rows[i].Cells[7].Value.ToString();
          frm.tbEstado.Text = dataGridView1.Rows[i].Cells[8].Value.ToString();
          frm.tbCep.Text = dataGridView1.Rows[i].Cells[9].Value.ToString();
          frm.dtNascimento.Value = Convert.ToDateTime(dataGridView1.Rows[i].Cells[10].Value);
          frm.dtAdmissao.Value = Convert.ToDateTime(dataGridView1.Rows[i].Cells[11].Value);
          frm.tbSalario.Text = dataGridView1.Rows[i].Cells[12].Value.ToString();
          frm.tbTelefone1.Text = dataGridView1.Rows[i].Cells[13].Value.ToString();
          frm.tbCelular.Text = dataGridView1.Rows[i].Cells[14].Value.ToString();

          dt = new DataTable();
          Funcao fun = new Funcao();
          fun.Id = Convert.ToInt32(dataGridView1.Rows[i].Cells[15].Value);
          fun.ConsultaFuncao();

          //Preenche ComboBox
          dt = new DataTable();
          dt = fun.PreencherCbx();
          frm.cbxFuncao.DisplayMember = "descricao";
          frm.cbxFuncao.ValueMember = "id";
          frm.cbxFuncao.DataSource = dt;
          frm.cbxFuncao.Text = fun.Descricao;

          frm.butAlterar.Enabled = true;
          frm.butExcluir.Enabled = true;
          frm.butNovo.Focus();
        }
              this.Dispose();
      }
      else if (e.KeyCode == Keys.Escape)
      {
        radNome.Checked = true;
        txtNome.Clear();
        txtNome.Focus();
        this.CancelButton = butSair;
      }
    }

    private void dataGridView1_Leave(object sender, EventArgs e)
    {
      this.CancelButton = butSair;
    }

    private void radioButton1_CheckedChanged(object sender, EventArgs e)
    {
      txtCpf.Clear();
      txtCpf.Enabled = false;
      txtNome.Enabled = true;
      txtNome.Focus();
    }

    private void radCpf_CheckedChanged(object sender, EventArgs e)
    {
      txtNome.Clear();
      txtNome.Enabled = false;
      txtCpf.Enabled = true;
      txtCpf.Focus();
    }
  }
}
