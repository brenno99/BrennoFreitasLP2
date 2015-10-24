using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Exercicio13
{
    class Program
    {
        static void Main(string[] args)
        {
            MySqlConnection Connection = new MySqlConnection("Server=localhost;Database=test;Uid=root;Pwd=");
            MySqlCommand Command = new MySqlCommand();

            Command.Connection = Connection;

            List<Pessoa> pessoas = new List<Pessoa>();

            Console.WriteLine("Opções: ");
            Console.WriteLine("1 - Cadastrar");
            Console.WriteLine("2 - Consultar");

            int opcao = int.Parse(Console.ReadLine());

            while (opcao != 2)
            {
                Pessoa P = new Pessoa();
                int i = 0;

                if (opcao == 1)
                {
                    Console.WriteLine("Nome: ");
                    P.Nome = Console.ReadLine();

                    Console.WriteLine("Sobrenome: ");
                    P.Sobrenome = Console.ReadLine();

                    Console.WriteLine("Peso: ");
                    P.Peso = double.Parse(Console.ReadLine());

                    Console.WriteLine("Altura: ");
                    P.Altura = double.Parse(Console.ReadLine());

                    Console.WriteLine("Telefone: ");
                    P.Telefone = Console.ReadLine();

                    pessoas.Add(P);

                    string Q = string.Format("INSERT INTO pessoa (Nome, Sobrenome, Peso, Altura, Telefone) VALUES ('{0}', '{1}', {2}, {3}, '{4}')", pessoas[i].Nome, pessoas[i].Sobrenome, pessoas[i].Peso, pessoas[i].Altura, pessoas[i].Telefone);
                    Command.CommandText = Q;
                    Command.ExecuteNonQuery();
                    
                    Console.WriteLine("Opções: ");
                    Console.WriteLine("1 - Cadastrar");
                    Console.WriteLine("2 - Consultar");
                    Console.WriteLine("3 - Sair");

                    opcao = 0;
                    i++;
                }

                  
                 if (opcao == 2)
                 {
                    Console.WriteLine("Consultar por nome ou Id");
                    string a = Console.ReadLine();
                    
                    Command.Connection.Open();
                    Command.CommandText = String.Format("Select * FROM Pessoa");

                    MySqlDataReader reader = Command.ExecuteReader();

                    if (a == "nome")
                    {
                        Console.WriteLine("Digite o Nome:");
                        string busca = Console.ReadLine();
                        int nome = 1;

                        while (reader.Read())
                        {
                            if (busca == reader.GetString(1))
                            {
                                Console.WriteLine("ID: {0} Nome: {1} Sobrenome: {2} Peso: {3}  Altura: {4}  Telefone: {5} ", reader.GetInt32(0), reader.GetString(1), reader.GetString(2), reader.GetDouble(3), reader.GetDouble(4), reader.GetString(5));
                                nome = 2;
                            }

                        }

                        if (nome == 1)
                        {
                            Console.WriteLine("Não há nenhum registro!");
                        }

                    }

                    else if (a == "id")
                    {
                        int id = 1;
                        Console.WriteLine("Digite o Id: ");
                        
                        int id_valor = int.Parse(Console.ReadLine());
                       
                        while (reader.Read())
                        {
                            if (id_valor == reader.GetInt32(0))
                            {
                                Console.WriteLine("Id: {0} Nome: {1} Sobrenome: {2} Peso: {3}  Altura: {4} Telefone: {5} ", reader.GetInt32(0), reader.GetString(1), reader.GetString(2), reader.GetDouble(3), reader.GetDouble(4), reader.GetString(5));
                                id = 2;
                            }

                        }
                        
                        if (id == 1)
                        {
                            Console.WriteLine("Não há nenhum registro!");
                        }
                    }
                    
                    reader.Close();
                    Command.Connection.Close();
                          
                 }//fim primeiro if

              }// fim while
        }
    }
}
