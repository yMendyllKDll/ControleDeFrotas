using Modelo;
using System.Data;
using System.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DALPermissaoUsuario
    {
        private DALConexao conexao;
        public DALPermissaoUsuario(DALConexao cx)
        {
            this.conexao = cx;
        }

        public void Incluir(ModeloPermissaoUsuario modelo)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.CommandText = "INSERT INTO permissaousuario(usu_id, per_nomefrm, per_descricao, per_bloqueado, per_inserir, per_alterar, per_excluir, per_imprimir) " +
                "VALUES " + "(@usu_id, @per_nomefrm, @per_descricao, @per_bloqueado, @per_inserir, @per_alterar, @per_excluir, @per_imprimir); select @@IDENTITY;";
            cmd.Parameters.AddWithValue("@usu_id", modelo.UsuId);
            cmd.Parameters.AddWithValue("@per_nomefrm", modelo.PerNomefrm);
            cmd.Parameters.AddWithValue("@per_descricao", modelo.PerDescricao);
            cmd.Parameters.AddWithValue("@per_bloqueado", modelo.PerBloqueado);
            cmd.Parameters.AddWithValue("@per_inserir", modelo.PerInserir);
            cmd.Parameters.AddWithValue("@per_alterar", modelo.PerAlterar);
            cmd.Parameters.AddWithValue("@per_excluir", modelo.PerExcluir);
            cmd.Parameters.AddWithValue("@per_imprimir", modelo.PerImprimir);
            conexao.Conectar();
            modelo.PerId = Convert.ToInt32(cmd.ExecuteScalar());
            conexao.Desconectar();
        }

        public void ExcluirTudo(int codigo)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.CommandText = "Delete from permissaousuario where usu_id=@codigo;";
            cmd.Parameters.AddWithValue("@codigo", codigo);
            conexao.Conectar();
            cmd.ExecuteNonQuery();
            conexao.Desconectar();
        }

        public ModeloPermissaoUsuario CarregaModeloPermissaoUsuario(int codigo)
        {
            ModeloPermissaoUsuario modelo = new ModeloPermissaoUsuario();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.CommandText = "select * from permissaousuario where usu_id = @codigo";
            cmd.Parameters.AddWithValue("@codigo", codigo);
            conexao.Conectar();
            SqlDataReader registro = cmd.ExecuteReader();
            if (registro.HasRows)
            {
                registro.Read();
                modelo.PerAlterar = Convert.ToString(registro["per_alterar"]);
                modelo.PerBloqueado = Convert.ToString(registro["per_bloqueado"]);
                modelo.PerDescricao = Convert.ToString(registro["per_descricao"]);
                modelo.PerExcluir = Convert.ToString(registro["per_excluir"]);
                modelo.PerId = Convert.ToInt32(registro["per_id"]);
                modelo.PerImprimir = Convert.ToString(registro["per_imprimir"]);
                modelo.PerInserir = Convert.ToString(registro["per_inserir"]);
                modelo.PerNomefrm = Convert.ToString(registro["per_nomefrm"]);
                modelo.UsuId = Convert.ToInt32(registro["usu_id"]);
            }
            conexao.Desconectar();
            registro.Close();
            return modelo;
        }

        public DataTable Localizar(int codigo) //Preenche o DGV Dados com as Permissões
        {
            DataTable tabela = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select p.per_id,p.per_nomefrm,p.per_descricao,p.per_bloqueado,p.per_inserir,p.per_alterar,p.per_excluir,p.per_imprimir," +
                "u.usu_nome, u.usu_login, u.usu_id from usuario u inner join permissaousuario p on u.usu_id=p.usu_id where u.usu_id = " + codigo.ToString(), conexao.Stringconexao);
            da.Fill(tabela);
            da.Dispose();
            return tabela;
        }

        public DataTable LocalizarPermissao(int idUsuario, string NomeFormulario) //LOCALIZAR PARA A PREMISSÃO DO USUÁRIO PARA SER UTILIZADA NOS FORMULARIOS.
        {
            DataTable tabela = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select p.per_id, p.usu_id, u.usu_login,p.per_nomefrm, p.per_bloqueado, p.per_inserir, " +
                "p.per_alterar, p.per_excluir, p.per_imprimir from usuario u inner join permissaousuario p on u.usu_id=p.usu_id " + "where p.per_nomefrm ='" +
                NomeFormulario.ToString() + "' and p.usu_id = " + idUsuario.ToString(), conexao.Stringconexao);
            da.Fill(tabela);
            da.Dispose();
            return tabela;
        }
    }
}
