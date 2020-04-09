using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;
using System.Data;
using System.Windows.Forms;

namespace MechSystem
{
  class Veiculo
  {
    //Atributos do Objeto
    private string placa;
    private string marca;
    private string modelo;
    private string cor;
    private string ano;
    private int idCliente;

    //Atributos de Manipulacao
    private BancoDados bd;
    private MySqlCommand cmd;
    private DataSet ds;
    
    
    //Construtor
    public Veiculo()
    {
      bd = new BancoDados();
      cmd = new MySqlCommand();
    }   
    
    //Propriedades
    public string Placa
    {
      get { return placa; }
      set { placa = value; }
    }
    public string Marca
    {
      get { return marca; }
      set { marca = value; }
    }
    public string Modelo
    {
      get { return modelo; }
      set { modelo = value; }
    }
    public string Cor
    {
      get { return cor; }
      set { cor = value; }
    }
    public string Ano
    {
      get { return ano; }
      set { ano = value; }
    }
    public int IdCliente
    {
      get { return idCliente; }
      set { idCliente = value; }
    }

    //Métodos
    public void InserirVeiculo()
    {
      string SQL = "INSERT INTO carro  VALUES (@placa, @marca, @modelo, @cor, @ano, @idCliente)";
      cmd.CommandText = SQL;

      MySqlParameter pPlaca = new MySqlParameter("@placa", placa);
      cmd.Parameters.Add(pPlaca);
      MySqlParameter pMarca = new MySqlParameter("@marca", marca);
      cmd.Parameters.Add(pMarca);
      MySqlParameter pModelo = new MySqlParameter("@modelo", modelo);
      cmd.Parameters.Add(pModelo);
      MySqlParameter pCor = new MySqlParameter("@cor", cor);
      cmd.Parameters.Add(pCor);
      MySqlParameter pAno = new MySqlParameter("@ano", ano);
      cmd.Parameters.Add(pAno);
      MySqlParameter pidCli = new MySqlParameter("@idCliente", idCliente);
      cmd.Parameters.Add(pidCli);

      bd.InserirRegistro(cmd);
      if (bd.Cont > 0)
      {
        MessageBox.Show("Registro inserido com sucesso!", "Novo Registro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        bd.Cont = 0;
      }
    }

    public bool VerificaCadastroPlaca()
    {
      string SQL = "SELECT COUNT(*) FROM carro WHERE placa = @placa";
      cmd.CommandText = SQL;
      MySqlParameter pPlaca = new MySqlParameter("@placa", placa);
      cmd.Parameters.Add(pPlaca);

      bool localizado = bd.VerificarRegistro(cmd);

      return localizado;
    }

    public void ConsultarVeiculo()
    {
      bool localizado = false;
      string SQL = "SELECT COUNT(*) FROM carro WHERE placa = @placa";
      cmd = new MySqlCommand();
      cmd.CommandText = SQL;
      MySqlParameter pPlaca = new MySqlParameter("@placa", placa);
      cmd.Parameters.Add(pPlaca);

      localizado = bd.VerificarRegistro(cmd);
      if (localizado)
      {
        SQL = "SELECT * FROM carro WHERE placa = '" + placa + "'";
        string tabela = "carro";

        ds = bd.ConsultarRegistro(SQL, tabela);
        marca = Convert.ToString(ds.Tables[0].Rows[0]["marca"]);
        modelo = Convert.ToString(ds.Tables[0].Rows[0]["modelo"]);
        cor = Convert.ToString(ds.Tables[0].Rows[0]["cor"]);
        ano = Convert.ToString(ds.Tables[0].Rows[0]["ano"]);
        idCliente = Convert.ToInt32(ds.Tables[0].Rows[0]["Clientes_id"]);
      }
      else
      {
        //MessageBox.Show("Veículo não cadastrado!", "Mech System", MessageBoxButtons.OK, MessageBoxIcon.Warning);
      }
    }

    public void AtualizarVeiculo()
    {
      string SQL = "UPDATE carro SET marca = @marca, modelo = @modelo, cor = @cor, ano = @ano, Clientes_id = @idcli WHERE placa = @placa";
      cmd.CommandText = SQL;

      MySqlParameter pMarca = new MySqlParameter("@marca", marca);
      cmd.Parameters.Add(pMarca);
      MySqlParameter pModelo = new MySqlParameter("@modelo", modelo);
      cmd.Parameters.Add(pModelo);
      MySqlParameter pCor = new MySqlParameter("@cor", cor);
      cmd.Parameters.Add(pCor);
      MySqlParameter pAno = new MySqlParameter("@ano", ano);
      cmd.Parameters.Add(pAno);
      MySqlParameter pIdCli = new MySqlParameter("@idcli", idCliente);
      cmd.Parameters.Add(pIdCli);
      MySqlParameter pPlaca = new MySqlParameter("@placa", placa);
      cmd.Parameters.Add(pPlaca);
      
      bd.AtualizarRegistro(cmd);
      if (bd.Cont > 0)
      {
        MessageBox.Show("Registro atualizado com sucesso!", "Atualização", MessageBoxButtons.OK, MessageBoxIcon.Warning);
      }
    }

    public void DeletarVeiculo()
    {
      string SQL = "DELETE FROM carro WHERE placa = @placa";
      cmd.CommandText = SQL;

      MySqlParameter pPlaca = new MySqlParameter("@placa", placa);
      cmd.Parameters.Add(pPlaca);

      bd.ExcluirRegistro(cmd);
      if (bd.Cont > 0)
      {
        MessageBox.Show("Registro excluido com sucesso!", "Exclusão", MessageBoxButtons.OK, MessageBoxIcon.Warning);
      }
    }
  }
}
