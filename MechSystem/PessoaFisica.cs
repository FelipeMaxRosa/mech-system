using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;
using System.Data;
using System.Windows.Forms;

namespace MechSystem
{
  public class PessoaFisica : Cliente
  {
    //Atributos
    private BancoDados bd;
    private MySqlCommand cmd;
    private MySqlCommand cmd2;
    private DataSet ds;

    private string cpf;
    private string rg;
    private string nome;
    private string apelido;
    private DateTime nascimento;
    private string nomepai;
    private string nomemae;
    private string cpfAnterior;
    
    //Propriedades
    public string Cpf
    {
      get { return cpf; }
      set { cpf = value; }
    }

    public string CpfAnterior
    {
      get { return cpfAnterior; }
      set { cpfAnterior = value; }
    }

    public string Rg
    {
      get { return rg; }
      set { rg = value; }
    }

    public string Nome
    {
      get { return nome; }
      set { nome = value; }
    }

    public string Apelido
    {
      get { return apelido; }
      set { apelido = value; }
    }

    public DateTime Nascimento
    {
      get { return nascimento; }
      set { nascimento = value; }
    }

    public string Nomepai
    {
      get { return nomepai; }
      set { nomepai = value; }
    }

    public string Nomemae
    {
      get { return nomemae; }
      set { nomemae = value; }
    }

    //Construtor Padrão
    public PessoaFisica()
    {
      bd = new BancoDados();
      cmd = new MySqlCommand();
      cmd2 = new MySqlCommand();
    }

