using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data.Sql;

namespace BancoDados
{
    public class ConectarBancoDados
    {
        private static string conexao = "";

        public static SqlConnection ObterConexao()
        {
            SqlConnection sqlConnection = new SqlConnection(conexao);
            return sqlConnection;
        }
    }
}
