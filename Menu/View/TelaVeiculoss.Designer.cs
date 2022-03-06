namespace Menu.View
{
    partial class TelaVeiculoss
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnExibListVei = new System.Windows.Forms.Button();
            this.dataGridVei = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.txtKMAtual = new System.Windows.Forms.TextBox();
            this.btnPesquisaVei = new System.Windows.Forms.Button();
            this.txtCodVeiculo = new System.Windows.Forms.TextBox();
            this.txtModelo = new System.Windows.Forms.TextBox();
            this.txtPneu = new System.Windows.Forms.ComboBox();
            this.txtCombustivel = new System.Windows.Forms.ComboBox();
            this.txtCor = new System.Windows.Forms.TextBox();
            this.txtChassi = new System.Windows.Forms.MaskedTextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtAno = new System.Windows.Forms.MaskedTextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtPlaca = new System.Windows.Forms.MaskedTextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtRenavam = new System.Windows.Forms.MaskedTextBox();
            this.txtSituacao = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtMarca = new System.Windows.Forms.TextBox();
            this.btnEditVei = new System.Windows.Forms.Button();
            this.btnDelVei = new System.Windows.Forms.Button();
            this.btnCadVei = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridVei)).BeginInit();
            this.panel2.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.panel1);
            this.groupBox1.Controls.Add(this.panel2);
            this.groupBox1.Location = new System.Drawing.Point(12, 11);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(639, 428);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "VEÍCULOS";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.DodgerBlue;
            this.panel1.Controls.Add(this.btnExibListVei);
            this.panel1.Controls.Add(this.dataGridVei);
            this.panel1.Location = new System.Drawing.Point(15, 19);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(284, 392);
            this.panel1.TabIndex = 0;
            // 
            // btnExibListVei
            // 
            this.btnExibListVei.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExibListVei.Location = new System.Drawing.Point(3, 357);
            this.btnExibListVei.Name = "btnExibListVei";
            this.btnExibListVei.Size = new System.Drawing.Size(278, 23);
            this.btnExibListVei.TabIndex = 2;
            this.btnExibListVei.Text = "ATUALIZAR LISTA";
            this.btnExibListVei.UseVisualStyleBackColor = true;
            this.btnExibListVei.Click += new System.EventHandler(this.btnExibListVei_Click);
            // 
            // dataGridVei
            // 
            this.dataGridVei.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridVei.BackgroundColor = System.Drawing.Color.White;
            this.dataGridVei.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridVei.Location = new System.Drawing.Point(3, 4);
            this.dataGridVei.Name = "dataGridVei";
            this.dataGridVei.Size = new System.Drawing.Size(278, 347);
            this.dataGridVei.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.Color.DodgerBlue;
            this.panel2.Controls.Add(this.groupBox2);
            this.panel2.Location = new System.Drawing.Point(305, 19);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(320, 392);
            this.panel2.TabIndex = 3;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.btnLimpar);
            this.groupBox2.Controls.Add(this.txtKMAtual);
            this.groupBox2.Controls.Add(this.btnPesquisaVei);
            this.groupBox2.Controls.Add(this.txtCodVeiculo);
            this.groupBox2.Controls.Add(this.txtModelo);
            this.groupBox2.Controls.Add(this.txtPneu);
            this.groupBox2.Controls.Add(this.txtCombustivel);
            this.groupBox2.Controls.Add(this.txtCor);
            this.groupBox2.Controls.Add(this.txtChassi);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.txtAno);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.txtPlaca);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.txtRenavam);
            this.groupBox2.Controls.Add(this.txtSituacao);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.txtMarca);
            this.groupBox2.Controls.Add(this.btnEditVei);
            this.groupBox2.Controls.Add(this.btnDelVei);
            this.groupBox2.Controls.Add(this.btnCadVei);
            this.groupBox2.Location = new System.Drawing.Point(15, 14);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(291, 366);
            this.groupBox2.TabIndex = 23;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "CADASTRO VEÍCULOS";
            // 
            // btnLimpar
            // 
            this.btnLimpar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLimpar.Location = new System.Drawing.Point(20, 337);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(248, 23);
            this.btnLimpar.TabIndex = 27;
            this.btnLimpar.Text = "LIMPAR";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // txtKMAtual
            // 
            this.txtKMAtual.Location = new System.Drawing.Point(73, 112);
            this.txtKMAtual.Name = "txtKMAtual";
            this.txtKMAtual.Size = new System.Drawing.Size(71, 20);
            this.txtKMAtual.TabIndex = 63;
            // 
            // btnPesquisaVei
            // 
            this.btnPesquisaVei.Location = new System.Drawing.Point(20, 221);
            this.btnPesquisaVei.Name = "btnPesquisaVei";
            this.btnPesquisaVei.Size = new System.Drawing.Size(247, 23);
            this.btnPesquisaVei.TabIndex = 62;
            this.btnPesquisaVei.Text = "PESQUISAR";
            this.btnPesquisaVei.UseVisualStyleBackColor = true;
            this.btnPesquisaVei.Click += new System.EventHandler(this.btnPesquisaVei_Click);
            // 
            // txtCodVeiculo
            // 
            this.txtCodVeiculo.Location = new System.Drawing.Point(73, 34);
            this.txtCodVeiculo.Name = "txtCodVeiculo";
            this.txtCodVeiculo.Size = new System.Drawing.Size(71, 20);
            this.txtCodVeiculo.TabIndex = 61;
            // 
            // txtModelo
            // 
            this.txtModelo.Location = new System.Drawing.Point(215, 34);
            this.txtModelo.Name = "txtModelo";
            this.txtModelo.Size = new System.Drawing.Size(71, 20);
            this.txtModelo.TabIndex = 60;
            // 
            // txtPneu
            // 
            this.txtPneu.FormattingEnabled = true;
            this.txtPneu.Items.AddRange(new object[] {
            "ÓTIMO",
            "BOM",
            "REGULAR",
            "PÉSSIMO"});
            this.txtPneu.Location = new System.Drawing.Point(215, 139);
            this.txtPneu.Name = "txtPneu";
            this.txtPneu.Size = new System.Drawing.Size(71, 21);
            this.txtPneu.TabIndex = 59;
            // 
            // txtCombustivel
            // 
            this.txtCombustivel.FormattingEnabled = true;
            this.txtCombustivel.Items.AddRange(new object[] {
            "GASOLINA C",
            "GASOLINA A",
            "ETANOL",
            "DIESEL",
            "GÁS"});
            this.txtCombustivel.Location = new System.Drawing.Point(73, 138);
            this.txtCombustivel.Name = "txtCombustivel";
            this.txtCombustivel.Size = new System.Drawing.Size(71, 21);
            this.txtCombustivel.TabIndex = 58;
            // 
            // txtCor
            // 
            this.txtCor.Location = new System.Drawing.Point(73, 86);
            this.txtCor.Name = "txtCor";
            this.txtCor.Size = new System.Drawing.Size(71, 20);
            this.txtCor.TabIndex = 57;
            // 
            // txtChassi
            // 
            this.txtChassi.Location = new System.Drawing.Point(73, 191);
            this.txtChassi.Mask = "99999999999999999";
            this.txtChassi.Name = "txtChassi";
            this.txtChassi.Size = new System.Drawing.Size(108, 20);
            this.txtChassi.TabIndex = 56;
            this.txtChassi.ValidatingType = typeof(System.DateTime);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(8, 191);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(49, 13);
            this.label13.TabIndex = 55;
            this.label13.Text = "CHASSI:";
            // 
            // txtAno
            // 
            this.txtAno.Location = new System.Drawing.Point(215, 60);
            this.txtAno.Mask = "00/00/0000";
            this.txtAno.Name = "txtAno";
            this.txtAno.Size = new System.Drawing.Size(71, 20);
            this.txtAno.TabIndex = 54;
            this.txtAno.ValidatingType = typeof(System.DateTime);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(150, 60);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(33, 13);
            this.label12.TabIndex = 53;
            this.label12.Text = "ANO:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(150, 34);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(56, 13);
            this.label11.TabIndex = 52;
            this.label11.Text = "MODELO:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(150, 113);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(44, 13);
            this.label10.TabIndex = 51;
            this.label10.Text = "PLACA:";
            // 
            // txtPlaca
            // 
            this.txtPlaca.Location = new System.Drawing.Point(215, 113);
            this.txtPlaca.Mask = "999-9999";
            this.txtPlaca.Name = "txtPlaca";
            this.txtPlaca.Size = new System.Drawing.Size(71, 20);
            this.txtPlaca.TabIndex = 50;
            this.txtPlaca.ValidatingType = typeof(System.DateTime);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(150, 139);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(40, 13);
            this.label9.TabIndex = 49;
            this.label9.Text = "PNEU:";
            // 
            // txtRenavam
            // 
            this.txtRenavam.Location = new System.Drawing.Point(73, 165);
            this.txtRenavam.Mask = "9999999999";
            this.txtRenavam.Name = "txtRenavam";
            this.txtRenavam.Size = new System.Drawing.Size(71, 20);
            this.txtRenavam.TabIndex = 48;
            // 
            // txtSituacao
            // 
            this.txtSituacao.FormattingEnabled = true;
            this.txtSituacao.Items.AddRange(new object[] {
            "GARAGEM",
            "INATIVO",
            "MANUTENÇÃO"});
            this.txtSituacao.Location = new System.Drawing.Point(215, 86);
            this.txtSituacao.Name = "txtSituacao";
            this.txtSituacao.Size = new System.Drawing.Size(71, 21);
            this.txtSituacao.TabIndex = 46;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(150, 86);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(64, 13);
            this.label8.TabIndex = 45;
            this.label8.Text = "SITUAÇÃO:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(8, 165);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(63, 13);
            this.label7.TabIndex = 44;
            this.label7.Text = "RENAVAM:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(7, 138);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 13);
            this.label6.TabIndex = 43;
            this.label6.Text = "Combustivel:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 112);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 13);
            this.label5.TabIndex = 42;
            this.label5.Text = "Km Atual:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 86);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 13);
            this.label4.TabIndex = 41;
            this.label4.Text = "COR:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 60);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 13);
            this.label3.TabIndex = 40;
            this.label3.Text = "MARCA:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 39;
            this.label1.Text = "CÓDIGO:";
            // 
            // txtMarca
            // 
            this.txtMarca.Location = new System.Drawing.Point(73, 60);
            this.txtMarca.Name = "txtMarca";
            this.txtMarca.Size = new System.Drawing.Size(71, 20);
            this.txtMarca.TabIndex = 38;
            // 
            // btnEditVei
            // 
            this.btnEditVei.Enabled = false;
            this.btnEditVei.Location = new System.Drawing.Point(20, 279);
            this.btnEditVei.Name = "btnEditVei";
            this.btnEditVei.Size = new System.Drawing.Size(247, 23);
            this.btnEditVei.TabIndex = 33;
            this.btnEditVei.Text = "EDITAR";
            this.btnEditVei.UseVisualStyleBackColor = true;
            this.btnEditVei.Click += new System.EventHandler(this.btnEditVei_Click);
            // 
            // btnDelVei
            // 
            this.btnDelVei.Location = new System.Drawing.Point(20, 308);
            this.btnDelVei.Name = "btnDelVei";
            this.btnDelVei.Size = new System.Drawing.Size(247, 23);
            this.btnDelVei.TabIndex = 35;
            this.btnDelVei.Text = "EXCLUIR";
            this.btnDelVei.UseVisualStyleBackColor = true;
            this.btnDelVei.Click += new System.EventHandler(this.btnDelVei_Click);
            // 
            // btnCadVei
            // 
            this.btnCadVei.Location = new System.Drawing.Point(20, 250);
            this.btnCadVei.Name = "btnCadVei";
            this.btnCadVei.Size = new System.Drawing.Size(247, 23);
            this.btnCadVei.TabIndex = 36;
            this.btnCadVei.Text = "CADASTRAR";
            this.btnCadVei.UseVisualStyleBackColor = true;
            this.btnCadVei.Click += new System.EventHandler(this.btnCadVei_Click);
            // 
            // TelaVeiculoss
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(663, 450);
            this.Controls.Add(this.groupBox1);
            this.Name = "TelaVeiculoss";
            this.Text = "TelaVeiculoss";
            this.groupBox1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridVei)).EndInit();
            this.panel2.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnExibListVei;
        private System.Windows.Forms.DataGridView dataGridVei;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnEditVei;
        private System.Windows.Forms.Button btnDelVei;
        private System.Windows.Forms.Button btnCadVei;
        private System.Windows.Forms.TextBox txtCodVeiculo;
        private System.Windows.Forms.TextBox txtModelo;
        private System.Windows.Forms.ComboBox txtPneu;
        private System.Windows.Forms.ComboBox txtCombustivel;
        private System.Windows.Forms.TextBox txtCor;
        private System.Windows.Forms.MaskedTextBox txtChassi;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.MaskedTextBox txtAno;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.MaskedTextBox txtPlaca;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.MaskedTextBox txtRenavam;
        private System.Windows.Forms.ComboBox txtSituacao;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMarca;
        private System.Windows.Forms.Button btnPesquisaVei;
        private System.Windows.Forms.TextBox txtKMAtual;
        private System.Windows.Forms.Button btnLimpar;
    }
}