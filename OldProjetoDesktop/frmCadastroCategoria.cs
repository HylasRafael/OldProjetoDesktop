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
    public partial class frmCadastroCategoria : Form
    {
        public frmCadastroCategoria()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnCancelarVenda_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmCadastroCategoria_Load(object sender, EventArgs e)
        {

        }

        private void btnSalvarVenda_Click(object sender, EventArgs e)
        {
            clCategoria categoria = new clCategoria();

            categoria.nome = txtNomeCategoria.Text;

            txtIDCategoria.Text = Convert.ToString(categoria.Salvar()); ;
        }
    }
}
