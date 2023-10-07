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
    public partial class frmConsultaClientes : SysLojaInfo.frmConsulta
    {
        public frmConsultaClientes()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        public override void alterar()
        {
            base.alterar();
            frmCadastroClientes tela = new frmCadastroClientes();
            tela.Botao_alterar();
            tela.Show();
        }

        public override void incluir()
        {
            base.incluir();
            frmCadastroClientes tela = new frmCadastroClientes();
            tela.Botao_Salvar();
            tela.Show();
        }

        public override void excluir()
        {
            base.excluir();
            frmCadastroClientes tela = new frmCadastroClientes();
            tela.Botao_Excluir();
            tela.Show();

        }
    }
}
