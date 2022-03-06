using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class ModeloPermissaoUsuario
    {
        private int per_id;
        public int PerId
        {
            get { return this.per_id; }
            set { this.per_id = value; }
        }

        private int usu_id;
        public int UsuId
        {
            get { return this.usu_id; }
            set { this.usu_id = value; }
        }

        private String per_nomefrm;
        public string PerNomefrm
        {
            get { return this.per_nomefrm; }
            set { this.per_nomefrm = value; }
        }

        private string per_descricao;
        public string PerDescricao
        {
            get { return this.per_descricao; }
            set { this.per_descricao = value; }
        }

        private string per_bloqueado;
        public string PerBloqueado
        {
            get { return this.per_bloqueado; }
            set { this.per_bloqueado = value; }
        }

        private string per_inserir;
        public string PerInserir
        {
            get { return this.per_inserir; }
            set { this.per_inserir = value; }
        }

        private string per_alterar;
        public string PerAlterar
        {
            get { return this.per_alterar; }
            set { this.per_alterar = value; }
        }

        private string per_excluir;
        public string PerExcluir
        {
            get { return this.per_excluir; }
            set { this.per_excluir = value; }
        }

        private string per_imprimir;
        public string PerImprimir
        {
            get { return this.per_imprimir; }
            set { this.per_imprimir = value; }
        }
    }
}
