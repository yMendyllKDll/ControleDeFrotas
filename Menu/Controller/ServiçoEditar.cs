using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Menu.Model;

namespace Menu.Controller
{
    class ServiçoEditar
    {
        public void EditarMoto(string nome, string rg, string cpf, string cnh, string datacnh, string datanasc, string StatusMoto)
        {
            Banco bd = new Banco();
            string Query = "UPDATE tblMotorista SET Nome = '" + nome + "',dataNasc = '" + datanasc + "',RG = '" + rg + "', CNH = '" + cnh + "', ValCNH = '" + datacnh + "' WHERE CPF = '" + cpf + "'";
            bd.EditarBanco(Query);
        }
        public void EditarVei(string Marca, string Cor, string KMAtual, string Combustivel, string Renavam, string Chassi, string Modelo, string Ano, string SituacaoVei, string Placa, string Pneu)
        {
            Banco bd = new Banco();
            string Query = "UPDATE tblVeiculo SET Marca = '" + Marca + "',Cor = '" + Cor + "',KMAtual = '" + KMAtual + "', Combustivel = '" + Combustivel + "', Renavam = '" + Renavam + "', Chassi = '" + Chassi + "', Modelo = '" + Modelo + "', Ano = '" + Ano + "', SituacaoVei = '" + SituacaoVei + "', Pneu = '" + Pneu + "' WHERE Placa = '" + Placa + "'";
            bd.EditarBanco(Query);
        }
        public void EditarCliente(string Nome, string CPFouCNPJ, string Endereco, string Bairro, string Estado, string Categoria, string ValCCNH, string ValorPago, string StatusCliente)
        {
            Banco bd = new Banco();
            string Query = "UPDATE tblClientes SET Nome = '" + Nome + "',Endereco = '" + Endereco + "', Bairro = '" + Bairro + "', Estado = '" + Estado + "', Categoria = '" + Categoria + "', ValCCNH = '" + ValCCNH + "', ValorPago = '" + ValorPago + "', StatusCliente = '" + StatusCliente + "' WHERE CPFouCNPJ = '" + CPFouCNPJ +"'";
            bd.EditarBanco(Query);
        }

        public void EditarViagem(int CodViagem, int CodVVeiculo, int CodVMoto, string DataViagem, string EntregArEm, string EntregEEm, string Motivo, string Situacao)
        {
            Banco bd = new Banco();
            string Query = "UPDATE tblViagens SET CodVVeiculo = '" + CodVVeiculo + "',CodVMoto = '" + CodVMoto + "', DataViagem = '" + DataViagem + "', EntregArEm = '" + EntregArEm + "', EntregEEm = '" + EntregEEm + "', Motivo = '" + Motivo + "', Situacao = '" + Situacao + "' WHERE CodViagem = '" + CodViagem + "'";
            bd.EditarBanco(Query);
        }
        public void EditarLoca(int CodLocacao, int CodLCliente, string DataLocacao, string DataDevolucao, string LocalRetirada, string Quantidade, string ValorLocacao)
        {
            Banco bd = new Banco();
            string Query = "UPDATE tblLocacao SET CodLCliente = '" + CodLCliente + "',DataLocacao = '" + DataLocacao + "', DataDevolucao = '" + DataDevolucao + "', LocalRetirada = '" + LocalRetirada + "', Quantidade = '" + Quantidade + "', ValorLocacao = '" + ValorLocacao + "' WHERE CodLocacao = '" + CodLocacao + "'";
            bd.EditarBanco(Query);
        }

        public void EditarSegMoto(int NumApolice, string CPFMoto, string Seguradora, string Corretor, string DataInicioSM, string DataVencSM, string ValorSM, string SituacaoSM)
        {
            Banco bd = new Banco();
            string Query = "UPDATE tblSeguroMOto SET CPFMoto = '" + CPFMoto + "',Seguradora = '" + Seguradora + "', Corretor = '" + Corretor + "', DataInicioSM = '" + DataInicioSM + "', DataVencSM = '" + DataVencSM + "', ValorSM = '" + ValorSM + "', SituacaoSM = '" + SituacaoSM + "' WHERE NumApolice = '" + NumApolice + "'";
            bd.EditarBanco(Query);
        }
    }
}
