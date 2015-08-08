using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2C_Trabalho1
{
    class Carro
    {
        private int _idCarro;
        private string _modelo;
        private string _marca;
        private string _placa;
        private int _capacCarro;
        private int _qtdPassag;

        public void Set_idCarro(int idCarro)
        {
            _idCarro = idCarro;
        }

        public int Get_idCarro()
        {
            return _idCarro;
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

        public void Set_placa(string placa)
        {
            _placa = placa;
        }

        public string Get_placa()
        {
            return _placa;
        }

        public void Set_capacCarro(int capacidade)
        {
            _capacCarro = capacidade;
        }

        public int Get_capacCarro()
        {
            return _capacCarro;
        }

        public void Set_qtdPassag(int qtdPassag)
        {
            _qtdPassag = qtdPassag;
        }

        public int Get_qtdPassag()
        {
            return _qtdPassag;
        }
       
    }
}
