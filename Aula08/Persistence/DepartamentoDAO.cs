using Empresa.Model;
using Npgsql;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Empresa.Persistence
{
    public class DepartamentoDAO
    {
        public bool Persistir(Departamento departamento)
        {
            try
            {
                NpgsqlConnection conexao = PostgreSQL.Conexao;

                string query = $@"INSERT INTO departamento (descricao)
                                  VALUES ('{departamento.Descricao}')";

                NpgsqlCommand comando = new NpgsqlCommand(query, conexao);

                comando.ExecuteNonQuery();

                return true;
            }
            catch (NpgsqlException e)
            {
                MessageBox.Show(e.Message);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }

            return false;
        }

        public bool Atualizar(Departamento departamento)
        {
            try
            {
                NpgsqlConnection conexao = PostgreSQL.Conexao;

                string query = $@"UPDATE departamento 
                                  SET descricao = '{departamento.Descricao}'
                                  WHERE id = {departamento.Id}";

                NpgsqlCommand comando = new NpgsqlCommand(query, conexao);

                comando.ExecuteNonQuery();

                return true;
            }
            catch (NpgsqlException e)
            {
                MessageBox.Show(e.Message);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }

            return false;
        }

        public static bool Excluir(int id)
        {
            try
            {
                NpgsqlConnection conexao = PostgreSQL.Conexao;

                string query = $@"DELETE FROM departamento
                                  WHERE id = {id}";

                NpgsqlCommand comando = new NpgsqlCommand(query, conexao);

                comando.ExecuteNonQuery();

                return true;
            }
            catch (NpgsqlException e)
            {
                MessageBox.Show(e.Message);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }

            return false;
        }

        public static List<Departamento> Consultar()
        {
            var departamentos = new List<Departamento>();

            try
            {
                NpgsqlConnection conexao = PostgreSQL.Conexao;

                string query = $@"SELECT id, descricao
                                  FROM departamento
                                  ORDER BY id";

                NpgsqlCommand comando = new NpgsqlCommand(query, conexao);

                NpgsqlDataReader leitor = comando.ExecuteReader();

                Departamento departamento;

                while(leitor.Read())
                {
                    departamento = new Departamento();

                    departamento.Id = Convert.ToInt32(leitor[0]);
                    departamento.Descricao = Convert.ToString(leitor[1]);

                    departamentos.Add(departamento);
                }

                leitor.Close();

                return departamentos;
            }
            catch (NpgsqlException e)
            {
                MessageBox.Show(e.Message);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }

            return null;
        }

        public static Departamento Consultar(int id)
        {
            try
            {
                NpgsqlConnection conexao = PostgreSQL.Conexao;

                string query = $@"SELECT id, descricao
                                  FROM departamento
                                  WHERE id = {id}";

                NpgsqlCommand comando = new NpgsqlCommand(query, conexao);

                NpgsqlDataReader leitor = comando.ExecuteReader();

                leitor.Read();

                var departamento = new Departamento();

                departamento.Id = Convert.ToInt32(leitor[0]);
                departamento.Descricao = Convert.ToString(leitor[1]);

                leitor.Close();

                return departamento;
            }
            catch (NpgsqlException e)
            {
                MessageBox.Show(e.Message);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }

            return null;
        }
    }
}
