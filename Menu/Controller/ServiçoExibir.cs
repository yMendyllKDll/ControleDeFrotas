using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Menu.Model;
using System.Data;

namespace Menu.Controller
{
    class ServiçoExibir
    {
        public DataTable ExibirMoto()
        {
            Banco bd = new Banco();
            DataTable dt = new DataTable();
            string Query = "Select CodMoto, Nome, CPF,StatusMoto From tblMotorista";
            dt = bd.ConsultarBanco(Query);
            return dt;
        }

        public string[] SelectMoto(string CPF)
        {
            string[] Dados = new string[8];
            Banco bd = new Banco();
            string Query = "Select CodMoto, Nome, RG, dataNasc, CNH, ValCNH,StatusMoto From tblMotorista WHERE CPF = '" + CPF + "'";
            Dados = bd.SelectMoto(Query); 
            return Dados;
        }

        public DataTable ExibirVei()
        {
            Banco bd = new Banco();
            DataTable dt = new DataTable();
            string Query = "Select CodVeiculo, Placa, Modelo, SituacaoVei From tblVeiculo";
            dt = bd.ConsultarBanco(Query);
            return dt;
        }

        public string[] SelectVei(string Placa)
        {
            string[] Dados = new string[12];
            Banco bd = new Banco();
            string Query = "Select CodVeiculo, Marca, Cor, KMAtual, Combustivel, Renavam, Chassi, Modelo, Ano, SituacaoVei, Pneu From tblVeiculo WHERE Placa = '" + Placa + "'";
            Dados = bd.SelectVei(Query);
            return Dados;
        }

        public DataTable ExibirCliente()
        {
            Banco bd = new Banco();
            DataTable dt = new DataTable();
            string Query = "Select CodCliente, Nome, CPFouCNPJ, StatusCliente From tblClientes;";
            dt = bd.ConsultarBanco(Query);
            return dt;
        }

        public string[] SelectCliente(string CPFouCNPJ)
        {
            string[] Dados = new string[9];
            Banco bd = new Banco();
            string Query = "Select CodCliente, Nome, Endereco, Bairro, Estado, Categoria, ValCCNH, ValorPago, StatusCliente From tblClientes WHERE CPFouCNPJ = '" + CPFouCNPJ + "'";
            Dados = bd.SelectCliente(Query);
            return Dados;
        }
        public DataTable ExibirViagem()
        {
            Banco bd = new Banco();
            DataTable dt = new DataTable();
            string Query = "Select CodViagem, CodVVeiculo, CodVMoto, Situacao From tblViagens";
            dt = bd.ConsultarBanco(Query);
            return dt;
        }

        public string[] SelectViagem(int CodViagem)
        {
            string[] Dados = new string[9];
            Banco bd = new Banco();
            string Query = "Select CodVVeiculo, CodVMoto, DataViagem, EntregArEm, EntregEEm, Motivo, Situacao From tblViagens WHERE CodViagem = '" + CodViagem + "'";
            Dados = bd.SelectCliente(Query);
            return Dados;
        }

        public DataTable ExibirLoca()
        {
            Banco bd = new Banco();
            DataTable dt = new DataTable();
            string Query = "Select CodLocacao, CodLCliente, DataLocacao, DataDevolucao From tblLocacao";
            dt = bd.ConsultarBanco(Query);
            return dt;
        }

        public string[] SelectLoca(int CodLocacao)
        {
            string[] Dados = new string[9];
            Banco bd = new Banco();
            string Query = "Select CodLCliente, DataLocacao, DataDevolucao, LocalRetirada, Quantidade, ValorLocacao From tblLocacao WHERE CodLocacao = '" + CodLocacao + "'";
            Dados = bd.SelectLoca(Query);
            return Dados;
        }

        public DataTable ExibirSegMoto()
        {
            Banco bd = new Banco();
            DataTable dt = new DataTable();
            string Query = "Select NumApolice, CPFMoto, Seguradora, DataVencSM, SituacaoSM From tblSeguroMoto";
            dt = bd.ConsultarBanco(Query);
            return dt;
        }

        public string[] SelectSegMoto(int NumApolice)
        {
            string[] Dados = new string[9];
            Banco bd = new Banco();
            string Query = "Select CPFMoto, Seguradora, Corretor, DataInicioSM, DataVencSM, ValorSM, SituacaoSM From tblSeguroMoto WHERE NumApolice = '" + NumApolice + "'";
            Dados = bd.SelectSegMoto(Query);
            return Dados;
        }

        public int SelectMax(string tblNome, string txtNome)
        {
            int Valor;
            Banco bd = new Banco();
            string Query = "SELECT MAX(" + txtNome + ") as Ultimo FROM " + tblNome;
            Valor = bd.SelectMax(Query);
            Valor = Valor + 1;
            return Valor;
        }
    }
}