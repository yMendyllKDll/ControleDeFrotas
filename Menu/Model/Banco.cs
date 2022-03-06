using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Menu.Model
{
    class Banco
    {
        public void CadastrarBanco(string QuerySql)
        {
            string strConBanco = @"Data Source=MENDY-PC\SQLEXPRESS;Initial Catalog=EOP_Demo;Integrated Security=True";
            //string strConBanco = @"Data Source=WAR;Initial Catalog=EOP_Demo;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
            string query = QuerySql;

            SqlConnection sqlCon = new SqlConnection(strConBanco);
            SqlCommand sqlCommand = new SqlCommand(query, sqlCon);

            try
            {
                sqlCon.Open();
                sqlCommand.ExecuteNonQuery();
                MessageBox.Show("Cadastro Efetuado!");
            }

            catch (Exception ex )
            {
                string erro = "Ops, ocorreu um erro! Cadastro Não Efetuado";
                MessageBox.Show(erro + " " + ex);
            }
            finally
            {
                sqlCon.Close();
            }

        }

        public DataTable ConsultarBanco(string QuerySql)
        {
            string strConBanco = @"Data Source=MENDY-PC\SQLEXPRESS;Initial Catalog=EOP_Demo;Integrated Security=True";
            //string strConBanco = @"Data Source=WAR;Initial Catalog=EOP_Demo;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
            string query = QuerySql;
            SqlConnection sqlCon = new SqlConnection(strConBanco);
            SqlCommand sqlCommand = new SqlCommand(query, sqlCon);
            DataTable dt = new DataTable();

            try
            {
                sqlCon.Open();
                DataSet ds = new DataSet();
                SqlDataAdapter da = new SqlDataAdapter(sqlCommand);

                da.Fill(ds);
                dt = ds.Tables[0];
            }

            catch (Exception err)
            {
                string erro = "Ops, ocorreu um erro! ";
                MessageBox.Show(erro+ " " +err);
            }
            finally
            {
                sqlCon.Close();
            }
            return dt;

        }

        public void EditarBanco(string QuerySql)
        {
            string strConBanco = @"Data Source=MENDY-PC\SQLEXPRESS;Initial Catalog=EOP_Demo;Integrated Security=True";
            //string strConBanco = @"Data Source=WAR;Initial Catalog=EOP_Demo;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
            string query = QuerySql;

            SqlConnection sqlCon = new SqlConnection(strConBanco);
            SqlCommand sqlCommand = new SqlCommand(query, sqlCon);

            try
            {
                sqlCon.Open();
                sqlCommand.ExecuteNonQuery();
                MessageBox.Show("Cadastro Editado!");
            }

            catch (Exception ex)
            {
                string erro = "Ops, ocorreu um erro! Edição Não Efetuada";
                MessageBox.Show(erro + ex);
            }
            finally
            {
                sqlCon.Close();
            }

        }
        
        public void ExcluirBanco(string QuerySql)
        {
            string strConBanco = @"Data Source=MENDY-PC\SQLEXPRESS;Initial Catalog=EOP_Demo;Integrated Security=True";
            //string strConBanco = @"Data Source=WAR;Initial Catalog=EOP_Demo;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
            string query = QuerySql;

            SqlConnection sqlCon = new SqlConnection(strConBanco);
            SqlCommand sqlCommand = new SqlCommand(query, sqlCon);

            try
            {
                sqlCon.Open();
                sqlCommand.ExecuteNonQuery();
                MessageBox.Show("Cadastro Excluido!");
            }

            catch (Exception ex)
            {
                string erro = "Ops, ocorreu um erro! Exclusão Não Efetuada";
                MessageBox.Show(erro + ex);
            }
            finally
            {
                sqlCon.Close();
            }
        }

        public string[] SelectMoto(string QuerySql)
        {
            string strConBanco = @"Data Source=MENDY-PC\SQLEXPRESS;Initial Catalog=EOP_Demo;Integrated Security=True";
            //string strConBanco = @"Data Source=WAR;Initial Catalog=EOP_Demo;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
            string query = QuerySql;
            SqlConnection sqlCon = new SqlConnection(strConBanco);
            SqlCommand sqlCommand = new SqlCommand(query, sqlCon);
            string[] Dados = new string[7];
            try
            {
                sqlCon.Open();
                SqlDataReader dr = sqlCommand.ExecuteReader();
                if (dr.HasRows == false)
                {
                    throw new Exception("Não foi encontrado nem um Registro desse dado no Banco");
                }
                dr.Read();
                Dados[0] = Convert.ToString(dr["Nome"]);
                Dados[1] = Convert.ToString(dr["dataNasc"]);
                Dados[2] = Convert.ToString(dr["RG"]);
                Dados[3] = Convert.ToString(dr["CodMoto"]);
                Dados[4] = Convert.ToString(dr["CNH"]);
                Dados[5] = Convert.ToString(dr["ValCNH"]);
                Dados[6] = Convert.ToString(dr["StatusMoto"]);

            }

            catch (Exception err)
            {
                string erro = "Ops, ocorreu um erro! " + err;
                MessageBox.Show(erro);
            }
            finally
            {
                sqlCon.Close();
            }
            return Dados;

        }
        public string[] SelectVei(string QuerySql)
        {
            string strConBanco = @"Data Source=MENDY-PC\SQLEXPRESS;Initial Catalog=EOP_Demo;Integrated Security=True";
            //string strConBanco = @"Data Source=WAR;Initial Catalog=EOP_Demo;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
            string query = QuerySql;
            SqlConnection sqlCon = new SqlConnection(strConBanco);
            SqlCommand sqlCommand = new SqlCommand(query, sqlCon);
            string[] Dados = new string[11];
            try
            {
                sqlCon.Open();
                SqlDataReader dr = sqlCommand.ExecuteReader();
                if (dr.HasRows == false)
                {
                    throw new Exception("Não foi encontrado nem um Registro desse dado no Banco");
                }
                dr.Read();
                Dados[0] = Convert.ToString(dr["CodVeiculo"]);
                Dados[1] = Convert.ToString(dr["Marca"]);
                Dados[2] = Convert.ToString(dr["Cor"]);
                Dados[3] = Convert.ToString(dr["KMAtual"]);
                Dados[4] = Convert.ToString(dr["Combustivel"]);
                Dados[5] = Convert.ToString(dr["Renavam"]);
                Dados[6] = Convert.ToString(dr["Chassi"]);
                Dados[7] = Convert.ToString(dr["Modelo"]);
                Dados[8] = Convert.ToString(dr["Ano"]);
                Dados[9] = Convert.ToString(dr["SituacaoVei"]);
                Dados[10] = Convert.ToString(dr["Pneu"]);

            }

            catch (Exception err)
            {
                string erro = "Ops, ocorreu um erro! " + err;
                MessageBox.Show(erro);
            }
            finally
            {
                sqlCon.Close();
            }
            return Dados;

        }

        public string[] SelectCliente(string QuerySql)
        {
            string strConBanco = @"Data Source=MENDY-PC\SQLEXPRESS;Initial Catalog=EOP_Demo;Integrated Security=True";
            //string strConBanco = @"Data Source=WAR;Initial Catalog=EOP_Demo;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
            string query = QuerySql;

            SqlConnection sqlCon = new SqlConnection(strConBanco);
            SqlCommand sqlCommand = new SqlCommand(query, sqlCon);
            string[] Dados = new string[7];
            try
            {
                sqlCon.Open();
                SqlDataReader dr = sqlCommand.ExecuteReader();
                if (dr.HasRows == false)
                {
                    throw new Exception("Não foi encontrado nem um Registro desse dado no Banco");
                }
                dr.Read();
                Dados[0] = Convert.ToString(dr["CodVVeiculo"]);
                Dados[1] = Convert.ToString(dr["CodVMoto"]);
                Dados[2] = Convert.ToString(dr["DataViagem"]);
                Dados[3] = Convert.ToString(dr["EntregArEm"]);
                Dados[4] = Convert.ToString(dr["EntregEEm"]);
                Dados[5] = Convert.ToString(dr["Motivo"]);
                Dados[6] = Convert.ToString(dr["Situacao"]);
            }

            catch (Exception err)
            {
                string erro = "Ops, ocorreu um erro! " + err;
                MessageBox.Show(erro);
            }
            finally
            {
                sqlCon.Close();
            }
            return Dados;

        }

        public string[] SelectLoca(string QuerySql)
        {
            string strConBanco = @"Data Source=MENDY-PC\SQLEXPRESS;Initial Catalog=EOP_Demo;Integrated Security=True";
            //string strConBanco = @"Data Source=WAR;Initial Catalog=EOP_Demo;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
            string query = QuerySql;

            SqlConnection sqlCon = new SqlConnection(strConBanco);
            SqlCommand sqlCommand = new SqlCommand(query, sqlCon);
            string[] Dados = new string[6];
            try
            {
                sqlCon.Open();
                SqlDataReader dr = sqlCommand.ExecuteReader();
                if (dr.HasRows == false)
                {
                    throw new Exception("Não foi encontrado nem um Registro desse dado no Banco");
                }
                dr.Read();
                Dados[0] = Convert.ToString(dr["CodLCliente"]);
                Dados[1] = Convert.ToString(dr["DataLocacao"]);
                Dados[2] = Convert.ToString(dr["DataDevolucao"]);
                Dados[3] = Convert.ToString(dr["LocalRetirada"]);
                Dados[4] = Convert.ToString(dr["Quantidade"]);
                Dados[5] = Convert.ToString(dr["ValorLocacao"]);
            }

            catch (Exception err)
            {
                string erro = "Ops, ocorreu um erro! " + err;
                MessageBox.Show(erro);
            }
            finally
            {
                sqlCon.Close();
            }
            return Dados;

        }

        public string[] SelectSegMoto(string QuerySql)
        {
            string strConBanco = @"Data Source=MENDY-PC\SQLEXPRESS;Initial Catalog=EOP_Demo;Integrated Security=True";
            //string strConBanco = @"Data Source=WAR;Initial Catalog=EOP_Demo;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
            string query = QuerySql;

            SqlConnection sqlCon = new SqlConnection(strConBanco);
            SqlCommand sqlCommand = new SqlCommand(query, sqlCon);
            string[] Dados = new string[7];
            try
            {
                sqlCon.Open();
                SqlDataReader dr = sqlCommand.ExecuteReader();
                if (dr.HasRows == false)
                {
                    throw new Exception("Não foi encontrado nem um Registro desse dado no Banco");
                }
                dr.Read();
                Dados[0] = Convert.ToString(dr["CPFMoto"]);
                Dados[1] = Convert.ToString(dr["Seguradora"]);
                Dados[2] = Convert.ToString(dr["Corretor"]);
                Dados[3] = Convert.ToString(dr["DataInicioSM"]);
                Dados[4] = Convert.ToString(dr["DataVencSM"]);
                Dados[5] = Convert.ToString(dr["ValorSM"]);
                Dados[6] = Convert.ToString(dr["SituacaoSM"]);
            }

            catch (Exception err)
            {
                string erro = "Ops, ocorreu um erro! " + err;
                MessageBox.Show(erro);
            }
            finally
            {
                sqlCon.Close();
            }
            return Dados;

        }

        public int SelectMax(string QuerySql)
        {
            string strConBanco = @"Data Source=MENDY-PC\SQLEXPRESS;Initial Catalog=EOP_Demo;Integrated Security=True";
            //string strConBanco = @"Data Source=WAR;Initial Catalog=EOP_Demo;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
            string query = QuerySql;

            SqlConnection sqlCon = new SqlConnection(strConBanco);
            SqlCommand sqlCommand = new SqlCommand(query, sqlCon);
            int Max = 0;
            try
            {
                sqlCon.Open();
                SqlDataReader dr = sqlCommand.ExecuteReader();
                if (!dr.HasRows)
                {
                    throw new Exception("Não foi encontrado nem um Registro desse dado no Banco");
                }
                dr.Read();
                if (!String.IsNullOrEmpty(dr["Ultimo"].ToString()))
                Max = Convert.ToInt32(dr["Ultimo"]);

            }

            catch (Exception err)
            {
                string erro = "Ops, ocorreu um erro! " + err;
                MessageBox.Show(erro);
            }
            finally
            {
                sqlCon.Close();
            }
            return Max;

        }
    }
}
