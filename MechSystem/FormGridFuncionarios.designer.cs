namespace MechSystem
{
  partial class FormGridFuncionarios
  {
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
      if (disposing && (components != null))
      {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormGridFuncionarios));
      this.butSair = new System.Windows.Forms.Button();
      this.dataGridView1 = new System.Windows.Forms.DataGridView();
      this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.Nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.Valor = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.Detalhes = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.Logradouro = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.Numero = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.Bairro = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.Cidade = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.Estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.CEP = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.DataNascimento = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.DataAdminissao = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.Salario = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.Telefone = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.Celular = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.IdFuncao = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.groupBox1 = new System.Windows.Forms.GroupBox();
      this.txtCpf = new System.Windows.Forms.MaskedTextBox();
      this.radCpf = new System.Windows.Forms.RadioButton();
      this.radNome = new System.Windows.Forms.RadioButton();
      this.btnPesquisar = new System.Windows.Forms.Button();
      this.txtNome = new System.Windows.Forms.TextBox();
      ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
      this.groupBox1.SuspendLayout();
      this.SuspendLayout();
      // 
      // butSair
      // 
      this.butSair.Cursor = System.Windows.Forms.Cursors.Hand;
      this.butSair.DialogResult = System.Windows.Forms.DialogResult.Cancel;
      this.butSair.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.butSair.Location = new System.Drawing.Point(761, 407);
      this.butSair.Name = "butSair";
      this.butSair.Size = new System.Drawing.Size(81, 23);
      this.butSair.TabIndex = 2;
      this.butSair.Text = "Sair";
      this.butSair.UseVisualStyleBackColor = true;
      this.butSair.Click += new System.EventHandler(this.butSair_Click);
      // 
      // dataGridView1
      // 
      this.dataGridView1.AllowUserToAddRows = false;
      this.dataGridView1.AllowUserToDeleteRows = false;
      this.dataGridView1.AllowUserToOrderColumns = true;
      this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.Nome,
            this.Valor,
            this.Detalhes,
            this.Logradouro,
            this.Numero,
            this.Bairro,
            this.Cidade,
            this.Estado,
            this.CEP,
            this.DataNascimento,
            this.DataAdminissao,
            this.Salario,
            this.Telefone,
            this.Celular,
            this.IdFuncao});
      this.dataGridView1.Location = new System.Drawing.Point(2, 85);
      this.dataGridView1.MultiSelect = false;
      this.dataGridView1.Name = "dataGridView1";
      this.dataGridView1.ReadOnly = true;
      this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
      this.dataGridView1.Size = new System.Drawing.Size(840, 316);
      this.dataGridView1.TabIndex = 1;
      this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
      this.dataGridView1.Leave += new System.EventHandler(this.dataGridView1_Leave);
      this.dataGridView1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dataGridView1_KeyDown);
      // 
      // id
      // 
      this.id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
      this.id.DataPropertyName = "id";
      this.id.HeaderText = "Código";
      this.id.Name = "id";
      this.id.ReadOnly = true;
      this.id.Width = 65;
      // 
      // Nome
      // 
      this.Nome.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
      this.Nome.DataPropertyName = "nome";
      this.Nome.HeaderText = "Nome";
      this.Nome.Name = "Nome";
      this.Nome.ReadOnly = true;
      this.Nome.Width = 59;
      // 
      // Valor
      // 
      this.Valor.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
      this.Valor.DataPropertyName = "cpf";
      this.Valor.HeaderText = "CPF";
      this.Valor.Name = "Valor";
      this.Valor.ReadOnly = true;
      this.Valor.Width = 51;
      // 
      // Detalhes
      // 
      this.Detalhes.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
      this.Detalhes.DataPropertyName = "rg";
      this.Detalhes.HeaderText = "RG";
      this.Detalhes.Name = "Detalhes";
      this.Detalhes.ReadOnly = true;
      this.Detalhes.Width = 46;
      // 
      // Logradouro
      // 
      this.Logradouro.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
      this.Logradouro.DataPropertyName = "logradouro";
      this.Logradouro.HeaderText = "Logradouro";
      this.Logradouro.Name = "Logradouro";
      this.Logradouro.ReadOnly = true;
      this.Logradouro.Width = 87;
      // 
      // Numero
      // 
      this.Numero.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
      this.Numero.DataPropertyName = "numero";
      this.Numero.HeaderText = "Numero";
      this.Numero.Name = "Numero";
      this.Numero.ReadOnly = true;
      this.Numero.Width = 69;
      // 
      // Bairro
      // 
      this.Bairro.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
      this.Bairro.DataPropertyName = "bairro";
      this.Bairro.HeaderText = "Bairro";
      this.Bairro.Name = "Bairro";
      this.Bairro.ReadOnly = true;
      this.Bairro.Width = 60;
      // 
      // Cidade
      // 
      this.Cidade.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
      this.Cidade.DataPropertyName = "cidade";
      this.Cidade.HeaderText = "Cidade";
      this.Cidade.Name = "Cidade";
      this.Cidade.ReadOnly = true;
      this.Cidade.Width = 65;
      // 
      // Estado
      // 
      this.Estado.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
      this.Estado.DataPropertyName = "estado";
      this.Estado.HeaderText = "Estado";
      this.Estado.Name = "Estado";
      this.Estado.ReadOnly = true;
      this.Estado.Width = 65;
      // 
      // CEP
      // 
      this.CEP.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
      this.CEP.DataPropertyName = "cep";
      this.CEP.HeaderText = "CEP";
      this.CEP.Name = "CEP";
      this.CEP.ReadOnly = true;
      this.CEP.Width = 51;
      // 
      // DataNascimento
      // 
      this.DataNascimento.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
      this.DataNascimento.DataPropertyName = "datanasc";
      this.DataNascimento.HeaderText = "Data Nascimento";
      this.DataNascimento.Name = "DataNascimento";
      this.DataNascimento.ReadOnly = true;
      this.DataNascimento.Width = 104;
      // 
      // DataAdminissao
      // 
      this.DataAdminissao.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
      this.DataAdminissao.DataPropertyName = "dataadmi";
      this.DataAdminissao.HeaderText = "Data Admissão";
      this.DataAdminissao.Name = "DataAdminissao";
      this.DataAdminissao.ReadOnly = true;
      this.DataAdminissao.Width = 95;
      // 
      // Salario
      // 
      this.Salario.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
      this.Salario.DataPropertyName = "salario";
      this.Salario.HeaderText = "Salario";
      this.Salario.Name = "Salario";
      this.Salario.ReadOnly = true;
      this.Salario.Width = 64;
      // 
      // Telefone
      // 
      this.Telefone.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
      this.Telefone.DataPropertyName = "telefone";
      this.Telefone.HeaderText = "Telefone";
      this.Telefone.Name = "Telefone";
      this.Telefone.ReadOnly = true;
      this.Telefone.Width = 74;
      // 
      // Celular
      // 
      this.Celular.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
      this.Celular.DataPropertyName = "celular";
      this.Celular.HeaderText = "Celular";
      this.Celular.Name = "Celular";
      this.Celular.ReadOnly = true;
      this.Celular.Width = 65;
      // 
      // IdFuncao
      // 
      this.IdFuncao.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
      this.IdFuncao.DataPropertyName = "idFuncao";
      this.IdFuncao.HeaderText = "Id Funcao";
      this.IdFuncao.Name = "IdFuncao";
      this.IdFuncao.ReadOnly = true;
      this.IdFuncao.Width = 74;
      // 
      // groupBox1
      // 
      this.groupBox1.Controls.Add(this.txtCpf);
      this.groupBox1.Controls.Add(this.radCpf);
      this.groupBox1.Controls.Add(this.radNome);
      this.groupBox1.Controls.Add(this.btnPesquisar);
      this.groupBox1.Controls.Add(this.txtNome);
      this.groupBox1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.groupBox1.Location = new System.Drawing.Point(2, 3);
      this.groupBox1.Name = "groupBox1";
      this.groupBox1.Size = new System.Drawing.Size(840, 76);
      this.groupBox1.TabIndex = 0;
      this.groupBox1.TabStop = false;
      this.groupBox1.Text = "Pesquisa por";
      // 
      // txtCpf
      // 
      this.txtCpf.Enabled = false;
      this.txtCpf.Location = new System.Drawing.Point(73, 45);
      this.txtCpf.Mask = "000,000,000-00";
      this.txtCpf.Name = "txtCpf";
      this.txtCpf.PromptChar = ' ';
      this.txtCpf.Size = new System.Drawing.Size(142, 21);
      this.txtCpf.TabIndex = 1;
      this.txtCpf.TabStop = false;
      // 
      // radCpf
      // 
      this.radCpf.AutoSize = true;
      this.radCpf.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.radCpf.Location = new System.Drawing.Point(11, 46);
      this.radCpf.Name = "radCpf";
      this.radCpf.Size = new System.Drawing.Size(48, 17);
      this.radCpf.TabIndex = 51;
      this.radCpf.Text = "C&PF:";
      this.radCpf.UseVisualStyleBackColor = true;
      this.radCpf.CheckedChanged += new System.EventHandler(this.radCpf_CheckedChanged);
      // 
      // radNome
      // 
      this.radNome.AutoSize = true;
      this.radNome.Checked = true;
      this.radNome.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.radNome.Location = new System.Drawing.Point(11, 22);
      this.radNome.Name = "radNome";
      this.radNome.Size = new System.Drawing.Size(56, 17);
      this.radNome.TabIndex = 51;
      this.radNome.TabStop = true;
      this.radNome.Text = "&Nome:";
      this.radNome.UseVisualStyleBackColor = true;
      this.radNome.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
      // 
      // btnPesquisar
      // 
      this.btnPesquisar.Cursor = System.Windows.Forms.Cursors.Hand;
      this.btnPesquisar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
      this.btnPesquisar.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.btnPesquisar.Location = new System.Drawing.Point(753, 46);
      this.btnPesquisar.Name = "btnPesquisar";
      this.btnPesquisar.Size = new System.Drawing.Size(81, 23);
      this.btnPesquisar.TabIndex = 2;
      this.btnPesquisar.Text = "Pesquisar";
      this.btnPesquisar.UseVisualStyleBackColor = true;
      this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
      // 
      // txtNome
      // 
      this.txtNome.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
      this.txtNome.Location = new System.Drawing.Point(73, 21);
      this.txtNome.MaxLength = 45;
      this.txtNome.Name = "txtNome";
      this.txtNome.Size = new System.Drawing.Size(257, 21);
      this.txtNome.TabIndex = 0;
      // 
      // FormGridFuncionarios
      // 
      this.AcceptButton = this.btnPesquisar;
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.CancelButton = this.butSair;
      this.ClientSize = new System.Drawing.Size(844, 435);
      this.Controls.Add(this.groupBox1);
      this.Controls.Add(this.butSair);
      this.Controls.Add(this.dataGridView1);
      this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
      this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
      this.MaximizeBox = false;
      this.Name = "FormGridFuncionarios";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "Consulta - Funcionários";
      this.Load += new System.EventHandler(this.FormGridFuncionarios_Load);
      ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
      this.groupBox1.ResumeLayout(false);
      this.groupBox1.PerformLayout();
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.Button butSair;
    private System.Windows.Forms.DataGridView dataGridView1;
    private System.Windows.Forms.DataGridViewTextBoxColumn id;
    private System.Windows.Forms.DataGridViewTextBoxColumn Nome;
    private System.Windows.Forms.DataGridViewTextBoxColumn Valor;
    private System.Windows.Forms.DataGridViewTextBoxColumn Detalhes;
    private System.Windows.Forms.DataGridViewTextBoxColumn Logradouro;
    private System.Windows.Forms.DataGridViewTextBoxColumn Numero;
    private System.Windows.Forms.DataGridViewTextBoxColumn Bairro;
    private System.Windows.Forms.DataGridViewTextBoxColumn Cidade;
    private System.Windows.Forms.DataGridViewTextBoxColumn Estado;
    private System.Windows.Forms.DataGridViewTextBoxColumn CEP;
    private System.Windows.Forms.DataGridViewTextBoxColumn DataNascimento;
    private System.Windows.Forms.DataGridViewTextBoxColumn DataAdminissao;
    private System.Windows.Forms.DataGridViewTextBoxColumn Salario;
    private System.Windows.Forms.DataGridViewTextBoxColumn Telefone;
    private System.Windows.Forms.DataGridViewTextBoxColumn Celular;
    private System.Windows.Forms.DataGridViewTextBoxColumn IdFuncao;
    private System.Windows.Forms.GroupBox groupBox1;
    private System.Windows.Forms.RadioButton radCpf;
    private System.Windows.Forms.RadioButton radNome;
    private System.Windows.Forms.Button btnPesquisar;
    private System.Windows.Forms.TextBox txtNome;
    public System.Windows.Forms.MaskedTextBox txtCpf;
  }
}