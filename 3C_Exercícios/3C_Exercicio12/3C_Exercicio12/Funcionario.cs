using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3C_Exercicio12
{
    class Funcionario
    {
        private string _nome;
        private string _matricula;
        private string _cpf;
        public string _dataNascimento;
        
        public void Set_nome(string nome)
        {
            _nome = nome;
        }

        public string Get_nome()
        {
            return _nome;
        }

        public void Set_matricula(string matricula)
        {
            _matricula = matricula;
        }

        public string Get_matricula()
        {
            return _matricula;
        }
        
        public void Set_cpf(string cpf)
        {
            _cpf = cpf;
        }

        public string Get_cpf()
        {
            return _cpf;
        }

        public void Set_dataNascimento(string dataNascimento)
        {
            _dataNascimento = dataNascimento;
        }

        public string Get_dataNascimento()
        {
            return _dataNascimento;
        }

    }
}
