using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07042015_2
{
    class Program
    {
        static void Main(string[] args)
        {
            string texto;
            int N;
            string temp = Console.ReadLine();
            char C = temp[0];
            
            Console.WriteLine("Digite uma frase: ");
            texto = Convert.ToString(Console.ReadLine());

            Console.WriteLine("informe o número: ");
            N = int.Parse(Console.ReadLine());

            for (int i = 0; i < texto.Length; i += N)
            {
                if (i + N > texto.Length)
                {
                    Console.WriteLine(texto.Substring(i));

                }
                else
                {
                    Console.WriteLine(texto.Substring(i, N));
                }
                    
            }
            string[] palavras = texto.Split(' ');                 
            int qtd = 0;

            for (int i = 0; i < palavras.Length; i++)         // Transformar em foreach 
                                                              // Fazer funcionar para maiusculo e minusculo
             {
                if (palavras[i][0] == C)
                {
                    qtd++;
                }
            }
            Console.WriteLine(qtd);

        }
    }
}
