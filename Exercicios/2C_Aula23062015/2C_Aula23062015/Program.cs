using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2C_Aula23062015
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            double salarioReajust = 0;

            Funcionario F = new Funcionario();

            for (int i = 0; i < N; i++)
            {
                F.nomes.Add(Console.ReadLine());
                F.cpf.Add(Console.ReadLine());
                F.datasNasc.Add(Console.ReadLine());
                F.datasAdmi.Add(Console.ReadLine());
                F.salarios.Add(Convert.ToDouble(Console.ReadLine()));
                Console.WriteLine();

            }

            for (int k = 0; k < N; k++)
            {
                Console.WriteLine("Nome: " + F.nomes[k]);
                Console.WriteLine("CPF: " + F.cpf[k]);
                Console.WriteLine("Data de Nascimento: " + F.datasNasc[k]);
                Console.WriteLine("Data de Admissão: " + F.datasAdmi[k]);
                Console.WriteLine("Salário: " + F.salarios[k]);

                salarioReajust = F.CalculaSalarioReajust(k);

                Console.WriteLine("Novo Salário: " + salarioReajust);
                Console.WriteLine();
            }
        }
    }
}

        
        
        
        
        
        
        
        
        
        
        
        
        
