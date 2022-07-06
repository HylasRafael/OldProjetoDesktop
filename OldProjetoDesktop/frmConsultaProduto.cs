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
    public partial class frmConsultaProduto : Form
    {
        public frmConsultaProduto()
        {
            InitializeComponent();
        }

        clProduto produto = new clProduto();


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvCliente_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (dgvProduto.SelectedRows.Count > 0)
            {
                DataGridViewSelectedRowCollection linha = dgvProduto.SelectedRows;
                produto.IDProduto = int.Parse(linha[0].Cells[0].Value.ToString());

                DialogResult resposta = MessageBox.Show(" Você tem certeza que deseja excluir o Produto? " + linha[0].Cells[1].Value.ToString() + " ?", "Tem certeza?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (resposta == DialogResult.Yes)
                {
                    
                }
            }
            else
            {
                MessageBox.Show("Você precisa selecionar um Produto para poder exclui-lo!", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void txtPesquisaCliente_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (txtPesquisaProduto.Text != "")
                {
                    produto.nome = txtPesquisaProduto.Text;
                    dgvProduto.DataSource = produto.PesquisaPorNome();
                }

                dgvProduto.Columns[1].Visible = false;               
                dgvProduto.Columns[2].Visible = false;

                
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error.: " + ex.Message);
            }
        }

        private void frmConsultaProduto_Load(object sender, EventArgs e)
        {

        }
    }
}
