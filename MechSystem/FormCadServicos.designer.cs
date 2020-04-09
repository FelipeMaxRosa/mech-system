namespace MechSystem
{
  partial class FormCadServicos
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCadServicos));
      this.tbDetalhes = new System.Windows.Forms.TextBox();
      this.tbValor = new System.Windows.Forms.TextBox();
      this.label2 = new System.Windows.Forms.Label();
      this.label3 = new System.Windows.Forms.Label();
      this.butSalvar = new System.Windows.Forms.Button();
      this.pictureBox1 = new System.Windows.Forms.PictureBox();
      this.tbDescricao = new System.Windows.Forms.TextBox();
      this.labNome = new System.Windows.Forms.Label();
      this.tbCodigo = new System.Windows.Forms.TextBox();
      this.butExcluir = new System.Windows.Forms.Button();
      this.butNovo = new System.Windows.Forms.Button();
      this.label1 = new System.Windows.Forms.Label();
      this.butConsultar = new System.Windows.Forms.Button();
      this.butAlterar = new System.Windows.Forms.Button();
      this.butSair = new System.Windows.Forms.Button();
      this.butCancelar = new System.Windows.Forms.Button();
      this.groupBox1 = new System.Windows.Forms.GroupBox();
      this.btnConsultaGeral = new System.Windows.Forms.Button();
      ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
      this.groupBox1.SuspendLayout();
      this.SuspendLayout();
      // 
      // tbDetalhes
      // 
      this.tbDetalhes.Location = new System.Drawing.Point(82, 115);
      this.tbDetalhes.MaxLength = 50;
      this.tbDetalhes.Multiline = true;
      this.tbDetalhes.Name = "tbDetalhes";
      this.tbDetalhes.ReadOnly = true;
      this.tbDetalhes.Size = new System.Drawing.Size(378, 64);
      this.tbDetalhes.TabIndex = 4;
      this.tbDetalhes.TabStop = false;
      // 
      // tbValor
      // 
      this.tbValor.Location = new System.Drawing.Point(82, 83);
      this.tbValor.MaxLength = 50;
      this.tbValor.Name = "tbValor";
      this.tbValor.ReadOnly = true;
      this.tbValor.Size = new System.Drawing.Size(86, 21);
      this.tbValor.TabIndex = 3;
      this.tbValor.TabStop = false;
      this.tbValor.Leave += new System.EventHandler(this.tbValor_Leave);
      this.tbValor.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbValor_KeyPress);
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label2.Location = new System.Drawing.Point(19, 86);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(59, 13);
      this.label2.TabIndex = 21;
      this.label2.Text = "Valor (R$):";
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label3.Location = new System.Drawing.Point(25, 118);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(53, 13);
      this.label3.TabIndex = 23;
      this.label3.Text = "Detalhes:";
      // 
      // butSalvar
      // 
      this.butSalvar.Cursor = System.Windows.Forms.Cursors.Hand;
      this.butSalvar.Enabled = false;
      this.butSalvar.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.butSalvar.Location = new System.Drawing.Point(212, 212);
      this.butSalvar.Name = "butSalvar";
      this.butSalvar.Size = new System.Drawing.Size(86, 26);
      this.butSalvar.TabIndex = 3;
      this.butSalvar.Text = "&Salvar";
      this.butSalvar.UseVisualStyleBackColor = true;
      this.butSalvar.Click += new System.EventHandler(this.butSalvar_Click);
      // 
      // pictureBox1
      // 
      this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
      this.pictureBox1.Location = new System.Drawing.Point(521, 36);
      this.pictureBox1.Name = "pictureBox1";
      this.pictureBox1.Size = new System.Drawing.Size(128, 128);
      this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
      this.pictureBox1.TabIndex = 19;
      this.pictureBox1.TabStop = false;
      // 
      // tbDescricao
      // 
      this.tbDescricao.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
      this.tbDescricao.Location = new System.Drawing.Point(82, 51);
      this.tbDescricao.MaxLength = 50;
      this.tbDescricao.Name = "tbDescricao";
      this.tbDescricao.ReadOnly = true;
      this.tbDescricao.Size = new System.Drawing.Size(368, 21);
      this.tbDescricao.TabIndex = 2;
      this.tbDescricao.TabStop = false;
      this.tbDescricao.Leave += new System.EventHandler(this.tbDescricao_Leave);
      // 
      // labNome
      // 
      this.labNome.AutoSize = true;
      this.labNome.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.labNome.Location = new System.Drawing.Point(21, 54);
      this.labNome.Name = "labNome";
      this.labNome.Size = new System.Drawing.Size(57, 13);
      this.labNome.TabIndex = 8;
      this.labNome.Text = "Descrição:";
      // 
      // tbCodigo
      // 
      this.tbCodigo.Location = new System.Drawing.Point(82, 19);
      this.tbCodigo.Name = "tbCodigo";
      this.tbCodigo.Size = new System.Drawing.Size(53, 21);
      this.tbCodigo.TabIndex = 0;
      this.tbCodigo.Leave += new System.EventHandler(this.tbCodigo_Leave);
      this.tbCodigo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbCodigo_KeyPress);
      this.tbCodigo.Enter += new System.EventHandler(this.tbCodigo_Enter);
      // 
      // butExcluir
      // 
      this.butExcluir.Cursor = System.Windows.Forms.Cursors.Hand;
      this.butExcluir.Enabled = false;
      this.butExcluir.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.butExcluir.Location = new System.Drawing.Point(412, 212);
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
      this.butNovo.Location = new System.Drawing.Point(12, 212);
      this.butNovo.Name = "butNovo";
      this.butNovo.Size = new System.Drawing.Size(86, 26);
      this.butNovo.TabIndex = 1;
      this.butNovo.Text = "Novo";
      this.butNovo.UseVisualStyleBackColor = true;
      this.butNovo.Click += new System.EventHandler(this.butNovo_Click);
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label1.Location = new System.Drawing.Point(34, 22);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(44, 13);
      this.label1.TabIndex = 6;
      this.label1.Text = "Código:";
      // 
      // butConsultar
      // 
      this.butConsultar.Cursor = System.Windows.Forms.Cursors.Hand;
      this.butConsultar.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.butConsultar.Location = new System.Drawing.Point(112, 212);
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
      this.butAlterar.Location = new System.Drawing.Point(311, 212);
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
      this.butSair.Location = new System.Drawing.Point(612, 212);
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
      this.butCancelar.Location = new System.Drawing.Point(512, 212);
      this.butCancelar.Name = "butCancelar";
      this.butCancelar.Size = new System.Drawing.Size(86, 26);
      this.butCancelar.TabIndex = 6;
      this.butCancelar.Text = "Cancelar";
      this.butCancelar.UseVisualStyleBackColor = true;
      this.butCancelar.Click += new System.EventHandler(this.butCancelar_Click);
      // 
      // groupBox1
      // 
      this.groupBox1.Controls.Add(this.btnConsultaGeral);
      this.groupBox1.Controls.Add(this.tbDetalhes);
      this.groupBox1.Controls.Add(this.label3);
      this.groupBox1.Controls.Add(this.tbValor);
      this.groupBox1.Controls.Add(this.label2);
      this.groupBox1.Controls.Add(this.pictureBox1);
      this.groupBox1.Controls.Add(this.tbDescricao);
      this.groupBox1.Controls.Add(this.labNome);
      this.groupBox1.Controls.Add(this.tbCodigo);
      this.groupBox1.Controls.Add(this.label1);
      this.groupBox1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.groupBox1.Location = new System.Drawing.Point(12, 9);
      this.groupBox1.Name = "groupBox1";
      this.groupBox1.Size = new System.Drawing.Size(686, 197);
      this.groupBox1.TabIndex = 0;
      this.groupBox1.TabStop = false;
      this.groupBox1.Text = "Dados do Serviço";
      // 
      // btnConsultaGeral
      // 
      this.btnConsultaGeral.Cursor = System.Windows.Forms.Cursors.Hand;
      this.btnConsultaGeral.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.btnConsultaGeral.Location = new System.Drawing.Point(141, 19);
      this.btnConsultaGeral.Name = "btnConsultaGeral";
      this.btnConsultaGeral.Size = new System.Drawing.Size(27, 22);
      this.btnConsultaGeral.TabIndex = 1;
      this.btnConsultaGeral.Text = "...";
      this.btnConsultaGeral.UseVisualStyleBackColor = true;
      this.btnConsultaGeral.Click += new System.EventHandler(this.btnConsultaGeral_Click);
      // 
      // FormCadServicos
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.CancelButton = this.butSair;
      this.ClientSize = new System.Drawing.Size(709, 246);
      this.Controls.Add(this.butSalvar);
      this.Controls.Add(this.butExcluir);
      this.Controls.Add(this.butNovo);
      this.Controls.Add(this.butConsultar);
      this.Controls.Add(this.butAlterar);
      this.Controls.Add(this.butSair);
      this.Controls.Add(this.butCancelar);
      this.Controls.Add(this.groupBox1);
      this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
      this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
      this.KeyPreview = true;
      this.MaximizeBox = false;
      this.Name = "FormCadServicos";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "Cadastro de Serviços";
      this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FormCadServicos_KeyDown);
      ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
      this.groupBox1.ResumeLayout(false);
      this.groupBox1.PerformLayout();
      this.ResumeLayout(false);

    }

    #endregion

    public System.Windows.Forms.TextBox tbDetalhes;
    public System.Windows.Forms.TextBox tbValor;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.Label label3;
    public System.Windows.Forms.Button butSalvar;
    private System.Windows.Forms.PictureBox pictureBox1;
    public System.Windows.Forms.TextBox tbDescricao;
    private System.Windows.Forms.Label labNome;
    public System.Windows.Forms.TextBox tbCodigo;
    public System.Windows.Forms.Button butExcluir;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Button butConsultar;
    public System.Windows.Forms.Button butAlterar;
    private System.Windows.Forms.Button butSair;
    private System.Windows.Forms.Button butCancelar;
    private System.Windows.Forms.GroupBox groupBox1;
    private System.Windows.Forms.Button btnConsultaGeral;
    public System.Windows.Forms.Button butNovo;

  }
}