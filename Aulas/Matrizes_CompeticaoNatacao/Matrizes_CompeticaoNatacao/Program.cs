using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matrizes_CompeticaoNatacao
{
    class Program
    {
        static void Main(string[] args)
        {
           //Console.WriteLine("digite o número de nadadores: ");
           //qtd_nadadores = int.Parse(Console.ReadLine());
            string[] nadadores = new string[5];
            string nome = "";
            
            //Console.WriteLine("Digite a quantidade de provas: ");
            //qtd_provas = int.Parse(Console.ReadLine());
            double[,] provas = new double[5, 3];
            int numero_prova = 0; 
            double tempo = 0;
                                               
            double menor_tempo_total = System.Double.MaxValue;
            double menor_tempo_prova = System.Double.MaxValue;
            int indice_nadador_vencedor = 0;
            double tempo_total_nadador = 0;

            // for para captar os nomes dos nadadores 
            for (int i = 0; i < nadadores.Length; i++)
            {
                Console.WriteLine("Informe o nome do nadador: ");
                nome = Console.ReadLine();
                nadadores[i] = nome;
            } // fim for nadadores 

            
            // imput para cada prova os tempos dos nadadores 
            for (int i = 0; i < 3; i++)
            {
                numero_prova = i + 1;
                Console.WriteLine("Resultados da prova: " + numero_prova);

                for (int k = 0; k < 5; k++)
                {
                    Console.WriteLine("Tempo do nadador " + nadadores[k]);
                    tempo = double.Parse(Console.ReadLine());
                    provas[k, i] = tempo;            
                 } 

            } // for da prova (coluna)


           //verificar o vencedor de cada prova
           for (int coluna = 0; coluna < 3; coluna++)
           {
               for (int linha = 0; linha < 5; linha++)
               {
                   if (provas[linha, coluna] < menor_tempo_prova)
                    {
                       menor_tempo_prova = provas[linha, coluna];
                       indice_nadador_vencedor = linha;
                    }
               }//for linha 

               // vencedor da prova 
               numero_prova = coluna + 1;
               Console.WriteLine("O vencedor da prova" + numero_prova + " foi: " + nadadores[indice_nadador_vencedor]);

               menor_tempo_prova = System.Double.MaxValue;
           }// for coluna(vencedor de cada prova)

            
            
            // verificar o nadador campeao 
            // soma todas as provas que competiu -> menor tempo     
            menor_tempo_total = System.Double.MaxValue;
            for (int linha = 0; linha < 5; linha++)
            {

               tempo_total_nadador = 0;
 
               for (int coluna = 0; coluna < 3; coluna++)
               {                     
                 tempo_total_nadador = tempo_total_nadador + provas[linha, coluna];        
               }//fim for coluna

               if (tempo_total_nadador < menor_tempo_total)
               {
                 menor_tempo_total = tempo_total_nadador;
                 indice_nadador_vencedor = linha;
               }

            }//fim for linha 
                
            Console.WriteLine("O nadador campeão foi: " + nadadores[indice_nadador_vencedor]);


             
        }
    }
}
