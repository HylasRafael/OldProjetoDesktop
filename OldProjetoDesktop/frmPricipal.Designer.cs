
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
            this.mbtCadastro = new System.Windows.Forms.ToolStripMenuItem();
            this.mbtCadastroDeCategoria = new System.Windows.Forms.ToolStripMenuItem();
            this.mbtCadastroDeCliente = new System.Windows.Forms.ToolStripMenuItem();
            this.mbtCadastroDeFuncionario = new System.Windows.Forms.ToolStripMenuItem();
            this.mbtCadastroDeProduto = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bmtSair = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.mbtPesquisar = new System.Windows.Forms.ToolStripMenuItem();
            this.mbtPesquisaCliente = new System.Windows.Forms.ToolStripMenuItem();
            this.mbtPesquisaProduto = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.mbtVendas = new System.Windows.Forms.ToolStripMenuItem();
            this.mbtVender = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.frmPrincipal.SuspendLayout();
            this.SuspendLayout();
            // 
            // frmPrincipal
            // 
            this.frmPrincipal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(229)))), ((int)(((byte)(219)))));
            this.frmPrincipal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mbtCadastro,
            this.toolStripSeparator2,
            this.mbtPesquisar,
            this.toolStripSeparator4,
            this.mbtVendas,
            this.toolStripMenuItem1});
            this.frmPrincipal.Location = new System.Drawing.Point(0, 0);
            this.frmPrincipal.Name = "frmPrincipal";
            this.frmPrincipal.Size = new System.Drawing.Size(800, 27);
            this.frmPrincipal.TabIndex = 18;
            this.frmPrincipal.Text = "Tela Principal";
            // 
            // mbtCadastro
            // 
            this.mbtCadastro.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mbtCadastroDeCategoria,
            this.mbtCadastroDeCliente,
            this.mbtCadastroDeFuncionario,
            this.mbtCadastroDeProduto,
            this.toolStripSeparator1,
            this.bmtSair});
            this.mbtCadastro.Name = "mbtCadastro";
            this.mbtCadastro.Size = new System.Drawing.Size(66, 23);
            this.mbtCadastro.Text = "Cadastro";
            // 
            // mbtCadastroDeCategoria
            // 
            this.mbtCadastroDeCategoria.Name = "mbtCadastroDeCategoria";
            this.mbtCadastroDeCategoria.Size = new System.Drawing.Size(203, 22);
            this.mbtCadastroDeCategoria.Text = "Cadastro de Categoria";
            this.mbtCadastroDeCategoria.Click += new System.EventHandler(this.mbtCadastroDeCategoria_Click_1);
            // 
            // mbtCadastroDeCliente
            // 
            this.mbtCadastroDeCliente.Name = "mbtCadastroDeCliente";
            this.mbtCadastroDeCliente.Size = new System.Drawing.Size(203, 22);
            this.mbtCadastroDeCliente.Text = "Cadastro de Cliente";
            this.mbtCadastroDeCliente.Click += new System.EventHandler(this.mbtCadastroDeCategoria_Click);
            // 
            // mbtCadastroDeFuncionario
            // 
            this.mbtCadastroDeFuncionario.Name = "mbtCadastroDeFuncionario";
            this.mbtCadastroDeFuncionario.Size = new System.Drawing.Size(203, 22);
            this.mbtCadastroDeFuncionario.Text = "Cadastro de Funcionario";
            this.mbtCadastroDeFuncionario.Click += new System.EventHandler(this.mbtCadastroDeFuncionario_Click);
            // 
            // mbtCadastroDeProduto
            // 
            this.mbtCadastroDeProduto.Name = "mbtCadastroDeProduto";
            this.mbtCadastroDeProduto.Size = new System.Drawing.Size(203, 22);
            this.mbtCadastroDeProduto.Text = "Cadastro de Produto";
            this.mbtCadastroDeProduto.Click += new System.EventHandler(this.mbtCadastroDeProduto_Click);
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
            // mbtPesquisar
            // 
            this.mbtPesquisar.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mbtPesquisaCliente,
            this.mbtPesquisaProduto,
            this.toolStripSeparator3});
            this.mbtPesquisar.Name = "mbtPesquisar";
            this.mbtPesquisar.Size = new System.Drawing.Size(69, 23);
            this.mbtPesquisar.Text = "Pesquisar";
            this.mbtPesquisar.Click += new System.EventHandler(this.mbtPesquisar_Click);
            // 
            // mbtPesquisaCliente
            // 
            this.mbtPesquisaCliente.Name = "mbtPesquisaCliente";
            this.mbtPesquisaCliente.Size = new System.Drawing.Size(180, 22);
            this.mbtPesquisaCliente.Text = "Cliente";
            this.mbtPesquisaCliente.Click += new System.EventHandler(this.clienteToolStripMenuItem_Click);
            // 
            // mbtPesquisaProduto
            // 
            this.mbtPesquisaProduto.Name = "mbtPesquisaProduto";
            this.mbtPesquisaProduto.Size = new System.Drawing.Size(180, 22);
            this.mbtPesquisaProduto.Text = "Produto";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(177, 6);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 23);
            // 
            // mbtVendas
            // 
            this.mbtVendas.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mbtVender});
            this.mbtVendas.Name = "mbtVendas";
            this.mbtVendas.Size = new System.Drawing.Size(56, 23);
            this.mbtVendas.Text = "Vendas";
            this.mbtVendas.Click += new System.EventHandler(this.mbtVendas_Click);
            // 
            // mbtVender
            // 
            this.mbtVender.Name = "mbtVender";
            this.mbtVender.Size = new System.Drawing.Size(180, 22);
            this.mbtVender.Text = "Vender";
            this.mbtVender.Click += new System.EventHandler(this.mbtVender_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(12, 23);
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
        private System.Windows.Forms.ToolStripMenuItem mbtCadastro;
        private System.Windows.Forms.ToolStripMenuItem mbtCadastroDeCategoria;
        private System.Windows.Forms.ToolStripMenuItem mbtCadastroDeCliente;
        private System.Windows.Forms.ToolStripMenuItem mbtCadastroDeFuncionario;
        private System.Windows.Forms.ToolStripMenuItem mbtCadastroDeProduto;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem bmtSair;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem mbtPesquisar;
        private System.Windows.Forms.ToolStripMenuItem mbtPesquisaCliente;
        private System.Windows.Forms.ToolStripMenuItem mbtPesquisaProduto;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem mbtVendas;
        private System.Windows.Forms.ToolStripMenuItem mbtVender;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
    }
}