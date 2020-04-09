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
  public partial class FormCadCodBarras : Form
  {
    //Atributos
    //-------------------------------------------------------------------------
    private BancoDados bd;
    private DataSet ds;
    private int idProduto;

    //Propriedades
    //-------------------------------------------------------------------------
    public int IdProduto
    {
      get { return idProduto; }
      set { idProduto = value; }
    }

    //Construtor
    //-------------------------------------------------------------------------
    public FormCadCodBarras()
    {
      InitializeComponent();
      bd = new BancoDados();
      cbxEmb.Text = "UN";
      txtUnidade.Text = "1";
    }

    //Metodos Gerais
    //-------------------------------------------------------------------------
    public void AtualizaGrid()
    {
      string SQL = "SELECT * FROM cod_barras WHERE idproduto = '" + idProduto + "' ORDER BY ean13";
      string tabela = "cod_barras";
      ds = new DataSet();
      ds = bd.ConsultarParaGrid(SQL, tabela);
      dataGridView1.DataSource = ds.Tables["cod_barras"];
    }

    private delegate void PosicionaCursorDelegate(int posicao);

    private void PosicionaCursor(int posicao)
    {
      this.txtEan13.SelectionStart = posicao;
    }

    //Metodos Eventos
    //-------------------------------------------------------------------------
    private void btnSair_Click(object sender, EventArgs e)
    {
      this.Close();
    }

    private void FormCadCodBarras_KeyPress(object sender, KeyPressEventArgs e)
    {
      if (e.KeyChar == Convert.ToChar(13))
      {
        e.Handled = true;
        SendKeys.Send("{TAB}");
      }
    }

    private void btnSalvar_Click(object sender, EventArgs e)
    {
      Produtos prod = new Produtos();
      string ean = txtEan13.Text;
      prod.Ean = ean.Replace("-", "");
      prod.Id = idProduto;
      prod.Embalagem = cbxEmb.Text;
      prod.Unidade = Convert.ToInt32(txtUnidade.Text);
      prod.Call_SP_CadastraEan();
      this.AtualizaGrid();
      txtEan13.Clear();
      txtEan13.Focus();
      txtEan13.SelectionStart = 0;
    }

    private void txtEan13_Leave(object sender, EventArgs e)
    {
      string ean = txtEan13.Text.Replace("-", "");
      if (ean.Length > 12)
      {
        Produtos prod = new Produtos();
        prod.Ean = ean;
        bool cadastrado = prod.VerificaEanCadastrado();
        if (cadastrado)
        {
          MessageBox.Show("Código EAN já cadastrado para outro produto!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
          txtEan13.Clear();
          txtEan13.Focus();
        }
        else
        {
          ValidaEAN val = new ValidaEAN();
          string ean2 = val.SomenteNumeros(txtEan13.Text);
          bool valido = val.ValidarEAN(ean2);
          if (valido)
          {
            btnSalvar.Enabled = true;
          }
          else
          {
            MessageBox.Show("Código EAN ou dígito verificador inválido!", "EAN Inválido", MessageBoxButtons.OK, MessageBoxIcon.Error);
            txtEan13.Clear();
            txtEan13.Focus();
            btnSalvar.Enabled = false;
          }
        }
      }
      else
      {
        btnSalvar.Enabled = false;
      }
    }

    private void FormCadCodBarras_Load(object sender, EventArgs e)
    {
      this.AtualizaGrid();
    }

    private void txtEan13_KeyPress(object sender, KeyPressEventArgs e)
    {
      if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8)
      {
        e.Handled = true;
      }
    }

    private void FormCadCodBarras_KeyDown(object sender, KeyEventArgs e)
    {
      if (e.KeyCode == Keys.Enter)
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

    private void dataGridView1_KeyDown(object sender, KeyEventArgs e)
    {
      if (e.KeyCode == Keys.Delete)
      {
        DialogResult res = MessageBox.Show("Confirma a exclusão do código de barras selecionado?", "Exclusão", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
        if (res == DialogResult.Yes)
        {
          DataGridViewRow linhaAtual = dataGridView1.CurrentRow;
          int i = linhaAtual.Index;
          Produtos prod = new Produtos();
          prod.Ean = dataGridView1.Rows[i].Cells[0].Value.ToString();
          prod.ExcluirCodigoBarra();
          this.AtualizaGrid();
        }
      }
    }
  }
}
