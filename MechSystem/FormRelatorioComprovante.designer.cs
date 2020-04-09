namespace MechSystem
{
  partial class FormRelatorioComprovante
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormRelatorioComprovante));
      this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
      this.dsRelatorioOs = new MechSystem.dsRelatorioOs();
      this.carroBindingSource = new System.Windows.Forms.BindingSource(this.components);
      this.carroTableAdapter = new MechSystem.dsRelatorioOsTableAdapters.carroTableAdapter();
      this.osBindingSource = new System.Windows.Forms.BindingSource(this.components);
      this.osTableAdapter = new MechSystem.dsRelatorioOsTableAdapters.osTableAdapter();
      ((System.ComponentModel.ISupportInitialize)(this.dsRelatorioOs)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.carroBindingSource)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.osBindingSource)).BeginInit();
      this.SuspendLayout();
      // 
      // reportViewer1
      // 
      this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
      reportDataSource1.Name = "dsRelatorioOs_carro";
      reportDataSource1.Value = this.carroBindingSource;
      reportDataSource2.Name = "dsRelatorioOs_os";
      reportDataSource2.Value = this.osBindingSource;
      this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
      this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
      this.reportViewer1.LocalReport.ReportEmbeddedResource = "MechSystem.RelComprovanteEntrada.rdlc";
      this.reportViewer1.Location = new System.Drawing.Point(0, 0);
      this.reportViewer1.Name = "reportViewer1";
      this.reportViewer1.ShowBackButton = false;
      this.reportViewer1.ShowDocumentMapButton = false;
      this.reportViewer1.ShowFindControls = false;
      this.reportViewer1.ShowStopButton = false;
      this.reportViewer1.Size = new System.Drawing.Size(659, 481);
      this.reportViewer1.TabIndex = 0;
      // 
      // dsRelatorioOs
      // 
      this.dsRelatorioOs.DataSetName = "dsRelatorioOs";
      this.dsRelatorioOs.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
      // osBindingSource
      // 
      this.osBindingSource.DataMember = "os";
      this.osBindingSource.DataSource = this.dsRelatorioOs;
      // 
      // osTableAdapter
      // 
      this.osTableAdapter.ClearBeforeFill = true;
      // 
      // FormRelatorioComprovante
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(659, 481);
      this.Controls.Add(this.reportViewer1);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
      this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
      this.Name = "FormRelatorioComprovante";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "Relatório - Comprovante de Entrada";
      this.Load += new System.EventHandler(this.FormRelatorioComprovante_Load);
      ((System.ComponentModel.ISupportInitialize)(this.dsRelatorioOs)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.carroBindingSource)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.osBindingSource)).EndInit();
      this.ResumeLayout(false);

    }

    #endregion

    private Microsoft.Reporting.WinForms.ReportViewer rptComprovante;
    private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
    private System.Windows.Forms.BindingSource carroBindingSource;
    private dsRelatorioOs dsRelatorioOs;
    private System.Windows.Forms.BindingSource osBindingSource;
    private MechSystem.dsRelatorioOsTableAdapters.carroTableAdapter carroTableAdapter;
    private MechSystem.dsRelatorioOsTableAdapters.osTableAdapter osTableAdapter;
  }
}