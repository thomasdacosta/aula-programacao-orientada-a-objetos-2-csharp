using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace BancoDados
{
    public class ConectarBancoDados
    {
        private static string conexao = "Server=localhost;Database=faculdade;Uid=root;Pwd=anhanguera;";

        public static MySqlConnection ObterConexao()
        {
            MySqlConnection mySqlConnection = new MySqlConnection(conexao);
            return mySqlConnection;
        }
    }
}
