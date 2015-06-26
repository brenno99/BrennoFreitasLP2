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
            string[] nome = new string[N];
            int[] cpf = new int[N];
            string[] DataNasc = new string[N];
            double[] salario = new double[N];
            int[] dataAdmi = new int[N];
            double[] salario_reajust = new double[N];
           
            for (int i = 0; i < N; i++)
            {
                nome[i] = Console.ReadLine();
                cpf[i] = int.Parse(Console.ReadLine());
                DataNasc[i] = Console.ReadLine();
                salario[i] = double.Parse(Console.ReadLine());
                dataAdmi[i] = int.Parse(Console.ReadLine());

                if (dataAdmi[i] >= 2014)
                {
                   salario_reajust[i] = salario[i] + 423.45;
                }

                else if (dataAdmi[i] > 2010 && dataAdmi[i] < 2013)
                {
                    double aumento = salario[i] * 9.84 / 100;
                    salario_reajust[i] = salario[i] + aumento;                
                }

                else if (dataAdmi[i] > 2000 && dataAdmi[i] < 2010)
                {
                    double aumento2 = salario[i] * 16.4 / 100;
                    salario_reajust[i] = salario[i] + aumento2;
                }

                else if (dataAdmi[i] < 1999)
                {
                    double aumento3 = salario[i] * 22.6 / 100;
                    salario_reajust[i] = salario[i] + aumento3;
                }

            }

            for (int j = 0; j < N; j++)
            {
                Console.WriteLine("O CPF é: " + cpf[j]);
                Console.WriteLine("O nome é: " + nome[j]);
                Console.WriteLine("A data de nascimento é: " + DataNasc[j]);
                Console.WriteLine("A data de admissão é: " + dataAdmi[j]);
                Console.WriteLine("O salário é: " + salario[j]);
                Console.WriteLine("O salário reajustado é: " + salario_reajust[j]);
            }
        }
    }
}

        
        
        
        
        
        
        
        
        
        
        
        
        
