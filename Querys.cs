using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Forms_Academia
{
     class Querys
    {
        public static MySqlConnection conect_()
        {
            try
            {
                MySqlConnection conexao = new MySqlConnection("conexao com banco de dados");
                conexao.Open();
                return conexao;
            }
            catch (Exception ex) 
            {
                throw new Exception("erro",ex);
            }
            
        }

        public static DataTable query_retorno(string Query_)
        {
            try
            {
                DataTable dt = new DataTable();
                MySqlDataAdapter ponte;
                using (var cmd=conect_().CreateCommand())
                {
                    cmd.CommandText = Query_;
                    ponte = new MySqlDataAdapter(cmd);
                    ponte.Fill(dt);
                    return dt;
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Erro de comando", ex);
            }
        }

        public static void exe(string Query_)
        {
            try
            {
                using (var cmd = conect_().CreateCommand())
                {
                    cmd.CommandText = Query_;
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Erro de comando", ex);
            }
        }
    }
}
