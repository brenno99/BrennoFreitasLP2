using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_aula240315LP2
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            double numeros;
            double soma = 0;
            double maior = -1;
            double menor = 1000;

            Console.WriteLine("Digite o valor de n: ");
            n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Digite os números: ");
                numeros = double.Parse(Console.ReadLine());

                soma += numeros;

                if (maior < numeros)
                {
                    maior = numeros;
                        
                }

                if (menor > numeros)
                {

                    menor = numeros;
                }

            }

            Console.WriteLine("O maior número é: " + maior);
            Console.WriteLine("O menor número é: " +  menor);
            Console.WriteLine("A soma dos números é: " + soma);
              
                }
             }  
         }
                
              
             
              

                      
            
      