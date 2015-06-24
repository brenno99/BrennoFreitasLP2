using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula_Apoio
{
    class Program
    {
        static void Main(string[] args)
        {
            int exercicio = 0;
            Console.WriteLine("Digite o exercício desejado: ");
            exercicio = int.Parse(Console.ReadLine());

            while(exercicio <= 3)
            {
                if (exercicio == 1)

                    Exercicio1();

                else if (exercicio == 2)

                    Exercicio2();

                else if (exercicio == 3)

                    Exercicio3();
            }
        }    

            private static void Exercicio1()
            {
                int N;
                int P;
                int Q;
                                  
            N = int.Parse(Console.ReadLine());
            P = int.Parse(Console.ReadLine());
            Q = int.Parse(Console.ReadLine());
            
             for (int i = P; i <= Q; i++)
            {
                if (i % N == 0)
                {
                    Console.WriteLine(i);
                }
            }
       }//fim Exercicio1

           private static void Exercicio2()
           {
               int N = int.Parse(Console.ReadLine());
            double hip = 0;
            
            for (int i = 0; i < N; i++)
            {
                double lado1 = double.Parse(Console.ReadLine());
                double lado2 = double.Parse(Console.ReadLine());
                double lado3 = double.Parse(Console.ReadLine());

                if (lado1 == lado2 && lado1 == lado3)
                {
                    Console.WriteLine("Triângulo Equilátero!");
                }

                else if (lado1 != lado2 && lado1 != lado3)
                {
                    Console.WriteLine("Triângulo Escaleno!");

                    if (lado1 > lado2 && lado1 > lado3)
                    {
                        hip = lado2 * lado2 + lado3 * lado3;
                        hip = Math.Sqrt(hip);

                        if (hip == lado1)
                        {
                            Console.WriteLine("Triângulo Escaleno e retângulo!");
                        }
                                                               
                    }
                }
            
               if(lado1 == lado2 && lado1 != lado3)
               {
                   Console.WriteLine("Triângulo Isósceles!");
               }
              
         }//fim for
      }//fim Exercicio2

             private static void Exercicio3()
             {
                int n = int.Parse(Console.ReadLine());
                int[] seq = new int[n];

                for(int i = 0; i < n; i++)
                {
                  seq[i] = int.Parse(Console.ReadLine());
                }

                int somaPar = 0, somaImpar = 0;
              
                 for(int i = 0; i< n; i++)
                 {
                    if (i % 2 == 0)
                    somaPar += seq[i];
                    
                    else
                      somaImpar += seq[i];
                 }

                 if (somaPar > somaImpar)
                 Console.WriteLine("Sequência Par");
               
                 else if (somaImpar > somaPar)
                 Console.WriteLine("Sequência Ímpar");
               
                 else
                 Console.WriteLine("Sequência Neutra");
               
             }//fim Exercicio3 

          }
      }
  


