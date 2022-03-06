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
    public partial class RelatorioLocacao : Form
    {
        public RelatorioLocacao()
        {
            InitializeComponent();
        }

        private void CarregarRelatorio_Click(object sender, EventArgs e)
        {
            DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
            BLLMotorista bll = new BLLMotorista(cx);
            reportViewer2.LocalReport.DataSources.Clear();

            ReportDataSource rds = new ReportDataSource("LocacaoDataSet", bll.LocacaoLocalizar(0));
            reportViewer2.LocalReport.DataSources.Add(rds);
            reportViewer2.RefreshReport();
        }
    }
}
