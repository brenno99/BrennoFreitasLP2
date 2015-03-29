using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercíco_VogaisLLP2
{
    class Program
    {
        static void Main(string[] args)
        {
            string frase;
            int tamanho = 0;
            int qtd_vogal = 0;
            string letra;
            int indice_frase = 0;
            
            Console.WriteLine("Digite a frase: ");
            frase = Console.ReadLine();

            tamanho = frase.Length;
            Console.WriteLine("O tamnho da frase é: " + tamanho);

            
           
            while (indice_frase < tamanho)
            {
                letra = frase.Substring(indice_frase, 1);
                letra = letra.ToUpper();
                
                
                if (letra == "A" | letra == "E" | letra == "I" | letra == "O" | letra == "U")
                {
                    qtd_vogal++;
                }

                indice_frase++;
            }

            Console.WriteLine("O número de vogais é: " + qtd_vogal);

             

        
        
        
        
        
        }
    }
}
