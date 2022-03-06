namespace Menu.View
{
    partial class TelaMotoristaa
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnExibListMoto = new System.Windows.Forms.Button();
            this.dataGridMoto = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.txtCodMoto = new System.Windows.Forms.TextBox();
            this.btnPesquisaMoto = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtStatusMoto = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtCPFMoto = new System.Windows.Forms.MaskedTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtCNHMoto = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtRGMoto = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnDelMoto = new System.Windows.Forms.Button();
            this.txtDataNascMoto = new System.Windows.Forms.MaskedTextBox();
            this.btnEditMoto = new System.Windows.Forms.Button();
            this.btnCadMoto = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.txtValCNHMoto = new System.Windows.Forms.MaskedTextBox();
            this.txtNomeMoto = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridMoto)).BeginInit();
            this.panel2.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.DodgerBlue;
            this.panel1.Controls.Add(this.btnExibListMoto);
            this.panel1.Controls.Add(this.dataGridMoto);
            this.panel1.Location = new System.Drawing.Point(15, 19);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(276, 405);
            this.panel1.TabIndex = 0;
            // 
            // btnExibListMoto
            // 
            this.btnExibListMoto.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExibListMoto.Location = new System.Drawing.Point(3, 370);
            this.btnExibListMoto.Name = "btnExibListMoto";
            this.btnExibListMoto.Size = new System.Drawing.Size(270, 23);
            this.btnExibListMoto.TabIndex = 0;
            this.btnExibListMoto.Text = "ATUALIZAR LISTA";
            this.btnExibListMoto.UseVisualStyleBackColor = true;
            this.btnExibListMoto.Click += new System.EventHandler(this.BtnExibirLista_Click);
            // 
            // dataGridMoto
            // 
            this.dataGridMoto.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridMoto.BackgroundColor = System.Drawing.Color.White;
            this.dataGridMoto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridMoto.Location = new System.Drawing.Point(3, 4);
            this.dataGridMoto.Name = "dataGridMoto";
            this.dataGridMoto.Size = new System.Drawing.Size(270, 360);
            this.dataGridMoto.TabIndex = 14;
            this.dataGridMoto.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.Color.DodgerBlue;
            this.panel2.Controls.Add(this.groupBox2);
            this.panel2.Location = new System.Drawing.Point(297, 19);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(320, 405);
            this.panel2.TabIndex = 3;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.btnLimpar);
            this.groupBox2.Controls.Add(this.txtCodMoto);
            this.groupBox2.Controls.Add(this.btnPesquisaMoto);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.txtStatusMoto);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.txtCPFMoto);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.txtCNHMoto);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.txtRGMoto);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.btnDelMoto);
            this.groupBox2.Controls.Add(this.txtDataNascMoto);
            this.groupBox2.Controls.Add(this.btnEditMoto);
            this.groupBox2.Controls.Add(this.btnCadMoto);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.txtValCNHMoto);
            this.groupBox2.Controls.Add(this.txtNomeMoto);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Location = new System.Drawing.Point(15, 14);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(291, 387);
            this.groupBox2.TabIndex = 23;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "CADASTRO MOTORISTA";
            // 
            // btnLimpar
            // 
            this.btnLimpar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLimpar.Location = new System.Drawing.Point(14, 346);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(257, 23);
            this.btnLimpar.TabIndex = 13;
            this.btnLimpar.Text = "LIMPAR";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.BtnLimpar_Click);
            // 
            // txtCodMoto
            // 
            this.txtCodMoto.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCodMoto.Location = new System.Drawing.Point(113, 20);
            this.txtCodMoto.Name = "txtCodMoto";
            this.txtCodMoto.Size = new System.Drawing.Size(158, 20);
            this.txtCodMoto.TabIndex = 1;
            // 
            // btnPesquisaMoto
            // 
            this.btnPesquisaMoto.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPesquisaMoto.Location = new System.Drawing.Point(14, 230);
            this.btnPesquisaMoto.Name = "btnPesquisaMoto";
            this.btnPesquisaMoto.Size = new System.Drawing.Size(257, 23);
            this.btnPesquisaMoto.TabIndex = 9;
            this.btnPesquisaMoto.Text = "PESQUISA";
            this.btnPesquisaMoto.UseVisualStyleBackColor = true;
            this.btnPesquisaMoto.Click += new System.EventHandler(this.BtnPesquisaMoto_Click);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 24;
            this.label2.Text = "CÓDIGO:";
            // 
            // txtStatusMoto
            // 
            this.txtStatusMoto.FormattingEnabled = true;
            this.txtStatusMoto.Items.AddRange(new object[] {
            "ATIVO",
            "INATIVO"});
            this.txtStatusMoto.Location = new System.Drawing.Point(113, 177);
            this.txtStatusMoto.Name = "txtStatusMoto";
            this.txtStatusMoto.Size = new System.Drawing.Size(158, 21);
            this.txtStatusMoto.TabIndex = 7;
            this.txtStatusMoto.Text = "ATIVO";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 128);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(30, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "CPF:";
            // 
            // txtCPFMoto
            // 
            this.txtCPFMoto.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCPFMoto.Location = new System.Drawing.Point(113, 125);
            this.txtCPFMoto.Mask = "99999999999";
            this.txtCPFMoto.Name = "txtCPFMoto";
            this.txtCPFMoto.Size = new System.Drawing.Size(158, 20);
            this.txtCPFMoto.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 102);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(26, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "RG:";
            // 
            // txtCNHMoto
            // 
            this.txtCNHMoto.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCNHMoto.Location = new System.Drawing.Point(113, 151);
            this.txtCNHMoto.Mask = "99999999999";
            this.txtCNHMoto.Name = "txtCNHMoto";
            this.txtCNHMoto.Size = new System.Drawing.Size(158, 20);
            this.txtCNHMoto.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "NASCIMENTO:";
            // 
            // txtRGMoto
            // 
            this.txtRGMoto.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtRGMoto.Location = new System.Drawing.Point(113, 99);
            this.txtRGMoto.Mask = "999999999";
            this.txtRGMoto.Name = "txtRGMoto";
            this.txtRGMoto.Size = new System.Drawing.Size(158, 20);
            this.txtRGMoto.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "NOME:";
            // 
            // btnDelMoto
            // 
            this.btnDelMoto.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDelMoto.Location = new System.Drawing.Point(14, 317);
            this.btnDelMoto.Name = "btnDelMoto";
            this.btnDelMoto.Size = new System.Drawing.Size(257, 23);
            this.btnDelMoto.TabIndex = 12;
            this.btnDelMoto.Text = "EXCLUIR";
            this.btnDelMoto.UseVisualStyleBackColor = true;
            this.btnDelMoto.Click += new System.EventHandler(this.BtnDelMoto_Click);
            // 
            // txtDataNascMoto
            // 
            this.txtDataNascMoto.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDataNascMoto.Location = new System.Drawing.Point(113, 73);
            this.txtDataNascMoto.Mask = "00/00/0000";
            this.txtDataNascMoto.Name = "txtDataNascMoto";
            this.txtDataNascMoto.Size = new System.Drawing.Size(158, 20);
            this.txtDataNascMoto.TabIndex = 3;
            this.txtDataNascMoto.ValidatingType = typeof(System.DateTime);
            // 
            // btnEditMoto
            // 
            this.btnEditMoto.AccessibleDescription = "Primeiro Pesquise para depois Editar!";
            this.btnEditMoto.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEditMoto.Enabled = false;
            this.btnEditMoto.Location = new System.Drawing.Point(14, 288);
            this.btnEditMoto.Name = "btnEditMoto";
            this.btnEditMoto.Size = new System.Drawing.Size(257, 23);
            this.btnEditMoto.TabIndex = 11;
            this.btnEditMoto.Text = "EDITAR";
            this.btnEditMoto.UseVisualStyleBackColor = true;
            this.btnEditMoto.Click += new System.EventHandler(this.BtnEditMoto_Click);
            // 
            // btnCadMoto
            // 
            this.btnCadMoto.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCadMoto.Location = new System.Drawing.Point(14, 259);
            this.btnCadMoto.Name = "btnCadMoto";
            this.btnCadMoto.Size = new System.Drawing.Size(257, 23);
            this.btnCadMoto.TabIndex = 10;
            this.btnCadMoto.Text = "CADASTRAR";
            this.btnCadMoto.UseVisualStyleBackColor = true;
            this.btnCadMoto.Click += new System.EventHandler(this.BtnCadMoto_Click);
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(16, 154);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(33, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "CNH:";
            // 
            // txtValCNHMoto
            // 
            this.txtValCNHMoto.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtValCNHMoto.Location = new System.Drawing.Point(113, 204);
            this.txtValCNHMoto.Mask = "00/00/0000";
            this.txtValCNHMoto.Name = "txtValCNHMoto";
            this.txtValCNHMoto.Size = new System.Drawing.Size(158, 20);
            this.txtValCNHMoto.TabIndex = 8;
            this.txtValCNHMoto.ValidatingType = typeof(System.DateTime);
            // 
            // txtNomeMoto
            // 
            this.txtNomeMoto.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNomeMoto.Location = new System.Drawing.Point(113, 47);
            this.txtNomeMoto.Name = "txtNomeMoto";
            this.txtNomeMoto.Size = new System.Drawing.Size(158, 20);
            this.txtNomeMoto.TabIndex = 2;
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(16, 180);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "STATUS:";
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(16, 207);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(89, 13);
            this.label8.TabIndex = 16;
            this.label8.Text = "VALIDADE CNH:";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.panel1);
            this.groupBox1.Controls.Add(this.panel2);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(631, 441);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "MOTORISTA";
            // 
            // TelaMotoristaa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(655, 463);
            this.Controls.Add(this.groupBox1);
            this.Name = "TelaMotoristaa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "TelaMotoristaa";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridMoto)).EndInit();
            this.panel2.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnExibListMoto;
        private System.Windows.Forms.DataGridView dataGridMoto;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.MaskedTextBox txtCPFMoto;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.MaskedTextBox txtCNHMoto;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MaskedTextBox txtRGMoto;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnDelMoto;
        private System.Windows.Forms.MaskedTextBox txtDataNascMoto;
        private System.Windows.Forms.Button btnEditMoto;
        private System.Windows.Forms.Button btnCadMoto;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.MaskedTextBox txtValCNHMoto;
        private System.Windows.Forms.TextBox txtNomeMoto;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox txtStatusMoto;
        private System.Windows.Forms.Button btnPesquisaMoto;
        private System.Windows.Forms.TextBox txtCodMoto;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnLimpar;
    }
}