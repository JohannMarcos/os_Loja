namespace SysLojaInfo
{
    partial class frmCadastroFuncionario
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
            lblCNH = new Label();
            lblCodCargo = new Label();
            lblCargo = new Label();
            txtCnh = new TextBox();
            txtCodCargo = new TextBox();
            txtCargo = new TextBox();
            btnProcuraCargo = new Button();
            SuspendLayout();
            // 
            // lblCNH
            // 
            lblCNH.AutoSize = true;
            lblCNH.Location = new Point(397, 83);
            lblCNH.Name = "lblCNH";
            lblCNH.Size = new Size(33, 15);
            lblCNH.TabIndex = 34;
            lblCNH.Text = "CNH";
            // 
            // lblCodCargo
            // 
            lblCodCargo.AutoSize = true;
            lblCodCargo.Location = new Point(29, 322);
            lblCodCargo.Name = "lblCodCargo";
            lblCodCargo.Size = new Size(98, 15);
            lblCodCargo.TabIndex = 35;
            lblCodCargo.Text = "Código do Cargo";
            // 
            // lblCargo
            // 
            lblCargo.AutoSize = true;
            lblCargo.Location = new Point(147, 322);
            lblCargo.Name = "lblCargo";
            lblCargo.Size = new Size(42, 15);
            lblCargo.TabIndex = 36;
            lblCargo.Text = "Cargo ";
            // 
            // txtCnh
            // 
            txtCnh.Location = new Point(397, 101);
            txtCnh.Name = "txtCnh";
            txtCnh.Size = new Size(213, 23);
            txtCnh.TabIndex = 37;
            // 
            // txtCodCargo
            // 
            txtCodCargo.Enabled = false;
            txtCodCargo.Location = new Point(29, 340);
            txtCodCargo.Name = "txtCodCargo";
            txtCodCargo.Size = new Size(109, 23);
            txtCodCargo.TabIndex = 38;
            // 
            // txtCargo
            // 
            txtCargo.Enabled = false;
            txtCargo.Location = new Point(147, 340);
            txtCargo.Name = "txtCargo";
            txtCargo.Size = new Size(276, 23);
            txtCargo.TabIndex = 39;
            // 
            // btnProcuraCargo
            // 
            btnProcuraCargo.Location = new Point(429, 340);
            btnProcuraCargo.Name = "btnProcuraCargo";
            btnProcuraCargo.Size = new Size(100, 23);
            btnProcuraCargo.TabIndex = 40;
            btnProcuraCargo.Text = "Procurar Cargo";
            btnProcuraCargo.UseVisualStyleBackColor = true;
            btnProcuraCargo.Click += btnProcuraCargo_Click;
            // 
            // frmCadastroFuncionario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnProcuraCargo);
            Controls.Add(txtCargo);
            Controls.Add(txtCodCargo);
            Controls.Add(txtCnh);
            Controls.Add(lblCargo);
            Controls.Add(lblCodCargo);
            Controls.Add(lblCNH);
            Name = "frmCadastroFuncionario";
            Text = "Cadastro de Funcionários";
            Load += Form1_Load;
            Controls.SetChildIndex(lblCNH, 0);
            Controls.SetChildIndex(lblCodCargo, 0);
            Controls.SetChildIndex(lblCargo, 0);
            Controls.SetChildIndex(txtCnh, 0);
            Controls.SetChildIndex(txtCodCargo, 0);
            Controls.SetChildIndex(txtCargo, 0);
            Controls.SetChildIndex(btnProcuraCargo, 0);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblCNH;
        private Label lblCodCargo;
        private Label lblCargo;
        private TextBox txtCnh;
        private TextBox txtCodCargo;
        private TextBox txtCargo;
        private Button btnProcuraCargo;
    }
}