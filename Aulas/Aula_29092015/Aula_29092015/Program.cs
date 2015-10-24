using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace Aula_29092015
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Menu de opções: ");
            Console.WriteLine("Escolha a sua opção:\n1: Consulta\n2: Inserir novo\n3: Remover\n4: Atualizar\n5:Sair");
            int option = int.Parse(Console.ReadLine());

            while (option != 5)
            {
                switch (option)
                {
                    case 1: Consultar();
                        break;

                    case 2: Inserir();
                        break;

                    case 3: Remover();
                        break;

                    case 4: Atualizar();
                        break;

                    default: Console.WriteLine("O número digitado é inválido."); 
                        break;

                }

                Console.WriteLine("Escolha a sua opção: 1: Consulta\n2: Inserir novo\n3: Remover\n4: Atualizar\n5:Sair");
                option = int.Parse(Console.ReadLine());
            }
        }

        public static void Consultar()
        {
            string c = "SELECT id FROM PESSOA";
            OperacaoBD(c);
        }


        public static void Inserir()
        {
            Console.WriteLine("Digite o modelo e a marca desejados: ");
            string modelo = Console.ReadLine();
            string marca = Console.ReadLine();
            
            string q = string.Format("INSERT INTO CARRO (Modelo, Marca) VALUES ('{0}', '{1}')", modelo, marca);
            Console.WriteLine(q);
            OperacaoBD(q);
        }

        public static void Atualizar()
        {
            string a = "UPDATE endereço FROM PESSOA";
            OperacaoBD(a);
        }

        public static void Remover()
        {
            string r = "DELETE nome FROM PESSOA";
            OperacaoBD(r); 
        }
    
        public static void OperacaoBD(string query)
        {
            string strConn = "Server=localhost;Database=test;Uid=root;Pwd=";

            MySqlConnection conn = new MySqlConnection(strConn);
            
            MySqlCommand command = new MySqlCommand();
            command.Connection = conn;
            command.CommandText = query;

            conn.Open();
            command.ExecuteNonQuery();
            conn.Close();
            
        }
        
    }
}
