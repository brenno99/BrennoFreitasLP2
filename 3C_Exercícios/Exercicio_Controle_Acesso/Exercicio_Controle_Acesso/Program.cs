using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace Exercicio_Controle_Acesso
{
    class Program
    {
        static void Main(string[] args)
        {
            bool permanecer = true;
           
            MySqlConnection conn = new MySqlConnection("Server=localhost;Database=test;Uid=root;Pwd=anaewagner");
            MySqlCommand cnd = new MySqlCommand();
            cnd.Connection = conn;

            Usuario usu = new Usuario();

            while (permanecer)
            {
                Console.WriteLine("Tela de Login!");
                Console.WriteLine("Informe o seu Login: ");
                string login = Console.ReadLine();
                Console.WriteLine("Informe a sua Senha: ");
                string senha = Console.ReadLine();

                conn.Open();

                string a = String.Format("SELECT *  FROM usuario WHERE Login = '{0}' AND Senha = '{1}' ", login, senha);
                cnd.CommandText = a;

                MySqlDataReader reader = cnd.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        usu.Id = reader.GetInt32(0);
                        usu.Nome = reader.GetString(1);
                        usu.Email = reader.GetString(2);
                        usu.Login = reader.GetString(3);
                        usu.Senha = reader.GetString(4);

                        usu.DataUltimoAcesso = reader.GetDateTime(5);

                        Console.WriteLine("Última data de Acesso: {0}", reader.GetDateTime(5));
                        Console.WriteLine("Login concedido!");

                        Console.WriteLine("Data atualizada!");
                    }
                    
                    reader.Close();
                    conn.Close();
                   
                } // if reader.HasRows

                else
                {
                    Console.WriteLine("Login falhou!!");
                    Console.WriteLine("Verifique o Email ou sua Senha novamente!");
                }

                Console.WriteLine("Desejar fazer o logout??");
                string logout = Console.ReadLine();

                if (logout == "sim")
                {
                    break;
                }

            }//fim while
                       
        }
    }
}
