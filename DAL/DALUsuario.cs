using Modelo;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DALUsuario
    {
        private DALConexao conexao;
        public DALUsuario(DALConexao ex)
        {
            this.conexao = ex;
        }
        public void Incluir(ModeloUsuario modelo)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.CommandText = "INSERT INTO usuario(usu_nome, usu_login, usu_grupo, usu_senha) VALUES " + "(@usu_nome, @usu_login, @usu_grupo, @usu_senha); select @@IDENTITY;";
            cmd.Parameters.AddWithValue("@usu_nome", modelo.UsuNome);
            cmd.Parameters.AddWithValue("@usu_login", modelo.UsuLogin);
            cmd.Parameters.AddWithValue("@usu_grupo", modelo.UsuGrupo);
            cmd.Parameters.AddWithValue("@usu_senha", modelo.UsuSenha);
            conexao.Conectar();
            modelo.UsuId = Convert.ToInt32(cmd.ExecuteScalar());
            conexao.Desconectar();
        }
        public void Alterar(ModeloUsuario modelo)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.CommandText = "UPDATE usuario SET usu_nome = @usu_nome, usu_login = @usu_login, usu_grupo = @usu_grupo, usu_senha = @usu_senha where usu_id = @codigo;";
            cmd.Parameters.AddWithValue("@codigo", modelo.UsuId);
            cmd.Parameters.AddWithValue("@usu_nome", modelo.UsuNome);
            cmd.Parameters.AddWithValue("@usu_login", modelo.UsuLogin);
            cmd.Parameters.AddWithValue("@usu_grupo", modelo.UsuGrupo);
            cmd.Parameters.AddWithValue("@usu_senha", modelo.UsuSenha);
            conexao.Conectar();
            cmd.ExecuteNonQuery();
            conexao.Desconectar();
        }
        public void Excluir(int codigo)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.CommandText = "Delete from usuario where usu_id=@codigo;";
            cmd.Parameters.AddWithValue("@codigo", codigo);
            conexao.Conectar();
            cmd.ExecuteNonQuery();
            conexao.Desconectar();
        }
        public ModeloUsuario CarregaModeloUsuario(int codigo)
        {
            ModeloUsuario modelo = new ModeloUsuario();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.CommandText = "select * from usuario where usu_id = @codigo";
            cmd.Parameters.AddWithValue("@codigo", codigo);
            conexao.Conectar();
            SqlDataReader registro = cmd.ExecuteReader();
            if (registro.HasRows)
            {
                registro.Read();
                modelo.UsuId = Convert.ToInt32(registro["usu_id"]);
                modelo.UsuGrupo = Convert.ToString(registro["usu_grupo"]);
                modelo.UsuLogin = Convert.ToString(registro["usu_login"]);
                modelo.UsuNome = Convert.ToString(registro["usu_nome"]);
                modelo.UsuSenha = Convert.ToString(registro["usu_senha"]);
            }
            conexao.Desconectar();
            registro.Close();
            return modelo;
        }
        public DataTable Localizar(int codigo)
        {
            DataTable tabela = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select * from usuario where usu_id =" + codigo.ToString(), conexao.ObjetoConexao);
            da.Fill(tabela);
            da.Dispose();
            return tabela;
        }
        public DataTable Localizar(string nome)
        {
            DataTable tabela = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select * from usuario where usu_nome like '%" + nome.ToString() + "%' OR usu_login like '%" + nome.ToString() + "%'", conexao.ObjetoConexao);
            da.Fill(tabela);
            da.Dispose();
            return tabela;
        }
        public DataTable LocalizarUsuarioLogin(string login, string senha)
        {
            DataTable tabela = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select * from usuario where usu_login = '" + login.ToString() +
                "' COLLATE SQL_Latin1_General_CP1_CS_AS AND usu_senha = '" + senha.ToString() + "'", conexao.Stringconexao);
            da.Fill(tabela);
            da.Dispose();
            return tabela;
        }
    }
}
