using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TESTE_GUNA.br.com.farmacia.model;
using TESTE_GUNA.br.com.farmacia.dao;
using TESTE_GUNA.br.com.farmacia.conexao;
using System.Runtime.CompilerServices;

namespace TESTE_GUNA.projeto.view
{
    public partial class FrmCadastro : Form
    {
        public FrmCadastro()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            //abrir a tela de login
            FrmLogin telaLogin = new FrmLogin();
            //esconde a tela anterior
            this.Hide();
            //tela abre no centro
            telaLogin.StartPosition = FormStartPosition.CenterScreen;
            telaLogin.Show();
        }

        private void btnX_Click(object sender, EventArgs e)
        {
            //button fechar o programa (X)
            Environment.Exit(0);
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            Cliente obj = new Cliente();


            obj.nome = nometxt.Text;
            obj.cpf_cnpj = (int)long.Parse(cpftxt.Text);
            obj.email = txtEmail.Text;
            obj.senha = txtSenha.Text;


            ClienteDAO dao = new ClienteDAO();
            dao.CadastrarClienteOrdem1(obj);

            

        }

        private void FrmCadastro_Load(object sender, EventArgs e)
        {
            
        }

        private void nometxt_TextChanged(object sender, EventArgs e)
        {
        }
        
    }
}
