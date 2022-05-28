
namespace OldProjetoDesktop
{
    partial class frmCadastroProduto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCadastroProduto));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.cadastroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mbtCadastroDeProduto = new System.Windows.Forms.ToolStripMenuItem();
            this.mbtCadastroDeCategoria = new System.Windows.Forms.ToolStripMenuItem();
            this.mbtCadastroDeFuncionario = new System.Windows.Forms.ToolStripMenuItem();
            this.mbtCadastroDeCliente = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bmtSair = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNomeProduto = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDescricaoProduto = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDataProduto = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtCodigoProduto = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtPrecoProduto = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtCategoriaProduto = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastroToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // cadastroToolStripMenuItem
            // 
            this.cadastroToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mbtCadastroDeProduto,
            this.mbtCadastroDeCategoria,
            this.mbtCadastroDeFuncionario,
            this.mbtCadastroDeCliente,
            this.toolStripSeparator1,
            this.bmtSair});
            this.cadastroToolStripMenuItem.Name = "cadastroToolStripMenuItem";
            this.cadastroToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.cadastroToolStripMenuItem.Text = "Cadastro";
            // 
            // mbtCadastroDeProduto
            // 
            this.mbtCadastroDeProduto.Name = "mbtCadastroDeProduto";
            this.mbtCadastroDeProduto.Size = new System.Drawing.Size(203, 22);
            this.mbtCadastroDeProduto.Text = "Cadastro de Categoria";
            // 
            // mbtCadastroDeCategoria
            // 
            this.mbtCadastroDeCategoria.Name = "mbtCadastroDeCategoria";
            this.mbtCadastroDeCategoria.Size = new System.Drawing.Size(203, 22);
            this.mbtCadastroDeCategoria.Text = "Cadastro de Cliente";
            this.mbtCadastroDeCategoria.Click += new System.EventHandler(this.cadastroDeCategoriaToolStripMenuItem_Click);
            // 
            // mbtCadastroDeFuncionario
            // 
            this.mbtCadastroDeFuncionario.Name = "mbtCadastroDeFuncionario";
            this.mbtCadastroDeFuncionario.Size = new System.Drawing.Size(203, 22);
            this.mbtCadastroDeFuncionario.Text = "Cadastro de Funcionario";
            // 
            // mbtCadastroDeCliente
            // 
            this.mbtCadastroDeCliente.Name = "mbtCadastroDeCliente";
            this.mbtCadastroDeCliente.Size = new System.Drawing.Size(203, 22);
            this.mbtCadastroDeCliente.Text = "Cadastro de Produto";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(200, 6);
            // 
            // bmtSair
            // 
            this.bmtSair.Name = "bmtSair";
            this.bmtSair.Size = new System.Drawing.Size(203, 22);
            this.bmtSair.Text = "Sair";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(9, 121);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nome Produto";
            // 
            // txtNomeProduto
            // 
            this.txtNomeProduto.Location = new System.Drawing.Point(12, 137);
            this.txtNomeProduto.Multiline = true;
            this.txtNomeProduto.Name = "txtNomeProduto";
            this.txtNomeProduto.Size = new System.Drawing.Size(574, 29);
            this.txtNomeProduto.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(261, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(292, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "CADASTRO DE PRODUTO";
            // 
            // txtDescricaoProduto
            // 
            this.txtDescricaoProduto.Location = new System.Drawing.Point(12, 260);
            this.txtDescricaoProduto.Multiline = true;
            this.txtDescricaoProduto.Name = "txtDescricaoProduto";
            this.txtDescricaoProduto.Size = new System.Drawing.Size(776, 81);
            this.txtDescricaoProduto.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(9, 244);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(159, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Descrição do Produto";
            // 
            // txtDataProduto
            // 
            this.txtDataProduto.Location = new System.Drawing.Point(641, 137);
            this.txtDataProduto.Multiline = true;
            this.txtDataProduto.Name = "txtDataProduto";
            this.txtDataProduto.Size = new System.Drawing.Size(147, 29);
            this.txtDataProduto.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(638, 121);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(130, 16);
            this.label4.TabIndex = 7;
            this.label4.Text = "Data do Cadastro";
            // 
            // txtCodigoProduto
            // 
            this.txtCodigoProduto.Location = new System.Drawing.Point(448, 195);
            this.txtCodigoProduto.Multiline = true;
            this.txtCodigoProduto.Name = "txtCodigoProduto";
            this.txtCodigoProduto.Size = new System.Drawing.Size(300, 29);
            this.txtCodigoProduto.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(445, 179);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(138, 16);
            this.label5.TabIndex = 9;
            this.label5.Text = "Código do Produto";
            // 
            // txtPrecoProduto
            // 
            this.txtPrecoProduto.Location = new System.Drawing.Point(12, 370);
            this.txtPrecoProduto.Multiline = true;
            this.txtPrecoProduto.Name = "txtPrecoProduto";
            this.txtPrecoProduto.Size = new System.Drawing.Size(251, 29);
            this.txtPrecoProduto.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(9, 354);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 16);
            this.label6.TabIndex = 11;
            this.label6.Text = "Preço R$";
            // 
            // txtCategoriaProduto
            // 
            this.txtCategoriaProduto.Location = new System.Drawing.Point(12, 195);
            this.txtCategoriaProduto.Multiline = true;
            this.txtCategoriaProduto.Name = "txtCategoriaProduto";
            this.txtCategoriaProduto.Size = new System.Drawing.Size(387, 29);
            this.txtCategoriaProduto.TabIndex = 15;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(9, 179);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(76, 16);
            this.label7.TabIndex = 14;
            this.label7.Text = "Categoria";
            // 
            // btnSalvar
            // 
            this.btnSalvar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(94)))), ((int)(((byte)(20)))));
            this.btnSalvar.Location = new System.Drawing.Point(524, 392);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(129, 46);
            this.btnSalvar.TabIndex = 34;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = false;
            this.btnSalvar.Click += new System.EventHandler(this.btnAtualizar_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(184)))), ((int)(((byte)(179)))));
            this.button1.Location = new System.Drawing.Point(659, 392);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(129, 46);
            this.button1.TabIndex = 35;
            this.button1.Text = "Cancelar";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // frmCadastroProduto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(229)))), ((int)(((byte)(219)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.txtCategoriaProduto);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtPrecoProduto);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtCodigoProduto);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtDataProduto);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtDescricaoProduto);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNomeProduto);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmCadastroProduto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Produto";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem cadastroToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mbtCadastroDeProduto;
        private System.Windows.Forms.ToolStripMenuItem mbtCadastroDeCategoria;
        private System.Windows.Forms.ToolStripMenuItem mbtCadastroDeCliente;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem bmtSair;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNomeProduto;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtDescricaoProduto;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtDataProduto;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtCodigoProduto;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtPrecoProduto;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtCategoriaProduto;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ToolStripMenuItem mbtCadastroDeFuncionario;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button button1;
    }
}