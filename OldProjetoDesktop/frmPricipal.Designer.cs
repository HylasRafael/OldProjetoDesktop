
namespace OldProjetoDesktop
{
    partial class frmPricipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPricipal));
            this.frmPrincipal = new System.Windows.Forms.MenuStrip();
            this.cadastroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mbtCadastroDeProduto = new System.Windows.Forms.ToolStripMenuItem();
            this.mbtCadastroDeCategoria = new System.Windows.Forms.ToolStripMenuItem();
            this.mbtCadastroDeFuncionario = new System.Windows.Forms.ToolStripMenuItem();
            this.mbtCadastroDeCliente = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bmtSair = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.pesquisarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.produtoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.frmPrincipal.SuspendLayout();
            this.SuspendLayout();
            // 
            // frmPrincipal
            // 
            this.frmPrincipal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(229)))), ((int)(((byte)(219)))));
            this.frmPrincipal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastroToolStripMenuItem,
            this.toolStripSeparator2,
            this.pesquisarToolStripMenuItem});
            this.frmPrincipal.Location = new System.Drawing.Point(0, 0);
            this.frmPrincipal.Name = "frmPrincipal";
            this.frmPrincipal.Size = new System.Drawing.Size(800, 27);
            this.frmPrincipal.TabIndex = 18;
            this.frmPrincipal.Text = "Tela Principal";
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
            this.cadastroToolStripMenuItem.Size = new System.Drawing.Size(66, 23);
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
            this.mbtCadastroDeCategoria.Click += new System.EventHandler(this.mbtCadastroDeCategoria_Click);
            // 
            // mbtCadastroDeFuncionario
            // 
            this.mbtCadastroDeFuncionario.Name = "mbtCadastroDeFuncionario";
            this.mbtCadastroDeFuncionario.Size = new System.Drawing.Size(203, 22);
            this.mbtCadastroDeFuncionario.Text = "Cadastro de Funcionario";
            this.mbtCadastroDeFuncionario.Click += new System.EventHandler(this.mbtCadastroDeFuncionario_Click);
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
            this.bmtSair.Click += new System.EventHandler(this.bmtSair_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 23);
            // 
            // pesquisarToolStripMenuItem
            // 
            this.pesquisarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clienteToolStripMenuItem,
            this.produtoToolStripMenuItem,
            this.toolStripSeparator3});
            this.pesquisarToolStripMenuItem.Name = "pesquisarToolStripMenuItem";
            this.pesquisarToolStripMenuItem.Size = new System.Drawing.Size(69, 23);
            this.pesquisarToolStripMenuItem.Text = "Pesquisar";
            // 
            // clienteToolStripMenuItem
            // 
            this.clienteToolStripMenuItem.Name = "clienteToolStripMenuItem";
            this.clienteToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
            this.clienteToolStripMenuItem.Text = "Cliente";
            this.clienteToolStripMenuItem.Click += new System.EventHandler(this.clienteToolStripMenuItem_Click);
            // 
            // produtoToolStripMenuItem
            // 
            this.produtoToolStripMenuItem.Name = "produtoToolStripMenuItem";
            this.produtoToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
            this.produtoToolStripMenuItem.Text = "Produto";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(114, 6);
            // 
            // frmPricipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::OldProjetoDesktop.Properties.Resources._3986728_online_shop_store_store_icon_112980;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.frmPrincipal);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmPricipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tela Principal";
            this.Load += new System.EventHandler(this.frmPricipal_Load);
            this.Shown += new System.EventHandler(this.frmPricipal_Shown);
            this.frmPrincipal.ResumeLayout(false);
            this.frmPrincipal.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip frmPrincipal;
        private System.Windows.Forms.ToolStripMenuItem cadastroToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mbtCadastroDeProduto;
        private System.Windows.Forms.ToolStripMenuItem mbtCadastroDeCategoria;
        private System.Windows.Forms.ToolStripMenuItem mbtCadastroDeFuncionario;
        private System.Windows.Forms.ToolStripMenuItem mbtCadastroDeCliente;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem bmtSair;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem pesquisarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clienteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem produtoToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
    }
}