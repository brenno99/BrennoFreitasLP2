using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula_15092015
{
    class Gerente: Funcionario
    {
        private double _salario;
        private string _areaGerenciada;
        private double _salarioAdicional;
        
        public void Set_salario(double salario)
        {
            _salario = salario;
        }

        public double Get_salario()
        {
            return _salario;
        }

        public void Set_areaGerenciada(string areaGrenciada)
        {
            _areaGerenciada = areaGrenciada;
        }

        public string Get_areaGerenciada()
        {
            return _areaGerenciada;
        }

        public void Set_salarioAdicional(double salarioAdicional)
        {
            _salarioAdicional = salarioAdicional;
        }

        public double Get_salario()
        {
            return _salarioAdicional;
        }

        public double ValeAlimentacao()
        {
            double valor;
            double valor_maximo = 750;

            valor = (_salario + _salarioAdicional) * 6.5 / 100;

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
