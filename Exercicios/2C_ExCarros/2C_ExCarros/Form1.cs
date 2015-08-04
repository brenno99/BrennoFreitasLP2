using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2C_ExCarros
{
    public partial class Form1_Carros : Form
    {
        public Form1_Carros()
        {
            InitializeComponent();
        }

        ArrayList carros = new ArrayList();
        
        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            Carro C = new Carro();

            C.Set_modelo(txtModelo.Text);
            C.Set_placa(txtPlaca.Text);
            C.Set_marca(txtMarca.Text);
            C.Set_ano(txtAno.Text);
            C.Set_kilometragem(double.Parse(txtKilometragem.Text));
            C.Set_capacidadeTanque(double.Parse(txtCapaTanque.Text));
            C.Set_potencia(txtPotencia.Text);

            carros.Add(C);

            txtModelo.Clear();
            txtPlaca.Clear();
            txtMarca.Clear();
            txtAno.Clear();
            txtKilometragem.Clear();
            txtCapaTanque.Clear();
            txtPotencia.Clear();

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            Carro b = new Carro();
            bool exist_placa = false;
           
            for (int i = 0; i < carros.Count; i++)
            {
                b = (Carro)carros[i];

                if (b.Get_placa() == txtPlaca.Text)
                {
                    exist_placa = true;
                }
            }// for

            if (exist_placa == true)
            {
                MessageBox.Show("Placa já registrada!");
            }
            else
            {
                MessageBox.Show("Placa não registrada!");
            }
        }
    }
}
