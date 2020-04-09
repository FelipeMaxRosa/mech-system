namespace MechSystem
{
  partial class FormLogin
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormLogin));
      this.label1 = new System.Windows.Forms.Label();
      this.txtSenha = new System.Windows.Forms.TextBox();
      this.butAcessar = new System.Windows.Forms.Button();
      this.butSair = new System.Windows.Forms.Button();
      this.txtLogin = new System.Windows.Forms.TextBox();
      this.label2 = new System.Windows.Forms.Label();
      this.pictureBox1 = new System.Windows.Forms.PictureBox();
      ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
      this.SuspendLayout();
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.BackColor = System.Drawing.Color.Transparent;
      this.label1.Font = new System.Drawing.Font("Impact", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label1.ForeColor = System.Drawing.Color.WhiteSmoke;
      this.label1.Location = new System.Drawing.Point(104, 49);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(43, 17);
      this.label1.TabIndex = 0;
      this.label1.Text = "Senha";
      // 
      // txtSenha
      // 
      this.txtSenha.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.txtSenha.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.txtSenha.Location = new System.Drawing.Point(107, 69);
      this.txtSenha.Name = "txtSenha";
      this.txtSenha.PasswordChar = '*';
      this.txtSenha.Size = new System.Drawing.Size(103, 23);
      this.txtSenha.TabIndex = 1;
      this.txtSenha.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
      this.txtSenha.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSenha_KeyPress);
      // 
      // butAcessar
      // 
      this.butAcessar.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.butAcessar.Location = new System.Drawing.Point(59, 99);
      this.butAcessar.Name = "butAcessar";
      this.butAcessar.Size = new System.Drawing.Size(89, 23);
      this.butAcessar.TabIndex = 2;
      this.butAcessar.Text = "Acessar";
      this.butAcessar.UseVisualStyleBackColor = true;
      this.butAcessar.Click += new System.EventHandler(this.butAcessar_Click);
      // 
      // butSair
      // 
      this.butSair.DialogResult = System.Windows.Forms.DialogResult.Cancel;
      this.butSair.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.butSair.Location = new System.Drawing.Point(166, 99);
      this.butSair.Name = "butSair";
      this.butSair.Size = new System.Drawing.Size(89, 23);
      this.butSair.TabIndex = 3;
      this.butSair.Text = "Sair";
      this.butSair.UseVisualStyleBackColor = true;
      this.butSair.Click += new System.EventHandler(this.butSair_Click);
      // 
      // txtLogin
      // 
      this.txtLogin.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.txtLogin.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
      this.txtLogin.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.txtLogin.Location = new System.Drawing.Point(107, 26);
      this.txtLogin.Name = "txtLogin";
      this.txtLogin.Size = new System.Drawing.Size(103, 23);
      this.txtLogin.TabIndex = 0;
      this.txtLogin.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
      this.txtLogin.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtLogin_KeyPress);
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.BackColor = System.Drawing.Color.Transparent;
      this.label2.Font = new System.Drawing.Font("Impact", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label2.ForeColor = System.Drawing.Color.WhiteSmoke;
      this.label2.Location = new System.Drawing.Point(104, 6);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(38, 17);
      this.label2.TabIndex = 4;
      this.label2.Text = "Login";
      // 
      // pictureBox1
      // 
      this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
      this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
      this.pictureBox1.Location = new System.Drawing.Point(3, 9);
      this.pictureBox1.Name = "pictureBox1";
      this.pictureBox1.Size = new System.Drawing.Size(100, 86);
      this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
      this.pictureBox1.TabIndex = 5;
      this.pictureBox1.TabStop = false;
      // 
      // FormLogin
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.BackColor = System.Drawing.SystemColors.Control;
      this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
      this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
      this.CancelButton = this.butSair;
      this.ClientSize = new System.Drawing.Size(314, 126);
      this.ControlBox = false;
      this.Controls.Add(this.pictureBox1);
      this.Controls.Add(this.txtLogin);
      this.Controls.Add(this.label2);
      this.Controls.Add(this.butSair);
      this.Controls.Add(this.butAcessar);
      this.Controls.Add(this.txtSenha);
      this.Controls.Add(this.label1);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
      this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
      this.KeyPreview = true;
      this.MaximizeBox = false;
      this.Name = "FormLogin";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FormLogin_KeyDown);
      ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.TextBox txtSenha;
    private System.Windows.Forms.Button butAcessar;
    private System.Windows.Forms.Button butSair;
    private System.Windows.Forms.TextBox txtLogin;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.PictureBox pictureBox1;
  }
}