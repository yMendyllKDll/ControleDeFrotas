using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Menu.Model;

namespace Menu.Controller
{
    class ServiçoCadastros
    {
        public void CadastrarMoto(int CodMoto, string nome, string rg, string cpf, string cnh, string datacnh, string datanasc, string StatusMoto)
        {
            Banco bd = new Banco();
            string Query = "INSERT INTO tblMotorista (CodMoto, Nome, datanasc, RG, CPF, CNH, ValCNH, StatusMoto) VALUES (" + CodMoto + ",'" + nome + "','" + datanasc + "','" + rg + "','" + cpf + "','" + cnh + "','" + datacnh + "','" + StatusMoto + "')";
            bd.CadastrarBanco(Query);
        }

        public void CadastrarVei(int CodVeiculo, string Marca, string Cor, string KMAtual, string Combustivel, string Renavam, string Chassi, string Modelo, string Ano, string SituacaoVei, string Placa, string Pneu)
        {
            Banco bd = new Banco();
            string Query = "INSERT INTO tblVeiculo (CodVeiculo, Marca, Cor, KMAtual, Combustivel, Renavam, Chassi, Modelo, Ano, SituacaoVei, Placa, Pneu) VALUES (" + CodVeiculo + ",'" + Marca + "','" + Cor + "','" + KMAtual + "','" + Combustivel + "','" + Renavam + "','" + Chassi + "','" + Modelo + "','" + Ano + "','" + SituacaoVei + "','" + Placa + "','" + Pneu + "')";
            bd.CadastrarBanco(Query);
        }

        public void CadastrarCliente(int CodCliente, string Nome, string CPFouCNPJ, string Endereco, string Bairro, string Estado, string Categoria, string ValCCNH, string ValorPago, string StatusCliente)
        {
            Banco bd = new Banco();
            string Query = "INSERT INTO tblClientes (CodCliente, Nome, CPFouCNPJ, Endereco, Bairro, Estado, Categoria, ValCCNH, ValorPago, StatusCliente) VALUES (" + CodCliente + ",'" + Nome + "','" + CPFouCNPJ + "','" + Endereco + "','" + Bairro + "','" + Estado + "','" + Categoria + "','" + ValCCNH + "','" + ValorPago + "','" + StatusCliente + "')";
            bd.CadastrarBanco(Query);
        }

        public void CadastrarViagem(int CodViagem, int CodVVeiculo, int CodVMoto, string DataViagem, string EntregArEm, string EntregEEm, string Motivo, string Situacao)
        {
            Banco bd = new Banco();
            string Query = "INSERT INTO tblViagens (CodViagem, CodVVeiculo, CodVMoto, DataViagem, EntregArEm, EntregEEm, Motivo, Situacao) VALUES (" + CodViagem + ",'" + CodVVeiculo + "','" + CodVMoto + "','" + DataViagem + "','" + EntregArEm + "','" + EntregEEm + "','" + Motivo + "','" + Situacao + "')";
            bd.CadastrarBanco(Query);
        }
        public void CadastrarLoca(int CodLocacao, int CodLCliente, string DataLocacao, string DataDevolucao, string LocalRetirada, string Quantidade, string ValorLocacao)
        {
            Banco bd = new Banco();
            string Query = "INSERT INTO tblLocacao (CodLocacao, CodLCliente, DataLocacao, DataDevolucao, LocalRetirada, Quantidade, ValorLocacao) VALUES (" + CodLocacao + ",'" + CodLCliente + "','" + DataLocacao + "','" + DataDevolucao + "','" + LocalRetirada + "','" + Quantidade + "','" + ValorLocacao + "')";
            bd.CadastrarBanco(Query);
        }

        public void CadastrarSegMoto(int NumApolice, string CPFMoto, string Seguradora, string Corretor, string DataInicioSM, string DataVencSM, string ValorSM, string SituacaoSM)
        {
            Banco bd = new Banco();
            string Query = "INSERT INTO tblSeguroMoto (NumApolice, CPFMoto, Seguradora, Corretor, DataInicioSM, DataVencSM, ValorSM, SituacaoSM) VALUES (" + NumApolice + ",'" + CPFMoto + "','" + Seguradora + "','" + Corretor + "','" + DataInicioSM + "','" + DataVencSM + "','" + ValorSM + "','" + SituacaoSM + "')";
            bd.CadastrarBanco(Query);
        }
    }
}
