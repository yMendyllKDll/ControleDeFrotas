namespace Menu.View
{
    partial class TelaSeguroMotoristaa
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
            this.btnExibListaSegMoto = new System.Windows.Forms.Button();
            this.dataGridSegMoto = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnLimparSegMoto = new System.Windows.Forms.Button();
            this.btnPesqSegMoto = new System.Windows.Forms.Button();
            this.txtCorretor = new System.Windows.Forms.TextBox();
            this.txtSituacao = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtValor = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtDataInicio = new System.Windows.Forms.MaskedTextBox();
            this.txtSeguradora = new System.Windows.Forms.TextBox();
            this.txtCPFMoto = new System.Windows.Forms.MaskedTextBox();
            this.txtNApolice = new System.Windows.Forms.MaskedTextBox();
            this.txtDataVenc = new System.Windows.Forms.MaskedTextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnEditSegMoto = new System.Windows.Forms.Button();
            this.btnDelSegMoto = new System.Windows.Forms.Button();
            this.btnCadSegMoto = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridSegMoto)).BeginInit();
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
            this.groupBox1.Size = new System.Drawing.Size(639, 432);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "SEGURO MOTORISTA";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.DodgerBlue;
            this.panel1.Controls.Add(this.btnExibListaSegMoto);
            this.panel1.Controls.Add(this.dataGridSegMoto);
            this.panel1.Location = new System.Drawing.Point(15, 19);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(284, 396);
            this.panel1.TabIndex = 0;
            // 
            // btnExibListaSegMoto
            // 
            this.btnExibListaSegMoto.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExibListaSegMoto.Location = new System.Drawing.Point(3, 361);
            this.btnExibListaSegMoto.Name = "btnExibListaSegMoto";
            this.btnExibListaSegMoto.Size = new System.Drawing.Size(278, 23);
            this.btnExibListaSegMoto.TabIndex = 2;
            this.btnExibListaSegMoto.Text = "ATUALIZAR LISTA";
            this.btnExibListaSegMoto.UseVisualStyleBackColor = true;
            this.btnExibListaSegMoto.Click += new System.EventHandler(this.btnExibListaSegMoto_Click);
            // 
            // dataGridSegMoto
            // 
            this.dataGridSegMoto.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridSegMoto.BackgroundColor = System.Drawing.Color.White;
            this.dataGridSegMoto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridSegMoto.Location = new System.Drawing.Point(3, 4);
            this.dataGridSegMoto.Name = "dataGridSegMoto";
            this.dataGridSegMoto.Size = new System.Drawing.Size(278, 351);
            this.dataGridSegMoto.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.Color.DodgerBlue;
            this.panel2.Controls.Add(this.groupBox2);
            this.panel2.Location = new System.Drawing.Point(305, 19);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(320, 396);
            this.panel2.TabIndex = 3;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.btnLimparSegMoto);
            this.groupBox2.Controls.Add(this.btnPesqSegMoto);
            this.groupBox2.Controls.Add(this.txtCorretor);
            this.groupBox2.Controls.Add(this.txtSituacao);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.txtValor);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.txtDataInicio);
            this.groupBox2.Controls.Add(this.txtSeguradora);
            this.groupBox2.Controls.Add(this.txtCPFMoto);
            this.groupBox2.Controls.Add(this.txtNApolice);
            this.groupBox2.Controls.Add(this.txtDataVenc);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.btnEditSegMoto);
            this.groupBox2.Controls.Add(this.btnDelSegMoto);
            this.groupBox2.Controls.Add(this.btnCadSegMoto);
            this.groupBox2.Location = new System.Drawing.Point(15, 14);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(291, 367);
            this.groupBox2.TabIndex = 23;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "CADASTRO SEGURO MOTORISTA";
            // 
            // btnLimparSegMoto
            // 
            this.btnLimparSegMoto.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLimparSegMoto.Location = new System.Drawing.Point(22, 327);
            this.btnLimparSegMoto.Name = "btnLimparSegMoto";
            this.btnLimparSegMoto.Size = new System.Drawing.Size(248, 23);
            this.btnLimparSegMoto.TabIndex = 64;
            this.btnLimparSegMoto.Text = "LIMPAR";
            this.btnLimparSegMoto.UseVisualStyleBackColor = true;
            this.btnLimparSegMoto.Click += new System.EventHandler(this.btnLimparSegMoto_Click);
            // 
            // btnPesqSegMoto
            // 
            this.btnPesqSegMoto.Location = new System.Drawing.Point(24, 211);
            this.btnPesqSegMoto.Name = "btnPesqSegMoto";
            this.btnPesqSegMoto.Size = new System.Drawing.Size(247, 23);
            this.btnPesqSegMoto.TabIndex = 63;
            this.btnPesqSegMoto.Text = "PESQUISAR";
            this.btnPesqSegMoto.UseVisualStyleBackColor = true;
            this.btnPesqSegMoto.Click += new System.EventHandler(this.btnPesqSegMoto_Click);
            // 
            // txtCorretor
            // 
            this.txtCorretor.Location = new System.Drawing.Point(145, 96);
            this.txtCorretor.Name = "txtCorretor";
            this.txtCorretor.Size = new System.Drawing.Size(125, 20);
            this.txtCorretor.TabIndex = 54;
            // 
            // txtSituacao
            // 
            this.txtSituacao.FormattingEnabled = true;
            this.txtSituacao.Items.AddRange(new object[] {
            "ATIVO",
            "INATIVO"});
            this.txtSituacao.Location = new System.Drawing.Point(188, 174);
            this.txtSituacao.Name = "txtSituacao";
            this.txtSituacao.Size = new System.Drawing.Size(82, 21);
            this.txtSituacao.TabIndex = 53;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(127, 177);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(64, 13);
            this.label10.TabIndex = 52;
            this.label10.Text = "SITUAÇÃO:";
            // 
            // txtValor
            // 
            this.txtValor.Location = new System.Drawing.Point(72, 174);
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(49, 20);
            this.txtValor.TabIndex = 51;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(20, 177);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(46, 13);
            this.label9.TabIndex = 50;
            this.label9.Text = "VALOR:";
            // 
            // txtDataInicio
            // 
            this.txtDataInicio.Location = new System.Drawing.Point(145, 122);
            this.txtDataInicio.Mask = "00/00/0000";
            this.txtDataInicio.Name = "txtDataInicio";
            this.txtDataInicio.Size = new System.Drawing.Size(125, 20);
            this.txtDataInicio.TabIndex = 49;
            this.txtDataInicio.ValidatingType = typeof(System.DateTime);
            // 
            // txtSeguradora
            // 
            this.txtSeguradora.Location = new System.Drawing.Point(145, 44);
            this.txtSeguradora.Name = "txtSeguradora";
            this.txtSeguradora.Size = new System.Drawing.Size(125, 20);
            this.txtSeguradora.TabIndex = 38;
            // 
            // txtCPFMoto
            // 
            this.txtCPFMoto.Location = new System.Drawing.Point(145, 70);
            this.txtCPFMoto.Mask = "999999999/99";
            this.txtCPFMoto.Name = "txtCPFMoto";
            this.txtCPFMoto.Size = new System.Drawing.Size(125, 20);
            this.txtCPFMoto.TabIndex = 47;
            // 
            // txtNApolice
            // 
            this.txtNApolice.Location = new System.Drawing.Point(145, 18);
            this.txtNApolice.Name = "txtNApolice";
            this.txtNApolice.Size = new System.Drawing.Size(125, 20);
            this.txtNApolice.TabIndex = 46;
            // 
            // txtDataVenc
            // 
            this.txtDataVenc.Location = new System.Drawing.Point(145, 148);
            this.txtDataVenc.Mask = "00/00/0000";
            this.txtDataVenc.Name = "txtDataVenc";
            this.txtDataVenc.Size = new System.Drawing.Size(125, 20);
            this.txtDataVenc.TabIndex = 45;
            this.txtDataVenc.ValidatingType = typeof(System.DateTime);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(20, 148);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(113, 13);
            this.label8.TabIndex = 44;
            this.label8.Text = "DATA VENCIMENTO:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(20, 122);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(74, 13);
            this.label7.TabIndex = 43;
            this.label7.Text = "DATA INICIO:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(20, 96);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 13);
            this.label6.TabIndex = 42;
            this.label6.Text = "CORRETOR";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(20, 70);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 13);
            this.label5.TabIndex = 41;
            this.label5.Text = "SEGURADO:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 44);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 13);
            this.label4.TabIndex = 40;
            this.label4.Text = "SEGURADORA:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 13);
            this.label3.TabIndex = 39;
            this.label3.Text = "Nº APÓLISE";
            // 
            // btnEditSegMoto
            // 
            this.btnEditSegMoto.Enabled = false;
            this.btnEditSegMoto.Location = new System.Drawing.Point(24, 269);
            this.btnEditSegMoto.Name = "btnEditSegMoto";
            this.btnEditSegMoto.Size = new System.Drawing.Size(247, 23);
            this.btnEditSegMoto.TabIndex = 33;
            this.btnEditSegMoto.Text = "EDITAR";
            this.btnEditSegMoto.UseVisualStyleBackColor = true;
            this.btnEditSegMoto.Click += new System.EventHandler(this.btnEditSegMoto_Click);
            // 
            // btnDelSegMoto
            // 
            this.btnDelSegMoto.Location = new System.Drawing.Point(24, 298);
            this.btnDelSegMoto.Name = "btnDelSegMoto";
            this.btnDelSegMoto.Size = new System.Drawing.Size(247, 23);
            this.btnDelSegMoto.TabIndex = 35;
            this.btnDelSegMoto.Text = "EXCLUIR";
            this.btnDelSegMoto.UseVisualStyleBackColor = true;
            this.btnDelSegMoto.Click += new System.EventHandler(this.btnDelSegMoto_Click);
            // 
            // btnCadSegMoto
            // 
            this.btnCadSegMoto.Location = new System.Drawing.Point(24, 240);
            this.btnCadSegMoto.Name = "btnCadSegMoto";
            this.btnCadSegMoto.Size = new System.Drawing.Size(247, 23);
            this.btnCadSegMoto.TabIndex = 36;
            this.btnCadSegMoto.Text = "CADASTRAR";
            this.btnCadSegMoto.UseVisualStyleBackColor = true;
            this.btnCadSegMoto.Click += new System.EventHandler(this.btnCadSegMoto_Click);
            // 
            // TelaSeguroMotoristaa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(663, 454);
            this.Controls.Add(this.groupBox1);
            this.Name = "TelaSeguroMotoristaa";
            this.Text = "TelaSeguroMotoristaa";
            this.groupBox1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridSegMoto)).EndInit();
            this.panel2.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnExibListaSegMoto;
        private System.Windows.Forms.DataGridView dataGridSegMoto;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnEditSegMoto;
        private System.Windows.Forms.Button btnDelSegMoto;
        private System.Windows.Forms.Button btnCadSegMoto;
        private System.Windows.Forms.TextBox txtCorretor;
        private System.Windows.Forms.ComboBox txtSituacao;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtValor;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.MaskedTextBox txtDataInicio;
        private System.Windows.Forms.TextBox txtSeguradora;
        private System.Windows.Forms.MaskedTextBox txtCPFMoto;
        private System.Windows.Forms.MaskedTextBox txtNApolice;
        private System.Windows.Forms.MaskedTextBox txtDataVenc;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnPesqSegMoto;
        private System.Windows.Forms.Button btnLimparSegMoto;
    }
}