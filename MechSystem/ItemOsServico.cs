using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Data;

namespace MechSystem
{
  class ItemOsServico
  {
    //Atributos
    private BancoDados bd;
    private MySqlCommand cmd;
    private DataSet ds;
    private DataTable dt;

    //Atributos do Objeto
    private int idItem;
    private int idOs;
    private int idServico;
    private decimal valorServico;
    private string estado;

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

    public int IdServico
    {
      get { return idServico; }
      set { idServico = value; }
    }

    public decimal ValorServico
    {
      get { return valorServico; }
      set { valorServico = value; }
    }

    public string Estado
    {
      get { return estado; }
      set { estado = value; }
    }

    //Construtor
    public ItemOsServico()
    {
      bd = new BancoDados();
    }

    //Métodos
    public void VerificaQtdeItensServico()
    {
      string SQL = "SELECT COUNT(*) FROM os_servico WHERE idOs = @idOs";
      cmd = new MySqlCommand();
      cmd.CommandText = SQL;

      MySqlParameter pIdOs = new MySqlParameter("@idOs", idOs);
      cmd.Parameters.Add(pIdOs);

      idItem = bd.RetornaQtdeRegistros(cmd);
      idItem += 1;
    }

    public void InserirItemServico()
    {
      string SQL = "INSERT INTO os_servico VALUE (@idItem, @idOs, @valor, @idServ, @estado)";
      cmd = new MySqlCommand();
      cmd.CommandText = SQL;

      MySqlParameter pIdItem = new MySqlParameter("@idItem", idItem);
      cmd.Parameters.Add(pIdItem);
      MySqlParameter pIdOs = new MySqlParameter("@idOs", idOs);
      cmd.Parameters.Add(pIdOs);
      MySqlParameter pValor = new MySqlParameter("@valor", valorServico);
      cmd.Parameters.Add(pValor);
      MySqlParameter pIdServ = new MySqlParameter("@idServ", idServico);
      cmd.Parameters.Add(pIdServ);
      MySqlParameter pEst = new MySqlParameter("@estado", estado);
      cmd.Parameters.Add(pEst);

      bd.InserirRegistro(cmd);
      if (bd.Cont > 0)
      {
        //MessageBox.Show("Registro Inserido com sucesso!", "Inserção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        bd.Cont = 0;
      }
    }

    public DataSet AtualizarGridServico()
    {
      string SQL = "SELECT os.idItem, os.idServico, s.descricao, os.valor, os.estado FROM os_servico AS os INNER JOIN servico s ON os.idServico = s.id WHERE os.idOs = '" + idOs + "' ORDER BY os.idItem";
      string tabela = "os_servico";
      ds = new DataSet();
      ds = bd.ConsultarParaGrid(SQL, tabela);

      return ds;
    }

    public DataSet LimparGridServico()
    {
      string SQL = "SELECT os.idItem, os.idServico, s.descricao, os.valor, os.estado FROM os_servico AS os INNER JOIN servico AS s ON os.idServico = s.id WHERE os.idOs = '" + idOs + "' ORDER BY os.idItem";
      string tabela = "os_servico";
      ds = new DataSet();
      ds = bd.ConsultarParaGrid(SQL, tabela);

      return ds;
    }

    public string CalcularSubTotal()
    {
      string SQL = "SELECT SUM(valor) subtotal FROM os_servico WHERE idOs = '" + idOs + "' AND estado <> 'CANCELADO'";
      string tabela = "os_servico";
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

    public void AtualizarItemServico()
    {
      string SQL = "UPDATE os_servico SET valor = @valor, idServico = @idServ WHERE idItem = @idItem AND idOs = @idOs";
      cmd = new MySqlCommand();
      cmd.CommandText = SQL;

      MySqlParameter pIdItem = new MySqlParameter("@idItem", idItem);
      cmd.Parameters.Add(pIdItem);
      MySqlParameter pIdOs = new MySqlParameter("@idOs", idOs);
      cmd.Parameters.Add(pIdOs);
      MySqlParameter pValor = new MySqlParameter("@valor", valorServico);
      cmd.Parameters.Add(pValor);
      //idPeca += 1;
      MySqlParameter pIdServ = new MySqlParameter("@idServ", idServico);
      cmd.Parameters.Add(pIdServ);

      bd.AtualizarRegistro(cmd);
      if (bd.Cont > 0)
      {
        //MessageBox.Show("Registro Inserido com sucesso!", "Inserção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        bd.Cont = 0;
      }
    }

    public void CancelarItemServico()
    {
      string SQL = "UPDATE os_servico SET estado = @estado WHERE idItem = @idItem AND idOs = @idOs";
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
  }
}
