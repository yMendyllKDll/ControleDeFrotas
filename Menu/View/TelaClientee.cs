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
    public partial class TelaClientee : Form
    {
        string Nome = "", CPFouCNPJ = "", Endereco = "", Bairro = "", Estado = "", Categoria = "", ValCCNH = "", ValorPago = "", StatusCliente = "";
        int CodCliente;
        string tblNome, txtNome;

        public TelaClientee()
        {
            InitializeComponent();
            Atualizar();
            CodMax();
        }

        private void Atualizar()
        {
            ServiçoExibir ExibCliente = new ServiçoExibir();
            dataGridCliente.DataSource = ExibCliente.ExibirCliente();

        }
        private void CodMax()
        {
            tblNome = "tblClientes";
            txtNome = "CodCliente";
            ServiçoExibir SelecttMax = new ServiçoExibir();
            txtCodCliente.Text = Convert.ToString(SelecttMax.SelectMax(tblNome, txtNome));
        }

        private void Limpar()
        {
            txtCodCliente.Text = "";
            txtNomeCliente.Text = "";
            txtEndeCliente.Text = "";
            txtBairroCliente.Text = "";
            txtEstadoCliente.Text = "";
            txtCateCliente.Text = "";
            txtValCCNH.Text = "";
            txtValorPagoCliente.Text = "";
            txtStatusCliente.Text = "";
            txtCPFouCNPJ.Text = "";
            btnEditar.Enabled = false;
            CodMax();
        }

        private void btnExibirLista_Click(object sender, EventArgs e)
        {
            Atualizar();
        }
        
        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            if (txtCPFouCNPJ.Text != "         /")
            {
                string[] Dados = new string[9];
                CPFouCNPJ = txtCPFouCNPJ.Text;
                ServiçoExibir SelecttCliente = new ServiçoExibir();
                Dados = SelecttCliente.SelectCliente(CPFouCNPJ);
                txtCodCliente.Text = Dados[0];
                txtNomeCliente.Text = Dados[1];
                txtEndeCliente.Text = Dados[2];
                txtBairroCliente.Text = Dados[3];
                txtEstadoCliente.Text = Dados[4];
                txtCateCliente.Text = Dados[5];
                txtValCCNH.Text = Dados[6];
                txtValorPagoCliente.Text = Dados[7];
                txtStatusCliente.Text = Dados[8];

            }
            else
            {
                MessageBox.Show("Ops, Digite um CPFouCNPJ para Pesquisar");
            }

        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            ServiçoCadastros CadCliente = new ServiçoCadastros();
            CodCliente = Convert.ToInt32(txtCodCliente.Text);
            Nome = txtNomeCliente.Text;
            CPFouCNPJ = txtCPFouCNPJ.Text;
            Endereco = txtEndeCliente.Text;
            Bairro = txtBairroCliente.Text;
            Estado = txtEstadoCliente.Text;
            Categoria = txtCateCliente.Text;
            ValCCNH = txtValCCNH.Text;
            ValorPago = txtValorPagoCliente.Text;
            StatusCliente = txtStatusCliente.Text;

            try
            {
                CadCliente.CadastrarCliente(CodCliente, Nome, CPFouCNPJ, Endereco, Bairro, Estado, Categoria, ValCCNH, ValorPago, StatusCliente);
                btnEditar.Enabled = true;
            }
            catch { }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            ServiçoEditar EditCliente = new ServiçoEditar();
            Nome = txtNomeCliente.Text;
            CPFouCNPJ = txtCPFouCNPJ.Text;
            Endereco = txtEndeCliente.Text;
            Bairro = txtBairroCliente.Text;
            Estado = txtEstadoCliente.Text;
            Categoria = txtCateCliente.Text;
            ValCCNH = txtValCCNH.Text;
            ValorPago = txtValorPagoCliente.Text;
            StatusCliente = txtStatusCliente.Text;

            try
            {
                EditCliente.EditarCliente(Nome, CPFouCNPJ, Endereco, Bairro, Estado, Categoria, ValCCNH, ValorPago, StatusCliente);
                Limpar();
            }
            catch { }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            ServiçoExcluir ExcluiCliente = new ServiçoExcluir();

            CPFouCNPJ = txtCPFouCNPJ.Text;

            try
            {
                ExcluiCliente.ExcluirCliente(CPFouCNPJ);
            }
            catch { }
        }
        private void btnLimpar_Click(object sender, EventArgs e)
        {
            Limpar();
        }
    }
}
