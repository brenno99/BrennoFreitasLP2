using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;  
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2C_Trabalho1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
       
        //ArrayList carros = new ArrayList();
        List<Carro> carros = new List<Carro>();

        public int qtdCarrosInformada;
        public int qtdCarros = 0 ; 

        private void btn_Cadastrar_Click(object sender, EventArgs e)
        {
                qtdCarros = qtdCarros + 1;
                if (qtdCarros <= qtdCarrosInformada)
                {
                    Carro c = new Carro();
                    c.Set_idCarro(qtdCarros);
                    c.Set_modelo(txtModelo.Text);
                    c.Set_marca(txtMarca.Text);
                    c.Set_placa(txtPlaca.Text);
                    c.Set_capacCarro(int.Parse(txtCapacidadeCarro.Text));
                    c.Set_qtdPassag(0);
                    carros.Add(c);

                    Limpar_Campos();
                }
                else
                {
                    MessageBox.Show("Todos os carros já foram cadastrados!");
                    Limpar_Campos();
                }

                       
        }

        private void btn_Iniciar_Click(object sender, EventArgs e)
        {
            qtdCarrosInformada = int.Parse(txtQtdCarros.Text);
            txtModelo.Focus();
        }

        private void btn_Limpar_Click(object sender, EventArgs e)
        {
            Limpar_Campos();
        }


        private void Limpar_Campos()
        {
            txtModelo.Clear();
            txtMarca.Clear();
            txtPlaca.Clear();
            txtCapacidadeCarro.Clear();
            txtModelo.Focus();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int total_passag = 0;
            int qtd_vagas_disponiveis = 0;

            for (int k = 0; k < carros.Count; k++)
            {
                Carro c2 = new Carro();
                c2 = (Carro)carros[k];

                total_passag = total_passag + carros[k].Get_qtdPassag();

                qtd_vagas_disponiveis = carros[k].Get_capacCarro() - carros[k].Get_qtdPassag();
                txtCarros.AppendText("Carro " + (k + 1) + "\r\n" + "Modelo: " + carros[k].Get_modelo() + " - " + "Marca: " + carros[k].Get_marca() + " " + "Placa: " + carros[k].Get_placa() + "\r\n" + "\r\n" + "Quantidade de vagas disponíveis: " + qtd_vagas_disponiveis + "\r\n" + "\r\n");

                if (carros[k].Get_qtdPassag() >= carros[k].Get_capacCarro())
                {
                    txtCarros.AppendText("Carro lotado!");
                }
               
            } // for 
           
            txtCarros.AppendText("Total de pessoas na viagem: " + total_passag);
        } // listar passageiros
                     

        private void btn_Solicitar_Vaga_Click(object sender, EventArgs e)
        {

            int id_carro = int.Parse(txtidCarro.Text); 
            string existe_carro = "Não";
               
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
                            MessageBox.Show("O carro " + id_carro.ToString() +  " está lotado! " );
                        }
                        
                        else
                        {
                            c1.Set_qtdPassag(c1.Get_qtdPassag() + 1);
                            carros[k] = c1;
                            MessageBox.Show("Solicitação efetuada!");
                        }
                                                
                    }// get_idCarro == id_carro 

           }// for carros.Count

          if (existe_carro == "Não")
          {
             MessageBox.Show("Não existe o carro!");
          }

          txtidCarro.Clear(); 

        } // solicitar vaga 



        }
    }

