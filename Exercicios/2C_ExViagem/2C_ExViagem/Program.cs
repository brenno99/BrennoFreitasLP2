using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2C_ExViagem
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList carros = new ArrayList();
            Console.WriteLine("Qtd. Carros:");
            int qtdCarros = int.Parse(Console.ReadLine());

            for (int i = 1; i <= qtdCarros; i++)
            {
                Carro c = new Carro();
                c.Set_idCarro(i);
                Console.WriteLine("Modelo:");
                c.Set_modelo(Console.ReadLine());
                Console.WriteLine("Marca:");
                c.Set_marca(Console.ReadLine());
                Console.WriteLine("Placa:");
                c.Set_placa(Console.ReadLine());
                Console.WriteLine("Cap. Carro:");
                c.Set_capacCarro(int.Parse(Console.ReadLine()));
                c.Set_qtdPassag(0) ;                 
                carros.Add(c);            
            }//fim for


            // leitura dos IDs do carro 
            int id_carro = 0;
            string existe_carro = "Não";
            while (id_carro >= 0)
            {
                Console.WriteLine("Informe o ID do carro:");
                id_carro = int.Parse(Console.ReadLine());
                
                // Pesquisar o id_carro no array de objetos 
                
                for (int k = 0; k < carros.Count; k++)
                {
                    Carro c1 = new Carro();
                    c1 = (Carro)carros[k];                   
                   
                                       
                    if (c1.Get_idCarro() == id_carro)
                    {
                        existe_carro = "Sim";
                       
                        if (c1.Get_qtdPassag() >= c1.Get_capacCarro())
                        {
                            Console.WriteLine("O carro {0} está lotado: ", id_carro);
                        }
                        
                        else
                        {
                            c1.Set_qtdPassag(c1.Get_qtdPassag() + 1);
                            carros[k] = c1;
                        }
                                                
                    }// get_idCarro == id_carro 

                }// for carros.Count

                if (existe_carro == "Não")
                {
                    Console.WriteLine("Não existe o carro!");
                }
                 
            }// fim while

            int total_passag = 0;
           
            for (int k = 0; k < carros.Count; k++)
            {
                Carro c2 = new Carro();
                c2 = (Carro)carros[k];
                total_passag = total_passag + c2.Get_qtdPassag();
                Console.WriteLine("Carro {0}: {1} - {2} ({3}) : " , c2.Get_idCarro() , c2.Get_modelo() , c2.Get_marca() , c2.Get_placa());
                Console.WriteLine("Passageiros : " + c2.Get_qtdPassag());
                if (c2.Get_qtdPassag() >= c2.Get_capacCarro())
                {
                    Console.WriteLine("O carro lotado");
                }
                else {
                    Console.WriteLine("Vagas restantes: " + (c2.Get_capacCarro() - c2.Get_qtdPassag()));                
                }
              
            }// for carros.Count
            
            Console.WriteLine("Total de pessoas na viagem: " + total_passag);

           } // void 



       } //  Class Program 
   } 
