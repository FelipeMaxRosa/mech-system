using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;
using System.Data;
using System.Windows.Forms;

namespace MechSystem
{
  class Produtos
  {
    //Atributos
    private BancoDados bd;
    private MySqlCommand cmd;
    private MySqlCommand cmd2;
    private DataSet ds;
    private DataTable dt;
    private string usuario;

    //Propriedades
    public string Usuario
    {
      get { return usuario; }
      set { usuario = value; }
    }

    //Atributos do Objeto
    private int id;
    private string ean;
    private string descricao;
    private string descResumida;
    private string embalagem;
    private int unidade;
    private string marca;
    private decimal margem;
    private decimal custo;
    private decimal precoVenda;
    private int estoqueAtual;
    private int estoqueMinimo;
    private int idFornecedor;
    private string estado;
    private string estadoEstoque;

    //Construtor
    public Produtos()
    {
      bd = new BancoDados();
      cmd = new MySqlCommand();
      cmd2 = new MySqlCommand();
    }

    //Propriedades
    public int Id
    {
      get { return id; }
      set { id = value; }
    }
    public string Ean
    {
      get { return ean; }
      set { ean = value; }
    }
    public string Descricao
    {
      get { return descricao; }
      set { descricao = value; }
    }    
    public string DescResumida
    {
      get { return descResumida; }
      set { descResumida = value; }
    }
    public int Unidade
    {
      get { return unidade; }
      set { unidade = value; }
    }
    public string Embalagem
    {
      get { return embalagem; }
      set { embalagem = value; }
    }
    public string Marca
    {
      get { return marca; }
      set { marca = value; }
    }
    public decimal Margem
    {
      get { return margem; }
      set { margem = value; }
    }
    public decimal PrecoVenda
    {
      get { return precoVenda; }
      set { precoVenda = value; }
    }
    public int EstoqueAtual
    {
      get { return estoqueAtual; }
      set { estoqueAtual = value; }
    }
    public int EstoqueMinimo
    {
      get { return estoqueMinimo; }
      set { estoqueMinimo = value; }
    }
    public int IdFornecedor
    {
      get { return idFornecedor; }
      set { idFornecedor = value; }
    }
    public decimal Custo
    {
      get { return custo; }
      set { custo = value; }
    }
    public string Estado
    {
      get { return estado; }
      set { estado = value; }
    }
    public string EstadoEstoque
    {
      get { return estadoEstoque; }
      set { estadoEstoque = value; }
    }

