namespace MechSystem
{
  partial class FormAjuEstoque
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAjuEstoque));
      this.grbProduto = new System.Windows.Forms.GroupBox();
      this.btnPesquisar = new System.Windows.Forms.Button();
      this.label2 = new System.Windows.Forms.Label();
      this.tbCodigo = new System.Windows.Forms.TextBox();
      this.label1 = new System.Windows.Forms.Label();
      this.grbAjuste = new System.Windows.Forms.GroupBox();
      this.tbEmb = new System.Windows.Forms.TextBox();
      this.lblTotalAjuste = new System.Windows.Forms.Label();
      this.label6 = new System.Windows.Forms.Label();
      this.label5 = new System.Windows.Forms.Label();
      this.tbQtde = new System.Windows.Forms.TextBox();
      this.label4 = new System.Windows.Forms.Label();
      this.label3 = new System.Windows.Forms.Label();
      this.cbxAjuste = new System.Windows.Forms.ComboBox();
      this.grbObs = new System.Windows.Forms.GroupBox();
      this.tbObs = new System.Windows.Forms.TextBox();
      this.butSalvar = new System.Windows.Forms.Button();
      this.butNovo = new System.Windows.Forms.Button();
      this.butSair = new System.Windows.Forms.Button();
      this.butCancelar = new System.Windows.Forms.Button();
      this.pictureBox1 = new System.Windows.Forms.PictureBox();
      this.lblDescricao = new System.Windows.Forms.TextBox();
      this.grbProduto.SuspendLayout();
      this.grbAjuste.SuspendLayout();
      this.grbObs.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
      this.SuspendLayout();
      // 
      // grbProduto
      // 
      this.grbProduto.Controls.Add(this.lblDescricao);
      this.grbProduto.Controls.Add(this.btnPesquisar);
      this.grbProduto.Controls.Add(this.label2);
      this.grbProduto.Controls.Add(this.tbCodigo);
      this.grbProduto.Controls.Add(this.label1);
      this.grbProduto.Enabled = false;
      this.grbProduto.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.grbProduto.Location = new System.Drawing.Point(10, 8);
      this.grbProduto.Name = "grbProduto";
      this.grbProduto.Size = new System.Drawing.Size(381, 77);
      this.grbProduto.TabIndex = 0;
      this.grbProduto.TabStop = false;
      this.grbProduto.Text = "Dados do Produto";
      // 
      // btnPesquisar
      // 
      this.btnPesquisar.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.btnPesquisar.Location = new System.Drawing.Point(123, 20);
      this.btnPesquisar.Name = "btnPesquisar";
      this.btnPesquisar.Size = new System.Drawing.Size(27, 22);
      this.btnPesquisar.TabIndex = 1;
      this.btnPesquisar.Text = "...";
      this.btnPesquisar.UseVisualStyleBackColor = true;
      this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label2.Location = new System.Drawing.Point(5, 51);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(57, 13);
      this.label2.TabIndex = 9;
      this.label2.Text = "Descrição:";
      // 
      // tbCodigo
      // 
      this.tbCodigo.Location = new System.Drawing.Point(68, 21);
      this.tbCodigo.Name = "tbCodigo";
      this.tbCodigo.Size = new System.Drawing.Size(51, 21);
      this.tbCodigo.TabIndex = 0;
      this.tbCodigo.Leave += new System.EventHandler(this.tbCodigo_Leave);
      this.tbCodigo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbCodigo_KeyPress);
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label1.Location = new System.Drawing.Point(18, 25);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(44, 13);
      this.label1.TabIndex = 8;
      this.label1.Text = "Código:";
      // 
      // grbAjuste
      // 
      this.grbAjuste.Controls.Add(this.tbEmb);
      this.grbAjuste.Controls.Add(this.lblTotalAjuste);
      this.grbAjuste.Controls.Add(this.label6);
      this.grbAjuste.Controls.Add(this.label5);
      this.grbAjuste.Controls.Add(this.tbQtde);
      this.grbAjuste.Controls.Add(this.label4);
      this.grbAjuste.Controls.Add(this.label3);
      this.grbAjuste.Controls.Add(this.cbxAjuste);
      this.grbAjuste.Enabled = false;
      this.grbAjuste.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.grbAjuste.Location = new System.Drawing.Point(10, 88);
      this.grbAjuste.Name = "grbAjuste";
      this.grbAjuste.Size = new System.Drawing.Size(381, 76);
      this.grbAjuste.TabIndex = 1;
      this.grbAjuste.TabStop = false;
      this.grbAjuste.Text = "Dados do Ajuste";
      // 
      // tbEmb
      // 
      this.tbEmb.Location = new System.Drawing.Point(152, 47);
      this.tbEmb.Name = "tbEmb";
      this.tbEmb.Size = new System.Drawing.Size(43, 21);
      this.tbEmb.TabIndex = 2;
      this.tbEmb.TextChanged += new System.EventHandler(this.tbEmb_TextChanged);
      this.tbEmb.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbEmb_KeyPress);
      // 
      // lblTotalAjuste
      // 
      this.lblTotalAjuste.AutoSize = true;
      this.lblTotalAjuste.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lblTotalAjuste.Location = new System.Drawing.Point(300, 50);
      this.lblTotalAjuste.Name = "lblTotalAjuste";
      this.lblTotalAjuste.Size = new System.Drawing.Size(0, 14);
      this.lblTotalAjuste.TabIndex = 14;
      // 
      // label6
      // 
      this.label6.AutoSize = true;
      this.label6.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label6.Location = new System.Drawing.Point(218, 50);
      this.label6.Name = "label6";
      this.label6.Size = new System.Drawing.Size(84, 13);
      this.label6.TabIndex = 13;
      this.label6.Text = "Total do Ajuste:";
      // 
      // label5
      // 
      this.label5.AutoSize = true;
      this.label5.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label5.Location = new System.Drawing.Point(118, 50);
      this.label5.Name = "label5";
      this.label5.Size = new System.Drawing.Size(35, 13);
      this.label5.TabIndex = 11;
      this.label5.Text = "Emb.:";
      // 
      // tbQtde
      // 
      this.tbQtde.Location = new System.Drawing.Point(68, 47);
      this.tbQtde.Name = "tbQtde";
      this.tbQtde.Size = new System.Drawing.Size(43, 21);
      this.tbQtde.TabIndex = 1;
      this.tbQtde.TextChanged += new System.EventHandler(this.tbQtde_TextChanged);
      this.tbQtde.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbQtde_KeyPress);
      // 
      // label4
      // 
      this.label4.AutoSize = true;
      this.label4.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label4.Location = new System.Drawing.Point(27, 51);
      this.label4.Name = "label4";
      this.label4.Size = new System.Drawing.Size(35, 13);
      this.label4.TabIndex = 9;
      this.label4.Text = "Qtde:";
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label3.Location = new System.Drawing.Point(31, 22);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(31, 13);
      this.label3.TabIndex = 9;
      this.label3.Text = "Tipo:";
      // 
      // cbxAjuste
      // 
      this.cbxAjuste.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
      this.cbxAjuste.FormattingEnabled = true;
      this.cbxAjuste.Items.AddRange(new object[] {
            "POSITIVO",
            "NEGATIVO",
            "QUEBRAS E PERDAS",
            "ROUBO",
            "ENVIO PARA TROCA",
            "RETORNO DE TROCA"});
      this.cbxAjuste.Location = new System.Drawing.Point(68, 19);
      this.cbxAjuste.Name = "cbxAjuste";
      this.cbxAjuste.Size = new System.Drawing.Size(158, 21);
      this.cbxAjuste.TabIndex = 0;
      this.cbxAjuste.DropDownClosed += new System.EventHandler(this.cbxAjuste_DropDownClosed);
      // 
      // grbObs
      // 
      this.grbObs.Controls.Add(this.tbObs);
      this.grbObs.Enabled = false;
      this.grbObs.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.grbObs.Location = new System.Drawing.Point(10, 167);
      this.grbObs.Name = "grbObs";
      this.grbObs.Size = new System.Drawing.Size(465, 76);
      this.grbObs.TabIndex = 2;
      this.grbObs.TabStop = false;
      this.grbObs.Text = "Observações";
      // 
      // tbObs
      // 
      this.tbObs.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
      this.tbObs.Location = new System.Drawing.Point(10, 19);
      this.tbObs.MaxLength = 150;
      this.tbObs.Multiline = true;
      this.tbObs.Name = "tbObs";
      this.tbObs.Size = new System.Drawing.Size(445, 46);
      this.tbObs.TabIndex = 0;
      // 
      // butSalvar
      // 
      this.butSalvar.Cursor = System.Windows.Forms.Cursors.Hand;
      this.butSalvar.Enabled = false;
      this.butSalvar.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
      this.butSalvar.Location = new System.Drawing.Point(110, 251);
      this.butSalvar.Name = "butSalvar";
      this.butSalvar.Size = new System.Drawing.Size(86, 26);
      this.butSalvar.TabIndex = 4;
      this.butSalvar.Text = "&Salvar";
      this.butSalvar.UseVisualStyleBackColor = true;
      this.butSalvar.Click += new System.EventHandler(this.butSalvar_Click);
      // 
      // butNovo
      // 
      this.butNovo.Cursor = System.Windows.Forms.Cursors.Hand;
      this.butNovo.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
      this.butNovo.Location = new System.Drawing.Point(10, 251);
      this.butNovo.Name = "butNovo";
      this.butNovo.Size = new System.Drawing.Size(86, 26);
      this.butNovo.TabIndex = 3;
      this.butNovo.Text = "&Novo";
      this.butNovo.UseVisualStyleBackColor = true;
      this.butNovo.Click += new System.EventHandler(this.butNovo_Click);
      // 
      // butSair
      // 
      this.butSair.Cursor = System.Windows.Forms.Cursors.Hand;
      this.butSair.DialogResult = System.Windows.Forms.DialogResult.Cancel;
      this.butSair.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
      this.butSair.Location = new System.Drawing.Point(310, 251);
      this.butSair.Name = "butSair";
      this.butSair.Size = new System.Drawing.Size(86, 26);
      this.butSair.TabIndex = 6;
      this.butSair.Text = "Sair";
      this.butSair.UseVisualStyleBackColor = true;
      this.butSair.Click += new System.EventHandler(this.butSair_Click);
      // 
      // butCancelar
      // 
      this.butCancelar.Cursor = System.Windows.Forms.Cursors.Hand;
      this.butCancelar.Enabled = false;
      this.butCancelar.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
      this.butCancelar.Location = new System.Drawing.Point(210, 251);
      this.butCancelar.Name = "butCancelar";
      this.butCancelar.Size = new System.Drawing.Size(86, 26);
      this.butCancelar.TabIndex = 5;
      this.butCancelar.Text = "Cancelar";
      this.butCancelar.UseVisualStyleBackColor = true;
      this.butCancelar.Click += new System.EventHandler(this.butCancelar_Click);
      // 
      // pictureBox1
      // 
      this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
      this.pictureBox1.Location = new System.Drawing.Point(397, 12);
      this.pictureBox1.Name = "pictureBox1";
      this.pictureBox1.Size = new System.Drawing.Size(114, 87);
      this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
      this.pictureBox1.TabIndex = 7;
      this.pictureBox1.TabStop = false;
      // 
      // lblDescricao
      // 
      this.lblDescricao.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
      this.lblDescricao.Location = new System.Drawing.Point(68, 48);
      this.lblDescricao.MaxLength = 150;
      this.lblDescricao.Name = "lblDescricao";
      this.lblDescricao.ReadOnly = true;
      this.lblDescricao.Size = new System.Drawing.Size(295, 21);
      this.lblDescricao.TabIndex = 10;
      this.lblDescricao.TabStop = false;
      // 
      // FormAjuEstoque
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.CancelButton = this.butSair;
      this.ClientSize = new System.Drawing.Size(523, 284);
      this.Controls.Add(this.pictureBox1);
      this.Controls.Add(this.butSalvar);
      this.Controls.Add(this.butNovo);
      this.Controls.Add(this.butSair);
      this.Controls.Add(this.butCancelar);
      this.Controls.Add(this.grbObs);
      this.Controls.Add(this.grbAjuste);
      this.Controls.Add(this.grbProduto);
      this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
      this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
      this.KeyPreview = true;
      this.MaximizeBox = false;
      this.Name = "FormAjuEstoque";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "Ajuste de Estoque";
      this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FormAjuEstoque_KeyDown);
      this.grbProduto.ResumeLayout(false);
      this.grbProduto.PerformLayout();
      this.grbAjuste.ResumeLayout(false);
      this.grbAjuste.PerformLayout();
      this.grbObs.ResumeLayout(false);
      this.grbObs.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.GroupBox grbProduto;
    public System.Windows.Forms.TextBox tbCodigo;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.Button btnPesquisar;
    private System.Windows.Forms.GroupBox grbAjuste;
    private System.Windows.Forms.Label label3;
    public System.Windows.Forms.TextBox tbEmb;
    private System.Windows.Forms.Label label6;
    private System.Windows.Forms.Label label5;
    public System.Windows.Forms.TextBox tbQtde;
    private System.Windows.Forms.Label label4;
    private System.Windows.Forms.GroupBox grbObs;
    public System.Windows.Forms.TextBox tbObs;
    public System.Windows.Forms.ComboBox cbxAjuste;
    public System.Windows.Forms.Label lblTotalAjuste;
    public System.Windows.Forms.Button butSalvar;
    private System.Windows.Forms.Button butNovo;
    private System.Windows.Forms.Button butSair;
    private System.Windows.Forms.Button butCancelar;
    private System.Windows.Forms.PictureBox pictureBox1;
    public System.Windows.Forms.TextBox lblDescricao;
  }
}