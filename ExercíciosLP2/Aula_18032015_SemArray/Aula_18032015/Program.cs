using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Aula_18032015
{
    class Program
    {
        static void Main(string[] args)
        {
            // Inicializando as variáveis que serão utilizadas tanto para o recebimento dos números como para
            // o cálculo da média
            int numeros = 0;
            int media;
            int n = 1;
            int i = 0;

            // Laço que será responsável pelo recebimento de valores digitados pelo usuário e sua soma na variável numeros.
            // ao receber o valor 0, sua execução será finalizada e a soma os valores digitados serão gravados na variável 
            // números.
            while (n != 0)
            {
             Console.WriteLine("Digite um valor para n: ");
             n = int.Parse(Console.ReadLine());
                
             numeros += n;
             i++;
            }
                 
            Console.WriteLine();
            // Cálculo da média aritmética dos números digitados (soma dos números digitados / quantidade de números digitados)
            media = numeros / (i - 1);

            Console.WriteLine("A média aritmética dos números é: " + media);
        }
    }
}
