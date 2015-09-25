using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3C_Exercicio12
{
    class Program
    {
        static void Main(string[] args)
        {
            string tipoFuncionario;
            double despesa_total_empresa = 0;

            Console.WriteLine("Informe a quantidade de funcionarios:");
            int qtdFuncs = int.Parse(Console.ReadLine());

            List<Terceirizado> terceirizados = new List<Terceirizado>();
            List<Gerente> gerentes = new List<Gerente>();
            List<Trabalhador> trabalhadores = new List<Trabalhador>();

            Terceirizado t = new Terceirizado();
            Trabalhador tra = new Trabalhador();
            Gerente g = new Gerente();

            int a = 0; int b = 0; int c = 0;

            for (int i = 1; i <= qtdFuncs; i++)
            {
                Console.WriteLine("Digite qual funcionário é desejado: gerente, terceirizado ou trabalhador: ");
                tipoFuncionario = Console.ReadLine();

                if (tipoFuncionario == "terceirizado")
                {
                    Console.WriteLine("Nome : ");
                    t.Set_nome(Console.ReadLine());

                    Console.WriteLine("Matricula : ");
                    t.Set_matricula(Console.ReadLine());

                    Console.WriteLine("CPF : ");
                    t.Set_cpf(Console.ReadLine());

                    Console.WriteLine("Data Nascimento : ");
                    t.Set_dataNascimento(Console.ReadLine());

                    Console.Write("CNPJ : ");
                    t.Set_cnpj(Console.ReadLine());
                    terceirizados.Add(t);
                    a++;
                }

              else if (tipoFuncionario == "trabalhador")
                {
                    double valeAlimentacao_Trabalhador = tra.ValeAlimentacaoTrabalhador();

                    Console.Write("Nome: ");
                    tra.Set_nome(Console.ReadLine());

                    Console.Write("Matrícula: ");
                    tra.Set_matricula(Console.ReadLine());

                    Console.Write("Data de Nascimento: ");
                    tra.Set_dataNascimento(Console.ReadLine());

                    Console.Write("CPF: ");
                    tra.Set_cpf(Console.ReadLine());

                    trabalhadores.Add(tra);
                    b++;
                }

                else if (tipoFuncionario == "gerente")
                {
                    Console.Write("Nome: ");
                    g.Set_nome(Console.ReadLine());

                    Console.Write("Matrícula: ");
                    g.Set_matricula(Console.ReadLine());

                    Console.Write("Data de Nascimento: ");
                    g.Set_dataNascimento(Console.ReadLine());

                    Console.Write("CPF: ");
                    g.Set_cpf(Console.ReadLine());

                    Console.Write("Área de Gerenciação: ");
                    g.Set_areaGerenciada(Console.ReadLine());
                    gerentes.Add(g);
                    c++;
                }
            }//fim for - leitura 

            if (terceirizados.Count > 0)
            {
                Console.WriteLine("Terceirizados");

                for (int j = 0; j < terceirizados.Count; j++)
                {
                    Console.WriteLine("Nome: " + terceirizados[j].Get_nome());
                    Console.WriteLine("Terceirizado: " + terceirizados[j].Get_matricula());
                    Console.WriteLine("Data de Nascimento: " + terceirizados[j].Get_dataNascimento());
                    Console.WriteLine("CPF: " + terceirizados[j].Get_cpf());
                    Console.WriteLine("CNPJ: " + terceirizados[j].Get_cnpj());

                }
            }// fim terceirizado

            if (gerentes.Count > 0)
            {
                Console.WriteLine("Gerentes");

                for (int n = 0; n < gerentes.Count; n++)
                {
                   double valeAlimentacaoGerente = gerentes[n].ValeAlimentacaoGerente();

                   Console.WriteLine("Nome" + gerentes[n].Get_nome());
                   Console.WriteLine("Matrícula: " + gerentes[n].Get_matricula());
                   Console.WriteLine("Data de Nascimento: " + gerentes[n].Get_dataNascimento());
                   Console.WriteLine("CPF: " + gerentes[n].Get_cpf());
                   Console.WriteLine("Salário: " + gerentes[n].Get_salario());
                   Console.WriteLine("Área de atuação: " + gerentes[n].Get_areaGerenciada());
                   Console.WriteLine("Vale Alimentação: " + valeAlimentacaoGerente);
                   Console.WriteLine();

                despesa_total_empresa += gerentes[n].Get_salario() + valeAlimentacaoGerente;
            }
         }

            if (trabalhadores.Count > 0)
            {
                Console.WriteLine("Trabalhadores");
                
                for (int o = 0; o < trabalhadores.Count; o++)
                {
                    double valeAlimentacaoTrabalhador = trabalhadores[o].ValeAlimentacaoTrabalhador();

                    Console.WriteLine("Nome: " + trabalhadores[o].Get_nome());
                    Console.WriteLine("Matrícula: " + trabalhadores[o].Get_matricula());
                    Console.WriteLine("Data de Nascimento: " + trabalhadores[o].Get_dataNascimento());
                    Console.WriteLine("CPF: " + trabalhadores[o].Get_cpf());
                    Console.WriteLine("Salário: " + trabalhadores[o].Get_salario());
                    Console.WriteLine("Vale Alimentação: " + valeAlimentacaoTrabalhador);

                    despesa_total_empresa += trabalhadores[o].Get_salario() + trabalhadores[o].ValeAlimentacaoTrabalhador();
                }
            }

            Console.WriteLine("Despesa da empresa com o salário mensal de seus funcionários: " + despesa_total_empresa);

           }
        }           
    }

