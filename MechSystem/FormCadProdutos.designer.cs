namespace MechSystem
{
  partial class FormCadProdutos
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCadProdutos));
      this.label1 = new System.Windows.Forms.Label();
      this.tbCodigoProduto = new System.Windows.Forms.TextBox();
      this.labNome = new System.Windows.Forms.Label();
      this.tbDescProduto = new System.Windows.Forms.TextBox();
      this.pictureBox1 = new System.Windows.Forms.PictureBox();
      this.labApelidoNFantasia = new System.Windows.Forms.Label();
      this.tbDescResumida = new System.Windows.Forms.TextBox();
      this.label2 = new System.Windows.Forms.Label();
      this.label4 = new System.Windows.Forms.Label();
      this.tbMarcaProduto = new System.Windows.Forms.TextBox();
      this.gbProduto = new System.Windows.Forms.GroupBox();
      this.butReferencias = new System.Windows.Forms.Button();
      this.butEans = new System.Windows.Forms.Button();
      this.groupBox2 = new System.Windows.Forms.GroupBox();
      this.cbxSituacao = new System.Windows.Forms.ComboBox();
      this.btnConsultaGeral = new System.Windows.Forms.Button();
      this.tbEan13 = new System.Windows.Forms.MaskedTextBox();
      this.gbPrecos = new System.Windows.Forms.GroupBox();
      this.label14 = new System.Windows.Forms.Label();
      this.tbPrecoSugerido = new System.Windows.Forms.TextBox();
      this.label12 = new System.Windows.Forms.Label();
      this.label11 = new System.Windows.Forms.Label();
      this.tbMargemReal = new System.Windows.Forms.TextBox();
      this.label9 = new System.Windows.Forms.Label();
      this.tbPrecoVenda = new System.Windows.Forms.TextBox();
      this.label8 = new System.Windows.Forms.Label();
      this.tbMargemLucro = new System.Windows.Forms.TextBox();
      this.label7 = new System.Windows.Forms.Label();
      this.tbPrecoCusto = new System.Windows.Forms.TextBox();
      this.label5 = new System.Windows.Forms.Label();
      this.gbEstoque = new System.Windows.Forms.GroupBox();
      this.groupBox3 = new System.Windows.Forms.GroupBox();
      this.lblEstadoEstoque = new System.Windows.Forms.Label();
      this.tbEstoqueMinimo = new System.Windows.Forms.TextBox();
      this.label13 = new System.Windows.Forms.Label();
      this.tbEstoqueInicial = new System.Windows.Forms.TextBox();
      this.label15 = new System.Windows.Forms.Label();
      this.gbFornecedor = new System.Windows.Forms.GroupBox();
      this.btnConsultaFornecedor = new System.Windows.Forms.Button();
      this.lblForn = new System.Windows.Forms.Label();
      this.label6 = new System.Windows.Forms.Label();
      this.tbCodigoFornecedor = new System.Windows.Forms.TextBox();
      this.groupBox1 = new System.Windows.Forms.GroupBox();
      this.tbUnidade = new System.Windows.Forms.TextBox();
      this.cbxEmb = new System.Windows.Forms.ComboBox();
      this.label17 = new System.Windows.Forms.Label();
      this.tbNomeFornecedor = new System.Windows.Forms.TextBox();
      this.label10 = new System.Windows.Forms.Label();
      this.butCancelar = new System.Windows.Forms.Button();
      this.butAlterar = new System.Windows.Forms.Button();
      this.butNovo = new System.Windows.Forms.Button();
      this.butSalvar = new System.Windows.Forms.Button();
      this.butExcluir = new System.Windows.Forms.Button();
      this.butConsultar = new System.Windows.Forms.Button();
      this.butSair = new System.Windows.Forms.Button();
      this.tbEstoqueAtual = new System.Windows.Forms.TextBox();
      this.label16 = new System.Windows.Forms.Label();
      ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
      this.gbProduto.SuspendLayout();
      this.groupBox2.SuspendLayout();
      this.gbPrecos.SuspendLayout();
      this.gbEstoque.SuspendLayout();
      this.groupBox3.SuspendLayout();
      this.gbFornecedor.SuspendLayout();
      this.groupBox1.SuspendLayout();
      this.SuspendLayout();
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label1.Location = new System.Drawing.Point(38, 27);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(44, 13);
      this.label1.TabIndex = 0;
      this.label1.Text = "Código:";
      // 
      // tbCodigoProduto
      // 
      this.tbCodigoProduto.Location = new System.Drawing.Point(86, 24);
      this.tbCodigoProduto.Name = "tbCodigoProduto";
      this.tbCodigoProduto.Size = new System.Drawing.Size(58, 21);
      this.tbCodigoProduto.TabIndex = 1;
      this.tbCodigoProduto.Leave += new System.EventHandler(this.tbCodigoProduto_Leave);
      this.tbCodigoProduto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbCodigoProduto_KeyPress);
      this.tbCodigoProduto.Enter += new System.EventHandler(this.tbCodigoProduto_Enter);
      // 
      // labNome
      // 
      this.labNome.AutoSize = true;
      this.labNome.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.labNome.Location = new System.Drawing.Point(25, 55);
      this.labNome.Name = "labNome";
      this.labNome.Size = new System.Drawing.Size(57, 13);
      this.labNome.TabIndex = 4;
      this.labNome.Text = "Descrição:";
      // 
      // tbDescProduto
      // 
      this.tbDescProduto.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
      this.tbDescProduto.Location = new System.Drawing.Point(86, 52);
      this.tbDescProduto.MaxLength = 45;
      this.tbDescProduto.Name = "tbDescProduto";
      this.tbDescProduto.ReadOnly = true;
      this.tbDescProduto.Size = new System.Drawing.Size(328, 21);
      this.tbDescProduto.TabIndex = 4;
      this.tbDescProduto.TabStop = false;
      this.tbDescProduto.Leave += new System.EventHandler(this.tbDescProduto_Leave);
      // 
      // pictureBox1
      // 
      this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
      this.pictureBox1.Location = new System.Drawing.Point(571, 21);
      this.pictureBox1.Name = "pictureBox1";
      this.pictureBox1.Size = new System.Drawing.Size(116, 109);
      this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
      this.pictureBox1.TabIndex = 18;
      this.pictureBox1.TabStop = false;
      // 
      // labApelidoNFantasia
      // 
      this.labApelidoNFantasia.AutoSize = true;
      this.labApelidoNFantasia.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.labApelidoNFantasia.Location = new System.Drawing.Point(19, 83);
      this.labApelidoNFantasia.Name = "labApelidoNFantasia";
      this.labApelidoNFantasia.Size = new System.Drawing.Size(63, 13);
      this.labApelidoNFantasia.TabIndex = 30;
      this.labApelidoNFantasia.Text = "Desc. Res.:";
      // 
      // tbDescResumida
      // 
      this.tbDescResumida.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
      this.tbDescResumida.Location = new System.Drawing.Point(86, 80);
      this.tbDescResumida.MaxLength = 20;
      this.tbDescResumida.Name = "tbDescResumida";
      this.tbDescResumida.ReadOnly = true;
      this.tbDescResumida.Size = new System.Drawing.Size(216, 21);
      this.tbDescResumida.TabIndex = 5;
      this.tbDescResumida.TabStop = false;
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label2.Location = new System.Drawing.Point(265, 28);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(31, 13);
      this.label2.TabIndex = 31;
      this.label2.Text = "EAN:";
      // 
      // label4
      // 
      this.label4.AutoSize = true;
      this.label4.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label4.Location = new System.Drawing.Point(42, 111);
      this.label4.Name = "label4";
      this.label4.Size = new System.Drawing.Size(40, 13);
      this.label4.TabIndex = 35;
      this.label4.Text = "Marca:";
      // 
      // tbMarcaProduto
      // 
      this.tbMarcaProduto.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
      this.tbMarcaProduto.Location = new System.Drawing.Point(86, 108);
      this.tbMarcaProduto.MaxLength = 40;
      this.tbMarcaProduto.Name = "tbMarcaProduto";
      this.tbMarcaProduto.ReadOnly = true;
      this.tbMarcaProduto.Size = new System.Drawing.Size(161, 21);
      this.tbMarcaProduto.TabIndex = 6;
      this.tbMarcaProduto.TabStop = false;
      // 
      // gbProduto
      // 
      this.gbProduto.Controls.Add(this.butReferencias);
      this.gbProduto.Controls.Add(this.butEans);
      this.gbProduto.Controls.Add(this.groupBox2);
      this.gbProduto.Controls.Add(this.btnConsultaGeral);
      this.gbProduto.Controls.Add(this.tbEan13);
      this.gbProduto.Controls.Add(this.gbPrecos);
      this.gbProduto.Controls.Add(this.gbEstoque);
      this.gbProduto.Controls.Add(this.gbFornecedor);
      this.gbProduto.Controls.Add(this.tbMarcaProduto);
      this.gbProduto.Controls.Add(this.label4);
      this.gbProduto.Controls.Add(this.label2);
      this.gbProduto.Controls.Add(this.tbDescResumida);
      this.gbProduto.Controls.Add(this.labApelidoNFantasia);
      this.gbProduto.Controls.Add(this.pictureBox1);
      this.gbProduto.Controls.Add(this.tbDescProduto);
      this.gbProduto.Controls.Add(this.labNome);
      this.gbProduto.Controls.Add(this.tbCodigoProduto);
      this.gbProduto.Controls.Add(this.label1);
      this.gbProduto.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.gbProduto.Location = new System.Drawing.Point(12, 9);
      this.gbProduto.Name = "gbProduto";
      this.gbProduto.Size = new System.Drawing.Size(693, 402);
      this.gbProduto.TabIndex = 0;
      this.gbProduto.TabStop = false;
      this.gbProduto.Text = "Dados do Produto";
      this.gbProduto.Leave += new System.EventHandler(this.gbProduto_Leave);
      this.gbProduto.Enter += new System.EventHandler(this.gbProduto_Enter);
      // 
      // butReferencias
      // 
      this.butReferencias.Cursor = System.Windows.Forms.Cursors.Hand;
      this.butReferencias.Enabled = false;
      this.butReferencias.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.butReferencias.Location = new System.Drawing.Point(563, 268);
      this.butReferencias.Name = "butReferencias";
      this.butReferencias.Size = new System.Drawing.Size(106, 25);
      this.butReferencias.TabIndex = 11;
      this.butReferencias.Text = "Referências - F8";
      this.butReferencias.UseVisualStyleBackColor = true;
      this.butReferencias.Visible = false;
      // 
      // butEans
      // 
      this.butEans.Cursor = System.Windows.Forms.Cursors.Hand;
      this.butEans.Enabled = false;
      this.butEans.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.butEans.Location = new System.Drawing.Point(563, 236);
      this.butEans.Name = "butEans";
      this.butEans.Size = new System.Drawing.Size(106, 25);
      this.butEans.TabIndex = 10;
      this.butEans.Text = "EANs - F7";
      this.butEans.UseVisualStyleBackColor = true;
      this.butEans.Click += new System.EventHandler(this.butEans_Click);
      // 
      // groupBox2
      // 
      this.groupBox2.Controls.Add(this.cbxSituacao);
      this.groupBox2.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.groupBox2.Location = new System.Drawing.Point(420, 16);
      this.groupBox2.Name = "groupBox2";
      this.groupBox2.Size = new System.Drawing.Size(145, 49);
      this.groupBox2.TabIndex = 0;
      this.groupBox2.TabStop = false;
      this.groupBox2.Text = "Situação";
      // 
      // cbxSituacao
      // 
      this.cbxSituacao.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
      this.cbxSituacao.Enabled = false;
      this.cbxSituacao.FormattingEnabled = true;
      this.cbxSituacao.Items.AddRange(new object[] {
            "EM LINHA",
            "FORA DE LINHA"});
      this.cbxSituacao.Location = new System.Drawing.Point(7, 18);
      this.cbxSituacao.Name = "cbxSituacao";
      this.cbxSituacao.Size = new System.Drawing.Size(131, 21);
      this.cbxSituacao.TabIndex = 0;
      this.cbxSituacao.TabStop = false;
      // 
      // btnConsultaGeral
      // 
      this.btnConsultaGeral.Cursor = System.Windows.Forms.Cursors.Hand;
      this.btnConsultaGeral.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.btnConsultaGeral.Location = new System.Drawing.Point(148, 24);
      this.btnConsultaGeral.Name = "btnConsultaGeral";
      this.btnConsultaGeral.Size = new System.Drawing.Size(27, 22);
      this.btnConsultaGeral.TabIndex = 2;
      this.btnConsultaGeral.Text = "...";
      this.btnConsultaGeral.UseVisualStyleBackColor = true;
      this.btnConsultaGeral.Click += new System.EventHandler(this.btnConsultaGeral_Click);
      // 
      // tbEan13
      // 
      this.tbEan13.Location = new System.Drawing.Point(300, 25);
      this.tbEan13.Mask = "000000000000-0";
      this.tbEan13.Name = "tbEan13";
      this.tbEan13.PromptChar = ' ';
      this.tbEan13.ReadOnly = true;
      this.tbEan13.Size = new System.Drawing.Size(114, 21);
      this.tbEan13.TabIndex = 3;
      this.tbEan13.TabStop = false;
      this.tbEan13.Leave += new System.EventHandler(this.maskedTextBox1_Leave);
      // 
      // gbPrecos
      // 
      this.gbPrecos.Controls.Add(this.label14);
      this.gbPrecos.Controls.Add(this.tbPrecoSugerido);
      this.gbPrecos.Controls.Add(this.label12);
      this.gbPrecos.Controls.Add(this.label11);
      this.gbPrecos.Controls.Add(this.tbMargemReal);
      this.gbPrecos.Controls.Add(this.label9);
      this.gbPrecos.Controls.Add(this.tbPrecoVenda);
      this.gbPrecos.Controls.Add(this.label8);
      this.gbPrecos.Controls.Add(this.tbMargemLucro);
      this.gbPrecos.Controls.Add(this.label7);
      this.gbPrecos.Controls.Add(this.tbPrecoCusto);
      this.gbPrecos.Controls.Add(this.label5);
      this.gbPrecos.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.gbPrecos.Location = new System.Drawing.Point(6, 220);
      this.gbPrecos.Name = "gbPrecos";
      this.gbPrecos.Size = new System.Drawing.Size(521, 116);
      this.gbPrecos.TabIndex = 8;
      this.gbPrecos.TabStop = false;
      this.gbPrecos.Text = "Preços";
      // 
      // label14
      // 
      this.label14.AutoSize = true;
      this.label14.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label14.Location = new System.Drawing.Point(176, 58);
      this.label14.Name = "label14";
      this.label14.Size = new System.Drawing.Size(60, 13);
      this.label14.TabIndex = 72;
      this.label14.Text = "Margem de";
      // 
      // tbPrecoSugerido
      // 
      this.tbPrecoSugerido.Location = new System.Drawing.Point(421, 26);
      this.tbPrecoSugerido.Name = "tbPrecoSugerido";
      this.tbPrecoSugerido.ReadOnly = true;
      this.tbPrecoSugerido.Size = new System.Drawing.Size(72, 21);
      this.tbPrecoSugerido.TabIndex = 4;
      this.tbPrecoSugerido.TabStop = false;
      // 
      // label12
      // 
      this.label12.AutoSize = true;
      this.label12.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label12.Location = new System.Drawing.Point(334, 29);
      this.label12.Name = "label12";
      this.label12.Size = new System.Drawing.Size(83, 13);
      this.label12.TabIndex = 71;
      this.label12.Text = "Preço Sugerido:";
      // 
      // label11
      // 
      this.label11.AutoSize = true;
      this.label11.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label11.Location = new System.Drawing.Point(27, 77);
      this.label11.Name = "label11";
      this.label11.Size = new System.Drawing.Size(56, 13);
      this.label11.TabIndex = 69;
      this.label11.Text = "Lucro(%):";
      // 
      // tbMargemReal
      // 
      this.tbMargemReal.Location = new System.Drawing.Point(252, 73);
      this.tbMargemReal.Name = "tbMargemReal";
      this.tbMargemReal.ReadOnly = true;
      this.tbMargemReal.Size = new System.Drawing.Size(72, 21);
      this.tbMargemReal.TabIndex = 3;
      this.tbMargemReal.TabStop = false;
      // 
      // label9
      // 
      this.label9.AutoSize = true;
      this.label9.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label9.Location = new System.Drawing.Point(165, 76);
      this.label9.Name = "label9";
      this.label9.Size = new System.Drawing.Size(83, 13);
      this.label9.TabIndex = 68;
      this.label9.Text = "Lucro Real (%):";
      // 
      // tbPrecoVenda
      // 
      this.tbPrecoVenda.Location = new System.Drawing.Point(252, 26);
      this.tbPrecoVenda.Name = "tbPrecoVenda";
      this.tbPrecoVenda.ReadOnly = true;
      this.tbPrecoVenda.Size = new System.Drawing.Size(72, 21);
      this.tbPrecoVenda.TabIndex = 2;
      this.tbPrecoVenda.TabStop = false;
      this.tbPrecoVenda.Leave += new System.EventHandler(this.tbPrecoVenda_Leave);
      this.tbPrecoVenda.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbPrecoVenda_KeyPress);
      // 
      // label8
      // 
      this.label8.AutoSize = true;
      this.label8.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label8.Location = new System.Drawing.Point(177, 29);
      this.label8.Name = "label8";
      this.label8.Size = new System.Drawing.Size(71, 13);
      this.label8.TabIndex = 66;
      this.label8.Text = "Preço Venda:";
      // 
      // tbMargemLucro
      // 
      this.tbMargemLucro.Location = new System.Drawing.Point(89, 73);
      this.tbMargemLucro.Name = "tbMargemLucro";
      this.tbMargemLucro.ReadOnly = true;
      this.tbMargemLucro.Size = new System.Drawing.Size(72, 21);
      this.tbMargemLucro.TabIndex = 1;
      this.tbMargemLucro.TabStop = false;
      this.tbMargemLucro.Leave += new System.EventHandler(this.tbMargemLucro_Leave);
      this.tbMargemLucro.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbMargemLucro_KeyPress);
      // 
      // label7
      // 
      this.label7.AutoSize = true;
      this.label7.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label7.Location = new System.Drawing.Point(25, 59);
      this.label7.Name = "label7";
      this.label7.Size = new System.Drawing.Size(60, 13);
      this.label7.TabIndex = 64;
      this.label7.Text = "Margem de";
      // 
      // tbPrecoCusto
      // 
      this.tbPrecoCusto.Location = new System.Drawing.Point(89, 26);
      this.tbPrecoCusto.Name = "tbPrecoCusto";
      this.tbPrecoCusto.ReadOnly = true;
      this.tbPrecoCusto.Size = new System.Drawing.Size(72, 21);
      this.tbPrecoCusto.TabIndex = 0;
      this.tbPrecoCusto.TabStop = false;
      this.tbPrecoCusto.Leave += new System.EventHandler(this.tbPrecoCusto_Leave);
      this.tbPrecoCusto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbPrecoCusto_KeyPress);
      // 
      // label5
      // 
      this.label5.AutoSize = true;
      this.label5.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label5.Location = new System.Drawing.Point(16, 29);
      this.label5.Name = "label5";
      this.label5.Size = new System.Drawing.Size(69, 13);
      this.label5.TabIndex = 62;
      this.label5.Text = "Preço Custo:";
      // 
      // gbEstoque
      // 
      this.gbEstoque.Controls.Add(this.tbEstoqueAtual);
      this.gbEstoque.Controls.Add(this.label16);
      this.gbEstoque.Controls.Add(this.groupBox3);
      this.gbEstoque.Controls.Add(this.tbEstoqueMinimo);
      this.gbEstoque.Controls.Add(this.label13);
      this.gbEstoque.Controls.Add(this.tbEstoqueInicial);
      this.gbEstoque.Controls.Add(this.label15);
      this.gbEstoque.Location = new System.Drawing.Point(6, 342);
      this.gbEstoque.Name = "gbEstoque";
      this.gbEstoque.Size = new System.Drawing.Size(680, 54);
      this.gbEstoque.TabIndex = 9;
      this.gbEstoque.TabStop = false;
      this.gbEstoque.Text = "Estoque";
      // 
      // groupBox3
      // 
      this.groupBox3.Controls.Add(this.lblEstadoEstoque);
      this.groupBox3.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.groupBox3.Location = new System.Drawing.Point(514, 9);
      this.groupBox3.Name = "groupBox3";
      this.groupBox3.Size = new System.Drawing.Size(157, 38);
      this.groupBox3.TabIndex = 3;
      this.groupBox3.TabStop = false;
      this.groupBox3.Text = "Estado";
      // 
      // lblEstadoEstoque
      // 
      this.lblEstadoEstoque.AutoSize = true;
      this.lblEstadoEstoque.Font = new System.Drawing.Font("Arial Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lblEstadoEstoque.Location = new System.Drawing.Point(7, 14);
      this.lblEstadoEstoque.Name = "lblEstadoEstoque";
      this.lblEstadoEstoque.Size = new System.Drawing.Size(0, 18);
      this.lblEstadoEstoque.TabIndex = 0;
      // 
      // tbEstoqueMinimo
      // 
      this.tbEstoqueMinimo.Location = new System.Drawing.Point(262, 21);
      this.tbEstoqueMinimo.Name = "tbEstoqueMinimo";
      this.tbEstoqueMinimo.ReadOnly = true;
      this.tbEstoqueMinimo.Size = new System.Drawing.Size(72, 21);
      this.tbEstoqueMinimo.TabIndex = 2;
      this.tbEstoqueMinimo.TabStop = false;
      this.tbEstoqueMinimo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbEstoqueMinimo_KeyPress);
      // 
      // label13
      // 
      this.label13.AutoSize = true;
      this.label13.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label13.ForeColor = System.Drawing.SystemColors.ControlText;
      this.label13.Location = new System.Drawing.Point(211, 24);
      this.label13.Name = "label13";
      this.label13.Size = new System.Drawing.Size(43, 13);
      this.label13.TabIndex = 66;
      this.label13.Text = "Mínimo:";
      // 
      // tbEstoqueInicial
      // 
      this.tbEstoqueInicial.Enabled = false;
      this.tbEstoqueInicial.Location = new System.Drawing.Point(93, 21);
      this.tbEstoqueInicial.Name = "tbEstoqueInicial";
      this.tbEstoqueInicial.ReadOnly = true;
      this.tbEstoqueInicial.Size = new System.Drawing.Size(72, 21);
      this.tbEstoqueInicial.TabIndex = 0;
      this.tbEstoqueInicial.TabStop = false;
      // 
      // label15
      // 
      this.label15.AutoSize = true;
      this.label15.Enabled = false;
      this.label15.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label15.Location = new System.Drawing.Point(9, 24);
      this.label15.Name = "label15";
      this.label15.Size = new System.Drawing.Size(74, 13);
      this.label15.TabIndex = 62;
      this.label15.Text = "Mensal Inicial:";
      // 
      // gbFornecedor
      // 
      this.gbFornecedor.Controls.Add(this.btnConsultaFornecedor);
      this.gbFornecedor.Controls.Add(this.lblForn);
      this.gbFornecedor.Controls.Add(this.label6);
      this.gbFornecedor.Controls.Add(this.tbCodigoFornecedor);
      this.gbFornecedor.Controls.Add(this.groupBox1);
      this.gbFornecedor.Controls.Add(this.tbNomeFornecedor);
      this.gbFornecedor.Controls.Add(this.label10);
      this.gbFornecedor.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.gbFornecedor.Location = new System.Drawing.Point(6, 136);
      this.gbFornecedor.Name = "gbFornecedor";
      this.gbFornecedor.Size = new System.Drawing.Size(680, 78);
      this.gbFornecedor.TabIndex = 7;
      this.gbFornecedor.TabStop = false;
      this.gbFornecedor.Text = "Fornecedor";
      // 
      // btnConsultaFornecedor
      // 
      this.btnConsultaFornecedor.Cursor = System.Windows.Forms.Cursors.Hand;
      this.btnConsultaFornecedor.Enabled = false;
      this.btnConsultaFornecedor.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.btnConsultaFornecedor.Location = new System.Drawing.Point(142, 19);
      this.btnConsultaFornecedor.Name = "btnConsultaFornecedor";
      this.btnConsultaFornecedor.Size = new System.Drawing.Size(27, 22);
      this.btnConsultaFornecedor.TabIndex = 1;
      this.btnConsultaFornecedor.Text = "...";
      this.btnConsultaFornecedor.UseVisualStyleBackColor = true;
      this.btnConsultaFornecedor.Click += new System.EventHandler(this.btnConsultaFornecedor_Click);
      // 
      // lblForn
      // 
      this.lblForn.AutoSize = true;
      this.lblForn.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lblForn.Location = new System.Drawing.Point(164, 23);
      this.lblForn.Name = "lblForn";
      this.lblForn.Size = new System.Drawing.Size(0, 13);
      this.lblForn.TabIndex = 36;
      // 
      // label6
      // 
      this.label6.AutoSize = true;
      this.label6.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label6.Location = new System.Drawing.Point(36, 49);
      this.label6.Name = "label6";
      this.label6.Size = new System.Drawing.Size(38, 13);
      this.label6.TabIndex = 35;
      this.label6.Text = "Nome:";
      // 
      // tbCodigoFornecedor
      // 
      this.tbCodigoFornecedor.Location = new System.Drawing.Point(78, 20);
      this.tbCodigoFornecedor.Name = "tbCodigoFornecedor";
      this.tbCodigoFornecedor.ReadOnly = true;
      this.tbCodigoFornecedor.Size = new System.Drawing.Size(60, 21);
      this.tbCodigoFornecedor.TabIndex = 0;
      this.tbCodigoFornecedor.TabStop = false;
      this.tbCodigoFornecedor.Leave += new System.EventHandler(this.tbCodigoFornecedor_Leave);
      this.tbCodigoFornecedor.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbCodigoFornecedor_KeyPress);
      // 
      // groupBox1
      // 
      this.groupBox1.Controls.Add(this.tbUnidade);
      this.groupBox1.Controls.Add(this.cbxEmb);
      this.groupBox1.Controls.Add(this.label17);
      this.groupBox1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.groupBox1.Location = new System.Drawing.Point(517, 14);
      this.groupBox1.Name = "groupBox1";
      this.groupBox1.Size = new System.Drawing.Size(157, 54);
      this.groupBox1.TabIndex = 3;
      this.groupBox1.TabStop = false;
      this.groupBox1.Text = "Embalagem de Venda";
      // 
      // tbUnidade
      // 
      this.tbUnidade.Location = new System.Drawing.Point(95, 21);
      this.tbUnidade.Name = "tbUnidade";
      this.tbUnidade.ReadOnly = true;
      this.tbUnidade.Size = new System.Drawing.Size(43, 21);
      this.tbUnidade.TabIndex = 1;
      this.tbUnidade.TabStop = false;
      this.tbUnidade.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbCodigoProduto_KeyPress);
      // 
      // cbxEmb
      // 
      this.cbxEmb.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
      this.cbxEmb.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
      this.cbxEmb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
      this.cbxEmb.Enabled = false;
      this.cbxEmb.FormattingEnabled = true;
      this.cbxEmb.Items.AddRange(new object[] {
            "UN",
            "CX",
            "PC",
            "LT",
            "L"});
      this.cbxEmb.Location = new System.Drawing.Point(7, 21);
      this.cbxEmb.Name = "cbxEmb";
      this.cbxEmb.Size = new System.Drawing.Size(53, 21);
      this.cbxEmb.TabIndex = 0;
      this.cbxEmb.TabStop = false;
      this.cbxEmb.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cbUnidade_KeyPress);
      // 
      // label17
      // 
      this.label17.AutoSize = true;
      this.label17.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label17.Location = new System.Drawing.Point(64, 24);
      this.label17.Name = "label17";
      this.label17.Size = new System.Drawing.Size(29, 13);
      this.label17.TabIndex = 47;
      this.label17.Text = "UN.:";
      // 
      // tbNomeFornecedor
      // 
      this.tbNomeFornecedor.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
      this.tbNomeFornecedor.Location = new System.Drawing.Point(78, 46);
      this.tbNomeFornecedor.Name = "tbNomeFornecedor";
      this.tbNomeFornecedor.ReadOnly = true;
      this.tbNomeFornecedor.Size = new System.Drawing.Size(429, 21);
      this.tbNomeFornecedor.TabIndex = 2;
      this.tbNomeFornecedor.TabStop = false;
      // 
      // label10
      // 
      this.label10.AutoSize = true;
      this.label10.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label10.Location = new System.Drawing.Point(31, 23);
      this.label10.Name = "label10";
      this.label10.Size = new System.Drawing.Size(44, 13);
      this.label10.TabIndex = 34;
      this.label10.Text = "Código:";
      // 
      // butCancelar
      // 
      this.butCancelar.Cursor = System.Windows.Forms.Cursors.Hand;
      this.butCancelar.Enabled = false;
      this.butCancelar.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
      this.butCancelar.Location = new System.Drawing.Point(512, 418);
      this.butCancelar.Name = "butCancelar";
      this.butCancelar.Size = new System.Drawing.Size(86, 26);
      this.butCancelar.TabIndex = 6;
      this.butCancelar.Text = "Cancelar";
      this.butCancelar.UseVisualStyleBackColor = true;
      this.butCancelar.Click += new System.EventHandler(this.butCancelar_Click);
      // 
      // butAlterar
      // 
      this.butAlterar.Cursor = System.Windows.Forms.Cursors.Hand;
      this.butAlterar.Enabled = false;
      this.butAlterar.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
      this.butAlterar.Location = new System.Drawing.Point(312, 418);
      this.butAlterar.Name = "butAlterar";
      this.butAlterar.Size = new System.Drawing.Size(86, 26);
      this.butAlterar.TabIndex = 4;
      this.butAlterar.Text = "&Alterar";
      this.butAlterar.UseVisualStyleBackColor = true;
      this.butAlterar.Click += new System.EventHandler(this.butAlterar_Click);
      // 
      // butNovo
      // 
      this.butNovo.Cursor = System.Windows.Forms.Cursors.Hand;
      this.butNovo.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.butNovo.Location = new System.Drawing.Point(12, 418);
      this.butNovo.Name = "butNovo";
      this.butNovo.Size = new System.Drawing.Size(86, 26);
      this.butNovo.TabIndex = 1;
      this.butNovo.Text = "&Novo";
      this.butNovo.UseVisualStyleBackColor = true;
      this.butNovo.Click += new System.EventHandler(this.butNovo_Click_1);
      // 
      // butSalvar
      // 
      this.butSalvar.Cursor = System.Windows.Forms.Cursors.Hand;
      this.butSalvar.Enabled = false;
      this.butSalvar.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
      this.butSalvar.Location = new System.Drawing.Point(212, 418);
      this.butSalvar.Name = "butSalvar";
      this.butSalvar.Size = new System.Drawing.Size(86, 26);
      this.butSalvar.TabIndex = 3;
      this.butSalvar.Text = "&Salvar";
      this.butSalvar.UseVisualStyleBackColor = true;
      this.butSalvar.Click += new System.EventHandler(this.butSalvar_Click);
      // 
      // butExcluir
      // 
      this.butExcluir.Cursor = System.Windows.Forms.Cursors.Hand;
      this.butExcluir.Enabled = false;
      this.butExcluir.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
      this.butExcluir.Location = new System.Drawing.Point(412, 418);
      this.butExcluir.Name = "butExcluir";
      this.butExcluir.Size = new System.Drawing.Size(86, 26);
      this.butExcluir.TabIndex = 5;
      this.butExcluir.Text = "&Excluir";
      this.butExcluir.UseVisualStyleBackColor = true;
      this.butExcluir.Click += new System.EventHandler(this.butExcluir_Click);
      // 
      // butConsultar
      // 
      this.butConsultar.Cursor = System.Windows.Forms.Cursors.Hand;
      this.butConsultar.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.butConsultar.Location = new System.Drawing.Point(112, 418);
      this.butConsultar.Name = "butConsultar";
      this.butConsultar.Size = new System.Drawing.Size(86, 26);
      this.butConsultar.TabIndex = 2;
      this.butConsultar.Text = "Consultar";
      this.butConsultar.UseVisualStyleBackColor = true;
      this.butConsultar.Click += new System.EventHandler(this.butConsultar_Click);
      // 
      // butSair
      // 
      this.butSair.Cursor = System.Windows.Forms.Cursors.Hand;
      this.butSair.DialogResult = System.Windows.Forms.DialogResult.Cancel;
      this.butSair.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
      this.butSair.Location = new System.Drawing.Point(612, 418);
      this.butSair.Name = "butSair";
      this.butSair.Size = new System.Drawing.Size(86, 26);
      this.butSair.TabIndex = 7;
      this.butSair.Text = "Sair";
      this.butSair.UseVisualStyleBackColor = true;
      this.butSair.Click += new System.EventHandler(this.butSair_Click_1);
      // 
      // tbEstoqueAtual
      // 
      this.tbEstoqueAtual.Location = new System.Drawing.Point(408, 21);
      this.tbEstoqueAtual.Name = "tbEstoqueAtual";
      this.tbEstoqueAtual.ReadOnly = true;
      this.tbEstoqueAtual.Size = new System.Drawing.Size(72, 21);
      this.tbEstoqueAtual.TabIndex = 67;
      this.tbEstoqueAtual.TabStop = false;
      this.tbEstoqueAtual.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbCodigoProduto_KeyPress);
      // 
      // label16
      // 
      this.label16.AutoSize = true;
      this.label16.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label16.ForeColor = System.Drawing.SystemColors.ControlText;
      this.label16.Location = new System.Drawing.Point(355, 24);
      this.label16.Name = "label16";
      this.label16.Size = new System.Drawing.Size(47, 13);
      this.label16.TabIndex = 68;
      this.label16.Text = "ATUAL:";
      // 
      // FormCadProdutos
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.CancelButton = this.butSair;
      this.ClientSize = new System.Drawing.Size(717, 450);
      this.Controls.Add(this.butCancelar);
      this.Controls.Add(this.butAlterar);
      this.Controls.Add(this.butNovo);
      this.Controls.Add(this.butSalvar);
      this.Controls.Add(this.butExcluir);
      this.Controls.Add(this.butConsultar);
      this.Controls.Add(this.butSair);
      this.Controls.Add(this.gbProduto);
      this.Font = new System.Drawing.Font("Tahoma", 8.25F);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
      this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
      this.KeyPreview = true;
      this.MaximizeBox = false;
      this.Name = "FormCadProdutos";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "Cadastro de Produtos";
      this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FormCadProdutos_KeyDown);
      ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
      this.gbProduto.ResumeLayout(false);
      this.gbProduto.PerformLayout();
      this.groupBox2.ResumeLayout(false);
      this.gbPrecos.ResumeLayout(false);
      this.gbPrecos.PerformLayout();
      this.gbEstoque.ResumeLayout(false);
      this.gbEstoque.PerformLayout();
      this.groupBox3.ResumeLayout(false);
      this.groupBox3.PerformLayout();
      this.gbFornecedor.ResumeLayout(false);
      this.gbFornecedor.PerformLayout();
      this.groupBox1.ResumeLayout(false);
      this.groupBox1.PerformLayout();
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Label labNome;
    private System.Windows.Forms.PictureBox pictureBox1;
    private System.Windows.Forms.Label labApelidoNFantasia;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.Label label4;
    private System.Windows.Forms.GroupBox gbProduto;
    private System.Windows.Forms.GroupBox gbFornecedor;
    private System.Windows.Forms.Label label10;
    private System.Windows.Forms.Label label15;
    private System.Windows.Forms.GroupBox gbEstoque;
    private System.Windows.Forms.GroupBox gbPrecos;
    private System.Windows.Forms.Label label14;
    private System.Windows.Forms.Label label12;
    private System.Windows.Forms.Label label11;
    private System.Windows.Forms.Label label9;
    private System.Windows.Forms.Label label8;
    private System.Windows.Forms.Label label7;
    private System.Windows.Forms.Label label5;
    private System.Windows.Forms.Label label6;
    private System.Windows.Forms.Label label13;
    public System.Windows.Forms.Button butCancelar;
    public System.Windows.Forms.Button butAlterar;
    public System.Windows.Forms.Button butNovo;
    public System.Windows.Forms.Button butSalvar;
    public System.Windows.Forms.Button butExcluir;
    public System.Windows.Forms.Button butConsultar;
    public System.Windows.Forms.Button butSair;
    public System.Windows.Forms.TextBox tbCodigoProduto;
    public System.Windows.Forms.TextBox tbDescProduto;
    public System.Windows.Forms.TextBox tbDescResumida;
    public System.Windows.Forms.TextBox tbMarcaProduto;
    public System.Windows.Forms.TextBox tbCodigoFornecedor;
    public System.Windows.Forms.TextBox tbNomeFornecedor;
    public System.Windows.Forms.ComboBox cbxEmb;
    public System.Windows.Forms.TextBox tbEstoqueInicial;
    public System.Windows.Forms.TextBox tbPrecoSugerido;
    public System.Windows.Forms.TextBox tbMargemReal;
    public System.Windows.Forms.TextBox tbPrecoVenda;
    public System.Windows.Forms.TextBox tbMargemLucro;
    public System.Windows.Forms.TextBox tbPrecoCusto;
    public System.Windows.Forms.TextBox tbEstoqueMinimo;
    public System.Windows.Forms.MaskedTextBox tbEan13;
    private System.Windows.Forms.Label lblForn;
    private System.Windows.Forms.GroupBox groupBox1;
    private System.Windows.Forms.Label label17;
    public System.Windows.Forms.TextBox tbUnidade;
    private System.Windows.Forms.Button btnConsultaGeral;
    private System.Windows.Forms.GroupBox groupBox2;
    public System.Windows.Forms.ComboBox cbxSituacao;
    private System.Windows.Forms.GroupBox groupBox3;
    private System.Windows.Forms.Button btnConsultaFornecedor;
    public System.Windows.Forms.Label lblEstadoEstoque;
    public System.Windows.Forms.Button butEans;
    public System.Windows.Forms.Button butReferencias;
    public System.Windows.Forms.TextBox tbEstoqueAtual;
    private System.Windows.Forms.Label label16;
  }
}