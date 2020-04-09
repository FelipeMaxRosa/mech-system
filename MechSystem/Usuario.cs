using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace MechSystem
{
  class Usuario
  {
    #region Atributos
    //----------------------------------------------------------------------------
    private BancoDados bd;
    private DataSet ds;
    private MySqlCommand cmd;

    private int id;
    private string nome;
    private string senha;
    private string perfil;

    #endregion

    #region Propriedades
    //----------------------------------------------------------------------------
    public int Id
    {
      get { return id; }
      set { id = value; }
    }
    public string Nome
    {
      get { return nome; }
      set { nome = value; }
    }
    public string Senha
    {
      get { return senha; }
      set { senha = value; }
    }
    public string Perfil
    {
      get { return perfil; }
      set { perfil = value; }
    }
    #endregion

    #region Construtor
    //----------------------------------------------------------------------------
    public Usuario()
    {
      bd = new BancoDados();
    }

    #endregion

    #region Metodos Gerais
    //----------------------------------------------------------------------------
    public void InserirUsuario()
    {
      string SQL = "INSERT INTO usuarios (nome, senha, perfil) VALUES (@nome, @senha, @perfil)";
      cmd = new MySqlCommand();
      cmd.CommandText = SQL;

      MySqlParameter pNome = new MySqlParameter("@nome", nome);
      cmd.Parameters.Add(pNome);
      MySqlParameter pSenha = new MySqlParameter("@senha", senha);
      cmd.Parameters.Add(pSenha);
      MySqlParameter pPerfil = new MySqlParameter("@perfil", perfil);
      cmd.Parameters.Add(pPerfil);

      bd.InserirRegistro(cmd);
      if (bd.Cont > 0)
      {
        MessageBox.Show("Registro inserido com sucesso!", "Novo Registo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        bd.Cont = 0;
      }
    }

    public DataSet RetornaCodigo()
    {
      string SQL = "SELECT id FROM usuarios WHERE nome = '" + nome + "' ORDER BY id DESC LIMIT 1";

      string tabela = "usuarios";
      ds = bd.ConsultarRegistro(SQL, tabela);

      return ds;
    }

    public void AtualizarUsuario()
    {
      string SQL = "UPDATE usuarios SET nome = @nome, senha = @senha, perfil = @perfil WHERE id = @id";
      cmd = new MySqlCommand();
      cmd.CommandText = SQL;

      MySqlParameter pNome = new MySqlParameter("@nome", nome);
      cmd.Parameters.Add(pNome);
      MySqlParameter pSenha = new MySqlParameter("@senha", senha);
      cmd.Parameters.Add(pSenha);
      MySqlParameter pPerfil = new MySqlParameter("@perfil", perfil);
      cmd.Parameters.Add(pPerfil);
      MySqlParameter pId = new MySqlParameter("@id", id);
      cmd.Parameters.Add(pId);

      bd.AtualizarRegistro(cmd);
      if (bd.Cont > 0)
      {
        MessageBox.Show("Registro atualizado com sucesso!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        bd.Cont = 0;
      }
    }

    public void ValidarUsuario(string usu, string sen)
    {
      string SQL = "SELECT COUNT(*) FROM usuarios WHERE nome = '" + usu + "' AND senha = '" + sen + "'";
      cmd = new MySqlCommand();
      cmd.CommandText = SQL;
      int valido = bd.ValidarUsuario(cmd);

      if (valido > 0)
      {
        SQL = "SELECT * FROM usuarios WHERE nome = '" + usu + "' AND senha = '" + sen + "'";
        cmd = new MySqlCommand();
        cmd.CommandText = SQL;
        ds = bd.ConsultarRegistro(SQL, "usuarios");
        nome = Convert.ToString(ds.Tables[0].Rows[0]["nome"]);
        senha = Convert.ToString(ds.Tables[0].Rows[0]["senha"]);
        perfil = Convert.ToString(ds.Tables[0].Rows[0]["perfil"]);
      }
    }

    public void ConsutarUsuario()
    {
      bool localizado = false;
      string SQL = "SELECT COUNT(*) FROM usuarios WHERE id = @id";
      cmd = new MySqlCommand();
      cmd.CommandText = SQL;

      MySqlParameter pId = new MySqlParameter("@id", id);
      cmd.Parameters.Add(pId);

      localizado = bd.VerificarRegistro(cmd);
      if (localizado)
      {
        SQL = "SELECT * FROM usuarios WHERE id = '" + id + "'";
        string table = "usuarios";

        ds = bd.ConsultarRegistro(SQL, table);
        nome = Convert.ToString(ds.Tables[0].Rows[0]["nome"]);
        senha = Convert.ToString(ds.Tables[0].Rows[0]["senha"]);
        perfil = Convert.ToString(ds.Tables[0].Rows[0]["perfil"]);
      }
      else
      {
        MessageBox.Show("Usuário não cadastrado!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
      }
    }

    public void DeletarUsuario()
    {
      string SQL = "DELETE FROM usuarios WHERE id = @id";
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

    #endregion
  }
}
