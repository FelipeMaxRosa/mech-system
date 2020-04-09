namespace MechSystem
{
  partial class FormGridOs
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormGridOs));
      this.dataGridView1 = new System.Windows.Forms.DataGridView();
      this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.placaveiculo = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.os_status = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.os_data = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.os_datasaida = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.responsavel = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.telefone = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.total = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.defeito = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.rel_tecnico = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.idmecanico = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.idfinalizadora = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.descricao = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.btnPesquisar = new System.Windows.Forms.Button();
      this.butSair = new System.Windows.Forms.Button();
      this.tbPesqNumero = new System.Windows.Forms.TextBox();
      this.groupBox1 = new System.Windows.Forms.GroupBox();
      this.groupBox4 = new System.Windows.Forms.GroupBox();
      this.cbxEstado = new System.Windows.Forms.ComboBox();
      this.groupBox3 = new System.Windows.Forms.GroupBox();
      this.groupBox2 = new System.Windows.Forms.GroupBox();
      this.label3 = new System.Windows.Forms.Label();
      this.label2 = new System.Windows.Forms.Label();
      this.label1 = new System.Windows.Forms.Label();
      this.tbPesqPlaca = new System.Windows.Forms.TextBox();
      this.dtFim = new System.Windows.Forms.DateTimePicker();
      this.dtInicio = new System.Windows.Forms.DateTimePicker();
      this.radPeriodo = new System.Windows.Forms.RadioButton();
      this.radPlaca = new System.Windows.Forms.RadioButton();
      this.radNumero = new System.Windows.Forms.RadioButton();
      ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
      this.groupBox1.SuspendLayout();
      this.groupBox4.SuspendLayout();
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
            this.placaveiculo,
            this.os_status,
            this.os_data,
            this.os_datasaida,
            this.responsavel,
            this.telefone,
            this.total,
            this.defeito,
            this.rel_tecnico,
            this.idmecanico,
            this.nome,
            this.idfinalizadora,
            this.descricao});
      this.dataGridView1.Location = new System.Drawing.Point(3, 77);
      this.dataGridView1.MultiSelect = false;
      this.dataGridView1.Name = "dataGridView1";
      this.dataGridView1.ReadOnly = true;
      this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
      this.dataGridView1.Size = new System.Drawing.Size(908, 296);
      this.dataGridView1.TabIndex = 1;
      this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
      this.dataGridView1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dataGridView1_KeyDown);
      // 
      // id
      // 
      this.id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
      this.id.DataPropertyName = "id";
      this.id.HeaderText = "Número";
      this.id.Name = "id";
      this.id.ReadOnly = true;
      this.id.Width = 69;
      // 
      // placaveiculo
      // 
      this.placaveiculo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
      this.placaveiculo.DataPropertyName = "placaveiculo";
      this.placaveiculo.HeaderText = "Placa";
      this.placaveiculo.Name = "placaveiculo";
      this.placaveiculo.ReadOnly = true;
      this.placaveiculo.Width = 57;
      // 
      // os_status
      // 
      this.os_status.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
      this.os_status.DataPropertyName = "os_status";
      this.os_status.HeaderText = "Estado";
      this.os_status.Name = "os_status";
      this.os_status.ReadOnly = true;
      this.os_status.Width = 65;
      // 
      // os_data
      // 
      this.os_data.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
      this.os_data.DataPropertyName = "os_data";
      this.os_data.HeaderText = "Data Entrada";
      this.os_data.Name = "os_data";
      this.os_data.ReadOnly = true;
      this.os_data.Width = 88;
      // 
      // os_datasaida
      // 
      this.os_datasaida.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
      this.os_datasaida.DataPropertyName = "os_datasaida";
      this.os_datasaida.HeaderText = "Data Saída";
      this.os_datasaida.Name = "os_datasaida";
      this.os_datasaida.ReadOnly = true;
      this.os_datasaida.Width = 78;
      // 
      // responsavel
      // 
      this.responsavel.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
      this.responsavel.DataPropertyName = "responsavel";
      this.responsavel.HeaderText = "Responsavel";
      this.responsavel.Name = "responsavel";
      this.responsavel.ReadOnly = true;
      this.responsavel.Width = 93;
      // 
      // telefone
      // 
      this.telefone.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
      this.telefone.DataPropertyName = "telefone";
      this.telefone.HeaderText = "Telefone";
      this.telefone.Name = "telefone";
      this.telefone.ReadOnly = true;
      this.telefone.Width = 74;
      // 
      // total
      // 
      this.total.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
      this.total.DataPropertyName = "total";
      this.total.HeaderText = "Total";
      this.total.Name = "total";
      this.total.ReadOnly = true;
      this.total.Width = 56;
      // 
      // defeito
      // 
      this.defeito.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
      this.defeito.DataPropertyName = "defeito";
      this.defeito.HeaderText = "Defeito Apresentado";
      this.defeito.Name = "defeito";
      this.defeito.ReadOnly = true;
      this.defeito.Width = 121;
      // 
      // rel_tecnico
      // 
      this.rel_tecnico.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
      this.rel_tecnico.DataPropertyName = "rel_tecnico";
      this.rel_tecnico.HeaderText = "Relatório Técnico";
      this.rel_tecnico.Name = "rel_tecnico";
      this.rel_tecnico.ReadOnly = true;
      this.rel_tecnico.Width = 105;
      // 
      // idmecanico
      // 
      this.idmecanico.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
      this.idmecanico.DataPropertyName = "idmecanico";
      this.idmecanico.HeaderText = "Cód. Mecânico";
      this.idmecanico.Name = "idmecanico";
      this.idmecanico.ReadOnly = true;
      this.idmecanico.Width = 94;
      // 
      // nome
      // 
      this.nome.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
      this.nome.DataPropertyName = "nome";
      this.nome.HeaderText = "Mecânico";
      this.nome.Name = "nome";
      this.nome.ReadOnly = true;
      this.nome.Visible = false;
      // 
      // idfinalizadora
      // 
      this.idfinalizadora.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
      this.idfinalizadora.DataPropertyName = "idfinalizadora";
      this.idfinalizadora.HeaderText = "Cód. Finalizadora";
      this.idfinalizadora.Name = "idfinalizadora";
      this.idfinalizadora.ReadOnly = true;
      this.idfinalizadora.Width = 106;
      // 
      // descricao
      // 
      this.descricao.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
      this.descricao.DataPropertyName = "descricao";
      this.descricao.HeaderText = "Forma de Pagamento";
      this.descricao.Name = "descricao";
      this.descricao.ReadOnly = true;
      this.descricao.Visible = false;
      // 
      // btnPesquisar
      // 
      this.btnPesquisar.Cursor = System.Windows.Forms.Cursors.Hand;
      this.btnPesquisar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
      this.btnPesquisar.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.btnPesquisar.Location = new System.Drawing.Point(818, 39);
      this.btnPesquisar.Name = "btnPesquisar";
      this.btnPesquisar.Size = new System.Drawing.Size(81, 23);
      this.btnPesquisar.TabIndex = 5;
      this.btnPesquisar.Text = "Pesquisar";
      this.btnPesquisar.UseVisualStyleBackColor = true;
      this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
      // 
      // butSair
      // 
      this.butSair.Cursor = System.Windows.Forms.Cursors.Hand;
      this.butSair.DialogResult = System.Windows.Forms.DialogResult.Cancel;
      this.butSair.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.butSair.Location = new System.Drawing.Point(830, 377);
      this.butSair.Name = "butSair";
      this.butSair.Size = new System.Drawing.Size(81, 23);
      this.butSair.TabIndex = 2;
      this.butSair.Text = "Sair";
      this.butSair.UseVisualStyleBackColor = true;
      this.butSair.Click += new System.EventHandler(this.butSair_Click);
      // 
      // tbPesqNumero
      // 
      this.tbPesqNumero.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
      this.tbPesqNumero.Location = new System.Drawing.Point(9, 41);
      this.tbPesqNumero.MaxLength = 8;
      this.tbPesqNumero.Name = "tbPesqNumero";
      this.tbPesqNumero.Size = new System.Drawing.Size(54, 21);
      this.tbPesqNumero.TabIndex = 0;
      this.tbPesqNumero.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbPesqNumero_KeyPress);
      // 
      // groupBox1
      // 
      this.groupBox1.Controls.Add(this.groupBox4);
      this.groupBox1.Controls.Add(this.groupBox3);
      this.groupBox1.Controls.Add(this.groupBox2);
      this.groupBox1.Controls.Add(this.label3);
      this.groupBox1.Controls.Add(this.label2);
      this.groupBox1.Controls.Add(this.label1);
      this.groupBox1.Controls.Add(this.tbPesqPlaca);
      this.groupBox1.Controls.Add(this.dtFim);
      this.groupBox1.Controls.Add(this.dtInicio);
      this.groupBox1.Controls.Add(this.radPeriodo);
      this.groupBox1.Controls.Add(this.radPlaca);
      this.groupBox1.Controls.Add(this.radNumero);
      this.groupBox1.Controls.Add(this.btnPesquisar);
      this.groupBox1.Controls.Add(this.tbPesqNumero);
      this.groupBox1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.groupBox1.Location = new System.Drawing.Point(3, 2);
      this.groupBox1.Name = "groupBox1";
      this.groupBox1.Size = new System.Drawing.Size(908, 68);
      this.groupBox1.TabIndex = 0;
      this.groupBox1.TabStop = false;
      this.groupBox1.Text = "Pesquisa por";
      // 
      // groupBox4
      // 
      this.groupBox4.Controls.Add(this.cbxEstado);
      this.groupBox4.Location = new System.Drawing.Point(124, 14);
      this.groupBox4.Name = "groupBox4";
      this.groupBox4.Size = new System.Drawing.Size(142, 47);
      this.groupBox4.TabIndex = 1;
      this.groupBox4.TabStop = false;
      this.groupBox4.Text = "Estado";
      // 
      // cbxEstado
      // 
      this.cbxEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
      this.cbxEstado.FormattingEnabled = true;
      this.cbxEstado.Items.AddRange(new object[] {
            "ABERTA",
            "FINALIZADA",
            "TODAS"});
      this.cbxEstado.Location = new System.Drawing.Point(6, 20);
      this.cbxEstado.Name = "cbxEstado";
      this.cbxEstado.Size = new System.Drawing.Size(121, 21);
      this.cbxEstado.TabIndex = 0;
      this.cbxEstado.SelectedIndexChanged += new System.EventHandler(this.cbxEstado_SelectedIndexChanged);
      // 
      // groupBox3
      // 
      this.groupBox3.Location = new System.Drawing.Point(284, 9);
      this.groupBox3.Name = "groupBox3";
      this.groupBox3.Size = new System.Drawing.Size(11, 52);
      this.groupBox3.TabIndex = 49;
      this.groupBox3.TabStop = false;
      // 
      // groupBox2
      // 
      this.groupBox2.Location = new System.Drawing.Point(93, 9);
      this.groupBox2.Name = "groupBox2";
      this.groupBox2.Size = new System.Drawing.Size(11, 52);
      this.groupBox2.TabIndex = 49;
      this.groupBox2.TabStop = false;
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label3.ForeColor = System.Drawing.SystemColors.ControlText;
      this.label3.Location = new System.Drawing.Point(301, 18);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(66, 13);
      this.label3.TabIndex = 48;
      this.label3.Text = "Filtrar por:";
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label2.Location = new System.Drawing.Point(601, 44);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(24, 13);
      this.label2.TabIndex = 46;
      this.label2.Text = "Até";
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label1.Location = new System.Drawing.Point(471, 44);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(20, 13);
      this.label1.TabIndex = 45;
      this.label1.Text = "De";
      // 
      // tbPesqPlaca
      // 
      this.tbPesqPlaca.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
      this.tbPesqPlaca.Location = new System.Drawing.Point(385, 41);
      this.tbPesqPlaca.MaxLength = 8;
      this.tbPesqPlaca.Name = "tbPesqPlaca";
      this.tbPesqPlaca.ReadOnly = true;
      this.tbPesqPlaca.Size = new System.Drawing.Size(72, 21);
      this.tbPesqPlaca.TabIndex = 2;
      this.tbPesqPlaca.TabStop = false;
      // 
      // dtFim
      // 
      this.dtFim.Enabled = false;
      this.dtFim.Format = System.Windows.Forms.DateTimePickerFormat.Short;
      this.dtFim.Location = new System.Drawing.Point(628, 40);
      this.dtFim.Name = "dtFim";
      this.dtFim.Size = new System.Drawing.Size(106, 21);
      this.dtFim.TabIndex = 4;
      this.dtFim.TabStop = false;
      // 
      // dtInicio
      // 
      this.dtInicio.Enabled = false;
      this.dtInicio.Format = System.Windows.Forms.DateTimePickerFormat.Short;
      this.dtInicio.Location = new System.Drawing.Point(492, 40);
      this.dtInicio.Name = "dtInicio";
      this.dtInicio.Size = new System.Drawing.Size(106, 21);
      this.dtInicio.TabIndex = 3;
      this.dtInicio.TabStop = false;
      // 
      // radPeriodo
      // 
      this.radPeriodo.AutoSize = true;
      this.radPeriodo.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.radPeriodo.Location = new System.Drawing.Point(474, 18);
      this.radPeriodo.Name = "radPeriodo";
      this.radPeriodo.Size = new System.Drawing.Size(61, 17);
      this.radPeriodo.TabIndex = 41;
      this.radPeriodo.Text = "P&eríodo";
      this.radPeriodo.UseVisualStyleBackColor = true;
      this.radPeriodo.CheckedChanged += new System.EventHandler(this.radPeriodo_CheckedChanged);
      // 
      // radPlaca
      // 
      this.radPlaca.AutoSize = true;
      this.radPlaca.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.radPlaca.Location = new System.Drawing.Point(385, 18);
      this.radPlaca.Name = "radPlaca";
      this.radPlaca.Size = new System.Drawing.Size(50, 17);
      this.radPlaca.TabIndex = 40;
      this.radPlaca.Text = "&Placa";
      this.radPlaca.UseVisualStyleBackColor = true;
      this.radPlaca.CheckedChanged += new System.EventHandler(this.radPlaca_CheckedChanged);
      // 
      // radNumero
      // 
      this.radNumero.AutoSize = true;
      this.radNumero.Checked = true;
      this.radNumero.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.radNumero.Location = new System.Drawing.Point(9, 18);
      this.radNumero.Name = "radNumero";
      this.radNumero.Size = new System.Drawing.Size(62, 17);
      this.radNumero.TabIndex = 39;
      this.radNumero.TabStop = true;
      this.radNumero.Text = "Número";
      this.radNumero.UseVisualStyleBackColor = true;
      this.radNumero.CheckedChanged += new System.EventHandler(this.radNumero_CheckedChanged);
      // 
      // FormGridOs
      // 
      this.AcceptButton = this.btnPesquisar;
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.CancelButton = this.butSair;
      this.ClientSize = new System.Drawing.Size(914, 404);
      this.Controls.Add(this.groupBox1);
      this.Controls.Add(this.butSair);
      this.Controls.Add(this.dataGridView1);
      this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
      this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
      this.MaximizeBox = false;
      this.Name = "FormGridOs";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "Consulta - Ordens de Serviço";
      this.Load += new System.EventHandler(this.FormGridOs_Load);
      ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
      this.groupBox1.ResumeLayout(false);
      this.groupBox1.PerformLayout();
      this.groupBox4.ResumeLayout(false);
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.DataGridView dataGridView1;
    private System.Windows.Forms.Button btnPesquisar;
    private System.Windows.Forms.Button butSair;
    private System.Windows.Forms.TextBox tbPesqNumero;
    private System.Windows.Forms.GroupBox groupBox1;
    private System.Windows.Forms.RadioButton radNumero;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.TextBox tbPesqPlaca;
    private System.Windows.Forms.DateTimePicker dtFim;
    private System.Windows.Forms.DateTimePicker dtInicio;
    private System.Windows.Forms.RadioButton radPeriodo;
    private System.Windows.Forms.RadioButton radPlaca;
    private System.Windows.Forms.DataGridViewTextBoxColumn id;
    private System.Windows.Forms.DataGridViewTextBoxColumn placaveiculo;
    private System.Windows.Forms.DataGridViewTextBoxColumn os_status;
    private System.Windows.Forms.DataGridViewTextBoxColumn os_data;
    private System.Windows.Forms.DataGridViewTextBoxColumn os_datasaida;
    private System.Windows.Forms.DataGridViewTextBoxColumn responsavel;
    private System.Windows.Forms.DataGridViewTextBoxColumn telefone;
    private System.Windows.Forms.DataGridViewTextBoxColumn total;
    private System.Windows.Forms.DataGridViewTextBoxColumn defeito;
    private System.Windows.Forms.DataGridViewTextBoxColumn rel_tecnico;
    private System.Windows.Forms.DataGridViewTextBoxColumn idmecanico;
    private System.Windows.Forms.DataGridViewTextBoxColumn nome;
    private System.Windows.Forms.DataGridViewTextBoxColumn idfinalizadora;
    private System.Windows.Forms.DataGridViewTextBoxColumn descricao;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.GroupBox groupBox2;
    private System.Windows.Forms.ComboBox cbxEstado;
    private System.Windows.Forms.GroupBox groupBox4;
    private System.Windows.Forms.GroupBox groupBox3;
  }
}