using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3C_Exercicio12
{
    class Gerente: Funcionario
    {
        public double Salario { get; set; }

        public string AreaGerenciada { get; set; }

        public double _SalarioAdicional;
        
        public void Set_SalarioAdicional(double salarioAdicional)
        {
            _SalarioAdicional = salarioAdicional;
        }

        public  double ValeAlimentacaoGerente()
        {
            double valor_alimentacao;
            valor_alimentacao = (Salario + _SalarioAdicional) * 6.5 / 100;

            if (valor_alimentacao > 750)
            {
                valor_alimentacao = 750;
            }

            return ValeAlimentacaoGerente();
        } 
    }
}
      