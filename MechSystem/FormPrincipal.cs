using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Collections;
using System.Diagnostics;
using System.IO;
using System.Configuration;
using System.Threading;

namespace MechSystem
{
  
  public partial class FormPrincipal : Form
  {
    //Atributos
    FormCadClientes  frmCli = null;
    FormCadFornecedores frmForn = null;
    FormCadFuncao frmFuncao = null;
    FormCadFuncionarios frmFunc = null;
    FormCadProdutos frmProd = null;
    FormCadServicos frmServ = null;
    FormCadVeiculos frmVei = null;
    FormCadOs frmOs = null;
    FormCadUsuarios frmUsu = null;
    FormCadFinalizadoras frmFin = null;
    FormAjuEstoque frmAju = null;
    //FormLancNF frmNf = null;
    private int ibkp = 0;

    //Construtor
    public FormPrincipal()
    {
      InitializeComponent();
    }
    
    //Metodos Eventos
    private void sairToolStripMenuItem_Click(object sender, EventArgs e)
    {
      this.Close();
    }

    private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
    {
      bool open = false;
      foreach (Form frm in this.MdiChildren)
      {
        if (frm is FormCadClientes)
        {
          frm.BringToFront();
          open = true; 
        }
      }
      if (!open)
      {
        frmCli = new FormCadClientes(this);
        frmCli.Show();
      } 
    }

    private void carrosToolStripMenuItem_Click(object sender, EventArgs e)
    {
      bool open = false;
      foreach (Form frm in this.MdiChildren)
      {
        if (frm is FormCadVeiculos)
        {
          frm.BringToFront();
          open = true;
        }
      }
      if (!open)
      {
        frmVei = new FormCadVeiculos(this);
        frmVei.usuarioAtual = lblUsuario.Text;
        frmVei.Show();
      } 
    }

    private void fornecedoresToolStripMenuItem_Click(object sender, EventArgs e)
    {
      bool open = false;
      foreach (Form frm in this.MdiChildren)
      {
        if (frm is FormCadFornecedores)
        {
          frm.BringToFront();
          open = true;
        }
      }
      if (!open)
      {
        frmForn = new FormCadFornecedores(this);
        frmForn.Show();
      } 
    }

    private void produtosToolStripMenuItem_Click(object sender, EventArgs e)
    {
      bool open = false;
      foreach (Form frm in this.MdiChildren)
      {
        if (frm is FormCadProdutos)
        {
          frm.BringToFront();
          open = true;
        }
      }
      if (!open)
      {
        frmProd = new FormCadProdutos(this);
        frmProd.Show();
      } 
    }

    private void toolStripButton1_Click(object sender, EventArgs e)
    {
      bool open = false;
      foreach (Form frm in this.MdiChildren)
      {
        if (frm is FormCadClientes)
        {
          frm.BringToFront();
          open = true;
        }
      }
      if (!open)
      {
        frmCli = new FormCadClientes(this);
        frmCli.Show();
      } 
    }

    private void tsbtnVeiculos_Click(object sender, EventArgs e)
    {
      bool open = false;
      foreach (Form frm in this.MdiChildren)
      {
        if (frm is FormCadVeiculos)
        {
          frm.BringToFront();
          open = true;
        }
      }
      if (!open)
      {
        frmVei = new FormCadVeiculos(this);
        frmVei.usuarioAtual = lblUsuario.Text;
        frmVei.Show();
      } 
    }

    private void tsbtnFornecedores_Click(object sender, EventArgs e)
    {
      bool open = false;
      foreach (Form frm in this.MdiChildren)
      {
        if (frm is FormCadFornecedores)
        {
          frm.BringToFront();
          open = true;
        }
      }
      if (!open)
      {
        frmForn = new FormCadFornecedores(this);
        frmForn.Show();
      } 
    }

    private void tsbtnProdutos_Click(object sender, EventArgs e)
    {
      bool open = false;
      foreach (Form frm in this.MdiChildren)
      {
        if (frm is FormCadProdutos)
        {
          frm.BringToFront();
          open = true;
        }
      }
      if (!open)
      {
        frmProd = new FormCadProdutos(this);
        frmProd.Show();
      }
    }

    private void sobreToolStripMenuItem1_Click(object sender, EventArgs e)
    {
      AboutJM about = new AboutJM(this);
      about.Show();
    }

    private void mecânicosToolStripMenuItem_Click(object sender, EventArgs e)
    {
      bool open = false;
      foreach (Form frm in this.MdiChildren)
      {
        if (frm is FormCadFuncionarios)
        {
          frm.BringToFront();
          open = true;
        }
      }
      if (!open)
      {
        frmFunc = new FormCadFuncionarios(this);
        frmFunc.Show();
      }
    }

    private void toolStripButton2_Click(object sender, EventArgs e)
    {
      this.Close();
    }

