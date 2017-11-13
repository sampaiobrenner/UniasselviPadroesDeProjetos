using Npgsql;
using System;
using System.Windows.Forms;

namespace Empresa.Persistence
{
    public class PostgreSQL
    {
        private static NpgsqlConnection conexao = null;

        public PostgreSQL()
        {
            try
            {
                conexao = new NpgsqlConnection();

                conexao.ConnectionString = @"Host=127.0.0.1;
                                             Port=5432;
                                             Database=empresa;
                                             Username=postgres;
                                             Password=assevim;";

                conexao.Open();
            }
            catch (NpgsqlException e)
            {
                MessageBox.Show(e.Message);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        public static NpgsqlConnection Conexao
        {
            get
            {
                if (conexao == null)
                {
                    new PostgreSQL();
                }

                return conexao;
            }
        }

        public static void FecharConexao()
        {
            try
            {
                conexao.Close();
            }
            catch (NpgsqlException e)
            {
                MessageBox.Show(e.Message);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }
    }
}
