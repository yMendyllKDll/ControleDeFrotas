namespace Menu
{
    partial class Home
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            BunifuAnimatorNS.Animation animation1 = new BunifuAnimatorNS.Animation();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
            this.MenuLateral = new System.Windows.Forms.Panel();
            this.btnRelatorios = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnAvisos = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnVeiculosDisponiveis = new Bunifu.Framework.UI.BunifuFlatButton();
            this.panelFinanceiroSubMenu = new System.Windows.Forms.Panel();
            this.btnContasPagar = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnContasReceber = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnFinanceiro = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnManutencao = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnMultas = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnLocacao = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnCliente = new Bunifu.Framework.UI.BunifuFlatButton();
            this.panelViagenSubMenu = new System.Windows.Forms.Panel();
            this.btnAbastecimento = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnViagens = new Bunifu.Framework.UI.BunifuFlatButton();
            this.panelVeiculoSubMenu = new System.Windows.Forms.Panel();
            this.btnSinistro = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnSeguroVeiculo = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnCompraVenda = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnVeiculos = new Bunifu.Framework.UI.BunifuFlatButton();
            this.panelMotoristaSubMenu = new System.Windows.Forms.Panel();
            this.btnSeguroMotorista = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnMotorista = new Bunifu.Framework.UI.BunifuFlatButton();
            this.LOGO = new System.Windows.Forms.PictureBox();
            this.bunifuFlatButton4 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.tshow = new BunifuAnimatorNS.BunifuTransition(this.components);
            this.panelSuperior = new System.Windows.Forms.Panel();
            this.btnMenu = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.btnSobre = new Bunifu.Framework.UI.BunifuImageButton();
            this.txtUsuarioLogado = new System.Windows.Forms.TextBox();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.Hora = new System.Windows.Forms.Label();
            this.btnFechar = new Bunifu.Framework.UI.BunifuImageButton();
            this.btnRestaurarTamanho = new Bunifu.Framework.UI.BunifuImageButton();
            this.btnMinimizar = new Bunifu.Framework.UI.BunifuImageButton();
            this.Casinha = new Bunifu.Framework.UI.BunifuImageButton();
            this.Tracinho = new Bunifu.Framework.UI.BunifuImageButton();
            this.panelChildForm = new System.Windows.Forms.Panel();
            this.MenuDianteiro = new System.Windows.Forms.Panel();
            this.bunifuDragControl2 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.horafecha = new System.Windows.Forms.Timer(this.components);
            this.MenuLateral.SuspendLayout();
            this.panelFinanceiroSubMenu.SuspendLayout();
            this.panelViagenSubMenu.SuspendLayout();
            this.panelVeiculoSubMenu.SuspendLayout();
            this.panelMotoristaSubMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LOGO)).BeginInit();
            this.panelSuperior.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnSobre)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnFechar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnRestaurarTamanho)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Casinha)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Tracinho)).BeginInit();
            this.MenuDianteiro.SuspendLayout();
            this.SuspendLayout();
            // 
            // MenuLateral
            // 
            this.MenuLateral.AutoSize = true;
            this.MenuLateral.BackColor = System.Drawing.Color.DodgerBlue;
            this.MenuLateral.Controls.Add(this.btnRelatorios);
            this.MenuLateral.Controls.Add(this.btnAvisos);
            this.MenuLateral.Controls.Add(this.btnVeiculosDisponiveis);
            this.MenuLateral.Controls.Add(this.panelFinanceiroSubMenu);
            this.MenuLateral.Controls.Add(this.btnFinanceiro);
            this.MenuLateral.Controls.Add(this.btnManutencao);
            this.MenuLateral.Controls.Add(this.btnMultas);
            this.MenuLateral.Controls.Add(this.btnLocacao);
            this.MenuLateral.Controls.Add(this.btnCliente);
            this.MenuLateral.Controls.Add(this.panelViagenSubMenu);
            this.MenuLateral.Controls.Add(this.btnViagens);
            this.MenuLateral.Controls.Add(this.panelVeiculoSubMenu);
            this.MenuLateral.Controls.Add(this.btnVeiculos);
            this.MenuLateral.Controls.Add(this.panelMotoristaSubMenu);
            this.MenuLateral.Controls.Add(this.btnMotorista);
            this.MenuLateral.Controls.Add(this.LOGO);
            this.MenuLateral.Controls.Add(this.bunifuFlatButton4);
            this.tshow.SetDecoration(this.MenuLateral, BunifuAnimatorNS.DecorationType.None);
            this.MenuLateral.Dock = System.Windows.Forms.DockStyle.Left;
            this.MenuLateral.Location = new System.Drawing.Point(0, 0);
            this.MenuLateral.Name = "MenuLateral";
            this.MenuLateral.Size = new System.Drawing.Size(180, 788);
            this.MenuLateral.TabIndex = 0;
            this.MenuLateral.Paint += new System.Windows.Forms.PaintEventHandler(this.MenuLateral_Paint);
            // 
            // btnRelatorios
            // 
            this.btnRelatorios.Activecolor = System.Drawing.Color.White;
            this.btnRelatorios.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnRelatorios.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnRelatorios.BorderRadius = 0;
            this.btnRelatorios.ButtonText = "RELATÓRIOS";
            this.btnRelatorios.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tshow.SetDecoration(this.btnRelatorios, BunifuAnimatorNS.DecorationType.None);
            this.btnRelatorios.DisabledColor = System.Drawing.Color.Gray;
            this.btnRelatorios.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnRelatorios.Iconcolor = System.Drawing.Color.Transparent;
            this.btnRelatorios.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnRelatorios.Iconimage")));
            this.btnRelatorios.Iconimage_right = null;
            this.btnRelatorios.Iconimage_right_Selected = null;
            this.btnRelatorios.Iconimage_Selected = null;
            this.btnRelatorios.IconMarginLeft = 0;
            this.btnRelatorios.IconMarginRight = 0;
            this.btnRelatorios.IconRightVisible = true;
            this.btnRelatorios.IconRightZoom = 0D;
            this.btnRelatorios.IconVisible = true;
            this.btnRelatorios.IconZoom = 70D;
            this.btnRelatorios.IsTab = true;
            this.btnRelatorios.Location = new System.Drawing.Point(0, 787);
            this.btnRelatorios.Name = "btnRelatorios";
            this.btnRelatorios.Normalcolor = System.Drawing.Color.DodgerBlue;
            this.btnRelatorios.OnHovercolor = System.Drawing.Color.Cyan;
            this.btnRelatorios.OnHoverTextColor = System.Drawing.Color.Black;
            this.btnRelatorios.selected = false;
            this.btnRelatorios.Size = new System.Drawing.Size(180, 40);
            this.btnRelatorios.TabIndex = 10;
            this.btnRelatorios.Text = "RELATÓRIOS";
            this.btnRelatorios.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnRelatorios.Textcolor = System.Drawing.Color.Black;
            this.btnRelatorios.TextFont = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRelatorios.Click += new System.EventHandler(this.BunifuFlatButton10_Click);
            // 
            // btnAvisos
            // 
            this.btnAvisos.Activecolor = System.Drawing.Color.LightBlue;
            this.btnAvisos.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnAvisos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAvisos.BorderRadius = 0;
            this.btnAvisos.ButtonText = "AVISOS";
            this.btnAvisos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tshow.SetDecoration(this.btnAvisos, BunifuAnimatorNS.DecorationType.None);
            this.btnAvisos.DisabledColor = System.Drawing.Color.Gray;
            this.btnAvisos.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAvisos.Iconcolor = System.Drawing.Color.Transparent;
            this.btnAvisos.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnAvisos.Iconimage")));
            this.btnAvisos.Iconimage_right = null;
            this.btnAvisos.Iconimage_right_Selected = null;
            this.btnAvisos.Iconimage_Selected = null;
            this.btnAvisos.IconMarginLeft = 0;
            this.btnAvisos.IconMarginRight = 0;
            this.btnAvisos.IconRightVisible = true;
            this.btnAvisos.IconRightZoom = 0D;
            this.btnAvisos.IconVisible = true;
            this.btnAvisos.IconZoom = 60D;
            this.btnAvisos.IsTab = true;
            this.btnAvisos.Location = new System.Drawing.Point(0, 746);
            this.btnAvisos.Name = "btnAvisos";
            this.btnAvisos.Normalcolor = System.Drawing.Color.DodgerBlue;
            this.btnAvisos.OnHovercolor = System.Drawing.Color.Cyan;
            this.btnAvisos.OnHoverTextColor = System.Drawing.Color.Black;
            this.btnAvisos.selected = false;
            this.btnAvisos.Size = new System.Drawing.Size(180, 41);
            this.btnAvisos.TabIndex = 7;
            this.btnAvisos.Text = "AVISOS";
            this.btnAvisos.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnAvisos.Textcolor = System.Drawing.Color.Black;
            this.btnAvisos.TextFont = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAvisos.Click += new System.EventHandler(this.BtnAvisos_Click);
            // 
            // btnVeiculosDisponiveis
            // 
            this.btnVeiculosDisponiveis.Activecolor = System.Drawing.Color.LightBlue;
            this.btnVeiculosDisponiveis.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnVeiculosDisponiveis.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnVeiculosDisponiveis.BorderRadius = 0;
            this.btnVeiculosDisponiveis.ButtonText = "VEÍCULOS DISPONIVEL";
            this.btnVeiculosDisponiveis.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tshow.SetDecoration(this.btnVeiculosDisponiveis, BunifuAnimatorNS.DecorationType.None);
            this.btnVeiculosDisponiveis.DisabledColor = System.Drawing.Color.Gray;
            this.btnVeiculosDisponiveis.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnVeiculosDisponiveis.Iconcolor = System.Drawing.Color.Transparent;
            this.btnVeiculosDisponiveis.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnVeiculosDisponiveis.Iconimage")));
            this.btnVeiculosDisponiveis.Iconimage_right = null;
            this.btnVeiculosDisponiveis.Iconimage_right_Selected = null;
            this.btnVeiculosDisponiveis.Iconimage_Selected = null;
            this.btnVeiculosDisponiveis.IconMarginLeft = 0;
            this.btnVeiculosDisponiveis.IconMarginRight = 0;
            this.btnVeiculosDisponiveis.IconRightVisible = true;
            this.btnVeiculosDisponiveis.IconRightZoom = 0D;
            this.btnVeiculosDisponiveis.IconVisible = true;
            this.btnVeiculosDisponiveis.IconZoom = 70D;
            this.btnVeiculosDisponiveis.IsTab = true;
            this.btnVeiculosDisponiveis.Location = new System.Drawing.Point(0, 706);
            this.btnVeiculosDisponiveis.Name = "btnVeiculosDisponiveis";
            this.btnVeiculosDisponiveis.Normalcolor = System.Drawing.Color.DodgerBlue;
            this.btnVeiculosDisponiveis.OnHovercolor = System.Drawing.Color.Cyan;
            this.btnVeiculosDisponiveis.OnHoverTextColor = System.Drawing.Color.Black;
            this.btnVeiculosDisponiveis.selected = false;
            this.btnVeiculosDisponiveis.Size = new System.Drawing.Size(180, 40);
            this.btnVeiculosDisponiveis.TabIndex = 6;
            this.btnVeiculosDisponiveis.Text = "VEÍCULOS DISPONIVEL";
            this.btnVeiculosDisponiveis.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnVeiculosDisponiveis.Textcolor = System.Drawing.Color.Black;
            this.btnVeiculosDisponiveis.TextFont = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVeiculosDisponiveis.Click += new System.EventHandler(this.BtnVeiculosDisponiveis_Click);
            // 
            // panelFinanceiroSubMenu
            // 
            this.panelFinanceiroSubMenu.BackColor = System.Drawing.Color.SlateGray;
            this.panelFinanceiroSubMenu.Controls.Add(this.btnContasPagar);
            this.panelFinanceiroSubMenu.Controls.Add(this.btnContasReceber);
            this.tshow.SetDecoration(this.panelFinanceiroSubMenu, BunifuAnimatorNS.DecorationType.None);
            this.panelFinanceiroSubMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelFinanceiroSubMenu.Location = new System.Drawing.Point(0, 632);
            this.panelFinanceiroSubMenu.Name = "panelFinanceiroSubMenu";
            this.panelFinanceiroSubMenu.Size = new System.Drawing.Size(180, 74);
            this.panelFinanceiroSubMenu.TabIndex = 15;
            // 
            // btnContasPagar
            // 
            this.btnContasPagar.Activecolor = System.Drawing.Color.SteelBlue;
            this.btnContasPagar.BackColor = System.Drawing.Color.SlateGray;
            this.btnContasPagar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnContasPagar.BorderRadius = 0;
            this.btnContasPagar.ButtonText = "CONTAS A PAGAR";
            this.btnContasPagar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tshow.SetDecoration(this.btnContasPagar, BunifuAnimatorNS.DecorationType.None);
            this.btnContasPagar.DisabledColor = System.Drawing.Color.Gray;
            this.btnContasPagar.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnContasPagar.Iconcolor = System.Drawing.Color.Transparent;
            this.btnContasPagar.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnContasPagar.Iconimage")));
            this.btnContasPagar.Iconimage_right = null;
            this.btnContasPagar.Iconimage_right_Selected = null;
            this.btnContasPagar.Iconimage_Selected = null;
            this.btnContasPagar.IconMarginLeft = 0;
            this.btnContasPagar.IconMarginRight = 0;
            this.btnContasPagar.IconRightVisible = true;
            this.btnContasPagar.IconRightZoom = 0D;
            this.btnContasPagar.IconVisible = true;
            this.btnContasPagar.IconZoom = 70D;
            this.btnContasPagar.IsTab = true;
            this.btnContasPagar.Location = new System.Drawing.Point(0, 40);
            this.btnContasPagar.Name = "btnContasPagar";
            this.btnContasPagar.Normalcolor = System.Drawing.Color.SlateGray;
            this.btnContasPagar.OnHovercolor = System.Drawing.Color.Cyan;
            this.btnContasPagar.OnHoverTextColor = System.Drawing.Color.Black;
            this.btnContasPagar.selected = false;
            this.btnContasPagar.Size = new System.Drawing.Size(180, 37);
            this.btnContasPagar.TabIndex = 16;
            this.btnContasPagar.Text = "CONTAS A PAGAR";
            this.btnContasPagar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnContasPagar.Textcolor = System.Drawing.Color.Black;
            this.btnContasPagar.TextFont = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnContasPagar.Click += new System.EventHandler(this.BtnContasPagar_Click);
            // 
            // btnContasReceber
            // 
            this.btnContasReceber.Activecolor = System.Drawing.Color.SteelBlue;
            this.btnContasReceber.BackColor = System.Drawing.Color.SlateGray;
            this.btnContasReceber.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnContasReceber.BorderRadius = 0;
            this.btnContasReceber.ButtonText = "CONTAS A RECEBER";
            this.btnContasReceber.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tshow.SetDecoration(this.btnContasReceber, BunifuAnimatorNS.DecorationType.None);
            this.btnContasReceber.DisabledColor = System.Drawing.Color.Gray;
            this.btnContasReceber.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnContasReceber.Iconcolor = System.Drawing.Color.Transparent;
            this.btnContasReceber.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnContasReceber.Iconimage")));
            this.btnContasReceber.Iconimage_right = null;
            this.btnContasReceber.Iconimage_right_Selected = null;
            this.btnContasReceber.Iconimage_Selected = null;
            this.btnContasReceber.IconMarginLeft = 0;
            this.btnContasReceber.IconMarginRight = 0;
            this.btnContasReceber.IconRightVisible = true;
            this.btnContasReceber.IconRightZoom = 0D;
            this.btnContasReceber.IconVisible = true;
            this.btnContasReceber.IconZoom = 70D;
            this.btnContasReceber.IsTab = true;
            this.btnContasReceber.Location = new System.Drawing.Point(0, 0);
            this.btnContasReceber.Name = "btnContasReceber";
            this.btnContasReceber.Normalcolor = System.Drawing.Color.SlateGray;
            this.btnContasReceber.OnHovercolor = System.Drawing.Color.Cyan;
            this.btnContasReceber.OnHoverTextColor = System.Drawing.Color.Black;
            this.btnContasReceber.selected = false;
            this.btnContasReceber.Size = new System.Drawing.Size(180, 40);
            this.btnContasReceber.TabIndex = 15;
            this.btnContasReceber.Text = "CONTAS A RECEBER";
            this.btnContasReceber.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnContasReceber.Textcolor = System.Drawing.Color.Black;
            this.btnContasReceber.TextFont = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnContasReceber.Click += new System.EventHandler(this.BtnContasReceber_Click);
            // 
            // btnFinanceiro
            // 
            this.btnFinanceiro.Activecolor = System.Drawing.Color.LightBlue;
            this.btnFinanceiro.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnFinanceiro.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnFinanceiro.BorderRadius = 0;
            this.btnFinanceiro.ButtonText = "FINANCEIRO";
            this.btnFinanceiro.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tshow.SetDecoration(this.btnFinanceiro, BunifuAnimatorNS.DecorationType.None);
            this.btnFinanceiro.DisabledColor = System.Drawing.Color.Gray;
            this.btnFinanceiro.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnFinanceiro.Iconcolor = System.Drawing.Color.Transparent;
            this.btnFinanceiro.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnFinanceiro.Iconimage")));
            this.btnFinanceiro.Iconimage_right = null;
            this.btnFinanceiro.Iconimage_right_Selected = null;
            this.btnFinanceiro.Iconimage_Selected = null;
            this.btnFinanceiro.IconMarginLeft = 0;
            this.btnFinanceiro.IconMarginRight = 0;
            this.btnFinanceiro.IconRightVisible = true;
            this.btnFinanceiro.IconRightZoom = 0D;
            this.btnFinanceiro.IconVisible = true;
            this.btnFinanceiro.IconZoom = 60D;
            this.btnFinanceiro.IsTab = true;
            this.btnFinanceiro.Location = new System.Drawing.Point(0, 592);
            this.btnFinanceiro.Name = "btnFinanceiro";
            this.btnFinanceiro.Normalcolor = System.Drawing.Color.DodgerBlue;
            this.btnFinanceiro.OnHovercolor = System.Drawing.Color.Cyan;
            this.btnFinanceiro.OnHoverTextColor = System.Drawing.Color.Black;
            this.btnFinanceiro.selected = false;
            this.btnFinanceiro.Size = new System.Drawing.Size(180, 40);
            this.btnFinanceiro.TabIndex = 3;
            this.btnFinanceiro.Text = "FINANCEIRO";
            this.btnFinanceiro.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnFinanceiro.Textcolor = System.Drawing.Color.Black;
            this.btnFinanceiro.TextFont = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFinanceiro.Click += new System.EventHandler(this.BtnFinanceiro_Click);
            // 
            // btnManutencao
            // 
            this.btnManutencao.Activecolor = System.Drawing.Color.LightBlue;
            this.btnManutencao.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnManutencao.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnManutencao.BorderRadius = 0;
            this.btnManutencao.ButtonText = "   MANUTENÇÃO";
            this.btnManutencao.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tshow.SetDecoration(this.btnManutencao, BunifuAnimatorNS.DecorationType.None);
            this.btnManutencao.DisabledColor = System.Drawing.Color.Gray;
            this.btnManutencao.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnManutencao.Iconcolor = System.Drawing.Color.Transparent;
            this.btnManutencao.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnManutencao.Iconimage")));
            this.btnManutencao.Iconimage_right = null;
            this.btnManutencao.Iconimage_right_Selected = null;
            this.btnManutencao.Iconimage_Selected = null;
            this.btnManutencao.IconMarginLeft = 0;
            this.btnManutencao.IconMarginRight = 0;
            this.btnManutencao.IconRightVisible = true;
            this.btnManutencao.IconRightZoom = 0D;
            this.btnManutencao.IconVisible = true;
            this.btnManutencao.IconZoom = 60D;
            this.btnManutencao.IsTab = true;
            this.btnManutencao.Location = new System.Drawing.Point(0, 552);
            this.btnManutencao.Name = "btnManutencao";
            this.btnManutencao.Normalcolor = System.Drawing.Color.DodgerBlue;
            this.btnManutencao.OnHovercolor = System.Drawing.Color.Cyan;
            this.btnManutencao.OnHoverTextColor = System.Drawing.Color.Black;
            this.btnManutencao.selected = false;
            this.btnManutencao.Size = new System.Drawing.Size(180, 40);
            this.btnManutencao.TabIndex = 5;
            this.btnManutencao.Text = "   MANUTENÇÃO";
            this.btnManutencao.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnManutencao.Textcolor = System.Drawing.Color.Black;
            this.btnManutencao.TextFont = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnManutencao.Click += new System.EventHandler(this.BtnManutencao_Click);
            // 
            // btnMultas
            // 
            this.btnMultas.Activecolor = System.Drawing.Color.LightBlue;
            this.btnMultas.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnMultas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnMultas.BorderRadius = 0;
            this.btnMultas.ButtonText = "MULTAS";
            this.btnMultas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tshow.SetDecoration(this.btnMultas, BunifuAnimatorNS.DecorationType.None);
            this.btnMultas.DisabledColor = System.Drawing.Color.Gray;
            this.btnMultas.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnMultas.Iconcolor = System.Drawing.Color.Transparent;
            this.btnMultas.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnMultas.Iconimage")));
            this.btnMultas.Iconimage_right = null;
            this.btnMultas.Iconimage_right_Selected = null;
            this.btnMultas.Iconimage_Selected = null;
            this.btnMultas.IconMarginLeft = 0;
            this.btnMultas.IconMarginRight = 0;
            this.btnMultas.IconRightVisible = true;
            this.btnMultas.IconRightZoom = 0D;
            this.btnMultas.IconVisible = true;
            this.btnMultas.IconZoom = 70D;
            this.btnMultas.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnMultas.IsTab = true;
            this.btnMultas.Location = new System.Drawing.Point(0, 512);
            this.btnMultas.Name = "btnMultas";
            this.btnMultas.Normalcolor = System.Drawing.Color.DodgerBlue;
            this.btnMultas.OnHovercolor = System.Drawing.Color.Cyan;
            this.btnMultas.OnHoverTextColor = System.Drawing.Color.Black;
            this.btnMultas.selected = false;
            this.btnMultas.Size = new System.Drawing.Size(180, 40);
            this.btnMultas.TabIndex = 8;
            this.btnMultas.Text = "MULTAS";
            this.btnMultas.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnMultas.Textcolor = System.Drawing.Color.Black;
            this.btnMultas.TextFont = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMultas.Click += new System.EventHandler(this.BtnMultas_Click);
            // 
            // btnLocacao
            // 
            this.btnLocacao.Activecolor = System.Drawing.Color.LightBlue;
            this.btnLocacao.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnLocacao.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnLocacao.BorderRadius = 0;
            this.btnLocacao.ButtonText = "LOCAÇÃO";
            this.btnLocacao.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tshow.SetDecoration(this.btnLocacao, BunifuAnimatorNS.DecorationType.None);
            this.btnLocacao.DisabledColor = System.Drawing.Color.Gray;
            this.btnLocacao.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnLocacao.Iconcolor = System.Drawing.Color.Transparent;
            this.btnLocacao.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnLocacao.Iconimage")));
            this.btnLocacao.Iconimage_right = null;
            this.btnLocacao.Iconimage_right_Selected = null;
            this.btnLocacao.Iconimage_Selected = null;
            this.btnLocacao.IconMarginLeft = 0;
            this.btnLocacao.IconMarginRight = 0;
            this.btnLocacao.IconRightVisible = true;
            this.btnLocacao.IconRightZoom = 0D;
            this.btnLocacao.IconVisible = true;
            this.btnLocacao.IconZoom = 70D;
            this.btnLocacao.IsTab = true;
            this.btnLocacao.Location = new System.Drawing.Point(0, 472);
            this.btnLocacao.Name = "btnLocacao";
            this.btnLocacao.Normalcolor = System.Drawing.Color.DodgerBlue;
            this.btnLocacao.OnHovercolor = System.Drawing.Color.Cyan;
            this.btnLocacao.OnHoverTextColor = System.Drawing.Color.Black;
            this.btnLocacao.selected = false;
            this.btnLocacao.Size = new System.Drawing.Size(180, 40);
            this.btnLocacao.TabIndex = 9;
            this.btnLocacao.Text = "LOCAÇÃO";
            this.btnLocacao.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnLocacao.Textcolor = System.Drawing.Color.Black;
            this.btnLocacao.TextFont = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLocacao.Click += new System.EventHandler(this.BtnLocacao_Click);
            // 
            // btnCliente
            // 
            this.btnCliente.Activecolor = System.Drawing.Color.LightBlue;
            this.btnCliente.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnCliente.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCliente.BorderRadius = 0;
            this.btnCliente.ButtonText = "CLIENTES";
            this.btnCliente.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tshow.SetDecoration(this.btnCliente, BunifuAnimatorNS.DecorationType.None);
            this.btnCliente.DisabledColor = System.Drawing.Color.Gray;
            this.btnCliente.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCliente.Iconcolor = System.Drawing.Color.Transparent;
            this.btnCliente.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnCliente.Iconimage")));
            this.btnCliente.Iconimage_right = null;
            this.btnCliente.Iconimage_right_Selected = null;
            this.btnCliente.Iconimage_Selected = null;
            this.btnCliente.IconMarginLeft = 0;
            this.btnCliente.IconMarginRight = 0;
            this.btnCliente.IconRightVisible = true;
            this.btnCliente.IconRightZoom = 0D;
            this.btnCliente.IconVisible = true;
            this.btnCliente.IconZoom = 70D;
            this.btnCliente.IsTab = true;
            this.btnCliente.Location = new System.Drawing.Point(0, 432);
            this.btnCliente.Name = "btnCliente";
            this.btnCliente.Normalcolor = System.Drawing.Color.DodgerBlue;
            this.btnCliente.OnHovercolor = System.Drawing.Color.Cyan;
            this.btnCliente.OnHoverTextColor = System.Drawing.Color.Black;
            this.btnCliente.selected = false;
            this.btnCliente.Size = new System.Drawing.Size(180, 40);
            this.btnCliente.TabIndex = 11;
            this.btnCliente.Text = "CLIENTES";
            this.btnCliente.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnCliente.Textcolor = System.Drawing.Color.Black;
            this.btnCliente.TextFont = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCliente.Click += new System.EventHandler(this.BtnCliente_Click);
            // 
            // panelViagenSubMenu
            // 
            this.panelViagenSubMenu.BackColor = System.Drawing.Color.SlateGray;
            this.panelViagenSubMenu.Controls.Add(this.btnAbastecimento);
            this.tshow.SetDecoration(this.panelViagenSubMenu, BunifuAnimatorNS.DecorationType.None);
            this.panelViagenSubMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelViagenSubMenu.Location = new System.Drawing.Point(0, 392);
            this.panelViagenSubMenu.Name = "panelViagenSubMenu";
            this.panelViagenSubMenu.Size = new System.Drawing.Size(180, 40);
            this.panelViagenSubMenu.TabIndex = 14;
            // 
            // btnAbastecimento
            // 
            this.btnAbastecimento.Activecolor = System.Drawing.Color.SteelBlue;
            this.btnAbastecimento.BackColor = System.Drawing.Color.SlateGray;
            this.btnAbastecimento.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAbastecimento.BorderRadius = 0;
            this.btnAbastecimento.ButtonText = "ABASTECIMENTO";
            this.btnAbastecimento.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tshow.SetDecoration(this.btnAbastecimento, BunifuAnimatorNS.DecorationType.None);
            this.btnAbastecimento.DisabledColor = System.Drawing.Color.Gray;
            this.btnAbastecimento.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAbastecimento.Iconcolor = System.Drawing.Color.Transparent;
            this.btnAbastecimento.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnAbastecimento.Iconimage")));
            this.btnAbastecimento.Iconimage_right = null;
            this.btnAbastecimento.Iconimage_right_Selected = null;
            this.btnAbastecimento.Iconimage_Selected = null;
            this.btnAbastecimento.IconMarginLeft = 0;
            this.btnAbastecimento.IconMarginRight = 0;
            this.btnAbastecimento.IconRightVisible = true;
            this.btnAbastecimento.IconRightZoom = 0D;
            this.btnAbastecimento.IconVisible = true;
            this.btnAbastecimento.IconZoom = 70D;
            this.btnAbastecimento.IsTab = true;
            this.btnAbastecimento.Location = new System.Drawing.Point(0, 0);
            this.btnAbastecimento.Name = "btnAbastecimento";
            this.btnAbastecimento.Normalcolor = System.Drawing.Color.SlateGray;
            this.btnAbastecimento.OnHovercolor = System.Drawing.Color.Cyan;
            this.btnAbastecimento.OnHoverTextColor = System.Drawing.Color.Black;
            this.btnAbastecimento.selected = false;
            this.btnAbastecimento.Size = new System.Drawing.Size(180, 40);
            this.btnAbastecimento.TabIndex = 14;
            this.btnAbastecimento.Text = "ABASTECIMENTO";
            this.btnAbastecimento.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnAbastecimento.Textcolor = System.Drawing.Color.Black;
            this.btnAbastecimento.TextFont = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAbastecimento.Click += new System.EventHandler(this.BtnAbastecimento_Click);
            // 
            // btnViagens
            // 
            this.btnViagens.Activecolor = System.Drawing.Color.LightBlue;
            this.btnViagens.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnViagens.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnViagens.BorderRadius = 0;
            this.btnViagens.ButtonText = "VIAGENS";
            this.btnViagens.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tshow.SetDecoration(this.btnViagens, BunifuAnimatorNS.DecorationType.None);
            this.btnViagens.DisabledColor = System.Drawing.Color.Gray;
            this.btnViagens.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnViagens.Iconcolor = System.Drawing.Color.Transparent;
            this.btnViagens.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnViagens.Iconimage")));
            this.btnViagens.Iconimage_right = null;
            this.btnViagens.Iconimage_right_Selected = null;
            this.btnViagens.Iconimage_Selected = null;
            this.btnViagens.IconMarginLeft = 0;
            this.btnViagens.IconMarginRight = 0;
            this.btnViagens.IconRightVisible = true;
            this.btnViagens.IconRightZoom = 0D;
            this.btnViagens.IconVisible = true;
            this.btnViagens.IconZoom = 70D;
            this.btnViagens.IsTab = true;
            this.btnViagens.Location = new System.Drawing.Point(0, 352);
            this.btnViagens.Name = "btnViagens";
            this.btnViagens.Normalcolor = System.Drawing.Color.DodgerBlue;
            this.btnViagens.OnHovercolor = System.Drawing.Color.Cyan;
            this.btnViagens.OnHoverTextColor = System.Drawing.Color.Black;
            this.btnViagens.selected = false;
            this.btnViagens.Size = new System.Drawing.Size(180, 40);
            this.btnViagens.TabIndex = 4;
            this.btnViagens.Text = "VIAGENS";
            this.btnViagens.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnViagens.Textcolor = System.Drawing.Color.Black;
            this.btnViagens.TextFont = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViagens.Click += new System.EventHandler(this.BtnViagens_Click);
            // 
            // panelVeiculoSubMenu
            // 
            this.panelVeiculoSubMenu.BackColor = System.Drawing.Color.SlateGray;
            this.panelVeiculoSubMenu.Controls.Add(this.btnSinistro);
            this.panelVeiculoSubMenu.Controls.Add(this.btnSeguroVeiculo);
            this.panelVeiculoSubMenu.Controls.Add(this.btnCompraVenda);
            this.tshow.SetDecoration(this.panelVeiculoSubMenu, BunifuAnimatorNS.DecorationType.None);
            this.panelVeiculoSubMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelVeiculoSubMenu.Location = new System.Drawing.Point(0, 230);
            this.panelVeiculoSubMenu.Name = "panelVeiculoSubMenu";
            this.panelVeiculoSubMenu.Size = new System.Drawing.Size(180, 122);
            this.panelVeiculoSubMenu.TabIndex = 0;
            // 
            // btnSinistro
            // 
            this.btnSinistro.Activecolor = System.Drawing.Color.SteelBlue;
            this.btnSinistro.BackColor = System.Drawing.Color.SlateGray;
            this.btnSinistro.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSinistro.BorderRadius = 0;
            this.btnSinistro.ButtonText = "SINISTROS";
            this.btnSinistro.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tshow.SetDecoration(this.btnSinistro, BunifuAnimatorNS.DecorationType.None);
            this.btnSinistro.DisabledColor = System.Drawing.Color.Gray;
            this.btnSinistro.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSinistro.Iconcolor = System.Drawing.Color.Transparent;
            this.btnSinistro.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnSinistro.Iconimage")));
            this.btnSinistro.Iconimage_right = null;
            this.btnSinistro.Iconimage_right_Selected = null;
            this.btnSinistro.Iconimage_Selected = null;
            this.btnSinistro.IconMarginLeft = 0;
            this.btnSinistro.IconMarginRight = 0;
            this.btnSinistro.IconRightVisible = true;
            this.btnSinistro.IconRightZoom = 0D;
            this.btnSinistro.IconVisible = true;
            this.btnSinistro.IconZoom = 70D;
            this.btnSinistro.IsTab = true;
            this.btnSinistro.Location = new System.Drawing.Point(0, 80);
            this.btnSinistro.Name = "btnSinistro";
            this.btnSinistro.Normalcolor = System.Drawing.Color.SlateGray;
            this.btnSinistro.OnHovercolor = System.Drawing.Color.Cyan;
            this.btnSinistro.OnHoverTextColor = System.Drawing.Color.Black;
            this.btnSinistro.selected = false;
            this.btnSinistro.Size = new System.Drawing.Size(180, 42);
            this.btnSinistro.TabIndex = 14;
            this.btnSinistro.Text = "SINISTROS";
            this.btnSinistro.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnSinistro.Textcolor = System.Drawing.Color.Black;
            this.btnSinistro.TextFont = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSinistro.Click += new System.EventHandler(this.BtnSinistro_Click);
            // 
            // btnSeguroVeiculo
            // 
            this.btnSeguroVeiculo.Activecolor = System.Drawing.Color.SteelBlue;
            this.btnSeguroVeiculo.BackColor = System.Drawing.Color.SlateGray;
            this.btnSeguroVeiculo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSeguroVeiculo.BorderRadius = 0;
            this.btnSeguroVeiculo.ButtonText = "SEGURO VEÍCULO";
            this.btnSeguroVeiculo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tshow.SetDecoration(this.btnSeguroVeiculo, BunifuAnimatorNS.DecorationType.None);
            this.btnSeguroVeiculo.DisabledColor = System.Drawing.Color.Gray;
            this.btnSeguroVeiculo.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSeguroVeiculo.Iconcolor = System.Drawing.Color.Transparent;
            this.btnSeguroVeiculo.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnSeguroVeiculo.Iconimage")));
            this.btnSeguroVeiculo.Iconimage_right = null;
            this.btnSeguroVeiculo.Iconimage_right_Selected = null;
            this.btnSeguroVeiculo.Iconimage_Selected = null;
            this.btnSeguroVeiculo.IconMarginLeft = 0;
            this.btnSeguroVeiculo.IconMarginRight = 0;
            this.btnSeguroVeiculo.IconRightVisible = true;
            this.btnSeguroVeiculo.IconRightZoom = 0D;
            this.btnSeguroVeiculo.IconVisible = true;
            this.btnSeguroVeiculo.IconZoom = 70D;
            this.btnSeguroVeiculo.IsTab = true;
            this.btnSeguroVeiculo.Location = new System.Drawing.Point(0, 40);
            this.btnSeguroVeiculo.Name = "btnSeguroVeiculo";
            this.btnSeguroVeiculo.Normalcolor = System.Drawing.Color.SlateGray;
            this.btnSeguroVeiculo.OnHovercolor = System.Drawing.Color.Cyan;
            this.btnSeguroVeiculo.OnHoverTextColor = System.Drawing.Color.Black;
            this.btnSeguroVeiculo.selected = false;
            this.btnSeguroVeiculo.Size = new System.Drawing.Size(180, 40);
            this.btnSeguroVeiculo.TabIndex = 13;
            this.btnSeguroVeiculo.Text = "SEGURO VEÍCULO";
            this.btnSeguroVeiculo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnSeguroVeiculo.Textcolor = System.Drawing.Color.Black;
            this.btnSeguroVeiculo.TextFont = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSeguroVeiculo.Click += new System.EventHandler(this.bunifuFlatButton2_Click);
            // 
            // btnCompraVenda
            // 
            this.btnCompraVenda.Activecolor = System.Drawing.Color.SteelBlue;
            this.btnCompraVenda.BackColor = System.Drawing.Color.SlateGray;
            this.btnCompraVenda.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCompraVenda.BorderRadius = 0;
            this.btnCompraVenda.ButtonText = "COMPRA/ VENDA";
            this.btnCompraVenda.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tshow.SetDecoration(this.btnCompraVenda, BunifuAnimatorNS.DecorationType.None);
            this.btnCompraVenda.DisabledColor = System.Drawing.Color.Gray;
            this.btnCompraVenda.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCompraVenda.Iconcolor = System.Drawing.Color.Transparent;
            this.btnCompraVenda.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnCompraVenda.Iconimage")));
            this.btnCompraVenda.Iconimage_right = null;
            this.btnCompraVenda.Iconimage_right_Selected = null;
            this.btnCompraVenda.Iconimage_Selected = null;
            this.btnCompraVenda.IconMarginLeft = 0;
            this.btnCompraVenda.IconMarginRight = 0;
            this.btnCompraVenda.IconRightVisible = true;
            this.btnCompraVenda.IconRightZoom = 0D;
            this.btnCompraVenda.IconVisible = true;
            this.btnCompraVenda.IconZoom = 70D;
            this.btnCompraVenda.IsTab = true;
            this.btnCompraVenda.Location = new System.Drawing.Point(0, 0);
            this.btnCompraVenda.Name = "btnCompraVenda";
            this.btnCompraVenda.Normalcolor = System.Drawing.Color.SlateGray;
            this.btnCompraVenda.OnHovercolor = System.Drawing.Color.Cyan;
            this.btnCompraVenda.OnHoverTextColor = System.Drawing.Color.Black;
            this.btnCompraVenda.selected = false;
            this.btnCompraVenda.Size = new System.Drawing.Size(180, 40);
            this.btnCompraVenda.TabIndex = 12;
            this.btnCompraVenda.Text = "COMPRA/ VENDA";
            this.btnCompraVenda.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnCompraVenda.Textcolor = System.Drawing.Color.Black;
            this.btnCompraVenda.TextFont = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCompraVenda.Click += new System.EventHandler(this.bunifuFlatButton1_Click);
            // 
            // btnVeiculos
            // 
            this.btnVeiculos.Activecolor = System.Drawing.Color.LightBlue;
            this.btnVeiculos.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnVeiculos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnVeiculos.BorderRadius = 0;
            this.btnVeiculos.ButtonText = "VEÍCULOS";
            this.btnVeiculos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tshow.SetDecoration(this.btnVeiculos, BunifuAnimatorNS.DecorationType.None);
            this.btnVeiculos.DisabledColor = System.Drawing.Color.Gray;
            this.btnVeiculos.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnVeiculos.Iconcolor = System.Drawing.Color.Transparent;
            this.btnVeiculos.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnVeiculos.Iconimage")));
            this.btnVeiculos.Iconimage_right = null;
            this.btnVeiculos.Iconimage_right_Selected = null;
            this.btnVeiculos.Iconimage_Selected = null;
            this.btnVeiculos.IconMarginLeft = 0;
            this.btnVeiculos.IconMarginRight = 0;
            this.btnVeiculos.IconRightVisible = true;
            this.btnVeiculos.IconRightZoom = 0D;
            this.btnVeiculos.IconVisible = true;
            this.btnVeiculos.IconZoom = 70D;
            this.btnVeiculos.IsTab = true;
            this.btnVeiculos.Location = new System.Drawing.Point(0, 190);
            this.btnVeiculos.Name = "btnVeiculos";
            this.btnVeiculos.Normalcolor = System.Drawing.Color.DodgerBlue;
            this.btnVeiculos.OnHovercolor = System.Drawing.Color.Cyan;
            this.btnVeiculos.OnHoverTextColor = System.Drawing.Color.Black;
            this.btnVeiculos.selected = false;
            this.btnVeiculos.Size = new System.Drawing.Size(180, 40);
            this.btnVeiculos.TabIndex = 2;
            this.btnVeiculos.Text = "VEÍCULOS";
            this.btnVeiculos.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnVeiculos.Textcolor = System.Drawing.Color.Black;
            this.btnVeiculos.TextFont = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVeiculos.Click += new System.EventHandler(this.BtnVeiculos_Click);
            // 
            // panelMotoristaSubMenu
            // 
            this.panelMotoristaSubMenu.BackColor = System.Drawing.Color.SlateGray;
            this.panelMotoristaSubMenu.Controls.Add(this.btnSeguroMotorista);
            this.tshow.SetDecoration(this.panelMotoristaSubMenu, BunifuAnimatorNS.DecorationType.None);
            this.panelMotoristaSubMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelMotoristaSubMenu.Location = new System.Drawing.Point(0, 149);
            this.panelMotoristaSubMenu.Name = "panelMotoristaSubMenu";
            this.panelMotoristaSubMenu.Size = new System.Drawing.Size(180, 41);
            this.panelMotoristaSubMenu.TabIndex = 13;
            // 
            // btnSeguroMotorista
            // 
            this.btnSeguroMotorista.Activecolor = System.Drawing.Color.SteelBlue;
            this.btnSeguroMotorista.BackColor = System.Drawing.Color.SlateGray;
            this.btnSeguroMotorista.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSeguroMotorista.BorderRadius = 0;
            this.btnSeguroMotorista.ButtonText = "SEGURO MOTORISTA";
            this.btnSeguroMotorista.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tshow.SetDecoration(this.btnSeguroMotorista, BunifuAnimatorNS.DecorationType.None);
            this.btnSeguroMotorista.DisabledColor = System.Drawing.Color.Gray;
            this.btnSeguroMotorista.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSeguroMotorista.Iconcolor = System.Drawing.Color.Transparent;
            this.btnSeguroMotorista.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnSeguroMotorista.Iconimage")));
            this.btnSeguroMotorista.Iconimage_right = null;
            this.btnSeguroMotorista.Iconimage_right_Selected = null;
            this.btnSeguroMotorista.Iconimage_Selected = null;
            this.btnSeguroMotorista.IconMarginLeft = 0;
            this.btnSeguroMotorista.IconMarginRight = 0;
            this.btnSeguroMotorista.IconRightVisible = true;
            this.btnSeguroMotorista.IconRightZoom = 0D;
            this.btnSeguroMotorista.IconVisible = true;
            this.btnSeguroMotorista.IconZoom = 100D;
            this.btnSeguroMotorista.IsTab = true;
            this.btnSeguroMotorista.Location = new System.Drawing.Point(0, 0);
            this.btnSeguroMotorista.Name = "btnSeguroMotorista";
            this.btnSeguroMotorista.Normalcolor = System.Drawing.Color.SlateGray;
            this.btnSeguroMotorista.OnHovercolor = System.Drawing.Color.Cyan;
            this.btnSeguroMotorista.OnHoverTextColor = System.Drawing.Color.Black;
            this.btnSeguroMotorista.selected = false;
            this.btnSeguroMotorista.Size = new System.Drawing.Size(180, 40);
            this.btnSeguroMotorista.TabIndex = 14;
            this.btnSeguroMotorista.Text = "SEGURO MOTORISTA";
            this.btnSeguroMotorista.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnSeguroMotorista.Textcolor = System.Drawing.Color.Black;
            this.btnSeguroMotorista.TextFont = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSeguroMotorista.Click += new System.EventHandler(this.BtnSeguroMotorista_Click);
            // 
            // btnMotorista
            // 
            this.btnMotorista.Activecolor = System.Drawing.Color.LightBlue;
            this.btnMotorista.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnMotorista.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnMotorista.BorderRadius = 0;
            this.btnMotorista.ButtonText = "MOTORISTAS";
            this.btnMotorista.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tshow.SetDecoration(this.btnMotorista, BunifuAnimatorNS.DecorationType.None);
            this.btnMotorista.DisabledColor = System.Drawing.Color.DimGray;
            this.btnMotorista.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnMotorista.Iconcolor = System.Drawing.Color.Transparent;
            this.btnMotorista.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnMotorista.Iconimage")));
            this.btnMotorista.Iconimage_right = null;
            this.btnMotorista.Iconimage_right_Selected = null;
            this.btnMotorista.Iconimage_Selected = null;
            this.btnMotorista.IconMarginLeft = 0;
            this.btnMotorista.IconMarginRight = 0;
            this.btnMotorista.IconRightVisible = true;
            this.btnMotorista.IconRightZoom = 0D;
            this.btnMotorista.IconVisible = true;
            this.btnMotorista.IconZoom = 60D;
            this.btnMotorista.IsTab = true;
            this.btnMotorista.Location = new System.Drawing.Point(0, 109);
            this.btnMotorista.Name = "btnMotorista";
            this.btnMotorista.Normalcolor = System.Drawing.Color.DodgerBlue;
            this.btnMotorista.OnHovercolor = System.Drawing.Color.Cyan;
            this.btnMotorista.OnHoverTextColor = System.Drawing.Color.Black;
            this.btnMotorista.selected = false;
            this.btnMotorista.Size = new System.Drawing.Size(180, 40);
            this.btnMotorista.TabIndex = 1;
            this.btnMotorista.Text = "MOTORISTAS";
            this.btnMotorista.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnMotorista.Textcolor = System.Drawing.Color.Black;
            this.btnMotorista.TextFont = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMotorista.Click += new System.EventHandler(this.BtnMotorista_Click);
            // 
            // LOGO
            // 
            this.LOGO.BackColor = System.Drawing.Color.White;
            this.tshow.SetDecoration(this.LOGO, BunifuAnimatorNS.DecorationType.None);
            this.LOGO.Dock = System.Windows.Forms.DockStyle.Top;
            this.LOGO.Image = ((System.Drawing.Image)(resources.GetObject("LOGO.Image")));
            this.LOGO.Location = new System.Drawing.Point(0, 0);
            this.LOGO.Name = "LOGO";
            this.LOGO.Size = new System.Drawing.Size(180, 109);
            this.LOGO.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.LOGO.TabIndex = 0;
            this.LOGO.TabStop = false;
            // 
            // bunifuFlatButton4
            // 
            this.bunifuFlatButton4.Activecolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton4.BackColor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton4.BorderRadius = 0;
            this.bunifuFlatButton4.ButtonText = "";
            this.bunifuFlatButton4.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.tshow.SetDecoration(this.bunifuFlatButton4, BunifuAnimatorNS.DecorationType.None);
            this.bunifuFlatButton4.DisabledColor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton4.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton4.Iconimage = null;
            this.bunifuFlatButton4.Iconimage_right = null;
            this.bunifuFlatButton4.Iconimage_right_Selected = null;
            this.bunifuFlatButton4.Iconimage_Selected = null;
            this.bunifuFlatButton4.IconMarginLeft = 0;
            this.bunifuFlatButton4.IconMarginRight = 0;
            this.bunifuFlatButton4.IconRightVisible = true;
            this.bunifuFlatButton4.IconRightZoom = 0D;
            this.bunifuFlatButton4.IconVisible = true;
            this.bunifuFlatButton4.IconZoom = 70D;
            this.bunifuFlatButton4.IsTab = true;
            this.bunifuFlatButton4.Location = new System.Drawing.Point(3, 778);
            this.bunifuFlatButton4.Name = "bunifuFlatButton4";
            this.bunifuFlatButton4.Normalcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton4.OnHovercolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton4.OnHoverTextColor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton4.selected = false;
            this.bunifuFlatButton4.Size = new System.Drawing.Size(174, 10);
            this.bunifuFlatButton4.TabIndex = 12;
            this.bunifuFlatButton4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuFlatButton4.Textcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton4.TextFont = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // tshow
            // 
            this.tshow.AnimationType = BunifuAnimatorNS.AnimationType.HorizSlide;
            this.tshow.Cursor = null;
            animation1.AnimateOnlyDifferences = true;
            animation1.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.BlindCoeff")));
            animation1.LeafCoeff = 0F;
            animation1.MaxTime = 1F;
            animation1.MinTime = 0F;
            animation1.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicCoeff")));
            animation1.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicShift")));
            animation1.MosaicSize = 0;
            animation1.Padding = new System.Windows.Forms.Padding(0);
            animation1.RotateCoeff = 0F;
            animation1.RotateLimit = 0F;
            animation1.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.ScaleCoeff")));
            animation1.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.SlideCoeff")));
            animation1.TimeCoeff = 0F;
            animation1.TransparencyCoeff = 0F;
            this.tshow.DefaultAnimation = animation1;
            // 
            // panelSuperior
            // 
            this.panelSuperior.BackColor = System.Drawing.Color.DarkTurquoise;
            this.panelSuperior.Controls.Add(this.btnMenu);
            this.panelSuperior.Controls.Add(this.btnSobre);
            this.panelSuperior.Controls.Add(this.txtUsuarioLogado);
            this.panelSuperior.Controls.Add(this.bunifuCustomLabel1);
            this.panelSuperior.Controls.Add(this.Hora);
            this.panelSuperior.Controls.Add(this.btnFechar);
            this.panelSuperior.Controls.Add(this.btnRestaurarTamanho);
            this.panelSuperior.Controls.Add(this.btnMinimizar);
            this.panelSuperior.Controls.Add(this.Casinha);
            this.panelSuperior.Controls.Add(this.Tracinho);
            this.tshow.SetDecoration(this.panelSuperior, BunifuAnimatorNS.DecorationType.None);
            this.panelSuperior.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelSuperior.Location = new System.Drawing.Point(0, 0);
            this.panelSuperior.Name = "panelSuperior";
            this.panelSuperior.Size = new System.Drawing.Size(838, 40);
            this.panelSuperior.TabIndex = 0;
            // 
            // btnMenu
            // 
            this.btnMenu.AutoSize = true;
            this.tshow.SetDecoration(this.btnMenu, BunifuAnimatorNS.DecorationType.None);
            this.btnMenu.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMenu.ForeColor = System.Drawing.Color.White;
            this.btnMenu.Location = new System.Drawing.Point(75, 5);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Size = new System.Drawing.Size(84, 25);
            this.btnMenu.TabIndex = 14;
            this.btnMenu.Text = "LOGOUT";
            this.btnMenu.Click += new System.EventHandler(this.btnMenu_Click);
            // 
            // btnSobre
            // 
            this.btnSobre.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSobre.BackColor = System.Drawing.Color.Transparent;
            this.btnSobre.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tshow.SetDecoration(this.btnSobre, BunifuAnimatorNS.DecorationType.None);
            this.btnSobre.Image = ((System.Drawing.Image)(resources.GetObject("btnSobre.Image")));
            this.btnSobre.ImageActive = null;
            this.btnSobre.Location = new System.Drawing.Point(697, 3);
            this.btnSobre.Name = "btnSobre";
            this.btnSobre.Size = new System.Drawing.Size(30, 30);
            this.btnSobre.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnSobre.TabIndex = 13;
            this.btnSobre.TabStop = false;
            this.btnSobre.Zoom = 10;
            this.btnSobre.Click += new System.EventHandler(this.btnSobre_Click);
            // 
            // txtUsuarioLogado
            // 
            this.txtUsuarioLogado.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tshow.SetDecoration(this.txtUsuarioLogado, BunifuAnimatorNS.DecorationType.None);
            this.txtUsuarioLogado.Enabled = false;
            this.txtUsuarioLogado.Location = new System.Drawing.Point(488, 8);
            this.txtUsuarioLogado.Name = "txtUsuarioLogado";
            this.txtUsuarioLogado.Size = new System.Drawing.Size(100, 20);
            this.txtUsuarioLogado.TabIndex = 12;
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bunifuCustomLabel1.AutoSize = true;
            this.tshow.SetDecoration(this.bunifuCustomLabel1, BunifuAnimatorNS.DecorationType.None);
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel1.ForeColor = System.Drawing.Color.White;
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(411, 3);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(82, 25);
            this.bunifuCustomLabel1.TabIndex = 11;
            this.bunifuCustomLabel1.Text = "Usuário:";
            // 
            // Hora
            // 
            this.Hora.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Hora.AutoSize = true;
            this.Hora.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.tshow.SetDecoration(this.Hora, BunifuAnimatorNS.DecorationType.None);
            this.Hora.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Hora.Location = new System.Drawing.Point(605, 4);
            this.Hora.Name = "Hora";
            this.Hora.Size = new System.Drawing.Size(70, 26);
            this.Hora.TabIndex = 7;
            this.Hora.Text = "TIMER";
            // 
            // btnFechar
            // 
            this.btnFechar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFechar.BackColor = System.Drawing.Color.Transparent;
            this.btnFechar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tshow.SetDecoration(this.btnFechar, BunifuAnimatorNS.DecorationType.None);
            this.btnFechar.Image = ((System.Drawing.Image)(resources.GetObject("btnFechar.Image")));
            this.btnFechar.ImageActive = null;
            this.btnFechar.Location = new System.Drawing.Point(805, 3);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(30, 30);
            this.btnFechar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnFechar.TabIndex = 6;
            this.btnFechar.TabStop = false;
            this.btnFechar.Zoom = 10;
            this.btnFechar.Click += new System.EventHandler(this.BunifuImageButton3_Click);
            // 
            // btnRestaurarTamanho
            // 
            this.btnRestaurarTamanho.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRestaurarTamanho.BackColor = System.Drawing.Color.Transparent;
            this.btnRestaurarTamanho.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tshow.SetDecoration(this.btnRestaurarTamanho, BunifuAnimatorNS.DecorationType.None);
            this.btnRestaurarTamanho.Image = ((System.Drawing.Image)(resources.GetObject("btnRestaurarTamanho.Image")));
            this.btnRestaurarTamanho.ImageActive = null;
            this.btnRestaurarTamanho.Location = new System.Drawing.Point(769, 3);
            this.btnRestaurarTamanho.Name = "btnRestaurarTamanho";
            this.btnRestaurarTamanho.Size = new System.Drawing.Size(30, 30);
            this.btnRestaurarTamanho.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnRestaurarTamanho.TabIndex = 5;
            this.btnRestaurarTamanho.TabStop = false;
            this.btnRestaurarTamanho.Zoom = 10;
            this.btnRestaurarTamanho.Click += new System.EventHandler(this.BtnRestaurarTamanho_Click);
            // 
            // btnMinimizar
            // 
            this.btnMinimizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMinimizar.BackColor = System.Drawing.Color.Transparent;
            this.btnMinimizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tshow.SetDecoration(this.btnMinimizar, BunifuAnimatorNS.DecorationType.None);
            this.btnMinimizar.Image = ((System.Drawing.Image)(resources.GetObject("btnMinimizar.Image")));
            this.btnMinimizar.ImageActive = null;
            this.btnMinimizar.Location = new System.Drawing.Point(733, 3);
            this.btnMinimizar.Name = "btnMinimizar";
            this.btnMinimizar.Size = new System.Drawing.Size(30, 30);
            this.btnMinimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnMinimizar.TabIndex = 4;
            this.btnMinimizar.TabStop = false;
            this.btnMinimizar.Zoom = 10;
            this.btnMinimizar.Click += new System.EventHandler(this.BtnMinimizar_Click);
            // 
            // Casinha
            // 
            this.Casinha.BackColor = System.Drawing.Color.Transparent;
            this.Casinha.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tshow.SetDecoration(this.Casinha, BunifuAnimatorNS.DecorationType.None);
            this.Casinha.Image = ((System.Drawing.Image)(resources.GetObject("Casinha.Image")));
            this.Casinha.ImageActive = null;
            this.Casinha.Location = new System.Drawing.Point(39, 3);
            this.Casinha.Name = "Casinha";
            this.Casinha.Size = new System.Drawing.Size(30, 30);
            this.Casinha.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Casinha.TabIndex = 3;
            this.Casinha.TabStop = false;
            this.Casinha.Zoom = 10;
            this.Casinha.Click += new System.EventHandler(this.Homee_Click);
            // 
            // Tracinho
            // 
            this.Tracinho.BackColor = System.Drawing.Color.Transparent;
            this.Tracinho.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tshow.SetDecoration(this.Tracinho, BunifuAnimatorNS.DecorationType.None);
            this.Tracinho.Image = ((System.Drawing.Image)(resources.GetObject("Tracinho.Image")));
            this.Tracinho.ImageActive = null;
            this.Tracinho.Location = new System.Drawing.Point(3, 3);
            this.Tracinho.Name = "Tracinho";
            this.Tracinho.Size = new System.Drawing.Size(30, 30);
            this.Tracinho.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Tracinho.TabIndex = 0;
            this.Tracinho.TabStop = false;
            this.Tracinho.Zoom = 10;
            this.Tracinho.Click += new System.EventHandler(this.Tracinho_Click);
            // 
            // panelChildForm
            // 
            this.panelChildForm.AutoSize = true;
            this.tshow.SetDecoration(this.panelChildForm, BunifuAnimatorNS.DecorationType.None);
            this.panelChildForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelChildForm.Location = new System.Drawing.Point(0, 40);
            this.panelChildForm.Name = "panelChildForm";
            this.panelChildForm.Size = new System.Drawing.Size(838, 748);
            this.panelChildForm.TabIndex = 20;
            // 
            // MenuDianteiro
            // 
            this.MenuDianteiro.Controls.Add(this.panelChildForm);
            this.MenuDianteiro.Controls.Add(this.panelSuperior);
            this.tshow.SetDecoration(this.MenuDianteiro, BunifuAnimatorNS.DecorationType.None);
            this.MenuDianteiro.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MenuDianteiro.Location = new System.Drawing.Point(180, 0);
            this.MenuDianteiro.Name = "MenuDianteiro";
            this.MenuDianteiro.Size = new System.Drawing.Size(838, 788);
            this.MenuDianteiro.TabIndex = 1;
            this.MenuDianteiro.Paint += new System.Windows.Forms.PaintEventHandler(this.MenuSuperior_Paint);
            // 
            // bunifuDragControl2
            // 
            this.bunifuDragControl2.Fixed = true;
            this.bunifuDragControl2.Horizontal = true;
            this.bunifuDragControl2.TargetControl = this.panelSuperior;
            this.bunifuDragControl2.Vertical = true;
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this.LOGO;
            this.bunifuDragControl1.Vertical = true;
            // 
            // horafecha
            // 
            this.horafecha.Enabled = true;
            this.horafecha.Tick += new System.EventHandler(this.Horafecha_Tick);
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1018, 788);
            this.Controls.Add(this.MenuDianteiro);
            this.Controls.Add(this.MenuLateral);
            this.tshow.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Home";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Home_Load);
            this.MenuLateral.ResumeLayout(false);
            this.panelFinanceiroSubMenu.ResumeLayout(false);
            this.panelViagenSubMenu.ResumeLayout(false);
            this.panelVeiculoSubMenu.ResumeLayout(false);
            this.panelMotoristaSubMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.LOGO)).EndInit();
            this.panelSuperior.ResumeLayout(false);
            this.panelSuperior.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnSobre)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnFechar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnRestaurarTamanho)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Casinha)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Tracinho)).EndInit();
            this.MenuDianteiro.ResumeLayout(false);
            this.MenuDianteiro.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel MenuLateral;
        private Bunifu.Framework.UI.BunifuFlatButton btnMotorista;
        private System.Windows.Forms.PictureBox LOGO;
        private Bunifu.Framework.UI.BunifuFlatButton btnVeiculos;
        private Bunifu.Framework.UI.BunifuFlatButton btnRelatorios;
        private Bunifu.Framework.UI.BunifuFlatButton btnVeiculosDisponiveis;
        private Bunifu.Framework.UI.BunifuFlatButton btnAvisos;
        private Bunifu.Framework.UI.BunifuFlatButton btnMultas;
        private Bunifu.Framework.UI.BunifuFlatButton btnLocacao;
        private Bunifu.Framework.UI.BunifuFlatButton btnManutencao;
        private Bunifu.Framework.UI.BunifuFlatButton btnFinanceiro;
        private Bunifu.Framework.UI.BunifuFlatButton btnViagens;
        private BunifuAnimatorNS.BunifuTransition tshow;
        private Bunifu.Framework.UI.BunifuFlatButton btnCliente;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl2;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private System.Windows.Forms.Panel panelSuperior;
        private Bunifu.Framework.UI.BunifuImageButton btnFechar;
        private Bunifu.Framework.UI.BunifuImageButton btnRestaurarTamanho;
        private Bunifu.Framework.UI.BunifuImageButton btnMinimizar;
        private Bunifu.Framework.UI.BunifuImageButton Casinha;
        private Bunifu.Framework.UI.BunifuImageButton Tracinho;
        private System.Windows.Forms.Panel panelChildForm;
        private System.Windows.Forms.Panel MenuDianteiro;
        private System.Windows.Forms.Panel panelVeiculoSubMenu;
        private Bunifu.Framework.UI.BunifuFlatButton btnSeguroVeiculo;
        private Bunifu.Framework.UI.BunifuFlatButton btnCompraVenda;
        private Bunifu.Framework.UI.BunifuFlatButton btnSinistro;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton4;
        private System.Windows.Forms.Panel panelMotoristaSubMenu;
        private Bunifu.Framework.UI.BunifuFlatButton btnSeguroMotorista;
        private System.Windows.Forms.Panel panelViagenSubMenu;
        private Bunifu.Framework.UI.BunifuFlatButton btnAbastecimento;
        private System.Windows.Forms.Panel panelFinanceiroSubMenu;
        private Bunifu.Framework.UI.BunifuFlatButton btnContasReceber;
        private System.Windows.Forms.Timer horafecha;
        private System.Windows.Forms.Label Hora;
        private Bunifu.Framework.UI.BunifuFlatButton btnContasPagar;
        private System.Windows.Forms.TextBox txtUsuarioLogado;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private Bunifu.Framework.UI.BunifuImageButton btnSobre;
        private Bunifu.Framework.UI.BunifuCustomLabel btnMenu;
    }
}

