using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

    public class ClasseConexao
    {
        SqlConnection conexao = new SqlConnection();

        private SqlConnection conectar()
        {
            try
            {
            String strConexao = "Password=12345; Persist Security Info=True; User ID=sa; Initial Catalog=Teste; Data Source=" + Environment.MachineName+"\\SQLEXPRESS";
            conexao.ConnectionString = strConexao;
                conexao.Open();
                return conexao;
            }
            catch (Exception erro)
            {
                desconectar();
                return null;
            }
        }

        public void desconectar()
        {
            try
            {
                if ((conexao.State == ConnectionState.Open))
                {
                    conexao.Close();
                    conexao.Dispose();
                    conexao = null;
                }
            }
            catch (Exception erro) { }
        }

        public DataSet executa_sql(String comando_sql)
        {
            try
            {
                conectar();
                SqlDataAdapter adaptador = new SqlDataAdapter(comando_sql, conexao);
                DataSet ds = new DataSet();
                adaptador.Fill(ds);
                return ds;
            }
            catch (Exception erro)
            {
                return null;
            }
            finally
            {
                desconectar();
            }
        }

        public bool manutencao(String comando_sql) //incluir, alterar, excluir
        {
            try
            {
                conectar();
                SqlCommand comando = new SqlCommand();
                comando.CommandText = comando_sql;
                comando.Connection = conexao;
                conexao.Open();
                comando.ExecuteScalar();
                return true;
            }
            catch (Exception erro)
            {
                return false;
            }
            finally
            {
                desconectar();
            }
        }
    }
