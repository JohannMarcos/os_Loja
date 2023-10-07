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
    public partial class frmConsultaFormaPag : SysLojaInfo.frmConsulta
    {
        public frmConsultaFormaPag()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        public override void alterar()
        {
            base.alterar();
            frmCadastroFormaPag tela = new frmCadastroFormaPag();
            tela.Botao_alterar();
            tela.Show();
        }

        public override void incluir()
        {
            base.incluir();
            frmCadastroFormaPag tela = new frmCadastroFormaPag();
            tela.Botao_Salvar();
            tela.Show();
        }

        public override void excluir()
        {
            base.excluir();
            frmCadastroFormaPag tela = new frmCadastroFormaPag();
            tela.Botao_Excluir();
            tela.Show();

        }
    }
}
