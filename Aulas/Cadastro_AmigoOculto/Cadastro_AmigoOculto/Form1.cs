using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace Cadastro_AmigoOculto
{
    public partial class Form1 : Form
    {
        List<Pessoa> pessoas = new List<Pessoa>();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            foreach (Pessoa p in pessoas)
            {
                p.Salvar();
            }
        }

        private void btnStatus_Click(object sender, EventArgs e)
        {
            MessageBox.Show(String.Format("O número de cadastros é: {0}", pessoas.Count));
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            Pessoa p = new Pessoa();

            p.Nome = txtNome.Text;
            p.Sobrenome = txtSobreNome.Text;

            p.Presentes[0] = txtPresente1.Text;
            p.Presentes[1] = txtPresente2.Text;
            p.Presentes[2] = txtPresente3.Text;

            pessoas.Add(p);

            txtNome.Clear();
            txtSobreNome.Clear();
            txtPresente1.Clear();
            txtPresente2.Clear();
            txtPresente3.Clear();
        }
    }
}
