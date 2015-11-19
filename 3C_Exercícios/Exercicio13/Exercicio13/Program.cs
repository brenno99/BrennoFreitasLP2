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
            int op = 0;
            int verificadorconsulta = 0;

            MySqlConnection Connection = new MySqlConnection("Server=localhost;Database=test;Uid=root;Pwd=anaewagner");
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

                    string Q = string.Format("INSERT INTO Pessoa (Nome, Sobrenome, Peso, Altura, Telefone) VALUES ('{0}', '{1}', {2}, {3}, '{4}')", pessoas[i].Nome, pessoas[i].Sobrenome, pessoas[i].Peso, pessoas[i].Altura, pessoas[i].Telefone);
                    Command.CommandText = Q;
                    Connection.Open();
                    Command.ExecuteNonQuery();

                    Console.WriteLine("Opções: ");
                    Console.WriteLine("1 - Cadastrar");
                    Console.WriteLine("2 - Consultar");
                    Console.WriteLine("3 - Sair");
                    opcao = int.Parse(Console.ReadLine());

                    opcao = 0;
                    i++;
                }

                if (opcao == 2)
                {
                    int opconsulta = 0;
                    string consultani;

                    Console.WriteLine("Consultar por nome ou Id");
                    string a = Console.ReadLine();

                    Connection.Open();
                    Command.CommandText = String.Format("Select * FROM Pessoa");

                    MySqlDataReader reader = Command.ExecuteReader();

                    if (a == "nome")
                    {
                        Console.WriteLine("Digite o Nome: ");
                        string busca = Console.ReadLine();
                  
                        while (opconsulta != 1 && opconsulta != 2)
                        {
                            Console.Write("Digite 1 para consultar por nome ou 2 para consultar por id: ");
                            opconsulta = int.Parse(Console.ReadLine());

                            if (opconsulta == 1)
                            {
                                Console.Write("Escolha o nome a consultar: ");
                                consultani = Console.ReadLine();
                                if (reader.HasRows)
                                {
                                    while (reader.Read())
                                    {
                                        if (reader.GetString(1) == consultani)
                                        {
                                            Console.WriteLine("ID: {0}, Nome: {1}, Sobrenome: {2}",
                                            reader.GetInt32(0),
                                            reader.GetString(1),
                                            reader.GetString(2));
                                            verificadorconsulta++;
                                        }
                                    }

                                    if (verificadorconsulta == 0)
                                    {
                                        Console.WriteLine("Não há nenhum registro com o nome informado.");
                                    }
                                }
                            }

                            else if (opconsulta == 2)
                            {
                                Console.Write("Escolha o id a consultar: ");
                                consultani = Console.ReadLine();
                                if (reader.HasRows)
                                {
                                    while (reader.Read())
                                    {
                                        if (reader.GetInt32(0) == Convert.ToInt32(consultani))
                                        {
                                            Console.WriteLine("ID: {0}, Nome: {1}, Sobrenome: {2}, Peso: {3}, Altura: {4}, Telefone: {5}",
                                            reader.GetInt32(0),
                                            reader.GetString(1),
                                            reader.GetString(2),
                                            reader.GetDouble(3),
                                            reader.GetDouble(4),
                                            reader.GetString(5));
                                            verificadorconsulta++;
                                        }
                                    }

                                    if (verificadorconsulta == 0)
                                    {
                                        Console.WriteLine("Não há nenhum registro com o id informado!");
                                    }
                                }
                            }

                            else
                            {
                                Console.WriteLine("Insira um número válido. 1 para consultar por nome ou 2 por id!");
                            }
                        }
                        reader.Close();
                        op = 0;
                    }
                    // Fim Consulta //

                }

            }
        }
    }
}
