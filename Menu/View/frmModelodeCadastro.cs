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
    public partial class frmModelodeCadastro : Form
    {
        //Variaveis que serão utilizadas pelos formularios filhos
        public string operacao;

        public frmModelodeCadastro()
        {
            InitializeComponent();
        }

        public void alterarBotoes(int op, Boolean perInserir, Boolean perAlterar, Boolean perExcluir, Boolean perImprimir)
        {
            //1 = Inserir e Localizar
            //2= Inserir e Alterar
            //3= Excluir e Alterar
            pnDados.Enabled = false;
            btInserir.Enabled = false;
            btAlterar.Enabled = false;
            btLocalizar.Enabled = false;
            btExcluir.Enabled = false;
            btCancelar.Enabled = false;
            btSalvar.Enabled = false;
            if (op == 1)
            {
                btInserir.Enabled = perInserir;
                btLocalizar.Enabled = true;
            }
            if (op == 2)
            {
                pnDados.Enabled = true;
                btSalvar.Enabled = true;
                btCancelar.Enabled = true;
            }
            if (op == 3)
            {
                btAlterar.Enabled = perAlterar;
                btExcluir.Enabled = perExcluir;
                btCancelar.Enabled = true;
            }
        }

        private void frmModelodeCadastro_Load(object sender, EventArgs e)
        {
            alterarBotoes(1, false, false, false, false);
        }

        private void btInserir_Click(object sender, EventArgs e)
        {

        }
    }
}
