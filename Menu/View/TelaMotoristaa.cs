using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Menu.Controller;

namespace Menu.View
{
    public partial class TelaMotoristaa : Form
    {
        string nome = "", rg = "", cpf = "", cnh = "", datacnh = "", datanasc = "", statusMoto;
        int codMoto;
        string tblNome, txtNome;


        public TelaMotoristaa()
        {
            InitializeComponent();
            Atualizar();
            CodMax();
        }

        private void Atualizar()
        {
            ServiçoExibir ExibMoto = new ServiçoExibir();
            dataGridMoto.DataSource = ExibMoto.ExibirMoto();
        }
        private void CodMax()
        {
            tblNome = "tblMotorista";
            txtNome = "codMoto";
            ServiçoExibir SelecttMax = new ServiçoExibir();
            txtCodMoto.Text = Convert.ToString(SelecttMax.SelectMax(tblNome, txtNome));
        }

        private void Limpar()
        {
            txtCodMoto.Text = "";
            txtNomeMoto.Text = "";
            txtDataNascMoto.Text = "";
            txtRGMoto.Text = "";
            txtCPFMoto.Text = "";
            txtCNHMoto.Text = "";
            txtValCNHMoto.Text = "";
            txtStatusMoto.Text = "";
            btnEditMoto.Enabled = false;
            CodMax();
        }


        private void BtnExibirLista_Click(object sender, EventArgs e)
        {
            Atualizar();
        }

        private void BtnPesquisaMoto_Click(object sender, EventArgs e)
        {
            if (txtCPFMoto.Text != "         /")
            {
                string[] Dados = new string[7];
                cpf = txtCPFMoto.Text;
                ServiçoExibir SelecttMoto = new ServiçoExibir();
                Dados = SelecttMoto.SelectMoto(cpf);
                txtNomeMoto.Text = Dados[0];
                txtDataNascMoto.Text = Dados[1];
                txtRGMoto.Text = Dados[2];
                txtCodMoto.Text = Dados[3];
                txtCNHMoto.Text = Dados[4];
                txtValCNHMoto.Text = Dados[5];
                txtStatusMoto.Text = Dados[6];

                btnEditMoto.Enabled = true;
            }
            else
            {
                MessageBox.Show("Ops, Digite um CPF para Pesquisar");
            }
            
        }

        private void BtnCadMoto_Click(object sender, EventArgs e)
        {

            ServiçoCadastros CadMoto = new ServiçoCadastros();
            codMoto = Convert.ToInt32(txtCodMoto.Text);
            nome = txtNomeMoto.Text;
            rg = txtRGMoto.Text;
            cpf = txtCPFMoto.Text;
            cnh = txtCNHMoto.Text;
            datacnh = txtValCNHMoto.Text;
            datanasc = txtDataNascMoto.Text;
            statusMoto = txtStatusMoto.Text;
            try
            {
                CadMoto.CadastrarMoto(codMoto, nome, rg, cpf, cnh, datacnh, datanasc, statusMoto);
            }
            catch { }


        }

        private void BtnEditMoto_Click(object sender, EventArgs e)
        {
            ServiçoEditar EditMoto = new ServiçoEditar();
                nome = txtNomeMoto.Text;
                datanasc = txtDataNascMoto.Text; 
                rg = txtRGMoto.Text;
                cpf = txtCPFMoto.Text;
                cnh = txtCNHMoto.Text;
                datacnh = txtValCNHMoto.Text;
                statusMoto = txtStatusMoto.Text;

                try
                {
                    EditMoto.EditarMoto(nome, rg, cpf, cnh, datacnh, datanasc, statusMoto);
                    Limpar();
                }
                catch { }
        }

        private void BtnDelMoto_Click(object sender, EventArgs e)
        {
            ServiçoExcluir ExcluiMoto = new ServiçoExcluir();

            cpf = txtCPFMoto.Text;

            try
            {
                ExcluiMoto.ExcluirMoto(cpf);
            }
            catch { }
            Limpar();

        }
        private void BtnLimpar_Click(object sender, EventArgs e)
        {
            Limpar();
        }

    }
}
