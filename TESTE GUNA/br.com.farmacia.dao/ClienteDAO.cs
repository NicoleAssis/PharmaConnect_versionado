using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TESTE_GUNA.br.com.farmacia.conexao;
using TESTE_GUNA.br.com.farmacia.model;
namespace TESTE_GUNA.br.com.farmacia.dao
{
    public class ClienteDAO
    {
        //Conecta com o Banco de dados
        private MySqlConnection conexao;

        public ClienteDAO()
        {
            this.conexao = new ConnectionFactory().GetConnection();
        }

        #region Cadastrar Cliente
        public void CadastrarClienteOrdem1(Cliente obj)
        {
            try
            {
                // definindo comando sql para aplicar ao banco
                string sql = @"INSERT INTO tb_clientes (cpf_cnpj_cliente, nome_cliente, email_cliente, senha_cliente) VALUES
                                (@cpf_cnpj,@nome, @email,@senha )";

                // organizando o comando em seu respectivo campo

                MySqlCommand executacmd = new MySqlCommand(sql, conexao);

                executacmd.Parameters.AddWithValue("@cpf_cnpj", obj.cpf_cnpj);
                executacmd.Parameters.AddWithValue("@nome", obj.nome);
                executacmd.Parameters.AddWithValue("@email", obj.email);
                executacmd.Parameters.AddWithValue("@senha", obj.senha);


                //3 Abrir conexao e abrir comando sql
                conexao.Open();
                executacmd.ExecuteNonQuery();

                MessageBox.Show("Cliente cadastrado com sucesso!");

                //fechar a conexao com o banco de dados
                conexao.Close();
            }
            catch (Exception erro)
            {

                MessageBox.Show("Aconteceu o erro " + erro);
            }
        }
        #endregion
    }
}
