using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Tela_teste_login2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            var strConexao = "server=localhost;uid=luis;pwd=3412;database=cadastro";
            var conexao = new MySqlConnection(strConexao);
    
            conexao.Open();
        }


        MySqlConnection conexao1 = new MySqlConnection(Properties.Settings.Default.conexao);

        string usuario, senha;

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            Logar();
        }

        private void Logar()
        {

            string login = "SELECT CPF, Senha FROM pacientes WHERE CPF='"+txtLogin.Text+"' AND Senha='"+txtSenha.Text+"'";
            MySqlCommand comando = new MySqlCommand(login, conexao1);
            comando.CommandType = CommandType.Text;
            MySqlDataReader reader;

            try
            {

                conexao1.Open();
                reader = comando.ExecuteReader();
                if(reader.Read())
                {

                    usuario = reader[0].ToString();
                    senha = reader[1].ToString();

                    conexao1.Close();
                    
                    if(usuario==txtLogin.Text && senha == txtSenha.Text) 
                    { 
                    
                   Form form = new Form();
                        form.Show();
                        this.Hide();
                    
                    }


                }


            }

            catch (Exception ex)
            {

                MessageBox.Show("Deu erro" + ex);



            }

           
        }


    }
}