    private void FormPrincipal_FormClosing(object sender, FormClosingEventArgs e)
    {
      DialogResult res = MessageBox.Show("Deseja realmente encerrar o aplicativo?", "Sair", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
      e.Cancel = (res == DialogResult.No);
    }

    private void cargosEFunçõesToolStripMenuItem_Click(object sender, EventArgs e)
    {
      bool open = false;
      foreach (Form frm in this.MdiChildren)
      {
        if (frm is FormCadFuncao)
        {
          frm.BringToFront();
          open = true;
        }
      }
      if (!open)
      {
        frmFuncao = new FormCadFuncao(this);
        frmFuncao.Show();
      }
    }

    private void usuáriosToolStripMenuItem_Click(object sender, EventArgs e)
    {
      bool open = false;
      foreach (Form frm in this.MdiChildren)
      {
        if (frm is FormCadUsuarios)
        {
          frm.BringToFront();
          open = true;
        }
      }
      if (!open)
      {
        frmUsu = new FormCadUsuarios(this);
        frmUsu.Show();
      }
    }

    private void serviçosToolStripMenuItem_Click(object sender, EventArgs e)
    {
      bool open = false;
      foreach (Form frm in this.MdiChildren)
      {
        if (frm is FormCadServicos)
        {
          frm.BringToFront();
          open = true;
        }
      }
      if (!open)
      {
        frmServ = new FormCadServicos(this);
        frmServ.Show();
      }
    }

    private void tsbtnServicos_Click(object sender, EventArgs e)
    {
      bool open = false;
      foreach (Form frm in this.MdiChildren)
      {
        if (frm is FormCadServicos)
        {
          frm.BringToFront();
          open = true;
        }
      }
      if (!open)
      {
        frmServ = new FormCadServicos(this);
        frmServ.Show();
      }
    }

    private void finalizadorasToolStripMenuItem_Click(object sender, EventArgs e)
    {
      bool open = false;
      foreach (Form frm in this.MdiChildren)
      {
        if (frm is FormCadFinalizadoras)
        {
          frm.BringToFront();
          open = true;
        }
      }
      if (!open)
      {
        frmFin = new FormCadFinalizadoras(this);
        frmFin.Show();
      }
    }

    private void novaToolStripMenuItem_Click(object sender, EventArgs e)
    {
      bool open = false;
      foreach (Form frm in this.MdiChildren)
      {
        if (frm is FormCadOs)
        {
          frm.BringToFront();
          open = true;
        }
      }
      if (!open)
      {
        frmOs = new FormCadOs(this);
        frmOs.usuarioAtual = lblUsuario.Text;
        frmOs.Show();
        frmOs.tbNumOs.Focus();
      }
    }

    private void ordemDeServiçoToolStripMenuItem_Click(object sender, EventArgs e)
    {
      bool open = false;
      foreach (Form frm in this.MdiChildren)
      {
        if (frm is FormCadOs)
        {
          frm.BringToFront();
          open = true;
        }
      }
      if (!open)
      {
        frmOs = new FormCadOs(this);
        frmOs.usuarioAtual = lblUsuario.Text;
        frmOs.Show();
        frmOs.tbNumOs.Focus();
      }
    }

    private void toolStripButton3_Click(object sender, EventArgs e)
    {
      bool open = false;
      foreach (Form frm in this.MdiChildren)
      {
        if (frm is FormCadOs)
        {
          frm.BringToFront();
          open = true;
        }
      }
      if (!open)
      {
        frmOs = new FormCadOs(this);
        frmOs.usuarioAtual = lblUsuario.Text;
        frmOs.Show();
        frmOs.tbNumOs.Focus();
      }
    }

    private void executarToolStripMenuItem_Click(object sender, EventArgs e)
    {
      DialogResult res = MessageBox.Show("Confirma a execução do backup do Banco de Dados?", "Backup", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
      if (res == DialogResult.Yes)
      {
        BancoDados bd = new BancoDados();
        //Thread t = new Thread(delegate() { bd.Backup_Process(); });
        Thread t = new Thread(bd.Backup_Process);
        t.Start();
        timer1.Enabled = true;
        //timer1.Start();
      }
    }

    private void abrirLocalDeBackupToolStripMenuItem_Click(object sender, EventArgs e)
    {
      BancoDados bd = new BancoDados();
      Process.Start("C:\\MM\\MechSystem\\Backup");
    }

    private void timer1_Tick(object sender, EventArgs e)
    {
      ibkp += 1;
      if (ibkp == 3)
      {
        BancoDados bd = new BancoDados();
        string velho = "C:\\MM\\MechSystem\\Backup\\mechsystem_db.sql";
        string novo = "C:\\MM\\MechSystem\\Backup\\" + bd.Backup_Nome() + ".sql";
        File.Move(velho, novo);
        ibkp = 0;
        //timer1.Enabled = false;        
        timer1.Dispose();
      }
    }

    private void ajustesToolStripMenuItem_Click(object sender, EventArgs e)
    {
      bool open = false;
      foreach (Form frm in this.MdiChildren)
      {
        if (frm is FormAjuEstoque)
        {
          frm.BringToFront();
          open = true;
        }
      }
      if (!open)
      {
        frmAju = new FormAjuEstoque(this);
        frmAju.Usuario = lblUsuario.Text;
        frmAju.Show();
      }
    }

    private void toolStripButton4_Click(object sender, EventArgs e)
    {
      bool open = false;
      foreach (Form frm in this.MdiChildren)
      {
        if (frm is FormAjuEstoque)
        {
          frm.BringToFront();
          open = true;
        }
      }
      if (!open)
      {
        frmAju = new FormAjuEstoque(this);
        frmAju.Usuario = lblUsuario.Text;
        frmAju.Show();
      }
    }

    private void porFornecedorToolStripMenuItem_Click(object sender, EventArgs e)
    {
      FormRelProdForn relProdForn = new FormRelProdForn();
      //relProdForn.MdiParent = this.ParentForm;
      relProdForn.Show();
    }

    private void sairToolStripMenuItem_Click_1(object sender, EventArgs e)
    {
      this.Close();
    }


  }
}
