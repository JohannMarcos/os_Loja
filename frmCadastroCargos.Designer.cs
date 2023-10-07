namespace SysLojaInfo
{
    partial class frmCadastroCargos
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
            lblCargo = new Label();
            txtCargo = new TextBox();
            SuspendLayout();
            // 
            // lblCargo
            // 
            lblCargo.AutoSize = true;
            lblCargo.Location = new Point(147, 25);
            lblCargo.Name = "lblCargo";
            lblCargo.Size = new Size(39, 15);
            lblCargo.TabIndex = 10;
            lblCargo.Text = "Cargo";
            // 
            // txtCargo
            // 
            txtCargo.Location = new Point(144, 43);
            txtCargo.Name = "txtCargo";
            txtCargo.Size = new Size(209, 23);
            txtCargo.TabIndex = 11;
            // 
            // frmCadastroCargos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtCargo);
            Controls.Add(lblCargo);
            Name = "frmCadastroCargos";
            Text = "Cadastro de Cargos";
            Load += Form1_Load;
            Controls.SetChildIndex(lblCargo, 0);
            Controls.SetChildIndex(txtCargo, 0);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblCargo;
        private TextBox txtCargo;
    }
}