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
  public partial class FormGridProdutos : Form
  {
    //Atributos
    private DataSet ds;
    private BancoDados bd;
    private FormCadProdutos prod;
    private FormAjuEstoque ajuste;
    private FormCadOs os;

    //Construtor
    public FormGridProdutos(object frm1, string tipoobj)
    {
      InitializeComponent();
      bd = new BancoDados();
      if (tipoobj == "produtos")
      {
        prod = (FormCadProdutos)frm1;
      }
      else if (tipoobj == "ajuste")
      {
        ajuste = (FormAjuEstoque)frm1;
      }
      else if (tipoobj == "os")
      {
        os = (FormCadOs)frm1;
      }
      txtPesquisa.Focus();
    }

    //Metodos_Gerais
    private delegate void PosicionaCursorDelegate(int posicao);

    private void PosicionaCursor(int posicao)
    {
      this.tbEan13.SelectionStart = posicao;
    }

    //Metodos_Eventos
    private void butSair_Click(object sender, EventArgs e)
    {
      if (os != null)
      {
        /*
        if (os.butCancelar.Enabled == true)
        {
          os.CancelButton = os.butCancelar;
        }
        else
        {
          os.CancelButton = os.butSair;
        }
        */
        os.txtCodigoPeca.Focus();
      }
      else if (ajuste != null)
      {
        ajuste.tbCodigo.Focus();
      }
      else if (prod != null)
      {
        prod.tbCodigoProduto.Focus();
      }
      this.Close();
    }

    private void FormGridProdutos_Load(object sender, EventArgs e)
    {
      //string SQL = "SELECT id, ean, descricao, estado, descricaoresumida, marca, embalagem, unidade, venda, margemlucro, estoqueminimo, estoque, idfornecedor, custo, estado_estoque FROM produtos WHERE estado = 'EM LINHA' ORDER BY descricao";
      string SQL2 = "SELECT id, descricao, estado, descricaoresumida, marca, embalagem, unidade, venda, margemlucro, estoqueminimo, estoque, idfornecedor, custo, estado_estoque FROM produtos WHERE estado = 'EM LINHA' ORDER BY descricao";
      string tabela = "produtos";
      ds = new DataSet();
      ds = bd.ConsultarParaGrid(SQL2, tabela);
      dataGridView1.DataSource = ds.Tables["produtos"];
      cbxEstadoEstoque.Text = "TODOS";
      cbxSituacao.Text = "EM LINHA";
    }

    private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
    {
      if (e.RowIndex < 0)
      {
      }
      else
      {
        if (prod != null)
        {
          prod.tbCodigoProduto.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
          //prod.tbEan13.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
          prod.tbDescProduto.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
          prod.req_nomeprod = true;
          prod.cbxSituacao.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
          prod.tbDescResumida.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
          prod.tbMarcaProduto.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
          prod.cbxEmb.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
          prod.tbUnidade.Text = dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString();
          prod.tbPrecoVenda.Text = dataGridView1.Rows[e.RowIndex].Cells[7].Value.ToString();
          prod.tbMargemLucro.Text = dataGridView1.Rows[e.RowIndex].Cells[8].Value.ToString();
          prod.tbEstoqueMinimo.Text = dataGridView1.Rows[e.RowIndex].Cells[9].Value.ToString();
          prod.tbEstoqueAtual.Text = dataGridView1.Rows[e.RowIndex].Cells[10].Value.ToString();
          prod.tbCodigoFornecedor.Text = dataGridView1.Rows[e.RowIndex].Cells[11].Value.ToString();
          prod.req_idforn = true;
          //Preenche campo fornecedor
          //-------------------------------------------------------------------------
          Fornecedor forn = new Fornecedor();
          forn.IdFornecedor = Convert.ToInt32(prod.tbCodigoFornecedor.Text);
          forn.LocalizaFornecedor();
          prod.tbNomeFornecedor.Text = forn.RazaoSocial;
          prod.lblEstadoEstoque.Text = dataGridView1.Rows[e.RowIndex].Cells[13].Value.ToString();
          //Preenche campo EAN13
          //-------------------------------------------------------------------------
          Produtos pr = new Produtos();
          pr.LocalizaEan(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
          prod.tbEan13.Text = pr.Ean;

          prod.tbPrecoCusto.Text = dataGridView1.Rows[e.RowIndex].Cells[12].Value.ToString();
          prod.CalcularMargemReal();
          prod.CalcularPrecoSugerido();

          prod.butAlterar.Enabled = true;
          prod.butExcluir.Enabled = true;
          prod.butEans.Enabled = true;
          prod.butNovo.Focus();
        }
        else if (os != null)
        {
          os.txtCodigoPeca.Text = Convert.ToString(dataGridView1.Rows[e.RowIndex].Cells[0].Value);
          os.txtCodigoPeca.Focus();
          os.txtQtdePeca.Focus();
        }
        else if (ajuste != null)
        {
          ajuste.tbCodigo.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
          ajuste.lblDescricao.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
          ajuste.butSalvar.Enabled = true;
          ajuste.tbQtde.Focus();
        }
        this.Dispose();
      }
    }

    private void btnPesquisar_Click(object sender, EventArgs e)
    {
      if (radDescricao.Checked)
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
      else if (radEan.Checked)
      {
        string SQL = "SELECT * FROM cod_barras WHERE ean13 LIKE ('" + tbEan13.Text.Replace("-","") + "%') ORDER BY ean13 ASC LIMIT 1";
        string tabela = "cod_barras";
        ds = bd.ConsultarRegistro(SQL, tabela);
        if (ds.Tables[0].Rows.Count > 0)
        {
          for (int i = 0; i < dataGridView1.RowCount; i++)
          {
            if (dataGridView1.Rows[i].Cells[0].Value.ToString().Contains(ds.Tables[0].Rows[0]["idproduto"].ToString()))
            {
              dataGridView1.Focus();
              dataGridView1.FirstDisplayedScrollingRowIndex = i;
              dataGridView1.Refresh();
              dataGridView1.CurrentCell = dataGridView1.Rows[i].Cells[0];
              dataGridView1.Rows[i].Selected = true;
              this.CancelButton = null;
              break;
            }
          }
        }
        else
        {
          MessageBox.Show("Nenhum registro encontrado com essas informações!", "Pesquisa", MessageBoxButtons.OK, MessageBoxIcon.Warning);
          tbEan13.SelectAll();
        }
      }
    }

    private void dataGridView1_KeyDown(object sender, KeyEventArgs e)
    {
      if (e.KeyCode == Keys.Enter)
      {
        DataGridViewRow linhaAtual = dataGridView1.CurrentRow;
        int i = linhaAtual.Index;
        if (prod != null)
        {
          prod.tbCodigoProduto.Text = dataGridView1.Rows[i].Cells[0].Value.ToString();
          //prod.tbEan13.Text = dataGridView1.Rows[i].Cells[1].Value.ToString();
          prod.tbDescProduto.Text = dataGridView1.Rows[i].Cells[1].Value.ToString();
          prod.req_nomeprod = true;
          prod.cbxSituacao.Text = dataGridView1.Rows[i].Cells[2].Value.ToString();
          prod.tbDescResumida.Text = dataGridView1.Rows[i].Cells[3].Value.ToString();
          prod.tbMarcaProduto.Text = dataGridView1.Rows[i].Cells[4].Value.ToString();
          prod.cbxEmb.Text = dataGridView1.Rows[i].Cells[5].Value.ToString();
          prod.tbUnidade.Text = dataGridView1.Rows[i].Cells[6].Value.ToString();
          prod.tbPrecoVenda.Text = dataGridView1.Rows[i].Cells[7].Value.ToString();
          prod.tbMargemLucro.Text = dataGridView1.Rows[i].Cells[8].Value.ToString();
          prod.tbEstoqueMinimo.Text = dataGridView1.Rows[i].Cells[9].Value.ToString();
          prod.tbEstoqueAtual.Text = dataGridView1.Rows[i].Cells[10].Value.ToString();
          prod.tbCodigoFornecedor.Text = dataGridView1.Rows[i].Cells[11].Value.ToString();
          prod.req_idforn = true;
          //Preenche campo fornecedor
          //-------------------------------------------------------------------------
          Fornecedor forn = new Fornecedor();
          forn.IdFornecedor = Convert.ToInt32(prod.tbCodigoFornecedor.Text);
          forn.LocalizaFornecedor();
          prod.tbNomeFornecedor.Text = forn.RazaoSocial;
          //Preenche campo EAN13
          //-------------------------------------------------------------------------
          Produtos pr = new Produtos();
          pr.LocalizaEan(dataGridView1.Rows[i].Cells[0].Value.ToString());
          prod.tbEan13.Text = pr.Ean;

          prod.tbPrecoCusto.Text = dataGridView1.Rows[i].Cells[12].Value.ToString();
          prod.lblEstadoEstoque.Text = dataGridView1.Rows[i].Cells[13].Value.ToString();
          prod.CalcularMargemReal();
          prod.CalcularPrecoSugerido();

          prod.butAlterar.Enabled = true;
          prod.butExcluir.Enabled = true;
          prod.butEans.Enabled = true;
          prod.butNovo.Focus();
        }
        else if (os != null)
        {
          os.txtCodigoPeca.Text = dataGridView1.Rows[i].Cells[0].Value.ToString();
          os.txtCodigoPeca.Focus();
          os.txtQtdePeca.Focus();
          
        }
        else if (ajuste != null)
        {
          ajuste.tbCodigo.Text = dataGridView1.Rows[i].Cells[0].Value.ToString();
          ajuste.lblDescricao.Text = dataGridView1.Rows[i].Cells[1].Value.ToString();
          ajuste.butSalvar.Enabled = true;
          ajuste.tbQtde.Focus();
        }

        this.Dispose();
      }
      else if (e.KeyCode == Keys.Escape)
      {
        radDescricao.Checked = true;
        txtPesquisa.Clear();
        txtPesquisa.Focus();
        this.CancelButton = butSair;
      }
      else if (e.KeyCode == Keys.F7)
      {
        DataGridViewRow linhaAtual = dataGridView1.CurrentRow;
        int i = linhaAtual.Index;
        FormCadCodBarras barcode = new FormCadCodBarras();
        barcode.IdProduto = Convert.ToInt32(dataGridView1.Rows[i].Cells[0].Value);
        barcode.gpbCodBarras.Text = dataGridView1.Rows[i].Cells[1].Value.ToString();
        barcode.MdiParent = this.ParentForm;
        barcode.Show();
      }
    }

    private void dataGridView1_Leave(object sender, EventArgs e)
    {
      this.CancelButton = butSair;
    }

    private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
    {
      if (dataGridView1.RowCount > 0)
      {
        if (dataGridView1.Rows[e.RowIndex].Cells["estado_estoque"].Value.ToString() == "ABAIXO DO MINIMO")
        {
          e.CellStyle.ForeColor = Color.Red;
          e.CellStyle.Font = new Font(this.Font, FontStyle.Bold);
        }
      }
    }

    private void radioButton2_CheckedChanged(object sender, EventArgs e)
    {
      txtPesquisa.Clear();
      txtPesquisa.Enabled = false;
      tbEan13.Clear();
      tbEan13.Enabled = true;
      tbEan13.Focus();
    }

    private void radioButton1_CheckedChanged(object sender, EventArgs e)
    {
      tbEan13.Clear();
      tbEan13.Enabled = false;
      txtPesquisa.Clear();
      txtPesquisa.Enabled = true;
      txtPesquisa.Focus();
    }

    private void cbxSituacao_SelectedIndexChanged(object sender, EventArgs e)
    {
      string SQL = "";
      if (cbxSituacao.Text != "TODOS" && cbxEstadoEstoque.Text != "TODOS")
      {
        SQL = "SELECT id, descricao, estado, descricaoresumida, marca, embalagem, unidade, venda, margemlucro, estoqueminimo, estoque, idfornecedor, custo, estado_estoque FROM produtos WHERE estado = '" + cbxSituacao.Text + "' AND estado_estoque = '" + cbxEstadoEstoque.Text + "' ORDER BY descricao";

      }
      else if (cbxSituacao.Text == "TODOS" && cbxEstadoEstoque.Text != "TODOS")
      {
        SQL = "SELECT id, descricao, estado, descricaoresumida, marca, embalagem, unidade, venda, margemlucro, estoqueminimo, estoque, idfornecedor, custo, estado_estoque FROM produtos WHERE estado_estoque = '" + cbxEstadoEstoque.Text + "' ORDER BY descricao";
      }
      else if (cbxSituacao.Text != "TODOS" && cbxEstadoEstoque.Text == "TODOS")
      {
        SQL = "SELECT id, descricao, estado, descricaoresumida, marca, embalagem, unidade, venda, margemlucro, estoqueminimo, estoque, idfornecedor, custo, estado_estoque FROM produtos WHERE estado = '" + cbxSituacao.Text + "' ORDER BY descricao";
      }
      else
      {
        SQL = "SELECT id, descricao, estado, descricaoresumida, marca, embalagem, unidade, venda, margemlucro, estoqueminimo, estoque, idfornecedor, custo, estado_estoque FROM produtos ORDER BY descricao";
      }
      string tabela = "produtos";
      ds = new DataSet();
      ds = bd.ConsultarParaGrid(SQL, tabela);
      dataGridView1.DataSource = ds.Tables["produtos"];
    }

    private void cbxEstadoEstoque_SelectedIndexChanged(object sender, EventArgs e)
    {
      string SQL = "";
      if (cbxSituacao.Text != "TODOS" && cbxEstadoEstoque.Text != "TODOS")
      {
        SQL = "SELECT id, descricao, estado, descricaoresumida, marca, embalagem, unidade, venda, margemlucro, estoqueminimo, estoque, idfornecedor, custo, estado_estoque FROM produtos WHERE estado = '" + cbxSituacao.Text + "' AND estado_estoque = '" + cbxEstadoEstoque.Text + "' ORDER BY descricao";

      }
      else if (cbxSituacao.Text == "TODOS" && cbxEstadoEstoque.Text != "TODOS")
      {
        SQL = "SELECT id, descricao, estado, descricaoresumida, marca, embalagem, unidade, venda, margemlucro, estoqueminimo, estoque, idfornecedor, custo, estado_estoque FROM produtos WHERE estado_estoque = '" + cbxEstadoEstoque.Text + "' ORDER BY descricao";
      }
      else if (cbxSituacao.Text != "TODOS" && cbxEstadoEstoque.Text == "TODOS")
      {
        SQL = "SELECT id, descricao, estado, descricaoresumida, marca, embalagem, unidade, venda, margemlucro, estoqueminimo, estoque, idfornecedor, custo, estado_estoque FROM produtos WHERE estado = '" + cbxSituacao.Text + "' ORDER BY descricao";
      }
      else
      {
        SQL = "SELECT id, descricao, estado, descricaoresumida, marca, embalagem, unidade, venda, margemlucro, estoqueminimo, estoque, idfornecedor, custo, estado_estoque FROM produtos ORDER BY descricao";
      }
      string tabela = "produtos";
      ds = new DataSet();
      ds = bd.ConsultarParaGrid(SQL, tabela);
      dataGridView1.DataSource = ds.Tables["produtos"];
    }

    private void dataGridView1_Enter(object sender, EventArgs e)
    {
      this.CancelButton = null;
    }
  }
}
