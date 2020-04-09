using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;
using System.Data;
using System.Windows.Forms;

namespace MechSystem
{
  class Fornecedor
  {
    //Atributos
    private BancoDados bd;
    private MySqlCommand cmd;
    private MySqlCommand cmd2;
    private DataSet ds;

    private int idFornecedor;
    private string razaoSocial;
    private string nomeFantasia;
    private string cnpj;
    private string ie;
    private string cep;
    private string endereco;
    private string numero;
    private string bairro;
    private string cidade;
    private string uf;
    private string tel1;
    private string ramal1;
    private string tel2;
    private string ramal2;
    private string email;
    private string obs;

    //Propriedades
    public int IdFornecedor
    {
      get { return idFornecedor; }
      set { idFornecedor = value; }
    }

    public string RazaoSocial
    {
      get { return razaoSocial; }
      set { razaoSocial = value; }
    }

    public string NomeFantasia
    {
      get { return nomeFantasia; }
      set { nomeFantasia = value; }
    }

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

    public string Endereco
    {
      get { return endereco; }
      set { endereco = value; }
    }

    public string Cep
    {
      get { return cep; }
      set { cep = value; }
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

    public string Uf
    {
      get { return uf; }
      set { uf = value; }
    }

    public string Tel1
    {
      get { return tel1; }
      set { tel1 = value; }
    }

    public string Ramal1
    {
      get { return ramal1; }
      set { ramal1 = value; }
    }

    public string Tel2
    {
      get { return tel2; }
      set { tel2 = value; }
    }

    public string Ramal2
    {
      get { return ramal2; }
      set { ramal2 = value; }
    }

    public string Email
    {
      get { return email; }
      set { email = value; }
    }

    public string Obs
    {
      get { return obs; }
      set { obs = value; }
    }

    //Construtor
    public Fornecedor()
    {
      bd = new BancoDados();
      cmd = new MySqlCommand();
      cmd2 = new MySqlCommand();
    }

    //Métodos
    public void InserirFornecedor()
    {
      string SQL = "INSERT INTO fornecedor (razaosocial, nomefantasia, cnpj, ie, cep, logradouro, numero, bairro, cidade, estado, telefone1, ramal1, telefone2, ramal2, email, obs) VALUES (@razsoc, @nomfan, @cnpj, @ie, @cep, @logr, @num, @bairro, @cidade, @estado, @tel1, @ram1, @tel2, @ram2, @email, @obs)";
      cmd.CommandText = SQL;

      MySqlParameter pRazSoc = new MySqlParameter("@razsoc", razaoSocial);
      cmd.Parameters.Add(pRazSoc);
      MySqlParameter pNomFan = new MySqlParameter("@nomfan", nomeFantasia);
      cmd.Parameters.Add(pNomFan);
      MySqlParameter pCnpj = new MySqlParameter("@cnpj", cnpj);
      cmd.Parameters.Add(pCnpj);
      MySqlParameter pIe = new MySqlParameter("@ie", ie);
      cmd.Parameters.Add(pIe);
      MySqlParameter pCep = new MySqlParameter("@cep", cep);
      cmd.Parameters.Add(pCep);
      MySqlParameter pLogr = new MySqlParameter("@logr", endereco);
      cmd.Parameters.Add(pLogr);
      MySqlParameter pNum = new MySqlParameter("@num", numero);
      cmd.Parameters.Add(pNum);
      MySqlParameter pBairro = new MySqlParameter("@bairro", bairro);
      cmd.Parameters.Add(pBairro);
      MySqlParameter pCidade = new MySqlParameter("@cidade", cidade);
      cmd.Parameters.Add(pCidade);
      MySqlParameter pEstado = new MySqlParameter("@estado", uf);
      cmd.Parameters.Add(pEstado);
      MySqlParameter pTel1 = new MySqlParameter("@tel1", tel1);
      cmd.Parameters.Add(pTel1);
      MySqlParameter pRam1 = new MySqlParameter("@ram1", ramal1);
      cmd.Parameters.Add(pRam1);
      MySqlParameter pTel2 = new MySqlParameter("@tel2", tel2);
      cmd.Parameters.Add(pTel2);
      MySqlParameter pRam2 = new MySqlParameter("@ram2", ramal2);
      cmd.Parameters.Add(pRam2);
      MySqlParameter pEmail = new MySqlParameter("@email", email);
      cmd.Parameters.Add(pEmail);
      MySqlParameter pObs = new MySqlParameter("@obs", obs);
      cmd.Parameters.Add(pObs);

      bd.InserirRegistro(cmd);
      if (bd.Cont > 0)
      {
        MessageBox.Show("Registro inserido com sucesso!", "Novo Registro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        bd.Cont = 0;
      }
    }

    public void AlterarCadastro()
    {
      string SQL = "UPDATE fornecedor SET razaosocial = @razsoc, nomefantasia = @nomfan, ie = @ie, cep = @cep, logradouro = @logr, numero = @num, bairro = @bairro, cidade = @cidade, estado = @estado, telefone1 = @tel1, ramal1 = @ram1, telefone2 = @tel2, ramal2 = @ram2, email = @email, obs = @obs WHERE cnpj = @cnpj";
      cmd.CommandText = SQL;

      MySqlParameter pRazSoc = new MySqlParameter("@razsoc", razaoSocial);
      cmd.Parameters.Add(pRazSoc);
      MySqlParameter pNomFan = new MySqlParameter("@nomfan", nomeFantasia);
      cmd.Parameters.Add(pNomFan);
      MySqlParameter pCnpj = new MySqlParameter("@cnpj", cnpj);
      cmd.Parameters.Add(pCnpj);
      MySqlParameter pIe = new MySqlParameter("@ie", ie);
      cmd.Parameters.Add(pIe);
      MySqlParameter pCep = new MySqlParameter("@cep", cep);
      cmd.Parameters.Add(pCep);
      MySqlParameter pLogr = new MySqlParameter("@logr", endereco);
      cmd.Parameters.Add(pLogr);
      MySqlParameter pNum = new MySqlParameter("@num", numero);
      cmd.Parameters.Add(pNum);
      MySqlParameter pBairro = new MySqlParameter("@bairro", bairro);
      cmd.Parameters.Add(pBairro);
      MySqlParameter pCidade = new MySqlParameter("@cidade", cidade);
      cmd.Parameters.Add(pCidade);
      MySqlParameter pEstado = new MySqlParameter("@estado", uf);
      cmd.Parameters.Add(pEstado);
      MySqlParameter pTel1 = new MySqlParameter("@tel1", tel1);
      cmd.Parameters.Add(pTel1);
      MySqlParameter pRam1 = new MySqlParameter("@ram1", ramal1);
      cmd.Parameters.Add(pRam1);
      MySqlParameter pTel2 = new MySqlParameter("@tel2", tel2);
      cmd.Parameters.Add(pTel2);
      MySqlParameter pRam2 = new MySqlParameter("@ram2", ramal2);
      cmd.Parameters.Add(pRam2);
      MySqlParameter pEmail = new MySqlParameter("@email", email);
      cmd.Parameters.Add(pEmail);
      MySqlParameter pObs = new MySqlParameter("@obs", obs);
      cmd.Parameters.Add(pObs);

      bd.AtualizarRegistro(cmd);
      if (bd.Cont > 0)
      {
        MessageBox.Show("Registro atualizado com sucesso!", "Atualização", MessageBoxButtons.OK, MessageBoxIcon.Warning);
      }
    }

    public DataSet BuscaCodigo()
    {
      string SQL = "SELECT * FROM fornecedor WHERE cnpj = '" + cnpj + "'";
      string tabela = "fornecedor";
      ds = bd.ConsultarRegistro(SQL, tabela);

      return ds;
    }

    public bool VerificaCadastro()
    {
      string SQL = "SELECT COUNT(*) FROM fornecedor WHERE cnpj = @cnpj";
      cmd.CommandText = SQL;
      MySqlParameter pCnpj = new MySqlParameter("@cnpj", cnpj);
      cmd.Parameters.Add(pCnpj);

      bool localizado = bd.VerificarRegistro(cmd);

      return localizado;
    }

    public void LocalizaFornecedor()
    {
      bool localizado = false;
      string SQL = "SELECT COUNT(*) FROM fornecedor WHERE id = @id";
      cmd = new MySqlCommand();
      cmd.CommandText = SQL;
      MySqlParameter pId = new MySqlParameter("@id", idFornecedor);
      cmd.Parameters.Add(pId);

      localizado = bd.VerificarRegistro(cmd);
      if (localizado)
      {
        SQL = "SELECT * FROM fornecedor WHERE id = '" + idFornecedor + "'";
        string tabela = "fornecedor";

        ds = bd.ConsultarRegistro(SQL, tabela);
        razaoSocial = Convert.ToString(ds.Tables[0].Rows[0]["razaosocial"]);
        nomeFantasia = Convert.ToString(ds.Tables[0].Rows[0]["nomefantasia"]);
        cnpj = Convert.ToString(ds.Tables[0].Rows[0]["cnpj"]);
        ie = Convert.ToString(ds.Tables[0].Rows[0]["ie"]);
        cep = Convert.ToString(ds.Tables[0].Rows[0]["cep"]);
        endereco = Convert.ToString(ds.Tables[0].Rows[0]["logradouro"]);
        numero = Convert.ToString(ds.Tables[0].Rows[0]["numero"]);
        bairro = Convert.ToString(ds.Tables[0].Rows[0]["bairro"]);
        cidade = Convert.ToString(ds.Tables[0].Rows[0]["cidade"]);
        uf = Convert.ToString(ds.Tables[0].Rows[0]["estado"]);
        tel1 = Convert.ToString(ds.Tables[0].Rows[0]["telefone1"]);
        ramal1 = Convert.ToString(ds.Tables[0].Rows[0]["ramal1"]);
        tel2 = Convert.ToString(ds.Tables[0].Rows[0]["telefone2"]);
        ramal2 = Convert.ToString(ds.Tables[0].Rows[0]["ramal2"]);
        email = Convert.ToString(ds.Tables[0].Rows[0]["email"]);
        obs = Convert.ToString(ds.Tables[0].Rows[0]["obs"]);
      }
      else
      {
        MessageBox.Show("Fornecedor não cadastrado!", "Consulta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
      }
    }

    public void ExcluirFornecedor()
    {
      string SQL = "DELETE FROM fornecedor WHERE id = @id";

      cmd.CommandText = SQL;

      MySqlParameter pId = new MySqlParameter("@id", idFornecedor);
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
