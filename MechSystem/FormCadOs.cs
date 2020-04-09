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
    public partial class FormCadOs : Form
    {
      //Atributos
      //------------------------------------------------------------------------
      private DataSet ds;
      private DataSet ds2;
      private DataTable dt;
      private OrdemServico os;
      private FormGridProdutos gridProd;
      private int idItemPeca = 0;

      public bool novaOs = false;
      private bool novoItemPeca = false;
      private bool novoItemServico = false;
      public bool req_placa = false;
      public int idOsAtual = 0;
      public string usuarioAtual;

      //Atributos
      //------------------------------------------------------------------------
      public int IdItemPeca
      {
        get { return idItemPeca; }
        set { idItemPeca = value; }
      }
      public bool NovoItemPeca
      {
        get { return novoItemPeca; }
        set { novoItemPeca = value; }
      }     

      //Construtor
      //------------------------------------------------------------------------
      public FormCadOs(FormPrincipal parent)
      {
        InitializeComponent();
        this.MdiParent = parent;
        tbNumOs.Focus();
      }

      //Metodos Gerais
      //------------------------------------------------------------------------
      private void OrganizaBotoes()
      {
        butAlterar.Enabled = false;
        butCancelar.Enabled = false;
        butConsultar.Enabled = true;
        butFinalizarOs.Enabled = false;
        btnEmitirCe.Enabled = false;
        btnEmitirOs.Enabled = false;
        butNovo.Enabled = true;
        butSair.Enabled = true;
        butSalvar.Enabled = false;
        btnCancelarItemPeca.Enabled = false;
        btnCancelarItemServico.Enabled = false;
        btnConsultaGeral.Enabled = true;
        btnConsultarVeiculo.Enabled = false;
      }

      private void LimparCampos()
      {
        tbCodigoProprietario.Clear();
        dtOs.Value = Convert.ToDateTime("01/01/1900");
        tbDefeito.Clear();
        tbMarcaCarro.Clear();
        tbModeloCarro.Clear();
        tbNomeProprietario.Clear();
        tbNumOs.Clear();
        tbPlacaCarro.Clear();
        tbResponsavel.Clear();
        tbTelefone.Clear();
        txtRelatorio.Clear();
        lblStatus.Text = "";
        lblMecanico.Text = "";
        lblFormaPgto.Text = "";
        lblSubPecas.Text = "0,00";
        lblSubServicos.Text = "0,00";
        lblTotalGeral.Text = "0,00";
        decimal total = 0.00M;
        lblTotalOs.Text = total.ToString();
        cbxServicos.DataSource = null;
        cbxMecanico.DataSource = null;
        cbxFormaPgto.DataSource = null;
      }

      public void HabiDesaCampoOs(bool flag)
      {
        //Read_Only
        tbDefeito.ReadOnly = !flag;
        tbNumOs.ReadOnly = flag;
        tbPlacaCarro.ReadOnly = !flag;
        tbResponsavel.ReadOnly = !flag;
        tbTelefone.ReadOnly = !flag;
        txtRelatorio.ReadOnly = !flag;

        //Tab_Stop
        dtOs.TabStop = flag;
        tbDefeito.TabStop = flag;
        tbNumOs.TabStop = flag;
        tbPlacaCarro.TabStop = flag;
        tbResponsavel.TabStop = flag;
        tbTelefone.TabStop = flag;
        txtRelatorio.TabStop = flag;

        //Enabled
        dtOs.Enabled = flag;
      }

      public void ValidarRequisitos()
      {
        if (req_placa)
        {
          butSalvar.Enabled = true;
        }
        else
        {
          butSalvar.Enabled = false;
        }
      }

      public void CalcularTotalPecas()
      {
        decimal total = 0.00M;
        if (GridPecas.RowCount > 0)
        {
          for (int i = 0; i < GridPecas.RowCount; i++)
          {
            if (GridPecas.Rows[i].Cells["estado"].Value.ToString() == "OK")
            {
              total += Convert.ToDecimal(GridPecas.Rows[i].Cells["total"].Value); 
            }            
          }
          lblSubPecas.Text = total.ToString("0.00");
        }
        else
        {
          lblSubPecas.Text = total.ToString("0.00");
        }
      }

      public void CalcularTotalServicos()
      {
        decimal total = 0.00M;
        if (GridServicos.RowCount > 0)
        {
          for (int i = 0; i < GridServicos.RowCount; i++)
          {
            if (GridServicos.Rows[i].Cells["estadoServico"].Value.ToString() == "OK")
            {
              total += Convert.ToDecimal(GridServicos.Rows[i].Cells["oss_valor"].Value);  
            }            
          }
          lblSubServicos.Text = total.ToString("0.00");
        }
        else
        {
          lblSubServicos.Text = total.ToString("0.00");
        }
      }

      public void CalcularTotalPecasEServicos()
      {
        decimal pecas = Convert.ToDecimal(lblSubPecas.Text);
        decimal servicos = Convert.ToDecimal(lblSubServicos.Text);
        decimal total = pecas + servicos;
        //lblTotalGeral.Text = total.ToString("c2");
        lblTotalGeral.Text = total.ToString();
      }

      public void LimparGridPecas()
      {
        DataTable dt_pecas = new DataTable();
        dt_pecas.Columns.Add("idItem", typeof(int));
        dt_pecas.Columns.Add("idProduto", typeof(int));
        dt_pecas.Columns.Add("idOs", typeof(int));
        dt_pecas.Columns.Add("Descricao", typeof(string));
        dt_pecas.Columns.Add("qtde", typeof(int));
        dt_pecas.Columns.Add("valor", typeof(decimal));
        dt_pecas.Columns.Add("total", typeof(decimal));
        dt_pecas.Columns.Add("estado", typeof(string));
        GridPecas.DataSource = dt_pecas;
      }

      public void LimparGridServicos()
      {
        DataTable dt_serv = new DataTable();
        dt_serv.Columns.Add("idItem", typeof(int));
        dt_serv.Columns.Add("idServico", typeof(int));
        dt_serv.Columns.Add("descricao", typeof(string));
        dt_serv.Columns.Add("valor", typeof(decimal));
        dt_serv.Columns.Add("estado", typeof(string));
        GridServicos.DataSource = dt_serv;
      }

      public void HabiDesaCamposPeca(bool flag)
      {
        txtCodigoPeca.ReadOnly = !flag;
        txtCodigoPeca.TabStop = flag;
        btnConsultarProduto.Enabled = flag;
      }

      public void HabiDesaCamposServico(bool flag)
      {
        cbxServicos.Enabled = flag;
      }

      //Metodos_Eventos
      //------------------------------------------------------------------------
      private void butNovo_Click(object sender, EventArgs e)
      {
        novaOs = true;
        this.LimparCampos();
        this.HabiDesaCampoOs(true);
        this.CancelButton = butCancelar;
        tabControl1.SelectedTab = tabPage1;
        dtOs.Value = DateTime.Now;
        butNovo.Enabled = false;
        butCancelar.Enabled = true;
        butConsultar.Enabled = false;
        butAlterar.Enabled = false;
        butFinalizarOs.Enabled = false;
        btnConsultaGeral.Enabled = false;
        btnConsultarVeiculo.Enabled = true;
        butFinalizarOs.Enabled = false;
        btnEmitirCe.Enabled = false;
        btnEmitirOs.Enabled = false;
        tbPlacaCarro.Focus();
      }

      private void butSair_Click(object sender, EventArgs e)
      {
        this.Close();
      }

      private void txtQtdePeca_KeyPress(object sender, KeyPressEventArgs e)
      {
        if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8)
        {
          e.Handled = true;
        }
      }

      private void txtPrecoPeca_KeyPress(object sender, KeyPressEventArgs e)
      {
        if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8 && e.KeyChar != ',')
        {
          e.Handled = true;
        }
      }

      private void txtQtdePeca_Leave(object sender, EventArgs e)
      {
        if (txtQtdePeca.Text.Length == 0)
        {
          txtQtdePeca.Text = "1";
          decimal tot = Convert.ToDecimal(txtQtdePeca.Text) * Convert.ToDecimal(txtPrecoPeca.Text);
          txtTotalPeca.Text = tot.ToString("0.00");
        }
        else
        {
          decimal tot = Convert.ToDecimal(txtQtdePeca.Text) * Convert.ToDecimal(txtPrecoPeca.Text);
          txtTotalPeca.Text = tot.ToString("0.00");
        }
      }

      private void txtPrecoPeca_Leave(object sender, EventArgs e)
      {
        if (txtPrecoPeca.Text.Length > 0)
        {
          if (txtQtdePeca.Text.Length > 0)
          {
            decimal tot = Convert.ToDecimal(txtQtdePeca.Text) * Convert.ToDecimal(txtPrecoPeca.Text);
            txtTotalPeca.Text = tot.ToString("0.00");
          }
          else
          {
            txtQtdePeca.Text = "1";
            decimal tot = Convert.ToDecimal(txtQtdePeca.Text) * Convert.ToDecimal(txtPrecoPeca.Text);
            txtTotalPeca.Text = tot.ToString("0.00");
          }
        }
      }

      private void btnCancelarPeca_Click(object sender, EventArgs e)
      {
        novoItemPeca = false;
        if (GridPecas.RowCount > 0)
        {
          if (GridPecas.Rows[0].Cells["estado"].Value.ToString() == "CANCELADO")
          {
            btnCancelarItemPeca.Enabled = false;
          }
          else
          {
            btnCancelarItemPeca.Enabled = true;
          }
        }
        if (GridServicos.RowCount > 0)
        {
          if (GridServicos.Rows[0].Cells["estadoservico"].Value.ToString() == "CANCELADO")
          {
            btnCancelarItemServico.Enabled = false;
          }
          else
          {
            btnCancelarItemServico.Enabled = true;
          }
        }

        if (butCancelar.Enabled == true)
        {
          this.CancelButton = butCancelar;
        }
        else
        {
          this.CancelButton = butSair;
        }
      }

      private void btnCancelarServico_Click(object sender, EventArgs e)
      {
        novoItemServico = false;
        txtPrecoServico.Clear();      
        if (GridPecas.RowCount > 0)
        {
          if (GridPecas.Rows[0].Cells["estado"].Value.ToString() == "CANCELADO")
          {
            btnCancelarItemPeca.Enabled = false;
          }
          else
          {
            btnCancelarItemPeca.Enabled = true;
          }
        }
        if (GridServicos.RowCount > 0)
        {
          if (GridServicos.Rows[0].Cells["estadoservico"].Value.ToString() == "CANCELADO")
          {
            btnCancelarItemServico.Enabled = false;
          }
          else
          {
            btnCancelarItemServico.Enabled = true;
          }
        }

        if (butCancelar.Enabled == true)
        {
          this.CancelButton = butCancelar;
        }
        else
        {
          this.CancelButton = butSair;
        }
      }

      private void btnSalvarServico_Click(object sender, EventArgs e)
      {
        ItemOsServico serv = new ItemOsServico();
        serv.IdServico = Convert.ToInt32(cbxServicos.SelectedValue);
        serv.ValorServico = Convert.ToDecimal(txtPrecoServico.Text);
        serv.IdOs = Convert.ToInt32(tbNumOs.Text);
        serv.Estado = "OK";
        serv.VerificaQtdeItensServico();
        serv.InserirItemServico();
        lblSubServicos.Text = serv.CalcularSubTotal();
        decimal total = Convert.ToDecimal(lblSubPecas.Text) + Convert.ToDecimal(lblSubServicos.Text);
        lblTotalGeral.Text = total.ToString();
        lblTotalOs.Text = total.ToString();
        //txtPrecoServico.Clear();
        ds = serv.AtualizarGridServico();
        GridServicos.DataSource = ds.Tables["os_servico"];
        txtPrecoServico.Clear();
        btnSalvarServico.Enabled = false;
        cbxServicos.Focus();

        OrdemServico os = new OrdemServico();
        os.IdOs = idOsAtual;
        os.AtualizarTotal(total);
      }

      private void butCancelar_Click(object sender, EventArgs e)
      {
        DialogResult res = MessageBox.Show("Deseja realmente cancelar a alteração dos dados da Os?", "Cancelar Alteração de Dados", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
        if (res == DialogResult.Yes)
        {
          novaOs = false;
          idOsAtual = 0;
          this.LimparCampos();
          this.HabiDesaCampoOs(false);
          this.OrganizaBotoes();

          ItemOsPeca itemPeca = new ItemOsPeca();
          ds = new DataSet();
          ds = itemPeca.LimparGridPeca();
          GridPecas.DataSource = ds.Tables["os_produto"];
          ItemOsServico itemServ = new ItemOsServico();
          ds2 = new DataSet();
          ds2 = itemServ.LimparGridServico();
          GridServicos.DataSource = ds2.Tables["os_servico"];

          this.CancelButton = butSair;
          tabControl1.SelectedTab = tabPage1;
          tbNumOs.Focus();
        }
      }

      private void FormCadOs_KeyDown(object sender, KeyEventArgs e)
      {
        if (e.KeyCode == Keys.F6)
        {
          if (btnConsultaGeral.Enabled)
          {
            this.LimparCampos();
            this.HabiDesaCampoOs(false);
            FormGridOs grid = new FormGridOs(this);
            grid.MdiParent = this.ParentForm;
            grid.Show();
          }
          else if (tbPlacaCarro.Focused == true || tbMarcaCarro.Focused == true || tbModeloCarro.Focused == true)
          {
            FormGridVeiculos grid = new FormGridVeiculos(this, "os");
            grid.MdiParent = this.ParentForm;
            grid.Show();
          }
        }
        else if (e.KeyCode == Keys.F2)
        {
          if (tbPlacaCarro.Focused == true || tbMarcaCarro.Focused == true || tbModeloCarro.Focused == true)
          {
            FormCadVeiculos cadVei = new FormCadVeiculos((FormPrincipal)this.MdiParent);
            cadVei.MdiParent = this.ParentForm;
            cadVei.Show();
          }
        }
        else if (e.KeyCode == Keys.Enter)
        {
          if (e.Shift)
          {
            e.SuppressKeyPress = true;
            SendKeys.Send("+{TAB}");
          }
          else
          {
            e.SuppressKeyPress = true;
            SendKeys.Send("{TAB}");
          }
        }
      }

      private void tbPlacaCarro_Leave_1(object sender, EventArgs e)
      {
        string placa = tbPlacaCarro.Text;
        tbPlacaCarro.Text = placa.ToUpper();

        if (tbPlacaCarro.Text.Length < 8)
        {
          tbPlacaCarro.Clear();
          tbMarcaCarro.Clear();
          tbModeloCarro.Clear();
          tbCodigoProprietario.Clear();
          tbNomeProprietario.Clear();
          req_placa = false;
          this.ValidarRequisitos();
        }
        else
        {
          Veiculo vei = new Veiculo();
          vei.Placa = tbPlacaCarro.Text;
          vei.ConsultarVeiculo();

          if (vei.Marca != null)
          {
            tbMarcaCarro.Text = vei.Marca;
            tbModeloCarro.Text = vei.Modelo;
            tbCodigoProprietario.Text = Convert.ToString(vei.IdCliente);

            Cliente cli = new Cliente();
            cli.IdCliente = Convert.ToInt32(tbCodigoProprietario.Text);
            cli.LocalizaCliente();
            if (cli.Cnpj == "")
            {
              PessoaFisica cliPf = new PessoaFisica();
              cliPf.Cpf = cli.Cpf;
              cliPf.ConsultarRegistro();
              tbNomeProprietario.Text = cliPf.Nome;
              req_placa = true;
              this.ValidarRequisitos();
              tbResponsavel.Focus();
            }
            else if (cli.Cpf == "")
            {
              PessoaJuridica cliPj = new PessoaJuridica();
              cliPj.Cnpj = cli.Cnpj;
              cliPj.ConsultarRegistro();
              tbNomeProprietario.Text = cliPj.Razaosocial;
              req_placa = true;
              this.ValidarRequisitos();
              tbResponsavel.Focus();
            }
          }
          else
          {
            tbMarcaCarro.Clear();
            tbModeloCarro.Clear();
            tbCodigoProprietario.Clear();
            tbNomeProprietario.Clear();
            req_placa = false;
            this.ValidarRequisitos();
          }
        }
      }

      private void butSalvar_Click(object sender, EventArgs e)
      {
        if (novaOs)
        {
          DialogResult res = MessageBox.Show("Confirma a abertura da Ordem de Serviço?", "Nova Ordem de Serviço", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
          if (res == DialogResult.Yes)
          {
            os = new OrdemServico();
            os.DataOs = Convert.ToDateTime(dtOs.Value);
            os.Defeito = tbDefeito.Text;
            os.Placa = tbPlacaCarro.Text;
            os.Status = "ABERTA";
            os.Responsavel = tbResponsavel.Text;
            os.Telefone = tbTelefone.Text;
            os.Rel_tecnico = txtRelatorio.Text;

            os.InserirOs();
            os.RetornaCodigo_Status();
            idOsAtual = os.IdOs;
            tbNumOs.Text = Convert.ToString(os.IdOs);
            lblStatus.Text = os.Status;

            this.HabiDesaCampoOs(false);
            this.OrganizaBotoes();
            btnEmitirCe.Enabled = true;
            btnEmitirOs.Enabled = false;
            butFinalizarOs.Enabled = true;
            this.CancelButton = butSair;
            butAlterar.Enabled = true;
            novaOs = false;
            tbNumOs.Focus();
            tbNumOs.SelectAll();
            DialogResult compr = MessageBox.Show("Deseja imprimir o comprovante de entrada?", "Comprovante de Entrada", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (compr == DialogResult.Yes)
            {
              FormRelatorioComprovante comp = new FormRelatorioComprovante();
              comp.idOs = os.IdOs;
              comp.placa = os.Placa;
              comp.MdiParent = this.ParentForm;
              comp.Show();
            }
          }
        }
        else
        {
          DialogResult res = MessageBox.Show("Confirma a atualização dos dados da Ordem de Serviço?", "Nova Ordem de Serviço", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
          if (res == DialogResult.Yes)
          {
            os = new OrdemServico();
            os.Defeito = tbDefeito.Text;
            os.Responsavel = tbResponsavel.Text;
            os.Telefone = tbTelefone.Text;
            os.Rel_tecnico = txtRelatorio.Text;
            //os.IdOs = Convert.ToInt32(tbNumOs.Text);
            os.IdOs = idOsAtual;

            os.AtualizarDadosOs();

            this.HabiDesaCampoOs(false);
            this.OrganizaBotoes();
            btnEmitirCe.Enabled = true;
            //btnEmitirOs.Enabled = true;
            if (lblStatus.Text == "ABERTA")
            {
              butFinalizarOs.Enabled = true;
              btnEmitirOs.Enabled = false;
            }
            else
            {
              butFinalizarOs.Enabled = false;
              btnEmitirOs.Enabled = true;
            }
            this.CancelButton = butSair;
            butAlterar.Enabled = true;
            novaOs = false;
            tbNumOs.Focus();
            tbNumOs.SelectAll();
          }
        }
        tabControl1.SelectedTab = tabPage1;
        tbNumOs.Select();
      }

      private void butConsultar_Click(object sender, EventArgs e)
      {
        if (tbNumOs.Text.Length == 0)
        {
          this.LimparCampos();
          this.HabiDesaCampoOs(false);
          this.OrganizaBotoes();
          FormGridOs grid = new FormGridOs(this);
          grid.MdiParent = this.ParentForm;
          grid.Show();
        }
        else
        {
          os = new OrdemServico();
          os.IdOs = Convert.ToInt32(tbNumOs.Text);
          os.ConsultarOs();
          if (os.Placa != null)
          {
            idOsAtual = os.IdOs;
            dtOs.Value = os.DataOs;
            lblStatus.Text = os.Status;
            if (lblStatus.Text == "ABERTA")
            {
              butFinalizarOs.Enabled = true;
              btnEmitirOs.Enabled = false;
              btnEmitirCe.Enabled = true;
            }
            else
            {
              butFinalizarOs.Enabled = false;
              btnEmitirOs.Enabled = true;
              btnEmitirCe.Enabled = true;
            }
            //lblTotalOs.Text = os.Total.ToString("c2");
            lblTotalOs.Text = os.Total.ToString();
            tbResponsavel.Text = os.Responsavel;
            tbTelefone.Text = os.Telefone;
            tbDefeito.Text = os.Defeito;
            tbPlacaCarro.Text = os.Placa;
            if (tbPlacaCarro.Text.Length == 8 && tbNumOs.Text.Length > 0)
            {
              btnEmitirOs.Enabled = true;
              btnEmitirCe.Enabled = true;
            }
            else
            {
              btnEmitirOs.Enabled = false;
              btnEmitirCe.Enabled = false;
            }
            txtRelatorio.Text = os.Rel_tecnico;
            if (os.IdMecanico > 0)
            {
              Funcionario func = new Funcionario();
              DataTable dtableFunc = new DataTable();
              dtableFunc = func.PreencherCbx();
              cbxMecanico.DisplayMember = "nomeFunc";
              cbxMecanico.ValueMember = "idFunc";
              cbxMecanico.DataSource = dtableFunc;
              DataRow[] row = dtableFunc.Select("idFunc = '" + os.IdMecanico + "'");
              cbxMecanico.Text = row[0]["nomeFunc"].ToString();
              lblMecanico.Text = row[0]["nomeFunc"].ToString();
            }
            else 
            {
              lblMecanico.Text = "";
              cbxMecanico.DataSource = null;
            }

            if (os.IdFinalizadora > 0)
            {
              Finalizadora fin = new Finalizadora();
              DataTable dtableFin = new DataTable();
              dtableFin = fin.PreencherCbx();
              cbxFormaPgto.DisplayMember = "descricao";
              cbxFormaPgto.ValueMember = "id";
              cbxFormaPgto.DataSource = dtableFin;
              DataRow[] row = dtableFin.Select("id = '" + os.IdFinalizadora + "'");
              cbxFormaPgto.Text = row[0]["descricao"].ToString();
              lblFormaPgto.Text = row[0]["descricao"].ToString();
            }
            else
            {
              lblFormaPgto.Text = "";
              cbxFormaPgto.DataSource = null;
            }

            Veiculo vei = new Veiculo();
            vei.Placa = tbPlacaCarro.Text;
            vei.ConsultarVeiculo();
            if (vei.Marca != null)
            {
              tbMarcaCarro.Text = vei.Marca;
              tbModeloCarro.Text = vei.Modelo;
              tbCodigoProprietario.Text = Convert.ToString(vei.IdCliente);

              Cliente cli = new Cliente();
              cli.IdCliente = Convert.ToInt32(tbCodigoProprietario.Text);
              cli.LocalizaCliente();
              if (cli.Cnpj == "")
              {
                PessoaFisica cliPf = new PessoaFisica();
                cliPf.Cpf = cli.Cpf;
                cliPf.ConsultarRegistro();
                tbNomeProprietario.Text = cliPf.Nome;
              }
              else if (cli.Cpf == "")
              {
                PessoaJuridica cliPj = new PessoaJuridica();
                cliPj.Cnpj = cli.Cnpj;
                cliPj.ConsultarRegistro();
                tbNomeProprietario.Text = cliPj.Razaosocial;
              }
              tbNumOs.Focus();
              tbNumOs.SelectAll();
              if (lblStatus.Text == "ABERTA")
              {
                btnCancelarItemPeca.Enabled = false;
                btnCancelarItemServico.Enabled = false;
                butAlterar.Enabled = true;
                butFinalizarOs.Enabled = true;
              }
              else
              {
                butAlterar.Enabled = false;
                butFinalizarOs.Enabled = false;
              }
            }
          }
          else
          {
            idOsAtual = 0;
            this.LimparCampos();
            this.OrganizaBotoes();
            tbNumOs.Focus();
          }
        }
      }

      private void butAlterar_Click(object sender, EventArgs e)
      {
        novaOs = false;
        req_placa = true;
        this.HabiDesaCampoOs(true);
        dtOs.Enabled = false;
        dtOs.TabStop = false;
        tbPlacaCarro.ReadOnly = true;
        tbPlacaCarro.TabStop = false;
        this.ValidarRequisitos();
        butNovo.Enabled = false;
        butAlterar.Enabled = false;
        butCancelar.Enabled = true;
        butConsultar.Enabled = false;
        butFinalizarOs.Enabled = false;
        btnEmitirCe.Enabled = false;
        btnEmitirOs.Enabled = false;
        btnConsultaGeral.Enabled = false;
        //btnConsultarVeiculo.Enabled = true;
        this.CancelButton = butCancelar;

        tbResponsavel.Focus();
      }

      private void btnSalvarPeca_Click(object sender, EventArgs e)
      {
        ItemOsPeca peca = new ItemOsPeca();
        peca.usuarioAtual = usuarioAtual;
        peca.IdPeca = Convert.ToInt32(txtCodigoPeca.Text);
        peca.QtdPeca = Convert.ToInt32(txtQtdePeca.Text);
        peca.ValorPeca = Convert.ToDecimal(txtPrecoPeca.Text);
        peca.IdOs = idOsAtual;
        peca.Estado = "OK";
        peca.VerificaQtdeItensPeca();
        peca.InserirItemPeca();
        peca.AtualizarEstoquePeca("-", Convert.ToInt32(txtQtdePeca.Text));
        peca.Call_SP_EstadoProduto();
        lblSubPecas.Text = peca.CalcularSubTotal();
        decimal total = Convert.ToDecimal(lblSubPecas.Text) + Convert.ToDecimal(lblSubServicos.Text);
        lblTotalGeral.Text = total.ToString("0.00");
        lblTotalOs.Text = total.ToString("0.00");
        ds = peca.AtualizarGridPeca();

        GridPecas.DataSource = ds.Tables["os_produto"];
        if (GridPecas.RowCount > 0)
        {
          if (GridPecas.Rows[0].Cells["estado"].Value.ToString() == "OK")
          {
            btnCancelarItemPeca.Enabled = true;
          }
          else
          {
            btnCancelarItemPeca.Enabled = false;
          }
        }
        OrdemServico os = new OrdemServico();
        os.IdOs = idOsAtual;
        os.AtualizarTotal(total);
        txtDescricaoPeca.Clear();
        txtQtdePeca.Clear();
        txtPrecoPeca.Clear();
        txtTotalPeca.Clear();
        txtQtdePeca.ReadOnly = true;
        txtQtdePeca.TabStop = false;
        btnSalvarPeca.Enabled = false;
        txtCodigoPeca.Clear();
        txtCodigoPeca.Focus();
      }

      private void tabPage2_Enter(object sender, EventArgs e)
      {
        ItemOsPeca peca = new ItemOsPeca();
        peca.IdOs = idOsAtual;
        ds = new DataSet();
        ds = peca.AtualizarGridPeca();
        GridPecas.DataSource = ds.Tables["os_produto"];

        ItemOsServico serv = new ItemOsServico();
        serv.IdOs = idOsAtual;
        ds2 = new DataSet();
        ds2 = serv.AtualizarGridServico();
        GridServicos.DataSource = ds2.Tables["os_servico"];

        //Calcula aqui os subtotais
        //------------------------------------------------------------------
        this.CalcularTotalPecas();
        this.CalcularTotalServicos();
        this.CalcularTotalPecasEServicos();

        if (lblStatus.Text == "ABERTA")
        {
          //Preenche ComboBox
          //------------------------------------------------------------------
          cbxServicos.Enabled = true;
          Servicos servicos = new Servicos();
          dt = new DataTable();
          dt = servicos.PreencherCbx();
          cbxServicos.DisplayMember = "descricao";
          cbxServicos.ValueMember = "id";
          cbxServicos.DataSource = dt;

          //Habilita Campos para novos itens
          //------------------------------------------------------------------
          //txtCodigoPeca.Clear();
          //txtCodigoPeca.ReadOnly = false;
          //txtCodigoPeca.TabStop = true;
          btnConsultarProduto.Enabled = true;

          if (GridPecas.RowCount > 0)
          {
            if (GridPecas.Rows[0].Cells["estado"].Value.ToString() == "OK")
            {
              btnCancelarItemPeca.Enabled = true;
            }
            else
            {
              btnCancelarItemPeca.Enabled = false;
            }
          }

          if (GridServicos.RowCount > 0)
          {
            if (GridServicos.Rows[0].Cells["estadoServico"].Value.ToString() == "OK")
            {
              btnCancelarItemServico.Enabled = true;
            }
            else
            {
              btnCancelarItemServico.Enabled = false;
            }
          }
        }
        else
        {
          cbxServicos.DataSource = null;
          cbxServicos.Enabled = false;
          btnSalvarServico.Enabled = false;
          btnSalvarPeca.Enabled = false;
          btnCancelarItemPeca.Enabled = false;
          btnCancelarItemServico.Enabled = false;
          txtPrecoServico.Clear();
          txtDescricaoPeca.Clear();
          txtQtdePeca.Clear();
          txtPrecoPeca.Clear();
          txtTotalPeca.Clear();
          txtCodigoPeca.Clear();
          txtCodigoPeca.ReadOnly = true;
          txtCodigoPeca.TabStop = false;
          btnConsultarProduto.Enabled = false;
        }
      }

      private void tbNumOs_KeyPress(object sender, KeyPressEventArgs e)
      {
        if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8)
        {
          e.Handled = true;
        }
      }

      private void btnExcluirPeca_Click(object sender, EventArgs e)
      {
        DataGridViewRow linhaAtual = GridPecas.CurrentRow;
        int i = linhaAtual.Index;

        DialogResult res = MessageBox.Show("Confirma o cancelamento do Item --> " + Convert.ToString(GridPecas.Rows[i].Cells["idItem"].Value) + " ?", "Cancelamento de Item", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
        if (res == DialogResult.Yes)
        {
          ItemOsPeca peca = new ItemOsPeca();
          peca.usuarioAtual = usuarioAtual;
          peca.IdItem = Convert.ToInt32(GridPecas.Rows[i].Cells["idItem"].Value);
          peca.QtdPeca = Convert.ToInt32(GridPecas.Rows[i].Cells["qtde"].Value);
          peca.IdOs = idOsAtual;
          peca.Estado = "CANCELADO";
          peca.CancelarItemPeca();
          peca.IdPeca = Convert.ToInt32(GridPecas.Rows[i].Cells["idProduto"].Value);
          peca.AtualizarEstoquePeca("+", Convert.ToInt32(GridPecas.Rows[i].Cells["qtde"].Value));
          peca.Call_SP_EstadoProduto();
          lblSubPecas.Text = peca.CalcularSubTotal();
          decimal total = Convert.ToDecimal(lblSubPecas.Text) + Convert.ToDecimal(lblSubServicos.Text);
          lblTotalGeral.Text = total.ToString();
          lblTotalOs.Text = total.ToString();
          ds = peca.AtualizarGridPeca();
          GridPecas.DataSource = ds.Tables["os_produto"];

          OrdemServico os = new OrdemServico();
          os.IdOs = idOsAtual;
          os.AtualizarTotal(total);

          GridPecas.Rows[i].Selected = true;
          btnCancelarItemPeca.Enabled = false;
        }
      }

      private void GridPecas_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
      {
        if (this.GridPecas.RowCount > 0)
        {
          if (GridPecas.Rows[e.RowIndex].Cells["estado"].Value.ToString() == "CANCELADO")
          {
            e.CellStyle.ForeColor = Color.Red;
            e.CellStyle.Font = new Font(this.Font, FontStyle.Bold);
          }
        }
      }

      private void GridPecas_CellClick(object sender, DataGridViewCellEventArgs e)
      {
        if (GridPecas.RowCount > 0 && e.RowIndex >= 0)
        {
          DataGridViewRow linhaAtual = GridPecas.CurrentRow;
          int i = linhaAtual.Index;
          if (lblStatus.Text == "ABERTA")
          {
            if (GridPecas.Rows[i].Cells["estado"].Value.ToString() == "CANCELADO")
            {
              btnCancelarItemPeca.Enabled = false;
            }
            else
            {
              btnCancelarItemPeca.Enabled = true;
            }
          }
        }
      }

      private void GridServicos_CellClick(object sender, DataGridViewCellEventArgs e)
      {        
        if (GridServicos.RowCount > 0 && e.RowIndex >= 0)
        {
          DataGridViewRow linhaAtual = GridServicos.CurrentRow;
          int i = linhaAtual.Index;
          if (lblStatus.Text == "ABERTA")
          {
            if (GridServicos.Rows[i].Cells[4].Value.ToString() == "CANCELADO")
            {
              btnCancelarItemServico.Enabled = false;
            }
            else
            {
              btnCancelarItemServico.Enabled = true;
            }
          }
        }
      }

      private void btnCancelarItemServico_Click(object sender, EventArgs e)
      {
        DataGridViewRow linhaAtual = GridServicos.CurrentRow;
        int i = linhaAtual.Index;

        DialogResult res = MessageBox.Show("Confirma o cancelamento do Item --> " + Convert.ToString(GridServicos.Rows[i].Cells["oss_idItem"].Value) + " ?", "Cancelamento de Item", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
        if (res == DialogResult.Yes)
        {
          ItemOsServico serv = new ItemOsServico();
          serv.IdItem = Convert.ToInt32(GridServicos.Rows[i].Cells["oss_idItem"].Value);
          serv.IdOs = idOsAtual;
          serv.Estado = "CANCELADO";
          serv.CancelarItemServico();
          lblSubServicos.Text = serv.CalcularSubTotal();
          decimal total = Convert.ToDecimal(lblSubPecas.Text) + Convert.ToDecimal(lblSubServicos.Text);
          lblTotalGeral.Text = total.ToString();
          lblTotalOs.Text = total.ToString();
          ds2 = serv.AtualizarGridServico();
          GridServicos.DataSource = ds2.Tables["os_servico"];
          OrdemServico os = new OrdemServico();
          os.IdOs = idOsAtual;
          os.AtualizarTotal(total);

          GridServicos.Rows[i].Selected = true;
          btnCancelarItemServico.Enabled = false;
        }
      }

      private void GridServicos_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
      {
        if (this.GridServicos.RowCount > 0)
        {
          if (this.GridServicos.Rows[e.RowIndex].Cells[4].Value.ToString() == "CANCELADO")
          {
            e.CellStyle.ForeColor = Color.Red;
            e.CellStyle.Font = new Font(this.Font, FontStyle.Bold);
          }
        }
      }

      private void tabPage3_Enter(object sender, EventArgs e)
      {
        if (lblStatus.Text == "ABERTA")
        {
          butMecanico.Enabled = true;
          butPagamento.Enabled = true;
          //butFinalizarOs.Enabled = true;
        }
        else
        {
          butMecanico.Enabled = false;
          butPagamento.Enabled = false;
          //butFinalizarOs.Enabled = false;
        }
      }

      private void butMecanico_Click(object sender, EventArgs e)
      {
        butMecanico.Enabled = false;
        butPagamento.Enabled = false;
        gpbMecanico.Enabled = true;
        Funcionario func = new Funcionario();
        DataTable dtableFunc;
        dtableFunc = func.PreencherCbx();
        cbxMecanico.DisplayMember = "nomeFunc";
        cbxMecanico.ValueMember = "idFunc";
        cbxMecanico.DataSource = dtableFunc;
        if (cbxMecanico.Items.Count > 0)
        {
          butSalvarMecanico.Enabled = true;
          cbxMecanico.Text = lblMecanico.Text;
        }
        else
        {
          butSalvarMecanico.Enabled = false;
        }
        this.CancelButton = butCancelarMecanico;
        cbxMecanico.Focus();
      }

      private void butPagamento_Click(object sender, EventArgs e)
      {
        butMecanico.Enabled = false;
        butPagamento.Enabled = false;
        gpbFormaPgto.Enabled = true;
        Finalizadora fin = new Finalizadora();
        DataTable dtableFin;
        dtableFin = fin.PreencherCbx();
        cbxFormaPgto.DisplayMember = "descricao";
        cbxFormaPgto.ValueMember = "id";
        cbxFormaPgto.DataSource = dtableFin;
        if (cbxFormaPgto.Items.Count > 0)
        {
          butSalvarFormaPgto.Enabled = true;
          cbxFormaPgto.Text = lblFormaPgto.Text;
        }
        else
        {
          butSalvarFormaPgto.Enabled = false;
        }
        this.CancelButton = butCancelarFormaPgto;
        cbxFormaPgto.Focus();
      }

      private void butCancelarMecanico_Click(object sender, EventArgs e)
      {
        cbxMecanico.DataSource = null;
        cbxMecanico.Items.Add(lblMecanico.Text);
        cbxMecanico.Text = lblMecanico.Text;
        gpbMecanico.Enabled = false;
        butPagamento.Enabled = true;
        butMecanico.Enabled = true;
        if (butCancelar.Enabled == true)
        {
          this.CancelButton = butCancelar;
        }
        else
        {
          this.CancelButton = butSair;
        }
      }

      private void butCancelarFormaPgto_Click(object sender, EventArgs e)
      {
        cbxFormaPgto.DataSource = null;
        cbxFormaPgto.Items.Add(lblFormaPgto.Text);
        cbxFormaPgto.Text = lblFormaPgto.Text;
        gpbFormaPgto.Enabled = false;
        butPagamento.Enabled = true;
        butMecanico.Enabled = true;
        if (butCancelar.Enabled == true)
        {
          this.CancelButton = butCancelar;
        }
        else
        {
          this.CancelButton = butSair;
        }       
      }

      private void butSalvarMecanico_Click(object sender, EventArgs e)
      {
        OrdemServico os = new OrdemServico();
        os.IdMecanico = Convert.ToInt32(cbxMecanico.SelectedValue);
        os.IdOs = idOsAtual;
        os.AtualizarMecanico();

        gpbMecanico.Enabled = false;
        butPagamento.Enabled = true;
        butMecanico.Enabled = true;
        lblMecanico.Text = cbxMecanico.Text;
      }

      private void butSalvarFormaPgto_Click(object sender, EventArgs e)
      {
        OrdemServico os = new OrdemServico();
        os.IdFinalizadora = Convert.ToInt32(cbxFormaPgto.SelectedValue);
        os.IdOs = idOsAtual;
        os.AtualizarFinalizadora();

        gpbFormaPgto.Enabled = false;
        butPagamento.Enabled = true;
        butMecanico.Enabled = true;
        lblFormaPgto.Text = cbxFormaPgto.Text;
      }

      private void butFinalizarOs_Click(object sender, EventArgs e)
      {
        if (cbxFormaPgto.Text.Length > 0 && cbxMecanico.Text.Length > 0)
        {
          DialogResult res = MessageBox.Show("Confirma a finalização da Ordem de Serviço: " + tbNumOs.Text , "Finalizar OS", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
          if (res == DialogResult.Yes)
          {
            os = new OrdemServico();
            os.IdOs = idOsAtual;
            os.Status = "FINALIZADA";
            os.FinalizarOs();

            lblStatus.Text = os.Status;

            this.HabiDesaCampoOs(false);
            this.OrganizaBotoes();
            btnEmitirOs.Enabled = true;
            btnEmitirCe.Enabled = true;
            this.CancelButton = butSair;
            novaOs = false;
            tabControl1.SelectedTab = tabPage1;
            tbNumOs.Focus();
            tbNumOs.SelectAll();
            DialogResult resOs = MessageBox.Show("Deseja emitir a Ordem de Serviço?", "Ordem de Serviço", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            {
              if (resOs == DialogResult.Yes)
              {
                FormRelatorioOs relOs = new FormRelatorioOs();
                relOs.idOs = idOsAtual;
                relOs.idFinalizadora = Convert.ToInt32(cbxFormaPgto.SelectedValue);
                relOs.idMecanico = Convert.ToInt32(cbxMecanico.SelectedValue);
                relOs.placa = tbPlacaCarro.Text;

                relOs.MdiParent = this.ParentForm;
                relOs.Show();
              }
            }
          }
        }
        else
        {
          MessageBox.Show("Verifique se a forma de pagamento e/ou mecânico estão informados na Ordem de Serviço...", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
      }

      private void tabPage2_Leave(object sender, EventArgs e)
      {
        txtCodigoPeca.Clear();
        txtDescricaoPeca.Clear();
        txtQtdePeca.Clear();
        txtPrecoPeca.Clear();
        txtTotalPeca.Clear();
        txtQtdePeca.ReadOnly = true;
        txtQtdePeca.TabStop = false;
        btnSalvarPeca.Enabled = false; 
      }

      private void btnEmitirOs_Click(object sender, EventArgs e)
      {
        FormRelatorioOs relOs = new FormRelatorioOs();
        relOs.idOs = idOsAtual;
        relOs.idFinalizadora = Convert.ToInt32(cbxFormaPgto.SelectedValue);
        relOs.idMecanico = Convert.ToInt32(cbxMecanico.SelectedValue);
        relOs.placa = tbPlacaCarro.Text;

        relOs.MdiParent = this.ParentForm;
        relOs.Show();
      }

      private void btnEmitirCe_Click(object sender, EventArgs e)
      {
        FormRelatorioComprovante relCe = new FormRelatorioComprovante();
        relCe.idOs = idOsAtual;
        relCe.placa = tbPlacaCarro.Text;

        relCe.MdiParent = this.ParentForm;
        relCe.Show();
      }

      private void btnConsultar_Click(object sender, EventArgs e)
      {
        gridProd = new FormGridProdutos(this, "os");
        gridProd.MdiParent = this.ParentForm;
        gridProd.Show();
      }

      private void btnConsultaGeral_Click(object sender, EventArgs e)
      {
        this.LimparCampos();
        this.HabiDesaCampoOs(false);
        this.OrganizaBotoes();
        FormGridOs grid = new FormGridOs(this);
        grid.MdiParent = this.ParentForm;
        grid.Show();
      }

      private void tabPage1_Leave(object sender, EventArgs e)
      {

      }

      private void tbNumOs_Leave(object sender, EventArgs e)
      {
        if (tbNumOs.Text.Length != 0)
        {
          os = new OrdemServico();
          os.IdOs = Convert.ToInt32(tbNumOs.Text);
          os.ConsultarOs();
          if (!String.IsNullOrEmpty(os.Placa))
          {
            idOsAtual = os.IdOs;
            dtOs.Value = os.DataOs;
            lblStatus.Text = os.Status;
            if (lblStatus.Text == "ABERTA")
            {
              butFinalizarOs.Enabled = true;
              btnEmitirOs.Enabled = false;
              btnEmitirCe.Enabled = true;
            }
            else
            {
              butFinalizarOs.Enabled = false;
              btnEmitirOs.Enabled = true;
              btnEmitirCe.Enabled = true;
            }
            //lblTotalOs.Text = os.Total.ToString("c2");
            lblTotalOs.Text = os.Total.ToString();
            tbResponsavel.Text = os.Responsavel;
            tbTelefone.Text = os.Telefone;
            tbDefeito.Text = os.Defeito;
            tbPlacaCarro.Text = os.Placa;
            txtRelatorio.Text = os.Rel_tecnico;
            if (os.IdMecanico > 0)
            {
              Funcionario func = new Funcionario();
              DataTable dtableFunc = new DataTable();
              dtableFunc = func.PreencherCbx();
              cbxMecanico.DisplayMember = "nomeFunc";
              cbxMecanico.ValueMember = "idFunc";
              cbxMecanico.DataSource = dtableFunc;
              DataRow[] row = dtableFunc.Select("idFunc = '" + os.IdMecanico + "'");
              cbxMecanico.Text = row[0]["nomeFunc"].ToString();
              lblMecanico.Text = row[0]["nomeFunc"].ToString();
            }
            else
            {
              lblMecanico.Text = "";
              cbxMecanico.DataSource = null;
            }

            if (os.IdFinalizadora > 0)
            {
              Finalizadora fin = new Finalizadora();
              DataTable dtableFin = new DataTable();
              dtableFin = fin.PreencherCbx();
              cbxFormaPgto.DisplayMember = "descricao";
              cbxFormaPgto.ValueMember = "id";
              cbxFormaPgto.DataSource = dtableFin;
              DataRow[] row = dtableFin.Select("id = '" + os.IdFinalizadora + "'");
              cbxFormaPgto.Text = row[0]["descricao"].ToString();
              lblFormaPgto.Text = row[0]["descricao"].ToString();
            }
            else
            {
              lblFormaPgto.Text = "";
              cbxFormaPgto.DataSource = null;
            }

            Veiculo vei = new Veiculo();
            vei.Placa = tbPlacaCarro.Text;
            vei.ConsultarVeiculo();
            if (vei.Marca != null)
            {
              tbMarcaCarro.Text = vei.Marca;
              tbModeloCarro.Text = vei.Modelo;
              tbCodigoProprietario.Text = Convert.ToString(vei.IdCliente);

              Cliente cli = new Cliente();
              cli.IdCliente = Convert.ToInt32(tbCodigoProprietario.Text);
              cli.LocalizaCliente();
              if (cli.Cnpj == "")
              {
                PessoaFisica cliPf = new PessoaFisica();
                cliPf.Cpf = cli.Cpf;
                cliPf.ConsultarRegistro();
                tbNomeProprietario.Text = cliPf.Nome;
              }
              else if (cli.Cpf == "")
              {
                PessoaJuridica cliPj = new PessoaJuridica();
                cliPj.Cnpj = cli.Cnpj;
                cliPj.ConsultarRegistro();
                tbNomeProprietario.Text = cliPj.Razaosocial;
              }
              if (lblStatus.Text == "ABERTA")
              {
                btnCancelarItemPeca.Enabled = false;
                btnCancelarItemServico.Enabled = false;
                butAlterar.Enabled = true;
                butFinalizarOs.Enabled = true;
              }
              else
              {
                butAlterar.Enabled = false;
                butFinalizarOs.Enabled = false;
              }
              butNovo.Focus();
            }
          }
          else
          {
            idOsAtual = 0;
            this.LimparCampos();
            this.OrganizaBotoes();
            tbNumOs.Focus();
          }
        }
        else
        {
          idOsAtual = 0;
          this.LimparCampos();
          this.OrganizaBotoes();
        }
      }

      private void btnConsultarVeiculo_Click(object sender, EventArgs e)
      {
        FormGridVeiculos grid = new FormGridVeiculos(this, "os");
        grid.MdiParent = this.ParentForm;
        grid.Show();
      }

      private void tbNumOs_Enter(object sender, EventArgs e)
      {
        tbNumOs.SelectAll();
      }

      private void cbxServicos_DropDownClosed(object sender, EventArgs e)
      {
        if (cbxServicos.Items.Count > 0)
        {
          DataRow[] row = dt.Select("id = '" + Convert.ToInt32(cbxServicos.SelectedValue) + "'");
          txtPrecoServico.Text = row[0]["valor"].ToString();
          btnSalvarServico.Enabled = true;
          btnSalvarServico.Focus();
        }
      }

      private void txtCodigoProduto_Leave(object sender, EventArgs e)
      {
        if (txtCodigoPeca.Text.Length > 0)
        {
          Produtos prod = new Produtos();
          prod.Id = Convert.ToInt32(txtCodigoPeca.Text);
          prod.LocalizaProduto();
          if (prod.Descricao != null)
          {
            txtDescricaoPeca.Text = prod.Descricao;
            txtQtdePeca.Text = "1";
            txtPrecoPeca.Text = prod.PrecoVenda.ToString("0.00");
            txtTotalPeca.Text = prod.PrecoVenda.ToString("0.00");
            txtQtdePeca.ReadOnly = false;
            txtQtdePeca.TabStop = true;
            btnSalvarPeca.Enabled = true;
            txtQtdePeca.Select();
          }
          else
          {
            txtCodigoPeca.Clear();
            txtDescricaoPeca.Clear();
            txtQtdePeca.Clear();
            txtPrecoPeca.Clear();
            txtTotalPeca.Clear();
            txtQtdePeca.ReadOnly = true;
            txtQtdePeca.TabStop = false;
            btnSalvarPeca.Enabled = false;            
          }
        }
        else
        {
          txtDescricaoPeca.Clear();
          txtQtdePeca.Clear();
          txtPrecoPeca.Clear();
          txtTotalPeca.Clear();
          txtQtdePeca.ReadOnly = true;
          txtQtdePeca.TabStop = false;
          btnSalvarPeca.Enabled = false;
        }
        
      }

      private void txtCodigoProduto_KeyPress(object sender, KeyPressEventArgs e)
      {
        if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8)
        {
          e.Handled = true;
        }
      }
    }
}
