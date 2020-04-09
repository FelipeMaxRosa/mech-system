using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;
using System.Data;
using System.Windows.Forms;

namespace MechSystem
{
  class Finalizadora
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
    public Finalizadora()
    {
      bd = new BancoDados();
    }

    //Métodos_Gerais
    public DataTable PreencherCbx()
    {
      string SQL = "SELECT * FROM finalizadoras";
      dt = new DataTable();
      dt = bd.PreencherCbx(SQL, dt);

      return dt;
    }

    public DataSet RetornaCodigo()
    {
      string SQL = "SELECT id FROM finalizadoras WHERE descricao = '" + descricao + "' ORDER BY id DESC LIMIT 1";

      string tabela = "finalizadoras";
      ds = bd.ConsultarRegistro(SQL, tabela);

      return ds;
    }

    public void InserirFinalizadora()
    {
      string SQL = "INSERT INTO finalizadoras VALUES (NULL, @desc)";
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

    public void ConsultaFinalizadora()
    {
      bool localizado = false;
      string SQL = "SELECT COUNT(*) FROM finalizadoras WHERE id = @id";
      cmd = new MySqlCommand();
      cmd.CommandText = SQL;

      MySqlParameter pId = new MySqlParameter("@id", id);
      cmd.Parameters.Add(pId);
      localizado = bd.VerificarRegistro(cmd);
      if (localizado)
      {
        SQL = "SELECT * FROM finalizadoras WHERE id = '" + id + "'";
        string tabela = "finalizadoras";

        ds = bd.ConsultarRegistro(SQL, tabela);
        descricao = Convert.ToString(ds.Tables[0].Rows[0]["descricao"]);
      }
      else
      {
        MessageBox.Show("Finalizadora não cadastrada!", "Mech System", MessageBoxButtons.OK, MessageBoxIcon.Warning);
      }
    }

    public void AlterarFinalizadora()
    {
      string SQL = "UPDATE finalizadoras SET descricao = @desc WHERE id = @id";
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

    public void ExcluirFinalizadora()
    {
      string SQL = "DELETE FROM finalizadoras WHERE id = @id";
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
