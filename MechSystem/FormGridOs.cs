using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MechSystem
{
  public partial class FormGridOs : Form
  {
    //Atributos
    private DataSet ds;
    private FormCadOs frm;
    private BancoDados bd;

    //Construtor
    public FormGridOs(FormCadOs frm1)
    {
      InitializeComponent();
      bd = new BancoDados();
      frm = frm1;
      tbPesqNumero.Focus();
    }

    //Métodos_Gerais
    private void HabiDesaCampos(bool flag, string campo)
    {
      if (campo == "numero")
      {
        tbPesqNumero.ReadOnly = !flag;
        tbPesqPlaca.ReadOnly = flag;
        tbPesqNumero.TabStop = flag;
        tbPesqPlaca.TabStop = !flag;
        dtFim.Enabled = !flag;
        dtInicio.Enabled = !flag;
        dtInicio.TabStop = !flag;
        dtFim.TabStop = !flag;
      }
      else if (campo == "placa")
      {
        tbPesqNumero.ReadOnly = flag;
        tbPesqPlaca.ReadOnly = !flag;
        tbPesqNumero.TabStop = !flag;
        tbPesqPlaca.TabStop = flag;
        tbPesqNumero.Clear();
        tbPesqPlaca.Clear();
        dtFim.Enabled = !flag;
        dtInicio.Enabled = !flag;
        dtInicio.TabStop = !flag;
        dtFim.TabStop = !flag;
      }
      else if (campo == "periodo")
      {
        tbPesqNumero.ReadOnly = flag;
        tbPesqPlaca.ReadOnly = flag;
        tbPesqNumero.TabStop = !flag;
        tbPesqPlaca.TabStop = !flag;
        tbPesqNumero.Clear();
        tbPesqPlaca.Clear();
        dtFim.Enabled = flag;
        dtInicio.Enabled = flag;
        dtInicio.TabStop = flag;
        dtFim.TabStop = flag;
      }
      else if (campo == "todas")
      {
        tbPesqNumero.ReadOnly = flag;
        tbPesqPlaca.ReadOnly = flag;
        tbPesqNumero.TabStop = !flag;
        tbPesqPlaca.TabStop = !flag;
        tbPesqNumero.Clear();
        tbPesqPlaca.Clear();
        dtFim.Enabled = !flag;
        dtInicio.Enabled = !flag;
        dtInicio.TabStop = !flag;
        dtFim.TabStop = !flag;
      }
      else if (campo == "estado")
      {
        tbPesqNumero.ReadOnly = flag;
        tbPesqPlaca.ReadOnly = flag;
        tbPesqNumero.TabStop = !flag;
        tbPesqPlaca.TabStop = !flag;
        tbPesqNumero.Clear();
        tbPesqPlaca.Clear();
        dtFim.Enabled = !flag;
        dtInicio.Enabled = !flag;
        dtInicio.TabStop = !flag;
        dtFim.TabStop = !flag;
      }
    }

    private void radNumero_CheckedChanged(object sender, EventArgs e)
    {
      this.HabiDesaCampos(true, "numero");
      this.tbPesqNumero.Focus();
      this.tbPesqNumero.SelectAll();
    }

    private void radPlaca_CheckedChanged(object sender, EventArgs e)
    {
      this.HabiDesaCampos(true, "placa");
      tbPesqPlaca.Focus();
      tbPesqPlaca.SelectAll();
    }

    private void radPeriodo_CheckedChanged(object sender, EventArgs e)
    {
      this.HabiDesaCampos(true, "periodo");
      dtInicio.Focus();
    }

    private void FormGridOs_Load(object sender, EventArgs e)
    {
      string SQL = "SELECT id, placaveiculo, os_status, os_data, os_datasaida, responsavel, telefone, total, defeito, rel_tecnico, idmecanico, idfinalizadora FROM os WHERE os_status = 'ABERTA' ORDER BY id";
      string table = "os";
      ds = new DataSet();
      ds = bd.ConsultarParaGrid(SQL, table);
      dataGridView1.DataSource = ds.Tables[table];
      cbxEstado.Text = "ABERTA";
    }

    private void butSair_Click(object sender, EventArgs e)
    {
      if (frm != null)
      {
        frm.tbNumOs.Focus();
      }
      this.Close();
    }

    private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
    {
      if (e.RowIndex < 0)
      { 

      }
      else
      {
        if (frm != null)
        {
          frm.idOsAtual = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["id"].Value);
          frm.tbNumOs.Text = dataGridView1.Rows[e.RowIndex].Cells["id"].Value.ToString();
          frm.dtOs.Value = Convert.ToDateTime(dataGridView1.Rows[e.RowIndex].Cells["os_data"].Value);
          frm.lblStatus.Text = dataGridView1.Rows[e.RowIndex].Cells["os_status"].Value.ToString();
          frm.tbResponsavel.Text = dataGridView1.Rows[e.RowIndex].Cells["responsavel"].Value.ToString();
          frm.tbTelefone.Text = dataGridView1.Rows[e.RowIndex].Cells["telefone"].Value.ToString();
          frm.tbDefeito.Text = dataGridView1.Rows[e.RowIndex].Cells["defeito"].Value.ToString();
          frm.tbPlacaCarro.Text = dataGridView1.Rows[e.RowIndex].Cells["placaveiculo"].Value.ToString();
          frm.txtRelatorio.Text = dataGridView1.Rows[e.RowIndex].Cells["rel_tecnico"].Value.ToString();
          decimal total = Convert.ToDecimal(dataGridView1.Rows[e.RowIndex].Cells["total"].Value);
          //frm.lblTotalOs.Text = total.ToString("C2");
          frm.lblTotalOs.Text = total.ToString();
          
          //if (Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["idmecanico"].Value) > 0)
          if (dataGridView1.Rows[e.RowIndex].Cells["idmecanico"].Value != DBNull.Value)
          {
            Funcionario func = new Funcionario();
            DataTable dtableFunc = new DataTable();
            dtableFunc = func.PreencherCbx();
            frm.cbxMecanico.DisplayMember = "nomeFunc";
            frm.cbxMecanico.ValueMember = "idFunc";
            frm.cbxMecanico.DataSource = dtableFunc;
            DataRow[] row = dtableFunc.Select("idFunc = '" + Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["idmecanico"].Value) + "'");
            frm.cbxMecanico.Text = row[0]["nomeFunc"].ToString();
            frm.lblMecanico.Text = row[0]["nomeFunc"].ToString();
          }
          else
          {
            frm.lblMecanico.Text = "";
            frm.cbxMecanico.DataSource = null;
          }

          //if (Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["idfinalizadora"].Value) > 0)
          if (dataGridView1.Rows[e.RowIndex].Cells["idfinalizadora"].Value != DBNull.Value)
          {
            Finalizadora fin = new Finalizadora();
            DataTable dtableFin = new DataTable();
            dtableFin = fin.PreencherCbx();
            frm.cbxFormaPgto.DisplayMember = "descricao";
            frm.cbxFormaPgto.ValueMember = "id";
            frm.cbxFormaPgto.DataSource = dtableFin;
            DataRow[] row = dtableFin.Select("id = '" + Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["idfinalizadora"].Value) + "'");
            frm.cbxFormaPgto.Text = row[0]["descricao"].ToString();
            frm.lblFormaPgto.Text = row[0]["descricao"].ToString();
          }
          else
          {
            frm.lblFormaPgto.Text = "";
            frm.cbxFormaPgto.DataSource = null;
          }

          Veiculo vei = new Veiculo();
          vei.Placa = frm.tbPlacaCarro.Text;
          vei.ConsultarVeiculo();
          if (vei.Marca != null)
          {
            frm.tbMarcaCarro.Text = vei.Marca;
            frm.tbModeloCarro.Text = vei.Modelo;
            frm.tbCodigoProprietario.Text = Convert.ToString(vei.IdCliente);

            Cliente cli = new Cliente();
            cli.IdCliente = Convert.ToInt32(frm.tbCodigoProprietario.Text);
            cli.LocalizaCliente();
            if (cli.Cnpj == "")
            {
              PessoaFisica cliPf = new PessoaFisica();
              cliPf.Cpf = cli.Cpf;
              cliPf.ConsultarRegistro();
              frm.tbNomeProprietario.Text = cliPf.Nome;
            }
            else if (cli.Cpf == "")
            {
              PessoaJuridica cliPj = new PessoaJuridica();
              cliPj.Cnpj = cli.Cnpj;
              cliPj.ConsultarRegistro();
              frm.tbNomeProprietario.Text = cliPj.Razaosocial;
            }
            if (frm.lblStatus.Text == "ABERTA")
            {
              frm.btnCancelarItemServico.Enabled = false;
              frm.butAlterar.Enabled = true;
              frm.butFinalizarOs.Enabled = true;
              frm.btnEmitirCe.Enabled = true;
              frm.btnEmitirOs.Enabled = false;
            }
            else
            {
              frm.butAlterar.Enabled = false;
              frm.butFinalizarOs.Enabled = false;
              frm.btnEmitirCe.Enabled = true;
              frm.btnEmitirOs.Enabled = true;
            }
            frm.butNovo.Focus();
          }
        }
        this.Dispose();
      }      
    }

    private void btnPesquisar_Click(object sender, EventArgs e)
    {
      if (radNumero.Checked)
      {
        if (tbPesqNumero.Text.Length > 0)
        {
          bool encontrado = false;
          for (int i = 0; i < dataGridView1.RowCount; i++)
          {
            if (dataGridView1.Rows[i].Cells["id"].Value.ToString().Contains(tbPesqNumero.Text))
            {
              dataGridView1.Focus();
              dataGridView1.FirstDisplayedScrollingRowIndex = i;
              dataGridView1.Refresh();
              dataGridView1.CurrentCell = dataGridView1.Rows[i].Cells["id"];
              dataGridView1.Rows[i].Selected = true;
              encontrado = true;
              this.CancelButton = null;
              break;
            }
          }
          if (!encontrado)
          {
            MessageBox.Show("Nenhum registro encontrado com essas informações!", "Pesquisa", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            tbPesqNumero.SelectAll();
          }
        }
        else
        {
          string SQL = "";
          if (cbxEstado.Text == "TODAS")
          {
            SQL = "SELECT id, placaveiculo, os_status, os_data, os_datasaida, responsavel, telefone, total, defeito, rel_tecnico, idmecanico, idfinalizadora FROM os ORDER BY id";
          }
          else
          {
            SQL = "SELECT id, placaveiculo, os_status, os_data, os_datasaida, responsavel, telefone, total, defeito, rel_tecnico, idmecanico, idfinalizadora FROM os WHERE os_status = '" + cbxEstado.Text + "'ORDER BY id";
          }
          string table = "os";
          ds = new DataSet();
          ds = bd.ConsultarParaGrid(SQL, table);
          dataGridView1.DataSource = ds.Tables[table];
          radNumero.Checked = true;
          //tbPesqNumero.Select();
          dataGridView1.Focus();
          this.CancelButton = null;
        }
      }
      else if (radPlaca.Checked)
      {
        string SQL = "";
        if (cbxEstado.Text == "TODAS")
        {
          SQL = "SELECT id, placaveiculo, os_status, os_data, os_datasaida, responsavel, telefone, total, defeito, rel_tecnico, idmecanico, idfinalizadora FROM os WHERE placaveiculo LIKE ('" + tbPesqPlaca.Text + "%') ORDER BY id";
        }
        else
        {
          SQL = "SELECT id, placaveiculo, os_status, os_data, os_datasaida, responsavel, telefone, total, defeito, rel_tecnico, idmecanico, idfinalizadora FROM os WHERE placaveiculo LIKE ('" + tbPesqPlaca.Text + "%') AND os_status = '" + cbxEstado.Text + "' ORDER BY id";
        }
        string table = "os";
        ds = new DataSet();
        ds = bd.ConsultarParaGrid(SQL, table);
        dataGridView1.DataSource = ds.Tables[table];
        radNumero.Checked = true;
        tbPesqNumero.Select();
      }
      else if (radPeriodo.Checked)
      {
        string SQL = "";
        if (cbxEstado.Text == "TODAS")
        {
          SQL = "SELECT id, placaveiculo, os_status, os_data, os_datasaida, responsavel, telefone, total, defeito, rel_tecnico, idmecanico, idfinalizadora FROM os WHERE os_data BETWEEN '" + dtInicio.Value.Year + "-" + dtInicio.Value.Month + "-" + dtInicio.Value.Day + "' AND '" + dtFim.Value.Year + "-" + dtFim.Value.Month + "-" + dtFim.Value.Day + "' ORDER BY id";
        }
        else
        {
          SQL = "SELECT id, placaveiculo, os_status, os_data, os_datasaida, responsavel, telefone, total, defeito, rel_tecnico, idmecanico, idfinalizadora FROM os WHERE os_data BETWEEN '" + dtInicio.Value.Year + "-" + dtInicio.Value.Month + "-" + dtInicio.Value.Day + "' AND '" + dtFim.Value.Year + "-" + dtFim.Value.Month + "-" + dtFim.Value.Day + "' AND os_status = '" + cbxEstado.Text + "' ORDER BY id";
        }
        string table = "os";
        ds = new DataSet();
        ds = bd.ConsultarParaGrid(SQL, table);
        dataGridView1.DataSource = ds.Tables[table];
        radNumero.Checked = true;
        tbPesqNumero.Select();
      }
    }

    private void radTodas_CheckedChanged(object sender, EventArgs e)
    {
      this.HabiDesaCampos(true, "todas");
    }

    private void dataGridView1_KeyDown(object sender, KeyEventArgs e)
    {
      if (e.KeyCode == Keys.Enter)
      {
        DataGridViewRow linhaAtual = dataGridView1.CurrentRow;
        int i = linhaAtual.Index;
        if (frm != null)
        {
          frm.idOsAtual = Convert.ToInt32(dataGridView1.Rows[i].Cells["id"].Value);
          frm.tbNumOs.Text = dataGridView1.Rows[i].Cells["id"].Value.ToString();
          frm.dtOs.Value = Convert.ToDateTime(dataGridView1.Rows[i].Cells["os_data"].Value);
          frm.lblStatus.Text = dataGridView1.Rows[i].Cells["os_status"].Value.ToString();
          frm.tbResponsavel.Text = dataGridView1.Rows[i].Cells["responsavel"].Value.ToString();
          frm.tbTelefone.Text = dataGridView1.Rows[i].Cells["telefone"].Value.ToString();
          frm.tbDefeito.Text = dataGridView1.Rows[i].Cells["defeito"].Value.ToString();
          frm.tbPlacaCarro.Text = dataGridView1.Rows[i].Cells["placaveiculo"].Value.ToString();
          frm.txtRelatorio.Text = dataGridView1.Rows[i].Cells["rel_tecnico"].Value.ToString();
          decimal total = Convert.ToDecimal(dataGridView1.Rows[i].Cells["total"].Value);
          //frm.lblTotalOs.Text = total.ToString("C2");
          frm.lblTotalOs.Text = total.ToString();

          if (dataGridView1.Rows[i].Cells["idmecanico"].Value != DBNull.Value)
          {
            Funcionario func = new Funcionario();
            DataTable dtableFunc = new DataTable();
            dtableFunc = func.PreencherCbx();
            frm.cbxMecanico.DisplayMember = "nomeFunc";
            frm.cbxMecanico.ValueMember = "idFunc";
            frm.cbxMecanico.DataSource = dtableFunc;
            DataRow[] row = dtableFunc.Select("idFunc = '" + Convert.ToInt32(dataGridView1.Rows[i].Cells["idmecanico"].Value) + "'");
            frm.cbxMecanico.Text = row[0]["nomeFunc"].ToString();
            frm.lblMecanico.Text = row[0]["nomeFunc"].ToString();
          }
          else
          {
            frm.lblMecanico.Text = "";
            frm.cbxMecanico.DataSource = null;
          }

          if (dataGridView1.Rows[i].Cells["idfinalizadora"].Value != DBNull.Value)
          {
            Finalizadora fin = new Finalizadora();
            DataTable dtableFin = new DataTable();
            dtableFin = fin.PreencherCbx();
            frm.cbxFormaPgto.DisplayMember = "descricao";
            frm.cbxFormaPgto.ValueMember = "id";
            frm.cbxFormaPgto.DataSource = dtableFin;
            DataRow[] row = dtableFin.Select("id = '" + Convert.ToInt32(dataGridView1.Rows[i].Cells["idfinalizadora"].Value) + "'");
            frm.cbxFormaPgto.Text = row[0]["descricao"].ToString();
            frm.lblFormaPgto.Text = row[0]["descricao"].ToString();
          }
          else
          {
            frm.lblFormaPgto.Text = "";
            frm.cbxFormaPgto.DataSource = null;
          }

          Veiculo vei = new Veiculo();
          vei.Placa = frm.tbPlacaCarro.Text;
          vei.ConsultarVeiculo();
          if (vei.Marca != null)
          {
            frm.tbMarcaCarro.Text = vei.Marca;
            frm.tbModeloCarro.Text = vei.Modelo;
            frm.tbCodigoProprietario.Text = Convert.ToString(vei.IdCliente);

            Cliente cli = new Cliente();
            cli.IdCliente = Convert.ToInt32(frm.tbCodigoProprietario.Text);
            cli.LocalizaCliente();
            if (cli.Cnpj == "")
            {
              PessoaFisica cliPf = new PessoaFisica();
              cliPf.Cpf = cli.Cpf;
              cliPf.ConsultarRegistro();
              frm.tbNomeProprietario.Text = cliPf.Nome;
            }
            else if (cli.Cpf == "")
            {
              PessoaJuridica cliPj = new PessoaJuridica();
              cliPj.Cnpj = cli.Cnpj;
              cliPj.ConsultarRegistro();
              frm.tbNomeProprietario.Text = cliPj.Razaosocial;
            }
            if (frm.lblStatus.Text == "ABERTA")
            {
              frm.btnCancelarItemServico.Enabled = false;
              frm.butFinalizarOs.Enabled = true;
              frm.btnEmitirCe.Enabled = true;
              frm.btnEmitirOs.Enabled = false;
            }
            else
            {
              frm.butAlterar.Enabled = false;
              frm.butFinalizarOs.Enabled = false;
              frm.btnEmitirCe.Enabled = true;
              frm.btnEmitirOs.Enabled = true;
            }
            frm.butNovo.Focus();
          }
        }
        this.Dispose();
      }
      else if (e.KeyCode == Keys.Escape)
      {
        tbPesqNumero.Clear();
        tbPesqPlaca.Clear();
        radNumero.Checked = true;
        tbPesqNumero.Focus();
        this.CancelButton = butSair;
      }
    }

    private void radioButton1_CheckedChanged(object sender, EventArgs e)
    {
      this.HabiDesaCampos(true, "estado");
      cbxEstado.Focus();
    }

    private void cbxEstado_SelectedIndexChanged(object sender, EventArgs e)
    {
      string SQL = "";
      if (cbxEstado.Text == "TODAS")
      {
        SQL = "SELECT id, placaveiculo, os_status, os_data, os_datasaida, responsavel, telefone, total, defeito, rel_tecnico, idmecanico, idfinalizadora FROM os ORDER BY id";
      }
      else
      {
        SQL = "SELECT id, placaveiculo, os_status, os_data, os_datasaida, responsavel, telefone, total, defeito, rel_tecnico, idmecanico, idfinalizadora FROM os WHERE os_status = '" + cbxEstado.Text + "' ORDER BY id";
        
      }
      string table = "os";
      ds = new DataSet();
      ds = bd.ConsultarParaGrid(SQL, table);
      dataGridView1.DataSource = ds.Tables[table];
      radNumero.Checked = true;
      tbPesqNumero.Select();
    }

    private void tbPesqNumero_KeyPress(object sender, KeyPressEventArgs e)
    {
      if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8)
      {
        e.Handled = true;
      }
    }
  }
}
