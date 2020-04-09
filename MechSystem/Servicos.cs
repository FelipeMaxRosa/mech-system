using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;
using System.Data;
using System.Windows.Forms;

 namespace MechSystem
{
  public class Servicos
  {
    //Atributos
    private BancoDados bd;
    private MySqlCommand cmd;
    private DataSet ds;
    private DataTable dt;

    private int id;
    private string descricao;
    private decimal valor;
    private string detalhes;

    //Propriedades
    public int Id
    {
      get { return id; }
      set { id = value; }
    }

    public string Descricao
    {
      get { return descricao; }
      set { descricao = value; }
    }

    public decimal Valor
    {
      get { return valor; }
      set { valor = value; }
    }

    public string Detalhes
    {
      get { return detalhes; }
      set { detalhes = value; }
    }

    //Construtor
    public Servicos()
    {
      bd = new BancoDados();
    }

    //Métodos Gerais
    public void InserirServico()
    {
      string SQL = "INSERT INTO servico (descricao, valor, detalhes) VALUES (@desc, @valor, @deta)";
      cmd = new MySqlCommand();
      cmd.CommandText = SQL;

      MySqlParameter pDesc = new MySqlParameter("@desc", descricao);
      cmd.Parameters.Add(pDesc);
      MySqlParameter pValor = new MySqlParameter("@valor", valor);
      cmd.Parameters.Add(pValor);
      MySqlParameter pDet = new MySqlParameter("@deta", detalhes);
      cmd.Parameters.Add(pDet);

      bd.InserirRegistro(cmd);
      if (bd.Cont > 0)
      {
        MessageBox.Show("Registro inserido com sucesso!", "Registro Inserido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        bd.Cont = 0;
      }
    }

    public void RetornaCodigo()
    {
      string SQL = "SELECT id FROM servico WHERE descricao = '" + descricao + "' ORDER BY id DESC LIMIT 1";
      string table = "servico";

      ds = bd.ConsultarRegistro(SQL, table);

      this.id = Convert.ToInt32(ds.Tables[0].Rows[0]["id"]);
    }

    public void ConsultaServico()
    {
      bool localizado = false;
      string SQL = "SELECT COUNT(*) FROM servico WHERE id = @id";
      cmd = new MySqlCommand();
      cmd.CommandText = SQL;

      MySqlParameter pId = new MySqlParameter("@id", id);
      cmd.Parameters.Add(pId);
      localizado = bd.VerificarRegistro(cmd);
      if (localizado)
      {
        SQL = "SELECT * FROM servico WHERE id = '" + id + "'";
        string table = "servico";

        ds = bd.ConsultarRegistro(SQL, table);
        descricao = Convert.ToString(ds.Tables[table].Rows[0]["descricao"]);
        valor = Convert.ToDecimal(ds.Tables[table].Rows[0]["valor"]);
        detalhes = Convert.ToString(ds.Tables[table].Rows[0]["detalhes"]);
      }
      else
      {
        MessageBox.Show("Serviço não cadastrado!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
      }
    }

    public void AtualizarServico()
    {
      string SQL = "UPDATE servico SET descricao = @desc, valor = @val, detalhes = @det WHERE id = @id";
      cmd = new MySqlCommand();
      cmd.CommandText = SQL;
      cmd.Parameters.Clear();

      MySqlParameter pDesc = new MySqlParameter("@desc", descricao);
      cmd.Parameters.Add(pDesc);
      MySqlParameter pValor = new MySqlParameter("@val", valor);
      cmd.Parameters.Add(pValor);
      MySqlParameter pDet = new MySqlParameter("@det", detalhes);
      cmd.Parameters.Add(pDet);
      MySqlParameter pId = new MySqlParameter("@id", id);
      cmd.Parameters.Add(pId);

      bd.AtualizarRegistro(cmd);
      if (bd.Cont > 0)
      {
        MessageBox.Show("Registro atualizado com sucesso!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        bd.Cont = 0;
      }
    }

    public void DeletarServico()
    {
      string SQL = "DELETE FROM servico WHERE id = @id";
      cmd = new MySqlCommand();
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
      string SQL = "SELECT id, descricao, valor FROM servico";
      dt = new DataTable();
      dt = bd.PreencherCbx(SQL, dt);
      return dt;
    }
  }
}
