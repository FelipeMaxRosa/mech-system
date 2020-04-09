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
  public partial class FormCadProdutos : Form
  {
    //Atributos
    //-------------------------------------------------------------------------
    bool novoProduto = false;
    public bool req_nomeprod = false;
    public bool req_idforn = false;
    bool ean_modif = false;
    string ean_atual = "";
    Produtos prod;

    //Construtor
    //-------------------------------------------------------------------------
    public FormCadProdutos(FormPrincipal parent)
    {
      InitializeComponent();
      this.MdiParent = parent;
      tbCodigoProduto.Focus();
    }

    //Métodos_Gerais
    //-------------------------------------------------------------------------
    public void VerificaRequisitos()
    {
      if (req_nomeprod == true && req_idforn == true && tbCodigoFornecedor.Text.Length > 0)
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
      btnConsultaFornecedor.Enabled = false;
      butEans.Enabled = false;
    }

    private void LimparCampos()
    {
      tbCodigoFornecedor.Clear();
      tbCodigoProduto.Clear();
      tbDescProduto.Clear();
      tbDescResumida.Clear();
      tbEan13.Clear();
      tbEstoqueAtual.Clear();
      tbUnidade.Clear();
      tbEstoqueMinimo.Clear();
      tbMarcaProduto.Clear();
      tbMargemLucro.Clear();
      tbMargemReal.Clear();
      tbNomeFornecedor.Clear();
      tbPrecoCusto.Clear();
      tbPrecoSugerido.Clear();
      tbPrecoVenda.Clear();
      cbxEmb.Text = "";
      cbxSituacao.Text = "";
      lblEstadoEstoque.Text = "";
    }

    private void HabiDesaCampos(bool flag)
    {
      //Read_Only
      tbCodigoFornecedor.ReadOnly = !flag;
      tbCodigoProduto.ReadOnly = flag;
      tbDescProduto.ReadOnly = !flag;
      tbDescResumida.ReadOnly = !flag;
      tbEan13.ReadOnly = !flag;
      tbEstoqueMinimo.ReadOnly = !flag;
      tbUnidade.ReadOnly = !flag;
      tbMarcaProduto.ReadOnly = !flag;
      tbMargemLucro.ReadOnly = !flag;
      tbPrecoCusto.ReadOnly = !flag;
      tbPrecoVenda.ReadOnly = !flag;
      tbUnidade.ReadOnly = !flag;

      //Tab_Stop
      tbPrecoVenda.TabStop = flag;
      tbPrecoCusto.TabStop = flag;
      tbMargemLucro.TabStop = flag;
      tbMarcaProduto.TabStop = flag;
      tbEstoqueMinimo.TabStop = flag;
      tbUnidade.TabStop = flag;
      tbEan13.TabStop = flag;
      tbDescResumida.TabStop = flag;
      tbDescProduto.TabStop = flag;
      tbCodigoProduto.TabStop = !flag;
      tbCodigoFornecedor.TabStop = flag;
      tbUnidade.TabStop = flag;
      cbxEmb.TabStop = flag;
      cbxSituacao.TabStop = flag;

      //Enabled
      cbxEmb.Enabled = flag;
      cbxSituacao.Enabled = flag;
    }

    public void CalcularMargemReal()
    {
      if (tbPrecoCusto.Text != "0,00" && tbPrecoVenda.Text != "0,00")
      {
        float custo = float.Parse(tbPrecoCusto.Text);
        float venda = float.Parse(tbPrecoVenda.Text);
        float margemReal = ((venda / custo) - 1) * 100;
        if (margemReal <= 0)
        {
          tbMargemReal.Text = "0,00";
        }
        else
        {
          tbMargemReal.Text = margemReal.ToString("0.00");
        }
      }
    }

    public void CalcularPrecoSugerido()
    {
      float custo = float.Parse(tbPrecoCusto.Text);
      float smargem = float.Parse(tbMargemLucro.Text) / 100;
      smargem = 1 + smargem;

      float precoSugerido = custo * smargem;
      tbPrecoSugerido.Text = precoSugerido.ToString("0.00");
    }

    //Metodos_Eventos
    //-------------------------------------------------------------------------
    private void tbCodigoEAN_KeyPress(object sender, KeyPressEventArgs e)
    {
      if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8)
      {
        e.Handled = true;
      }
    }

    private void maskedTextBox1_Leave(object sender, EventArgs e)
    {
      string ean = tbEan13.Text.Trim();
      ean = ean.Replace(" ", "");
      ean = ean.Replace("-", "");
      int a = ean.Length;
      if (a > 0)
      {
        ValidaEAN val = new ValidaEAN();
        string ean2 = val.SomenteNumeros(tbEan13.Text);
        bool valido = val.ValidarEAN(ean2);
        if (valido)
        {

        }
        else
        {
          MessageBox.Show("Código EAN ou dígito verificador inválido!", "EAN Inválido", MessageBoxButtons.OK, MessageBoxIcon.Error);
          tbEan13.Focus();
          tbEan13.SelectAll();
        }
      }
    }

    private void butSair_Click_1(object sender, EventArgs e)
    {
      this.Close();
    }

    private void butNovo_Click_1(object sender, EventArgs e)
    {
      novoProduto = true;
      this.LimparCampos();
      this.HabiDesaCampos(true);
      tbEstoqueAtual.ReadOnly = false;
      tbEstoqueAtual.TabStop = true;
      butNovo.Enabled = false;
      butCancelar.Enabled = true;
      butConsultar.Enabled = false;
      butAlterar.Enabled = false;
      butExcluir.Enabled = false;
      btnConsultaGeral.Enabled = false;
      btnConsultaFornecedor.Enabled = true;
      butEans.Enabled = false;
      this.CancelButton = butCancelar;
      tbPrecoCusto.Text = "0,00";
      tbPrecoVenda.Text = "0,00";
      tbMargemLucro.Text = "0,00";
      tbMargemReal.Text = "0,00";
      tbPrecoSugerido.Text = "0,00";
      tbEstoqueAtual.Text = "0";
      tbEstoqueMinimo.Text = "0";
      cbxSituacao.Text = "EM LINHA";
      cbxEmb.Text = "UN";
      tbUnidade.Text = "1";
      tbEan13.Focus();
    }

    private void butCancelar_Click(object sender, EventArgs e)
    {
      DialogResult res = MessageBox.Show("Deseja realmente cancelar a operação?", "Cancelar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
      if (res == DialogResult.Yes)
      {
        this.LimparCampos();
        this.HabiDesaCampos(false);
        tbEstoqueAtual.ReadOnly = true;
        tbEstoqueAtual.TabStop = false;
        this.OrganizaBotoes();
        tbCodigoProduto.Focus();
        this.CancelButton = butSair;
        novoProduto = false;
      }
    }

    private void butSalvar_Click(object sender, EventArgs e)
    {
      prod = new Produtos();
      prod.Ean = tbEan13.Text.Replace("-", "");
      prod.Descricao = tbDescProduto.Text;
      prod.DescResumida = tbDescResumida.Text;
      prod.Marca = tbMarcaProduto.Text;
      prod.Embalagem = cbxEmb.Text;
      prod.Unidade = Convert.ToInt32(tbUnidade.Text);
      prod.Margem = Convert.ToDecimal(tbMargemLucro.Text);
      prod.PrecoVenda = Convert.ToDecimal(tbPrecoVenda.Text);
      prod.EstoqueAtual = Convert.ToInt32(tbEstoqueAtual.Text);
      prod.IdFornecedor = Convert.ToInt32(tbCodigoFornecedor.Text);
      prod.EstoqueMinimo = Convert.ToInt32(tbEstoqueMinimo.Text);
      prod.Custo = Convert.ToDecimal(tbPrecoCusto.Text);
      prod.Estado = cbxSituacao.Text;

      if (novoProduto)
      {
        bool cadastrado = prod.VerificaEanCadastrado();
        if (cadastrado)
        {
          MessageBox.Show("Código EAN já cadastrado para outro produto!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
          tbEan13.Focus();
          tbEan13.Clear();
        }
        else
        {
          DialogResult res = MessageBox.Show("Confirma a inserção do registro?", "Novo Registro", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
          if (res == DialogResult.Yes)
          {
            prod.InserirProduto();
            //Executa Stored Procedure estado_produto
            prod.Call_SP_EstadoProduto();

            DataSet ds = prod.RetornaCodigo();
            tbCodigoProduto.Text = Convert.ToString(ds.Tables[0].Rows[0]["id"]);
            lblEstadoEstoque.Text = Convert.ToString(ds.Tables[0].Rows[0]["estado_estoque"]);
            //Executa Stored Procedure cad_ean;
            prod.Id = Convert.ToInt32(tbCodigoProduto.Text);
            if (tbEan13.Text.Length == 14)
            {
              prod.Call_SP_CadastraEan();
            }
            this.HabiDesaCampos(false);
            tbEstoqueAtual.ReadOnly = true;
            tbEstoqueAtual.TabStop = false;
            this.CancelButton = butSair;
            novoProduto = false;
            this.OrganizaBotoes();
            tbCodigoProduto.Focus();
            tbCodigoProduto.SelectAll();
            this.CancelButton = butSair;
            butAlterar.Enabled = true;
            butExcluir.Enabled = true;
            butSalvar.Enabled = false;
            butEans.Enabled = true;
          }
        }
      }
      else
      {
        DialogResult res = MessageBox.Show("Confirma a alteração do registro?", "Atualização", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
        if (res == DialogResult.Yes)
        {
          prod.Id = Convert.ToInt32(tbCodigoProduto.Text);
          prod.AlterarCadastro();
          //Executa Stored Procedure estado_produto
          prod.Call_SP_EstadoProduto();
          //Consulta novamente o produto para retornar o novo estado do estoque
          prod.LocalizaProduto();
          lblEstadoEstoque.Text = prod.EstadoEstoque;
          this.HabiDesaCampos(false);
          novoProduto = false;
          this.OrganizaBotoes();
          tbCodigoProduto.Focus();
          tbCodigoProduto.SelectAll();
          this.CancelButton = butSair;
          butAlterar.Enabled = true;
          butExcluir.Enabled = true;
          butSalvar.Enabled = false;
          butEans.Enabled = true;
        }
      }
    }

    private void FormCadProdutos_KeyDown(object sender, KeyEventArgs e)
    {
      if (e.KeyCode == Keys.F6)
      {
        if (btnConsultaGeral.Enabled)
        {
          LimparCampos();
          OrganizaBotoes();
          butAlterar.Enabled = false;
          FormGridProdutos grid = new FormGridProdutos(this, "produtos");
          grid.MdiParent = this.ParentForm;
          grid.Show();
        }
        else if (tbCodigoFornecedor.Focused == true || tbNomeFornecedor.Focused == true)
        {
          tbCodigoFornecedor.Clear();
          tbNomeFornecedor.Clear();
          FormGridFornecedores grid = new FormGridFornecedores(this, "produtos");
          grid.MdiParent = this.ParentForm;
          grid.Show();
        }
      }
      else if (e.KeyCode == Keys.F2)
      {
        if (tbCodigoFornecedor.Focused == true || tbNomeFornecedor.Focused == true)
        {
          FormCadFornecedores cadForn = new FormCadFornecedores((FormPrincipal)this.MdiParent);
          cadForn.MdiParent = this.ParentForm;
          cadForn.Show();
        }
      }
      else if (e.KeyCode == Keys.F7)
      {
        if (tbCodigoProduto.Text.Length > 0 && tbDescProduto.Text.Length > 0)
        {
          FormCadCodBarras barcode = new FormCadCodBarras();
          barcode.IdProduto = Convert.ToInt32(tbCodigoProduto.Text);
          barcode.gpbCodBarras.Text = tbDescProduto.Text;
          barcode.MdiParent = this.ParentForm;
          barcode.Show();
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

    private void tbCodigoFornecedor_Leave(object sender, EventArgs e)
    {
      if (tbCodigoFornecedor.Text.Length == 0)
      {

      }
      else
      {
        Fornecedor forn = new Fornecedor();
        forn.IdFornecedor = Convert.ToInt32(tbCodigoFornecedor.Text);

        forn.LocalizaFornecedor();
        if (forn.RazaoSocial != null)
        {
          tbNomeFornecedor.Text = forn.RazaoSocial;
          req_idforn = true;
          this.VerificaRequisitos();
          cbxEmb.Focus();
        }
        else
        {
          tbNomeFornecedor.Clear();
          tbCodigoFornecedor.Focus();
          tbCodigoFornecedor.SelectAll();
          req_idforn = false;
          this.VerificaRequisitos();
        }
      }
    }

    private void tbDescProduto_Leave(object sender, EventArgs e)
    {
      if (tbDescProduto.Text.Length > 0)
      {
        req_nomeprod = true;
        this.VerificaRequisitos();
      }
      else
      {
        req_nomeprod = false;
        this.VerificaRequisitos();
      }
    }

    private void tbMargemLucro_Leave(object sender, EventArgs e)
    {
      if (tbMargemLucro.Text.Length == 0)
      {
        tbMargemLucro.Text = "0,00";
      }
      else
      {
        float margem = float.Parse(tbMargemLucro.Text);
        tbMargemLucro.Text = margem.ToString("0.00");
        this.CalcularPrecoSugerido();
        this.CalcularMargemReal();
      }
    }

    private void tbPrecoCusto_Leave(object sender, EventArgs e)
    {
      if (tbPrecoCusto.Text.Length == 0 || tbPrecoCusto.Text == "0,00")
      {
        tbPrecoCusto.Text = "0,00";
        tbMargemReal.Text = "0,00";
        tbPrecoSugerido.Text = "0,00";
      }
      else
      {
        decimal custo = Convert.ToDecimal(tbPrecoCusto.Text);
        tbPrecoCusto.Text = custo.ToString("0.00");
        this.CalcularPrecoSugerido();
        this.CalcularMargemReal();
      }
    }

    private void tbPrecoVenda_Leave(object sender, EventArgs e)
    {
      if (tbPrecoVenda.Text.Length == 0)
      {
        tbPrecoVenda.Text = "0,00";
        tbMargemReal.Text = "0,00";
      }
      else
      {
        float venda = float.Parse(tbPrecoVenda.Text);
        tbPrecoVenda.Text = venda.ToString("0.00");
        this.CalcularMargemReal();
      }
    }

    private void butConsultar_Click(object sender, EventArgs e)
    {
      if (tbCodigoProduto.Text.Length == 0)
      {
        LimparCampos();
        OrganizaBotoes();
        butAlterar.Enabled = false;
        FormGridProdutos grid = new FormGridProdutos(this, "produtos");
        grid.MdiParent = this.ParentForm;
        grid.Show();
      }
      else
      {
        prod = new Produtos();
        prod.Id = Convert.ToInt32(tbCodigoProduto.Text);
        prod.LocalizaProduto();

        if (prod.Descricao != null)
        {
          tbCodigoFornecedor.Text = Convert.ToString(prod.IdFornecedor);
          this.req_idforn = true;

          Fornecedor forn = new Fornecedor();
          forn.IdFornecedor = Convert.ToInt32(tbCodigoFornecedor.Text);
          forn.LocalizaFornecedor();
          tbNomeFornecedor.Text = forn.RazaoSocial;
          tbUnidade.Text = Convert.ToString(prod.Unidade);
          cbxEmb.Text = prod.Embalagem;
          cbxSituacao.Text = prod.Estado;

          tbDescProduto.Text = prod.Descricao;
          this.req_nomeprod = true;

          tbDescResumida.Text = prod.DescResumida;
          tbEan13.Text = prod.Ean;
          tbEstoqueAtual.Text = Convert.ToString(prod.EstoqueAtual);
          tbEstoqueMinimo.Text = Convert.ToString(prod.EstoqueMinimo);
          tbMarcaProduto.Text = prod.Marca;
          tbMargemLucro.Text = prod.Margem.ToString("0.00");
          tbPrecoCusto.Text = prod.Custo.ToString("0.00");
          tbPrecoVenda.Text = prod.PrecoVenda.ToString("0.00");
          lblEstadoEstoque.Text = prod.EstadoEstoque;
          this.CalcularMargemReal();
          this.CalcularPrecoSugerido();
          butAlterar.Enabled = true;
          butExcluir.Enabled = true;
          butNovo.Focus();
        }
        else
        {
          this.LimparCampos();
          this.OrganizaBotoes();
          tbCodigoProduto.SelectAll();
        }        
      }
    }

    private void butAlterar_Click(object sender, EventArgs e)
    {
      novoProduto = false;
      this.HabiDesaCampos(true);
      tbEan13.ReadOnly = true;
      tbEan13.TabStop = false;
      tbDescProduto.Focus();
      tbDescProduto.SelectAll();
      butAlterar.Enabled = false;
      butCancelar.Enabled = true;
      butConsultar.Enabled = false;
      butExcluir.Enabled = false;
      butNovo.Enabled = false;
      butSalvar.Enabled = true;
      btnConsultaGeral.Enabled = false;
      btnConsultaFornecedor.Enabled = true;
      this.CancelButton = butCancelar;
      this.ean_atual = tbEan13.Text;
    }

    private void tbCodigoFornecedor_KeyPress(object sender, KeyPressEventArgs e)
    {
      if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8)
      {
        e.Handled = true;
      }
    }

    private void tbCodigoProduto_KeyPress(object sender, KeyPressEventArgs e)
    {
      if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8)
      {
        e.Handled = true;
      }
    }

    private void tbPrecoCusto_KeyPress(object sender, KeyPressEventArgs e)
    {
      if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8 && e.KeyChar != ',')
      {
        e.Handled = true;
      }
    }

    private void tbMargemLucro_KeyPress(object sender, KeyPressEventArgs e)
    {
      if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8 && e.KeyChar != ',')
      {
        e.Handled = true;
      }
    }

    private void tbPrecoVenda_KeyPress(object sender, KeyPressEventArgs e)
    {
      if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8 && e.KeyChar != ',')
      {
        e.Handled = true;
      }
    }

    private void tbEstoqueMinimo_KeyPress(object sender, KeyPressEventArgs e)
    {
      if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8)
      {
        e.Handled = true;
      }
    }

    private void cbUnidade_KeyPress(object sender, KeyPressEventArgs e)
    {
      if (!Char.IsLetter(e.KeyChar) && e.KeyChar != (char)8)
      {
        e.Handled = true;
      }
    }

    private void butExcluir_Click(object sender, EventArgs e)
    {
      DialogResult res = MessageBox.Show("Confirma a exclusão do registro?", "Exclusão", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
      if (res == DialogResult.Yes)
      {
        prod = new Produtos();
        prod.Id = Convert.ToInt32(tbCodigoProduto.Text);
        prod.ExcluirProduto();
        this.LimparCampos();
        this.HabiDesaCampos(false);
        this.OrganizaBotoes();
        tbCodigoProduto.Focus();
      }
    }

    private void btnConsultaGeral_Click(object sender, EventArgs e)
    {
      LimparCampos();
      OrganizaBotoes();
      butAlterar.Enabled = false;
      FormGridProdutos grid = new FormGridProdutos(this, "produtos");
      grid.MdiParent = this.ParentForm;
      grid.Show();
    }

    private void gbProduto_Enter(object sender, EventArgs e)
    {
      
    }

    private void gbProduto_Leave(object sender, EventArgs e)
    {
      
    }

    private void btnConsultaFornecedor_Click(object sender, EventArgs e)
    {
      tbCodigoFornecedor.Clear();
      tbNomeFornecedor.Clear();
      FormGridFornecedores grid = new FormGridFornecedores(this, "produtos");
      grid.MdiParent = this.ParentForm;
      grid.Show();
    }

    private void FormCadProdutos_KeyPress(object sender, KeyPressEventArgs e)
    {

    }

    private void tbCodigoProduto_Leave(object sender, EventArgs e)
    {
      if (tbCodigoProduto.Text.Length == 0)
      {

      }
      else
      {
        prod = new Produtos();
        prod.Id = Convert.ToInt32(tbCodigoProduto.Text);
        prod.LocalizaProduto();

        if (prod.Descricao != null)
        {
          tbCodigoFornecedor.Text = Convert.ToString(prod.IdFornecedor);
          this.req_idforn = true;

          Fornecedor forn = new Fornecedor();
          forn.IdFornecedor = Convert.ToInt32(tbCodigoFornecedor.Text);
          forn.LocalizaFornecedor();
          tbNomeFornecedor.Text = forn.RazaoSocial;
          tbUnidade.Text = Convert.ToString(prod.Unidade);
          cbxEmb.Text = prod.Embalagem;
          cbxSituacao.Text = prod.Estado;

          tbDescProduto.Text = prod.Descricao;
          this.req_nomeprod = true;

          tbDescResumida.Text = prod.DescResumida;
          tbEan13.Text = prod.Ean;
          tbEstoqueAtual.Text = Convert.ToString(prod.EstoqueAtual);
          tbEstoqueMinimo.Text = Convert.ToString(prod.EstoqueMinimo);
          tbMarcaProduto.Text = prod.Marca;
          tbMargemLucro.Text = prod.Margem.ToString("0.00");
          tbPrecoCusto.Text = prod.Custo.ToString("0.00");
          tbPrecoVenda.Text = prod.PrecoVenda.ToString("0.00");
          lblEstadoEstoque.Text = prod.EstadoEstoque;
          this.CalcularMargemReal();
          this.CalcularPrecoSugerido();
          butAlterar.Enabled = true;
          butExcluir.Enabled = true;
          butEans.Enabled = true;
          butNovo.Focus();
        }
        else
        {
          this.LimparCampos();
          this.OrganizaBotoes();
          tbCodigoProduto.Select();
        }          
      }
    }

    private void butEans_Click(object sender, EventArgs e)
    {
      FormCadCodBarras barcode = new FormCadCodBarras();
      barcode.IdProduto = Convert.ToInt32(tbCodigoProduto.Text);
      barcode.gpbCodBarras.Text = tbDescProduto.Text;
      barcode.MdiParent = this.ParentForm;
      barcode.Show();
    }

    private void tbCodigoProduto_Enter(object sender, EventArgs e)
    {
      tbCodigoProduto.SelectAll();
    }
  }
}
