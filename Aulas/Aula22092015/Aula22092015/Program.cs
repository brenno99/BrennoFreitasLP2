using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace Aula22092015
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informe o nome para realizar o cadastro: ");
            string nome = Console.ReadLine();

            string strConn = "Server=localhost;Database=test;Uid=root;Pwd=";

            MySqlConnection conn = new MySqlConnection(strConn);

            MySqlCommand command = new MySqlCommand();

            command.Connection = conn;


            command.CommandText = String.Format("Insert into Pessoa (Nome) Values ('{0}')" , nome);

            conn.Open();

            command.ExecuteNonQuery();

            conn.Close();

        }
    }
}
