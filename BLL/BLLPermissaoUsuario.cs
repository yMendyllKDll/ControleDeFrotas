using DAL;
using Modelo;
using System.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class BLLPermissaoUsuario
    {
        private DALConexao conexao;
        public BLLPermissaoUsuario(DALConexao cx)
        {
            this.conexao = cx;
        }

        public void Incluir(ModeloPermissaoUsuario modelo)
        {
            if (modelo.PerDescricao.Trim().Length == 0)
            {
                throw new Exception(" A DESCRIÇÃO É OBRIGATÓRIA !!");
            }

            DALPermissaoUsuario DALobj = new DALPermissaoUsuario(conexao);
            DALobj.Incluir(modelo);
        }

        public void ExcluirTudo(int codigo)
        {
            DALPermissaoUsuario DALobj = new DALPermissaoUsuario(conexao);
            DALobj.ExcluirTudo(codigo);
        }

        public ModeloPermissaoUsuario CarregaModeloPermissaUsuario(int codigo)
        {
            DALPermissaoUsuario DALobj = new DALPermissaoUsuario(conexao);
            return DALobj.CarregaModeloPermissaoUsuario(codigo);
        }

        public DataTable Localizar(int codigo)
        {
            DALPermissaoUsuario DALobj = new DALPermissaoUsuario(conexao);
            return DALobj.Localizar(codigo);
        }

        public DataTable LocalizarPermissao(int idUsuario, string NomeFormulario)
        {
            DALPermissaoUsuario DALobj = new DALPermissaoUsuario(conexao);
            return DALobj.LocalizarPermissao(idUsuario, NomeFormulario);
        }
    }
}
