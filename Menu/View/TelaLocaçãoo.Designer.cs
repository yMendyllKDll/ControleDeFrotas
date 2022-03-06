namespace Menu.View
{
    partial class TelaLocaçãoo
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
            this.btnExibirLista = new System.Windows.Forms.Button();
            this.dataGridLoca = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtCodLoca = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnPesqLoca = new System.Windows.Forms.Button();
            this.txtQntLoca = new System.Windows.Forms.TextBox();
            this.txtDataLoca = new System.Windows.Forms.MaskedTextBox();
            this.txtDataDevolucao = new System.Windows.Forms.MaskedTextBox();
            this.txtValorLoca = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtCodCliente = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtLocalRetirada = new System.Windows.Forms.TextBox();
            this.btnEditLoca = new System.Windows.Forms.Button();
            this.btnDelLoca = new System.Windows.Forms.Button();
            this.btnCadLoca = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridLoca)).BeginInit();
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
            this.groupBox1.Size = new System.Drawing.Size(639, 402);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "LOCAÇÃO";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.DodgerBlue;
            this.panel1.Controls.Add(this.btnExibirLista);
            this.panel1.Controls.Add(this.dataGridLoca);
            this.panel1.Location = new System.Drawing.Point(15, 19);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(284, 366);
            this.panel1.TabIndex = 0;
            // 
            // btnExibirLista
            // 
            this.btnExibirLista.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExibirLista.Location = new System.Drawing.Point(3, 331);
            this.btnExibirLista.Name = "btnExibirLista";
            this.btnExibirLista.Size = new System.Drawing.Size(278, 23);
            this.btnExibirLista.TabIndex = 2;
            this.btnExibirLista.Text = "ATUALIZAR LISTA";
            this.btnExibirLista.UseVisualStyleBackColor = true;
            this.btnExibirLista.Click += new System.EventHandler(this.btnExibirLista_Click);
            // 
            // dataGridLoca
            // 
            this.dataGridLoca.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridLoca.BackgroundColor = System.Drawing.Color.White;
            this.dataGridLoca.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridLoca.Location = new System.Drawing.Point(3, 4);
            this.dataGridLoca.Name = "dataGridLoca";
            this.dataGridLoca.Size = new System.Drawing.Size(278, 321);
            this.dataGridLoca.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.Color.DodgerBlue;
            this.panel2.Controls.Add(this.groupBox2);
            this.panel2.Location = new System.Drawing.Point(305, 19);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(320, 366);
            this.panel2.TabIndex = 3;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.txtCodLoca);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.btnLimpar);
            this.groupBox2.Controls.Add(this.btnPesqLoca);
            this.groupBox2.Controls.Add(this.txtQntLoca);
            this.groupBox2.Controls.Add(this.txtDataLoca);
            this.groupBox2.Controls.Add(this.txtDataDevolucao);
            this.groupBox2.Controls.Add(this.txtValorLoca);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.txtCodCliente);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.txtLocalRetirada);
            this.groupBox2.Controls.Add(this.btnEditLoca);
            this.groupBox2.Controls.Add(this.btnDelLoca);
            this.groupBox2.Controls.Add(this.btnCadLoca);
            this.groupBox2.Location = new System.Drawing.Point(15, 14);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(291, 349);
            this.groupBox2.TabIndex = 23;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "CADASTRO LOCAÇÃO";
            // 
            // txtCodLoca
            // 
            this.txtCodLoca.Location = new System.Drawing.Point(135, 19);
            this.txtCodLoca.Name = "txtCodLoca";
            this.txtCodLoca.Size = new System.Drawing.Size(132, 20);
            this.txtCodLoca.TabIndex = 66;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 13);
            this.label2.TabIndex = 65;
            this.label2.Text = "CÓDIGO LOCAÇÃO:";
            // 
            // btnLimpar
            // 
            this.btnLimpar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLimpar.Location = new System.Drawing.Point(19, 315);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(248, 23);
            this.btnLimpar.TabIndex = 64;
            this.btnLimpar.Text = "LIMPAR";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // btnPesqLoca
            // 
            this.btnPesqLoca.Location = new System.Drawing.Point(20, 199);
            this.btnPesqLoca.Name = "btnPesqLoca";
            this.btnPesqLoca.Size = new System.Drawing.Size(247, 23);
            this.btnPesqLoca.TabIndex = 63;
            this.btnPesqLoca.Text = "PESQUISAR";
            this.btnPesqLoca.UseVisualStyleBackColor = true;
            this.btnPesqLoca.Click += new System.EventHandler(this.btnPesqLoca_Click);
            // 
            // txtQntLoca
            // 
            this.txtQntLoca.Location = new System.Drawing.Point(135, 147);
            this.txtQntLoca.Name = "txtQntLoca";
            this.txtQntLoca.Size = new System.Drawing.Size(132, 20);
            this.txtQntLoca.TabIndex = 54;
            // 
            // txtDataLoca
            // 
            this.txtDataLoca.Location = new System.Drawing.Point(135, 68);
            this.txtDataLoca.Mask = "00/00/0000";
            this.txtDataLoca.Name = "txtDataLoca";
            this.txtDataLoca.Size = new System.Drawing.Size(132, 20);
            this.txtDataLoca.TabIndex = 53;
            this.txtDataLoca.ValidatingType = typeof(System.DateTime);
            // 
            // txtDataDevolucao
            // 
            this.txtDataDevolucao.Location = new System.Drawing.Point(135, 94);
            this.txtDataDevolucao.Mask = "00/00/0000";
            this.txtDataDevolucao.Name = "txtDataDevolucao";
            this.txtDataDevolucao.Size = new System.Drawing.Size(132, 20);
            this.txtDataDevolucao.TabIndex = 52;
            this.txtDataDevolucao.ValidatingType = typeof(System.DateTime);
            // 
            // txtValorLoca
            // 
            this.txtValorLoca.Location = new System.Drawing.Point(135, 173);
            this.txtValorLoca.Name = "txtValorLoca";
            this.txtValorLoca.Size = new System.Drawing.Size(132, 20);
            this.txtValorLoca.TabIndex = 51;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(17, 173);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(46, 13);
            this.label7.TabIndex = 50;
            this.label7.Text = "VALOR:";
            // 
            // txtCodCliente
            // 
            this.txtCodCliente.Location = new System.Drawing.Point(135, 42);
            this.txtCodCliente.Name = "txtCodCliente";
            this.txtCodCliente.Size = new System.Drawing.Size(132, 20);
            this.txtCodCliente.TabIndex = 49;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(17, 147);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(81, 13);
            this.label6.TabIndex = 48;
            this.label6.Text = "QUANTIDADE:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(17, 94);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(108, 13);
            this.label5.TabIndex = 47;
            this.label5.Text = "DATA DEVOLUÇÃO:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 68);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 13);
            this.label4.TabIndex = 46;
            this.label4.Text = "DATA LOCAÇÃO:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 121);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 13);
            this.label3.TabIndex = 45;
            this.label3.Text = "LOCAL RETIRADA:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 13);
            this.label1.TabIndex = 44;
            this.label1.Text = "CÓDIGO CLIENTE:";
            // 
            // txtLocalRetirada
            // 
            this.txtLocalRetirada.Location = new System.Drawing.Point(135, 121);
            this.txtLocalRetirada.Name = "txtLocalRetirada";
            this.txtLocalRetirada.Size = new System.Drawing.Size(132, 20);
            this.txtLocalRetirada.TabIndex = 43;
            // 
            // btnEditLoca
            // 
            this.btnEditLoca.Enabled = false;
            this.btnEditLoca.Location = new System.Drawing.Point(20, 257);
            this.btnEditLoca.Name = "btnEditLoca";
            this.btnEditLoca.Size = new System.Drawing.Size(247, 23);
            this.btnEditLoca.TabIndex = 33;
            this.btnEditLoca.Text = "EDITAR";
            this.btnEditLoca.UseVisualStyleBackColor = true;
            this.btnEditLoca.Click += new System.EventHandler(this.btnEditLoca_Click);
            // 
            // btnDelLoca
            // 
            this.btnDelLoca.Location = new System.Drawing.Point(20, 286);
            this.btnDelLoca.Name = "btnDelLoca";
            this.btnDelLoca.Size = new System.Drawing.Size(247, 23);
            this.btnDelLoca.TabIndex = 35;
            this.btnDelLoca.Text = "EXCLUIR";
            this.btnDelLoca.UseVisualStyleBackColor = true;
            this.btnDelLoca.Click += new System.EventHandler(this.btnDelLoca_Click);
            // 
            // btnCadLoca
            // 
            this.btnCadLoca.Location = new System.Drawing.Point(20, 228);
            this.btnCadLoca.Name = "btnCadLoca";
            this.btnCadLoca.Size = new System.Drawing.Size(247, 23);
            this.btnCadLoca.TabIndex = 36;
            this.btnCadLoca.Text = "CADASTRAR";
            this.btnCadLoca.UseVisualStyleBackColor = true;
            this.btnCadLoca.Click += new System.EventHandler(this.btnCadLoca_Click);
            // 
            // TelaLocaçãoo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(663, 424);
            this.Controls.Add(this.groupBox1);
            this.Name = "TelaLocaçãoo";
            this.Text = "TelaLocaçãoo";
            this.groupBox1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridLoca)).EndInit();
            this.panel2.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnExibirLista;
        private System.Windows.Forms.DataGridView dataGridLoca;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtQntLoca;
        private System.Windows.Forms.MaskedTextBox txtDataLoca;
        private System.Windows.Forms.MaskedTextBox txtDataDevolucao;
        private System.Windows.Forms.TextBox txtValorLoca;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtCodCliente;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtLocalRetirada;
        private System.Windows.Forms.Button btnEditLoca;
        private System.Windows.Forms.Button btnDelLoca;
        private System.Windows.Forms.Button btnCadLoca;
        private System.Windows.Forms.Button btnPesqLoca;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.TextBox txtCodLoca;
        private System.Windows.Forms.Label label2;
    }
}