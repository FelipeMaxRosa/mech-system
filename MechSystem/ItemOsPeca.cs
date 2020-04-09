using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Data;

namespace MechSystem
{
  class ItemOsPeca
  {
    //Atributos
    private BancoDados bd;
    private MySqlCommand cmd;
    private DataSet ds;
    private DataTable dt; 

    //Atributos do Objeto
    private int idItem;
    private int idOs;
    private int idPeca;
    private int qtdPeca;
    private decimal valorPeca;
    private decimal totalPeca;
    private string estado;
    public string usuarioAtual;

    //Propriedades
    public int IdItem
    {
      get { return idItem; }
      set { idItem = value; }
    }

    public int IdOs
    {
      get { return idOs; }
      set { idOs = value; }
    }   

    public int IdPeca
    {
      get { return idPeca; }
      set { idPeca = value; }
    }

    public int QtdPeca
    {
      get { return qtdPeca; }
      set { qtdPeca = value; }
    }

    public decimal ValorPeca
    {
      get { return valorPeca; }
      set { valorPeca = value; }
    }

    public decimal TotalPeca
    {
      get { return totalPeca; }
      set { totalPeca = value; }
    }

    public string Estado
    {
      get { return estado; }
      set { estado = value; }
    }

    //Construtor
    public ItemOsPeca()
    {
      bd = new BancoDados();
    }

    //Métodos
    public void VerificaQtdeItensPeca()
    {
      string SQL = "SELECT COUNT(*) FROM os_produto WHERE idOs = @idOs ORDER BY idItem DESC LIMIT 1";
      cmd = new MySqlCommand();
      cmd.CommandText = SQL;

      MySqlParameter pIdOs = new MySqlParameter("@idOs", idOs);
      cmd.Parameters.Add(pIdOs);

      idItem = bd.RetornaQtdeRegistros(cmd);
      idItem += 1;
    }

    public void InserirItemPeca()
    {
      string SQL = "INSERT INTO os_produto VALUE (@idItem, @idOs, @qtde, @valor, @idProd, @estado)";
      cmd = new MySqlCommand();
      cmd.CommandText = SQL;

      MySqlParameter pIdItem = new MySqlParameter("@idItem", idItem);
      cmd.Parameters.Add(pIdItem);
      MySqlParameter pIdOs = new MySqlParameter("@idOs", idOs);
      cmd.Parameters.Add(pIdOs);
      MySqlParameter pQtde = new MySqlParameter("@qtde", qtdPeca);
      cmd.Parameters.Add(pQtde);
      MySqlParameter pValor = new MySqlParameter("@valor", valorPeca);
      cmd.Parameters.Add(pValor);
      MySqlParameter pIdPeca = new MySqlParameter("@idProd", idPeca);
      cmd.Parameters.Add(pIdPeca);
      MySqlParameter pEst = new MySqlParameter("@estado", estado);
      cmd.Parameters.Add(pEst);

      bd.InserirRegistro(cmd);
      if (bd.Cont > 0)
      {
        //MessageBox.Show("Registro Inserido com sucesso!", "Inserção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        bd.Cont = 0;
      }
    }

    public DataSet AtualizarGridPeca()
    {
      string SQL = "SELECT os.idItem, os.idProduto, p.descricao, os.qtde, os.valor, os.qtde*os.valor total, os.estado FROM os_produto AS os INNER JOIN produtos p ON os.idProduto = p.id WHERE os.idOs = '" + idOs + "' ORDER BY os.idItem";
      string tabela = "os_produto";
      ds = new DataSet();
      ds = bd.ConsultarParaGrid(SQL, tabela);

      return ds;
    }

    public DataSet LimparGridPeca()
    {
      string SQL = "SELECT os.*, os.qtde*os.valor total, p.descricao FROM os_produto AS os, produtos AS p WHERE os.idOs = '0'";
      string tabela = "os_produto";
      ds = new DataSet();
      ds = bd.ConsultarParaGrid(SQL, tabela);

      return ds;
    }

