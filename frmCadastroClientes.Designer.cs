namespace SysLojaInfo
{
    partial class frmCadastroClientes
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
            lblLimite = new Label();
            txtLimite = new TextBox();
            SuspendLayout();
            // 
            // lblLimite
            // 
            lblLimite.AutoSize = true;
            lblLimite.Location = new Point(392, 83);
            lblLimite.Name = "lblLimite";
            lblLimite.Size = new Size(98, 15);
            lblLimite.TabIndex = 34;
            lblLimite.Text = "Limite de Crédito";
            // 
            // txtLimite
            // 
            txtLimite.Location = new Point(392, 101);
            txtLimite.Name = "txtLimite";
            txtLimite.Size = new Size(137, 23);
            txtLimite.TabIndex = 35;
            // 
            // frmCadastroClientes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtLimite);
            Controls.Add(lblLimite);
            Name = "frmCadastroClientes";
            Text = "Cadastro De Clientes";
            Load += Form1_Load;
            Controls.SetChildIndex(lblLimite, 0);
            Controls.SetChildIndex(txtLimite, 0);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblLimite;
        private TextBox txtLimite;
    }
}