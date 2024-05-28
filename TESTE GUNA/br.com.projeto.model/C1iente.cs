using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TESTE_GUNA.br.com.projeto.model
{
    public class C1iente
    {
        //atributos tabela tb_clientes
        public int cpf_cnpjCliente { get; set; }
        public string nomeCliente { get; set; }
        public string emailCliente { get; set; }
        public int telefoneCliente { get; set; }
        public int celularCliente { get; set; }
        public int cepCliente { get; set; }
        public string enderecoCliente { get; set; }
        public int numeroCliente { get; set; }
        public string complementoCliente { get; set; }
        public string bairroCliente { get; set; }
        public string cidadeCliente { get; set; }
        public string estadoCliente { get; set; }
        public int senhaCliente { get; set; }

        //associal a nivel de acesso 
        public int for_nivel_acesso { get; set; }


    }
}
