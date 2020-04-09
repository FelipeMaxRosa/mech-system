using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;
using System.Data;
using System.Windows.Forms;

namespace MechSystem
{
  class Funcionario
  {
    #region Atributos
    //Atributos
    private BancoDados bd;
    private MySqlCommand cmd;
    private DataSet ds;
    private DataTable dt;

    //Atributos do Objeto
    private int id;
    private string nome;
    private string cpf;
    private string rg;
    private string logradouro;
    private string numero;
    private string bairro;
    private string cidade;
    private string estado;
    private string cep;
    private DateTime datanasc;
    private DateTime dataadmi;
    private decimal salario;
    private string telefone;
    private string celular;
    private int idFuncao;
    #endregion

    #region Propriedades
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
    public string Cpf
    {
      get { return cpf; }
      set { cpf = value; }
    }
    public string Rg
    {
      get { return rg; }
      set { rg = value; }
    }
    public string Logradouro
    {
      get { return logradouro; }
      set { logradouro = value; }
    }
    public string Numero
    {
      get { return numero; }
      set { numero = value; }
    }
    public string Bairro
    {
      get { return bairro; }
      set { bairro = value; }
    }
    public string Cidade
    {
      get { return cidade; }
      set { cidade = value; }
    }
    public string Estado
    {
      get { return estado; }
      set { estado = value; }
    }
    public string Cep
    {
      get { return cep; }
      set { cep = value; }
    }
    public DateTime Datanasc
    {
      get { return datanasc; }
      set { datanasc = value; }
    }
    public DateTime Dataadmi
    {
      get { return dataadmi; }
      set { dataadmi = value; }
    }
    public decimal Salario
    {
      get { return salario; }
      set { salario = value; }
    }
    public string Telefone
    {
      get { return telefone; }
      set { telefone = value; }
    }
    public string Celular
    {
      get { return celular; }
      set { celular = value; }
    }
    public int IdFuncao
    {
      get { return idFuncao; }
      set { idFuncao = value; }
    }
    #endregion

    //Construtor
    public Funcionario()
    {
      bd = new BancoDados();
      cmd = new MySqlCommand();
    }

    //Métodos_Gerais
    public bool VerificaCadastro()
    {
      string SQL = "SELECT COUNT(*) FROM mecanico WHERE cpf = @cpf";
      cmd.CommandText = SQL;
      MySqlParameter pCpf = new MySqlParameter("@cpf", cpf);
      cmd.Parameters.Add(pCpf);

      bool localizado = bd.VerificarRegistro(cmd);

      return localizado;
    }

