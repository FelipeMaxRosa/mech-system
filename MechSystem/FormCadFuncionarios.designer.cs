namespace MechSystem
{
  partial class FormCadFuncionarios
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCadFuncionarios));
      this.butSalvar = new System.Windows.Forms.Button();
      this.butExcluir = new System.Windows.Forms.Button();
      this.butNovo = new System.Windows.Forms.Button();
      this.butConsultar = new System.Windows.Forms.Button();
      this.butAlterar = new System.Windows.Forms.Button();
      this.butSair = new System.Windows.Forms.Button();
      this.butCancelar = new System.Windows.Forms.Button();
      this.label1 = new System.Windows.Forms.Label();
      this.tbCodigoFuncionario = new System.Windows.Forms.TextBox();
      this.labNome = new System.Windows.Forms.Label();
      this.tbNome = new System.Windows.Forms.TextBox();
      this.labRgIe = new System.Windows.Forms.Label();
      this.tbRgIe = new System.Windows.Forms.TextBox();
      this.labCpfCnpj = new System.Windows.Forms.Label();
      this.label5 = new System.Windows.Forms.Label();
      this.label6 = new System.Windows.Forms.Label();
      this.tbEndereco = new System.Windows.Forms.TextBox();
      this.label9 = new System.Windows.Forms.Label();
      this.tbBairro = new System.Windows.Forms.TextBox();
      this.label7 = new System.Windows.Forms.Label();
      this.label8 = new System.Windows.Forms.Label();
      this.tbNumero = new System.Windows.Forms.TextBox();
      this.tbCidade = new System.Windows.Forms.TextBox();
      this.label10 = new System.Windows.Forms.Label();
      this.tbEstado = new System.Windows.Forms.TextBox();
      this.pictureBox1 = new System.Windows.Forms.PictureBox();
      this.lblDataNasc = new System.Windows.Forms.Label();
      this.label15 = new System.Windows.Forms.Label();
      this.label3 = new System.Windows.Forms.Label();
      this.labApelidoNFantasia = new System.Windows.Forms.Label();
      this.tbCep = new System.Windows.Forms.MaskedTextBox();
      this.tbTelefone1 = new System.Windows.Forms.MaskedTextBox();
      this.tbCelular = new System.Windows.Forms.MaskedTextBox();
      this.tbCpfCnpj = new System.Windows.Forms.MaskedTextBox();
      this.dtNascimento = new System.Windows.Forms.DateTimePicker();
      this.cbxFuncao = new System.Windows.Forms.ComboBox();
      this.label4 = new System.Windows.Forms.Label();
      this.dtAdmissao = new System.Windows.Forms.DateTimePicker();
      this.label11 = new System.Windows.Forms.Label();
      this.tbSalario = new System.Windows.Forms.TextBox();
      this.btnConsultaGeral = new System.Windows.Forms.Button();
      this.gbClientes = new System.Windows.Forms.GroupBox();
      ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
      this.gbClientes.SuspendLayout();
      this.SuspendLayout();
      // 
      // butSalvar
      // 
      this.butSalvar.Cursor = System.Windows.Forms.Cursors.Hand;
      this.butSalvar.Enabled = false;
      this.butSalvar.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
      this.butSalvar.Location = new System.Drawing.Point(212, 327);
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
      this.butExcluir.Location = new System.Drawing.Point(412, 327);
      this.butExcluir.Name = "butExcluir";
      this.butExcluir.Size = new System.Drawing.Size(86, 26);
      this.butExcluir.TabIndex = 5;
      this.butExcluir.Text = "Excluir";
      this.butExcluir.UseVisualStyleBackColor = true;
      this.butExcluir.Click += new System.EventHandler(this.butExcluir_Click);
      // 
      // butNovo
      // 
      this.butNovo.Cursor = System.Windows.Forms.Cursors.Hand;
      this.butNovo.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
      this.butNovo.Location = new System.Drawing.Point(12, 327);
      this.butNovo.Name = "butNovo";
      this.butNovo.Size = new System.Drawing.Size(86, 26);
      this.butNovo.TabIndex = 1;
      this.butNovo.Text = "Novo";
      this.butNovo.UseVisualStyleBackColor = true;
      this.butNovo.Click += new System.EventHandler(this.butNovo_Click);
      // 
      // butConsultar
      // 
      this.butConsultar.Cursor = System.Windows.Forms.Cursors.Hand;
      this.butConsultar.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
      this.butConsultar.Location = new System.Drawing.Point(112, 327);
      this.butConsultar.Name = "butConsultar";
      this.butConsultar.Size = new System.Drawing.Size(86, 26);
      this.butConsultar.TabIndex = 2;
      this.butConsultar.Text = "Consultar";
      this.butConsultar.UseVisualStyleBackColor = true;
      this.butConsultar.Click += new System.EventHandler(this.butConsultar_Click);
      // 
      // butAlterar
      // 
      this.butAlterar.Cursor = System.Windows.Forms.Cursors.Hand;
      this.butAlterar.Enabled = false;
      this.butAlterar.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
      this.butAlterar.Location = new System.Drawing.Point(312, 327);
      this.butAlterar.Name = "butAlterar";
      this.butAlterar.Size = new System.Drawing.Size(86, 26);
      this.butAlterar.TabIndex = 4;
      this.butAlterar.Text = "Alterar";
      this.butAlterar.UseVisualStyleBackColor = true;
      this.butAlterar.Click += new System.EventHandler(this.butAlterar_Click);
      // 
      // butSair
      // 
      this.butSair.Cursor = System.Windows.Forms.Cursors.Hand;
      this.butSair.DialogResult = System.Windows.Forms.DialogResult.Cancel;
      this.butSair.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
      this.butSair.Location = new System.Drawing.Point(612, 327);
      this.butSair.Name = "butSair";
      this.butSair.Size = new System.Drawing.Size(86, 26);
      this.butSair.TabIndex = 7;
      this.butSair.Text = "Sair";
      this.butSair.UseVisualStyleBackColor = true;
      this.butSair.Click += new System.EventHandler(this.butSair_Click);
      // 
      // butCancelar
      // 
      this.butCancelar.Cursor = System.Windows.Forms.Cursors.Hand;
      this.butCancelar.Enabled = false;
      this.butCancelar.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
      this.butCancelar.Location = new System.Drawing.Point(512, 327);
      this.butCancelar.Name = "butCancelar";
      this.butCancelar.Size = new System.Drawing.Size(86, 26);
      this.butCancelar.TabIndex = 6;
      this.butCancelar.Text = "Cancelar";
      this.butCancelar.UseVisualStyleBackColor = true;
      this.butCancelar.Click += new System.EventHandler(this.butCancelar_Click);
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label1.Location = new System.Drawing.Point(37, 24);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(44, 13);
      this.label1.TabIndex = 0;
      this.label1.Text = "Código:";
      // 
      // tbCodigoFuncionario
      // 
      this.tbCodigoFuncionario.Location = new System.Drawing.Point(84, 21);
      this.tbCodigoFuncionario.Name = "tbCodigoFuncionario";
      this.tbCodigoFuncionario.Size = new System.Drawing.Size(58, 21);
      this.tbCodigoFuncionario.TabIndex = 0;
      this.tbCodigoFuncionario.Leave += new System.EventHandler(this.tbCodigoFuncionario_Leave);
      this.tbCodigoFuncionario.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbCodigoFuncionario_KeyPress);
      this.tbCodigoFuncionario.Enter += new System.EventHandler(this.tbCodigoFuncionario_Enter);
      // 
      // labNome
      // 
      this.labNome.AutoSize = true;
      this.labNome.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.labNome.Location = new System.Drawing.Point(43, 52);
      this.labNome.Name = "labNome";
      this.labNome.Size = new System.Drawing.Size(38, 13);
      this.labNome.TabIndex = 4;
      this.labNome.Text = "Nome:";
      // 
      // tbNome
      // 
      this.tbNome.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
      this.tbNome.Location = new System.Drawing.Point(84, 49);
      this.tbNome.MaxLength = 50;
      this.tbNome.Name = "tbNome";
      this.tbNome.ReadOnly = true;
      this.tbNome.Size = new System.Drawing.Size(402, 21);
      this.tbNome.TabIndex = 2;
      this.tbNome.TabStop = false;
      this.tbNome.Leave += new System.EventHandler(this.tbNome_Leave);
      // 
      // labRgIe
      // 
      this.labRgIe.AutoSize = true;
      this.labRgIe.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.labRgIe.Location = new System.Drawing.Point(56, 108);
      this.labRgIe.Name = "labRgIe";
      this.labRgIe.Size = new System.Drawing.Size(25, 13);
      this.labRgIe.TabIndex = 6;
      this.labRgIe.Text = "RG:";
      // 
      // tbRgIe
      // 
      this.tbRgIe.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
      this.tbRgIe.Location = new System.Drawing.Point(84, 105);
      this.tbRgIe.MaxLength = 12;
      this.tbRgIe.Name = "tbRgIe";
      this.tbRgIe.ReadOnly = true;
      this.tbRgIe.Size = new System.Drawing.Size(120, 21);
      this.tbRgIe.TabIndex = 4;
      this.tbRgIe.TabStop = false;
      this.tbRgIe.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbRgIe_KeyPress);
      // 
      // labCpfCnpj
      // 
      this.labCpfCnpj.AutoSize = true;
      this.labCpfCnpj.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.labCpfCnpj.Location = new System.Drawing.Point(221, 108);
      this.labCpfCnpj.Name = "labCpfCnpj";
      this.labCpfCnpj.Size = new System.Drawing.Size(30, 13);
      this.labCpfCnpj.TabIndex = 8;
      this.labCpfCnpj.Text = "CPF:";
      // 
      // label5
      // 
      this.label5.AutoSize = true;
      this.label5.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label5.Location = new System.Drawing.Point(51, 138);
      this.label5.Name = "label5";
      this.label5.Size = new System.Drawing.Size(30, 13);
      this.label5.TabIndex = 10;
      this.label5.Text = "CEP:";
      // 
      // label6
      // 
      this.label6.AutoSize = true;
      this.label6.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label6.Location = new System.Drawing.Point(25, 166);
      this.label6.Name = "label6";
      this.label6.Size = new System.Drawing.Size(56, 13);
      this.label6.TabIndex = 12;
      this.label6.Text = "Endereço:";
      // 
      // tbEndereco
      // 
      this.tbEndereco.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
      this.tbEndereco.Location = new System.Drawing.Point(84, 163);
      this.tbEndereco.MaxLength = 45;
      this.tbEndereco.Name = "tbEndereco";
      this.tbEndereco.ReadOnly = true;
      this.tbEndereco.Size = new System.Drawing.Size(353, 21);
      this.tbEndereco.TabIndex = 7;
      this.tbEndereco.TabStop = false;
      // 
      // label9
      // 
      this.label9.AutoSize = true;
      this.label9.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label9.Location = new System.Drawing.Point(42, 194);
      this.label9.Name = "label9";
      this.label9.Size = new System.Drawing.Size(39, 13);
      this.label9.TabIndex = 10;
      this.label9.Text = "Bairro:";
      // 
      // tbBairro
      // 
      this.tbBairro.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
      this.tbBairro.Location = new System.Drawing.Point(84, 191);
      this.tbBairro.MaxLength = 45;
      this.tbBairro.Name = "tbBairro";
      this.tbBairro.ReadOnly = true;
      this.tbBairro.Size = new System.Drawing.Size(183, 21);
      this.tbBairro.TabIndex = 9;
      this.tbBairro.TabStop = false;
      // 
      // label7
      // 
      this.label7.AutoSize = true;
      this.label7.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label7.Location = new System.Drawing.Point(444, 166);
      this.label7.Name = "label7";
      this.label7.Size = new System.Drawing.Size(48, 13);
      this.label7.TabIndex = 14;
      this.label7.Text = "Número:";
      // 
      // label8
      // 
      this.label8.AutoSize = true;
      this.label8.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label8.Location = new System.Drawing.Point(271, 194);
      this.label8.Name = "label8";
      this.label8.Size = new System.Drawing.Size(44, 13);
      this.label8.TabIndex = 12;
      this.label8.Text = "Cidade:";
      // 
      // tbNumero
      // 
      this.tbNumero.Location = new System.Drawing.Point(501, 163);
      this.tbNumero.MaxLength = 10;
      this.tbNumero.Name = "tbNumero";
      this.tbNumero.ReadOnly = true;
      this.tbNumero.Size = new System.Drawing.Size(66, 21);
      this.tbNumero.TabIndex = 8;
      this.tbNumero.TabStop = false;
      this.tbNumero.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbNumero_KeyPress);
      // 
      // tbCidade
      // 
      this.tbCidade.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
      this.tbCidade.Location = new System.Drawing.Point(319, 191);
      this.tbCidade.MaxLength = 45;
      this.tbCidade.Name = "tbCidade";
      this.tbCidade.ReadOnly = true;
      this.tbCidade.Size = new System.Drawing.Size(175, 21);
      this.tbCidade.TabIndex = 10;
      this.tbCidade.TabStop = false;
      // 
      // label10
      // 
      this.label10.AutoSize = true;
      this.label10.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label10.Location = new System.Drawing.Point(498, 194);
      this.label10.Name = "label10";
      this.label10.Size = new System.Drawing.Size(24, 13);
      this.label10.TabIndex = 16;
      this.label10.Text = "UF:";
      // 
      // tbEstado
      // 
      this.tbEstado.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
      this.tbEstado.Location = new System.Drawing.Point(529, 191);
      this.tbEstado.MaxLength = 2;
      this.tbEstado.Name = "tbEstado";
      this.tbEstado.ReadOnly = true;
      this.tbEstado.Size = new System.Drawing.Size(38, 21);
      this.tbEstado.TabIndex = 11;
      this.tbEstado.TabStop = false;
      this.tbEstado.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbEstado_KeyPress);
      // 
      // pictureBox1
      // 
      this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
      this.pictureBox1.Location = new System.Drawing.Point(556, 24);
      this.pictureBox1.Name = "pictureBox1";
      this.pictureBox1.Size = new System.Drawing.Size(111, 103);
      this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
      this.pictureBox1.TabIndex = 18;
      this.pictureBox1.TabStop = false;
      // 
      // lblDataNasc
      // 
      this.lblDataNasc.AutoSize = true;
      this.lblDataNasc.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lblDataNasc.Location = new System.Drawing.Point(17, 223);
      this.lblDataNasc.Name = "lblDataNasc";
      this.lblDataNasc.Size = new System.Drawing.Size(64, 13);
      this.lblDataNasc.TabIndex = 19;
      this.lblDataNasc.Text = "Data Nasc.:";
      // 
      // label15
      // 
      this.label15.AutoSize = true;
      this.label15.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label15.Location = new System.Drawing.Point(28, 280);
      this.label15.Name = "label15";
      this.label15.Size = new System.Drawing.Size(53, 13);
      this.label15.TabIndex = 31;
      this.label15.Text = "Telefone:";
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label3.Location = new System.Drawing.Point(217, 280);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(44, 13);
      this.label3.TabIndex = 33;
      this.label3.Text = "Celular:";
      // 
      // labApelidoNFantasia
      // 
      this.labApelidoNFantasia.AutoSize = true;
      this.labApelidoNFantasia.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.labApelidoNFantasia.Location = new System.Drawing.Point(35, 80);
      this.labApelidoNFantasia.Name = "labApelidoNFantasia";
      this.labApelidoNFantasia.Size = new System.Drawing.Size(46, 13);
      this.labApelidoNFantasia.TabIndex = 30;
      this.labApelidoNFantasia.Text = "Função:";
      // 
      // tbCep
      // 
      this.tbCep.Location = new System.Drawing.Point(84, 135);
      this.tbCep.Mask = "00000-999";
      this.tbCep.Name = "tbCep";
      this.tbCep.PromptChar = ' ';
      this.tbCep.ReadOnly = true;
      this.tbCep.Size = new System.Drawing.Size(100, 21);
      this.tbCep.TabIndex = 6;
      this.tbCep.TabStop = false;
      // 
      // tbTelefone1
      // 
      this.tbTelefone1.Location = new System.Drawing.Point(84, 277);
      this.tbTelefone1.Mask = "(00)0000-0000";
      this.tbTelefone1.Name = "tbTelefone1";
      this.tbTelefone1.PromptChar = ' ';
      this.tbTelefone1.ReadOnly = true;
      this.tbTelefone1.Size = new System.Drawing.Size(120, 21);
      this.tbTelefone1.TabIndex = 15;
      this.tbTelefone1.TabStop = false;
      // 
      // tbCelular
      // 
      this.tbCelular.Location = new System.Drawing.Point(266, 277);
      this.tbCelular.Mask = "(99)0000-0000";
      this.tbCelular.Name = "tbCelular";
      this.tbCelular.PromptChar = ' ';
      this.tbCelular.ReadOnly = true;
      this.tbCelular.Size = new System.Drawing.Size(120, 21);
      this.tbCelular.TabIndex = 16;
      this.tbCelular.TabStop = false;
      // 
      // tbCpfCnpj
      // 
      this.tbCpfCnpj.Location = new System.Drawing.Point(255, 105);
      this.tbCpfCnpj.Mask = "000,000,000-00";
      this.tbCpfCnpj.Name = "tbCpfCnpj";
      this.tbCpfCnpj.PromptChar = ' ';
      this.tbCpfCnpj.ReadOnly = true;
      this.tbCpfCnpj.Size = new System.Drawing.Size(142, 21);
      this.tbCpfCnpj.TabIndex = 5;
      this.tbCpfCnpj.TabStop = false;
      this.tbCpfCnpj.Leave += new System.EventHandler(this.tbCpfCnpj_Leave);
      // 
      // dtNascimento
      // 
      this.dtNascimento.Enabled = false;
      this.dtNascimento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
      this.dtNascimento.Location = new System.Drawing.Point(84, 219);
      this.dtNascimento.Name = "dtNascimento";
      this.dtNascimento.Size = new System.Drawing.Size(109, 21);
      this.dtNascimento.TabIndex = 12;
      this.dtNascimento.TabStop = false;
      this.dtNascimento.Value = new System.DateTime(1900, 1, 1, 19, 37, 0, 0);
      // 
      // cbxFuncao
      // 
      this.cbxFuncao.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
      this.cbxFuncao.Enabled = false;
      this.cbxFuncao.FormattingEnabled = true;
      this.cbxFuncao.Location = new System.Drawing.Point(84, 77);
      this.cbxFuncao.Name = "cbxFuncao";
      this.cbxFuncao.Size = new System.Drawing.Size(167, 21);
      this.cbxFuncao.TabIndex = 3;
      // 
      // label4
      // 
      this.label4.AutoSize = true;
      this.label4.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label4.Location = new System.Drawing.Point(215, 223);
      this.label4.Name = "label4";
      this.label4.Size = new System.Drawing.Size(82, 13);
      this.label4.TabIndex = 38;
      this.label4.Text = "Data Admissão:";
      // 
      // dtAdmissao
      // 
      this.dtAdmissao.Enabled = false;
      this.dtAdmissao.Format = System.Windows.Forms.DateTimePickerFormat.Short;
      this.dtAdmissao.Location = new System.Drawing.Point(303, 219);
      this.dtAdmissao.Name = "dtAdmissao";
      this.dtAdmissao.Size = new System.Drawing.Size(109, 21);
      this.dtAdmissao.TabIndex = 13;
      this.dtAdmissao.TabStop = false;
      this.dtAdmissao.Value = new System.DateTime(1900, 1, 1, 19, 37, 0, 0);
      // 
      // label11
      // 
      this.label11.AutoSize = true;
      this.label11.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label11.Location = new System.Drawing.Point(14, 250);
      this.label11.Name = "label11";
      this.label11.Size = new System.Drawing.Size(67, 13);
      this.label11.TabIndex = 39;
      this.label11.Text = "Salário (R$):";
      // 
      // tbSalario
      // 
      this.tbSalario.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
      this.tbSalario.Location = new System.Drawing.Point(84, 247);
      this.tbSalario.MaxLength = 45;
      this.tbSalario.Name = "tbSalario";
      this.tbSalario.ReadOnly = true;
      this.tbSalario.Size = new System.Drawing.Size(120, 21);
      this.tbSalario.TabIndex = 14;
      this.tbSalario.TabStop = false;
      this.tbSalario.Leave += new System.EventHandler(this.tbSalario_Leave);
      this.tbSalario.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbSalario_KeyPress);
      // 
      // btnConsultaGeral
      // 
      this.btnConsultaGeral.Cursor = System.Windows.Forms.Cursors.Hand;
      this.btnConsultaGeral.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.btnConsultaGeral.Location = new System.Drawing.Point(148, 20);
      this.btnConsultaGeral.Name = "btnConsultaGeral";
      this.btnConsultaGeral.Size = new System.Drawing.Size(27, 22);
      this.btnConsultaGeral.TabIndex = 1;
      this.btnConsultaGeral.Text = "...";
      this.btnConsultaGeral.UseVisualStyleBackColor = true;
      this.btnConsultaGeral.Click += new System.EventHandler(this.btnConsultaGeral_Click);
      // 
      // gbClientes
      // 
      this.gbClientes.Controls.Add(this.btnConsultaGeral);
      this.gbClientes.Controls.Add(this.tbSalario);
      this.gbClientes.Controls.Add(this.label11);
      this.gbClientes.Controls.Add(this.dtAdmissao);
      this.gbClientes.Controls.Add(this.label4);
      this.gbClientes.Controls.Add(this.cbxFuncao);
      this.gbClientes.Controls.Add(this.dtNascimento);
      this.gbClientes.Controls.Add(this.tbCpfCnpj);
      this.gbClientes.Controls.Add(this.tbCelular);
      this.gbClientes.Controls.Add(this.tbTelefone1);
      this.gbClientes.Controls.Add(this.tbCep);
      this.gbClientes.Controls.Add(this.labApelidoNFantasia);
      this.gbClientes.Controls.Add(this.label3);
      this.gbClientes.Controls.Add(this.label15);
      this.gbClientes.Controls.Add(this.lblDataNasc);
      this.gbClientes.Controls.Add(this.pictureBox1);
      this.gbClientes.Controls.Add(this.tbEstado);
      this.gbClientes.Controls.Add(this.label10);
      this.gbClientes.Controls.Add(this.tbCidade);
      this.gbClientes.Controls.Add(this.tbNumero);
      this.gbClientes.Controls.Add(this.label8);
      this.gbClientes.Controls.Add(this.label7);
      this.gbClientes.Controls.Add(this.tbBairro);
      this.gbClientes.Controls.Add(this.label9);
      this.gbClientes.Controls.Add(this.tbEndereco);
      this.gbClientes.Controls.Add(this.label6);
      this.gbClientes.Controls.Add(this.label5);
      this.gbClientes.Controls.Add(this.labCpfCnpj);
      this.gbClientes.Controls.Add(this.tbRgIe);
      this.gbClientes.Controls.Add(this.labRgIe);
      this.gbClientes.Controls.Add(this.tbNome);
      this.gbClientes.Controls.Add(this.labNome);
      this.gbClientes.Controls.Add(this.tbCodigoFuncionario);
      this.gbClientes.Controls.Add(this.label1);
      this.gbClientes.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.gbClientes.Location = new System.Drawing.Point(12, 9);
      this.gbClientes.Name = "gbClientes";
      this.gbClientes.Size = new System.Drawing.Size(686, 311);
      this.gbClientes.TabIndex = 0;
      this.gbClientes.TabStop = false;
      this.gbClientes.Text = "Dados do Funcionário";
      // 
      // FormCadFuncionarios
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.CancelButton = this.butSair;
      this.ClientSize = new System.Drawing.Size(711, 360);
      this.Controls.Add(this.gbClientes);
      this.Controls.Add(this.butSalvar);
      this.Controls.Add(this.butExcluir);
      this.Controls.Add(this.butNovo);
      this.Controls.Add(this.butConsultar);
      this.Controls.Add(this.butAlterar);
      this.Controls.Add(this.butSair);
      this.Controls.Add(this.butCancelar);
      this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
      this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
      this.KeyPreview = true;
      this.MinimizeBox = false;
      this.Name = "FormCadFuncionarios";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "Cadastro de Funcionários";
      this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FormCadFuncionarios_KeyDown);
      ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
      this.gbClientes.ResumeLayout(false);
      this.gbClientes.PerformLayout();
      this.ResumeLayout(false);

    }

    #endregion

    public System.Windows.Forms.Button butExcluir;
    private System.Windows.Forms.Button butConsultar;
    public System.Windows.Forms.Button butAlterar;
    private System.Windows.Forms.Button butSair;
    private System.Windows.Forms.Button butCancelar;
    public System.Windows.Forms.Button butSalvar;
    private System.Windows.Forms.Label label1;
    public System.Windows.Forms.TextBox tbCodigoFuncionario;
    private System.Windows.Forms.Label labNome;
    public System.Windows.Forms.TextBox tbNome;
    private System.Windows.Forms.Label labRgIe;
    public System.Windows.Forms.TextBox tbRgIe;
    private System.Windows.Forms.Label labCpfCnpj;
    private System.Windows.Forms.Label label5;
    private System.Windows.Forms.Label label6;
    public System.Windows.Forms.TextBox tbEndereco;
    private System.Windows.Forms.Label label9;
    public System.Windows.Forms.TextBox tbBairro;
    private System.Windows.Forms.Label label7;
    private System.Windows.Forms.Label label8;
    public System.Windows.Forms.TextBox tbNumero;
    public System.Windows.Forms.TextBox tbCidade;
    private System.Windows.Forms.Label label10;
    public System.Windows.Forms.TextBox tbEstado;
    private System.Windows.Forms.PictureBox pictureBox1;
    private System.Windows.Forms.Label lblDataNasc;
    private System.Windows.Forms.Label label15;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.Label labApelidoNFantasia;
    public System.Windows.Forms.MaskedTextBox tbCep;
    public System.Windows.Forms.MaskedTextBox tbTelefone1;
    public System.Windows.Forms.MaskedTextBox tbCelular;
    public System.Windows.Forms.MaskedTextBox tbCpfCnpj;
    public System.Windows.Forms.DateTimePicker dtNascimento;
    public System.Windows.Forms.ComboBox cbxFuncao;
    private System.Windows.Forms.Label label4;
    public System.Windows.Forms.DateTimePicker dtAdmissao;
    private System.Windows.Forms.Label label11;
    public System.Windows.Forms.TextBox tbSalario;
    private System.Windows.Forms.Button btnConsultaGeral;
    private System.Windows.Forms.GroupBox gbClientes;
    public System.Windows.Forms.Button butNovo;

  }
}