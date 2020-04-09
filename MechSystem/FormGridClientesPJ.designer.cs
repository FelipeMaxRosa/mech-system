namespace MechSystem
{
  partial class FormGridClientesPJ
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormGridClientesPJ));
      this.txtPesquisa = new System.Windows.Forms.TextBox();
      this.dataGridView1 = new System.Windows.Forms.DataGridView();
      this.butSair = new System.Windows.Forms.Button();
      this.txtPesquisaCnpj = new System.Windows.Forms.MaskedTextBox();
      this.label3 = new System.Windows.Forms.Label();
      this.label1 = new System.Windows.Forms.Label();
      this.label4 = new System.Windows.Forms.Label();
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
      this.EmailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.Tel1IDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.Ramal1IDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.Telefone2IDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.Ramal2DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.Obs = new System.Windows.Forms.DataGridViewTextBoxColumn();
      ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
      this.SuspendLayout();
      // 
      // txtPesquisa
      // 
      this.txtPesquisa.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
      this.txtPesquisa.Location = new System.Drawing.Point(87, 542);
      this.txtPesquisa.Name = "txtPesquisa";
      this.txtPesquisa.Size = new System.Drawing.Size(375, 21);
      this.txtPesquisa.TabIndex = 0;
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
      // butSair
      // 
      this.butSair.Cursor = System.Windows.Forms.Cursors.Hand;
      this.butSair.DialogResult = System.Windows.Forms.DialogResult.Cancel;
      this.butSair.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.butSair.Location = new System.Drawing.Point(825, 540);
      this.butSair.Name = "butSair";
      this.butSair.Size = new System.Drawing.Size(81, 23);
      this.butSair.TabIndex = 3;
      this.butSair.Text = "Sair";
      this.butSair.UseVisualStyleBackColor = true;
      this.butSair.Click += new System.EventHandler(this.butSair_Click);
      // 
      // txtPesquisaCnpj
      // 
      this.txtPesquisaCnpj.Location = new System.Drawing.Point(530, 542);
      this.txtPesquisaCnpj.Mask = "00,000,000/0000-00";
      this.txtPesquisaCnpj.Name = "txtPesquisaCnpj";
      this.txtPesquisaCnpj.PromptChar = ' ';
      this.txtPesquisaCnpj.Size = new System.Drawing.Size(156, 21);
      this.txtPesquisaCnpj.TabIndex = 1;
      this.txtPesquisaCnpj.TextChanged += new System.EventHandler(this.txtPesquisaCnpj_TextChanged);
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label3.ForeColor = System.Drawing.SystemColors.ControlText;
      this.label3.Location = new System.Drawing.Point(488, 545);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(37, 13);
      this.label3.TabIndex = 21;
      this.label3.Text = "CNPJ:";
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
      this.label1.Location = new System.Drawing.Point(1, 545);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(81, 13);
      this.label1.TabIndex = 20;
      this.label1.Text = "Razão Social:";
      // 
      // label4
      // 
      this.label4.AutoSize = true;
      this.label4.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label4.ForeColor = System.Drawing.SystemColors.ControlText;
      this.label4.Location = new System.Drawing.Point(0, 513);
      this.label4.Name = "label4";
      this.label4.Size = new System.Drawing.Size(102, 23);
      this.label4.TabIndex = 19;
      this.label4.Text = "PESQUISA";
      // 
      // btnPesquisar
      // 
      this.btnPesquisar.Cursor = System.Windows.Forms.Cursors.Hand;
      this.btnPesquisar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
      this.btnPesquisar.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.btnPesquisar.Location = new System.Drawing.Point(726, 540);
      this.btnPesquisar.Name = "btnPesquisar";
      this.btnPesquisar.Size = new System.Drawing.Size(81, 23);
      this.btnPesquisar.TabIndex = 22;
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
      this.NomeDataGridViewTextBoxColumn.DataPropertyName = "razaosocial";
      this.NomeDataGridViewTextBoxColumn.HeaderText = "Razão Social";
      this.NomeDataGridViewTextBoxColumn.Name = "NomeDataGridViewTextBoxColumn";
      this.NomeDataGridViewTextBoxColumn.ReadOnly = true;
      this.NomeDataGridViewTextBoxColumn.Width = 92;
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
      this.ApelidoDataGridViewTextBoxColumn.DataPropertyName = "nomefantasia";
      this.ApelidoDataGridViewTextBoxColumn.HeaderText = "Nome Fantasia";
      this.ApelidoDataGridViewTextBoxColumn.Name = "ApelidoDataGridViewTextBoxColumn";
      this.ApelidoDataGridViewTextBoxColumn.ReadOnly = true;
      this.ApelidoDataGridViewTextBoxColumn.Width = 95;
      // 
      // RGIDDataGridViewTextBoxColumn
      // 
      this.RGIDDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
      this.RGIDDataGridViewTextBoxColumn.DataPropertyName = "ie";
      this.RGIDDataGridViewTextBoxColumn.HeaderText = "IE";
      this.RGIDDataGridViewTextBoxColumn.Name = "RGIDDataGridViewTextBoxColumn";
      this.RGIDDataGridViewTextBoxColumn.ReadOnly = true;
      this.RGIDDataGridViewTextBoxColumn.Width = 42;
      // 
      // CPFIDDataGridViewTextBoxColumn
      // 
      this.CPFIDDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
      this.CPFIDDataGridViewTextBoxColumn.DataPropertyName = "cnpj";
      this.CPFIDDataGridViewTextBoxColumn.HeaderText = "CNPJ";
      this.CPFIDDataGridViewTextBoxColumn.Name = "CPFIDDataGridViewTextBoxColumn";
      this.CPFIDDataGridViewTextBoxColumn.ReadOnly = true;
      this.CPFIDDataGridViewTextBoxColumn.Width = 57;
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
      // FormGridClientesPJ
      // 
      this.AcceptButton = this.btnPesquisar;
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.CancelButton = this.butSair;
      this.ClientSize = new System.Drawing.Size(918, 569);
      this.Controls.Add(this.btnPesquisar);
      this.Controls.Add(this.txtPesquisaCnpj);
      this.Controls.Add(this.label3);
      this.Controls.Add(this.label1);
      this.Controls.Add(this.label4);
      this.Controls.Add(this.butSair);
      this.Controls.Add(this.txtPesquisa);
      this.Controls.Add(this.dataGridView1);
      this.Font = new System.Drawing.Font("Tahoma", 8.25F);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
      this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
      this.MaximizeBox = false;
      this.Name = "FormGridClientesPJ";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "Consulta - Pessoa Jurídica";
      this.Load += new System.EventHandler(this.FormGridClientesPJ_Load);
      ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.TextBox txtPesquisa;
    private System.Windows.Forms.DataGridView dataGridView1;
    private System.Windows.Forms.Button butSair;
    private System.Windows.Forms.MaskedTextBox txtPesquisaCnpj;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Label label4;
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
    private System.Windows.Forms.DataGridViewTextBoxColumn EmailDataGridViewTextBoxColumn;
    private System.Windows.Forms.DataGridViewTextBoxColumn Tel1IDDataGridViewTextBoxColumn;
    private System.Windows.Forms.DataGridViewTextBoxColumn Ramal1IDDataGridViewTextBoxColumn;
    private System.Windows.Forms.DataGridViewTextBoxColumn Telefone2IDDataGridViewTextBoxColumn;
    private System.Windows.Forms.DataGridViewTextBoxColumn Ramal2DataGridViewTextBoxColumn;
    private System.Windows.Forms.DataGridViewTextBoxColumn Obs;
  }
}