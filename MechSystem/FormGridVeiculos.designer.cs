namespace MechSystem
{
  partial class FormGridVeiculos
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormGridVeiculos));
      this.dataGridView1 = new System.Windows.Forms.DataGridView();
      this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.Cliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.razaosocial = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.nomefantasia = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.cnpj = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.ie = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.butSair = new System.Windows.Forms.Button();
      this.groupBox1 = new System.Windows.Forms.GroupBox();
      this.tbPlacaCarro = new System.Windows.Forms.TextBox();
      this.btnPesquisar = new System.Windows.Forms.Button();
      this.radPlaca = new System.Windows.Forms.RadioButton();
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
            this.Cliente,
            this.razaosocial,
            this.nomefantasia,
            this.cnpj,
            this.ie});
      this.dataGridView1.Location = new System.Drawing.Point(3, 57);
      this.dataGridView1.MultiSelect = false;
      this.dataGridView1.Name = "dataGridView1";
      this.dataGridView1.ReadOnly = true;
      this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
      this.dataGridView1.Size = new System.Drawing.Size(456, 148);
      this.dataGridView1.TabIndex = 1;
      this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
      this.dataGridView1.Leave += new System.EventHandler(this.dataGridView1_Leave);
      this.dataGridView1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dataGridView1_KeyDown);
      // 
      // id
      // 
      this.id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
      this.id.DataPropertyName = "placa";
      this.id.HeaderText = "Placa";
      this.id.Name = "id";
      this.id.ReadOnly = true;
      this.id.Width = 57;
      // 
      // Cliente
      // 
      this.Cliente.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
      this.Cliente.DataPropertyName = "Clientes_id";
      this.Cliente.HeaderText = "Cliente";
      this.Cliente.Name = "Cliente";
      this.Cliente.ReadOnly = true;
      this.Cliente.Width = 65;
      // 
      // razaosocial
      // 
      this.razaosocial.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
      this.razaosocial.DataPropertyName = "marca";
      this.razaosocial.HeaderText = "Fabricante";
      this.razaosocial.Name = "razaosocial";
      this.razaosocial.ReadOnly = true;
      this.razaosocial.Width = 83;
      // 
      // nomefantasia
      // 
      this.nomefantasia.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
      this.nomefantasia.DataPropertyName = "modelo";
      this.nomefantasia.HeaderText = "Modelo";
      this.nomefantasia.Name = "nomefantasia";
      this.nomefantasia.ReadOnly = true;
      this.nomefantasia.Width = 66;
      // 
      // cnpj
      // 
      this.cnpj.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
      this.cnpj.DataPropertyName = "cor";
      this.cnpj.HeaderText = "Cor";
      this.cnpj.Name = "cnpj";
      this.cnpj.ReadOnly = true;
      this.cnpj.Width = 49;
      // 
      // ie
      // 
      this.ie.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
      this.ie.DataPropertyName = "ano";
      this.ie.HeaderText = "Ano";
      this.ie.Name = "ie";
      this.ie.ReadOnly = true;
      this.ie.Width = 51;
      // 
      // butSair
      // 
      this.butSair.Cursor = System.Windows.Forms.Cursors.Hand;
      this.butSair.DialogResult = System.Windows.Forms.DialogResult.Cancel;
      this.butSair.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.butSair.Location = new System.Drawing.Point(378, 210);
      this.butSair.Name = "butSair";
      this.butSair.Size = new System.Drawing.Size(81, 23);
      this.butSair.TabIndex = 2;
      this.butSair.Text = "Sair";
      this.butSair.UseVisualStyleBackColor = true;
      this.butSair.Click += new System.EventHandler(this.butSair_Click);
      // 
      // groupBox1
      // 
      this.groupBox1.Controls.Add(this.radPlaca);
      this.groupBox1.Controls.Add(this.tbPlacaCarro);
      this.groupBox1.Controls.Add(this.btnPesquisar);
      this.groupBox1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.groupBox1.Location = new System.Drawing.Point(3, 2);
      this.groupBox1.Name = "groupBox1";
      this.groupBox1.Size = new System.Drawing.Size(456, 49);
      this.groupBox1.TabIndex = 0;
      this.groupBox1.TabStop = false;
      this.groupBox1.Text = "Pesquisar por";
      // 
      // tbPlacaCarro
      // 
      this.tbPlacaCarro.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
      this.tbPlacaCarro.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.tbPlacaCarro.Location = new System.Drawing.Point(63, 20);
      this.tbPlacaCarro.MaxLength = 8;
      this.tbPlacaCarro.Name = "tbPlacaCarro";
      this.tbPlacaCarro.Size = new System.Drawing.Size(67, 21);
      this.tbPlacaCarro.TabIndex = 0;
      // 
      // btnPesquisar
      // 
      this.btnPesquisar.Cursor = System.Windows.Forms.Cursors.Hand;
      this.btnPesquisar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
      this.btnPesquisar.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.btnPesquisar.Location = new System.Drawing.Point(369, 20);
      this.btnPesquisar.Name = "btnPesquisar";
      this.btnPesquisar.Size = new System.Drawing.Size(81, 23);
      this.btnPesquisar.TabIndex = 1;
      this.btnPesquisar.Text = "Pesquisar";
      this.btnPesquisar.UseVisualStyleBackColor = true;
      this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
      // 
      // radPlaca
      // 
      this.radPlaca.AutoSize = true;
      this.radPlaca.Checked = true;
      this.radPlaca.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.radPlaca.Location = new System.Drawing.Point(6, 21);
      this.radPlaca.Name = "radPlaca";
      this.radPlaca.Size = new System.Drawing.Size(54, 17);
      this.radPlaca.TabIndex = 34;
      this.radPlaca.TabStop = true;
      this.radPlaca.Text = "Placa:";
      this.radPlaca.UseVisualStyleBackColor = true;
      this.radPlaca.CheckedChanged += new System.EventHandler(this.radPlaca_CheckedChanged);
      // 
      // FormGridVeiculos
      // 
      this.AcceptButton = this.btnPesquisar;
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.CancelButton = this.butSair;
      this.ClientSize = new System.Drawing.Size(461, 236);
      this.Controls.Add(this.groupBox1);
      this.Controls.Add(this.butSair);
      this.Controls.Add(this.dataGridView1);
      this.Font = new System.Drawing.Font("Tahoma", 8.25F);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
      this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
      this.MaximizeBox = false;
      this.Name = "FormGridVeiculos";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "Consulta - Veículos";
      this.Load += new System.EventHandler(this.FormGridVeiculos_Load);
      ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
      this.groupBox1.ResumeLayout(false);
      this.groupBox1.PerformLayout();
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.DataGridView dataGridView1;
    private System.Windows.Forms.Button butSair;
    private System.Windows.Forms.DataGridViewTextBoxColumn id;
    private System.Windows.Forms.DataGridViewTextBoxColumn Cliente;
    private System.Windows.Forms.DataGridViewTextBoxColumn razaosocial;
    private System.Windows.Forms.DataGridViewTextBoxColumn nomefantasia;
    private System.Windows.Forms.DataGridViewTextBoxColumn cnpj;
    private System.Windows.Forms.DataGridViewTextBoxColumn ie;
    private System.Windows.Forms.GroupBox groupBox1;
    private System.Windows.Forms.RadioButton radPlaca;
    private System.Windows.Forms.TextBox tbPlacaCarro;
    private System.Windows.Forms.Button btnPesquisar;
  }
}