using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3C_Exercicio12
{
    class Terceirizado: Funcionario
    {
        private string _cnpj;

        public void Set_cnpj(string cnpj)
        {
            _cnpj = cnpj;
        }

        public string Get_cnpj()
        {
            return _cnpj;
        }

    }
}
