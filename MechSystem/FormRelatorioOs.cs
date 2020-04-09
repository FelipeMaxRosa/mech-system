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
  public partial class FormRelatorioOs : Form
  {
    //Atributos
    public int idOs;
    public int idFinalizadora;
    public string placa;
    public int idMecanico;

    public FormRelatorioOs()
    {
        InitializeComponent();
    }

    private void FormRelatorioOs_Load(object sender, EventArgs e)
    {
      // TODO: This line of code loads data into the 'dsRelatorioOs.os_servico' table. You can move, or remove it, as needed.
      this.os_servicoTableAdapter.Fill(this.dsRelatorioOs.os_servico, idOs);
      // TODO: This line of code loads data into the 'dsRelatorioOs.finalizadoras' table. You can move, or remove it, as needed.
      this.finalizadorasTableAdapter.Fill(this.dsRelatorioOs.finalizadoras, idFinalizadora);
      // TODO: This line of code loads data into the 'dsRelatorioOs.os_produto' table. You can move, or remove it, as needed.
      this.os_produtoTableAdapter.Fill(this.dsRelatorioOs.os_produto, idOs);
      // TODO: This line of code loads data into the 'dsRelatorioOs.carro' table. You can move, or remove it, as needed.
      this.carroTableAdapter.Fill(this.dsRelatorioOs.carro, placa);
      // TODO: This line of code loads data into the 'dsRelatorioOs.mecanico' table. You can move, or remove it, as needed.
      this.mecanicoTableAdapter.Fill(this.dsRelatorioOs.mecanico, idMecanico);
      // TODO: This line of code loads data into the 'dsRelatorioOs.os' table. You can move, or remove it, as needed.
      this.osTableAdapter.Fill(this.dsRelatorioOs.os, idOs);

      this.rptOs.RefreshReport();
    }
  }
}
