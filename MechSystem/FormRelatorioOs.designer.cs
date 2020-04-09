namespace MechSystem
{
    partial class FormRelatorioOs
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
          this.components = new System.ComponentModel.Container();
          Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
          Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
          Microsoft.Reporting.WinForms.ReportDataSource reportDataSource3 = new Microsoft.Reporting.WinForms.ReportDataSource();
          Microsoft.Reporting.WinForms.ReportDataSource reportDataSource4 = new Microsoft.Reporting.WinForms.ReportDataSource();
          Microsoft.Reporting.WinForms.ReportDataSource reportDataSource5 = new Microsoft.Reporting.WinForms.ReportDataSource();
          Microsoft.Reporting.WinForms.ReportDataSource reportDataSource6 = new Microsoft.Reporting.WinForms.ReportDataSource();
          System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormRelatorioOs));
          this.rptOs = new Microsoft.Reporting.WinForms.ReportViewer();
          this.dsRelatorioOs = new MechSystem.dsRelatorioOs();
          this.osBindingSource = new System.Windows.Forms.BindingSource(this.components);
          this.osTableAdapter = new MechSystem.dsRelatorioOsTableAdapters.osTableAdapter();
          this.mecanicoBindingSource = new System.Windows.Forms.BindingSource(this.components);
          this.mecanicoTableAdapter = new MechSystem.dsRelatorioOsTableAdapters.mecanicoTableAdapter();
          this.carroBindingSource = new System.Windows.Forms.BindingSource(this.components);
          this.carroTableAdapter = new MechSystem.dsRelatorioOsTableAdapters.carroTableAdapter();
          this.os_produtoBindingSource = new System.Windows.Forms.BindingSource(this.components);
          this.os_produtoTableAdapter = new MechSystem.dsRelatorioOsTableAdapters.os_produtoTableAdapter();
          this.finalizadorasBindingSource = new System.Windows.Forms.BindingSource(this.components);
          this.finalizadorasTableAdapter = new MechSystem.dsRelatorioOsTableAdapters.finalizadorasTableAdapter();
          this.os_servicoBindingSource = new System.Windows.Forms.BindingSource(this.components);
          this.os_servicoTableAdapter = new MechSystem.dsRelatorioOsTableAdapters.os_servicoTableAdapter();
          ((System.ComponentModel.ISupportInitialize)(this.dsRelatorioOs)).BeginInit();
          ((System.ComponentModel.ISupportInitialize)(this.osBindingSource)).BeginInit();
          ((System.ComponentModel.ISupportInitialize)(this.mecanicoBindingSource)).BeginInit();
          ((System.ComponentModel.ISupportInitialize)(this.carroBindingSource)).BeginInit();
          ((System.ComponentModel.ISupportInitialize)(this.os_produtoBindingSource)).BeginInit();
          ((System.ComponentModel.ISupportInitialize)(this.finalizadorasBindingSource)).BeginInit();
          ((System.ComponentModel.ISupportInitialize)(this.os_servicoBindingSource)).BeginInit();
          this.SuspendLayout();
          // 
          // rptOs
          // 
          this.rptOs.Dock = System.Windows.Forms.DockStyle.Fill;
          reportDataSource1.Name = "dsRelatorioOs_os";
          reportDataSource1.Value = this.osBindingSource;
          reportDataSource2.Name = "dsRelatorioOs_mecanico";
          reportDataSource2.Value = this.mecanicoBindingSource;
          reportDataSource3.Name = "dsRelatorioOs_carro";
          reportDataSource3.Value = this.carroBindingSource;
          reportDataSource4.Name = "dsRelatorioOs_os_produto";
          reportDataSource4.Value = this.os_produtoBindingSource;
          reportDataSource5.Name = "dsRelatorioOs_finalizadoras";
          reportDataSource5.Value = this.finalizadorasBindingSource;
          reportDataSource6.Name = "dsRelatorioOs_os_servico";
          reportDataSource6.Value = this.os_servicoBindingSource;
          this.rptOs.LocalReport.DataSources.Add(reportDataSource1);
          this.rptOs.LocalReport.DataSources.Add(reportDataSource2);
          this.rptOs.LocalReport.DataSources.Add(reportDataSource3);
          this.rptOs.LocalReport.DataSources.Add(reportDataSource4);
          this.rptOs.LocalReport.DataSources.Add(reportDataSource5);
          this.rptOs.LocalReport.DataSources.Add(reportDataSource6);
          this.rptOs.LocalReport.ReportEmbeddedResource = "MechSystem.RelOs.rdlc";
          this.rptOs.Location = new System.Drawing.Point(0, 0);
          this.rptOs.Name = "rptOs";
          this.rptOs.ShowBackButton = false;
          this.rptOs.ShowDocumentMapButton = false;
          this.rptOs.ShowFindControls = false;
          this.rptOs.ShowStopButton = false;
          this.rptOs.Size = new System.Drawing.Size(659, 481);
          this.rptOs.TabIndex = 0;
          // 
          // dsRelatorioOs
          // 
          this.dsRelatorioOs.DataSetName = "dsRelatorioOs";
          this.dsRelatorioOs.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
          // 
          // osBindingSource
          // 
          this.osBindingSource.DataMember = "os";
          this.osBindingSource.DataSource = this.dsRelatorioOs;
          // 
          // osTableAdapter
          // 
          this.osTableAdapter.ClearBeforeFill = true;
          // 
          // mecanicoBindingSource
          // 
          this.mecanicoBindingSource.DataMember = "mecanico";
          this.mecanicoBindingSource.DataSource = this.dsRelatorioOs;
          // 
          // mecanicoTableAdapter
          // 
          this.mecanicoTableAdapter.ClearBeforeFill = true;
          // 
          // carroBindingSource
          // 
          this.carroBindingSource.DataMember = "carro";
          this.carroBindingSource.DataSource = this.dsRelatorioOs;
          // 
          // carroTableAdapter
          // 
          this.carroTableAdapter.ClearBeforeFill = true;
          // 
          // os_produtoBindingSource
          // 
          this.os_produtoBindingSource.DataMember = "os_produto";
          this.os_produtoBindingSource.DataSource = this.dsRelatorioOs;
          // 
          // os_produtoTableAdapter
          // 
          this.os_produtoTableAdapter.ClearBeforeFill = true;
          // 
          // finalizadorasBindingSource
          // 
          this.finalizadorasBindingSource.DataMember = "finalizadoras";
          this.finalizadorasBindingSource.DataSource = this.dsRelatorioOs;
          // 
          // finalizadorasTableAdapter
          // 
          this.finalizadorasTableAdapter.ClearBeforeFill = true;
          // 
          // os_servicoBindingSource
          // 
          this.os_servicoBindingSource.DataMember = "os_servico";
          this.os_servicoBindingSource.DataSource = this.dsRelatorioOs;
          // 
          // os_servicoTableAdapter
          // 
          this.os_servicoTableAdapter.ClearBeforeFill = true;
          // 
          // FormRelatorioOs
          // 
          this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
          this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
          this.ClientSize = new System.Drawing.Size(659, 481);
          this.Controls.Add(this.rptOs);
          this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
          this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
          this.Name = "FormRelatorioOs";
          this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
          this.Text = "Relatório - Ordem de Serviço";
          this.Load += new System.EventHandler(this.FormRelatorioOs_Load);
          ((System.ComponentModel.ISupportInitialize)(this.dsRelatorioOs)).EndInit();
          ((System.ComponentModel.ISupportInitialize)(this.osBindingSource)).EndInit();
          ((System.ComponentModel.ISupportInitialize)(this.mecanicoBindingSource)).EndInit();
          ((System.ComponentModel.ISupportInitialize)(this.carroBindingSource)).EndInit();
          ((System.ComponentModel.ISupportInitialize)(this.os_produtoBindingSource)).EndInit();
          ((System.ComponentModel.ISupportInitialize)(this.finalizadorasBindingSource)).EndInit();
          ((System.ComponentModel.ISupportInitialize)(this.os_servicoBindingSource)).EndInit();
          this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer rptOs;
        private System.Windows.Forms.BindingSource osBindingSource;
        private dsRelatorioOs dsRelatorioOs;
        private System.Windows.Forms.BindingSource mecanicoBindingSource;
        private System.Windows.Forms.BindingSource carroBindingSource;
        private System.Windows.Forms.BindingSource os_produtoBindingSource;
        private System.Windows.Forms.BindingSource finalizadorasBindingSource;
        private System.Windows.Forms.BindingSource os_servicoBindingSource;
        private MechSystem.dsRelatorioOsTableAdapters.osTableAdapter osTableAdapter;
        private MechSystem.dsRelatorioOsTableAdapters.mecanicoTableAdapter mecanicoTableAdapter;
        private MechSystem.dsRelatorioOsTableAdapters.carroTableAdapter carroTableAdapter;
        private MechSystem.dsRelatorioOsTableAdapters.os_produtoTableAdapter os_produtoTableAdapter;
        private MechSystem.dsRelatorioOsTableAdapters.finalizadorasTableAdapter finalizadorasTableAdapter;
        private MechSystem.dsRelatorioOsTableAdapters.os_servicoTableAdapter os_servicoTableAdapter;
    }
}