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
    public partial class frmCadastroCidades : SysLojaInfo.frmCadastro
    {
        public frmCadastroCidades()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        public void BloqTxt()
        {
            this.txtCidade.Enabled = false;
            this.btnProcuraEstado.Enabled = false;
        }

        public void DesbloqTxt()
        {
            this.txtCidade.Enabled = true;
            this.btnProcuraEstado.Enabled = true;
        }
        public override void Botao_Salvar()
        {
            base.Botao_Salvar();
            this.DesbloqTxt();
        }

        public override void Botao_alterar()
        {
            base.Botao_alterar();
            this.DesbloqTxt();
        }

        public override void Botao_Excluir()
        {
            base.Botao_Excluir();
            this.BloqTxt();
        }

        private void btnProcuraEstado_Click(object sender, EventArgs e)
        {
            frmConsultaEstados tela = new frmConsultaEstados();
            tela.botao_Selecionar();
            tela.Show();
        }

    }
}
