using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MechSystem
{
  public partial class FormRelatorioComprovante : Form
  {
    //Atributos
    public int idOs;
    public string placa;

    public FormRelatorioComprovante()
    {
      InitializeComponent();
    }

    private void FormRelatorioComprovante_Load(object sender, EventArgs e)
    {
      // TODO: This line of code loads data into the 'dsRelatorioOs.carro' table. You can move, or remove it, as needed.
      this.carroTableAdapter.Fill(this.dsRelatorioOs.carro, placa);
      // TODO: This line of code loads data into the 'dsRelatorioOs.os' table. You can move, or remove it, as needed.
      this.osTableAdapter.Fill(this.dsRelatorioOs.os, idOs);

      this.reportViewer1.RefreshReport();
    }
  }
}
