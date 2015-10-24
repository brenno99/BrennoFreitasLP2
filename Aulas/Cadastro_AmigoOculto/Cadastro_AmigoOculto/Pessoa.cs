using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data;
using MySql.Data.MySqlClient;


namespace Cadastro_AmigoOculto
{
    class Pessoa
    {
        public int Id {get; set;}

        public string Nome { get; set; }

        public string Sobrenome { get; set; }

        public string[] Presentes = new string[3];

        public void Salvar()
        {
            MySqlConnection conn = new MySqlConnection("Server=localhost;Database=test;Uid=root;Pwd=");
            MySqlCommand comm = new MySqlCommand();

            comm.Connection = conn;

            string q = String.Format("INSERT INTO Pessoa (nome, sobrenome, presente1, presente2, presente3) VALUES('{0}', '{1}', '{2}', '{3}', '{4}')", Nome, Sobrenome, Presentes[0], Presentes[1], Presentes[2]);

            comm.CommandText = q;

            comm.Connection.Open();

            comm.ExecuteNonQuery();

            conn.Close();

        }
    }
}
