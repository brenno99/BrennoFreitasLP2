using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula14072015
{
    class Cachorro
    {
        private double _tamanhoCm;
        private string _nome;
        private double _peso;

        public double RacaoDiariaKg()
        {
            double resultado;

            resultado = _peso / (_tamanhoCm * _tamanhoCm);
            return resultado /  10;
        }

        public void SetNome(string name)
        {
          this._nome = name; 
        }

        public void SetPeso(double peso)
        {
            this._peso = peso;
        }
    
        public string GetNome()
        {
            return _nome;
        }

        public double GetPeso()
        {
            return _peso;
        }

        public void SetTamanhoCm(double tamanho)
        {
            this._tamanhoCm = tamanho;

        }

        public double GetTamanhoCm()
        {
            return _tamanhoCm;
        }
    
    
    
    
    }
}
