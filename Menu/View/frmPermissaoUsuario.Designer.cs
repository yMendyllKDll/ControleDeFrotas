namespace Menu.View
{
    partial class frmPermissaoUsuario
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
            this.txtUsuarioPesquisado = new System.Windows.Forms.TextBox();
            this.txtValor = new System.Windows.Forms.TextBox();
            this.btLocalizarPerm = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cbMim = new System.Windows.Forms.CheckBox();
            this.gbMarcarTodos = new System.Windows.Forms.GroupBox();
            this.cbMI = new System.Windows.Forms.CheckBox();
            this.cbMA = new System.Windows.Forms.CheckBox();
            this.cbME = new System.Windows.Forms.CheckBox();
            this.cbMB = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvDados = new System.Windows.Forms.DataGridView();
            this.per_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomefrm = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descricao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Bloqueado = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Inserir = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Alterar = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Excluir = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Imprimir = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.btCancelar = new System.Windows.Forms.Button();
            this.btSalvar = new System.Windows.Forms.Button();
            this.btLocalizar = new System.Windows.Forms.Button();
            this.btAlterar = new System.Windows.Forms.Button();
            this.btExcluir = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.gbMarcarTodos.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDados)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtUsuarioPesquisado
            // 
            this.txtUsuarioPesquisado.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtUsuarioPesquisado.Enabled = false;
            this.txtUsuarioPesquisado.Location = new System.Drawing.Point(6, 19);
            this.txtUsuarioPesquisado.Name = "txtUsuarioPesquisado";
            this.txtUsuarioPesquisado.Size = new System.Drawing.Size(170, 20);
            this.txtUsuarioPesquisado.TabIndex = 4;
            // 
            // txtValor
            // 
            this.txtValor.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtValor.Location = new System.Drawing.Point(13, 27);
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(476, 20);
            this.txtValor.TabIndex = 18;
            // 
            // btLocalizarPerm
            // 
            this.btLocalizarPerm.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btLocalizarPerm.Location = new System.Drawing.Point(495, 27);
            this.btLocalizarPerm.Name = "btLocalizarPerm";
            this.btLocalizarPerm.Size = new System.Drawing.Size(75, 20);
            this.btLocalizarPerm.TabIndex = 17;
            this.btLocalizarPerm.Text = "LOCALIZAR";
            this.btLocalizarPerm.UseVisualStyleBackColor = true;
            this.btLocalizarPerm.Click += new System.EventHandler(this.btLocalizarPerm_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 13);
            this.label1.TabIndex = 19;
            this.label1.Text = "CÓDIGO DO USUÁRIO:";
            // 
            // cbMim
            // 
            this.cbMim.AutoSize = true;
            this.cbMim.Location = new System.Drawing.Point(249, 19);
            this.cbMim.Name = "cbMim";
            this.cbMim.Size = new System.Drawing.Size(15, 14);
            this.cbMim.TabIndex = 4;
            this.cbMim.UseVisualStyleBackColor = true;
            this.cbMim.CheckedChanged += new System.EventHandler(this.cbMim_CheckedChanged);
            // 
            // gbMarcarTodos
            // 
            this.gbMarcarTodos.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbMarcarTodos.Controls.Add(this.cbMim);
            this.gbMarcarTodos.Controls.Add(this.cbMI);
            this.gbMarcarTodos.Controls.Add(this.cbMA);
            this.gbMarcarTodos.Controls.Add(this.cbME);
            this.gbMarcarTodos.Controls.Add(this.cbMB);
            this.gbMarcarTodos.Location = new System.Drawing.Point(272, 54);
            this.gbMarcarTodos.Name = "gbMarcarTodos";
            this.gbMarcarTodos.Size = new System.Drawing.Size(298, 44);
            this.gbMarcarTodos.TabIndex = 21;
            this.gbMarcarTodos.TabStop = false;
            this.gbMarcarTodos.Text = "MARCAR/DESMARCAR TODOS";
            // 
            // cbMI
            // 
            this.cbMI.AutoSize = true;
            this.cbMI.Location = new System.Drawing.Point(74, 19);
            this.cbMI.Name = "cbMI";
            this.cbMI.Size = new System.Drawing.Size(15, 14);
            this.cbMI.TabIndex = 3;
            this.cbMI.UseVisualStyleBackColor = true;
            this.cbMI.CheckedChanged += new System.EventHandler(this.cbMI_CheckedChanged);
            // 
            // cbMA
            // 
            this.cbMA.AutoSize = true;
            this.cbMA.Location = new System.Drawing.Point(134, 19);
            this.cbMA.Name = "cbMA";
            this.cbMA.Size = new System.Drawing.Size(15, 14);
            this.cbMA.TabIndex = 2;
            this.cbMA.UseVisualStyleBackColor = true;
            this.cbMA.CheckedChanged += new System.EventHandler(this.cbMA_CheckedChanged);
            // 
            // cbME
            // 
            this.cbME.AutoSize = true;
            this.cbME.Location = new System.Drawing.Point(191, 19);
            this.cbME.Name = "cbME";
            this.cbME.Size = new System.Drawing.Size(15, 14);
            this.cbME.TabIndex = 1;
            this.cbME.UseVisualStyleBackColor = true;
            this.cbME.CheckedChanged += new System.EventHandler(this.cbME_CheckedChanged);
            // 
            // cbMB
            // 
            this.cbMB.AutoSize = true;
            this.cbMB.Location = new System.Drawing.Point(17, 19);
            this.cbMB.Name = "cbMB";
            this.cbMB.Size = new System.Drawing.Size(15, 14);
            this.cbMB.TabIndex = 0;
            this.cbMB.UseVisualStyleBackColor = true;
            this.cbMB.CheckedChanged += new System.EventHandler(this.cbMB_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.txtUsuarioPesquisado);
            this.groupBox1.Location = new System.Drawing.Point(13, 54);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(253, 44);
            this.groupBox1.TabIndex = 20;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "PERMISSÃO PARA O USUÁRIO";
            // 
            // dgvDados
            // 
            this.dgvDados.AllowUserToAddRows = false;
            this.dgvDados.AllowUserToDeleteRows = false;
            this.dgvDados.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvDados.BackgroundColor = System.Drawing.Color.DodgerBlue;
            this.dgvDados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDados.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.per_id,
            this.nomefrm,
            this.descricao,
            this.Bloqueado,
            this.Inserir,
            this.Alterar,
            this.Excluir,
            this.Imprimir});
            this.dgvDados.Location = new System.Drawing.Point(13, 104);
            this.dgvDados.Name = "dgvDados";
            this.dgvDados.RowHeadersVisible = false;
            this.dgvDados.Size = new System.Drawing.Size(557, 224);
            this.dgvDados.TabIndex = 16;
            // 
            // per_id
            // 
            this.per_id.HeaderText = "perId";
            this.per_id.Name = "per_id";
            this.per_id.Visible = false;
            // 
            // nomefrm
            // 
            this.nomefrm.HeaderText = "nomefrm";
            this.nomefrm.Name = "nomefrm";
            this.nomefrm.Visible = false;
            // 
            // descricao
            // 
            this.descricao.HeaderText = "Formulário";
            this.descricao.Name = "descricao";
            this.descricao.Width = 250;
            // 
            // Bloqueado
            // 
            this.Bloqueado.HeaderText = "Bloqueado";
            this.Bloqueado.Name = "Bloqueado";
            this.Bloqueado.Width = 60;
            // 
            // Inserir
            // 
            this.Inserir.HeaderText = "Inserir";
            this.Inserir.Name = "Inserir";
            this.Inserir.Width = 60;
            // 
            // Alterar
            // 
            this.Alterar.HeaderText = "Alterar";
            this.Alterar.Name = "Alterar";
            this.Alterar.Width = 60;
            // 
            // Excluir
            // 
            this.Excluir.HeaderText = "Excluir";
            this.Excluir.Name = "Excluir";
            this.Excluir.Width = 60;
            // 
            // Imprimir
            // 
            this.Imprimir.HeaderText = "Imprimir";
            this.Imprimir.Name = "Imprimir";
            this.Imprimir.Width = 60;
            // 
            // btCancelar
            // 
            this.btCancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCancelar.Location = new System.Drawing.Point(441, 3);
            this.btCancelar.Name = "btCancelar";
            this.btCancelar.Size = new System.Drawing.Size(82, 46);
            this.btCancelar.TabIndex = 5;
            this.btCancelar.Text = "CANCELAR";
            this.btCancelar.UseVisualStyleBackColor = true;
            this.btCancelar.Click += new System.EventHandler(this.btCancelar_Click);
            // 
            // btSalvar
            // 
            this.btSalvar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btSalvar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSalvar.Location = new System.Drawing.Point(342, 3);
            this.btSalvar.Name = "btSalvar";
            this.btSalvar.Size = new System.Drawing.Size(75, 46);
            this.btSalvar.TabIndex = 4;
            this.btSalvar.Text = "SALVAR";
            this.btSalvar.UseVisualStyleBackColor = true;
            this.btSalvar.Click += new System.EventHandler(this.btSalvar_Click);
            // 
            // btLocalizar
            // 
            this.btLocalizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btLocalizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btLocalizar.Location = new System.Drawing.Point(136, 3);
            this.btLocalizar.Name = "btLocalizar";
            this.btLocalizar.Size = new System.Drawing.Size(83, 46);
            this.btLocalizar.TabIndex = 1;
            this.btLocalizar.Text = "LOCALIZAR";
            this.btLocalizar.UseVisualStyleBackColor = true;
            this.btLocalizar.Click += new System.EventHandler(this.btLocalizar_Click);
            // 
            // btAlterar
            // 
            this.btAlterar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btAlterar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btAlterar.Location = new System.Drawing.Point(37, 3);
            this.btAlterar.Name = "btAlterar";
            this.btAlterar.Size = new System.Drawing.Size(75, 46);
            this.btAlterar.TabIndex = 2;
            this.btAlterar.Text = "ALTERAR";
            this.btAlterar.UseVisualStyleBackColor = true;
            this.btAlterar.Click += new System.EventHandler(this.btAlterar_Click);
            // 
            // btExcluir
            // 
            this.btExcluir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btExcluir.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btExcluir.Location = new System.Drawing.Point(243, 3);
            this.btExcluir.Name = "btExcluir";
            this.btExcluir.Size = new System.Drawing.Size(75, 46);
            this.btExcluir.TabIndex = 3;
            this.btExcluir.Text = "EXCLUIR";
            this.btExcluir.UseVisualStyleBackColor = true;
            this.btExcluir.Click += new System.EventHandler(this.btExcluir_Click);
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.Color.DodgerBlue;
            this.panel2.Controls.Add(this.btCancelar);
            this.panel2.Controls.Add(this.btSalvar);
            this.panel2.Controls.Add(this.btLocalizar);
            this.panel2.Controls.Add(this.btAlterar);
            this.panel2.Controls.Add(this.btExcluir);
            this.panel2.Location = new System.Drawing.Point(13, 334);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(557, 52);
            this.panel2.TabIndex = 15;
            // 
            // frmPermissaoUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(581, 396);
            this.Controls.Add(this.txtValor);
            this.Controls.Add(this.btLocalizarPerm);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gbMarcarTodos);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgvDados);
            this.Controls.Add(this.panel2);
            this.Name = "frmPermissaoUsuario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CADASTRO DE PERMISSÃO DE USUÁRIO";
            this.Load += new System.EventHandler(this.frmPermissaoUsuario_Load);
            this.gbMarcarTodos.ResumeLayout(false);
            this.gbMarcarTodos.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDados)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtUsuarioPesquisado;
        private System.Windows.Forms.TextBox txtValor;
        private System.Windows.Forms.Button btLocalizarPerm;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox cbMim;
        private System.Windows.Forms.GroupBox gbMarcarTodos;
        private System.Windows.Forms.CheckBox cbMI;
        private System.Windows.Forms.CheckBox cbMA;
        private System.Windows.Forms.CheckBox cbME;
        private System.Windows.Forms.CheckBox cbMB;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvDados;
        private System.Windows.Forms.DataGridViewTextBoxColumn per_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomefrm;
        private System.Windows.Forms.DataGridViewTextBoxColumn descricao;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Bloqueado;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Inserir;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Alterar;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Excluir;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Imprimir;
        protected System.Windows.Forms.Button btCancelar;
        protected System.Windows.Forms.Button btSalvar;
        protected System.Windows.Forms.Button btLocalizar;
        protected System.Windows.Forms.Button btAlterar;
        protected System.Windows.Forms.Button btExcluir;
        protected System.Windows.Forms.Panel panel2;
    }
}