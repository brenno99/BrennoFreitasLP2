using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_12052015
{
    class Program
    {
        static void Main(string[] args)
        {
           int M = int.Parse(Console.ReadLine());
           int N = int.Parse(Console.ReadLine());
           int defeito_total = 0;
          
            int[,] pisc = new int[M, N];

            for (int i = 0; i < M; i++)
            {
                int defeito_linha = 0;
                for (int j = 0; j < N; j++)
                {
                    pisc[i, j] = int.Parse(Console.ReadLine());

                    if (pisc[i, j] == 1)
                    {
                        defeito_total++;
                        defeito_linha++;
                    }

                }
               
                Console.WriteLine("A linha tem {0} tem {1} azulejos.", i, defeito_linha);
                
            }

            Console.WriteLine("Total de {0} azulejos defeituosso.", defeito_total);

            
           

            for (int i = 0; i < M; i++)
            {
                int defeito_coluna = 0;

                for (int j = 0; j < N; j++)
                {
                    pisc[i, j] = int.Parse(Console.ReadLine());

                    if (pisc[j, i] == 1)
                    {
                        defeito_coluna++;
                    }

                    Console.WriteLine("A linha tem {0} tem {1} azulejos.", j, defeito_coluna);

                }
            }
             
        }
    }
}
