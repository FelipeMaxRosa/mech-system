namespace MechSystem
{
  partial class FormCadUsuarios
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCadUsuarios));
      this.butSalvar = new System.Windows.Forms.Button();
      this.butExcluir = new System.Windows.Forms.Button();
      this.butNovo = new System.Windows.Forms.Button();
      this.butConsultar = new System.Windows.Forms.Button();
      this.butAlterar = new System.Windows.Forms.Button();
      this.butSair = new System.Windows.Forms.Button();
      this.butCancelar = new System.Windows.Forms.Button();
      this.groupBox1 = new System.Windows.Forms.GroupBox();
      this.groupBox2 = new System.Windows.Forms.GroupBox();
      this.cbxPerfil = new System.Windows.Forms.ComboBox();
      this.btnConsultaGeral = new System.Windows.Forms.Button();
      this.chkMostraCaracteres = new System.Windows.Forms.CheckBox();
      this.lblSenha = new System.Windows.Forms.Label();
      this.tbSenhaC = new System.Windows.Forms.TextBox();
      this.label3 = new System.Windows.Forms.Label();
      this.tbSenha = new System.Windows.Forms.TextBox();
      this.label2 = new System.Windows.Forms.Label();
      this.pictureBox1 = new System.Windows.Forms.PictureBox();
      this.tbLogin = new System.Windows.Forms.TextBox();
      this.labNome = new System.Windows.Forms.Label();
      this.tbCodigo = new System.Windows.Forms.TextBox();
      this.label1 = new System.Windows.Forms.Label();
      this.groupBox1.SuspendLayout();
      this.groupBox2.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
      this.SuspendLayout();
      // 
      // butSalvar
      // 
      this.butSalvar.Cursor = System.Windows.Forms.Cursors.Hand;
      this.butSalvar.Enabled = false;
      this.butSalvar.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.butSalvar.Location = new System.Drawing.Point(212, 189);
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
      this.butExcluir.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.butExcluir.Location = new System.Drawing.Point(412, 189);
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
      this.butNovo.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.butNovo.Location = new System.Drawing.Point(12, 189);
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
      this.butConsultar.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.butConsultar.Location = new System.Drawing.Point(112, 189);
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
      this.butAlterar.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.butAlterar.Location = new System.Drawing.Point(311, 189);
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
      this.butSair.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.butSair.Location = new System.Drawing.Point(612, 189);
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
      this.butCancelar.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.butCancelar.Location = new System.Drawing.Point(512, 189);
      this.butCancelar.Name = "butCancelar";
      this.butCancelar.Size = new System.Drawing.Size(86, 26);
      this.butCancelar.TabIndex = 6;
      this.butCancelar.Text = "Cancelar";
      this.butCancelar.UseVisualStyleBackColor = true;
      this.butCancelar.Click += new System.EventHandler(this.butCancelar_Click);
      // 
      // groupBox1
      // 
      this.groupBox1.Controls.Add(this.groupBox2);
      this.groupBox1.Controls.Add(this.btnConsultaGeral);
      this.groupBox1.Controls.Add(this.chkMostraCaracteres);
      this.groupBox1.Controls.Add(this.lblSenha);
      this.groupBox1.Controls.Add(this.tbSenhaC);
      this.groupBox1.Controls.Add(this.label3);
      this.groupBox1.Controls.Add(this.tbSenha);
      this.groupBox1.Controls.Add(this.label2);
      this.groupBox1.Controls.Add(this.pictureBox1);
      this.groupBox1.Controls.Add(this.tbLogin);
      this.groupBox1.Controls.Add(this.labNome);
      this.groupBox1.Controls.Add(this.tbCodigo);
      this.groupBox1.Controls.Add(this.label1);
      this.groupBox1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.groupBox1.Location = new System.Drawing.Point(12, 9);
      this.groupBox1.Name = "groupBox1";
      this.groupBox1.Size = new System.Drawing.Size(686, 174);
      this.groupBox1.TabIndex = 0;
      this.groupBox1.TabStop = false;
      this.groupBox1.Text = "Dados do Usuário";
      // 
      // groupBox2
      // 
      this.groupBox2.Controls.Add(this.cbxPerfil);
      this.groupBox2.Location = new System.Drawing.Point(299, 24);
      this.groupBox2.Name = "groupBox2";
      this.groupBox2.Size = new System.Drawing.Size(179, 45);
      this.groupBox2.TabIndex = 2;
      this.groupBox2.TabStop = false;
      this.groupBox2.Text = "Perfil";
      // 
      // cbxPerfil
      // 
      this.cbxPerfil.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
      this.cbxPerfil.Enabled = false;
      this.cbxPerfil.FormattingEnabled = true;
      this.cbxPerfil.Items.AddRange(new object[] {
            "ADMINISTRADOR",
            "USUARIO"});
      this.cbxPerfil.Location = new System.Drawing.Point(6, 16);
      this.cbxPerfil.Name = "cbxPerfil";
      this.cbxPerfil.Size = new System.Drawing.Size(165, 21);
      this.cbxPerfil.TabIndex = 0;
      this.cbxPerfil.DropDownClosed += new System.EventHandler(this.cbxPerfil_DropDownClosed);
      // 
      // btnConsultaGeral
      // 
      this.btnConsultaGeral.Cursor = System.Windows.Forms.Cursors.Hand;
      this.btnConsultaGeral.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.btnConsultaGeral.Location = new System.Drawing.Point(180, 21);
      this.btnConsultaGeral.Name = "btnConsultaGeral";
      this.btnConsultaGeral.Size = new System.Drawing.Size(27, 22);
      this.btnConsultaGeral.TabIndex = 1;
      this.btnConsultaGeral.Text = "...";
      this.btnConsultaGeral.UseVisualStyleBackColor = true;
      this.btnConsultaGeral.Click += new System.EventHandler(this.btnConsultaGeral_Click);
      // 
      // chkMostraCaracteres
      // 
      this.chkMostraCaracteres.AutoSize = true;
      this.chkMostraCaracteres.Enabled = false;
      this.chkMostraCaracteres.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.chkMostraCaracteres.Location = new System.Drawing.Point(299, 76);
      this.chkMostraCaracteres.Name = "chkMostraCaracteres";
      this.chkMostraCaracteres.Size = new System.Drawing.Size(117, 17);
      this.chkMostraCaracteres.TabIndex = 6;
      this.chkMostraCaracteres.TabStop = false;
      this.chkMostraCaracteres.Text = "&Mostrar caracteres";
      this.chkMostraCaracteres.UseVisualStyleBackColor = true;
      this.chkMostraCaracteres.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
      // 
      // lblSenha
      // 
      this.lblSenha.Font = new System.Drawing.Font("Tahoma", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lblSenha.ForeColor = System.Drawing.Color.Red;
      this.lblSenha.Image = ((System.Drawing.Image)(resources.GetObject("lblSenha.Image")));
      this.lblSenha.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
      this.lblSenha.Location = new System.Drawing.Point(115, 129);
      this.lblSenha.Name = "lblSenha";
      this.lblSenha.Size = new System.Drawing.Size(199, 36);
      this.lblSenha.TabIndex = 26;
      this.lblSenha.Text = "Senha digitada não confere!";
      this.lblSenha.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
      this.lblSenha.Visible = false;
      // 
      // tbSenhaC
      // 
      this.tbSenhaC.Location = new System.Drawing.Point(118, 103);
      this.tbSenhaC.MaxLength = 50;
      this.tbSenhaC.Name = "tbSenhaC";
      this.tbSenhaC.PasswordChar = '*';
      this.tbSenhaC.ReadOnly = true;
      this.tbSenhaC.Size = new System.Drawing.Size(130, 21);
      this.tbSenhaC.TabIndex = 5;
      this.tbSenhaC.TabStop = false;
      this.tbSenhaC.TextChanged += new System.EventHandler(this.tbSenhaC_TextChanged);
      this.tbSenhaC.Leave += new System.EventHandler(this.tbSenhaC_Leave);
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label3.Location = new System.Drawing.Point(16, 108);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(96, 13);
      this.label3.TabIndex = 23;
      this.label3.Text = "Confirme a Senha:";
      // 
      // tbSenha
      // 
      this.tbSenha.Location = new System.Drawing.Point(118, 75);
      this.tbSenha.MaxLength = 50;
      this.tbSenha.Name = "tbSenha";
      this.tbSenha.PasswordChar = '*';
      this.tbSenha.ReadOnly = true;
      this.tbSenha.Size = new System.Drawing.Size(130, 21);
      this.tbSenha.TabIndex = 4;
      this.tbSenha.TabStop = false;
      this.tbSenha.Leave += new System.EventHandler(this.tbSenha_Leave);
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label2.Location = new System.Drawing.Point(71, 80);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(41, 13);
      this.label2.TabIndex = 21;
      this.label2.Text = "Senha:";
      // 
      // pictureBox1
      // 
      this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
      this.pictureBox1.Location = new System.Drawing.Point(516, 26);
      this.pictureBox1.Name = "pictureBox1";
      this.pictureBox1.Size = new System.Drawing.Size(128, 128);
      this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
      this.pictureBox1.TabIndex = 19;
      this.pictureBox1.TabStop = false;
      // 
      // tbLogin
      // 
      this.tbLogin.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
      this.tbLogin.Location = new System.Drawing.Point(118, 48);
      this.tbLogin.MaxLength = 50;
      this.tbLogin.Name = "tbLogin";
      this.tbLogin.ReadOnly = true;
      this.tbLogin.Size = new System.Drawing.Size(165, 21);
      this.tbLogin.TabIndex = 3;
      this.tbLogin.TabStop = false;
      this.tbLogin.Leave += new System.EventHandler(this.tbLogin_Leave);
      // 
      // labNome
      // 
      this.labNome.AutoSize = true;
      this.labNome.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.labNome.Location = new System.Drawing.Point(76, 53);
      this.labNome.Name = "labNome";
      this.labNome.Size = new System.Drawing.Size(36, 13);
      this.labNome.TabIndex = 8;
      this.labNome.Text = "Login:";
      // 
      // tbCodigo
      // 
      this.tbCodigo.Location = new System.Drawing.Point(118, 21);
      this.tbCodigo.Name = "tbCodigo";
      this.tbCodigo.Size = new System.Drawing.Size(56, 21);
      this.tbCodigo.TabIndex = 0;
      this.tbCodigo.Leave += new System.EventHandler(this.tbCodigo_Leave);
      this.tbCodigo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbCodigo_KeyPress);
      this.tbCodigo.Enter += new System.EventHandler(this.tbCodigo_Enter);
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label1.Location = new System.Drawing.Point(68, 26);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(44, 13);
      this.label1.TabIndex = 6;
      this.label1.Text = "Código:";
      // 
      // FormCadUsuarios
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.CancelButton = this.butSair;
      this.ClientSize = new System.Drawing.Size(711, 223);
      this.Controls.Add(this.butSalvar);
      this.Controls.Add(this.butExcluir);
      this.Controls.Add(this.butNovo);
      this.Controls.Add(this.butConsultar);
      this.Controls.Add(this.butAlterar);
      this.Controls.Add(this.butSair);
      this.Controls.Add(this.butCancelar);
      this.Controls.Add(this.groupBox1);
      this.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
      this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
      this.KeyPreview = true;
      this.MaximizeBox = false;
      this.Name = "FormCadUsuarios";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "Cadastro de Usuários";
      this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FormCadUsuarios_KeyDown);
      this.groupBox1.ResumeLayout(false);
      this.groupBox1.PerformLayout();
      this.groupBox2.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
      this.ResumeLayout(false);

    }

    #endregion

    public System.Windows.Forms.Button butSalvar;
    public System.Windows.Forms.Button butExcluir;
    private System.Windows.Forms.Button butConsultar;
    public System.Windows.Forms.Button butAlterar;
    private System.Windows.Forms.Button butSair;
    private System.Windows.Forms.Button butCancelar;
    private System.Windows.Forms.GroupBox groupBox1;
    private System.Windows.Forms.PictureBox pictureBox1;
    public System.Windows.Forms.TextBox tbLogin;
    private System.Windows.Forms.Label labNome;
    public System.Windows.Forms.TextBox tbCodigo;
    private System.Windows.Forms.Label label1;
    public System.Windows.Forms.TextBox tbSenha;
    private System.Windows.Forms.Label label2;
    public System.Windows.Forms.TextBox tbSenhaC;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.Label lblSenha;
    public System.Windows.Forms.CheckBox chkMostraCaracteres;
    private System.Windows.Forms.Button btnConsultaGeral;
    private System.Windows.Forms.GroupBox groupBox2;
    public System.Windows.Forms.ComboBox cbxPerfil;
    public System.Windows.Forms.Button butNovo;
  }
}