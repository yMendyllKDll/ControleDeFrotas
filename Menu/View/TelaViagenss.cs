using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAL;
using Menu.Controller;

namespace Menu.View
{
    public partial class TelaViagenss : Form
    {
        string DataViagem = "", EntregArEm = "", EntregEEm = "", Motivo = "", Situacao = "";
        int CodViagem, CodVVeiculo, CodVMoto;
        string tblNome, txtNome;

        public TelaViagenss()
        {
            InitializeComponent();
            Atualizar();
            CodMax();
        }
        private void LimpaTela()
        {
            foreach (Control c in groupBox2.Controls)
            {
                if (c is TextBox)
                {
                    c.Text = "";
                }
                if (c is ComboBox)
                {
                    c.Text = "";
                }
                if (c is MaskedTextBox)
                {
                    c.Text = "";
                }
            }

        }
        private void Atualizar()
        {
            ServiçoExibir ExibiVia = new ServiçoExibir();
            dataGridViagem.DataSource = ExibiVia.ExibirViagem();
        }
        private void CodMax()
        {
            tblNome = "tblViagens";
            txtNome = "CodViagem";
            ServiçoExibir SelecttMax = new ServiçoExibir();
            txtCodViagem.Text = Convert.ToString(SelecttMax.SelectMax(tblNome, txtNome));
        }

        private void Limpar()
        {
            txtCodViagem.Text = "";
            txtCodVeiculo.Text = "";
            txtCodMotorista.Text = "";
            txtDataViagem.Text = "";
            txtEngregArEm.Text = "";
            txtEntregEem.Text = "";
            txtMotivo.Text = "";
            txtSituacao.Text = "";
            btnEditar.Enabled = false;
            CodMax();
        }

        private void btnExibLista_Click(object sender, EventArgs e)
        {
            Atualizar();
        }
        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            if (txtCodViagem.Text != "")
            {
                string[] Dados = new string[7];
                CodViagem = Convert.ToInt32(txtCodViagem.Text);
                ServiçoExibir SelecttViagem = new ServiçoExibir();
                Dados = SelecttViagem.SelectViagem(CodViagem);
                txtCodVeiculo.Text = Dados[0];
                txtCodMotorista.Text = Dados[1];
                txtDataViagem.Text = Dados[2];
                txtEngregArEm.Text = Dados[3];
                txtEntregEem.Text = Dados[4];
                txtMotivo.Text = Dados[5];
                txtSituacao.Text = Dados[6];
                btnEditar.Enabled = true;
            }
            else
            {
                MessageBox.Show("Ops, Digite uma CODIGO VIAGEM para Pesquisar");
            }

        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            ServiçoCadastros CadViagem = new ServiçoCadastros();
            CodViagem = Convert.ToInt32(txtCodViagem.Text);
            CodVVeiculo = Convert.ToInt32(txtCodVeiculo.Text);
            CodVMoto = Convert.ToInt32(txtCodMotorista.Text);
            DataViagem = txtDataViagem.Text;
            EntregArEm = txtEngregArEm.Text;
            EntregEEm = txtEntregEem.Text;
            Motivo = txtMotivo.Text;
            Situacao = txtSituacao.Text;
            try
            {
                CadViagem.CadastrarViagem(CodViagem, CodVVeiculo, CodVMoto, DataViagem, EntregArEm, EntregEEm, Motivo, Situacao);
            }
            catch { }

            //Agenda Cadastrar
            Compromissos compromisso = new Compromissos();
            compromisso.Data = txtDataViagem.Text;
            compromisso.Hora = txtHora.Text;
            compromisso.Descricao = txtMotivo.Text;

            compromisso.Gravar();

            MessageBox.Show("Compromisso agendado com sucesso!",
                            "Informação",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
            LimpaTela();

        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            ServiçoEditar EditViagem = new ServiçoEditar();
            CodViagem = Convert.ToInt32(txtCodViagem.Text);
            CodVVeiculo = Convert.ToInt32(txtCodVeiculo.Text);
            CodVMoto = Convert.ToInt32(txtCodMotorista.Text);
            DataViagem = txtDataViagem.Text;
            EntregArEm = txtEngregArEm.Text;
            EntregEEm = txtEntregEem.Text;
            Motivo = txtMotivo.Text;
            Situacao = txtSituacao.Text;

            try
            {
                EditViagem.EditarViagem(CodViagem, CodVVeiculo, CodVMoto, DataViagem, EntregArEm, EntregEEm, Motivo, Situacao);
                Limpar();
            }
            catch { }

        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            ServiçoExcluir ExcluiViagem = new ServiçoExcluir();

            CodViagem = Convert.ToInt32(txtCodViagem.Text);

            //Agenda Excluir
            SqlCommand textoComando = new SqlCommand();
            using (SqlConnection conexao = Conexao.Conectar())
            {
                textoComando.CommandText = " DELETE FROM Compromissos WHERE Hora ='" + txtHora.Text + "'";
                textoComando.Connection = conexao;
                conexao.Open();
                textoComando.ExecuteNonQuery();
            }
            MessageBox.Show("Compromisso Excluido com sucesso!",
            "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
            LimpaTela();

            try
            {
                ExcluiViagem.ExcluirViagem(CodViagem);
            }
            catch { }

        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            Limpar();
        }
    }
}
