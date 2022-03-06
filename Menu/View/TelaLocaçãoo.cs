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
    public partial class TelaLocaçãoo : Form
    {
        string DataLocacao, DataDevolucao, LocalRetirada, Quantidade, ValorLocacao;
        int CodLocacao, CodLCliente;
        string tblNome, txtNome;

        public TelaLocaçãoo()
        {
            InitializeComponent();
            Atualizar();
            CodMax();
        }

        private void Atualizar()
        {
            ServiçoExibir ExibLoca = new ServiçoExibir();
            dataGridLoca.DataSource = ExibLoca.ExibirLoca();

        }
        private void CodMax()
        {
            tblNome = "tblLocacao";
            txtNome = "CodLocacao";
            ServiçoExibir SelecttMax = new ServiçoExibir();
            txtCodLoca.Text = Convert.ToString(SelecttMax.SelectMax(tblNome, txtNome));
        }

        private void Limpar()
        {
            txtCodLoca.Text = "";
            txtCodCliente.Text = "";
            txtDataLoca.Text = "";
            txtDataDevolucao.Text = "";
            txtLocalRetirada.Text = "";
            txtQntLoca.Text = "";
            txtValorLoca.Text = "";
            btnEditLoca.Enabled = false;
            CodMax();
        }

        private void btnExibirLista_Click(object sender, EventArgs e)
        {
            Atualizar();
        }

        private void btnPesqLoca_Click(object sender, EventArgs e)
        {
            if (txtCodLoca.Text != "")
            {
                string[] Dados = new string[6];
                CodLocacao = Convert.ToInt32(txtCodLoca.Text);
                ServiçoExibir SelecttLoca = new ServiçoExibir();
                Dados = SelecttLoca.SelectLoca(CodLocacao);
                txtCodCliente.Text = Dados[0];
                txtDataLoca.Text = Dados[1];
                txtDataDevolucao.Text = Dados[2];
                txtLocalRetirada.Text = Dados[3];
                txtQntLoca.Text = Dados[4];
                txtValorLoca.Text = Dados[5];
                btnEditLoca.Enabled = true;
            }
            else
            {
                MessageBox.Show("Ops, Digite uma Codigo de Locação para Pesquisar");

            }
        }

        private void btnCadLoca_Click(object sender, EventArgs e)
        {

            ServiçoCadastros CadLoca = new ServiçoCadastros();
            CodLocacao = Convert.ToInt32(txtCodLoca.Text);
            CodLCliente = Convert.ToInt32(txtCodCliente.Text);
            DataLocacao = txtDataLoca.Text;
            DataDevolucao = txtDataDevolucao.Text;
            LocalRetirada = txtLocalRetirada.Text;
            Quantidade = txtQntLoca.Text;
            ValorLocacao = txtValorLoca.Text;


            try
            {
                CadLoca.CadastrarLoca(CodLocacao, CodLCliente, DataLocacao, DataDevolucao, LocalRetirada, Quantidade, ValorLocacao);
                Limpar();
            }
            catch { }

        }

        private void btnEditLoca_Click(object sender, EventArgs e)
        {
            ServiçoEditar EditLoca = new ServiçoEditar();
            CodLocacao = Convert.ToInt32(txtCodLoca.Text);
            CodLCliente = Convert.ToInt32(txtCodCliente.Text);
            DataLocacao = txtDataLoca.Text;
            DataDevolucao = txtDataDevolucao.Text;
            LocalRetirada = txtLocalRetirada.Text;
            Quantidade = txtQntLoca.Text;
            ValorLocacao = txtValorLoca.Text;

            try
            {
                EditLoca.EditarLoca(CodLocacao, CodLCliente, DataLocacao, DataDevolucao, LocalRetirada, Quantidade, ValorLocacao);
                btnEditLoca.Enabled = false;
            }
            catch { }
        }

        private void btnDelLoca_Click(object sender, EventArgs e)
        {
            ServiçoExcluir ExcluiLoca = new ServiçoExcluir();

            CodLocacao = Convert.ToInt32(txtCodLoca.Text);

            try
            {
                ExcluiLoca.ExcluirLoca(CodLocacao);
            }
            catch { }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            Limpar();
        }
    }
}
