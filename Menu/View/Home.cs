using BLL;
using DAL;
using Ferramentas;
using Menu.View;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Menu
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
            hideSubMenu();
            panelVeiculoSubMenu.Visible = false;
            panelMotoristaSubMenu.Visible = false;
            panelViagenSubMenu.Visible = false;
            panelFinanceiroSubMenu.Visible = false;
            openChildForm(new View.TelaAgendaa());
        }

        private void MenuSuperior_Paint(object sender, PaintEventArgs e)
        {

        }
        private void Tracinho_Click(object sender, EventArgs e)
        {
            if(MenuLateral.Visible)
            {
                tshow.HideSync(MenuLateral);
            }
            else
            {
                tshow.ShowSync(MenuLateral);
            }
        }
        private void BunifuFlatButton10_Click(object sender, EventArgs e)
        {
            DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
            BLLPermissaoUsuario bll = new BLLPermissaoUsuario(cx);
            DataTable tabela = new DataTable();
            tabela = bll.LocalizarPermissao(SessaoUsuario.Session.Instance.UsuID, "TelaRelatorioss");
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
            openChildForm(new View.TelaRelatorioss());
            panelVeiculoSubMenu.Visible = false;
            panelMotoristaSubMenu.Visible = false;
            panelViagenSubMenu.Visible = false;
            panelFinanceiroSubMenu.Visible = false;
        }

        private void BtnMotorista_Click(object sender, EventArgs e)
        {
            DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
            BLLPermissaoUsuario bll = new BLLPermissaoUsuario(cx);
            DataTable tabela = new DataTable();
            tabela = bll.LocalizarPermissao(SessaoUsuario.Session.Instance.UsuID, "TelaMotoristaa");
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
            openChildForm(new View.TelaMotoristaa());
            showSubMenu(panelMotoristaSubMenu);
            panelVeiculoSubMenu.Visible = false;
            panelViagenSubMenu.Visible = false;
            panelFinanceiroSubMenu.Visible = false;
            
        }

        private void BtnVeiculos_Click(object sender, EventArgs e)
        {
            DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
            BLLPermissaoUsuario bll = new BLLPermissaoUsuario(cx);
            DataTable tabela = new DataTable();
            tabela = bll.LocalizarPermissao(SessaoUsuario.Session.Instance.UsuID, "TelaVeiculoss");
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
            openChildForm(new View.TelaVeiculoss());
            showSubMenu(panelVeiculoSubMenu);
            panelMotoristaSubMenu.Visible = false;
            panelViagenSubMenu.Visible = false;
            panelFinanceiroSubMenu.Visible = false;
        }

        private void Homee_Click(object sender, EventArgs e)
        {
            openChildForm(new View.frmAgenda());
            panelVeiculoSubMenu.Visible = false;
            panelMotoristaSubMenu.Visible = false;
            panelViagenSubMenu.Visible = false;
            panelFinanceiroSubMenu.Visible = false;
        }

        private void BtnCliente_Click(object sender, EventArgs e)
        {
            DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
            BLLPermissaoUsuario bll = new BLLPermissaoUsuario(cx);
            DataTable tabela = new DataTable();
            tabela = bll.LocalizarPermissao(SessaoUsuario.Session.Instance.UsuID, "TelaClientee");
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
            openChildForm(new View.TelaClientee());
            panelVeiculoSubMenu.Visible = false;
            panelMotoristaSubMenu.Visible = false;
            panelViagenSubMenu.Visible = false;
            panelFinanceiroSubMenu.Visible = false;
        }

        private void BtnViagens_Click(object sender, EventArgs e)
        {
            DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
            BLLPermissaoUsuario bll = new BLLPermissaoUsuario(cx);
            DataTable tabela = new DataTable();
            tabela = bll.LocalizarPermissao(SessaoUsuario.Session.Instance.UsuID, "TelaViagenss");
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
            openChildForm(new View.TelaViagenss());
            showSubMenu(panelViagenSubMenu);
            panelMotoristaSubMenu.Visible = false;
            panelVeiculoSubMenu.Visible = false;
            panelFinanceiroSubMenu.Visible = false;
        }

        private void BtnManutencao_Click(object sender, EventArgs e)
        {
            DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
            BLLPermissaoUsuario bll = new BLLPermissaoUsuario(cx);
            DataTable tabela = new DataTable();
            tabela = bll.LocalizarPermissao(SessaoUsuario.Session.Instance.UsuID, "TelaManutençãoo");
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
            openChildForm(new View.TelaManutençãoo());
            panelVeiculoSubMenu.Visible = false;
            panelMotoristaSubMenu.Visible = false;
            panelViagenSubMenu.Visible = false;
            panelFinanceiroSubMenu.Visible = false;
        }

        private void BtnLocacao_Click(object sender, EventArgs e)
        {
            DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
            BLLPermissaoUsuario bll = new BLLPermissaoUsuario(cx);
            DataTable tabela = new DataTable();
            tabela = bll.LocalizarPermissao(SessaoUsuario.Session.Instance.UsuID, "TelaLocaçãoo");
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
            openChildForm(new View.TelaLocaçãoo());
            panelVeiculoSubMenu.Visible = false;
            panelMotoristaSubMenu.Visible = false;
            panelViagenSubMenu.Visible = false;
            panelFinanceiroSubMenu.Visible = false;
        }

        private void BtnMultas_Click(object sender, EventArgs e)
        {
            DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
            BLLPermissaoUsuario bll = new BLLPermissaoUsuario(cx);
            DataTable tabela = new DataTable();
            tabela = bll.LocalizarPermissao(SessaoUsuario.Session.Instance.UsuID, "TelaMultass");
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
            openChildForm(new View.TelaMultass());
            panelVeiculoSubMenu.Visible = false;
            panelMotoristaSubMenu.Visible = false;
            panelViagenSubMenu.Visible = false;
            panelFinanceiroSubMenu.Visible = false;
        }

        private void BtnAvisos_Click(object sender, EventArgs e)
        {
            DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
            BLLPermissaoUsuario bll = new BLLPermissaoUsuario(cx);
            DataTable tabela = new DataTable();
            tabela = bll.LocalizarPermissao(SessaoUsuario.Session.Instance.UsuID, "TelaAvisoss");
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
            openChildForm(new View.TelaAvisoss());
            panelVeiculoSubMenu.Visible = false;
            panelMotoristaSubMenu.Visible = false;
            panelViagenSubMenu.Visible = false;
            panelFinanceiroSubMenu.Visible = false;
        }

        private void BtnVeiculosDisponiveis_Click(object sender, EventArgs e)
        {
            DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
            BLLPermissaoUsuario bll = new BLLPermissaoUsuario(cx);
            DataTable tabela = new DataTable();
            tabela = bll.LocalizarPermissao(SessaoUsuario.Session.Instance.UsuID, "TelaVeiculosDisponiveiss");
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
            openChildForm(new View.TelaVeiculosDisponiveiss());
            panelVeiculoSubMenu.Visible = false;
            panelMotoristaSubMenu.Visible = false;
            panelViagenSubMenu.Visible = false;
            panelFinanceiroSubMenu.Visible = false;
        }

        private void BtnFinanceiro_Click(object sender, EventArgs e)
        {
            DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
            BLLPermissaoUsuario bll = new BLLPermissaoUsuario(cx);
            DataTable tabela = new DataTable();
            tabela = bll.LocalizarPermissao(SessaoUsuario.Session.Instance.UsuID, "TelaFinanceiroo");
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
            openChildForm(new View.TelaFinanceiroo());
            showSubMenu(panelFinanceiroSubMenu);
            panelVeiculoSubMenu.Visible = false;
            panelMotoristaSubMenu.Visible = false;
            panelViagenSubMenu.Visible = false;
        }

        private void BunifuImageButton3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BtnMinimizar_Click(object sender, EventArgs e)
        {
          this.WindowState = FormWindowState.Minimized;
        }

        private void BtnRestaurarTamanho_Click(object sender, EventArgs e)
        {
            if (WindowState != FormWindowState.Maximized)
            {
                WindowState = FormWindowState.Maximized;
                MaximumSize = this.Size;
            }
            else
            {
                if (WindowState == FormWindowState.Maximized)
                {
                    this.WindowState = FormWindowState.Normal;
                }
            }
        }
        private void hideSubMenu()
        {
        }

        private void showSubMenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                hideSubMenu();
                subMenu.Visible = true;
            }
            else
                subMenu.Visible = false;
        }

        private Form activeForm = null;
        private void openChildForm(Form childForm)
        {
            if (activeForm != null) activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelChildForm.Controls.Add(childForm);
            panelChildForm.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void MenuLateral_Paint(object sender, PaintEventArgs e)
        {

        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
            BLLPermissaoUsuario bll = new BLLPermissaoUsuario(cx);
            DataTable tabela = new DataTable();
            tabela = bll.LocalizarPermissao(SessaoUsuario.Session.Instance.UsuID, "TelaCompraVendaa");
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
            openChildForm(new View.TelaCompraVendaa());
            panelMotoristaSubMenu.Visible = false;
            panelViagenSubMenu.Visible = false;
            panelFinanceiroSubMenu.Visible = false;
            hideSubMenu();
        }

        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {
            DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
            BLLPermissaoUsuario bll = new BLLPermissaoUsuario(cx);
            DataTable tabela = new DataTable();
            tabela = bll.LocalizarPermissao(SessaoUsuario.Session.Instance.UsuID, "TelaSeguroVeiculoo");
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
            openChildForm(new View.TelaSeguroVeiculoo());
            panelMotoristaSubMenu.Visible = false;
            panelViagenSubMenu.Visible = false;
            panelFinanceiroSubMenu.Visible = false;
            hideSubMenu();
        }

        private void BtnSeguroMotorista_Click(object sender, EventArgs e)
        {
            DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
            BLLPermissaoUsuario bll = new BLLPermissaoUsuario(cx);
            DataTable tabela = new DataTable();
            tabela = bll.LocalizarPermissao(SessaoUsuario.Session.Instance.UsuID, "TelaSeguroMotoristaa");
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
            openChildForm(new View.TelaSeguroMotoristaa());
            panelVeiculoSubMenu.Visible = false;
            panelViagenSubMenu.Visible = false;
            panelFinanceiroSubMenu.Visible = false;
            hideSubMenu();
        }

        private void Horafecha_Tick(object sender, EventArgs e)
        {
            Hora.Text = DateTime.Now.ToString("HH:mm:ss");
        }

        private void BtnSinistro_Click(object sender, EventArgs e)
        {
            DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
            BLLPermissaoUsuario bll = new BLLPermissaoUsuario(cx);
            DataTable tabela = new DataTable();
            tabela = bll.LocalizarPermissao(SessaoUsuario.Session.Instance.UsuID, "TelaSinistross");
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
            openChildForm(new View.TelaSinistross());
            panelMotoristaSubMenu.Visible = false;
            panelViagenSubMenu.Visible = false;
            panelFinanceiroSubMenu.Visible = false;
            hideSubMenu();
        }

        private void BtnAbastecimento_Click(object sender, EventArgs e)
        {
            DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
            BLLPermissaoUsuario bll = new BLLPermissaoUsuario(cx);
            DataTable tabela = new DataTable();
            tabela = bll.LocalizarPermissao(SessaoUsuario.Session.Instance.UsuID, "TelaAbastecimentoo");
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
            openChildForm(new View.TelaAbastecimentoo());
            panelVeiculoSubMenu.Visible = false;
            panelMotoristaSubMenu.Visible = false;
            panelFinanceiroSubMenu.Visible = false;
            hideSubMenu();
        }

        private void BtnContasReceber_Click(object sender, EventArgs e)
        {
            openChildForm(new View.TelaContasReceberr());
            panelVeiculoSubMenu.Visible = false;
            panelMotoristaSubMenu.Visible = false;
            panelViagenSubMenu.Visible = false;
            hideSubMenu();
        }

        private void BtnContasPagar_Click(object sender, EventArgs e)
        {
            openChildForm(new View.TelaContasPagarr());
            panelVeiculoSubMenu.Visible = false;
            panelMotoristaSubMenu.Visible = false;
            panelViagenSubMenu.Visible = false;
            hideSubMenu();
        }

        private void Home_Load(object sender, EventArgs e)
        {
            txtUsuarioLogado.Text = SessaoUsuario.Session.Instance.UsuNome;
            if (SessaoUsuario.Session.Instance.UsuGrupo != "Administrador")
            {
                btnFinanceiro.Visible = false;
                btnRelatorios.Visible = false;
                btnManutencao.Visible = false;
                btnMultas.Visible = false;
                btnCliente.Visible = false;
            }
        }
        private void btnSobre_Click(object sender, EventArgs e)
        {
            openChildForm(new View.frmPrincipal());
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmLogin f = new frmLogin();
            f.ShowDialog();
            f.Dispose();
        }
    }
}
