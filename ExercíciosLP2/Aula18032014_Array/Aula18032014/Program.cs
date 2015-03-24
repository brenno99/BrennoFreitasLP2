using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Aula18032014
{
    class Program
    {
        static void Main(string[] args)
        {
            // Inicializando as variáveis é um instanciando um array para o cálculo da média aritmética dos números 
            // que serão digitados pelo usuário
            ArrayList numeros = new ArrayList();
            int n = 1;
            int soma = 0;
            int media;

            // Laço for para receber os valores digitados pelo usuário e armazená-los(somando cada um deles) na variável
            // "soma"
            for (int i = 0; n != 0; i++)
            {
                Console.WriteLine("Digite um valor para n: ");
                n = int.Parse(Console.ReadLine());

                numeros.Add(n);
                numeros.Remove(0);

                soma += n;
            }
            Console.WriteLine();

            //Cálculo da média aritmética dos números digitados pelo usuário sem contar com o valor de saída(0) que foi
            //removido dentro do laço anterior
            media = soma / numeros.Count;
            Console.WriteLine("A média aritmética é: " + media);
        }
    }
}
