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
  public partial class FormRelProdForn : Form
  {
    //Atributos
    private int idFornecedor;
    private string estadoProduto;

    //Construtor
    public FormRelProdForn()
    {
      InitializeComponent();
      idFornecedor = 1;
    }

    //Propriedades
    public int IdFornecedor
    {
      get { return idFornecedor; }
      set { idFornecedor = value; }
    }
    public string EstadoProduto
    {
      get { return estadoProduto; }
      set { estadoProduto = value; }
    }

    private void FormRelProdForn_Load(object sender, EventArgs e)
    {
      // TODO: This line of code loads data into the 'dsProdForn.fornecedor' table. You can move, or remove it, as needed.
      this.fornecedorTableAdapter.Fill(this.dsProdForn.fornecedor, idFornecedor);
      // TODO: This line of code loads data into the 'dsProdForn.produtos' table. You can move, or remove it, as needed.
      this.produtosTableAdapter.Fill(this.dsProdForn.produtos, idFornecedor);

      this.reportViewer1.RefreshReport();
    }
  }
}
