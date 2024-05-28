using System.Configuration;
using MySql.Data.MySqlClient;


namespace TESTE_GUNA.br.com.farmacia.conexao
{
    public class ConnectionFactory
    {

        public MySqlConnection GetConnection()
        {
            string conexao = ConfigurationManager.ConnectionStrings["bdfarmacia"].ConnectionString;

            return new MySqlConnection(conexao);
        }


    }
}
