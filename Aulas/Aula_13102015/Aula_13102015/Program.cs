using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Collections;
using System.Globalization;

namespace Aula_13102015
{
    class Program
    {
        static void Main(string[] args)
        {
            MySqlConnection conn = new MySqlConnection("Server=localhost;Database=test;Uid=root;Pwd=");
            MySqlCommand cnd = new MySqlCommand();

            cnd.Connection = conn;

            Pessoa p = new Pessoa();
 
            List<Pessoa> pessoas = new List<Pessoa>(); 

            string c = "";

                Console.WriteLine("Digite 1 registrar as informações e 2 para sair");
                c = Console.ReadLine();

                Console.WriteLine("Nome: ");
                p.Nome = Console.ReadLine();

                Console.WriteLine("Sobrenome: ");
                p.Sobrenome = Console.ReadLine();

                Console.WriteLine("Peso: ");
                p.Peso = double.Parse(Console.ReadLine());

                Console.WriteLine("Altura: ");
                p.Altura = double.Parse(Console.ReadLine());

                Console.WriteLine("Telefone: ");
                p.Telefone = Console.ReadLine();

                pessoas.Add(p);
           

            cnd.Connection.Open();
            for (int i = 0; i < pessoas.Count; i++)
            {
                string q = String.Format(new CultureInfo("en"), "INSERT INTO PESSOA(Nome, Sobrenome, Peso, Altura, Telefone) VALUES ('{0}', '{1}', {2}, {3}, '{4}')" , pessoas[i].Nome, pessoas[i].Sobrenome, pessoas[i].Peso, pessoas[i].Altura, pessoas[i].Telefone);
                cnd.CommandText = q;
                cnd.ExecuteNonQuery();
            }
            conn.Close();

            /*MySqlDataReader reader = cnd.ExecuteReader();

            if (reader.HasRows)
            {
                while (reader.Read())
                {

                    pessoas[].Id = reader.GetInt32(0);
                }
            }

            else {

            }

            conn.Close();*/
        }
    }
}
