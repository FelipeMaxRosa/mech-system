namespace MechSystem
{
  partial class FormGridClientePF
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormGridClientePF));
      this.dataGridView1 = new System.Windows.Forms.DataGridView();
      this.label2 = new System.Windows.Forms.Label();
      this.txtPesquisaNome = new System.Windows.Forms.TextBox();
      this.butSair = new System.Windows.Forms.Button();
      this.label1 = new System.Windows.Forms.Label();
      this.label3 = new System.Windows.Forms.Label();
      this.txtPesquisaCpf = new System.Windows.Forms.MaskedTextBox();
      this.btnPesquisar = new System.Windows.Forms.Button();
      this.IDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.NomeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.situacao = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.ApelidoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.RGIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.CPFIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.CEPIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.LogradouroIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.NumeroIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.BairroIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.CidadeIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.UFIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.DataNascimento = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.NomePai = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.NomeMae = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.EmailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.Tel1IDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.Ramal1IDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.Telefone2IDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.Ramal2DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.Obs = new System.Windows.Forms.DataGridViewTextBoxColumn();
      ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
      this.SuspendLayout();
      // 
      // dataGridView1
      // 
      this.dataGridView1.AllowUserToAddRows = false;
      this.dataGridView1.AllowUserToDeleteRows = false;
      this.dataGridView1.AllowUserToOrderColumns = true;
      this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IDDataGridViewTextBoxColumn,
            this.NomeDataGridViewTextBoxColumn,
            this.situacao,
            this.ApelidoDataGridViewTextBoxColumn,
            this.RGIDDataGridViewTextBoxColumn,
            this.CPFIDDataGridViewTextBoxColumn,
            this.CEPIDDataGridViewTextBoxColumn,
            this.LogradouroIDDataGridViewTextBoxColumn,
            this.NumeroIDDataGridViewTextBoxColumn,
            this.BairroIDDataGridViewTextBoxColumn,
            this.CidadeIDDataGridViewTextBoxColumn,
            this.UFIDDataGridViewTextBoxColumn,
            this.DataNascimento,
            this.NomePai,
            this.NomeMae,
            this.EmailDataGridViewTextBoxColumn,
            this.Tel1IDDataGridViewTextBoxColumn,
            this.Ramal1IDDataGridViewTextBoxColumn,
            this.Telefone2IDDataGridViewTextBoxColumn,
            this.Ramal2DataGridViewTextBoxColumn,
            this.Obs});
      this.dataGridView1.Location = new System.Drawing.Point(3, 2);
      this.dataGridView1.MultiSelect = false;
      this.dataGridView1.Name = "dataGridView1";
      this.dataGridView1.ReadOnly = true;
      this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
      this.dataGridView1.Size = new System.Drawing.Size(912, 508);
      this.dataGridView1.TabIndex = 2;
      this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
      this.dataGridView1.Leave += new System.EventHandler(this.dataGridView1_Leave);
      this.dataGridView1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dataGridView1_KeyDown);
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
      this.label2.Location = new System.Drawing.Point(0, 513);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(102, 23);
      this.label2.TabIndex = 12;
      this.label2.Text = "PESQUISA";
      // 
      // txtPesquisaNome
      // 
      this.txtPesquisaNome.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
      this.txtPesquisaNome.Location = new System.Drawing.Point(47, 542);
      this.txtPesquisaNome.Name = "txtPesquisaNome";
      this.txtPesquisaNome.Size = new System.Drawing.Size(364, 21);
      this.txtPesquisaNome.TabIndex = 0;
      // 
      // butSair
      // 
      this.butSair.Cursor = System.Windows.Forms.Cursors.Hand;
      this.butSair.DialogResult = System.Windows.Forms.DialogResult.Cancel;
      this.butSair.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.butSair.Location = new System.Drawing.Point(825, 540);
      this.butSair.Name = "butSair";
      this.butSair.Size = new System.Drawing.Size(81, 23);
      this.butSair.TabIndex = 4;
      this.butSair.Text = "Sair";
      this.butSair.UseVisualStyleBackColor = true;
      this.butSair.Click += new System.EventHandler(this.button1_Click);
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
      this.label1.Location = new System.Drawing.Point(1, 545);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(42, 13);
      this.label1.TabIndex = 13;
      this.label1.Text = "Nome:";
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label3.ForeColor = System.Drawing.SystemColors.ControlText;
      this.label3.Location = new System.Drawing.Point(441, 545);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(30, 13);
      this.label3.TabIndex = 15;
      this.label3.Text = "CPF:";
      // 
      // txtPesquisaCpf
      // 
      this.txtPesquisaCpf.Location = new System.Drawing.Point(477, 542);
      this.txtPesquisaCpf.Mask = "000,000,000-00";
      this.txtPesquisaCpf.Name = "txtPesquisaCpf";
      this.txtPesquisaCpf.PromptChar = ' ';
      this.txtPesquisaCpf.Size = new System.Drawing.Size(156, 21);
      this.txtPesquisaCpf.TabIndex = 1;
      this.txtPesquisaCpf.TextChanged += new System.EventHandler(this.maskedTextBox1_TextChanged);
      // 
      // btnPesquisar
      // 
      this.btnPesquisar.Cursor = System.Windows.Forms.Cursors.Hand;
      this.btnPesquisar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
      this.btnPesquisar.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.btnPesquisar.Location = new System.Drawing.Point(723, 540);
      this.btnPesquisar.Name = "btnPesquisar";
      this.btnPesquisar.Size = new System.Drawing.Size(81, 23);
      this.btnPesquisar.TabIndex = 3;
      this.btnPesquisar.Text = "Pesquisar";
      this.btnPesquisar.UseVisualStyleBackColor = true;
      this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
      // 
      // IDDataGridViewTextBoxColumn
      // 
      this.IDDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
      this.IDDataGridViewTextBoxColumn.DataPropertyName = "id";
      this.IDDataGridViewTextBoxColumn.HeaderText = "Código";
      this.IDDataGridViewTextBoxColumn.Name = "IDDataGridViewTextBoxColumn";
      this.IDDataGridViewTextBoxColumn.ReadOnly = true;
      this.IDDataGridViewTextBoxColumn.Width = 65;
      // 
      // NomeDataGridViewTextBoxColumn
      // 
      this.NomeDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
      this.NomeDataGridViewTextBoxColumn.DataPropertyName = "nome";
      this.NomeDataGridViewTextBoxColumn.HeaderText = "Nome Completo";
      this.NomeDataGridViewTextBoxColumn.Name = "NomeDataGridViewTextBoxColumn";
      this.NomeDataGridViewTextBoxColumn.ReadOnly = true;
      this.NomeDataGridViewTextBoxColumn.Width = 98;
      // 
      // situacao
      // 
      this.situacao.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
      this.situacao.DataPropertyName = "c_status";
      this.situacao.HeaderText = "Situação";
      this.situacao.Name = "situacao";
      this.situacao.ReadOnly = true;
      this.situacao.Width = 73;
      // 
      // ApelidoDataGridViewTextBoxColumn
      // 
      this.ApelidoDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
      this.ApelidoDataGridViewTextBoxColumn.DataPropertyName = "apelido";
      this.ApelidoDataGridViewTextBoxColumn.HeaderText = "Apelido";
      this.ApelidoDataGridViewTextBoxColumn.Name = "ApelidoDataGridViewTextBoxColumn";
      this.ApelidoDataGridViewTextBoxColumn.ReadOnly = true;
      this.ApelidoDataGridViewTextBoxColumn.Width = 67;
      // 
      // RGIDDataGridViewTextBoxColumn
      // 
      this.RGIDDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
      this.RGIDDataGridViewTextBoxColumn.DataPropertyName = "rg";
      this.RGIDDataGridViewTextBoxColumn.HeaderText = "RG";
      this.RGIDDataGridViewTextBoxColumn.Name = "RGIDDataGridViewTextBoxColumn";
      this.RGIDDataGridViewTextBoxColumn.ReadOnly = true;
      this.RGIDDataGridViewTextBoxColumn.Width = 46;
      // 
      // CPFIDDataGridViewTextBoxColumn
      // 
      this.CPFIDDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
      this.CPFIDDataGridViewTextBoxColumn.DataPropertyName = "cpf";
      this.CPFIDDataGridViewTextBoxColumn.HeaderText = "CPF";
      this.CPFIDDataGridViewTextBoxColumn.Name = "CPFIDDataGridViewTextBoxColumn";
      this.CPFIDDataGridViewTextBoxColumn.ReadOnly = true;
      this.CPFIDDataGridViewTextBoxColumn.Width = 51;
      // 
      // CEPIDDataGridViewTextBoxColumn
      // 
      this.CEPIDDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
      this.CEPIDDataGridViewTextBoxColumn.DataPropertyName = "cep";
      this.CEPIDDataGridViewTextBoxColumn.HeaderText = "CEP";
      this.CEPIDDataGridViewTextBoxColumn.Name = "CEPIDDataGridViewTextBoxColumn";
      this.CEPIDDataGridViewTextBoxColumn.ReadOnly = true;
      this.CEPIDDataGridViewTextBoxColumn.Width = 51;
      // 
      // LogradouroIDDataGridViewTextBoxColumn
      // 
      this.LogradouroIDDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
      this.LogradouroIDDataGridViewTextBoxColumn.DataPropertyName = "logradouro";
      this.LogradouroIDDataGridViewTextBoxColumn.HeaderText = "Endereço";
      this.LogradouroIDDataGridViewTextBoxColumn.Name = "LogradouroIDDataGridViewTextBoxColumn";
      this.LogradouroIDDataGridViewTextBoxColumn.ReadOnly = true;
      this.LogradouroIDDataGridViewTextBoxColumn.Width = 77;
      // 
      // NumeroIDDataGridViewTextBoxColumn
      // 
      this.NumeroIDDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
      this.NumeroIDDataGridViewTextBoxColumn.DataPropertyName = "numero";
      this.NumeroIDDataGridViewTextBoxColumn.HeaderText = "Número";
      this.NumeroIDDataGridViewTextBoxColumn.Name = "NumeroIDDataGridViewTextBoxColumn";
      this.NumeroIDDataGridViewTextBoxColumn.ReadOnly = true;
      this.NumeroIDDataGridViewTextBoxColumn.Width = 69;
      // 
      // BairroIDDataGridViewTextBoxColumn
      // 
      this.BairroIDDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
      this.BairroIDDataGridViewTextBoxColumn.DataPropertyName = "bairro";
      this.BairroIDDataGridViewTextBoxColumn.HeaderText = "Bairro";
      this.BairroIDDataGridViewTextBoxColumn.Name = "BairroIDDataGridViewTextBoxColumn";
      this.BairroIDDataGridViewTextBoxColumn.ReadOnly = true;
      this.BairroIDDataGridViewTextBoxColumn.Width = 60;
      // 
      // CidadeIDDataGridViewTextBoxColumn
      // 
      this.CidadeIDDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
      this.CidadeIDDataGridViewTextBoxColumn.DataPropertyName = "cidade";
      this.CidadeIDDataGridViewTextBoxColumn.HeaderText = "Cidade";
      this.CidadeIDDataGridViewTextBoxColumn.Name = "CidadeIDDataGridViewTextBoxColumn";
      this.CidadeIDDataGridViewTextBoxColumn.ReadOnly = true;
      this.CidadeIDDataGridViewTextBoxColumn.Width = 65;
      // 
      // UFIDDataGridViewTextBoxColumn
      // 
      this.UFIDDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
      this.UFIDDataGridViewTextBoxColumn.DataPropertyName = "estado";
      this.UFIDDataGridViewTextBoxColumn.HeaderText = "UF";
      this.UFIDDataGridViewTextBoxColumn.Name = "UFIDDataGridViewTextBoxColumn";
      this.UFIDDataGridViewTextBoxColumn.ReadOnly = true;
      this.UFIDDataGridViewTextBoxColumn.Width = 45;
      // 
      // DataNascimento
      // 
      this.DataNascimento.DataPropertyName = "datanasc";
      this.DataNascimento.HeaderText = "Data Nascimento";
      this.DataNascimento.Name = "DataNascimento";
      this.DataNascimento.ReadOnly = true;
      this.DataNascimento.Width = 120;
      // 
      // NomePai
      // 
      this.NomePai.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
      this.NomePai.DataPropertyName = "nomepai";
      this.NomePai.HeaderText = "Nome Pai";
      this.NomePai.Name = "NomePai";
      this.NomePai.ReadOnly = true;
      this.NomePai.Width = 70;
      // 
      // NomeMae
      // 
      this.NomeMae.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
      this.NomeMae.DataPropertyName = "nomemae";
      this.NomeMae.HeaderText = "Nome Mãe";
      this.NomeMae.Name = "NomeMae";
      this.NomeMae.ReadOnly = true;
      this.NomeMae.Width = 76;
      // 
      // EmailDataGridViewTextBoxColumn
      // 
      this.EmailDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
      this.EmailDataGridViewTextBoxColumn.DataPropertyName = "email";
      this.EmailDataGridViewTextBoxColumn.HeaderText = "E-mail";
      this.EmailDataGridViewTextBoxColumn.Name = "EmailDataGridViewTextBoxColumn";
      this.EmailDataGridViewTextBoxColumn.ReadOnly = true;
      this.EmailDataGridViewTextBoxColumn.Width = 60;
      // 
      // Tel1IDDataGridViewTextBoxColumn
      // 
      this.Tel1IDDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
      this.Tel1IDDataGridViewTextBoxColumn.DataPropertyName = "telefone1";
      this.Tel1IDDataGridViewTextBoxColumn.HeaderText = "Telefone";
      this.Tel1IDDataGridViewTextBoxColumn.Name = "Tel1IDDataGridViewTextBoxColumn";
      this.Tel1IDDataGridViewTextBoxColumn.ReadOnly = true;
      this.Tel1IDDataGridViewTextBoxColumn.Width = 74;
      // 
      // Ramal1IDDataGridViewTextBoxColumn
      // 
      this.Ramal1IDDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
      this.Ramal1IDDataGridViewTextBoxColumn.DataPropertyName = "ramal1";
      this.Ramal1IDDataGridViewTextBoxColumn.HeaderText = "Ramal";
      this.Ramal1IDDataGridViewTextBoxColumn.Name = "Ramal1IDDataGridViewTextBoxColumn";
      this.Ramal1IDDataGridViewTextBoxColumn.ReadOnly = true;
      this.Ramal1IDDataGridViewTextBoxColumn.Width = 61;
      // 
      // Telefone2IDDataGridViewTextBoxColumn
      // 
      this.Telefone2IDDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
      this.Telefone2IDDataGridViewTextBoxColumn.DataPropertyName = "telefone2";
      this.Telefone2IDDataGridViewTextBoxColumn.HeaderText = "Telefone";
      this.Telefone2IDDataGridViewTextBoxColumn.Name = "Telefone2IDDataGridViewTextBoxColumn";
      this.Telefone2IDDataGridViewTextBoxColumn.ReadOnly = true;
      this.Telefone2IDDataGridViewTextBoxColumn.Width = 74;
      // 
      // Ramal2DataGridViewTextBoxColumn
      // 
      this.Ramal2DataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
      this.Ramal2DataGridViewTextBoxColumn.DataPropertyName = "ramal2";
      this.Ramal2DataGridViewTextBoxColumn.HeaderText = "Ramal";
      this.Ramal2DataGridViewTextBoxColumn.Name = "Ramal2DataGridViewTextBoxColumn";
      this.Ramal2DataGridViewTextBoxColumn.ReadOnly = true;
      this.Ramal2DataGridViewTextBoxColumn.Width = 61;
      // 
      // Obs
      // 
      this.Obs.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
      this.Obs.DataPropertyName = "obs";
      this.Obs.HeaderText = "Observação";
      this.Obs.Name = "Obs";
      this.Obs.ReadOnly = true;
      this.Obs.Width = 90;
      // 
      // FormGridClientePF
      // 
      this.AcceptButton = this.btnPesquisar;
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.CancelButton = this.butSair;
      this.ClientSize = new System.Drawing.Size(918, 569);
      this.Controls.Add(this.btnPesquisar);
      this.Controls.Add(this.txtPesquisaCpf);
      this.Controls.Add(this.label3);
      this.Controls.Add(this.label1);
      this.Controls.Add(this.butSair);
      this.Controls.Add(this.label2);
      this.Controls.Add(this.txtPesquisaNome);
      this.Controls.Add(this.dataGridView1);
      this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
      this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
      this.MaximizeBox = false;
      this.Name = "FormGridClientePF";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "Consulta - Pessoa Física";
      this.Load += new System.EventHandler(this.FormGridClientes_Load);
      ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.DataGridView dataGridView1;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.TextBox txtPesquisaNome;
    private System.Windows.Forms.Button butSair;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.MaskedTextBox txtPesquisaCpf;
    private System.Windows.Forms.Button btnPesquisar;
    private System.Windows.Forms.DataGridViewTextBoxColumn IDDataGridViewTextBoxColumn;
    private System.Windows.Forms.DataGridViewTextBoxColumn NomeDataGridViewTextBoxColumn;
    private System.Windows.Forms.DataGridViewTextBoxColumn situacao;
    private System.Windows.Forms.DataGridViewTextBoxColumn ApelidoDataGridViewTextBoxColumn;
    private System.Windows.Forms.DataGridViewTextBoxColumn RGIDDataGridViewTextBoxColumn;
    private System.Windows.Forms.DataGridViewTextBoxColumn CPFIDDataGridViewTextBoxColumn;
    private System.Windows.Forms.DataGridViewTextBoxColumn CEPIDDataGridViewTextBoxColumn;
    private System.Windows.Forms.DataGridViewTextBoxColumn LogradouroIDDataGridViewTextBoxColumn;
    private System.Windows.Forms.DataGridViewTextBoxColumn NumeroIDDataGridViewTextBoxColumn;
    private System.Windows.Forms.DataGridViewTextBoxColumn BairroIDDataGridViewTextBoxColumn;
    private System.Windows.Forms.DataGridViewTextBoxColumn CidadeIDDataGridViewTextBoxColumn;
    private System.Windows.Forms.DataGridViewTextBoxColumn UFIDDataGridViewTextBoxColumn;
    private System.Windows.Forms.DataGridViewTextBoxColumn DataNascimento;
    private System.Windows.Forms.DataGridViewTextBoxColumn NomePai;
    private System.Windows.Forms.DataGridViewTextBoxColumn NomeMae;
    private System.Windows.Forms.DataGridViewTextBoxColumn EmailDataGridViewTextBoxColumn;
    private System.Windows.Forms.DataGridViewTextBoxColumn Tel1IDDataGridViewTextBoxColumn;
    private System.Windows.Forms.DataGridViewTextBoxColumn Ramal1IDDataGridViewTextBoxColumn;
    private System.Windows.Forms.DataGridViewTextBoxColumn Telefone2IDDataGridViewTextBoxColumn;
    private System.Windows.Forms.DataGridViewTextBoxColumn Ramal2DataGridViewTextBoxColumn;
    private System.Windows.Forms.DataGridViewTextBoxColumn Obs;
  }
}