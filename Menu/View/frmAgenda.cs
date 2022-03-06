using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAL;
using Menu.Controller;

namespace Menu.View
{
    public partial class frmAgenda : Form
    {
        public frmAgenda()
        {
            InitializeComponent();
        }

        private void relogio_Tick(object sender, EventArgs e)
        {
            Compromissos.VerificaCompromissos();
        }

        private void Calendario_DateChanged(object sender, DateRangeEventArgs e)
        {
            List<Compromissos> compromissos = Compromissos.Listar(Calendario.SelectionRange.Start);
            CompromissosDoDia.Items.Clear();

            foreach (Compromissos lista in compromissos)
            {
                ListViewItem item = new ListViewItem();
                item.Text = lista.Id.ToString();
                item.SubItems.Add(lista.Hora.ToString());
                item.SubItems.Add(lista.Descricao);
                CompromissosDoDia.Items.Add(item);
            }
        }

        private void frmAgenda_Load(object sender, EventArgs e)
        {
            Calendario_DateChanged(sender, null);
        }

        private void CompromissosDoDia_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
