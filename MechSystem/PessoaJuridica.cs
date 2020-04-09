using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;
using System.Data;
using System.Windows.Forms;

namespace MechSystem
{
  public class PessoaJuridica : Cliente
  {
    //Atributos
    private BancoDados bd;
    private MySqlCommand cmd;
    private MySqlCommand cmd2;
    private DataSet ds;

    private string cnpj;
    private string ie;
    private string razaosocial;
    private string nomefantasia;

    //Propriedades
    public string Cnpj
    {
      get { return cnpj; }
      set { cnpj = value; }
    }
    public string Ie
    {
      get { return ie; }
      set { ie = value; }
    }
    public string Razaosocial
    {
      get { return razaosocial; }
      set { razaosocial = value; }
    }
    public string Nomefantasia
    {
      get { return nomefantasia; }
      set { nomefantasia = value; }
    }

    //Construtor Padrão
    public PessoaJuridica()
    {
      bd = new BancoDados();
      cmd = new MySqlCommand();
      cmd2 = new MySqlCommand();
    }

    //Métodos
    public void InserirCliente()
    {
      string SQL = "INSERT INTO pessoajuridica VALUES (@cnpj, @ie, @razao, @nomefant)";
      cmd.CommandText = SQL;

      string SQL2 = "INSERT INTO clientes (CEP, Logradouro, numero, Bairro, Cidade, Estado, telefone1, ramal1, telefone2, ramal2, Email, pessoajuridica_CNPJ, obs, c_status) VALUES (@cep, @logradouro, @numero, @bairro, @cidade, @estado, @tel1, @ramal1, @tel2, @ramal2, @email, @cnpj2, @obs, @status)";
      cmd2.CommandText = SQL2;

      //Parametros da Tabela Pessoa Jurídica
      MySqlParameter sCnpj = new MySqlParameter("@cnpj", cnpj);
      cmd.Parameters.Add(sCnpj);
      MySqlParameter sIe = new MySqlParameter("@ie", ie);
      cmd.Parameters.Add(sIe);
      MySqlParameter sRazao = new MySqlParameter("@razao", razaosocial);
      cmd.Parameters.Add(sRazao);
      MySqlParameter sNomeF = new MySqlParameter("@nomefant", nomefantasia);
      cmd.Parameters.Add(sNomeF);

      //Parametros da Tabela Cliente
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
      MySqlParameter sCnpj2 = new MySqlParameter("@cnpj2", cnpj);
      cmd2.Parameters.Add(sCnpj2);
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

    public bool VerificaCadastro()
    {
      string SQL = "SELECT COUNT(*) FROM pessoajuridica WHERE cnpj = @cnpj";
      cmd.CommandText = SQL;
      MySqlParameter pCnpj = new MySqlParameter("@cnpj", cnpj);
      cmd.Parameters.Add(pCnpj);

      bool localizado = bd.VerificarRegistro(cmd);

      return localizado;
    }

    public DataSet BuscaCodigo()
    {
      string SQL = "SELECT * FROM clientes WHERE pessoajuridica_CNPJ = '" + cnpj + "'";
      string tabela = "clientes";
      ds = bd.ConsultarRegistro(SQL, tabela);

      return ds;
    }

    public void ConsultarRegistro()
    {
      string SQL = "SELECT * FROM pessoajuridica WHERE cnpj = '" + cnpj + "'";
      string tabela = "pessoajuridica";
      ds = bd.ConsultarRegistro(SQL, tabela);

      ie = Convert.ToString(ds.Tables[0].Rows[0]["ie"]);
      razaosocial = Convert.ToString(ds.Tables[0].Rows[0]["razaosocial"]);
      nomefantasia = Convert.ToString(ds.Tables[0].Rows[0]["nomefantasia"]);
    }

    public void AtualizarCliente()
    {
      string SQL = "UPDATE pessoajuridica SET ie = @ie, razaosocial = @rs, nomefantasia = @nf WHERE cnpj = @cnpj";
      cmd.CommandText = SQL;
      string SQL2 = "UPDATE clientes SET cep = @cep, logradouro = @logr, numero = @num, bairro = @bairro, cidade = @cidade, estado = @estado, telefone1 = @tel1, ramal1 = @ram1, telefone2 = @tel2, ramal2 = @ram2, email = @email, PessoaJuridica_cnpj = @cnpj2, obs = @obs, c_status = @status WHERE id = @id";
      cmd2.CommandText = SQL2;

      //Parâmetros da tabela pessoajuridica
      MySqlParameter sIe = new MySqlParameter("@ie", ie);
      cmd.Parameters.Add(sIe);
      MySqlParameter sRazaoSocial = new MySqlParameter("@rs", razaosocial);
      cmd.Parameters.Add(sRazaoSocial);
      MySqlParameter sNomeFant = new MySqlParameter("@nf", nomefantasia);
      cmd.Parameters.Add(sNomeFant);
      MySqlParameter sCnpj = new MySqlParameter("@cnpj", cnpj);
      cmd.Parameters.Add(sCnpj);


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
      MySqlParameter sCnpj2 = new MySqlParameter("@cnpj2", cnpj);
      cmd2.Parameters.Add(sCnpj2);
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

    public void ExcluirCliente()
    {
      //string SQL2 = "DELETE FROM pessoajuridica WHERE cnpj = @cnpj";
      //cmd2.CommandText = SQL2;
      //MySqlParameter pCnpj = new MySqlParameter("@cnpj", cnpj);
      //cmd2.Parameters.Add(pCnpj);
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
