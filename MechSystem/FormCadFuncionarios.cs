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
  public partial class FormCadFuncionarios : Form
  {
    private bool novoFuncionario = false;
    private DataTable dt;
    private bool req_cpf = false;
    private bool req_nome = false;
    private Funcionario func;

    //Construtor
    public FormCadFuncionarios(FormPrincipal parent)
    {
      InitializeComponent();
      this.MdiParent = parent;
      tbCodigoFuncionario.Focus();
    }

    //Metodos_Gerais
    public void LimparCampos()
    {
      tbBairro.Clear();
      tbCelular.Clear();
      tbCep.Clear();
      tbCidade.Clear();
      tbCodigoFuncionario.Clear();
      tbCpfCnpj.Clear();
      tbEndereco.Clear();
      tbEstado.Clear();
      tbNome.Clear();
      tbNumero.Clear();
      tbRgIe.Clear();
      tbSalario.Clear();
      tbTelefone1.Clear();
      dtAdmissao.Value = Convert.ToDateTime("01/01/1900");
      dtNascimento.Value = Convert.ToDateTime("01/01/1900");
      cbxFuncao.DataSource = null;
    }
    
    private void HabiDesaCampos(bool flag)
    {
      //Enabled
      dtAdmissao.Enabled = flag;
      dtNascimento.Enabled = flag;
      cbxFuncao.Enabled = flag;

      //Read_Only
      tbBairro.ReadOnly = !flag;
      tbCelular.ReadOnly = !flag;
      tbCep.ReadOnly = !flag;
      tbCidade.ReadOnly = !flag;
      tbCodigoFuncionario.ReadOnly = flag;
      tbCpfCnpj.ReadOnly = !flag;
      tbEndereco.ReadOnly = !flag;
      tbEstado.ReadOnly = !flag;
      tbNome.ReadOnly = !flag;
      tbNumero.ReadOnly = !flag;
      tbRgIe.ReadOnly = !flag;
      tbSalario.ReadOnly = !flag;
      tbTelefone1.ReadOnly = !flag;

      //TabStop
      tbBairro.TabStop = flag;
      tbCelular.TabStop = flag;
      tbCep.TabStop = flag;
      tbCidade.TabStop = flag;
      tbCodigoFuncionario.TabStop = !flag;
      tbCpfCnpj.TabStop = flag;
      tbEndereco.TabStop = flag;
      tbEstado.TabStop = flag;
      tbNome.TabStop = flag;
      tbNumero.TabStop = flag;
      tbRgIe.TabStop = flag;
      tbSalario.TabStop = flag;
      tbTelefone1.TabStop = flag;

      cbxFuncao.TabStop = flag;

      dtAdmissao.TabStop = flag;
      dtNascimento.TabStop = flag;
    }

    public void ValidarRequisitos()
    {
      if (req_cpf == true && req_nome == true)
      {
        butSalvar.Enabled = true;
      }
      else
      {
        butSalvar.Enabled = false;
      }
    }

    private void OrganizaBotoes()
    {
      butAlterar.Enabled = false;
      butCancelar.Enabled = false;
      butConsultar.Enabled = true;
      butExcluir.Enabled = false;
      butNovo.Enabled = true;
      butSair.Enabled = true;
      butSalvar.Enabled = false;
      btnConsultaGeral.Enabled = true;
    }

    //Metodos_Eventos
    private void butNovo_Click(object sender, EventArgs e)
    {
      novoFuncionario = true;
      this.LimparCampos();
      this.HabiDesaCampos(true);
      butNovo.Enabled = false;
      butCancelar.Enabled = true;
      butConsultar.Enabled = false;
      butAlterar.Enabled = false;
      butExcluir.Enabled = false;
      btnConsultaGeral.Enabled = false;

      //Preenche ComboBox
      dt = new DataTable();
      Funcao fun = new Funcao();
      dt = fun.PreencherCbx();
      cbxFuncao.DisplayMember = "descricao";
      cbxFuncao.ValueMember = "id";
      cbxFuncao.DataSource = dt;
      tbSalario.Text = "0,00";
      tbNome.Focus();
      this.CancelButton = butCancelar;
    }

    private void butSair_Click(object sender, EventArgs e)
    {
      this.Close();
    }

    private void butCancelar_Click(object sender, EventArgs e)
    {
      DialogResult res = MessageBox.Show("Deseja realmente cancelar a operação?", "Cancelar Operação", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
      if (res == DialogResult.Yes)
      {
        this.LimparCampos();
        this.HabiDesaCampos(false);
        this.OrganizaBotoes();
        tbCodigoFuncionario.Focus();
        this.CancelButton = butSair;
        novoFuncionario = false;
      }
    }

    private void tbCpfCnpj_Leave(object sender, EventArgs e)
    {
      if (novoFuncionario)
      {
        if (tbCpfCnpj.Text.Length == 14)
        {
          Funcionario func = new Funcionario();
          func.Cpf = tbCpfCnpj.Text;
          bool cadastrado = func.VerificaCadastro();

          if (cadastrado)
          {
            MessageBox.Show("CPF já cadastrado para outro Funcionário!", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            tbCpfCnpj.Focus();
            tbCpfCnpj.SelectAll();
          }
          else
          {
            ValidaCPF val = new ValidaCPF();
            bool valido = val.Valida(tbCpfCnpj.Text);
            if (valido)
            {
              req_cpf = true;
              this.ValidarRequisitos();
            }
            else
            {
              MessageBox.Show("Número de CPF inválido, digite novamente...", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Warning);
              req_cpf = false;
              this.ValidarRequisitos();
              tbCpfCnpj.Focus();
              tbCpfCnpj.SelectAll();
            }
          }
        }
        else
        {
          tbCpfCnpj.Clear();
          req_cpf = false;
          this.ValidarRequisitos();
        }
      }
    }

    private void butSalvar_Click(object sender, EventArgs e)
    {
      func = new Funcionario();
      func.Bairro = tbBairro.Text;
      func.Celular = tbCelular.Text;
      func.Cep = tbCep.Text;
      func.Cidade = tbCidade.Text;
      func.Cpf = tbCpfCnpj.Text;
      func.Dataadmi = dtAdmissao.Value;
      func.Datanasc = dtNascimento.Value;
      func.Estado = tbEstado.Text;
      func.IdFuncao = Convert.ToInt32(cbxFuncao.SelectedValue);
      func.Logradouro = tbEndereco.Text;
      func.Nome = tbNome.Text;
      func.Numero = tbNumero.Text;
      func.Rg = tbRgIe.Text;
      func.Salario = Convert.ToDecimal(tbSalario.Text);
      func.Telefone = tbTelefone1.Text;
      if (novoFuncionario)
      {
        DialogResult res = MessageBox.Show("Confirma a inserção do registro?", "Novo Registro", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
        if (res == DialogResult.Yes)
        {
          func.InserirFuncionario();
          func.RetornaCodigo();
          tbCodigoFuncionario.Text = func.Id.ToString();

          this.HabiDesaCampos(false);
          this.OrganizaBotoes();
          this.CancelButton = butSair;
          butAlterar.Enabled = true;
          butExcluir.Enabled = true;
          novoFuncionario = false;
          tbCodigoFuncionario.Focus();
          tbCodigoFuncionario.SelectAll();
        }
      }
      else
      {
        DialogResult res = MessageBox.Show("Confirma a alteração do registro?", "Alteração", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
        if (res == DialogResult.Yes)
        {
          func.Id = Convert.ToInt32(tbCodigoFuncionario.Text);
          func.AtualizarFuncionario();

          this.HabiDesaCampos(false);
          this.OrganizaBotoes();
          this.CancelButton = butSair;
          butAlterar.Enabled = true;
          butExcluir.Enabled = true;
          novoFuncionario = false;
          tbCodigoFuncionario.Focus();
          tbCodigoFuncionario.SelectAll();
        }
      }
    }

    private void tbNome_Leave(object sender, EventArgs e)
    {
      if (tbNome.Text.Length > 0)
      {
        req_nome = true;
        this.ValidarRequisitos();
      }
      else
      {
        req_nome = false;
        this.ValidarRequisitos();
      }
    }

    private void tbSalario_Leave(object sender, EventArgs e)
    {
      if (tbSalario.Text.Length == 0 || tbSalario.Text == "0,00")
      {
        tbSalario.Text = "0,00";
      }
      else
      {
        decimal salario = Convert.ToDecimal(tbSalario.Text);
        tbSalario.Text = salario.ToString("0.00");
      }

    }

    private void tbCodigoFuncionario_KeyPress(object sender, KeyPressEventArgs e)
    {
      if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8)
      {
        e.Handled = true;
      }
    }

    private void tbEstado_KeyPress(object sender, KeyPressEventArgs e)
    {
      if (!Char.IsLetter(e.KeyChar) && e.KeyChar != (char)8)
      {
        e.Handled = true;
      }
    }

    private void tbSalario_KeyPress(object sender, KeyPressEventArgs e)
    {
      if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8 && e.KeyChar != ',')
      {
        e.Handled = true;
      }
    }

    private void tbRgIe_KeyPress(object sender, KeyPressEventArgs e)
    {
      if (!Char.IsLetterOrDigit(e.KeyChar) && e.KeyChar != (char)8)
      {
        e.Handled = true;
      }
    }

    private void butAlterar_Click(object sender, EventArgs e)
    {
      novoFuncionario = false;
      req_cpf = true;
      req_nome = true;
      this.HabiDesaCampos(true);
      tbCpfCnpj.ReadOnly = true;
      tbCpfCnpj.TabStop = false;
      butNovo.Enabled = false;
      butCancelar.Enabled = true;
      butConsultar.Enabled = false;
      butSalvar.Enabled = true;
      butAlterar.Enabled = false;
      butExcluir.Enabled = false;
      btnConsultaGeral.Enabled = false;

      //Preenche ComboBox
      string funcaoAtual = cbxFuncao.Text;
      dt = new DataTable();
      Funcao fun = new Funcao();
      dt = fun.PreencherCbx();
      cbxFuncao.DisplayMember = "descricao";
      cbxFuncao.ValueMember = "id";
      cbxFuncao.DataSource = dt;
      cbxFuncao.Text = funcaoAtual;
      tbNome.Focus();
      this.CancelButton = butCancelar;
    }

    private void butConsultar_Click(object sender, EventArgs e)
    {
      if (tbCodigoFuncionario.Text.Length == 0)
      {
        LimparCampos();
        OrganizaBotoes();
        butAlterar.Enabled = false;
        FormGridFuncionarios grid = new FormGridFuncionarios(this);
        grid.MdiParent = this.ParentForm;
        grid.Show();
      }
      else
      {
        func = new Funcionario();
        func.Id = Convert.ToInt32(tbCodigoFuncionario.Text);
        func.ConsultarMecanico();
        if (func.Nome != null)
        {
          dt = new DataTable();
          Funcao fun = new Funcao();
          fun.Id = func.IdFuncao;
          fun.ConsultaFuncao();

          //Preenche ComboBox
          dt = new DataTable();
          dt = fun.PreencherCbx();
          cbxFuncao.DisplayMember = "descricao";
          cbxFuncao.ValueMember = "id";
          cbxFuncao.DataSource = dt;
          cbxFuncao.Text = fun.Descricao;

          tbBairro.Text = func.Bairro;
          tbCelular.Text = func.Celular;
          tbCep.Text = func.Cep;
          tbCidade.Text = func.Cidade;
          tbCpfCnpj.Text = func.Cpf;
          dtAdmissao.Text = Convert.ToString(func.Dataadmi);
          dtNascimento.Text = Convert.ToString(func.Datanasc);
          tbEndereco.Text = func.Logradouro;
          tbEstado.Text = func.Estado;
          tbNome.Text = func.Nome;
          tbNumero.Text = func.Numero;
          tbRgIe.Text = func.Rg;
          tbSalario.Text = Convert.ToString(func.Salario);
          tbTelefone1.Text = func.Telefone;

          butAlterar.Enabled = true;
          butExcluir.Enabled = true;
          tbCodigoFuncionario.Focus();
          tbCodigoFuncionario.SelectAll();
        }
        else
        { 

        }
      }
    }

    private void butExcluir_Click(object sender, EventArgs e)
    {
      DialogResult res = MessageBox.Show("Confirma a exclusão do registro?", "Exclusão", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
      if (res == DialogResult.Yes)
      {
        func = new Funcionario();
        func.Id = Convert.ToInt32(tbCodigoFuncionario.Text);
        func.ExcluirFuncionario();

        this.LimparCampos();
        this.HabiDesaCampos(false);
        this.OrganizaBotoes();
        tbCodigoFuncionario.Focus();
      }
    }

    private void tbNumero_KeyPress(object sender, KeyPressEventArgs e)
    {
      if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8)
      {
        e.Handled = true;
      }
    }

    private void btnConsultaGeral_Click(object sender, EventArgs e)
    {
      LimparCampos();
      OrganizaBotoes();
      butAlterar.Enabled = false;
      FormGridFuncionarios grid = new FormGridFuncionarios(this);
      grid.MdiParent = this.ParentForm;
      grid.Show();
    }

    private void FormCadFuncionarios_KeyDown(object sender, KeyEventArgs e)
    {
      if (e.KeyCode == Keys.F6)
      {
        if (btnConsultaGeral.Enabled)
        {
          LimparCampos();
          OrganizaBotoes();
          butAlterar.Enabled = false;
          FormGridFuncionarios grid = new FormGridFuncionarios(this);
          grid.MdiParent = this.ParentForm;
          grid.Show();
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

    private void tbCodigoFuncionario_Leave(object sender, EventArgs e)
    {
      if (tbCodigoFuncionario.Text.Length != 0)
      {
        func = new Funcionario();
        func.Id = Convert.ToInt32(tbCodigoFuncionario.Text);
        func.ConsultarMecanico();
        if (func.Nome != null)
        {
          dt = new DataTable();
          Funcao fun = new Funcao();
          fun.Id = func.IdFuncao;
          fun.ConsultaFuncao();

          //Preenche ComboBox
          dt = new DataTable();
          dt = fun.PreencherCbx();
          cbxFuncao.DisplayMember = "descricao";
          cbxFuncao.ValueMember = "id";
          cbxFuncao.DataSource = dt;
          cbxFuncao.Text = fun.Descricao;

          tbBairro.Text = func.Bairro;
          tbCelular.Text = func.Celular;
          tbCep.Text = func.Cep;
          tbCidade.Text = func.Cidade;
          tbCpfCnpj.Text = func.Cpf;
          dtAdmissao.Text = Convert.ToString(func.Dataadmi);
          dtNascimento.Text = Convert.ToString(func.Datanasc);
          tbEndereco.Text = func.Logradouro;
          tbEstado.Text = func.Estado;
          tbNome.Text = func.Nome;
          tbNumero.Text = func.Numero;
          tbRgIe.Text = func.Rg;
          tbSalario.Text = Convert.ToString(func.Salario);
          tbTelefone1.Text = func.Telefone;

          butAlterar.Enabled = true;
          butExcluir.Enabled = true;
          butNovo.Focus();
        }
        else
        { 
          LimparCampos();
          OrganizaBotoes();
          tbCodigoFuncionario.Select();
        }
      }
      else
      {
        LimparCampos();
        OrganizaBotoes();
      }
    }

    private void tbCodigoFuncionario_Enter(object sender, EventArgs e)
    {
      tbCodigoFuncionario.SelectAll();
    }
  }
}
