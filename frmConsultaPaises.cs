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
    public partial class frmConsultaPaises : SysLojaInfo.frmConsulta
    {
        private ctrlPaises aCtrl;

        private Paises oPais;

        public frmConsultaPaises()
        {
            InitializeComponent();
            aCtrl = new ctrlPaises();
            oPais = new Paises();
            this.PopulaDataGrid();
        }

        public void PopulaDataGrid()
        {
            dgPaises.Rows.Clear();
            dgPaises.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomRight;
            DataTable dt = this.aCtrl.SelecionaDS();

            if (dt != null)
            {
                int i = 0;
                foreach (DataRow dr in dt.Rows)
                {
                    dgPaises.Rows.Add();
                    for (int k = 0; k < dr.Table.Columns.Count; k++)
                    {
                        var x = dr.Table.Columns.Count;
                        if (dr[k] != null)
                        {
                            dgPaises.Rows[i].Cells[k].Value = dr[k].ToString();
                        }
                    }
                    i++;
                }
            }

        }

        public void pegaRegDataGrid()
        {
            /*DataGridViewRow vLinha = dgPaises.SelectedRows[0];
            oPais.Codigo = Convert.ToInt32(vLinha.Cells["codigo"].Value);
            oPais.Pais = Convert.ToString(vLinha.Cells["pais"].Value);
            oPais.DDI = Convert.ToString(vLinha.Cells["ddi"].Value);
            oPais.Sigla = Convert.ToString(vLinha.Cells["sigla"].Value);
            oPais.DatCad = Convert.ToDateTime(vLinha.Cells["datCad"].Value);
            oPais.DatUltAlt = Convert.ToDateTime(vLinha.Cells["datAlt"].Value);
            oPais.QuemAlter = Convert.ToInt32(vLinha.Cells["idUser"].Value);*/

            DataGridViewRow vLinha = dgPaises.SelectedRows[0];
            oPais.Codigo = Convert.ToInt32(dgPaises.SelectedCells[0].Value);
            oPais.Pais = dgPaises.SelectedCells[1].Value.ToString();
            oPais.Sigla = dgPaises.SelectedCells[2].Value.ToString();
            oPais.DDI = dgPaises.SelectedCells[3].Value.ToString();
            oPais.DatCad = Convert.ToDateTime(vLinha.Cells["datCad"].Value);
            oPais.DatUltAlt = Convert.ToDateTime(vLinha.Cells["datAlt"].Value);
            oPais.QuemAlter = Convert.ToInt32(vLinha.Cells["idUser"].Value);

            /*DataGridViewRow row = null;
             try
             {
                 row = DGV_Countries.SelectedRows[0];
             }
             catch { }
             if (row != null)
             {
                 edt_id.Text = DGV_Countries.SelectedCells[0].Value.ToString();
                 edt_countryName.Text = DGV_Countries.SelectedCells[1].Value.ToString();
                 edt_acronym.Text = DGV_Countries.SelectedCells[2].Value.ToString();
                 edt_phonePrefix.Text = DGV_Countries.SelectedCells[3].Value.ToString();
                 edt_currency.Text = DGV_Countries.SelectedCells[4].Value.ToString();
             }*/
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        public override void alterar()
        {
            base.alterar();
            frmCadastroPaises tela = new frmCadastroPaises();
            this.pegaRegDataGrid();
            tela.CarregaCampos(oPais);
            tela.Botao_alterar();
            tela.Show();
        }

        public override void incluir()
        {
            base.incluir();
            frmCadastroPaises tela = new frmCadastroPaises();
            tela.Botao_Salvar();
            tela.Show();
        }

        public override void excluir()
        {
            base.excluir();
            frmCadastroPaises tela = new frmCadastroPaises();
            this.pegaRegDataGrid();
            tela.CarregaCampos(oPais);
            tela.Botao_Excluir();
            tela.Show();

        }

        private void frmConsultaPaises_Activated(object sender, EventArgs e)
        {
            this.PopulaDataGrid();
        }
    }
}
