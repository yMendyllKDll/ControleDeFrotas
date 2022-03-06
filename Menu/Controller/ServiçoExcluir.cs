using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Menu.Model;

namespace Menu.Controller
{
    class ServiçoExcluir
    {
        public void ExcluirMoto(string cpf)
        {
            Banco bd = new Banco();
            string Query = "DELETE FROM tblMotorista WHERE CPF = '" + cpf + "'";
            bd.ExcluirBanco(Query);
        }
        public void ExcluirVei(string Placa)
        {
            Banco bd = new Banco();
            string Query = "DELETE FROM tblVeiculo WHERE Placa = '" + Placa + "'";
            bd.ExcluirBanco(Query);
        }
        public void ExcluirCliente(string CPFouCNPJ)
        {
            Banco bd = new Banco();
            string Query = "DELETE FROM tblClientes WHERE CPFouCNPJ = '" + CPFouCNPJ + "'";
            bd.ExcluirBanco(Query);
        }
        public void ExcluirViagem(int CodViagem)
        {
            Banco bd = new Banco();
            string Query = "DELETE FROM tblViagens WHERE CodViagem = '" + CodViagem + "'";
            bd.ExcluirBanco(Query);
        }

        public void ExcluirLoca(int CodLocacao)
        {
            Banco bd = new Banco();
            string Query = "DELETE FROM tblLocacao WHERE CodLocacao = '" + CodLocacao + "'";
            bd.ExcluirBanco(Query);
        }
        public void ExcluirSegMoto(int NumApolice)
        {
            Banco bd = new Banco();
            string Query = "DELETE FROM tblSeguroMoto WHERE NumApolice = '" + NumApolice + "'";
            bd.ExcluirBanco(Query);
        }
    }
}
