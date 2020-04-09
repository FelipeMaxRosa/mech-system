using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace MechSystem
{
  class OrdemServico
  {
    //Atributos
    private BancoDados bd;
    private MySqlCommand cmd;
    private DataSet ds;

    private int idOs;
    private DateTime dataOs;
    private string responsavel;
    private string telefone;
    private decimal total;
    private string status;
    private string placa;
    private int idFinalizadora;
    private int idMecanico;
    private string defeito;
    private string rel_tecnico;
    private int contOsProd;
    private int contOsServ;

    //Propriedades
    public int IdOs
    {
      get { return idOs; }
      set { idOs = value; }
    }

    public DateTime DataOs
    {
      get { return dataOs; }
      set { dataOs = value; }
    }

    public string Responsavel
    {
      get { return responsavel; }
      set { responsavel = value; }
    }

    public string Telefone
    {
      get { return telefone; }
      set { telefone = value; }
    }

    public decimal Total
    {
      get { return total; }
      set { total = value; }
    }

    public string Status
    {
      get { return status; }
      set { status = value; }
    }

    public string Placa
    {
      get { return placa; }
      set { placa = value; }
    }

    public int IdFinalizadora
    {
      get { return idFinalizadora; }
      set { idFinalizadora = value; }
    }

    public int IdMecanico
    {
      get { return idMecanico; }
      set { idMecanico = value; }
    }

    public string Defeito
    {
      get { return defeito; }
      set { defeito = value; }
    }

    public string Rel_tecnico
    {
      get { return rel_tecnico; }
      set { rel_tecnico = value; }
    }

    public int ContOsProd
    {
      get { return contOsProd; }
      set { contOsProd = value; }
    }

    public int ContOsServ
    {
      get { return contOsServ; }
      set { contOsServ = value; }
    }

    //Construtor
    public OrdemServico()
    {
      bd = new BancoDados();
    }

    //Métodos
    public void InserirOs()
    {
      string SQL = "INSERT INTO os (os_data, responsavel, telefone, total, os_status, placaveiculo, defeito, rel_tecnico) VALUES (@data, @resp, @tel, '0.00', @status, @placa, @defeito, @rel)";
      cmd = new MySqlCommand();
      cmd.CommandText = SQL;

      MySqlParameter pData = new MySqlParameter("@data", dataOs);
      cmd.Parameters.Add(pData);
      MySqlParameter pResp = new MySqlParameter("@resp", responsavel);
      cmd.Parameters.Add(pResp);
      MySqlParameter pTel = new MySqlParameter("@tel", telefone);
      cmd.Parameters.Add(pTel);
      MySqlParameter pSta = new MySqlParameter("@status", status);
      cmd.Parameters.Add(pSta);
      MySqlParameter pPlaca = new MySqlParameter("@placa", placa);
      cmd.Parameters.Add(pPlaca);
      MySqlParameter pDef = new MySqlParameter("@defeito", defeito);
      cmd.Parameters.Add(pDef);
      MySqlParameter pRel = new MySqlParameter("@rel", rel_tecnico);
      cmd.Parameters.Add(pRel);

      bd.InserirRegistro(cmd);
      if (bd.Cont > 0)
      {
        MessageBox.Show("Ordem de Serviço aberta com sucesso!", "Ordem de Serviço", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        bd.Cont = 0;
      }
    }

    public void RetornaCodigo_Status()
    {
      string SQL = "SELECT id, os_status, placaveiculo FROM os WHERE placaveiculo = '" + placa + "' ORDER BY id DESC LIMIT 1";
      string table = "os";
      ds = bd.ConsultarRegistro(SQL, table);

      idOs = Convert.ToInt32(ds.Tables[table].Rows[0]["id"]);
      status = Convert.ToString(ds.Tables[table].Rows[0]["os_status"]);      
    }

    public void ConsultarOs()
    {
      bool localizado = false;
      string SQL = "SELECT COUNT(*) FROM os WHERE id = @id";
      cmd = new MySqlCommand();
      cmd.CommandText = SQL;

      MySqlParameter pId = new MySqlParameter("@id", idOs);
      cmd.Parameters.Add(pId);
      localizado = bd.VerificarRegistro(cmd);
      if (localizado)
      {
        SQL = "SELECT * FROM os WHERE id = '" + idOs + "'";
        string table = "os";

        ds = bd.ConsultarRegistro(SQL, table);
        dataOs = Convert.ToDateTime(ds.Tables[table].Rows[0]["os_data"]);
        responsavel = Convert.ToString(ds.Tables[table].Rows[0]["responsavel"]);
        telefone = Convert.ToString(ds.Tables[table].Rows[0]["telefone"]);
        status = Convert.ToString(ds.Tables[table].Rows[0]["os_status"]);
        placa = Convert.ToString(ds.Tables[table].Rows[0]["placaveiculo"]);
        defeito = Convert.ToString(ds.Tables[table].Rows[0]["defeito"]);
        rel_tecnico = Convert.ToString(ds.Tables[table].Rows[0]["rel_tecnico"]);
        total = Convert.ToDecimal(ds.Tables[table].Rows[0]["total"]);
        if (ds.Tables[table].Rows[0]["idmecanico"] == DBNull.Value)
        {
          idMecanico = 0;
        }
        else 
        {
          idMecanico = Convert.ToInt32(ds.Tables[table].Rows[0]["idmecanico"]);
        }
        if (ds.Tables[table].Rows[0]["idfinalizadora"] == DBNull.Value)
        {
          idFinalizadora = 0;
        }
        else
        {
          idFinalizadora = Convert.ToInt32(ds.Tables[table].Rows[0]["idfinalizadora"]);
        }
      }
      else
      {
        MessageBox.Show("Ordem de Serviço não cadastrada!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
      }
    }

    public void AtualizarDadosOs()
    {
      string SQL = "UPDATE os SET responsavel = @resp, telefone = @tel, defeito = @defeito, rel_tecnico = @rel WHERE id = @id";
      cmd = new MySqlCommand();
      cmd.CommandText = SQL;

      MySqlParameter pResp = new MySqlParameter("@resp", responsavel);
      cmd.Parameters.Add(pResp);
      MySqlParameter pTel = new MySqlParameter("@tel", telefone);
      cmd.Parameters.Add(pTel);
      MySqlParameter pDef = new MySqlParameter("@defeito", defeito);
      cmd.Parameters.Add(pDef);
      MySqlParameter pRel = new MySqlParameter("@rel", rel_tecnico);
      cmd.Parameters.Add(pRel);
      MySqlParameter pId = new MySqlParameter("@id", idOs);
      cmd.Parameters.Add(pId);

      bd.AtualizarRegistro(cmd);
      if (bd.Cont > 0)
      {
        MessageBox.Show("Ordem de Serviço atualizada com sucesso!", "Ordem de Serviço", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        bd.Cont = 0;
      }
    }

    public void AtualizarMecanico()
    {
      string SQL = "UPDATE os SET idMecanico = @idMec WHERE id = @id";
      cmd = new MySqlCommand();
      cmd.CommandText = SQL;

      MySqlParameter pIdMec = new MySqlParameter("@idMec", idMecanico);
      cmd.Parameters.Add(pIdMec);
      MySqlParameter pId = new MySqlParameter("@id", idOs);
      cmd.Parameters.Add(pId);

      bd.AtualizarRegistro(cmd);
      if (bd.Cont > 0)
      {
        MessageBox.Show("Mecânico atualizado com sucesso!", "Ordem de Serviço", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        bd.Cont = 0;
      }
    }

    public void AtualizarFinalizadora()
    {
      string SQL = "UPDATE os SET idFinalizadora = @idFin WHERE id = @id";
      cmd = new MySqlCommand();
      cmd.CommandText = SQL;

      MySqlParameter pIdFin = new MySqlParameter("@idFin", idFinalizadora);
      cmd.Parameters.Add(pIdFin);
      MySqlParameter pId = new MySqlParameter("@id", idOs);
      cmd.Parameters.Add(pId);

      bd.AtualizarRegistro(cmd);
      if (bd.Cont > 0)
      {
        MessageBox.Show("Finalizadora atualizada com sucesso!", "Ordem de Serviço", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        bd.Cont = 0;
      }
    }

    public void AtualizarTotal(decimal total)
    {
      string SQL = "UPDATE os SET total = @total WHERE id = @id";
      cmd = new MySqlCommand();
      cmd.CommandText = SQL;

      MySqlParameter pTot = new MySqlParameter("@total", total);
      cmd.Parameters.Add(pTot);
      MySqlParameter pId = new MySqlParameter("@id", idOs);
      cmd.Parameters.Add(pId);

      bd.AtualizarRegistro(cmd);
      if (bd.Cont > 0)
      {
        bd.Cont = 0;
      }
    }

    public void FinalizarOs()
    {
      string SQL = "UPDATE os SET os_status = @status, os_datasaida = @data WHERE id = @id";
      cmd = new MySqlCommand();
      cmd.CommandText = SQL;

      MySqlParameter pSta = new MySqlParameter("@status", status);
      cmd.Parameters.Add(pSta);
      DateTime dtAtual = DateTime.Now.Date;
      MySqlParameter pDtS = new MySqlParameter("@data", dtAtual);
      cmd.Parameters.Add(pDtS);
      MySqlParameter pId = new MySqlParameter("@id", idOs);
      cmd.Parameters.Add(pId);

      bd.AtualizarRegistro(cmd);
      if (bd.Cont > 0)
      {
        MessageBox.Show("Ordem de Serviço finalizada com sucesso!", "Ordem de Serviço", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        bd.Cont = 0;
      }
    }

  }
}
