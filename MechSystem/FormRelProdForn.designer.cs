namespace MechSystem
{
  partial class FormRelProdForn
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormRelProdForn));
      this.fornecedorBindingSource = new System.Windows.Forms.BindingSource(this.components);
      this.dsProdForn = new MechSystem.dsProdForn();
      this.produtosBindingSource = new System.Windows.Forms.BindingSource(this.components);
      this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
      this.fornecedorTableAdapter = new MechSystem.dsProdFornTableAdapters.fornecedorTableAdapter();
      this.produtosTableAdapter = new MechSystem.dsProdFornTableAdapters.produtosTableAdapter();
      ((System.ComponentModel.ISupportInitialize)(this.fornecedorBindingSource)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.dsProdForn)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.produtosBindingSource)).BeginInit();
      this.SuspendLayout();
      // 
      // fornecedorBindingSource
      // 
      this.fornecedorBindingSource.DataMember = "fornecedor";
      this.fornecedorBindingSource.DataSource = this.dsProdForn;
      // 
      // dsProdForn
      // 
      this.dsProdForn.DataSetName = "dsProdForn";
      this.dsProdForn.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
      // 
      // produtosBindingSource
      // 
      this.produtosBindingSource.DataMember = "produtos";
      this.produtosBindingSource.DataSource = this.dsProdForn;
      // 
      // reportViewer1
      // 
      this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
      reportDataSource1.Name = "dsProdForn_fornecedor";
      reportDataSource1.Value = this.fornecedorBindingSource;
      reportDataSource2.Name = "dsProdForn_produtos";
      reportDataSource2.Value = this.produtosBindingSource;
      this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
      this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
      this.reportViewer1.LocalReport.ReportEmbeddedResource = "MechSystem.RelProdForn.rdlc";
      this.reportViewer1.Location = new System.Drawing.Point(0, 0);
      this.reportViewer1.Name = "reportViewer1";
      this.reportViewer1.ShowBackButton = false;
      this.reportViewer1.ShowDocumentMapButton = false;
      this.reportViewer1.ShowFindControls = false;
      this.reportViewer1.ShowStopButton = false;
      this.reportViewer1.Size = new System.Drawing.Size(659, 481);
      this.reportViewer1.TabIndex = 0;
      // 
      // fornecedorTableAdapter
      // 
      this.fornecedorTableAdapter.ClearBeforeFill = true;
      // 
      // produtosTableAdapter
      // 
      this.produtosTableAdapter.ClearBeforeFill = true;
      // 
      // FormRelProdForn
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(659, 481);
      this.Controls.Add(this.reportViewer1);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
      this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
      this.Name = "FormRelProdForn";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "Relatório - Produtos por Fornecedor";
      this.Load += new System.EventHandler(this.FormRelProdForn_Load);
      ((System.ComponentModel.ISupportInitialize)(this.fornecedorBindingSource)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.dsProdForn)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.produtosBindingSource)).EndInit();
      this.ResumeLayout(false);

    }

    #endregion

    private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
    private System.Windows.Forms.BindingSource fornecedorBindingSource;
    private dsProdForn dsProdForn;
    private System.Windows.Forms.BindingSource produtosBindingSource;
    private MechSystem.dsProdFornTableAdapters.fornecedorTableAdapter fornecedorTableAdapter;
    private MechSystem.dsProdFornTableAdapters.produtosTableAdapter produtosTableAdapter;
  }
}