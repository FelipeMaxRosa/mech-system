namespace MechSystem
{
  partial class FormCadCodBarras
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCadCodBarras));
      this.dataGridView1 = new System.Windows.Forms.DataGridView();
      this.ean = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.emb = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.unidade = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.codigoproduto = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.gpbCodBarras = new System.Windows.Forms.GroupBox();
      this.txtEan13 = new System.Windows.Forms.MaskedTextBox();
      this.btnSalvar = new System.Windows.Forms.Button();
      this.txtUnidade = new System.Windows.Forms.TextBox();
      this.label17 = new System.Windows.Forms.Label();
      this.cbxEmb = new System.Windows.Forms.ComboBox();
      this.label1 = new System.Windows.Forms.Label();
      this.label2 = new System.Windows.Forms.Label();
      this.btnSair = new System.Windows.Forms.Button();
      ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
      this.gpbCodBarras.SuspendLayout();
      this.SuspendLayout();
      // 
      // dataGridView1
      // 
      this.dataGridView1.AllowUserToAddRows = false;
      this.dataGridView1.AllowUserToDeleteRows = false;
      this.dataGridView1.AllowUserToOrderColumns = true;
      this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ean,
            this.emb,
            this.unidade,
            this.codigoproduto});
      this.dataGridView1.Location = new System.Drawing.Point(2, 88);
      this.dataGridView1.MultiSelect = false;
      this.dataGridView1.Name = "dataGridView1";
      this.dataGridView1.ReadOnly = true;
      this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
      this.dataGridView1.Size = new System.Drawing.Size(305, 113);
      this.dataGridView1.TabIndex = 1;
      this.dataGridView1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dataGridView1_KeyDown);
      // 
      // ean
      // 
      this.ean.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
      this.ean.DataPropertyName = "ean13";
      this.ean.HeaderText = "EAN13";
      this.ean.Name = "ean";
      this.ean.ReadOnly = true;
      this.ean.Width = 64;
      // 
      // emb
      // 
      this.emb.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
      this.emb.DataPropertyName = "embalagem";
      this.emb.HeaderText = "Emb.";
      this.emb.Name = "emb";
      this.emb.ReadOnly = true;
      this.emb.Width = 56;
      // 
      // unidade
      // 
      this.unidade.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
      this.unidade.DataPropertyName = "unidade";
      this.unidade.HeaderText = "UN";
      this.unidade.Name = "unidade";
      this.unidade.ReadOnly = true;
      this.unidade.Width = 46;
      // 
      // codigoproduto
      // 
      this.codigoproduto.DataPropertyName = "idproduto";
      this.codigoproduto.HeaderText = "Código";
      this.codigoproduto.Name = "codigoproduto";
      this.codigoproduto.ReadOnly = true;
      this.codigoproduto.Visible = false;
      // 
      // gpbCodBarras
      // 
      this.gpbCodBarras.Controls.Add(this.txtEan13);
      this.gpbCodBarras.Controls.Add(this.btnSalvar);
      this.gpbCodBarras.Controls.Add(this.txtUnidade);
      this.gpbCodBarras.Controls.Add(this.label17);
      this.gpbCodBarras.Controls.Add(this.cbxEmb);
      this.gpbCodBarras.Controls.Add(this.label1);
      this.gpbCodBarras.Controls.Add(this.label2);
      this.gpbCodBarras.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.gpbCodBarras.Location = new System.Drawing.Point(2, 4);
      this.gpbCodBarras.Name = "gpbCodBarras";
      this.gpbCodBarras.Size = new System.Drawing.Size(305, 78);
      this.gpbCodBarras.TabIndex = 0;
      this.gpbCodBarras.TabStop = false;
      // 
      // txtEan13
      // 
      this.txtEan13.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.txtEan13.Location = new System.Drawing.Point(46, 20);
      this.txtEan13.Mask = "999999999999-9";
      this.txtEan13.Name = "txtEan13";
      this.txtEan13.PromptChar = ' ';
      this.txtEan13.Size = new System.Drawing.Size(121, 21);
      this.txtEan13.TabIndex = 0;
      this.txtEan13.Leave += new System.EventHandler(this.txtEan13_Leave);
      this.txtEan13.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtEan13_KeyPress);
      // 
      // btnSalvar
      // 
      this.btnSalvar.Cursor = System.Windows.Forms.Cursors.Hand;
      this.btnSalvar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
      this.btnSalvar.Enabled = false;
      this.btnSalvar.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.btnSalvar.Location = new System.Drawing.Point(213, 49);
      this.btnSalvar.Name = "btnSalvar";
      this.btnSalvar.Size = new System.Drawing.Size(81, 23);
      this.btnSalvar.TabIndex = 3;
      this.btnSalvar.Text = "Salvar";
      this.btnSalvar.UseVisualStyleBackColor = true;
      this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
      // 
      // txtUnidade
      // 
      this.txtUnidade.Location = new System.Drawing.Point(124, 47);
      this.txtUnidade.Name = "txtUnidade";
      this.txtUnidade.Size = new System.Drawing.Size(43, 21);
      this.txtUnidade.TabIndex = 2;
      // 
      // label17
      // 
      this.label17.AutoSize = true;
      this.label17.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label17.Location = new System.Drawing.Point(93, 50);
      this.label17.Name = "label17";
      this.label17.Size = new System.Drawing.Size(29, 13);
      this.label17.TabIndex = 47;
      this.label17.Text = "UN.:";
      // 
      // cbxEmb
      // 
      this.cbxEmb.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
      this.cbxEmb.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
      this.cbxEmb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
      this.cbxEmb.FormattingEnabled = true;
      this.cbxEmb.Items.AddRange(new object[] {
            "UN",
            "CX",
            "PC",
            "LT",
            "L"});
      this.cbxEmb.Location = new System.Drawing.Point(46, 47);
      this.cbxEmb.Name = "cbxEmb";
      this.cbxEmb.Size = new System.Drawing.Size(43, 21);
      this.cbxEmb.TabIndex = 1;
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label1.Location = new System.Drawing.Point(9, 50);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(35, 13);
      this.label1.TabIndex = 33;
      this.label1.Text = "Emb.:";
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label2.Location = new System.Drawing.Point(9, 23);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(31, 13);
      this.label2.TabIndex = 33;
      this.label2.Text = "EAN:";
      // 
      // btnSair
      // 
      this.btnSair.Cursor = System.Windows.Forms.Cursors.Hand;
      this.btnSair.DialogResult = System.Windows.Forms.DialogResult.Cancel;
      this.btnSair.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.btnSair.Location = new System.Drawing.Point(226, 207);
      this.btnSair.Name = "btnSair";
      this.btnSair.Size = new System.Drawing.Size(81, 23);
      this.btnSair.TabIndex = 2;
      this.btnSair.Text = "Sair";
      this.btnSair.UseVisualStyleBackColor = true;
      this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
      // 
      // FormCadCodBarras
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.CancelButton = this.btnSair;
      this.ClientSize = new System.Drawing.Size(311, 234);
      this.Controls.Add(this.btnSair);
      this.Controls.Add(this.gpbCodBarras);
      this.Controls.Add(this.dataGridView1);
      this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
      this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
      this.KeyPreview = true;
      this.MaximizeBox = false;
      this.Name = "FormCadCodBarras";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "Cadastro de Código de Barras";
      this.Load += new System.EventHandler(this.FormCadCodBarras_Load);
      this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FormCadCodBarras_KeyDown);
      ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
      this.gpbCodBarras.ResumeLayout(false);
      this.gpbCodBarras.PerformLayout();
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.DataGridView dataGridView1;
    private System.Windows.Forms.Label label2;
    public System.Windows.Forms.TextBox txtUnidade;
    private System.Windows.Forms.Label label17;
    public System.Windows.Forms.ComboBox cbxEmb;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Button btnSair;
    private System.Windows.Forms.Button btnSalvar;
    private System.Windows.Forms.DataGridViewTextBoxColumn ean;
    private System.Windows.Forms.DataGridViewTextBoxColumn emb;
    private System.Windows.Forms.DataGridViewTextBoxColumn unidade;
    private System.Windows.Forms.DataGridViewTextBoxColumn codigoproduto;
    private System.Windows.Forms.MaskedTextBox txtEan13;
    public System.Windows.Forms.GroupBox gpbCodBarras;
  }
}