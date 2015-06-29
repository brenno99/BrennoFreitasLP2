using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2C_Aula23062015
{
    class Funcionario
    {
        public ArrayList nomes = new ArrayList();
        public ArrayList cpf = new ArrayList();
        public ArrayList datasNasc = new ArrayList();
        public ArrayList datasAdmi = new ArrayList();
        public ArrayList salarios = new ArrayList();


        public double CalculaSalarioReajust(int j)
        {
            double salario_reajust = 0;

            if (Convert.ToInt32(datasAdmi[j]) >= 2014)
            {
                salario_reajust = Convert.ToDouble(salarios[j]) + 423.45;
            }

            else if (Convert.ToInt32(datasAdmi[j]) >= 2010 && Convert.ToInt32(datasAdmi[j]) <= 2013)
            {
                double aumento = Convert.ToDouble(salarios[j]) * 9.84 / 100;
                salario_reajust = Convert.ToDouble(salarios[j]) + aumento;
            }

            else if (Convert.ToInt32(datasAdmi[j]) >= 2000 && Convert.ToInt32(datasAdmi[j]) <= 2009)
            {
                double aumento2 = Convert.ToDouble(salarios[j]) * 16.4 / 100;
                salario_reajust = Convert.ToDouble(salarios[j]) + aumento2;
            }

            else if (Convert.ToInt32(datasAdmi[j]) <= 1999)
            {
                double aumento3 = Convert.ToDouble(salarios[j]) * 22.6 / 100;
                salario_reajust = Convert.ToDouble(salarios[j]) + aumento3;
            }

            return salario_reajust;
        }
        

    }
}
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
   

