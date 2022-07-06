using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OldProjetoDesktop
{
    public partial class frmPricipal : Form
    {
        public frmPricipal()
        {
            InitializeComponent();
        }

        private void mbtCadastroDeCategoria_Click(object sender, EventArgs e)
        {
            frmCadastroCliente formulario = new frmCadastroCliente();
            formulario.ShowDialog();
        }

        private void frmPricipal_Shown(object sender, EventArgs e)
        {
            frmLogin formulario = new frmLogin();
            formulario.ShowDialog();
        }

        private void frmPricipal_Load(object sender, EventArgs e)
        {

        }

        private void clienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmConsultaCliente consultaCliente = new frmConsultaCliente();
            consultaCliente.ShowDialog();
        }

        private void bmtSair_Click(object sender, EventArgs e)
        {
            frmLogin formulario = new frmLogin();
            formulario.ShowDialog();
           
        }

        private void mbtCadastroDeFuncionario_Click(object sender, EventArgs e)
        {
            frmCadastroFuncionario formulario = new frmCadastroFuncionario();
            formulario.ShowDialog();
        }

        private void mbtCadastroDeCategoria_Click_1(object sender, EventArgs e)
        {
            frmCadastroCategoria formulario = new frmCadastroCategoria();
            formulario.ShowDialog();
        }

        private void mbtCadastroDeProduto_Click(object sender, EventArgs e)
        {
            frmCadastroProduto formulario = new frmCadastroProduto();
            formulario.ShowDialog();
        }

        private void mbtPesquisar_Click(object sender, EventArgs e)
        {

        }

        private void mbtVendas_Click(object sender, EventArgs e)
        {

        }

        private void mbtVender_Click(object sender, EventArgs e)
        {
            frmVenda formulario = new frmVenda();
            formulario.ShowDialog();
        }

        private void mbtPesquisaProduto_Click(object sender, EventArgs e)
        {
            frmConsultaProduto consultaProduto = new frmConsultaProduto();
            consultaProduto.ShowDialog();
        }
    }
}
