namespace SysLojaInfo
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
            lblProduto = new Label();
            lblPrecoVenda = new Label();
            lblPrecoCusto = new Label();
            lblEstoque = new Label();
            txtProduto = new TextBox();
            txtPrecoVenda = new TextBox();
            txtEstoque = new TextBox();
            txtPrecoCusto = new TextBox();
            SuspendLayout();
            // 
            // lblProduto
            // 
            lblProduto.AutoSize = true;
            lblProduto.Location = new Point(147, 25);
            lblProduto.Name = "lblProduto";
            lblProduto.Size = new Size(50, 15);
            lblProduto.TabIndex = 10;
            lblProduto.Text = "Produto";
            // 
            // lblPrecoVenda
            // 
            lblPrecoVenda.AutoSize = true;
            lblPrecoVenda.Location = new Point(29, 78);
            lblPrecoVenda.Name = "lblPrecoVenda";
            lblPrecoVenda.Size = new Size(88, 15);
            lblPrecoVenda.TabIndex = 11;
            lblPrecoVenda.Text = "Preço de Venda";
            // 
            // lblPrecoCusto
            // 
            lblPrecoCusto.AutoSize = true;
            lblPrecoCusto.Location = new Point(536, 78);
            lblPrecoCusto.Name = "lblPrecoCusto";
            lblPrecoCusto.Size = new Size(87, 15);
            lblPrecoCusto.TabIndex = 12;
            lblPrecoCusto.Text = "Preço de Custo";
            // 
            // lblEstoque
            // 
            lblEstoque.AutoSize = true;
            lblEstoque.Location = new Point(536, 25);
            lblEstoque.Name = "lblEstoque";
            lblEstoque.Size = new Size(134, 15);
            lblEstoque.TabIndex = 13;
            lblEstoque.Text = "Quantidade em Estoque";
            // 
            // txtProduto
            // 
            txtProduto.Location = new Point(147, 43);
            txtProduto.Name = "txtProduto";
            txtProduto.Size = new Size(377, 23);
            txtProduto.TabIndex = 14;
            // 
            // txtPrecoVenda
            // 
            txtPrecoVenda.Enabled = false;
            txtPrecoVenda.Location = new Point(29, 96);
            txtPrecoVenda.Name = "txtPrecoVenda";
            txtPrecoVenda.Size = new Size(131, 23);
            txtPrecoVenda.TabIndex = 15;
            // 
            // txtEstoque
            // 
            txtEstoque.Enabled = false;
            txtEstoque.Location = new Point(536, 43);
            txtEstoque.Name = "txtEstoque";
            txtEstoque.Size = new Size(134, 23);
            txtEstoque.TabIndex = 16;
            // 
            // txtPrecoCusto
            // 
            txtPrecoCusto.Enabled = false;
            txtPrecoCusto.Location = new Point(536, 96);
            txtPrecoCusto.Name = "txtPrecoCusto";
            txtPrecoCusto.Size = new Size(100, 23);
            txtPrecoCusto.TabIndex = 17;
            // 
            // frmCadastroProduto
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtPrecoCusto);
            Controls.Add(txtEstoque);
            Controls.Add(txtPrecoVenda);
            Controls.Add(txtProduto);
            Controls.Add(lblEstoque);
            Controls.Add(lblPrecoCusto);
            Controls.Add(lblPrecoVenda);
            Controls.Add(lblProduto);
            Name = "frmCadastroProduto";
            Text = "Cadastro de Produtos";
            Load += Form1_Load;
            Controls.SetChildIndex(lblProduto, 0);
            Controls.SetChildIndex(lblPrecoVenda, 0);
            Controls.SetChildIndex(lblPrecoCusto, 0);
            Controls.SetChildIndex(lblEstoque, 0);
            Controls.SetChildIndex(txtProduto, 0);
            Controls.SetChildIndex(txtPrecoVenda, 0);
            Controls.SetChildIndex(txtEstoque, 0);
            Controls.SetChildIndex(txtPrecoCusto, 0);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblProduto;
        private Label lblPrecoVenda;
        private Label lblPrecoCusto;
        private Label lblEstoque;
        private TextBox txtProduto;
        private TextBox txtPrecoVenda;
        private TextBox txtEstoque;
        private TextBox txtPrecoCusto;
    }
}