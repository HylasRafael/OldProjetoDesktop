
namespace OldProjetoDesktop
{
    partial class frmConsultaProduto
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
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnAtualizar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.dgvProduto = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPesquisaProduto = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProduto)).BeginInit();
            this.SuspendLayout();
            // 
            // btnExcluir
            // 
            this.btnExcluir.BackColor = System.Drawing.Color.Red;
            this.btnExcluir.Location = new System.Drawing.Point(393, 500);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(129, 46);
            this.btnExcluir.TabIndex = 28;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = false;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnAtualizar
            // 
            this.btnAtualizar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(94)))), ((int)(((byte)(20)))));
            this.btnAtualizar.Location = new System.Drawing.Point(258, 500);
            this.btnAtualizar.Name = "btnAtualizar";
            this.btnAtualizar.Size = new System.Drawing.Size(129, 46);
            this.btnAtualizar.TabIndex = 27;
            this.btnAtualizar.Text = "Atualizar";
            this.btnAtualizar.UseVisualStyleBackColor = false;
            this.btnAtualizar.Click += new System.EventHandler(this.btnAtualizar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(184)))), ((int)(((byte)(179)))));
            this.btnCancelar.Location = new System.Drawing.Point(527, 500);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(129, 46);
            this.btnCancelar.TabIndex = 29;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // dgvProduto
            // 
            this.dgvProduto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProduto.Location = new System.Drawing.Point(14, 165);
            this.dgvProduto.Name = "dgvProduto";
            this.dgvProduto.Size = new System.Drawing.Size(642, 260);
            this.dgvProduto.TabIndex = 32;
            this.dgvProduto.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCliente_CellContentClick);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(11, 84);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(129, 16);
            this.label4.TabIndex = 31;
            this.label4.Text = "Nome do Produto";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(183, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(305, 25);
            this.label1.TabIndex = 30;
            this.label1.Text = "CONSULTA DE PRODUTOS";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtPesquisaProduto
            // 
            this.txtPesquisaProduto.Location = new System.Drawing.Point(14, 103);
            this.txtPesquisaProduto.Name = "txtPesquisaProduto";
            this.txtPesquisaProduto.Size = new System.Drawing.Size(642, 20);
            this.txtPesquisaProduto.TabIndex = 26;
            this.txtPesquisaProduto.TextChanged += new System.EventHandler(this.txtPesquisaCliente_TextChanged);
            // 
            // frmConsultaProduto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(229)))), ((int)(((byte)(219)))));
            this.ClientSize = new System.Drawing.Size(677, 567);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnAtualizar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.dgvProduto);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtPesquisaProduto);
            this.Name = "frmConsultaProduto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Consulta de Produto";
            this.Load += new System.EventHandler(this.frmConsultaProduto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProduto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnAtualizar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.DataGridView dgvProduto;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPesquisaProduto;
    }
}