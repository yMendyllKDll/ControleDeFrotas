using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace DAL
{
    public class Conexao
    {
        public static SqlConnection Conectar()
        {
            return new SqlConnection(@"Data Source=MENDY-PC\SQLEXPRESS;Initial Catalog=EOP_Demo;Integrated Security=True");
        }
    }
}
