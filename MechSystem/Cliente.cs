using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;
using System.Data;
using System.Windows.Forms;

namespace MechSystem
{
  public class Cliente
  {
    //Atributos
    private BancoDados bd;
    private MySqlCommand cmd;
    private DataSet ds;
    private string SQL = "";
    private int idCliente;
    private string cep;
    private string logradouro;
    private string numero;
    private string bairro;
    private string cidade;
    private string estado;
    private string telefone1;
    private string ramal1;
    private string telefone2;
    private string ramal2;
    private string email;
    private string cnpj;
    private string cpf;
    private string obs;
    private string situacao;

    //Propriedades
    public int IdCliente
    {
      get { return idCliente; }
      set { idCliente = value; }
    }        
    public string Cep
    {
      get { return cep; }
      set { cep = value; }
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
    public string Telefone1
    {
      get { return telefone1; }
      set { telefone1 = value; }
    }
    public string Ramal1
    {
      get { return ramal1; }
      set { ramal1 = value; }
    }
    public string Telefone2
    {
      get { return telefone2; }
      set { telefone2 = value; }
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
    public string Cnpj
   {
      get { return cnpj; }
      set { cnpj = value; }
   }
    public string Cpf
    {
      get { return cpf; }
      set { cpf = value; }
    }
    public string Obs
    {
      get { return obs; }
      set { obs = value; }
    }
    public string Situacao
    {
      get { return situacao; }
      set { situacao = value; }
    }

    //Construtor
    public Cliente()
    {
      bd = new BancoDados();
    }
    
    //Métodos
    public void LocalizaCliente()
    {
      bool localizado = false;
      SQL = "SELECT COUNT(*) FROM clientes WHERE ID = @id";
      cmd = new MySqlCommand();
      cmd.CommandText = SQL;
      MySqlParameter pId = new MySqlParameter("@id", idCliente);
      cmd.Parameters.Add(pId);

      localizado = bd.VerificarRegistro(cmd);
      if (localizado)
      {
        SQL = "SELECT * FROM clientes WHERE ID = '" + idCliente + "'";
        string tabela = "clientes";

        ds = bd.ConsultarRegistro(SQL, tabela);
        cep = Convert.ToString(ds.Tables[0].Rows[0]["CEP"]);
        logradouro = Convert.ToString(ds.Tables[0].Rows[0]["Logradouro"]);
        numero = Convert.ToString(ds.Tables[0].Rows[0]["numero"]);
        bairro = Convert.ToString(ds.Tables[0].Rows[0]["Bairro"]);
        cidade = Convert.ToString(ds.Tables[0].Rows[0]["Cidade"]);
        estado = Convert.ToString(ds.Tables[0].Rows[0]["Estado"]);
        telefone1 = Convert.ToString(ds.Tables[0].Rows[0]["telefone1"]);
        ramal1 = Convert.ToString(ds.Tables[0].Rows[0]["ramal1"]);
        telefone2 = Convert.ToString(ds.Tables[0].Rows[0]["telefone2"]);
        ramal2 = Convert.ToString(ds.Tables[0].Rows[0]["ramal2"]);
        email = Convert.ToString(ds.Tables[0].Rows[0]["Email"]);
        obs = Convert.ToString(ds.Tables[0].Rows[0]["obs"]);
        situacao = Convert.ToString(ds.Tables[0].Rows[0]["c_status"]);
        if (ds.Tables[0].Rows[0]["pessoajuridica_CNPJ"] == DBNull.Value)
        {
          cnpj = "";
        }
        else
        {
          cnpj = Convert.ToString(ds.Tables[0].Rows[0]["pessoajuridica_CNPJ"]);
        }
        if (ds.Tables[0].Rows[0]["pessoafisica_CPF"] == DBNull.Value)
        {
          cpf = "";
        }
        else
        {
          cpf = Convert.ToString(ds.Tables[0].Rows[0]["pessoafisica_CPF"]);
        }

      }
      else
      {
        MessageBox.Show("Cliente não encontrado!", "Pesquisa", MessageBoxButtons.OK, MessageBoxIcon.Warning);
      }
    }
  }
}
