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
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        clUsuario usuario = new clUsuario();

        private void txtRE_TextChanged(object sender, EventArgs e)
        {

        }

        private void frmLogin_Load(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
             usuario.re = txtRE.Text;
            DataTable dt = usuario.EfetuarLogin();

            if (dt.Rows.Count > 0)
            {
                string SENHA = dt.Rows[0]["SENHA"].ToString();
                if (txtSenha.Text == SENHA)
                {
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Erro, senha inválida", "Dados inválidos", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
            }
            else
            {
                MessageBox.Show("Erro, login inválido", "Dados inválidos", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }

        private void txtSenha_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txtSenha_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.Handled = true;
                e.SuppressKeyPress = true;
                btnLogin_Click(null, null);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void txtRE_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.Handled = true;
                txtSenha.Focus();
            }
        }
    }
    
}
