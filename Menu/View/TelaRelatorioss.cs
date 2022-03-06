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
    public partial class TelaRelatorioss : Form
    {
        public TelaRelatorioss()
        {
            InitializeComponent();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            RelatorioMotorista f = new RelatorioMotorista();
            f.ShowDialog();
            f.Dispose();
        }

        private void btVeiculos_Click(object sender, EventArgs e)
        {
            RelatorioVeiculo f = new RelatorioVeiculo();
            f.ShowDialog();
            f.Dispose();
        }

        private void bnLocacao_Click(object sender, EventArgs e)
        {
            RelatorioLocacao f = new RelatorioLocacao();
            f.ShowDialog();
            f.Dispose();
        }

        private void bnViagens_Click(object sender, EventArgs e)
        {
            RelatorioViagens f = new RelatorioViagens();
            f.ShowDialog();
            f.Dispose();
        }
    }
}
