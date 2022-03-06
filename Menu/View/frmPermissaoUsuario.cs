using DAL;
using Modelo;
using BLL;
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
    public partial class frmPermissaoUsuario : Form
    {
        public frmPermissaoUsuario()
        {
            InitializeComponent();
        }
        string operacao = "";
        int UsuId = 0;
        string UsuLoginPesquisado = "";
        string UsuNomePesquisado = "";

        public void alterarBotoes(int op)
        {
            //1 = Inserir e Localizar
            //2= Inserir e Alterar
            //3= Excluir e Alterar
            btLocalizarPerm.Enabled = false;
            btAlterar.Enabled = false;
            btLocalizar.Enabled = false;
            btExcluir.Enabled = false;
            dgvDados.Enabled = false;
            btCancelar.Enabled = false;
            gbMarcarTodos.Enabled = false;
            btSalvar.Enabled = false;
            if (op == 1)
            {
                btLocalizar.Enabled = true;
                btLocalizarPerm.Enabled = true;
                btCancelar.Enabled = false;
            }
            if (op == 2)
            {
                dgvDados.Enabled = true;
                btSalvar.Enabled = true;
                btCancelar.Enabled = true;
                gbMarcarTodos.Enabled = true;
            }
            if (op == 3)
            {
                btAlterar.Enabled = true;
                btExcluir.Enabled = true;
                btCancelar.Enabled = true;
            }
        }

        private void btAlterar_Click(object sender, EventArgs e)
        {
            operacao = "alterar";
            alterarBotoes(2);
        }

        private void frmPermissaoUsuario_Load(object sender, EventArgs e)
        {
            alterarBotoes(1);
        }

        private void btLocalizar_Click(object sender, EventArgs e)
        {
            frmConsultaUsuario f = new frmConsultaUsuario();
            f.ShowDialog();
            if (f.codigo != 0)
            {
                txtValor.Text = f.codigo.ToString();
                btLocalizarPerm_Click(sender, e);
                alterarBotoes(3);
            }
            else
            {
                alterarBotoes(1);
            }
            f.Dispose();
        }

        private void btLocalizarPerm_Click(object sender, EventArgs e)
        {
            try
            {
                DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
                //VERIFICA SE TEM USUÁRIO COM O ID DIGITADO
                BLLUsuario bllTestaUsuario = new BLLUsuario(cx);
                if (bllTestaUsuario.Localizar(Convert.ToInt32(txtValor.Text)).Rows.Count <= 0)
                {
                    MessageBox.Show("ATENÇÃO !! \n O CÓDIGO DIGITADO NÃO CORRESPONDE A NENHUM CADASTRO DE USUÁRIO !!", "Aviso !!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtValor.Focus();
                    txtValor.Text = "";
                    return;
                }

                BLLPermissaoUsuario bll = new BLLPermissaoUsuario(cx);
                DataTable tabela = new DataTable();
                tabela = bll.Localizar(Convert.ToInt32(txtValor.Text));
                int tPerm = 0;
                tPerm = tabela.Rows.Count;
                if (tPerm > 0)
                {
                    //Carrega as Permissões que o Usuário tem no Banco de Dados
                    for (int x = 0; x < tPerm;)
                    {
                        dgvDados.Rows.Add();
                        dgvDados.Rows[x].Cells[0].Value = tabela.Rows[x][0];
                        dgvDados.Rows[x].Cells[1].Value = tabela.Rows[x][1];
                        dgvDados.Rows[x].Cells[2].Value = tabela.Rows[x][2];
                        dgvDados.Rows[x].Cells[3].Value = tabela.Rows[x][3];
                        dgvDados.Rows[x].Cells[4].Value = tabela.Rows[x][4];
                        dgvDados.Rows[x].Cells[5].Value = tabela.Rows[x][5];
                        dgvDados.Rows[x].Cells[6].Value = tabela.Rows[x][6];
                        dgvDados.Rows[x].Cells[7].Value = tabela.Rows[x][7];
                        x++;
                    }
                    UsuId = Convert.ToInt32(tabela.Rows[0][10]);
                    UsuNomePesquisado = Convert.ToString(tabela.Rows[0][8]);
                    UsuLoginPesquisado = Convert.ToString(tabela.Rows[0][9]);
                    alterarBotoes(3);
                    tabela.Dispose();
                }
                else
                {
                    //PREENCHE AS VARIAVEIS COM O NOME DO USUÁRIO RECÉM CADASTRADO E SEM PERMISSÃO.
                    BLLUsuario bllUsuario = new BLLUsuario(cx);
                    DataTable dtUsuario = new DataTable();
                    dtUsuario = bllUsuario.Localizar(Convert.ToInt32(txtValor.Text));
                    UsuId = Convert.ToInt32(dtUsuario.Rows[0][0]);
                    UsuNomePesquisado = Convert.ToString(dtUsuario.Rows[0][1]);
                    UsuLoginPesquisado = Convert.ToString(dtUsuario.Rows[0][2]);

                    //Carregar Permissões Default
                    IDictionary<string, string> strPer = new Dictionary<string, string>()
                {//Cadastro dos Formularios
                {"TelaMotoristaa","Cadastrar Motoristas"},
                {"TelaSeguroMotoristaa","Cadastrar Seguros Motoristas"},
                {"TelaVeiculoss","Cadastrar Veículos" },
                {"TelaCompraVendaa","Cadastrar Compra e Venda dos Veículos" },
                {"TelaSeguroVeiculoo","Cadastrar Seguros Veículos"},
                {"TelaSinistross","Cadastrar Sinistros"},
                {"TelaViagenss","Cadastrar Viagens"},
                {"TelaAbastecimentoo","Cadastrar Abastecimentos"},
                {"TelaClientee","Cadastro de Clientes" },
                {"TelaLocaçãoo","Cadastrar Locações" },
                {"TelaMultass","Cadastrar Multas" },
                {"TelaManutençãoo","Cadastrar Manutenções" },
                {"TelaFinanceiroo","Cadastrar Financeiro" },
                {"TelaVeiculosDisponiveiss","Visualizar Veículos Disponiveis" },
                {"TelaAvisoss","Visualizar Avisos" },
                {"TelaRelatorioss","Visualizar Relatórios" },
                {"frmCadastrarUsuario","Cadastrar Usuário" },
                {"frmPermissaoUsuario","Cadastrar as Permissões de Acesso dos Usuários" },
                {"frmConsultarUsuario","Consultar Usuário" },

            };
                    int i = 0;
                    foreach (string Perm in strPer.Keys)
                    {
                        dgvDados.Rows.Add();
                        dgvDados.Rows[i].Cells[1].Value = Perm;
                        dgvDados.Rows[i].Cells[2].Value = strPer[Perm];
                        if (Perm == "frmCadastrarUsuario" || Perm == "frmPermissaoUsuario")
                        {
                            dgvDados.Rows[i].Cells[3].Value = "True";
                        }
                        else
                        dgvDados.Rows[i].Cells[3].Value = "False";
                        dgvDados.Rows[i].Cells[4].Value = "False";
                        dgvDados.Rows[i].Cells[5].Value = "False";
                        dgvDados.Rows[i].Cells[6].Value = "False";
                        dgvDados.Rows[i].Cells[7].Value = "False";
                        i++;
                    }
                    MessageBox.Show("ATENÇÃO!!\n CONFIGURAÇÕES PADRÃO (DEFAULT) FORAM CARREGADAS PARA O USUÁRIO!! \n\n" +
                        "REALIZE AS DEVIDAS ALTERAÇÕES E CLIQUE EM SALVAR, PARA QUE O USUÁRIO TENHA ACESSO AO SISTEMA", "ATENÇÃO !!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    operacao = "inserir";
                    alterarBotoes(3);
                }
                txtUsuarioPesquisado.Text = UsuNomePesquisado + "(" + UsuLoginPesquisado + ")";
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message, "ERRO !!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btCancelar_Click(object sender, EventArgs e)
        {
            alterarBotoes(1);
            dgvDados.Rows.Clear();
            UsuId = 0;
            UsuLoginPesquisado = "";
            UsuNomePesquisado = "";
            txtValor.Text = "";
        }

        private void btSalvar_Click(object sender, EventArgs e)
        {
            DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
            ModeloPermissaoUsuario modelo = new ModeloPermissaoUsuario();
            BLLPermissaoUsuario bll = new BLLPermissaoUsuario(cx);
            if (operacao == "alterar")
            {
                //EXCLUIR AS PERMISSÕES DO USUÁRIO
                BLLPermissaoUsuario bllExcluir = new BLLPermissaoUsuario(cx);
                bllExcluir.ExcluirTudo(UsuId);
            }
            //PREENCHER O MODELO E GRAVAR NO BANCO DE DADOS
            int x = dgvDados.RowCount;
            for (int i = 0; i < x; i++)
            {
                modelo.PerAlterar = Convert.ToString(dgvDados.Rows[i].Cells[5].Value);
                modelo.PerBloqueado = Convert.ToString(dgvDados.Rows[i].Cells[3].Value);
                modelo.PerDescricao = Convert.ToString(dgvDados.Rows[i].Cells[2].Value);
                modelo.PerExcluir = Convert.ToString(dgvDados.Rows[i].Cells[6].Value);
                modelo.PerImprimir = Convert.ToString(dgvDados.Rows[i].Cells[7].Value);
                modelo.PerInserir = Convert.ToString(dgvDados.Rows[i].Cells[4].Value);
                modelo.PerNomefrm = Convert.ToString(dgvDados.Rows[i].Cells[1].Value);
                modelo.UsuId = Convert.ToInt32(UsuId);
                bll.Incluir(modelo);
            }
            MessageBox.Show("AS PERMISSÕES FORAM CADASTRADAS COM SUCESSO !!", "Aviso !!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            alterarBotoes(1);
            dgvDados.Rows.Clear();
            txtValor.Text = "";
            operacao = "";
            UsuId = 0;
            UsuLoginPesquisado = "";
            UsuNomePesquisado = "";
        }

        private void cbMB_CheckedChanged(object sender, EventArgs e)
        {
            int x = dgvDados.RowCount;
            for (int i = 0; i < x; i++)
            {
                dgvDados.Rows[i].Cells[3].Value = cbMB.Checked;
            }
        }

        private void cbMI_CheckedChanged(object sender, EventArgs e)
        {
            int x = dgvDados.RowCount;
            for (int i = 0; i < x; i++)
            {
                dgvDados.Rows[i].Cells[4].Value = cbMI.Checked;
            }
        }

        private void cbMA_CheckedChanged(object sender, EventArgs e)
        {
            int x = dgvDados.RowCount;
            for (int i = 0; i < x; i++)
            {
                dgvDados.Rows[i].Cells[5].Value = cbMA.Checked;
            }
        }

        private void cbME_CheckedChanged(object sender, EventArgs e)
        {
            int x = dgvDados.RowCount;
            for (int i = 0; i < x; i++)
            {
                dgvDados.Rows[i].Cells[6].Value = cbME.Checked;
            }
        }

        private void cbMim_CheckedChanged(object sender, EventArgs e)
        {
            int x = dgvDados.RowCount;
            for (int i = 0; i < x; i++)
            {
                dgvDados.Rows[i].Cells[7].Value = cbMim.Checked;
            }
        }

        private void btExcluir_Click(object sender, EventArgs e)
        {
            try
            {
                if (Convert.ToInt32(dgvDados.Rows[0].Cells[0].Value) <= 0)
                {
                    dgvDados.Rows.Clear();
                    return;
                }
                DialogResult d = MessageBox.Show("DESEJA EXCLUIR TODAS AS PERMISSÕES DO USUÁRIO PESQUISADO ??" +
                    "\n \nATENÇÃO!! SEM AS PERMISSÕES, O USUÁRIO NÃO CONSEGUIRÁ ACESSAR O SISTEMA !!!", "AVISO", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
                if (d.ToString() == "Yes")
                {
                    DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
                    BLLPermissaoUsuario bll = new BLLPermissaoUsuario(cx);
                    bll.ExcluirTudo(UsuId);
                    dgvDados.Rows.Clear();
                    alterarBotoes(1);
                }
            }
            catch
            {
                MessageBox.Show("IMPOSSIVEL EXCLUIR O RESGISTRO. \n O REGISTRO ESTÁ SENDO UTILIZADO EM OUTRO LOCAL.");
                this.alterarBotoes(3);
            }
        }
    }
}
