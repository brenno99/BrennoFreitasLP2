using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista1
{
    class Program
    {
             
        static void Main(string[] args)
        {
            int exercicio = 0;
            Console.WriteLine("Digite o exercício desejado: ");
            exercicio = int.Parse(Console.ReadLine());
           
            while (exercicio <= 8)
            {
                if (exercicio == 1)

                    FExercicio1();

                else if (exercicio == 2)

                    FExercicio2();

                else if (exercicio == 3)

                    FExercicio3();

                else if (exercicio == 4)

                    FExercicio4();

                else if (exercicio == 5)

                    FExercicio5();

                else if (exercicio == 6)

                    FExercicio6();

                else if (exercicio == 7)

                    FExercicio7();

                else if (exercicio == 8)

                    FExercicio8();
                                         
               exercicio++;
            }
               
        }// staic 

        public static void FExercicio1()
        {
            Console.WriteLine("Exercico 1 " );

            int N = 0;                    
            Console.WriteLine("Digite o valor de N: ");
            N = int.Parse(Console.ReadLine());           

            Console.WriteLine("O fatorial de N é: " + FFatorial(N));
        } 


        public static int FFatorial(int N)
        {
            int qtd_vezes = 0;
            int fatorial = 1;
            qtd_vezes = N;

            for (int i = 1; i <= qtd_vezes; i++)
            {
                fatorial = fatorial * N;
                N = N - 1;
            }
            
            return fatorial; 
        }// fim FExercicio1



        public static void FExercicio2() {

            Console.WriteLine("Exercico 2 ");

            int N = 0;
            int x = 1;
            double resultado = 0;
            string operador = "+";
            double divisor = 1;
            double fatorial = 0; 

            Console.WriteLine("Digite o valor de N: ");
            N = int.Parse(Console.ReadLine());

            while (x <= N)
            {
                if (operador == "+")
                {
                    fatorial = FFatorial(x); 
                    resultado = resultado + (fatorial / divisor);
                }

                else
                {
                    fatorial = FFatorial(x);
                    resultado = resultado - (fatorial / divisor);
                }

                if (operador == "+")
                {
                    operador = "-";
                }

                else
                {
                    operador = "+";
                }

                divisor = (divisor * 2) + 1;
                x++;

            }

            Console.WriteLine("O resultado da equação é: " + resultado);


        }// fim FExercicio2

        public static void FExercicio3()
        {
            Console.WriteLine("Exercício 3: ");
            
            int qtd_funcionarios = 0;
            Console.WriteLine("Digite o número de funcionários: ");
            qtd_funcionarios = int.Parse(Console.ReadLine());
            
            string[] funcionarios = new string[qtd_funcionarios];
            double[] salarios = new double[qtd_funcionarios];
            
            string nome = "";
            double salario2 = 0;
            
            for (int i = 0; i < qtd_funcionarios; i++)
            {
                Console.WriteLine("Informe o nome do funcionario: ");
                nome = Console.ReadLine();
                funcionarios[i] = nome;

                Console.WriteLine("Informe o salário do funcionário: ");
                salario2 = double.Parse(Console.ReadLine());
                salarios[i] = salario2;

            } // for 
            
            for (int k = 0; k < qtd_funcionarios; k++)
            {
                Console.WriteLine("O funcionário é: {0}, o salário do mesmo é: {1} e seu salário reajustado é: {2}",
                funcionarios[k], salarios[k], F_SalarioAjustado(salarios[k]));

            }

        }//fim FExercicio3

        public static double F_SalarioAjustado(double salario_func)
        {
            double salario_reajust = 0;

            if (salario_func >= 0 && salario_func <= 2999)
            {
                salario_reajust = salario_func + (salario_func * 0.25);
            }

            if (salario_func >= 3000 && salario_func <= 3999)
            {
                salario_reajust = salario_func + (salario_func * 0.20);
            }

            if (salario_func >= 4000 && salario_func <= 4999)
            {
                salario_reajust = salario_func + (salario_func * 0.15);
            }

            if (salario_func >= 5000)
            {
                salario_reajust = salario_func + (salario_func * 0.10);
            }

            return salario_reajust;

        } // fim funçao F_SalarioAjustado

        public static void FExercicio4()
        {
            Console.WriteLine("Exercício 4: ");
            
            int codigo_jogador = 0;
            int qtd_pontos_jogador1 = 0;
            int qtd_pontos_jogador2 = 0;
            int codigo_jogador_vencedor = 0;

            while (codigo_jogador_vencedor == 0)
            {
                Console.WriteLine("Digite o código do jogador que ganhou a partida: ");
                codigo_jogador = int.Parse(Console.ReadLine());

                if (codigo_jogador == 1)
                {
                    qtd_pontos_jogador1 = qtd_pontos_jogador1 + 1;
                }

                if (codigo_jogador == 2)
                {
                    qtd_pontos_jogador2 = qtd_pontos_jogador2 + 1;
                }

                //verifacando quem é o vencedor
                if ((qtd_pontos_jogador1 == 21) && (qtd_pontos_jogador1 - qtd_pontos_jogador2 >= 2))
                {
                    codigo_jogador_vencedor = 1;
                }

                if ((qtd_pontos_jogador1 >= 21) && (qtd_pontos_jogador1 - qtd_pontos_jogador2 >= 2))
                {
                    codigo_jogador_vencedor = 1;
                }

                if ((qtd_pontos_jogador2 == 21) && (qtd_pontos_jogador2 - qtd_pontos_jogador1 >= 2))
                {
                    codigo_jogador_vencedor = 2;
                }

                if ((qtd_pontos_jogador2 >= 21) && (qtd_pontos_jogador2 - qtd_pontos_jogador1 >= 2))
                {
                    codigo_jogador_vencedor = 2;
                }

                Console.WriteLine("A quantidade dos pontos do jogaodor 1 é: " + qtd_pontos_jogador1);
                Console.WriteLine("A quantidade dos pontos do jogador 2 é: " + qtd_pontos_jogador2);
                
            }//Fim while

            Console.WriteLine("O jogador vencedor é: " + codigo_jogador_vencedor);
          }//Fim FExercicio4

        public static void FExercicio5()
        {
            Console.WriteLine("Exercício 5: ");
            
            double distanc_perc_ultima_medicao = 0;
            double litros_usados_ultima_medicao = 0;
            double total_perc = 0;
            double total_litros_usados = 0;
            
            while (total_perc <= 600 && total_litros_usados <= 50)
            {
                Console.WriteLine("Digite a distância percorrida desde a última medição: ");
                distanc_perc_ultima_medicao = double.Parse(Console.ReadLine());

                Console.WriteLine("Digite os litros usados nesta distância: ");
                litros_usados_ultima_medicao = double.Parse(Console.ReadLine());

                total_perc = total_perc + distanc_perc_ultima_medicao;

                total_litros_usados = total_litros_usados + litros_usados_ultima_medicao;

                if (total_litros_usados <= 50 && total_perc >= 600)
                {
                    Console.WriteLine("O veículo chegou ao seu destino!");
                }

                else if (total_litros_usados >= 50 && total_perc <= 600)
                {
                    Console.WriteLine("O veículo parou por falta de combustível!");
                }

            }//fim while

            Console.WriteLine("O desempenho médio do carro foi: " + total_perc / total_litros_usados);
         
          }// Fim FExercicio5()

        public static void FExercicio6()
        {
            ArrayList nomes = new ArrayList();
            ArrayList alturas = new ArrayList();

            string nome_modelo = "";
            int altura_modelo = 0;

            int maior_altura = 0;
            int segunda_maior_altura = 0;

            int qtd_modelos_maior_altura = 0;
            int qtd_modelos_segunda_maior_altura = 0;

            while (nome_modelo != "Fim")
            {

                Console.WriteLine("Digite o nome da modelo: ");
                nome_modelo = Console.ReadLine();

                Console.WriteLine("Digite a altura da modelo: ");
                altura_modelo = int.Parse(Console.ReadLine());

                nomes.Add(nome_modelo);
                alturas.Add(altura_modelo);

                if (altura_modelo > maior_altura)
                {
                    maior_altura = altura_modelo;
                }

            }

            // Inicializa um array com o tamanho do ArratList 
            int[] alturas_Array = new int[alturas.Count];

            // Copia todos os itens do ArrayList para o novo Array 
            alturas.CopyTo(alturas_Array);


            for (int i = 0; i < alturas_Array.Length; i++)
            {
                if (alturas_Array[i] == maior_altura)
                {
                    qtd_modelos_maior_altura = qtd_modelos_maior_altura + 1;
                }

            }

            // print a maior altura é ...... 
            // print a qdt de modelos da maior altura é 
            Console.WriteLine("A maior altura é: " + maior_altura);
            Console.WriteLine("A quantidade de modelos que possui a maior altura é: " + qtd_modelos_maior_altura);


            // percorrer novamente o array de alturas e verificar 
            // a segunda maior altura 
            // descartar as linhas que tem a maior altura 
            for (int i = 0; i < alturas_Array.Length; i++)
            {
                if (alturas_Array[i] == segunda_maior_altura)
                {
                    qtd_modelos_segunda_maior_altura = qtd_modelos_segunda_maior_altura + 1;
                }
            }

            Console.WriteLine("A segunda maior altura é: " + segunda_maior_altura);
            Console.WriteLine("A quantidade de mulheres com a segunda maior altura é: " + qtd_modelos_segunda_maior_altura);
       
       }//Fim FExercicio6()

        public static void FExercicio7()
        {
            Console.WriteLine("Exercício 7: ");
            
            int numero_prova = 0;
            int qtd_nadadores = 1;
            string nome_nadador = "";
            int classificacao = 0;
            double tempo = 0;
            string clube = "";
            int qtd_pontosA = 0;
            int qtd_pontosB = 0;
            int pontos = 0;

            while (numero_prova != 9999)
            {
                Console.WriteLine("Digite o número da prova: ");
                numero_prova = int.Parse(Console.ReadLine());
                
                Console.WriteLine("Digite a quantidade de nadadores: ");
                qtd_nadadores = int.Parse(Console.ReadLine());

                for (int i = 0; i < qtd_nadadores; i++)
                {
                    Console.WriteLine("Digite o nome do nadador: ");
                    nome_nadador = Console.ReadLine();

                    Console.WriteLine("Digite a classificação do nadador: ");
                    classificacao = int.Parse(Console.ReadLine());

                    Console.WriteLine("Digite o clube do nadador: ");
                    clube = Console.ReadLine();

                    Console.WriteLine("Digite o tempo do nadador: ");
                    tempo = double.Parse(Console.ReadLine());

                    pontos = FPontos(classificacao);

                    if (clube == "A")
                    {
                        qtd_pontosA = qtd_pontosA + pontos;
                    }
                    else
                    {
                        qtd_pontosB = qtd_pontosB + pontos;
                    }

                }//fim for qtd_nadadores
                
                if (qtd_nadadores != 0)
                {
                  
                    if (qtd_pontosA > qtd_pontosB)
                    {
                        Console.WriteLine("O vencedor foi o clube A");
                    }     
                      else 
                    {
                        if (qtd_pontosB > qtd_pontosA)
                        {
                            Console.WriteLine("O vencedor foi o clube B");
                        }
                        else
                        {
                            Console.WriteLine("O resultado foi empate entre os clube");
                        }

                    }// fim else

                }//fim qtd_nadadores != 0

                // para uma nova partida zerar a qtd de pontos dos clubes
                qtd_pontosA = 0;
                qtd_pontosB = 0;

            }//fim while

        }//static void Main

        public static int FPontos(int classificacao)
        {
            int ponto_classif = 0; 
          
            if (classificacao == 1)
            {
                ponto_classif = 9;
            }

            if (classificacao == 2)
            {
                ponto_classif = 6;
            }

            if (classificacao == 3)
            {
                ponto_classif = 4;
            }

            if (classificacao == 4)
            {
                ponto_classif = 3;
            }

            if (classificacao >= 5)
            {
                ponto_classif = 0;
            }

            return ponto_classif; 
        } // fim  FPontos 

       public static void FExercicio8() 
       {
           Console.WriteLine("Exercício 8: ");
           
           int N = 0;
           int soma = 0;

           Console.WriteLine("Informe o valor de N: ");
           N = int.Parse(Console.ReadLine());

           while (N >= 1)
           {
               soma = soma + N;
               N--;
           }

           Console.WriteLine("A soma dos números compriendidos entre 1 e N é: " + soma);
             
        }//Fim FExercicio8()
                         
    } // class 
}// name space