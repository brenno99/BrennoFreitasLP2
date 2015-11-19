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

            for (int i = 1; i <= qtdFuncs; i++)
            {
                Console.WriteLine("Digite qual funcionário é desejado: gerente, terceirizado ou trabalhador: ");
                tipoFuncionario = Console.ReadLine();

                if (tipoFuncionario == "terceirizado")
                {
                    Console.WriteLine("Nome : ");
                    t.Nome = (Console.ReadLine());

                    Console.WriteLine("Matricula : ");
                    t.Matricula = (Console.ReadLine());

                    Console.WriteLine("CPF : ");
                    t.CPF = (Console.ReadLine());

                    Console.WriteLine("Data Nascimento : ");
                    t.DataNascimento = (Console.ReadLine());

                    Console.Write("CNPJ : ");
                    t.CNPJ = (Console.ReadLine());
                    terceirizados.Add(t);
                    
                }

                else if (tipoFuncionario == "trabalhador")
                {
                    Console.Write("Nome: ");
                    tra.Nome = (Console.ReadLine());

                    Console.Write("Matrícula: ");
                    tra.Matricula = (Console.ReadLine());

                    Console.Write("Data de Nascimento: ");
                    tra.DataNascimento = (Console.ReadLine());

                    Console.Write("CPF: ");
                    tra.CPF = (Console.ReadLine());                   
                    
                    trabalhadores.Add(tra);
                    double valeAlimentacao_Trabalhador = tra.ValeAlimentacaoTrabalhador();
                }

                else if (tipoFuncionario == "gerente")
                {
                    Console.Write("Nome: ");
                    g.Nome = (Console.ReadLine());

                    Console.Write("Matrícula: ");
                    g.Matricula = (Console.ReadLine());

                    Console.Write("Data de Nascimento: ");
                    g.DataNascimento = (Console.ReadLine());

                    Console.Write("CPF: ");
                    g.CPF = (Console.ReadLine());

                    Console.Write("Área de Gerenciação: ");
                    g.AreaGerenciada = (Console.ReadLine());
                    gerentes.Add(g);
                    
                }
            }//fim for - leitura 

            if (terceirizados.Count > 0)
            {
                Console.WriteLine("Terceirizados");

                for (int j = 0; j < terceirizados.Count; j++)
                {
                    Console.WriteLine("Nome: " + terceirizados[j].Nome);
                    Console.WriteLine("Terceirizado: " + terceirizados[j].Matricula);
                    Console.WriteLine("Data de Nascimento: " + terceirizados[j].DataNascimento);
                    Console.WriteLine("CPF: " + terceirizados[j].CPF);
                    Console.WriteLine("CNPJ: " + terceirizados[j].CNPJ);

                }
            }// fim terceirizado

            if (gerentes.Count > 0)
            {
                Console.WriteLine("Gerentes");

                for (int n = 0; n < gerentes.Count; n++)
                {
                   Console.WriteLine("Nome" + gerentes[n].Nome);
                   Console.WriteLine("Matrícula: " + gerentes[n].Matricula);
                   Console.WriteLine("Data de Nascimento: " + gerentes[n].DataNascimento);
                   Console.WriteLine("CPF: " + gerentes[n].CPF);
                   Console.WriteLine("Salário: " + gerentes[n].Salario);
                   Console.WriteLine("Área de atuação: " + gerentes[n].AreaGerenciada);
                 
                   double valeAlimentacaoGerente = gerentes[n].ValeAlimentacaoGerente();
                   Console.WriteLine("Vale Alimentação: " + valeAlimentacaoGerente);
                 
                   despesa_total_empresa += gerentes[n].Salario + valeAlimentacaoGerente;
            }
         }

            if (trabalhadores.Count > 0)
            {
                Console.WriteLine("Trabalhadores");
                
                for (int o = 0; o < trabalhadores.Count; o++)
                {
                    Console.WriteLine("Nome: " + trabalhadores[o].Nome);
                    Console.WriteLine("Matrícula: " + trabalhadores[o].Matricula);
                    Console.WriteLine("Data de Nascimento: " + trabalhadores[o].DataNascimento);
                    Console.WriteLine("CPF: " + trabalhadores[o].CPF);
                    Console.WriteLine("Salário: " + trabalhadores[o].Salario());

                    double valeAlimentacaoTrabalhador = trabalhadores[o].ValeAlimentacaoTrabalhador();
                    Console.WriteLine("Vale Alimentação: " + valeAlimentacaoTrabalhador);

                    despesa_total_empresa += trabalhadores[o].Salario() + trabalhadores[o].ValeAlimentacaoTrabalhador();
                }
            }

            Console.WriteLine("Despesa da empresa com o salário mensal de seus funcionários: " + despesa_total_empresa);

           }
        }           
    }

