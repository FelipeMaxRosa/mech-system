using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Collections;
using System.Diagnostics;
using System.IO;
using System.Configuration;
using System.Threading;

namespace MechSystem
{
  class BancoDados
  {
    //string de conex�o com o BD
    //private string sCon = @"Data Source=localhost; DataBase=mechsystem; User Id=root; Password=jkax10";
    private string sCon = @"Data Source=localhost; DataBase=mechsystem; User Id=root; Password=jkax10";
    //objeto que efetua a conex�o entre a aplica��o e o BD, no caso o SQL SERVER
    private MySqlConnection con;
    private DataSet ds;
    private MySqlDataAdapter da;
    //private MySqlCommand cmd;
    private int cont = 0;

    //Construtor
    public BancoDados()
    {
      con = new MySqlConnection(sCon);
    }

    //Propriedades
    public int Cont
    {
      get { return cont; }
      set { cont = value; }
    }

    //M�todos Gerais
    public int ValidarUsuario(MySqlCommand cmd)
    {
      int valida = 0;
      try
      {
        if (con.State != ConnectionState.Open)
        {
          con.Open();
        }
        cmd.Connection = con;
        valida = Convert.ToInt32(cmd.ExecuteScalar());

        con.Close();  
      }
      catch (Exception ex)
      {
        MessageBox.Show("N�o foi poss�vel realizar a conex�o com o Banco!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
      }
      return valida;
    }

    public void InserirRegistro(MySqlCommand cmd)
    {
      if (con.State != ConnectionState.Open)
      {
        con.Open();
      }
      //Objeto de execu��o de comandos SQL direto no BD
      cmd.Connection = con;

      try
      {
        cont = cmd.ExecuteNonQuery();
      }
      catch (MySqlException ex)
      {
        MessageBox.Show("N�o foi poss�vel incluir as informa��es na Base de Dados\n\nErro: " + ex.Message, "Grava��o de Dados", MessageBoxButtons.OK, MessageBoxIcon.Error);
      }
      finally
      {
        cmd.Connection.Close();
      }

    }

    public void AtualizarRegistro(MySqlCommand cmd)
    {
      //Abre Conexao com o Banco
      if (con.State != ConnectionState.Open)
      {
        con.Open();
      }
      //Objeto de execu��o de comandos SQL direto no BD
      cmd.Connection = con;

      try
      {
        //Executa o comando INSERT
        cont = cmd.ExecuteNonQuery();
      }
      catch (MySqlException ex)
      {
        MessageBox.Show("N�o foi poss�vel atualizar as informa��es na Base de Dados\n\nErro: " + ex.Message, "Grava��o de Dados");
      }
      finally
      {
        //Fecha a conex�o
        cmd.Connection.Close();
      }

    }

    public DataSet ConsultarRegistro(string SQL, string tabela)
    {
      if (con.State != ConnectionState.Open)
      {
        con.Open();
      }
      ds = new DataSet();                                                  //Cria o Deposito para os dados contidos no BD
      da = new MySqlDataAdapter(SQL, con);                            //Liga��o com a tabela Cliente
      
      da.Fill(ds, tabela); //preenche o Deposito com os dados da tabela
      con.Close();                   //Fecha a conex�o com o BD

      return ds; //retorna o Deposito com os dados
    }

    public bool VerificarRegistro(MySqlCommand cmd)
    {
      //vari�vel booleana para retorno de localiza��o da informa��o
      bool localizado = false;
      //Cria objeto de execu��o de comandos SQL diretamente no BD
      cmd.Connection = con;

      try
      {
        //abre a conex�o com o BD
        if (con.State != ConnectionState.Open)
        {
          con.Open();
        }
        //retorna o resultado da pesquisa, informando o n�mero de linhas que atendem o teste
        localizado = (Convert.ToInt32(cmd.ExecuteScalar())) > 0;
        
      }
      catch
      {
        //MessageBox.Show("Registro n�o Encontrado\n\nVerifique se o registro solicitado encontra-se na Base de Dados...", "Pesquisa de Dados",MessageBoxButtons.OK, MessageBoxIcon.Error);
      }
      finally
      {
        //Fecha a conexao
        con.Close();
      }
      return localizado;
    }

    public void ExcluirRegistro(MySqlCommand cmd)
    {
      //Abre Conexao com o Banco
      if (con.State != ConnectionState.Open)
      {
        con.Open();
      }
      //Objeto de execu��o de comandos SQL direto no BD
      cmd.Connection = con;

      try
      {
          //Executa o comando INSERT
          cont = cmd.ExecuteNonQuery();
      }
      catch (MySqlException ex)
      {
          MessageBox.Show("N�o foi poss�vel excluir o registro!\n\nErro: " + ex.Message, "JM Control", MessageBoxButtons.OK, MessageBoxIcon.Error);
      }
      finally
      {
          //Fecha a conex�o
          cmd.Connection.Close();
      }

    }
    
    public void AtualizarEstoque(MySqlCommand cmd)
    {
      //Abre Conexao com o Banco
      if (con.State != ConnectionState.Open)
      {
        con.Open();
      }
      //Objeto de execu��o de comandos SQL direto no BD
      cmd.Connection = con;

      try
      {
        //Executa o comando INSERT
        cont = cmd.ExecuteNonQuery();
      }
      catch (MySqlException ex)
      {
        MessageBox.Show("N�o foi poss�vel atualizar o estoque na Base de Dados\n\nEntre em contato com o Suporte ao Usu�rio\n" + ex.Message, "Grava��o de Dados");
      }
    }

    public DataSet ConsultarParaGrid(string sql, string tabela)
    {
      if (con.State != ConnectionState.Open)
      {
        con.Open();
      }
      da = new MySqlDataAdapter(sql, sCon);
      ds = new DataSet();
      da.Fill(ds, tabela);

      return ds;
    }

    public DataSet pesquisarNoGrid(string sql, string tabela, string dadoPesq)
    {
      da = new MySqlDataAdapter(sql, sCon);
      da.SelectCommand.Parameters.AddWithValue("@pesq", "%" + dadoPesq + "%");
      ds = new DataSet();
      da.Fill(ds, tabela);

      return ds;
    }

    public DataTable PreencherCbx(string sql, DataTable dt)
    {
      da = new MySqlDataAdapter(sql, sCon);
      da.Fill(dt);

      return dt;
    }

    public int RetornaQtdeRegistros(MySqlCommand cmd)
    {
      if (con.State != ConnectionState.Open)
      {
        con.Open();
      }
      cmd.Connection = con;
      int valida = Convert.ToInt32(cmd.ExecuteScalar());

      con.Close();

      return valida;
    }

    public void Backup_Process()
    {
      string path = "C:\\MM\\MechSystem\\Backup";
      Process.Start(path + "\\MySqlbackup.cmd");
    }

    public string Backup_Nome()
    {
      string filename = "";
      DateTime dtAtual = DateTime.Now;
      filename += dtAtual.Day.ToString("00");
      filename += dtAtual.Month.ToString("00");
      string ano = Convert.ToString(dtAtual.Year);
      filename += ano.Substring(2, 2);
      filename += "_";
      filename += dtAtual.Hour.ToString("00");
      filename += dtAtual.Minute.ToString("00");
      filename += dtAtual.Second.ToString("00");

      return filename;
    }

    public void Call_StoredProcedure(MySqlCommand cmd)
    {
      if (con.State != ConnectionState.Open)
      {
        con.Open();
      }
      cmd.Connection = con;
      try
      {
        cmd.ExecuteNonQuery();
      }
      catch (Exception ex)
      {

        MessageBox.Show("Erro na execu��o da SP_estado_estoque:" + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
      }
      finally
      {
        con.Close();
      }
    }

  }
}
