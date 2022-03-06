using DAL;
using BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;

namespace Menu.View
{
    public partial class RelatorioMotorista : Form
    {
        public RelatorioMotorista()
        {
            InitializeComponent();
        }

        private void RelatorioMotorista_Load(object sender, EventArgs e)
        {
            this.reportViewer2.RefreshReport();
        }

        private void CarregarRelatorio_Click(object sender, EventArgs e)
        {
            DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
            BLLMotorista bll = new BLLMotorista(cx);
            reportViewer2.LocalReport.DataSources.Clear();

            ReportDataSource rds = new ReportDataSource("MotoristaDataSet", bll.MotoristaLocalizar(0));
            reportViewer2.LocalReport.DataSources.Add(rds);
            reportViewer2.RefreshReport();
        }
    }
}
