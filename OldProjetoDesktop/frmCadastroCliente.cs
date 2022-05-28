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
    public partial class frmCadastroCliente : Form
    {
        public frmCadastroCliente()
        {
            InitializeComponent();
        }

        private void frmCadastroCliente_Load(object sender, EventArgs e)
        {
            txtDataCliente.Text = DateTime.Now.ToShortDateString();
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            clCliente cliente = new clCliente();
                        
            cliente.nome = txtNomeCliente.Text;            
            cliente.CPF = txtCPFCliente.Text;
            cliente.telefone = txtTelefone.Text;
            cliente.endereco = txtEndereco.Text;
            cliente.bairro = txtBairro.Text;
            cliente.cidade = txtCidade.Text;
            cliente.UF = txtUF.Text;
            cliente.dataNascimento = Convert.ToDateTime(txtDataNascimento.Text);
            cliente.dataCadastro = Convert.ToDateTime(txtDataCliente.Text);
            
            txtIDCliente.Text = Convert.ToString(cliente.Salvar()); ;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bmtSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
