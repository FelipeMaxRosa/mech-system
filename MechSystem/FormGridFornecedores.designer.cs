namespace MechSystem
{
  partial class FormGridFornecedores
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormGridFornecedores));
      this.dataGridView1 = new System.Windows.Forms.DataGridView();
      this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.razaosocial = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.nomefantasia = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.cnpj = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.ie = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.cep = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.logradouro = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.numero = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.bairro = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.cidade = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.telefone1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.ramal1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.telefone2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.ramal2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.email = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.obs = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.butSair = new System.Windows.Forms.Button();
      this.groupBox1 = new System.Windows.Forms.GroupBox();
      this.radCnpj = new System.Windows.Forms.RadioButton();
      this.radNomeFantasia = new System.Windows.Forms.RadioButton();
      this.radRazaoSocial = new System.Windows.Forms.RadioButton();
      this.btnPesquisar = new System.Windows.Forms.Button();
      this.txtNomeFantasia = new System.Windows.Forms.TextBox();
      this.txtPesquisaCnpj = new System.Windows.Forms.MaskedTextBox();
      this.txtPesquisa = new System.Windows.Forms.TextBox();
      ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
      this.groupBox1.SuspendLayout();
      this.SuspendLayout();
      // 
      // dataGridView1
      // 
      this.dataGridView1.AllowUserToAddRows = false;
      this.dataGridView1.AllowUserToDeleteRows = false;
      this.dataGridView1.AllowUserToOrderColumns = true;
      this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.razaosocial,
            this.nomefantasia,
            this.cnpj,
            this.ie,
            this.cep,
            this.logradouro,
            this.numero,
            this.bairro,
            this.cidade,
            this.estado,
            this.telefone1,
            this.ramal1,
            this.telefone2,
            this.ramal2,
            this.email,
            this.obs});
      this.dataGridView1.Location = new System.Drawing.Point(3, 86);
      this.dataGridView1.MultiSelect = false;
      this.dataGridView1.Name = "dataGridView1";
      this.dataGridView1.ReadOnly = true;
      this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
      this.dataGridView1.Size = new System.Drawing.Size(912, 450);
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
      // razaosocial
      // 
      this.razaosocial.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
      this.razaosocial.DataPropertyName = "razaosocial";
      this.razaosocial.HeaderText = "Razão Social";
      this.razaosocial.Name = "razaosocial";
      this.razaosocial.ReadOnly = true;
      this.razaosocial.Width = 85;
      // 
      // nomefantasia
      // 
      this.nomefantasia.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
      this.nomefantasia.DataPropertyName = "nomefantasia";
      this.nomefantasia.HeaderText = "Nome Fantasia";
      this.nomefantasia.Name = "nomefantasia";
      this.nomefantasia.ReadOnly = true;
      this.nomefantasia.Width = 95;
      // 
      // cnpj
      // 
      this.cnpj.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
      this.cnpj.DataPropertyName = "cnpj";
      this.cnpj.HeaderText = "CNPJ";
      this.cnpj.Name = "cnpj";
      this.cnpj.ReadOnly = true;
      this.cnpj.Width = 57;
      // 
      // ie
      // 
      this.ie.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
      this.ie.DataPropertyName = "ie";
      this.ie.HeaderText = "IE";
      this.ie.Name = "ie";
      this.ie.ReadOnly = true;
      this.ie.Width = 42;
      // 
      // cep
      // 
      this.cep.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
      this.cep.DataPropertyName = "cep";
      this.cep.HeaderText = "CEP";
      this.cep.Name = "cep";
      this.cep.ReadOnly = true;
      this.cep.Width = 51;
      // 
      // logradouro
      // 
      this.logradouro.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
      this.logradouro.DataPropertyName = "logradouro";
      this.logradouro.HeaderText = "Endereço";
      this.logradouro.Name = "logradouro";
      this.logradouro.ReadOnly = true;
      this.logradouro.Width = 77;
      // 
      // numero
      // 
      this.numero.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
      this.numero.DataPropertyName = "numero";
      this.numero.HeaderText = "Número";
      this.numero.Name = "numero";
      this.numero.ReadOnly = true;
      this.numero.Width = 69;
      // 
      // bairro
      // 
      this.bairro.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
      this.bairro.DataPropertyName = "bairro";
      this.bairro.HeaderText = "Bairro";
      this.bairro.Name = "bairro";
      this.bairro.ReadOnly = true;
      this.bairro.Width = 60;
      // 
      // cidade
      // 
      this.cidade.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
      this.cidade.DataPropertyName = "cidade";
      this.cidade.HeaderText = "Cidade";
      this.cidade.Name = "cidade";
      this.cidade.ReadOnly = true;
      this.cidade.Width = 65;
      // 
      // estado
      // 
      this.estado.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
      this.estado.DataPropertyName = "estado";
      this.estado.HeaderText = "UF";
      this.estado.Name = "estado";
      this.estado.ReadOnly = true;
      this.estado.Width = 45;
      // 
      // telefone1
      // 
      this.telefone1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
      this.telefone1.DataPropertyName = "telefone1";
      this.telefone1.HeaderText = "Telefone";
      this.telefone1.Name = "telefone1";
      this.telefone1.ReadOnly = true;
      this.telefone1.Width = 74;
      // 
      // ramal1
      // 
      this.ramal1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
      this.ramal1.DataPropertyName = "ramal1";
      this.ramal1.HeaderText = "Ramal";
      this.ramal1.Name = "ramal1";
      this.ramal1.ReadOnly = true;
      this.ramal1.Width = 61;
      // 
      // telefone2
      // 
      this.telefone2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
      this.telefone2.DataPropertyName = "telefone2";
      this.telefone2.HeaderText = "Telefone";
      this.telefone2.Name = "telefone2";
      this.telefone2.ReadOnly = true;
      this.telefone2.Width = 74;
      // 
      // ramal2
      // 
      this.ramal2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
      this.ramal2.DataPropertyName = "ramal2";
      this.ramal2.HeaderText = "Ramal";
      this.ramal2.Name = "ramal2";
      this.ramal2.ReadOnly = true;
      this.ramal2.Width = 61;
      // 
      // email
      // 
      this.email.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
      this.email.DataPropertyName = "email";
      this.email.HeaderText = "E-mail";
      this.email.Name = "email";
      this.email.ReadOnly = true;
      this.email.Width = 60;
      // 
      // obs
      // 
      this.obs.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
      this.obs.DataPropertyName = "obs";
      this.obs.HeaderText = "Observação";
      this.obs.Name = "obs";
      this.obs.ReadOnly = true;
      this.obs.Width = 90;
      // 
      // butSair
      // 
      this.butSair.Cursor = System.Windows.Forms.Cursors.Hand;
      this.butSair.DialogResult = System.Windows.Forms.DialogResult.Cancel;
      this.butSair.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.butSair.Location = new System.Drawing.Point(834, 542);
      this.butSair.Name = "butSair";
      this.butSair.Size = new System.Drawing.Size(81, 23);
      this.butSair.TabIndex = 2;
      this.butSair.Text = "Sair";
      this.butSair.UseVisualStyleBackColor = true;
      this.butSair.Click += new System.EventHandler(this.butSair_Click);
      // 
      // groupBox1
      // 
      this.groupBox1.Controls.Add(this.radCnpj);
      this.groupBox1.Controls.Add(this.radNomeFantasia);
      this.groupBox1.Controls.Add(this.radRazaoSocial);
      this.groupBox1.Controls.Add(this.btnPesquisar);
      this.groupBox1.Controls.Add(this.txtNomeFantasia);
      this.groupBox1.Controls.Add(this.txtPesquisaCnpj);
      this.groupBox1.Controls.Add(this.txtPesquisa);
      this.groupBox1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.groupBox1.Location = new System.Drawing.Point(3, 4);
      this.groupBox1.Name = "groupBox1";
      this.groupBox1.Size = new System.Drawing.Size(912, 76);
      this.groupBox1.TabIndex = 0;
      this.groupBox1.TabStop = false;
      this.groupBox1.Text = "Pesquisa por";
      // 
      // radCnpj
      // 
      this.radCnpj.AutoSize = true;
      this.radCnpj.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.radCnpj.Location = new System.Drawing.Point(414, 20);
      this.radCnpj.Name = "radCnpj";
      this.radCnpj.Size = new System.Drawing.Size(54, 17);
      this.radCnpj.TabIndex = 2;
      this.radCnpj.Text = "CN&PJ:";
      this.radCnpj.UseVisualStyleBackColor = true;
      this.radCnpj.CheckedChanged += new System.EventHandler(this.radCnpj_CheckedChanged);
      // 
      // radNomeFantasia
      // 
      this.radNomeFantasia.AutoSize = true;
      this.radNomeFantasia.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.radNomeFantasia.Location = new System.Drawing.Point(9, 44);
      this.radNomeFantasia.Name = "radNomeFantasia";
      this.radNomeFantasia.Size = new System.Drawing.Size(84, 17);
      this.radNomeFantasia.TabIndex = 0;
      this.radNomeFantasia.Text = "N. &Fantasia:";
      this.radNomeFantasia.UseVisualStyleBackColor = true;
      this.radNomeFantasia.CheckedChanged += new System.EventHandler(this.radNomeFantasia_CheckedChanged);
      // 
      // radRazaoSocial
      // 
      this.radRazaoSocial.AutoSize = true;
      this.radRazaoSocial.Checked = true;
      this.radRazaoSocial.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.radRazaoSocial.Location = new System.Drawing.Point(9, 20);
      this.radRazaoSocial.Name = "radRazaoSocial";
      this.radRazaoSocial.Size = new System.Drawing.Size(89, 17);
      this.radRazaoSocial.TabIndex = 0;
      this.radRazaoSocial.TabStop = true;
      this.radRazaoSocial.Text = "&Razão Social:";
      this.radRazaoSocial.UseVisualStyleBackColor = true;
      this.radRazaoSocial.CheckedChanged += new System.EventHandler(this.radRazaoSocial_CheckedChanged);
      // 
      // btnPesquisar
      // 
      this.btnPesquisar.Cursor = System.Windows.Forms.Cursors.Hand;
      this.btnPesquisar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
      this.btnPesquisar.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.btnPesquisar.Location = new System.Drawing.Point(823, 44);
      this.btnPesquisar.Name = "btnPesquisar";
      this.btnPesquisar.Size = new System.Drawing.Size(81, 23);
      this.btnPesquisar.TabIndex = 2;
      this.btnPesquisar.Text = "Pesquisar";
      this.btnPesquisar.UseVisualStyleBackColor = true;
      this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
      // 
      // txtNomeFantasia
      // 
      this.txtNomeFantasia.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
      this.txtNomeFantasia.Enabled = false;
      this.txtNomeFantasia.Location = new System.Drawing.Point(101, 43);
      this.txtNomeFantasia.Name = "txtNomeFantasia";
      this.txtNomeFantasia.Size = new System.Drawing.Size(298, 21);
      this.txtNomeFantasia.TabIndex = 0;
      // 
      // txtPesquisaCnpj
      // 
      this.txtPesquisaCnpj.Enabled = false;
      this.txtPesquisaCnpj.Location = new System.Drawing.Point(471, 19);
      this.txtPesquisaCnpj.Mask = "00,000,000/0000-00";
      this.txtPesquisaCnpj.Name = "txtPesquisaCnpj";
      this.txtPesquisaCnpj.PromptChar = ' ';
      this.txtPesquisaCnpj.Size = new System.Drawing.Size(156, 21);
      this.txtPesquisaCnpj.TabIndex = 1;
      // 
      // txtPesquisa
      // 
      this.txtPesquisa.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
      this.txtPesquisa.Location = new System.Drawing.Point(101, 19);
      this.txtPesquisa.Name = "txtPesquisa";
      this.txtPesquisa.Size = new System.Drawing.Size(298, 21);
      this.txtPesquisa.TabIndex = 0;
      // 
      // FormGridFornecedores
      // 
      this.AcceptButton = this.btnPesquisar;
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.CancelButton = this.butSair;
      this.ClientSize = new System.Drawing.Size(918, 569);
      this.Controls.Add(this.groupBox1);
      this.Controls.Add(this.butSair);
      this.Controls.Add(this.dataGridView1);
      this.Font = new System.Drawing.Font("Tahoma", 8.25F);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
      this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
      this.KeyPreview = true;
      this.MaximizeBox = false;
      this.Name = "FormGridFornecedores";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "Consulta - Fornecedores";
      this.Load += new System.EventHandler(this.FormGridFornecedores_Load);
      ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
      this.groupBox1.ResumeLayout(false);
      this.groupBox1.PerformLayout();
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.DataGridView dataGridView1;
    private System.Windows.Forms.Button butSair;
    private System.Windows.Forms.DataGridViewTextBoxColumn id;
    private System.Windows.Forms.DataGridViewTextBoxColumn razaosocial;
    private System.Windows.Forms.DataGridViewTextBoxColumn nomefantasia;
    private System.Windows.Forms.DataGridViewTextBoxColumn cnpj;
    private System.Windows.Forms.DataGridViewTextBoxColumn ie;
    private System.Windows.Forms.DataGridViewTextBoxColumn cep;
    private System.Windows.Forms.DataGridViewTextBoxColumn logradouro;
    private System.Windows.Forms.DataGridViewTextBoxColumn numero;
    private System.Windows.Forms.DataGridViewTextBoxColumn bairro;
    private System.Windows.Forms.DataGridViewTextBoxColumn cidade;
    private System.Windows.Forms.DataGridViewTextBoxColumn estado;
    private System.Windows.Forms.DataGridViewTextBoxColumn telefone1;
    private System.Windows.Forms.DataGridViewTextBoxColumn ramal1;
    private System.Windows.Forms.DataGridViewTextBoxColumn telefone2;
    private System.Windows.Forms.DataGridViewTextBoxColumn ramal2;
    private System.Windows.Forms.DataGridViewTextBoxColumn email;
    private System.Windows.Forms.DataGridViewTextBoxColumn obs;
    private System.Windows.Forms.GroupBox groupBox1;
    private System.Windows.Forms.RadioButton radRazaoSocial;
    private System.Windows.Forms.Button btnPesquisar;
    private System.Windows.Forms.MaskedTextBox txtPesquisaCnpj;
    private System.Windows.Forms.TextBox txtPesquisa;
    private System.Windows.Forms.RadioButton radCnpj;
    private System.Windows.Forms.RadioButton radNomeFantasia;
    private System.Windows.Forms.TextBox txtNomeFantasia;
  }
}