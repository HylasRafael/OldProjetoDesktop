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
    public partial class frmCadastroFuncionario : Form
    {
        public frmCadastroFuncionario()
        {
            InitializeComponent();
        }

        private void frmCadastroFuncionario_Load(object sender, EventArgs e)
        {
            txtDataFuncionario.Text = DateTime.Now.ToShortDateString();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            clFuncionario funcionario = new clFuncionario();

            funcionario.nome = txtNomeFuncionario.Text;
            funcionario.CPF = txtCPFFuncionario.Text;
            funcionario.senha = txtSenha.Text;
            funcionario.re = txtRE.Text;
            funcionario.dataCadastroFuncionario = Convert.ToDateTime(txtDataFuncionario.Text);

            txtIdFuncionario.Text = Convert.ToString(funcionario.Salvar()); ;
        }

        private void txtDataFuncionario_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}


