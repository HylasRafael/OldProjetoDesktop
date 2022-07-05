﻿using System;
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
    public partial class frmConsultaCliente : Form
    {
        public frmConsultaCliente()
        {
            InitializeComponent();
        }

        clCliente cliente = new clCliente();

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmConsultaCliente_Load(object sender, EventArgs e)
        {

        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (dgvCliente.SelectedRows.Count > 0)
            {
                DataGridViewSelectedRowCollection linha = dgvCliente.SelectedRows;
                cliente.IDCliente = int.Parse(linha[0].Cells[0].Value.ToString());

                DialogResult resposta = MessageBox.Show("Você tem certeza que deseja excluir o cliente " + linha[0].Cells[1].Value.ToString() + " ?", "Tem certeza?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (resposta == DialogResult.Yes)
                {
                    cliente.Excluir();
                    txtPesquisaCliente_TextChanged(null, null);
                }
            }
            else
            {
                MessageBox.Show("Você precisa selecionar um cliente para poder exclui-lo!", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void txtPesquisaCliente_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (txtPesquisaCliente.Text != "")
                {
                    cliente.nome = txtPesquisaCliente.Text;
                    dgvCliente.DataSource = cliente.PesquisaPorNome();
                }

                dgvCliente.Columns[0].Visible = false;
                dgvCliente.Columns[3].Visible = false;
                dgvCliente.Columns[4].Visible = false;
                dgvCliente.Columns[5].Visible = false;
                dgvCliente.Columns[6].Visible = false;
                dgvCliente.Columns[7].Visible = false;
                dgvCliente.Columns[8].Visible = false;

                dgvCliente.Columns[1].Width = 200;

            }
            catch (Exception ex)
            {
                MessageBox.Show("ERRO.: " + ex.Message);
            }
        }

        private void dgvCliente_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
