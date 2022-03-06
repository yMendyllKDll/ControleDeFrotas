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
    public partial class TelaVeiculoss : Form
    {
        string Marca = "", Cor = "", KMAtual = "", Combustivel = "", Renavam = "", Chassi = "", Modelo = "", Ano = "", SituacaoVei = "", Placa = "", Pneu = "";
        int CodVeiculo;
        string tblNome, txtNome;

        public TelaVeiculoss()
        {        
            InitializeComponent();
            Atualizar();
            CodMax();
        }

        private void Atualizar()
        {
            ServiçoExibir ExibVei = new ServiçoExibir();
            dataGridVei.DataSource = ExibVei.ExibirVei();

        }
        private void CodMax()
        {
            tblNome = "tblVeiculo";
            txtNome = "CodVeiculo";
            ServiçoExibir SelecttMax = new ServiçoExibir();
            txtCodVeiculo.Text = Convert.ToString(SelecttMax.SelectMax(tblNome, txtNome));
        }

        private void Limpar()
        {
            txtCodVeiculo.Text = "";
            txtMarca.Text = "";
            txtCor.Text = "";
            txtKMAtual.Text = "";
            txtCombustivel.Text = "";
            txtRenavam.Text = "";
            txtChassi.Text = "";
            txtModelo.Text = "";
            txtAno.Text = "";
            txtSituacao.Text = "";
            txtPneu.Text = "";
            txtPlaca.Text = "";
            btnEditVei.Enabled = false;
            CodMax();
        }

        private void btnExibListVei_Click(object sender, EventArgs e)
        {
            Atualizar();
        }

        private void btnPesquisaVei_Click(object sender, EventArgs e)
        {
            if (txtPlaca.Text != "   -")
            {
                string[] Dados = new string[10];
                Placa = txtPlaca.Text;
                ServiçoExibir SelecttVei = new ServiçoExibir();
                Dados = SelecttVei.SelectVei(Placa);
                txtCodVeiculo.Text = Dados[0];
                txtMarca.Text = Dados[1];
                txtCor.Text = Dados[2];
                txtKMAtual.Text = Dados[3];
                txtCombustivel.Text = Dados[4];
                txtRenavam.Text = Dados[5];
                txtChassi.Text = Dados[6];
                txtModelo.Text = Dados[7];
                txtAno.Text = Dados[8];
                txtSituacao.Text = Dados[9];
                txtPneu.Text = Dados[10];
            }
            else
            {
                MessageBox.Show("Ops, Digite uma Placa para Pesquisar");
            }

        }

        private void btnCadVei_Click(object sender, EventArgs e)
        {
            ServiçoCadastros CadVei = new ServiçoCadastros();
            CodVeiculo = Convert.ToInt32(txtCodVeiculo.Text);
            Marca = txtMarca.Text;
            Cor = txtCor.Text;
            KMAtual = txtKMAtual.Text;
            Combustivel = txtCombustivel.Text;
            Renavam = txtRenavam.Text;
            Chassi = txtChassi.Text;
            Modelo = txtModelo.Text;
            Ano = txtAno.Text;
            SituacaoVei = txtSituacao.Text;
            Placa = txtPlaca.Text;
            Pneu = txtPneu.Text;
            
            try
            {
                CadVei.CadastrarVei(CodVeiculo, Marca, Cor, KMAtual, Combustivel, Renavam, Chassi, Modelo, Ano, SituacaoVei, Placa, Pneu);
                btnEditVei.Enabled = true;

            }
            catch { }
        }

        private void btnEditVei_Click(object sender, EventArgs e)
        {
            ServiçoEditar EditVei = new ServiçoEditar();
            Marca = txtMarca.Text;
            Cor = txtCor.Text;
            KMAtual = txtKMAtual.Text;
            Combustivel = txtCombustivel.Text;
            Renavam = txtRenavam.Text;
            Chassi = txtChassi.Text;
            Modelo = txtModelo.Text;
            Ano = txtAno.Text;
            SituacaoVei = txtSituacao.Text;
            Placa = txtPlaca.Text;
            Pneu = txtPneu.Text;

            try
            {
                EditVei.EditarVei(Marca, Cor, KMAtual, Combustivel, Renavam, Chassi, Modelo, Ano, SituacaoVei, Placa, Pneu);
                Limpar();
            }
            catch { }
        }

        private void btnDelVei_Click(object sender, EventArgs e)
        {
            ServiçoExcluir ExcluiVei = new ServiçoExcluir();

            Placa = txtPlaca.Text;

            try
            {
                ExcluiVei.ExcluirVei(Placa);
            }
            catch { }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            Limpar();
        }
    }
}
