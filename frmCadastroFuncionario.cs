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
    public partial class frmCadastroFuncionario : SysLojaInfo.frmCadastroPessoas
    {
        public frmCadastroFuncionario()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        public override void BloqTxt()
        {
            base.BloqTxt();
            this.txtCnh.Enabled = false;
            this.btnProcuraCargo.Enabled = false;
        }

        public override void DesbloqTxt()
        {
            base.DesbloqTxt();
            this.txtCnh.Enabled = true;
            this.btnProcuraCargo.Enabled = true;
        }


        public override void btnProcuraCidade_Click(object sender, EventArgs e)
        {
            base.btnProcuraCidade_Click(sender, e);
            frmConsultaCidades tela = new frmConsultaCidades();
            tela.botao_Selecionar();
            tela.Show();
        }

        private void btnProcuraCargo_Click(object sender, EventArgs e)
        {
            frmConsultaCargo tela = new frmConsultaCargo();
            tela.botao_Selecionar();
            tela.Show();
        }
    }
}
