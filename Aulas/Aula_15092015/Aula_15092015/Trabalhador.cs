using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula_15092015
{
    class Trabalhador: Funcionario
    {
        private double _salario;
         
        public void Set_salario(double salario)
        {
            _salario = salario;
        }

        public double Get_salario()
        {
            return _salario;
        }

        public double ValeAlimentacao()
        {
            double valor;
            double valor_maximo = 750; 

            valor = _salario * 8/100;

            if (valor >= valor_maximo)
            {
                return valor_maximo;
            }
            else
            {
                return valor;
            }
        
        }
    
    
    
    
    }
}
