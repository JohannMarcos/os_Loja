namespace SysLojaInfo
{
    partial class frmCadastroCondPag
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
            lblCondicao = new Label();
            lblTaxa = new Label();
            lblMulta = new Label();
            lblDesconto = new Label();
            txtCond = new TextBox();
            txtTaxa = new TextBox();
            txtMulta = new TextBox();
            txtDesconto = new TextBox();
            lblDias = new Label();
            lblPercent = new Label();
            txtDias = new TextBox();
            txtPercent = new TextBox();
            btnAdicionaParc = new Button();
            dgParcelas = new DataGridView();
            nParcela = new DataGridViewTextBoxColumn();
            dias = new DataGridViewTextBoxColumn();
            percent = new DataGridViewTextBoxColumn();
            forma = new DataGridViewTextBoxColumn();
            groupBox1 = new GroupBox();
            comboBox1 = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)dgParcelas).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // lblCondicao
            // 
            lblCondicao.AutoSize = true;
            lblCondicao.Location = new Point(147, 25);
            lblCondicao.Name = "lblCondicao";
            lblCondicao.Size = new Size(138, 15);
            lblCondicao.TabIndex = 10;
            lblCondicao.Text = "Condição de Pagamento";
            // 
            // lblTaxa
            // 
            lblTaxa.AutoSize = true;
            lblTaxa.Location = new Point(406, 25);
            lblTaxa.Name = "lblTaxa";
            lblTaxa.Size = new Size(30, 15);
            lblTaxa.TabIndex = 11;
            lblTaxa.Text = "Taxa";
            // 
            // lblMulta
            // 
            lblMulta.AutoSize = true;
            lblMulta.Location = new Point(513, 25);
            lblMulta.Name = "lblMulta";
            lblMulta.Size = new Size(38, 15);
            lblMulta.TabIndex = 12;
            lblMulta.Text = "Multa";
            // 
            // lblDesconto
            // 
            lblDesconto.AutoSize = true;
            lblDesconto.Location = new Point(623, 25);
            lblDesconto.Name = "lblDesconto";
            lblDesconto.Size = new Size(57, 15);
            lblDesconto.TabIndex = 13;
            lblDesconto.Text = "Desconto";
            // 
            // txtCond
            // 
            txtCond.Location = new Point(147, 43);
            txtCond.Name = "txtCond";
            txtCond.Size = new Size(253, 23);
            txtCond.TabIndex = 14;
            // 
            // txtTaxa
            // 
            txtTaxa.Location = new Point(406, 43);
            txtTaxa.Name = "txtTaxa";
            txtTaxa.Size = new Size(100, 23);
            txtTaxa.TabIndex = 15;
            // 
            // txtMulta
            // 
            txtMulta.Location = new Point(513, 43);
            txtMulta.Name = "txtMulta";
            txtMulta.Size = new Size(101, 23);
            txtMulta.TabIndex = 16;
            // 
            // txtDesconto
            // 
            txtDesconto.Location = new Point(623, 43);
            txtDesconto.Name = "txtDesconto";
            txtDesconto.Size = new Size(96, 23);
            txtDesconto.TabIndex = 17;
            // 
            // lblDias
            // 
            lblDias.AutoSize = true;
            lblDias.Location = new Point(6, 42);
            lblDias.Name = "lblDias";
            lblDias.Size = new Size(29, 15);
            lblDias.TabIndex = 18;
            lblDias.Text = "Dias";
            // 
            // lblPercent
            // 
            lblPercent.AutoSize = true;
            lblPercent.Location = new Point(124, 42);
            lblPercent.Name = "lblPercent";
            lblPercent.Size = new Size(63, 15);
            lblPercent.TabIndex = 19;
            lblPercent.Text = "Percentual";
            // 
            // txtDias
            // 
            txtDias.Location = new Point(6, 60);
            txtDias.Name = "txtDias";
            txtDias.Size = new Size(109, 23);
            txtDias.TabIndex = 20;
            // 
            // txtPercent
            // 
            txtPercent.Location = new Point(124, 60);
            txtPercent.Name = "txtPercent";
            txtPercent.Size = new Size(109, 23);
            txtPercent.TabIndex = 21;
            // 
            // btnAdicionaParc
            // 
            btnAdicionaParc.Location = new Point(447, 59);
            btnAdicionaParc.Name = "btnAdicionaParc";
            btnAdicionaParc.Size = new Size(138, 23);
            btnAdicionaParc.TabIndex = 22;
            btnAdicionaParc.Text = "Adicionar Parcela";
            btnAdicionaParc.UseVisualStyleBackColor = true;
            // 
            // dgParcelas
            // 
            dgParcelas.AllowUserToAddRows = false;
            dgParcelas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgParcelas.Columns.AddRange(new DataGridViewColumn[] { nParcela, dias, percent, forma });
            dgParcelas.Location = new Point(6, 89);
            dgParcelas.MultiSelect = false;
            dgParcelas.Name = "dgParcelas";
            dgParcelas.RowHeadersVisible = false;
            dgParcelas.RowTemplate.Height = 25;
            dgParcelas.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgParcelas.Size = new Size(738, 162);
            dgParcelas.TabIndex = 23;
            // 
            // nParcela
            // 
            nParcela.HeaderText = "Nº";
            nParcela.Name = "nParcela";
            nParcela.ReadOnly = true;
            nParcela.Width = 50;
            // 
            // dias
            // 
            dias.HeaderText = "Dias";
            dias.Name = "dias";
            dias.ReadOnly = true;
            dias.Width = 50;
            // 
            // percent
            // 
            percent.HeaderText = "%";
            percent.Name = "percent";
            percent.ReadOnly = true;
            percent.Width = 70;
            // 
            // forma
            // 
            forma.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            forma.HeaderText = "Forma de Pagamento";
            forma.Name = "forma";
            forma.ReadOnly = true;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(comboBox1);
            groupBox1.Controls.Add(dgParcelas);
            groupBox1.Controls.Add(lblDias);
            groupBox1.Controls.Add(btnAdicionaParc);
            groupBox1.Controls.Add(lblPercent);
            groupBox1.Controls.Add(txtPercent);
            groupBox1.Controls.Add(txtDias);
            groupBox1.Location = new Point(29, 92);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(750, 267);
            groupBox1.TabIndex = 24;
            groupBox1.TabStop = false;
            groupBox1.Text = "groupBox1";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(243, 60);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(198, 23);
            comboBox1.TabIndex = 24;
            // 
            // frmCadastroCondPag
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(groupBox1);
            Controls.Add(txtDesconto);
            Controls.Add(txtMulta);
            Controls.Add(txtTaxa);
            Controls.Add(txtCond);
            Controls.Add(lblDesconto);
            Controls.Add(lblMulta);
            Controls.Add(lblTaxa);
            Controls.Add(lblCondicao);
            Name = "frmCadastroCondPag";
            Text = "Cadastro de Condição de Pagamento";
            Load += Form1_Load;
            Controls.SetChildIndex(lblCondicao, 0);
            Controls.SetChildIndex(lblTaxa, 0);
            Controls.SetChildIndex(lblMulta, 0);
            Controls.SetChildIndex(lblDesconto, 0);
            Controls.SetChildIndex(txtCond, 0);
            Controls.SetChildIndex(txtTaxa, 0);
            Controls.SetChildIndex(txtMulta, 0);
            Controls.SetChildIndex(txtDesconto, 0);
            Controls.SetChildIndex(groupBox1, 0);
            ((System.ComponentModel.ISupportInitialize)dgParcelas).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblCondicao;
        private Label lblTaxa;
        private Label lblMulta;
        private Label lblDesconto;
        private TextBox txtCond;
        private TextBox txtTaxa;
        private TextBox txtMulta;
        private TextBox txtDesconto;
        private Label lblDias;
        private Label lblPercent;
        private TextBox txtDias;
        private TextBox txtPercent;
        private Button btnAdicionaParc;
        private DataGridView dgParcelas;
        private DataGridViewTextBoxColumn nParcela;
        private DataGridViewTextBoxColumn dias;
        private DataGridViewTextBoxColumn percent;
        private DataGridViewTextBoxColumn forma;
        private GroupBox groupBox1;
        private ComboBox comboBox1;
    }
}