    public void InserirFuncionario()
    {
      string SQL = "INSERT INTO mecanico (nome, cpf, rg, logradouro, numero, bairro, cidade, estado, cep, datanasc, dataadmi, salario, telefone, celular, idFuncao) VALUES (@nome, @cpf, @rg, @log, @num, @bai, @cid, @est, @cep, @dtn, @dta, @sal, @tel, @cel, @idF)";
      cmd = new MySqlCommand();
      cmd.CommandText = SQL;

      MySqlParameter pNome = new MySqlParameter("@nome", nome);
      cmd.Parameters.Add(pNome);
      MySqlParameter pCpf = new MySqlParameter("@cpf", cpf);
      cmd.Parameters.Add(pCpf);
      MySqlParameter pRg = new MySqlParameter("@rg", rg);
      cmd.Parameters.Add(pRg);
      MySqlParameter pLogr = new MySqlParameter("@log", logradouro);
      cmd.Parameters.Add(pLogr);
      MySqlParameter pNum = new MySqlParameter("@num", numero);
      cmd.Parameters.Add(pNum);
      MySqlParameter pBai = new MySqlParameter("@bai", bairro);
      cmd.Parameters.Add(pBai);
      MySqlParameter pCid = new MySqlParameter("@cid", cidade);
      cmd.Parameters.Add(pCid);
      MySqlParameter pEst = new MySqlParameter("@est", estado);
      cmd.Parameters.Add(pEst);
      MySqlParameter pCep = new MySqlParameter("@cep", cep);
      cmd.Parameters.Add(pCep);
      MySqlParameter pDtn = new MySqlParameter("@dtn", datanasc);
      cmd.Parameters.Add(pDtn);
      MySqlParameter pDta = new MySqlParameter("@dta", dataadmi);
      cmd.Parameters.Add(pDta);
      MySqlParameter pSal = new MySqlParameter("@sal", salario);
      cmd.Parameters.Add(pSal);
      MySqlParameter pTel = new MySqlParameter("@tel", telefone);
      cmd.Parameters.Add(pTel);
      MySqlParameter pCel = new MySqlParameter("@cel", celular);
      cmd.Parameters.Add(pCel);
      MySqlParameter pIdf = new MySqlParameter("@idF", idFuncao);
      cmd.Parameters.Add(pIdf);

      bd.InserirRegistro(cmd);
      if (bd.Cont > 0)
      {
        MessageBox.Show("Registro inserido com sucesso!", "Registro Inserido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        bd.Cont = 0;
      }
    }

    public void RetornaCodigo()
    {
      string SQL = "SELECT id FROM mecanico WHERE nome = '" + nome + "' ORDER BY id DESC LIMIT 1";

      string tabela = "mecanico";
      ds = bd.ConsultarRegistro(SQL, tabela);

      id = Convert.ToInt32(ds.Tables[tabela].Rows[0]["id"]);
    }

    public void ConsultarMecanico()
    {
      bool localizado = false;
      string SQL = "SELECT COUNT(*) FROM mecanico WHERE id = @id";
      cmd = new MySqlCommand();
      cmd.CommandText = SQL;

      MySqlParameter pId = new MySqlParameter("@id", id);
      cmd.Parameters.Add(pId);
      localizado = bd.VerificarRegistro(cmd);
      if (localizado)
      {
        SQL = "SELECT * FROM mecanico WHERE id = '" + id + "'";
        string tabela = "mecanico";

        ds = bd.ConsultarRegistro(SQL, tabela);
        nome = Convert.ToString(ds.Tables["mecanico"].Rows[0]["nome"]);
        cpf = Convert.ToString(ds.Tables["mecanico"].Rows[0]["cpf"]);
        rg = Convert.ToString(ds.Tables["mecanico"].Rows[0]["rg"]);
        logradouro = Convert.ToString(ds.Tables["mecanico"].Rows[0]["logradouro"]);
        bairro = Convert.ToString(ds.Tables["mecanico"].Rows[0]["bairro"]);
        numero = Convert.ToString(ds.Tables["mecanico"].Rows[0]["numero"]);
        cidade = Convert.ToString(ds.Tables["mecanico"].Rows[0]["cidade"]);
        estado = Convert.ToString(ds.Tables["mecanico"].Rows[0]["estado"]);
        cep = Convert.ToString(ds.Tables["mecanico"].Rows[0]["cep"]);
        datanasc = Convert.ToDateTime(ds.Tables["mecanico"].Rows[0]["datanasc"]);
        dataadmi = Convert.ToDateTime(ds.Tables["mecanico"].Rows[0]["dataadmi"]);
        salario = Convert.ToDecimal(ds.Tables["mecanico"].Rows[0]["salario"]);
        telefone = Convert.ToString(ds.Tables["mecanico"].Rows[0]["telefone"]);
        celular = Convert.ToString(ds.Tables["mecanico"].Rows[0]["celular"]);
        idFuncao = Convert.ToInt32(ds.Tables["mecanico"].Rows[0]["idFuncao"]);
      }
      else
      {
        MessageBox.Show("Funcionário não cadastrado!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
      }
    }

    public void AtualizarFuncionario()
    {
      string SQL = "UPDATE mecanico SET nome = @nome, cpf = @cpf, rg = @rg, logradouro = @log, numero = @num, bairro = @bai, cidade = @cid, estado = @est, cep = @cep, datanasc = @dtn, dataadmi = @dta, salario = @sal, telefone = @tel, celular = @cel, idFuncao = @idF WHERE id = @id";
      cmd = new MySqlCommand();
      cmd.CommandText = SQL;
      cmd.Parameters.Clear();

      MySqlParameter pNome = new MySqlParameter("@nome", nome);
      cmd.Parameters.Add(pNome);
      MySqlParameter pCpf = new MySqlParameter("@cpf", cpf);
      cmd.Parameters.Add(pCpf);
      MySqlParameter pRg = new MySqlParameter("@rg", rg);
      cmd.Parameters.Add(pRg);
      MySqlParameter pLogr = new MySqlParameter("@log", logradouro);
      cmd.Parameters.Add(pLogr);
      MySqlParameter pNum = new MySqlParameter("@num", numero);
      cmd.Parameters.Add(pNum);
      MySqlParameter pBai = new MySqlParameter("@bai", bairro);
      cmd.Parameters.Add(pBai);
      MySqlParameter pCid = new MySqlParameter("@cid", cidade);
      cmd.Parameters.Add(pCid);
      MySqlParameter pEst = new MySqlParameter("@est", estado);
      cmd.Parameters.Add(pEst);
      MySqlParameter pCep = new MySqlParameter("@cep", cep);
      cmd.Parameters.Add(pCep);
      MySqlParameter pDtn = new MySqlParameter("@dtn", datanasc);
      cmd.Parameters.Add(pDtn);
      MySqlParameter pDta = new MySqlParameter("@dta", dataadmi);
      cmd.Parameters.Add(pDta);
      MySqlParameter pSal = new MySqlParameter("@sal", salario);
      cmd.Parameters.Add(pSal);
      MySqlParameter pTel = new MySqlParameter("@tel", telefone);
      cmd.Parameters.Add(pTel);
      MySqlParameter pCel = new MySqlParameter("@cel", celular);
      cmd.Parameters.Add(pCel);
      MySqlParameter pIdf = new MySqlParameter("@idF", idFuncao);
      cmd.Parameters.Add(pIdf);
      MySqlParameter pId = new MySqlParameter("@id", id);
      cmd.Parameters.Add(pId);

      bd.AtualizarRegistro(cmd);
      if (bd.Cont > 0)
      {
        MessageBox.Show("Registro atualizado com sucesso!", "Atualização", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        bd.Cont = 0;
      }
    }

    public void ExcluirFuncionario()
    {
      string SQL = "DELETE FROM mecanico WHERE id = @id";
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

    public DataTable PreencherCbx()
    {
      string SQL = "SELECT * FROM funcaofunc";
      dt = new DataTable();
      dt = bd.PreencherCbx(SQL, dt);

      return dt;
    }

  }
}
