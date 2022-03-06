using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class ModeloUsuario
    {
        //Atributo
        private int usu_id;
        //Propriedade publica
        public int UsuId
        {
            get { return this.usu_id; }
            set { this.usu_id = value; }
        }

        private string usu_nome;
        public string UsuNome
        {
            get { return this.usu_nome; }
            set { this.usu_nome = value; }
        }

        private string usu_login;
        public string UsuLogin
        {
            get { return this.usu_login; }
            set { this.usu_login = value; }
        }

        private string usu_grupo;
        public string UsuGrupo
        {
            get { return this.usu_grupo; }
            set { this.usu_grupo = value; }
        }

        private string usu_senha;
        public string UsuSenha
        {
            get { return this.usu_senha; }
            set { this.usu_senha = value; }
        }

        public ModeloUsuario()
        {
            this.UsuId = 0; this.UsuNome = ""; this.UsuLogin = ""; this.UsuGrupo = ""; this.UsuSenha = "";
        }
        public ModeloUsuario(int usuid, string usunome, string usulogin, string usugrupo, string ususenha)
        {
            this.UsuId = usuid; this.UsuNome = usunome; this.UsuLogin = usulogin; this.UsuGrupo = usugrupo; this.UsuSenha = ususenha;
        }
    }
}

