
namespace OldProjetoDesktop
{
    partial class frmVenda
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmVenda));
            this.txtDataVenda = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtIdVenda = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnRemoverProduto = new System.Windows.Forms.Button();
            this.btnAdicionarProduto = new System.Windows.Forms.Button();
            this.txtCPFCliente = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtNomeCliente = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dgvProdutos = new System.Windows.Forms.DataGridView();
            this.lblValorTotal = new System.Windows.Forms.Label();
            this.btnCancelarVenda = new System.Windows.Forms.Button();
            this.btnSalvarVenda = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProdutos)).BeginInit();
            this.SuspendLayout();
            // 
            // txtDataVenda
            // 
            this.txtDataVenda.Location = new System.Drawing.Point(132, 115);
            this.txtDataVenda.Multiline = true;
            this.txtDataVenda.Name = "txtDataVenda";
            this.txtDataVenda.Size = new System.Drawing.Size(147, 29);
            this.txtDataVenda.TabIndex = 27;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(129, 99);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(112, 16);
            this.label4.TabIndex = 26;
            this.label4.Text = "Data da Venda";
            // 
            // txtIdVenda
            // 
            this.txtIdVenda.Location = new System.Drawing.Point(12, 115);
            this.txtIdVenda.Multiline = true;
            this.txtIdVenda.Name = "txtIdVenda";
            this.txtIdVenda.Size = new System.Drawing.Size(114, 29);
            this.txtIdVenda.TabIndex = 25;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(9, 99);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(23, 16);
            this.label1.TabIndex = 24;
            this.label1.Text = "ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(392, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(273, 25);
            this.label2.TabIndex = 28;
            this.label2.Text = "CADASTRO DE VENDAS";
            // 
            // btnRemoverProduto
            // 
            this.btnRemoverProduto.Location = new System.Drawing.Point(537, 266);
            this.btnRemoverProduto.Name = "btnRemoverProduto";
            this.btnRemoverProduto.Size = new System.Drawing.Size(105, 28);
            this.btnRemoverProduto.TabIndex = 34;
            this.btnRemoverProduto.Text = "Remover";
            this.btnRemoverProduto.UseVisualStyleBackColor = true;
            // 
            // btnAdicionarProduto
            // 
            this.btnAdicionarProduto.Location = new System.Drawing.Point(426, 266);
            this.btnAdicionarProduto.Name = "btnAdicionarProduto";
            this.btnAdicionarProduto.Size = new System.Drawing.Size(105, 28);
            this.btnAdicionarProduto.TabIndex = 35;
            this.btnAdicionarProduto.Text = "Adicionar";
            this.btnAdicionarProduto.UseVisualStyleBackColor = true;
            // 
            // txtCPFCliente
            // 
            this.txtCPFCliente.Location = new System.Drawing.Point(12, 172);
            this.txtCPFCliente.Multiline = true;
            this.txtCPFCliente.Name = "txtCPFCliente";
            this.txtCPFCliente.Size = new System.Drawing.Size(254, 29);
            this.txtCPFCliente.TabIndex = 41;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(9, 156);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(89, 16);
            this.label6.TabIndex = 40;
            this.label6.Text = "CPF Cliente";
            // 
            // txtNomeCliente
            // 
            this.txtNomeCliente.Location = new System.Drawing.Point(272, 172);
            this.txtNomeCliente.Multiline = true;
            this.txtNomeCliente.Name = "txtNomeCliente";
            this.txtNomeCliente.Size = new System.Drawing.Size(776, 29);
            this.txtNomeCliente.TabIndex = 43;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(269, 156);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(56, 16);
            this.label7.TabIndex = 42;
            this.label7.Text = "Cliente";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(463, 226);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(138, 25);
            this.label3.TabIndex = 44;
            this.label3.Text = "PRODUTOS";
            // 
            // dgvProdutos
            // 
            this.dgvProdutos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProdutos.Location = new System.Drawing.Point(26, 314);
            this.dgvProdutos.Name = "dgvProdutos";
            this.dgvProdutos.Size = new System.Drawing.Size(1022, 150);
            this.dgvProdutos.TabIndex = 45;
            this.dgvProdutos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // lblValorTotal
            // 
            this.lblValorTotal.AutoSize = true;
            this.lblValorTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValorTotal.Location = new System.Drawing.Point(33, 534);
            this.lblValorTotal.Name = "lblValorTotal";
            this.lblValorTotal.Size = new System.Drawing.Size(87, 25);
            this.lblValorTotal.TabIndex = 46;
            this.lblValorTotal.Text = "R$0,00";
            // 
            // btnCancelarVenda
            // 
            this.btnCancelarVenda.Location = new System.Drawing.Point(894, 554);
            this.btnCancelarVenda.Name = "btnCancelarVenda";
            this.btnCancelarVenda.Size = new System.Drawing.Size(154, 44);
            this.btnCancelarVenda.TabIndex = 48;
            this.btnCancelarVenda.Text = "Cancelar";
            this.btnCancelarVenda.UseVisualStyleBackColor = true;
            // 
            // btnSalvarVenda
            // 
            this.btnSalvarVenda.Location = new System.Drawing.Point(709, 554);
            this.btnSalvarVenda.Name = "btnSalvarVenda";
            this.btnSalvarVenda.Size = new System.Drawing.Size(154, 44);
            this.btnSalvarVenda.TabIndex = 47;
            this.btnSalvarVenda.Text = "Salvar";
            this.btnSalvarVenda.UseVisualStyleBackColor = true;
            // 
            // frmVenda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(229)))), ((int)(((byte)(219)))));
            this.ClientSize = new System.Drawing.Size(1069, 621);
            this.Controls.Add(this.btnCancelarVenda);
            this.Controls.Add(this.btnSalvarVenda);
            this.Controls.Add(this.lblValorTotal);
            this.Controls.Add(this.dgvProdutos);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtNomeCliente);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtCPFCliente);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnAdicionarProduto);
            this.Controls.Add(this.btnRemoverProduto);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtDataVenda);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtIdVenda);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmVenda";
            this.Text = "Vendas";
            this.Load += new System.EventHandler(this.frmVenda_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProdutos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtDataVenda;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtIdVenda;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnRemoverProduto;
        private System.Windows.Forms.Button btnAdicionarProduto;
        private System.Windows.Forms.TextBox txtCPFCliente;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtNomeCliente;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dgvProdutos;
        private System.Windows.Forms.Label lblValorTotal;
        private System.Windows.Forms.Button btnCancelarVenda;
        private System.Windows.Forms.Button btnSalvarVenda;
    }
}