namespace MechSystem
{
  partial class FormGridProdutos
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormGridProdutos));
      this.butSair = new System.Windows.Forms.Button();
      this.dataGridView1 = new System.Windows.Forms.DataGridView();
      this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.descricao = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.descricaoresumida = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.marca = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.embalagem = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.unidade = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.venda = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.Margem = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.estoqueminimo = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.estoque = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.IdFornecedor = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.Custo = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.estado_estoque = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.groupBox1 = new System.Windows.Forms.GroupBox();
      this.groupBox2 = new System.Windows.Forms.GroupBox();
      this.cbxEstadoEstoque = new System.Windows.Forms.ComboBox();
      this.groupBox4 = new System.Windows.Forms.GroupBox();
      this.cbxSituacao = new System.Windows.Forms.ComboBox();
      this.groupBox3 = new System.Windows.Forms.GroupBox();
      this.label3 = new System.Windows.Forms.Label();
      this.radEan = new System.Windows.Forms.RadioButton();
      this.radDescricao = new System.Windows.Forms.RadioButton();
      this.btnPesquisar = new System.Windows.Forms.Button();
      this.tbEan13 = new System.Windows.Forms.MaskedTextBox();
      this.txtPesquisa = new System.Windows.Forms.TextBox();
      ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
      this.groupBox1.SuspendLayout();
      this.groupBox2.SuspendLayout();
      this.groupBox4.SuspendLayout();
      this.SuspendLayout();
      // 
      // butSair
      // 
      this.butSair.Cursor = System.Windows.Forms.Cursors.Hand;
      this.butSair.DialogResult = System.Windows.Forms.DialogResult.Cancel;
      this.butSair.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.butSair.Location = new System.Drawing.Point(819, 485);
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
            this.descricao,
            this.estado,
            this.descricaoresumida,
            this.marca,
            this.embalagem,
            this.unidade,
            this.venda,
            this.Margem,
            this.estoqueminimo,
            this.estoque,
            this.IdFornecedor,
            this.Custo,
            this.estado_estoque});
      this.dataGridView1.Location = new System.Drawing.Point(3, 85);
      this.dataGridView1.MultiSelect = false;
      this.dataGridView1.Name = "dataGridView1";
      this.dataGridView1.ReadOnly = true;
      this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
      this.dataGridView1.Size = new System.Drawing.Size(897, 394);
      this.dataGridView1.TabIndex = 1;
      this.dataGridView1.Enter += new System.EventHandler(this.dataGridView1_Enter);
      this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
      this.dataGridView1.Leave += new System.EventHandler(this.dataGridView1_Leave);
      this.dataGridView1.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dataGridView1_CellFormatting);
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
      // descricao
      // 
      this.descricao.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
      this.descricao.DataPropertyName = "descricao";
      this.descricao.HeaderText = "Descrição";
      this.descricao.Name = "descricao";
      this.descricao.ReadOnly = true;
      this.descricao.Width = 78;
      // 
      // estado
      // 
      this.estado.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
      this.estado.DataPropertyName = "estado";
      this.estado.HeaderText = "Situação";
      this.estado.Name = "estado";
      this.estado.ReadOnly = true;
      this.estado.Width = 73;
      // 
      // descricaoresumida
      // 
      this.descricaoresumida.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
      this.descricaoresumida.DataPropertyName = "descricaoresumida";
      this.descricaoresumida.HeaderText = "Resumida";
      this.descricaoresumida.Name = "descricaoresumida";
      this.descricaoresumida.ReadOnly = true;
      this.descricaoresumida.Width = 78;
      // 
      // marca
      // 
      this.marca.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
      this.marca.DataPropertyName = "marca";
      this.marca.HeaderText = "Marca";
      this.marca.Name = "marca";
      this.marca.ReadOnly = true;
      this.marca.Width = 61;
      // 
      // embalagem
      // 
      this.embalagem.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
      this.embalagem.DataPropertyName = "embalagem";
      this.embalagem.HeaderText = "Emb.";
      this.embalagem.Name = "embalagem";
      this.embalagem.ReadOnly = true;
      this.embalagem.Width = 56;
      // 
      // unidade
      // 
      this.unidade.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
      this.unidade.DataPropertyName = "unidade";
      this.unidade.HeaderText = "Un.";
      this.unidade.Name = "unidade";
      this.unidade.ReadOnly = true;
      this.unidade.Width = 49;
      // 
      // venda
      // 
      this.venda.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
      this.venda.DataPropertyName = "venda";
      this.venda.HeaderText = "Venda";
      this.venda.Name = "venda";
      this.venda.ReadOnly = true;
      this.venda.Width = 62;
      // 
      // Margem
      // 
      this.Margem.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
      this.Margem.DataPropertyName = "margemlucro";
      this.Margem.HeaderText = "Margem";
      this.Margem.Name = "Margem";
      this.Margem.ReadOnly = true;
      this.Margem.Width = 70;
      // 
      // estoqueminimo
      // 
      this.estoqueminimo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
      this.estoqueminimo.DataPropertyName = "estoqueminimo";
      this.estoqueminimo.HeaderText = "Est. Mínimo";
      this.estoqueminimo.Name = "estoqueminimo";
      this.estoqueminimo.ReadOnly = true;
      this.estoqueminimo.Width = 79;
      // 
      // estoque
      // 
      this.estoque.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
      this.estoque.DataPropertyName = "estoque";
      this.estoque.HeaderText = "Est. Atual";
      this.estoque.Name = "estoque";
      this.estoque.ReadOnly = true;
      this.estoque.Width = 73;
      // 
      // IdFornecedor
      // 
      this.IdFornecedor.DataPropertyName = "idfornecedor";
      this.IdFornecedor.HeaderText = "Fornecedor";
      this.IdFornecedor.Name = "IdFornecedor";
      this.IdFornecedor.ReadOnly = true;
      this.IdFornecedor.Visible = false;
      // 
      // Custo
      // 
      this.Custo.DataPropertyName = "custo";
      this.Custo.HeaderText = "Custo";
      this.Custo.Name = "Custo";
      this.Custo.ReadOnly = true;
      this.Custo.Visible = false;
      // 
      // estado_estoque
      // 
      this.estado_estoque.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
      this.estado_estoque.DataPropertyName = "estado_estoque";
      this.estado_estoque.HeaderText = "Estado do Estoque";
      this.estado_estoque.Name = "estado_estoque";
      this.estado_estoque.ReadOnly = true;
      this.estado_estoque.Width = 112;
      // 
      // groupBox1
      // 
      this.groupBox1.Controls.Add(this.groupBox2);
      this.groupBox1.Controls.Add(this.groupBox4);
      this.groupBox1.Controls.Add(this.groupBox3);
      this.groupBox1.Controls.Add(this.label3);
      this.groupBox1.Controls.Add(this.radEan);
      this.groupBox1.Controls.Add(this.radDescricao);
      this.groupBox1.Controls.Add(this.btnPesquisar);
      this.groupBox1.Controls.Add(this.tbEan13);
      this.groupBox1.Controls.Add(this.txtPesquisa);
      this.groupBox1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.groupBox1.Location = new System.Drawing.Point(3, 3);
      this.groupBox1.Name = "groupBox1";
      this.groupBox1.Size = new System.Drawing.Size(897, 76);
      this.groupBox1.TabIndex = 0;
      this.groupBox1.TabStop = false;
      this.groupBox1.Text = "Pesquisa por";
      // 
      // groupBox2
      // 
      this.groupBox2.Controls.Add(this.cbxEstadoEstoque);
      this.groupBox2.Location = new System.Drawing.Point(599, 19);
      this.groupBox2.Name = "groupBox2";
      this.groupBox2.Size = new System.Drawing.Size(159, 47);
      this.groupBox2.TabIndex = 53;
      this.groupBox2.TabStop = false;
      this.groupBox2.Text = "Estado do Estoque";
      // 
      // cbxEstadoEstoque
      // 
      this.cbxEstadoEstoque.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
      this.cbxEstadoEstoque.FormattingEnabled = true;
      this.cbxEstadoEstoque.Items.AddRange(new object[] {
            "MINIMO",
            "ABAIXO DO MINIMO",
            "DISPONIVEL",
            "TODOS"});
      this.cbxEstadoEstoque.Location = new System.Drawing.Point(6, 20);
      this.cbxEstadoEstoque.Name = "cbxEstadoEstoque";
      this.cbxEstadoEstoque.Size = new System.Drawing.Size(147, 21);
      this.cbxEstadoEstoque.TabIndex = 0;
      this.cbxEstadoEstoque.SelectedIndexChanged += new System.EventHandler(this.cbxEstadoEstoque_SelectedIndexChanged);
      // 
      // groupBox4
      // 
      this.groupBox4.Controls.Add(this.cbxSituacao);
      this.groupBox4.Location = new System.Drawing.Point(459, 19);
      this.groupBox4.Name = "groupBox4";
      this.groupBox4.Size = new System.Drawing.Size(134, 47);
      this.groupBox4.TabIndex = 52;
      this.groupBox4.TabStop = false;
      this.groupBox4.Text = "Situação";
      // 
      // cbxSituacao
      // 
      this.cbxSituacao.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
      this.cbxSituacao.FormattingEnabled = true;
      this.cbxSituacao.Items.AddRange(new object[] {
            "EM LINHA",
            "FORA DE LINHA",
            "TODOS"});
      this.cbxSituacao.Location = new System.Drawing.Point(6, 20);
      this.cbxSituacao.Name = "cbxSituacao";
      this.cbxSituacao.Size = new System.Drawing.Size(121, 21);
      this.cbxSituacao.TabIndex = 0;
      this.cbxSituacao.SelectedIndexChanged += new System.EventHandler(this.cbxSituacao_SelectedIndexChanged);
      // 
      // groupBox3
      // 
      this.groupBox3.Location = new System.Drawing.Point(370, 14);
      this.groupBox3.Name = "groupBox3";
      this.groupBox3.Size = new System.Drawing.Size(11, 52);
      this.groupBox3.TabIndex = 51;
      this.groupBox3.TabStop = false;
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label3.ForeColor = System.Drawing.SystemColors.ControlText;
      this.label3.Location = new System.Drawing.Point(387, 23);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(66, 13);
      this.label3.TabIndex = 50;
      this.label3.Text = "Filtrar por:";
      // 
      // radEan
      // 
      this.radEan.AutoSize = true;
      this.radEan.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.radEan.Location = new System.Drawing.Point(11, 47);
      this.radEan.Name = "radEan";
      this.radEan.Size = new System.Drawing.Size(49, 17);
      this.radEan.TabIndex = 39;
      this.radEan.Text = "&EAN:";
      this.radEan.UseVisualStyleBackColor = true;
      this.radEan.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
      // 
      // radDescricao
      // 
      this.radDescricao.AutoSize = true;
      this.radDescricao.Checked = true;
      this.radDescricao.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.radDescricao.Location = new System.Drawing.Point(11, 21);
      this.radDescricao.Name = "radDescricao";
      this.radDescricao.Size = new System.Drawing.Size(75, 17);
      this.radDescricao.TabIndex = 39;
      this.radDescricao.TabStop = true;
      this.radDescricao.Text = "&Descrição:";
      this.radDescricao.UseVisualStyleBackColor = true;
      this.radDescricao.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
      // 
      // btnPesquisar
      // 
      this.btnPesquisar.Cursor = System.Windows.Forms.Cursors.Hand;
      this.btnPesquisar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
      this.btnPesquisar.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.btnPesquisar.Location = new System.Drawing.Point(810, 46);
      this.btnPesquisar.Name = "btnPesquisar";
      this.btnPesquisar.Size = new System.Drawing.Size(81, 23);
      this.btnPesquisar.TabIndex = 2;
      this.btnPesquisar.Text = "Pesquisar";
      this.btnPesquisar.UseVisualStyleBackColor = true;
      this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
      // 
      // tbEan13
      // 
      this.tbEan13.Enabled = false;
      this.tbEan13.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.tbEan13.Location = new System.Drawing.Point(90, 47);
      this.tbEan13.Mask = "000000000000-0";
      this.tbEan13.Name = "tbEan13";
      this.tbEan13.PromptChar = ' ';
      this.tbEan13.Size = new System.Drawing.Size(115, 21);
      this.tbEan13.TabIndex = 1;
      // 
      // txtPesquisa
      // 
      this.txtPesquisa.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
      this.txtPesquisa.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.txtPesquisa.Location = new System.Drawing.Point(90, 20);
      this.txtPesquisa.Name = "txtPesquisa";
      this.txtPesquisa.Size = new System.Drawing.Size(273, 21);
      this.txtPesquisa.TabIndex = 0;
      // 
      // FormGridProdutos
      // 
      this.AcceptButton = this.btnPesquisar;
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.CancelButton = this.butSair;
      this.ClientSize = new System.Drawing.Size(904, 512);
      this.Controls.Add(this.groupBox1);
      this.Controls.Add(this.butSair);
      this.Controls.Add(this.dataGridView1);
      this.Font = new System.Drawing.Font("Tahoma", 8.25F);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
      this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
      this.KeyPreview = true;
      this.MaximizeBox = false;
      this.Name = "FormGridProdutos";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "Consulta - Produtos";
      this.Load += new System.EventHandler(this.FormGridProdutos_Load);
      ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
      this.groupBox1.ResumeLayout(false);
      this.groupBox1.PerformLayout();
      this.groupBox2.ResumeLayout(false);
      this.groupBox4.ResumeLayout(false);
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.Button butSair;
    private System.Windows.Forms.DataGridView dataGridView1;
    private System.Windows.Forms.GroupBox groupBox1;
    private System.Windows.Forms.RadioButton radEan;
    private System.Windows.Forms.RadioButton radDescricao;
    private System.Windows.Forms.Button btnPesquisar;
    private System.Windows.Forms.MaskedTextBox tbEan13;
    private System.Windows.Forms.TextBox txtPesquisa;
    private System.Windows.Forms.GroupBox groupBox3;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.GroupBox groupBox4;
    private System.Windows.Forms.ComboBox cbxSituacao;
    private System.Windows.Forms.GroupBox groupBox2;
    private System.Windows.Forms.ComboBox cbxEstadoEstoque;
    private System.Windows.Forms.DataGridViewTextBoxColumn id;
    private System.Windows.Forms.DataGridViewTextBoxColumn descricao;
    private System.Windows.Forms.DataGridViewTextBoxColumn estado;
    private System.Windows.Forms.DataGridViewTextBoxColumn descricaoresumida;
    private System.Windows.Forms.DataGridViewTextBoxColumn marca;
    private System.Windows.Forms.DataGridViewTextBoxColumn embalagem;
    private System.Windows.Forms.DataGridViewTextBoxColumn unidade;
    private System.Windows.Forms.DataGridViewTextBoxColumn venda;
    private System.Windows.Forms.DataGridViewTextBoxColumn Margem;
    private System.Windows.Forms.DataGridViewTextBoxColumn estoqueminimo;
    private System.Windows.Forms.DataGridViewTextBoxColumn estoque;
    private System.Windows.Forms.DataGridViewTextBoxColumn IdFornecedor;
    private System.Windows.Forms.DataGridViewTextBoxColumn Custo;
    private System.Windows.Forms.DataGridViewTextBoxColumn estado_estoque;

  }
}