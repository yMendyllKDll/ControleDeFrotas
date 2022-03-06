using BLL;
using DAL;
using Ferramentas;
using Modelo;
using System.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Menu.View
{
    public partial class frmCadastrarUsuario : Menu.View.frmModelodeCadastro
    {
        public frmCadastrarUsuario()
        {
            InitializeComponent();
        }
        //Variaveis que guardara as permissões.
        Boolean perInserir = false; Boolean perAlterar = false; Boolean perExcluir = false; Boolean perImprimir = false;
        private void LimpaTela()
        {
            foreach (Control c in pnDados.Controls)
            {
                if (c is TextBox)
                {
                    c.Text = "";
                }
                if (c is ComboBox)
                {
                    c.Text = "";
                }
            }

        }

        private void btInserir_Click(object sender, EventArgs e)
        {
            operacao = "inserir";
            alterarBotoes(2, perInserir, perAlterar, perExcluir, perImprimir);
            txtCodigo.Enabled = false;
        }

        private void btLocalizar_Click(object sender, EventArgs e)
        {
            try
            {
                frmConsultaUsuario f = new frmConsultaUsuario();
                f.ShowDialog();
                if (f.codigo != 0)
                {
                    DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
                    BLLUsuario bll = new BLLUsuario(cx);
                    ModeloUsuario modelo = bll.CarregaModeloUsuario(f.codigo);
                    txtCodigo.Text = modelo.UsuId.ToString();
                    txtGrupo.Text = modelo.UsuGrupo;
                    txtLogin.Text = modelo.UsuLogin;
                    txtNome.Text = modelo.UsuNome;
                    txtSenha.Text = modelo.UsuSenha;
                    alterarBotoes(3, perInserir, perAlterar, perExcluir, perImprimir);
                }
                else
                {
                    LimpaTela();
                    alterarBotoes(1, perInserir, perAlterar, perExcluir, perImprimir);
                }

                f.Dispose();
            }
            catch (Exception erro)
            {
                MessageBox.Show("NÃO FOI POSSIVEL REALIZAR A OPERAÇÃO!\nERRO OCORRIDO:" +
                erro.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }

        private void btAlterar_Click(object sender, EventArgs e)
        {
            operacao = "alterar";
            alterarBotoes(2, perInserir, perAlterar, perExcluir, perImprimir);
        }

        private void btExcluir_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult d = MessageBox.Show("DESEJA EXCLUIR O REGISTRO?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (d.ToString() == "Yes")
                {
                    DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
                    BLLUsuario bll = new BLLUsuario(cx);
                    bll.Excluir(Convert.ToInt32(txtCodigo.Text));
                    LimpaTela();
                    alterarBotoes(1, perInserir, perAlterar, perExcluir, perImprimir);
                }
            }
            catch (Exception erro)
            {
                MessageBox.Show("IMPOSSIVEL EXCLUIR O RESGISTRO ! \n O REGISTRO PODE ESTÁ VINCULADO EM OUTRAS TABELAS!\nERRO OCORRIDO:" +
                erro.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                ModeloUsuario modelo = new ModeloUsuario();
                modelo.UsuGrupo = txtGrupo.Text;
                modelo.UsuNome = txtNome.Text;
                modelo.UsuSenha = txtSenha.Text;
                modelo.UsuLogin = txtLogin.Text;

                DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
                BLLUsuario bll = new BLLUsuario(cx);
                if (operacao == "inserir")
                {
                    //CADASTRO DO USUÁRIO
                    bll.Incluir(modelo);
                    MessageBox.Show("CADASTRO EFETUADO COM SUCESSO !! CÓDIGO:" + modelo.UsuId.ToString(), "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    //Alterar os Dados
                    modelo.UsuId = Convert.ToInt32(txtCodigo.Text);
                    bll.Alterar(modelo);
                    MessageBox.Show("CADASTRO ALTERADO COM SUCESSO !! CÓDIGO:" + modelo.UsuId.ToString(), "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                LimpaTela();
                alterarBotoes(1, perInserir, perAlterar, perExcluir, perImprimir);
            }
            catch (Exception erro)
            {
                MessageBox.Show("NÃO FOI POSSIVEL REALIZAR A OPERAÇÃO! \n ERRO OCORRIDO:" +
                    erro.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }

        private void btCancelar_Click(object sender, EventArgs e)
        {
            //Limpar a tela
            LimpaTela();
            alterarBotoes(1, perInserir, perAlterar, perExcluir, perImprimir);
        }

        private void frmCadastrarUsuario_Load(object sender, EventArgs e)
        {
            try
            {
                DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
                BLLPermissaoUsuario bll = new BLLPermissaoUsuario(cx);
                DataTable tabela = new DataTable();
                tabela = bll.LocalizarPermissao(SessaoUsuario.Session.Instance.UsuID, this.Name.ToString());
                //Carregar as Permissões do Usuário
                perInserir = Convert.ToBoolean(tabela.Rows[0][5]);
                perAlterar = Convert.ToBoolean(tabela.Rows[0][6]);
                perExcluir = Convert.ToBoolean(tabela.Rows[0][7]);
                perImprimir = Convert.ToBoolean(tabela.Rows[0][8]);

                //Chamar a Função ChecaPermissões
                alterarBotoes(1, perInserir, perAlterar, perExcluir, perImprimir);
            }
            catch
            {
                MessageBox.Show("ATENÇÃO !! \n O BANCO DE DADOS PODE NÃO ESTAR CONECTADO CORRETAMENTE !!", "ERRO !!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtNome_Leave(object sender, EventArgs e)
        {
            try
            {
                if (operacao == "inserir" && txtLogin.Text.Trim().Length == 0 && txtNome.Text.Trim().Length > 0)
                {
                    string[] f = txtNome.Text.Split(' ');
                    txtLogin.Text = Convert.ToString(f[0] + f.Last());
                }
            }
            catch
            {
                return;
            }
        }
    }
}
