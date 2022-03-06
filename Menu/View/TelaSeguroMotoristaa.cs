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
    public partial class TelaSeguroMotoristaa : Form
    {
        //NumApolice, CPFMoto, Seguradora, Corretor, DataInicioSM, DataVencSM, ValorSM, SituacaoSM
        string Seguradora, CPFMoto, Corretor, DataInicioSM, DataVencSM, ValorSM, SituacaoSM;
        int NumApolice;
        //string tblNome, txtNome;

        public TelaSeguroMotoristaa()
        {
            InitializeComponent();
            Atualizar();
            //CodMax();
        }

        private void Atualizar()
        {
            ServiçoExibir ExibSegMoto = new ServiçoExibir();
            dataGridSegMoto.DataSource = ExibSegMoto.ExibirSegMoto();
            dataGridSegMoto.Columns[0].Width = 70;
            dataGridSegMoto.Columns[1].Width = 80;
            dataGridSegMoto.Columns[2].Width = 95;
            dataGridSegMoto.Columns[3].Width = 80;
            dataGridSegMoto.Columns[4].Width = 80;
        }
        //private void CodMax()
        //{
        //    tblNome = "tblSeguroMoto";
        //    txtNome = "codMoto";
        //    ServiçoExibir SelecttMax = new ServiçoExibir();
        //    txtCodMoto.Text = Convert.ToString(SelecttMax.SelectMax(tblNome, txtNome));
        //}

        private void Limpar()
        {
            txtNApolice.Text = "";
            txtCPFMoto.Text = "";
            txtSeguradora.Text = "";
            txtCorretor.Text = "";
            txtDataInicio.Text = "";
            txtDataVenc.Text = "";
            txtValor.Text = "";
            txtSituacao.Text = "";
        }

        private void btnExibListaSegMoto_Click(object sender, EventArgs e)
        {
            ServiçoExibir ExibSegMoto = new ServiçoExibir();

            dataGridSegMoto.DataSource = ExibSegMoto.ExibirSegMoto();
        }

        private void btnPesqSegMoto_Click(object sender, EventArgs e)
        {
            if (txtNApolice.Text != "")
            {
                string[] Dados = new string[7];
                NumApolice = Convert.ToInt32(txtNApolice.Text);
                ServiçoExibir SelecttSegMoto = new ServiçoExibir();
                Dados = SelecttSegMoto.SelectSegMoto(NumApolice);
                txtCPFMoto.Text = Dados[0];
                txtSeguradora.Text = Dados[1];
                txtCorretor.Text = Dados[2];
                txtDataInicio.Text = Dados[3];
                txtDataVenc.Text = Dados[4];
                txtValor.Text = Dados[5];
                txtSituacao.Text = Dados[6];
            }
            else
            {
                MessageBox.Show("Ops, Digite uma Numero da Apolice para Pesquisar");
                btnEditSegMoto.Enabled = true;
            }
        }

        private void btnCadSegMoto_Click(object sender, EventArgs e)
        {
            ServiçoCadastros CadSegMoto = new ServiçoCadastros();
            NumApolice = Convert.ToInt32(txtNApolice.Text);
            CPFMoto = txtCPFMoto.Text;
            Seguradora = txtSeguradora.Text;
            Corretor = txtCorretor.Text;
            DataInicioSM = txtDataInicio.Text;
            DataVencSM = txtDataVenc.Text;
            ValorSM = txtValor.Text;
            SituacaoSM = txtSituacao.Text;

            try
            {
                CadSegMoto.CadastrarSegMoto(NumApolice, CPFMoto, Seguradora, Corretor, DataInicioSM, DataVencSM, ValorSM, SituacaoSM);
            }
            catch { }
        }

        private void btnEditSegMoto_Click(object sender, EventArgs e)
        {
            ServiçoEditar EditSegMoto = new ServiçoEditar();
            NumApolice = Convert.ToInt32(txtNApolice.Text);
            CPFMoto = txtCPFMoto.Text;
            Seguradora = txtSeguradora.Text;
            Corretor = txtCorretor.Text;
            DataInicioSM = txtDataInicio.Text;
            DataVencSM = txtDataVenc.Text;
            ValorSM = txtValor.Text;
            SituacaoSM = txtSituacao.Text;

            try
            {
                EditSegMoto.EditarSegMoto(NumApolice, CPFMoto, Seguradora, Corretor, DataInicioSM, DataVencSM, ValorSM, SituacaoSM);
                btnEditSegMoto.Enabled = false;
                Limpar();
            }
            catch { }
        }

        private void btnDelSegMoto_Click(object sender, EventArgs e)
        {
            ServiçoExcluir ExcluiSegMoto = new ServiçoExcluir();

            NumApolice = Convert.ToInt32(txtNApolice.Text);

            try
            {
                ExcluiSegMoto.ExcluirSegMoto(NumApolice);
            }
            catch { }
        }

        private void btnLimparSegMoto_Click(object sender, EventArgs e)
        {
            Limpar();
        }
    }
}
