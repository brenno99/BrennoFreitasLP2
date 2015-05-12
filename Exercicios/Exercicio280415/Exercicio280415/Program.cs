using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio280415
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = 0;

            int numero = 0;

            int auxi = 0;

            Console.WriteLine("Informe o valor de N: ");
            N = int.Parse(Console.ReadLine());

            int[] numeros = new int[N];

            for (int i = 0; i < N; i++)
            {
                Console.WriteLine("Digite os valores desejados: ");
                numero = int.Parse(Console.ReadLine());
                numeros[i] = numero;
            }

            for (int j = 0; j < N; j++) // j é quantas vezes pecorremos o array inteiro
            {
                for (int k = 0; k < N - 1; k++)
                {
                    if (numeros[k] > numeros[k + 1])
                    {
                        auxi = numeros[k];
                        numeros[k] = numeros[k + 1];
                        numeros[k + 1] = auxi;
                    }
                }
            }

            for (int z = 0; z < N; z++)
            {
                Console.WriteLine(numeros[z]);
            }

        }
    }
}
