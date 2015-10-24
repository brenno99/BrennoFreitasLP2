using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula_15092015
{
    class Terceirizadp: Funcionario
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
