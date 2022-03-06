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
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void sbmUsuario_Click(object sender, EventArgs e)
        {
            DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
            BLLPermissaoUsuario bll = new BLLPermissaoUsuario(cx);
            DataTable tabela = new DataTable();
            tabela = bll.LocalizarPermissao(SessaoUsuario.Session.Instance.UsuID, "frmCadastrarUsuario");
            if (tabela.Rows.Count <= 0)
            {
                MessageBox.Show("ATENÇÃO: O USUÁRIO NÃO POSSUI PERMISSÕES CADASTRADAS PARA ESSE FORMULARIO!!! \n\nCONTATE O ADMINISTRADOR E SOLICITE A PERMISSÃO");
                tabela.Dispose();
                return;
            }
            if (Convert.ToBoolean(tabela.Rows[0][4]) == true)
            {
                MessageBox.Show("ATENÇÃO: O USUÁRIO NÃO POSSUI PERMISSÕES DE ACESSO PARA ESSE FORMULARIO!!! \n\nCONTATE O ADMINISTRADOR E SOLICITE A PERMISSÃO");
                tabela.Dispose();
                return;
            }
            frmCadastrarUsuario f = new frmCadastrarUsuario();
            tabela.Dispose();
            f.ShowDialog();
            f.Dispose();
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            if (SessaoUsuario.Session.Instance.UsuGrupo != "Administrador")
            {
                mnUsuario.Visible = false;
                menuStrip1.Visible = false;
            }
        }

        private void sbmPermissaoUsuario_Click(object sender, EventArgs e)
        {
            DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
            BLLPermissaoUsuario bll = new BLLPermissaoUsuario(cx);
            DataTable tabela = new DataTable();
            tabela = bll.LocalizarPermissao(SessaoUsuario.Session.Instance.UsuID, "frmPermissaoUsuario");
            if (tabela.Rows.Count <= 0)
            {
                MessageBox.Show("ATENÇÃO: O USUÁRIO NÃO POSSUI PERMISSÕES CADASTRADAS PARA ESSE FORMULARIO!!! \n\nCONTATE O ADMINISTRADOR E SOLICITE A PERMISSÃO");
                tabela.Dispose();
                return;
            }
            if (Convert.ToBoolean(tabela.Rows[0][4]) == true)
            {
                MessageBox.Show("ATENÇÃO: O USUÁRIO NÃO POSSUI PERMISSÕES DE ACESSO PARA ESSE FORMULARIO!!! \n\nCONTATE O ADMINISTRADOR E SOLICITE A PERMISSÃO");
                tabela.Dispose();
                return;
            }
            frmPermissaoUsuario f = new frmPermissaoUsuario();
            f.ShowDialog();
            f.Dispose();
        }

        private void sbmConsultaUsuario_Click(object sender, EventArgs e)
        {
            DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
            BLLPermissaoUsuario bll = new BLLPermissaoUsuario(cx);
            DataTable tabela = new DataTable();
            tabela = bll.LocalizarPermissao(SessaoUsuario.Session.Instance.UsuID, "frmConsultaUsuario");
            if (tabela.Rows.Count <= 0)
            {
                MessageBox.Show("ATENÇÃO: O USUÁRIO NÃO POSSUI PERMISSÕES CADASTRADAS PARA ESSE FORMULARIO!!! \n\nCONTATE O ADMINISTRADOR E SOLICITE A PERMISSÃO");
                tabela.Dispose();
                return;
            }
            if (Convert.ToBoolean(tabela.Rows[0][4]) == true)
            {
                MessageBox.Show("ATENÇÃO: O USUÁRIO NÃO POSSUI PERMISSÕES DE ACESSO PARA ESSE FORMULARIO!!! \n\nCONTATE O ADMINISTRADOR E SOLICITE A PERMISSÃO");
                tabela.Dispose();
                return;
            }
            frmConsultaUsuario f = new frmConsultaUsuario();
            f.ShowDialog();
            f.Dispose();
        }
    }
}
