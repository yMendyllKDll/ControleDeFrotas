using BLL;
using DAL;
using Ferramentas;
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
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btLogar_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtUsuario.Text.Trim().Length == 0 || txtSenha.Text.Trim().Length == 0)
                {
                    MessageBox.Show("OS CAMPOS (USUÁRIO E SENHA) SÃO DE PREENCIMENTO OBRIGATÓRIA !! \n\n" +
                        "PREENCHA OS DADOS E CLIQUE NOVAMENTE EM LOGAR !!", "ERRO!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtUsuario.Focus();
                    return;
                }
                DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
                BLLUsuario bll = new BLLUsuario(cx);
                DataTable tabela = new DataTable();
                tabela = bll.LocalizarUsuarioLogin(txtUsuario.Text, txtSenha.Text);
                if (tabela.Rows.Count == 1)
                {
                    SessaoUsuario.Session.Instance.UsuID = Convert.ToInt32(tabela.Rows[0][0].ToString());
                    SessaoUsuario.Session.Instance.UsuNome = tabela.Rows[0][2].ToString();
                    SessaoUsuario.Session.Instance.UsuGrupo = tabela.Rows[0][3].ToString();
                    this.Close();
                    this.Dispose();
                    Home f = new Home();
                    f.ShowDialog();
                    f.Dispose();
                }
                else
                {
                    MessageBox.Show("USUÁRIO NÃO ENCONTRADO");
                    return;
                }
            }
            catch
            {
                MessageBox.Show("UM ERRO OCORREU AO PROCESSAR OS DADOS!! \n TENTE NOVAMENTE MAIS TARDE!!");
            }
        }

        private void btSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
