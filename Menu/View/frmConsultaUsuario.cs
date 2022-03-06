﻿using BLL;
using DAL;
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
    public partial class frmConsultaUsuario : Form
    {
        public int codigo = 0;
        public frmConsultaUsuario()
        {
            InitializeComponent();
        }
        public void CarregaTituloDgv()
        {
            dgvDados.Columns[0].HeaderText = "Código";
            dgvDados.Columns[0].Width = 60;
            dgvDados.Columns[1].HeaderText = "Nome Usuário";
            dgvDados.Columns[1].Width = 250;
            dgvDados.Columns[2].HeaderText = "Login";
            dgvDados.Columns[2].Width = 100;
            dgvDados.Columns[3].HeaderText = "Grupo";
            dgvDados.Columns[3].Width = 120;
            dgvDados.Columns[4].Visible = false;
        }
        private void btLocalizar_Click(object sender, EventArgs e)
        {
            DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
            BLLUsuario bll = new BLLUsuario(cx);
            dgvDados.DataSource = bll.Localizar(txtValor.Text);
            CarregaTituloDgv();
        }

        private void frmConsultaUsuario_DoubleClick(object sender, EventArgs e)
        {

        }

        private void dgvDados_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            codigo = Convert.ToInt32(dgvDados.Rows[e.RowIndex].Cells[0].Value);
            this.Close();
        }
    }
}