    //Métodos
    public void InserirCliente()
    {
        string SQL = "INSERT INTO pessoafisica VALUES (@cpf, @rg, @nome, @apelido, @datanasc, @nomepai, @nomemae)";
        cmd.CommandText = SQL;

        string SQL2 = "INSERT INTO clientes (CEP, Logradouro, numero, Bairro, Cidade, Estado, telefone1, ramal1, telefone2, ramal2, Email, pessoafisica_CPF, obs, c_status) VALUES (@cep, @logradouro, @numero, @bairro, @cidade, @estado, @tel1, @ramal1, @tel2, @ramal2, @email, @cpf2, @obs, @status)";
        cmd2.CommandText = SQL2;
        
        //Parâmetros da tabela pessoa fisica
        MySqlParameter sCpf = new MySqlParameter("@cpf", cpf);
        cmd.Parameters.Add(sCpf);
        MySqlParameter sRg = new MySqlParameter("@rg", rg);
        cmd.Parameters.Add(sRg);
        MySqlParameter sNome = new MySqlParameter("@nome", nome);
        cmd.Parameters.Add(sNome);
        MySqlParameter sApelido = new MySqlParameter("@apelido", apelido);
        cmd.Parameters.Add(sApelido);
        MySqlParameter sDataNasc = new MySqlParameter("@datanasc", nascimento);
        cmd.Parameters.Add(sDataNasc);
        MySqlParameter sNomePai = new MySqlParameter("@nomepai", nomepai);
        cmd.Parameters.Add(sNomePai);
        MySqlParameter sNomeMae = new MySqlParameter("@nomemae", nomemae);
        cmd.Parameters.Add(sNomeMae);

      //Parâmetros da tabela clientes
        MySqlParameter sCep = new MySqlParameter("@cep", Cep);
        cmd2.Parameters.Add(sCep);
        MySqlParameter sLogr = new MySqlParameter("@logradouro", Logradouro);
        cmd2.Parameters.Add(sLogr);
        MySqlParameter sNum = new MySqlParameter("@numero", Numero);
        cmd2.Parameters.Add(sNum);
        MySqlParameter sBairro = new MySqlParameter("@bairro", Bairro);
        cmd2.Parameters.Add(sBairro);
        MySqlParameter sCidade = new MySqlParameter("@cidade", Cidade);
        cmd2.Parameters.Add(sCidade);
        MySqlParameter sEstado = new MySqlParameter("@estado", Estado);
        cmd2.Parameters.Add(sEstado);
        MySqlParameter sTel1 = new MySqlParameter("@tel1", Telefone1);
        cmd2.Parameters.Add(sTel1);
        MySqlParameter sRam1 = new MySqlParameter("@ramal1", Ramal1);
        cmd2.Parameters.Add(sRam1);
        MySqlParameter sTel2 = new MySqlParameter("@tel2", Telefone2);
        cmd2.Parameters.Add(sTel2);
        MySqlParameter sRam2 = new MySqlParameter("@ramal2", Ramal2);
        cmd2.Parameters.Add(sRam2);
        MySqlParameter sEmail = new MySqlParameter("@email", Email);
        cmd2.Parameters.Add(sEmail);
        MySqlParameter sCpf2 = new MySqlParameter("@cpf2", cpf);
        cmd2.Parameters.Add(sCpf2);
        MySqlParameter sObs = new MySqlParameter("@obs", Obs);
        cmd2.Parameters.Add(sObs);
        MySqlParameter sSta = new MySqlParameter("@status", Situacao);
        cmd2.Parameters.Add(sSta);

        bd.InserirRegistro(cmd);
        if (bd.Cont > 0)
        {
          bd.InserirRegistro(cmd2);
          MessageBox.Show("Registro inserido com sucesso!", "Novo Registro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
          bd.Cont = 0;
        }
    }

    public void AtualizarCliente()
    {
      string SQL = "UPDATE pessoafisica SET rg = @rg, nome = @nome, apelido = @apelido, datanasc = @datanasc, nomepai = @nomepai, nomemae = @nomemae WHERE cpf = @cpf";
      cmd.CommandText = SQL;
      string SQL2 = "UPDATE clientes SET cep = @cep, logradouro = @logr, numero = @num, bairro = @bairro, cidade = @cidade, estado = @estado, telefone1 = @tel1, ramal1 = @ram1, telefone2 = @tel2, ramal2 = @ram2, email = @email, PessoaFisica_cpf = @cpf2, obs = @obs, c_status = @status WHERE id = @id";
      cmd2.CommandText = SQL2;

      //Parâmetros da tabela pessoafisica
      MySqlParameter sRg = new MySqlParameter("@rg", rg);
      cmd.Parameters.Add(sRg);
      MySqlParameter sNome = new MySqlParameter("@nome", nome);
      cmd.Parameters.Add(sNome);
      MySqlParameter sApelido = new MySqlParameter("@apelido", apelido);
      cmd.Parameters.Add(sApelido);
      MySqlParameter sDataNasc = new MySqlParameter("@datanasc", nascimento);
      cmd.Parameters.Add(sDataNasc);
      MySqlParameter sNomePai = new MySqlParameter("@nomepai", nomepai);
      cmd.Parameters.Add(sNomePai);
      MySqlParameter sNomeMae = new MySqlParameter("@nomemae", nomemae);
      cmd.Parameters.Add(sNomeMae);
      MySqlParameter sCpf = new MySqlParameter("@cpf", cpfAnterior);
      cmd.Parameters.Add(sCpf);

      //Parâmetros da tabela clientes
      MySqlParameter sCep = new MySqlParameter("@cep", Cep);
      cmd2.Parameters.Add(sCep);
      MySqlParameter sLogr = new MySqlParameter("@logr", Logradouro);
      cmd2.Parameters.Add(sLogr);
      MySqlParameter sNum = new MySqlParameter("@num", Numero);
      cmd2.Parameters.Add(sNum);
      MySqlParameter sBairro = new MySqlParameter("@bairro", Bairro);
      cmd2.Parameters.Add(sBairro);
      MySqlParameter sCidade = new MySqlParameter("@cidade", Cidade);
      cmd2.Parameters.Add(sCidade);
      MySqlParameter sEstado = new MySqlParameter("@estado", Estado);
      cmd2.Parameters.Add(sEstado);
      MySqlParameter sTel1 = new MySqlParameter("@tel1", Telefone1);
      cmd2.Parameters.Add(sTel1);
      MySqlParameter sRam1 = new MySqlParameter("@ram1", Ramal1);
      cmd2.Parameters.Add(sRam1);
      MySqlParameter sTel2 = new MySqlParameter("@tel2", Telefone2);
      cmd2.Parameters.Add(sTel2);
      MySqlParameter sRam2 = new MySqlParameter("@ram2", Ramal2);
      cmd2.Parameters.Add(sRam2);
      MySqlParameter sEmail = new MySqlParameter("@email", Email);
      cmd2.Parameters.Add(sEmail);
      MySqlParameter sCpf2 = new MySqlParameter("@cpf2", cpf);
      cmd2.Parameters.Add(sCpf2);
      MySqlParameter sObs = new MySqlParameter("@obs", Obs);
      cmd2.Parameters.Add(sObs);
      MySqlParameter sSta = new MySqlParameter("@status", Situacao);
      cmd2.Parameters.Add(sSta);
      MySqlParameter sId = new MySqlParameter("@id", IdCliente);
      cmd2.Parameters.Add(sId);

      bd.AtualizarRegistro(cmd2);
      if (bd.Cont > 0)
      {
        bd.AtualizarRegistro(cmd);
        MessageBox.Show("Registro atualizado com sucesso!", "Atualização", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        bd.Cont = 0;
      }
    }

    public bool VerificaCadastro()
    {
      string SQL = "SELECT COUNT(*) FROM pessoafisica WHERE cpf = @cpf";
      cmd.CommandText = SQL;
      MySqlParameter pCpf = new MySqlParameter("@cpf", cpf);
      cmd.Parameters.Add(pCpf);

      bool localizado = bd.VerificarRegistro(cmd);

      return localizado;
    }

    public DataSet BuscaCodigo()
    {
      string SQL = "SELECT * FROM clientes WHERE PessoaFisica_CPF = '"+cpf+"'";
      string tabela = "clientes";
      ds = bd.ConsultarRegistro(SQL, tabela);

      return ds;
    }

    public void ConsultarRegistro()
    {
      string SQL = "SELECT * FROM pessoafisica WHERE cpf = '" + cpf + "'";
      string tabela = "pessoafisica";
      ds = bd.ConsultarRegistro(SQL, tabela);

      rg = Convert.ToString(ds.Tables[0].Rows[0]["rg"]);
      nome = Convert.ToString(ds.Tables[0].Rows[0]["nome"]);
      apelido = Convert.ToString(ds.Tables[0].Rows[0]["apelido"]);
      nascimento = Convert.ToDateTime(ds.Tables[0].Rows[0]["datanasc"]);
      nomepai = Convert.ToString(ds.Tables[0].Rows[0]["nomepai"]);
      nomemae = Convert.ToString(ds.Tables[0].Rows[0]["nomemae"]);
    }

    public void ExcluirCliente()
    {
      //string SQL2 = "DELETE FROM pessoafisica WHERE cpf = @cpf";
      //cmd2.CommandText = SQL2;
      //MySqlParameter pCpf = new MySqlParameter("@cpf", cpf);
      //cmd2.Parameters.Add(pCpf);
      string SQL = "UPDATE clientes SET c_status = 'EXCLUIDO' WHERE id = @id";
      cmd2.CommandText = SQL;
      MySqlParameter pId = new MySqlParameter("@id", IdCliente);
      cmd2.Parameters.Add(pId);      

      bd.ExcluirRegistro(cmd2);
      if (bd.Cont > 0)
      {
          MessageBox.Show("Registro excluido com sucesso!", "Exclusão", MessageBoxButtons.OK, MessageBoxIcon.Warning);
          bd.Cont = 0;
      }
    }

  }
}
