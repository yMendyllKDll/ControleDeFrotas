using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace DAL
{
    public class DALMotorista
    {
        private DALConexao conexao;
        public DALMotorista(DALConexao cx)
        {
            this.conexao = cx;
        }

        public DataTable MotoristaLocalizar(int CodMoto)
        {
            DataTable tabela = new DataTable();                         /*where CodMoto = " + CodigoCliente.ToString()*/
            SqlDataAdapter da = new SqlDataAdapter("select * from tblMotorista", conexao.ObjetoConexao);
            da.Fill(tabela);
            da.Dispose();
            return tabela;
        }

        public DataTable ClienteLocalizar(int CodigoCliente)
        {
            DataTable tabela = new DataTable(); /*where CodCliente = " + CodigoCliente.ToString()*/
            SqlDataAdapter da = new SqlDataAdapter("select * from tblClientes" , conexao.ObjetoConexao);
            da.Fill(tabela);
            da.Dispose();
            return tabela;
        }

        public DataTable SeguroMotoristaLocalizar(int CodigoCliente)
        {
            DataTable tabela = new DataTable(); /*where NumApolice = " + CodigoCliente.ToString()*/
            SqlDataAdapter da = new SqlDataAdapter("select * from tblSeguroMoto ", conexao.ObjetoConexao);
            da.Fill(tabela);
            da.Dispose();
            return tabela;
        }

        public DataTable LocacaoLocalizar(int CodigoCliente)
        {
            DataTable tabela = new DataTable(); /*where CodLocacao = " + CodigoCliente.ToString()*/
            SqlDataAdapter da = new SqlDataAdapter("select * from tblLocacao ", conexao.ObjetoConexao);
            da.Fill(tabela);
            da.Dispose();
            return tabela;
        }

        public DataTable ViagemLocalizar(int CodigoCliente)
        {
            DataTable tabela = new DataTable();/* where CodViagem = " + CodigoCliente.ToString()*/
            SqlDataAdapter da = new SqlDataAdapter("select * from tblViagens ", conexao.ObjetoConexao);
            da.Fill(tabela);
            da.Dispose();
            return tabela;
        }

        public DataTable VeiculoLocalizar(int CodigoCliente)
        {
            DataTable tabela = new DataTable(); /*where CodVeiculo = " + CodigoCliente.ToString()*/
            SqlDataAdapter da = new SqlDataAdapter("select * from tblVeiculo ", conexao.ObjetoConexao);
            da.Fill(tabela);
            da.Dispose();
            return tabela;
        }
    }
}
