using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercício_aula31032015
{
    class Program
    {
        static void Main(string[] args)
        {
            int x;
            int y;
            int potencia = 1;
            
            
            Console.WriteLine("Digite um valor para x: ");
            x = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o valor de y: ");
            y = int.Parse(Console.ReadLine());
                                    
            for (int i = 0; i < y ; i++)
            {
                potencia = potencia * x; 
            }

            Console.WriteLine("A potenciação de x elevado a y é: " + potencia);
        
        }
    }
}
