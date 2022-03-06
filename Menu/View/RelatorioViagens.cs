using BLL;
using DAL;
using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Menu.View
{
    public partial class RelatorioViagens : Form
    {
        public RelatorioViagens()
        {
            InitializeComponent();
        }

        private void CarregarRelatorio_Click(object sender, EventArgs e)
        {
            DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
            BLLMotorista bll = new BLLMotorista(cx);
            reportViewer2.LocalReport.DataSources.Clear();

            ReportDataSource rds = new ReportDataSource("ViagensDataSet", bll.ViagemLocalizar(0));
            reportViewer2.LocalReport.DataSources.Add(rds);
            reportViewer2.RefreshReport();
        }

        private void RelatorioViagens_Load(object sender, EventArgs e)
        {
            this.reportViewer2.RefreshReport();
        }
    }
}
