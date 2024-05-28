using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using MySql.Data.MySqlClient;

namespace TESTE_GUNA.br.com.projeto.conexao
{
    internal class ConnectionFactory
    {
        //metodo que conecta ao banco de dados

        public MySqlConnection getconnection()
        {
            string conexao = ConfigurationManager.ConnectionStrings["bdvendas"].ConnectionString;


            return new MySqlConnection(conexao);
        }
    }
}
