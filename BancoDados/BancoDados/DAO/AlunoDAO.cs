using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace BancoDados
{
    public class AlunoDAO
    {
        public void IncluirAluno(Aluno aluno)
        {
            using (MySqlConnection connection =
                        ConectarBancoDados.ObterConexao())
            {
                string queryString = @"insert into aluno(nome,ra) 
                                    values (@aluno, @ra)";

                MySqlCommand command = new MySqlCommand(queryString, connection);
                command.Parameters.AddWithValue("@aluno", aluno.Nome);
                command.Parameters.AddWithValue("@ra", aluno.RA);

                try
                {
                    connection.Open();
                    int valor = command.ExecuteNonQuery();

                    if (valor <= 0)
                    {
                        throw new Exception("Não foi possivel inserir o aluno");
                    }
                }
                catch (Exception ex)
                {
                    throw new Exception(ex.Message, ex);
                }
            }
        }
    }
}
