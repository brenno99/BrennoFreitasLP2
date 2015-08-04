using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2C_ExCarros
{
    class Carro
    {
       private string _modelo;
       private string _placa;
       private string _marca;
       private string _ano;
       private double _kilometragem;
       private double _capacidadeTanque;
       private string _potência;

       public void Set_placa(string placa)
       {
           _placa = placa;
       }

       public string Get_placa()
       {
           return _placa;
       }

       public void Set_modelo(string modelo)
       {
           _modelo = modelo;
       }

       public string Get_modelo()
       {
           return _modelo;
       }

       public void Set_marca(string marca)
       {
           _marca = marca;
       }

       public string Get_marca()
       {
           return _marca;
       }

       public void Set_ano(string ano)
       {
           _ano = ano;
       }

       public string Get_ano()
       {
           return _ano;
       }

       public void Set_kilometragem(double kilometragem)
       {
           _kilometragem = kilometragem;
       }

       public double Get_kilometragem()
       {
           return _kilometragem;
       }

       public void Set_capacidadeTanque(double capacidadeTanque)
       {
           _capacidadeTanque = capacidadeTanque;
       }

       public double Get_capacidadeTanque()
       {
           return _capacidadeTanque;
       }

       public void Set_potencia(string potencia)
       {
           _potência = potencia;
       }

       public string Get_potencia()
       {
           return _potência;
       }
    
    }
}
