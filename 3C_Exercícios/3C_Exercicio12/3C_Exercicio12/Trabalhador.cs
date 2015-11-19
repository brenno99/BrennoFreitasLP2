using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3C_Exercicio12
{
    class Trabalhador: Funcionario
    {
        private double _salario = 5000;

        public  double Salario()
        {
            return _salario;
        }

        public  double ValeAlimentacaoTrabalhador()
        {
            double valor_alimentacao;

            valor_alimentacao = _salario + 8 / 100;

            if (valor_alimentacao > 750)
            {
                valor_alimentacao = 750;
            }

            return ValeAlimentacaoTrabalhador();
        }   
   
    }
}
