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
    public partial class frmCadastroEstados : SysLojaInfo.frmCadastro
    {
        public frmCadastroEstados()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        public void BloqTxt()
        {
            this.txtEstado.Enabled = false;
            this.txtUF.Enabled = false;
            this.btnPesquisa.Enabled = false;

        }

        public void DesbloqTxt()
        {
            this.txtEstado.Enabled = true;
            this.txtUF.Enabled = true;
            this.btnPesquisa.Enabled=true;  
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

        private void btnPesquisa_Click(object sender, EventArgs e)
        {
            frmConsultaPaises tela = new frmConsultaPaises();
            tela.botao_Selecionar();
            tela.Show();
        }
    }
}
