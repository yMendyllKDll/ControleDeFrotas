using DAL;
using Modelo;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class BLLUsuario
    {
        private DALConexao conexao;
        public BLLUsuario(DALConexao ex)
        {
            this.conexao = ex;
        }

        public void Incluir(ModeloUsuario modelo)
        {
            if (modelo.UsuGrupo.Trim().Length == 0)
            {
                throw new Exception("O GRUPO DO USUÁRIO DEVE SER INFORMADO!");
            }
            if (modelo.UsuLogin.Trim().Length == 0)
            {
                throw new Exception("O LOGIN DO USUÁRIO DEVE SER INFORMADO!");
            }
            if (modelo.UsuNome.Trim().Length == 0)
            {
                throw new Exception("O NOME DO USUÁRIO DEVE SER INFORMADO!");
            }
            if (modelo.UsuSenha.Trim().Length == 0)
            {
                throw new Exception("A SENHA DO USUÁRIO DEVE SER INFORMADO!");
            }
            //Passa os dados para o DALUsuario para fazer a inclusão dos dados no banco de dados
            DALUsuario DALobj = new DALUsuario(conexao);
            DALobj.Incluir(modelo);
        }
        public void Alterar(ModeloUsuario modelo)
        {
            if (modelo.UsuGrupo.Trim().Length == 0)
            {
                throw new Exception("O GRUPO DO USUÁRIO DEVE SER INFORMADO!");
            }
            if (modelo.UsuLogin.Trim().Length == 0)
            {
                throw new Exception("O LOGIN DO USUÁRIO DEVE SER INFORMADO!");
            }
            if (modelo.UsuNome.Trim().Length == 0)
            {
                throw new Exception("O NOME DO USUÁRIO DEVE SER INFORMADO!");
            }
            if (modelo.UsuSenha.Trim().Length == 0)
            {
                throw new Exception("A SENHA DO USUÁRIO DEVE SER INFORMADO!");
            }
            if (modelo.UsuId <= 0)
            {
                throw new Exception("O CÓDIGO DO USUÁRIO DEVE SER INFORMADO!");
            }
            //Altera os dados
            DALUsuario DALobj = new DALUsuario(conexao);
            DALobj.Alterar(modelo);
        }
        public void Excluir(int codigo)
        {
            DALUsuario Dalobj = new DALUsuario(conexao);
            Dalobj.Excluir(codigo);
        }
        public ModeloUsuario CarregaModeloUsuario(int codigo)
        {
            DALUsuario DALobj = new DALUsuario(conexao);
            return DALobj.CarregaModeloUsuario(codigo);
        }
        public DataTable Localizar(int codigo)
        {
            DALUsuario DALobj = new DALUsuario(conexao);
            return DALobj.Localizar(codigo);
        }
        public DataTable Localizar(String nome)
        {
            DALUsuario DALobj = new DALUsuario(conexao);
            return DALobj.Localizar(nome);
        }
        public DataTable LocalizarUsuarioLogin(string login, string senha)
        {
            DALUsuario DALobj = new DALUsuario(conexao);
            return DALobj.LocalizarUsuarioLogin(login, senha);
        }
    }
}