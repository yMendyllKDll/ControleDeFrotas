using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DAL;

namespace BLL
{
    public class BLLMotorista
    {
        private DALConexao conexao;
        public BLLMotorista(DALConexao cx)
        {
            this.conexao = cx;
        }
        public DataTable MotoristaLocalizar(int CodMoto)
        {
            DALMotorista DALobj = new DALMotorista(conexao);
            return DALobj.MotoristaLocalizar(CodMoto);
        }

        public DataTable ClienteLocalizar(int CodigoCliente)
        {
            DALMotorista DALobj = new DALMotorista(conexao);
            return DALobj.ClienteLocalizar(CodigoCliente);
        }

        public DataTable SeguroMotoristaLocalizar(int CodigoCliente)
        {
            DALMotorista DALobj = new DALMotorista(conexao);
            return DALobj.SeguroMotoristaLocalizar(CodigoCliente);
        }

        public DataTable LocacaoLocalizar(int CodigoCliente)
        {
            DALMotorista DALobj = new DALMotorista(conexao);
            return DALobj.LocacaoLocalizar(CodigoCliente);
        }

        public DataTable ViagemLocalizar(int CodigoCliente)
        {
            DALMotorista DALobj = new DALMotorista(conexao);
            return DALobj.ViagemLocalizar(CodigoCliente);
        }

        public DataTable VeiculoLocalizar(int CodigoCliente)
        {
            DALMotorista DALobj = new DALMotorista(conexao);
            return DALobj.VeiculoLocalizar(CodigoCliente);
        }
    }
}
