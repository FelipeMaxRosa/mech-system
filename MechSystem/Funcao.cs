using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;
using System.Data;
using System.Windows.Forms;

namespace MechSystem
{
  class Funcao
  {
    //Atributos
    private BancoDados bd;
    private MySqlCommand cmd;
    private DataSet ds;
    private DataTable dt;

    //Atributos do Objeto
    private int id;
    private string descricao;

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

    //Construtor
    public Funcao()
    {
      bd = new BancoDados();
    }

    //Métodos_Gerais
    public DataTable PreencherCbx()
    {
      string SQL = "SELECT * FROM funcao";
      dt = new DataTable();
      dt = bd.PreencherCbx(SQL, dt);

      return dt;
    }

    public DataSet RetornaCodigo()
    {
      string SQL = "SELECT id FROM funcao WHERE descricao = '" + descricao + "' ORDER BY id DESC LIMIT 1";

      string tabela = "funcao";
      ds = bd.ConsultarRegistro(SQL, tabela);

      return ds;
    }

    public void InserirFuncao()
    {
      string SQL = "INSERT INTO funcao VALUES (NULL, @desc)";
      cmd = new MySqlCommand();
      cmd.CommandText = SQL;

      MySqlParameter pDesc = new MySqlParameter("@desc", descricao);
      cmd.Parameters.Add(pDesc);

      bd.InserirRegistro(cmd);
      if (bd.Cont > 0)
      {
        MessageBox.Show("Registro inserido com sucesso!", "Registro Inserido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        bd.Cont = 0;
      }
    }

    public void ConsultaFuncao()
    {
      bool localizado = false;
      string SQL = "SELECT COUNT(*) FROM funcao WHERE id = @id";
      cmd = new MySqlCommand();
      cmd.CommandText = SQL;
      
      MySqlParameter pId = new MySqlParameter("@id", id);
      cmd.Parameters.Add(pId);
      localizado = bd.VerificarRegistro(cmd);
      if (localizado)
      {
        SQL = "SELECT * FROM funcao WHERE id = '" + id + "'";
        string tabela = "funcao";

        ds = bd.ConsultarRegistro(SQL, tabela);
        descricao = Convert.ToString(ds.Tables[0].Rows[0]["descricao"]);
      }
      else
      {
        MessageBox.Show("Funcão não cadastrada!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
      }
    }

    public void AlterarFuncao()
    {
      string SQL = "UPDATE funcao SET descricao = @desc WHERE id = @id";
      cmd = new MySqlCommand();
      cmd.CommandText = SQL;
      cmd.Parameters.Clear();

      MySqlParameter pDesc = new MySqlParameter("@desc", descricao);
      cmd.Parameters.Add(pDesc);
      MySqlParameter pId = new MySqlParameter("@id", id);
      cmd.Parameters.Add(pId);

      bd.AtualizarRegistro(cmd);
      if (bd.Cont > 0)
      {
        MessageBox.Show("Registro atualizado com sucesso!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        bd.Cont = 0;
      }
    }

    public void ExcluirFuncao()
    {
      string SQL = "DELETE FROM funcao WHERE id = @id";
      cmd = new MySqlCommand();
      cmd.CommandText = SQL;
      cmd.Parameters.Clear();

      MySqlParameter pId = new MySqlParameter("@id", id);
      cmd.Parameters.Add(pId);

      bd.ExcluirRegistro(cmd);
      if (bd.Cont > 0)
      {
        MessageBox.Show("Registro excluido com sucesso!", "Exclusão", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        bd.Cont = 0;
      }
    }
  }
}
