﻿namespace MechSystem
{
  partial class FormCadFuncao
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCadFuncao));
      this.groupBox1 = new System.Windows.Forms.GroupBox();
      this.btnConsultaGeral = new System.Windows.Forms.Button();
      this.pictureBox1 = new System.Windows.Forms.PictureBox();
      this.tbDescricao = new System.Windows.Forms.TextBox();
      this.labNome = new System.Windows.Forms.Label();
      this.tbCodigo = new System.Windows.Forms.TextBox();
      this.label1 = new System.Windows.Forms.Label();
      this.butSalvar = new System.Windows.Forms.Button();
      this.butExcluir = new System.Windows.Forms.Button();
      this.butNovo = new System.Windows.Forms.Button();
      this.butConsultar = new System.Windows.Forms.Button();
      this.butAlterar = new System.Windows.Forms.Button();
      this.butSair = new System.Windows.Forms.Button();
      this.butCancelar = new System.Windows.Forms.Button();
      this.groupBox1.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
      this.SuspendLayout();
      // 
      // groupBox1
      // 
      this.groupBox1.Controls.Add(this.btnConsultaGeral);
      this.groupBox1.Controls.Add(this.pictureBox1);
      this.groupBox1.Controls.Add(this.tbDescricao);
      this.groupBox1.Controls.Add(this.labNome);
      this.groupBox1.Controls.Add(this.tbCodigo);
      this.groupBox1.Controls.Add(this.label1);
      this.groupBox1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.groupBox1.Location = new System.Drawing.Point(10, 9);
      this.groupBox1.Name = "groupBox1";
      this.groupBox1.Size = new System.Drawing.Size(686, 89);
      this.groupBox1.TabIndex = 0;
      this.groupBox1.TabStop = false;
      this.groupBox1.Text = "Dados da Função";
      // 
      // btnConsultaGeral
      // 
      this.btnConsultaGeral.Cursor = System.Windows.Forms.Cursors.Hand;
      this.btnConsultaGeral.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.btnConsultaGeral.Location = new System.Drawing.Point(144, 20);
      this.btnConsultaGeral.Name = "btnConsultaGeral";
      this.btnConsultaGeral.Size = new System.Drawing.Size(27, 22);
      this.btnConsultaGeral.TabIndex = 1;
      this.btnConsultaGeral.Text = "...";
      this.btnConsultaGeral.UseVisualStyleBackColor = true;
      this.btnConsultaGeral.Click += new System.EventHandler(this.btnConsultaGeral_Click);
      // 
      // pictureBox1
      // 
      this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
      this.pictureBox1.Location = new System.Drawing.Point(586, 12);
      this.pictureBox1.Name = "pictureBox1";
      this.pictureBox1.Size = new System.Drawing.Size(94, 71);
      this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
      this.pictureBox1.TabIndex = 19;
      this.pictureBox1.TabStop = false;
      // 
      // tbDescricao
      // 
      this.tbDescricao.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
      this.tbDescricao.Location = new System.Drawing.Point(80, 52);
      this.tbDescricao.MaxLength = 50;
      this.tbDescricao.Name = "tbDescricao";
      this.tbDescricao.ReadOnly = true;
      this.tbDescricao.Size = new System.Drawing.Size(402, 21);
      this.tbDescricao.TabIndex = 2;
      this.tbDescricao.TabStop = false;
      // 
      // labNome
      // 
      this.labNome.AutoSize = true;
      this.labNome.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.labNome.Location = new System.Drawing.Point(19, 55);
      this.labNome.Name = "labNome";
      this.labNome.Size = new System.Drawing.Size(57, 13);
      this.labNome.TabIndex = 8;
      this.labNome.Text = "Descrição:";
      // 
      // tbCodigo
      // 
      this.tbCodigo.Location = new System.Drawing.Point(80, 20);
      this.tbCodigo.Name = "tbCodigo";
      this.tbCodigo.Size = new System.Drawing.Size(58, 21);
      this.tbCodigo.TabIndex = 0;
      this.tbCodigo.Leave += new System.EventHandler(this.tbCodigo_Leave);
      this.tbCodigo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbCodigo_KeyPress);
      this.tbCodigo.Enter += new System.EventHandler(this.tbCodigo_Enter);
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label1.Location = new System.Drawing.Point(32, 23);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(44, 13);
      this.label1.TabIndex = 6;
      this.label1.Text = "Código:";
      // 
      // butSalvar
      // 
      this.butSalvar.Cursor = System.Windows.Forms.Cursors.Hand;
      this.butSalvar.Enabled = false;
      this.butSalvar.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
      this.butSalvar.Location = new System.Drawing.Point(210, 116);
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
      this.butExcluir.Location = new System.Drawing.Point(410, 116);
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
      this.butNovo.Location = new System.Drawing.Point(10, 116);
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
      this.butConsultar.Location = new System.Drawing.Point(110, 116);
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
      this.butAlterar.Location = new System.Drawing.Point(309, 116);
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
      this.butSair.Location = new System.Drawing.Point(610, 116);
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
      this.butCancelar.Location = new System.Drawing.Point(510, 116);
      this.butCancelar.Name = "butCancelar";
      this.butCancelar.Size = new System.Drawing.Size(86, 26);
      this.butCancelar.TabIndex = 6;
      this.butCancelar.Text = "Cancelar";
      this.butCancelar.UseVisualStyleBackColor = true;
      this.butCancelar.Click += new System.EventHandler(this.butCancelar_Click);
      // 
      // FormCadFuncao
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.CancelButton = this.butSair;
      this.ClientSize = new System.Drawing.Size(707, 148);
      this.Controls.Add(this.butSalvar);
      this.Controls.Add(this.butExcluir);
      this.Controls.Add(this.butNovo);
      this.Controls.Add(this.butConsultar);
      this.Controls.Add(this.butAlterar);
      this.Controls.Add(this.butSair);
      this.Controls.Add(this.butCancelar);
      this.Controls.Add(this.groupBox1);
      this.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
      this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
      this.KeyPreview = true;
      this.MaximizeBox = false;
      this.Name = "FormCadFuncao";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "Cadastro de Funções";
      this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FormCadFuncao_KeyDown);
      this.groupBox1.ResumeLayout(false);
      this.groupBox1.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.GroupBox groupBox1;
    public System.Windows.Forms.Button butExcluir;
    private System.Windows.Forms.Button butConsultar;
    public System.Windows.Forms.Button butAlterar;
    private System.Windows.Forms.Button butSair;
    private System.Windows.Forms.Button butCancelar;
    public System.Windows.Forms.TextBox tbDescricao;
    private System.Windows.Forms.Label labNome;
    public System.Windows.Forms.TextBox tbCodigo;
    private System.Windows.Forms.Label label1;
    public System.Windows.Forms.Button butSalvar;
    private System.Windows.Forms.PictureBox pictureBox1;
    private System.Windows.Forms.Button btnConsultaGeral;
    public System.Windows.Forms.Button butNovo;
  }
}