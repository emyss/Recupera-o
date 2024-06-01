using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Recuperação
{
    public partial class IMCform : Form
    {
        public IMCform()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double peso = double.Parse(txtPeso.Text);
            double altura = double.Parse(txtAltura.Text);
            double imc = peso / (altura * altura);
            string genero = rdbHomem.Checked ? "Homem" : "Mulher";
            double pesoIdealMin, pesoIdealMax;
            if (genero == "Homem")
            {
                pesoIdealMin = 20.7 * (altura * altura);
                pesoIdealMax = 26.4 * (altura * altura);
            }
            else
            {
                pesoIdealMin = 19.1 * (altura * altura);
                pesoIdealMax = 25.8 * (altura * altura);
            }
            lblResultado.Text = $"IMC: {imc:F2}\nPeso Ideal: {pesoIdealMin:F2}kg - {pesoIdealMax:F2}kg";
        }
    }
}