    public string CalcularSubTotal()
    {
      string SQL = "SELECT SUM(qtde*valor) subtotal FROM os_produto WHERE idOs = '" + idOs + "' AND estado <> 'CANCELADO'";
      string tabela = "os_produto";
      ds = new DataSet();
      ds = bd.ConsultarParaGrid(SQL, tabela);
      decimal subtotal;
      if (ds.Tables[0].Rows[0]["subtotal"] == DBNull.Value)
      {
        subtotal = 0.00M;
      }
      else
      {
        subtotal = Convert.ToDecimal(ds.Tables[0].Rows[0]["subtotal"]);
      }

      return subtotal.ToString("0.00");
    }

    public void CancelarItemPeca()
    {
      string SQL = "UPDATE os_produto SET estado = @estado WHERE idItem = @idItem AND idOs = @idOs";
      cmd = new MySqlCommand();
      cmd.CommandText = SQL;

      MySqlParameter pIdItem = new MySqlParameter("@idItem", idItem);
      cmd.Parameters.Add(pIdItem);
      MySqlParameter pIdOs = new MySqlParameter("@idOs", idOs);
      cmd.Parameters.Add(pIdOs);
      MySqlParameter pEstado = new MySqlParameter("@estado", estado);
      cmd.Parameters.Add(pEstado);

      bd.AtualizarRegistro(cmd);
      if (bd.Cont > 0)
      {
        bd.Cont = 0;
      }
    }

    public void AtualizarEstoquePeca(string op, int qtde)
    {
      string SQL = "";
      string SQL2 = "";
      if (op == "-")
      {
        SQL = "UPDATE produtos SET estoque = estoque - @qtde WHERE id = @id";
        SQL2 = "INSERT INTO mov_estoque VALUES (NULL, 'O.S.: " + idOs.ToString() + " - SAIDA DO ITEM: " + idItem.ToString() + "', 'NEGATIVO', @qtde, @data, @usu, @idProd)";
      }
      else if (op == "+")
      {
        SQL = "UPDATE produtos SET estoque = estoque + @qtde WHERE id = @id";
        SQL2 = "INSERT INTO mov_estoque VALUES (NULL, 'O.S.: " + idOs.ToString() + " - CANCELAMENTO DO ITEM: " + idItem.ToString() + "', 'POSITIVO', @qtde, @data, @usu, @idProd)";
      }
      cmd = new MySqlCommand();
      cmd.CommandText = SQL;

      MySqlParameter pQtde = new MySqlParameter("@qtde", qtde);
      cmd.Parameters.Add(pQtde);
      MySqlParameter pIdp = new MySqlParameter("@id", idPeca);
      cmd.Parameters.Add(pIdp);

      bd.AtualizarEstoque(cmd);
      if (bd.Cont > 0)
      {
        MySqlCommand cmd2 = new MySqlCommand();
        cmd2.CommandText = SQL2;

        MySqlParameter pQtde2 = new MySqlParameter("@qtde", qtdPeca);
        cmd2.Parameters.Add(pQtde2);
        DateTime dtAtual = DateTime.Now;
        MySqlParameter pData = new MySqlParameter("@data", dtAtual);
        cmd2.Parameters.Add(pData);
        MySqlParameter pUsu = new MySqlParameter("@usu", usuarioAtual);
        cmd2.Parameters.Add(pUsu);
        MySqlParameter pIdPeca = new MySqlParameter("@idProd", idPeca);
        cmd2.Parameters.Add(pIdPeca);
        
        bd.InserirRegistro(cmd2);
        if (bd.Cont > 1)
        {
          bd.Cont = 0;
        }        
      }
    }

    public void Call_SP_EstadoProduto()
    {
      string SQL = "CALL sp_estado_estoque()";
      cmd = new MySqlCommand();
      cmd.CommandText = SQL;

      bd.Call_StoredProcedure(cmd);
      if (bd.Cont > 0)
      {
        bd.Cont = 0;
      }
    }
  }
}
