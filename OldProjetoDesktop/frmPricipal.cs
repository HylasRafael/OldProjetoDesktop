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
    }
}
