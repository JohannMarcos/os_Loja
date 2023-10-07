using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SysLojaInfo
{
    public partial class frmConsulta : SysLojaInfo.frmPai
    {
        public frmConsulta()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        public virtual void botao_Selecionar()
        {
            this.btnSair.Text = "Selecionar";
        }

        public virtual void botao_sair()
        {
            this.btnSair.Text = "Sair";
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.sair();
        }

        public virtual void alterar()
        {

        }

        public virtual void incluir()
        {

        }

        public virtual void excluir()
        {

        }

        public virtual void sair()
        {
            Close();
        }

        private void btnIncluir_Click(object sender, EventArgs e)
        {
            this.incluir();
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            this.alterar();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            this.excluir();
        }
    }

}