    //Métodos
    public void InserirProduto()
    {
      //string SQL = "INSERT INTO produtos (EAN, descricao, descricaoresumida, unidade, margemlucro, venda, estoque, marca, idfornecedor, estoqueminimo, custo, embalagem, estado) VALUES (@EAN, @descricao, @descricaoresumida, @unidade, @margemlucro, @venda, @estoque, @marca, @idfornecedor, @estoqueminimo, @custo, @emb, @estado)";
      string SQL = "INSERT INTO produtos (descricao, descricaoresumida, unidade, margemlucro, venda, estoque, marca, idfornecedor, estoqueminimo, custo, embalagem, estado) VALUES (@descricao, @descricaoresumida, @unidade, @margemlucro, @venda, @estoque, @marca, @idfornecedor, @estoqueminimo, @custo, @emb, @estado)";
      cmd.CommandText = SQL;
      cmd.Parameters.Clear();

      //MySqlParameter pEan = new MySqlParameter("@EAN", ean);
      //cmd.Parameters.Add(pEan);
      MySqlParameter pDescricao = new MySqlParameter("@descricao", descricao);
      cmd.Parameters.Add(pDescricao);
      MySqlParameter pDescRes = new MySqlParameter("@descricaoresumida", descResumida);
      cmd.Parameters.Add(pDescRes);
      MySqlParameter pUnid = new MySqlParameter("@unidade", unidade);
      cmd.Parameters.Add(pUnid);
      MySqlParameter pMargem = new MySqlParameter("@margemlucro", margem);
      cmd.Parameters.Add(pMargem);
      MySqlParameter pVenda = new MySqlParameter("@venda", precoVenda);
      cmd.Parameters.Add(pVenda);
      MySqlParameter pEstoque = new MySqlParameter("@estoque", estoqueAtual);
      cmd.Parameters.Add(pEstoque);
      MySqlParameter pMarca = new MySqlParameter("@marca", marca);
      cmd.Parameters.Add(pMarca);
      MySqlParameter pIdForn = new MySqlParameter("@idfornecedor", idFornecedor);
      cmd.Parameters.Add(pIdForn);
      MySqlParameter pEstMin = new MySqlParameter("@estoqueminimo", estoqueMinimo);
      cmd.Parameters.Add(pEstMin);
      MySqlParameter pCusto = new MySqlParameter("@custo", custo);
      cmd.Parameters.Add(pCusto);
      MySqlParameter pEmb = new MySqlParameter("@emb", embalagem);
      cmd.Parameters.Add(pEmb);
      MySqlParameter pEst = new MySqlParameter("@estado", estado);
      cmd.Parameters.Add(pEst);
      
      bd.InserirRegistro(cmd);
      if (bd.Cont > 0)
      {
        MessageBox.Show("Registro inserido com sucesso!", "Registro Inserido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        bd.Cont = 0;
      }
    }

    public DataSet RetornaCodigo()
    {
      string SQL = "SELECT id, estado_estoque FROM produtos WHERE descricao = '"+ descricao +"' ORDER BY id DESC LIMIT 1";
      string tabela = "produtos";
      ds = bd.ConsultarRegistro(SQL, tabela);

      return ds;
    }

    public bool VerificaEanCadastrado()
    {
      bool cadastrado = false;
      string SQL = "SELECT COUNT(*) FROM cod_barras WHERE ean13 = @ean";
      cmd.CommandText = SQL;

      MySqlParameter pEan = new MySqlParameter("@ean", ean);
      cmd.Parameters.Add(pEan);

      cadastrado = bd.VerificarRegistro(cmd);        
      return cadastrado;
    }

    public void AlterarCadastro()
    {
      //string SQL = "UPDATE produtos SET ean = @ean, descricao = @desc, descricaoresumida = @descres, unidade = @unidade, margemlucro = @margemlucro, venda = @venda, marca = @marca, idfornecedor = @idforn, estoqueminimo = @estmin, custo = @custo, embalagem = @emb, estado = @estado WHERE id = @id";
      string SQL = "UPDATE produtos SET descricao = @desc, descricaoresumida = @descres, unidade = @unidade, margemlucro = @margemlucro, venda = @venda, marca = @marca, idfornecedor = @idforn, estoqueminimo = @estmin, custo = @custo, embalagem = @emb, estado = @estado WHERE id = @id";
      cmd.CommandText = SQL;
      cmd.Parameters.Clear();

      //MySqlParameter pEan = new MySqlParameter("@ean", ean);
      //cmd.Parameters.Add(pEan);
      MySqlParameter pDesc = new MySqlParameter("@desc", descricao);
      cmd.Parameters.Add(pDesc);
      MySqlParameter pDescRes = new MySqlParameter("@descres", descResumida);
      cmd.Parameters.Add(pDescRes);
      MySqlParameter pUnid = new MySqlParameter("@unidade", unidade);
      cmd.Parameters.Add(pUnid);
      MySqlParameter pMarg = new MySqlParameter("@margemlucro", margem);
      cmd.Parameters.Add(pMarg);
      MySqlParameter pVenda = new MySqlParameter("@venda", precoVenda);
      cmd.Parameters.Add(pVenda);
      MySqlParameter pMarca = new MySqlParameter("@marca", marca);
      cmd.Parameters.Add(pMarca);
      MySqlParameter pIdForn = new MySqlParameter("@idforn", idFornecedor);
      cmd.Parameters.Add(pIdForn);
      MySqlParameter pEstMin = new MySqlParameter("@estmin", estoqueMinimo);
      cmd.Parameters.Add(pEstMin);
      MySqlParameter pCusto = new MySqlParameter("@custo", custo);
      cmd.Parameters.Add(pCusto);
      MySqlParameter pEmb = new MySqlParameter("@emb", embalagem);
      cmd.Parameters.Add(pEmb);
      MySqlParameter pEst = new MySqlParameter("@estado", estado);
      cmd.Parameters.Add(pEst);
      MySqlParameter pId = new MySqlParameter("@id", id);
      cmd.Parameters.Add(pId);

      bd.AtualizarRegistro(cmd);
      if (bd.Cont > 0)
      {
        MessageBox.Show("Registro atualizado com sucesso!", "Atualização", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        bd.Cont = 0;
      }
    }

    public void LocalizaProduto()
    {
      bool localizado = false;
      string SQL = "SELECT COUNT(*) FROM produtos WHERE id = @id";
      cmd = new MySqlCommand();
      cmd.CommandText = SQL;
      MySqlParameter pId = new MySqlParameter("@id", id);
      cmd.Parameters.Add(pId);

      localizado = bd.VerificarRegistro(cmd);
      if (localizado)
      {
        SQL = "SELECT * FROM produtos WHERE id = '" + id + "'";
        string tabela = "produtos";

        ds = bd.ConsultarRegistro(SQL, tabela);
        //ean = Convert.ToString(ds.Tables[0].Rows[0]["ean"]);
        descricao = Convert.ToString(ds.Tables[0].Rows[0]["descricao"]);
        descResumida = Convert.ToString(ds.Tables[0].Rows[0]["descricaoresumida"]);
        embalagem = Convert.ToString(ds.Tables[0].Rows[0]["embalagem"]);
        unidade = Convert.ToInt32(ds.Tables[0].Rows[0]["unidade"]);
        margem = Convert.ToDecimal(ds.Tables[0].Rows[0]["margemlucro"]);
        precoVenda = Convert.ToDecimal(ds.Tables[0].Rows[0]["venda"]);
        estoqueAtual = Convert.ToInt32(ds.Tables[0].Rows[0]["estoque"]);
        marca = Convert.ToString(ds.Tables[0].Rows[0]["marca"]);
        idFornecedor = Convert.ToInt32(ds.Tables[0].Rows[0]["idfornecedor"]);
        estoqueMinimo = Convert.ToInt32(ds.Tables[0].Rows[0]["estoqueminimo"]);
        custo = Convert.ToDecimal(ds.Tables[0].Rows[0]["custo"]);
        estado = Convert.ToString(ds.Tables[0].Rows[0]["estado"]);
        estadoEstoque = Convert.ToString(ds.Tables[0].Rows[0]["estado_estoque"]);

        this.LocalizaEan(id.ToString());
      }
      else
      {
        MessageBox.Show("Produto não cadastrado!", "Consulta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
      }
    }

    public void ExcluirProduto()
    {
      string SQL = "DELETE FROM produtos WHERE id = @id";
      cmd.CommandText = SQL;

      MySqlParameter pId = new MySqlParameter("@id", id);
      cmd.Parameters.Add(pId);

      bd.ExcluirRegistro(cmd);
      if (bd.Cont > 0)
      {
        MessageBox.Show("Registro excluido com sucesso!", "Exclusão", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        bd.Cont = 0;
      }
    }

    public DataTable PreencherCbx()
    {
      string SQL = "SELECT id, descricao, venda FROM produtos";
      dt = new DataTable();
      dt = bd.PreencherCbx(SQL, dt);
      return dt;
    }

    public void AtualizarEstoque(string desc, string tipo, int qtde)
    {
      string op = "";
      switch (tipo)
      {
        case "POSITIVO":
        case "RETORNO DE TROCA":
          op = "+";
          break;
        case "NEGATIVO":
        case "QUEBRAS E PERDAS":
        case "ROUBO":
        case "ENVIO PARA TROCA":
          op = "-";
          break;
      }
      string SQL = "UPDATE produtos SET estoque = estoque " + op + " " + qtde + " WHERE id = @idprod";
      cmd = new MySqlCommand();
      cmd.CommandText = SQL;
      MySqlParameter pIdprod = new MySqlParameter("@idprod", id);
      cmd.Parameters.Add(pIdprod);

      bd.AtualizarRegistro(cmd);
      if (bd.Cont > 0)
      {
        bd.Cont = 0;
        string SQL2 = "INSERT INTO mov_estoque VALUES (NULL, @desc, @tipo, @qtde, @data, @usuario, @idprod)";
        cmd.CommandText = SQL2;
        cmd.Parameters.Clear();

        MySqlParameter pDesc = new MySqlParameter("@desc", desc);
        cmd.Parameters.Add(pDesc);
        MySqlParameter pTipo = new MySqlParameter("@tipo", tipo);
        cmd.Parameters.Add(pTipo);
        MySqlParameter pQtde = new MySqlParameter("@qtde", qtde);
        cmd.Parameters.Add(pQtde);
        DateTime dtAtual = DateTime.Now;
        MySqlParameter pData = new MySqlParameter("@data", dtAtual);
        cmd.Parameters.Add(pData);
        MySqlParameter pUsu = new MySqlParameter("@usuario", usuario);
        cmd.Parameters.Add(pUsu);
        MySqlParameter pIdprod2 = new MySqlParameter("@idprod", id);
        cmd.Parameters.Add(pIdprod2);

        bd.AtualizarEstoque(cmd);
        if (bd.Cont > 0)
        {
          MessageBox.Show("Estoque Atualizado com sucesso", "Ajuste de Estoque", MessageBoxButtons.OK, MessageBoxIcon.Warning);
          bd.Cont = 0;
        }
      }


    }

    public void LocalizaEan(string id)
    {
      string SQL = "SELECT ean13 FROM cod_barras WHERE idproduto = '" + id + "' ORDER BY ean13 ASC LIMIT 1";
      string tabela = "cod_barras";
      ds = bd.ConsultarRegistro(SQL, tabela);
      if (ds.Tables[0].Rows.Count == 0)
      {
        ean = "";
      }
      else
      {
        ean = Convert.ToString(ds.Tables[0].Rows[0]["ean13"]);
      }      
    }

    public void Call_SP_EstadoProduto()
    {
      string SQL = "CALL sp_estado_estoque()";
      cmd.CommandText = SQL;

      bd.Call_StoredProcedure(cmd);
      if (bd.Cont > 0)
      {
        bd.Cont = 0;
      }
    }

    public void Call_SP_CadastraEan()
    {
      string SQL = "CALL sp_cad_ean(?ean, ?idprod, ?emb, ?unid)";
      cmd.CommandText = SQL;
      MySqlParameter pEan = new MySqlParameter("?ean", ean);
      cmd.Parameters.Add(pEan);
      MySqlParameter pIdProd = new MySqlParameter("?idprod", id);
      cmd.Parameters.Add(pIdProd);
      MySqlParameter pEmb = new MySqlParameter("?emb", embalagem);
      cmd.Parameters.Add(pEmb);
      MySqlParameter pUnid = new MySqlParameter("?unid", unidade);
      cmd.Parameters.Add(pUnid);

      bd.Call_StoredProcedure(cmd);
      if (bd.Cont > 0)
      {
        bd.Cont = 0;
      }
    }

    public void ExcluirCodigoBarra()
    {
      string SQL = "DELETE FROM cod_barras WHERE ean13 = ?ean";
      cmd.CommandText = SQL;
      MySqlParameter pEan = new MySqlParameter("?ean", ean);
      cmd.Parameters.Add(pEan);
      bd.ExcluirRegistro(cmd);
      if (bd.Cont > 0)
      {
        bd.Cont = 0;
      }
    }
  }
}
