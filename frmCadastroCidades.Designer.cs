namespace SysLojaInfo
{
    partial class frmCadastroCidades
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
            lblCidade = new Label();
            txtCidade = new TextBox();
            txtCodEstado = new TextBox();
            lblCodEstado = new Label();
            txtEstado = new TextBox();
            lblEstado = new Label();
            btnProcuraEstado = new Button();
            SuspendLayout();
            // 
            // lblCidade
            // 
            lblCidade.AutoSize = true;
            lblCidade.Location = new Point(147, 25);
            lblCidade.Name = "lblCidade";
            lblCidade.Size = new Size(44, 15);
            lblCidade.TabIndex = 10;
            lblCidade.Text = "Cidade";
            // 
            // txtCidade
            // 
            txtCidade.Location = new Point(147, 43);
            txtCidade.Name = "txtCidade";
            txtCidade.Size = new Size(322, 23);
            txtCidade.TabIndex = 11;
            // 
            // txtCodEstado
            // 
            txtCodEstado.Enabled = false;
            txtCodEstado.Location = new Point(29, 96);
            txtCodEstado.Name = "txtCodEstado";
            txtCodEstado.Size = new Size(109, 23);
            txtCodEstado.TabIndex = 12;
            // 
            // lblCodEstado
            // 
            lblCodEstado.AutoSize = true;
            lblCodEstado.Location = new Point(29, 78);
            lblCodEstado.Name = "lblCodEstado";
            lblCodEstado.Size = new Size(101, 15);
            lblCodEstado.TabIndex = 13;
            lblCodEstado.Text = "Código do Estado";
            // 
            // txtEstado
            // 
            txtEstado.Enabled = false;
            txtEstado.Location = new Point(147, 96);
            txtEstado.Name = "txtEstado";
            txtEstado.Size = new Size(212, 23);
            txtEstado.TabIndex = 14;
            // 
            // lblEstado
            // 
            lblEstado.AutoSize = true;
            lblEstado.Location = new Point(147, 78);
            lblEstado.Name = "lblEstado";
            lblEstado.Size = new Size(42, 15);
            lblEstado.TabIndex = 15;
            lblEstado.Text = "Estado";
            // 
            // btnProcuraEstado
            // 
            btnProcuraEstado.Location = new Point(371, 96);
            btnProcuraEstado.Name = "btnProcuraEstado";
            btnProcuraEstado.Size = new Size(98, 23);
            btnProcuraEstado.TabIndex = 16;
            btnProcuraEstado.Text = "Procurar Estado";
            btnProcuraEstado.UseVisualStyleBackColor = true;
            btnProcuraEstado.Click += btnProcuraEstado_Click;
            // 
            // frmCadastroCidades
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnProcuraEstado);
            Controls.Add(lblEstado);
            Controls.Add(txtEstado);
            Controls.Add(lblCodEstado);
            Controls.Add(txtCodEstado);
            Controls.Add(txtCidade);
            Controls.Add(lblCidade);
            Name = "frmCadastroCidades";
            Text = "Cadastro de Cidades";
            Load += Form1_Load;
            Controls.SetChildIndex(lblCidade, 0);
            Controls.SetChildIndex(txtCidade, 0);
            Controls.SetChildIndex(txtCodEstado, 0);
            Controls.SetChildIndex(lblCodEstado, 0);
            Controls.SetChildIndex(txtEstado, 0);
            Controls.SetChildIndex(lblEstado, 0);
            Controls.SetChildIndex(btnProcuraEstado, 0);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblCidade;
        private TextBox txtCidade;
        private TextBox txtCodEstado;
        private Label lblCodEstado;
        private TextBox txtEstado;
        private Label lblEstado;
        private Button btnProcuraEstado;
    }
}