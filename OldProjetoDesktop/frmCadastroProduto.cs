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
    public partial class frmCadastroProduto : Form
    {
        public frmCadastroProduto()
        {
            InitializeComponent();
        }

        clProduto produto = new clProduto();

        private void cadastroDeCategoriaToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {

        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            

            produto.nome = txtNomeProduto.Text;
            produto.descricao = txtDescricaoProduto.Text;
            produto.valor = Convert.ToDecimal( txtPrecoProduto.Text.Replace(",",".") );
            produto.dataCadastro = Convert.ToDateTime(txtDataProduto.Text);
            produto.id_categoria = cmbCategoria.SelectedIndex;

            txtIDProduto.Text = Convert.ToString(produto.Salvar()); ;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtDataProduto_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void frmCadastroProduto_Load(object sender, EventArgs e)
        {
            txtDataProduto.Text = DateTime.Now.ToShortDateString();

            cmbCategoria.DataSource = produto.PesquisaCategoria();
            cmbCategoria.ValueMember = "id_categoria";
            cmbCategoria.DisplayMember = "nome";
            cmbCategoria.SelectedIndex = -1;
        }
    }
}
