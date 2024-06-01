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
    public partial class FormasForm : Form
    {
        public FormasForm()
        {
            InitializeComponent();
            cbxForma.SelectedIndexChanged += cbxForma_SelectedIndexChanged;
            btnCalcular.Click += btnCalcular_Click;
            this.Load += FormasForm_Load;
        }
        private void FormasForm_Load(object sender, EventArgs e)
        {
            cbxForma.Items.AddRange(new string[] { "Círculo", "Triângulo", "Quadrilátero" });
            cbxForma.SelectedIndex = 0;
        }
        private void cbxForma_SelectedIndexChanged(object sender, EventArgs e)
        {
            string forma = cbxForma.SelectedItem.ToString();
            ResetParametros();
            if (forma == "Círculo")
            {
                lblP1.Text = "Diâmetro";
                txtP1.Visible = true;
                lblP1.Visible = true;
                txtP2.Visible = false;
                lblP2.Visible = false;
                txtP3.Visible = false;
                lblP3.Visible = false;
                txtP4.Visible = false;
                lblP4.Visible = false;
            }
            else if (forma == "Triângulo")
            {
                lblP1.Text = "Lado 1";
                lblP2.Text = "Lado 2";
                lblP3.Text = "Lado 3";
                txtP1.Visible = true;
                lblP1.Visible = true;
                txtP2.Visible = true;
                lblP2.Visible = true;
                txtP3.Visible = true;
                lblP3.Visible = true;
                txtP4.Visible = false;
                lblP4.Visible = false;
            }
            else if (forma == "Quadrilátero")
            {
                lblP1.Text = "Lado 1";
                lblP2.Text = "Lado 2";
                lblP3.Text = "Lado 3";
                lblP4.Text = "Lado 4";
                txtP1.Visible = true;
                lblP1.Visible = true;
                txtP2.Visible = true;
                lblP2.Visible = true;
                txtP3.Visible = true;
                lblP3.Visible = true;
                txtP4.Visible = true;
                lblP4.Visible = true;
            }
        }
        private void btnCalcular_Click(object sender, EventArgs e)
        {
            string forma = cbxForma.SelectedItem.ToString();
            double resultado = 0;
            if (forma == "Círculo")
            {
                if (double.TryParse(txtP1.Text, out double diametro) && diametro > 0)
                {
                    double raio = diametro / 2;
                    resultado = Math.PI * raio * raio;
                    lblResultado.Text = $"Área do Círculo: {resultado:F2}";
                }
                else
                {
                    lblResultado.Text = "Por favor, insira um diâmetro válido.";
                }
            }
            else if (forma == "Triângulo")
            {
                if (double.TryParse(txtP1.Text, out double lado1) && double.TryParse(txtP2.Text, out double lado2) &&
                double.TryParse(txtP3.Text, out double lado3) &&
                lado1 > 0 && lado2 > 0 && lado3 > 0)
                {
                    if (lado1 + lado2 > lado3 && lado1 + lado3 > lado2 && lado2 + lado3 > lado1)
                    {
                        resultado = lado1 + lado2 + lado3;
                        lblResultado.Text = $"Perímetro do Triângulo: {resultado:F2}";
                    }
                    else
                    {
                        lblResultado.Text = "Triângulo Inválido";
                    }
                }
                else
                {
                    lblResultado.Text = "Por favor, insira valores válidos para os lados.";
                }
            }
            else if (forma == "Quadrilátero")
            {
                if (double.TryParse(txtP1.Text, out double lado1) && double.TryParse(txtP2.Text, out double lado2) &&
                double.TryParse(txtP3.Text, out double lado3) && double.TryParse(txtP4.Text, out double lado4) &&
                lado1 > 0 && lado2 > 0 && lado3 > 0 && lado4 > 0)
                {
                    if (lado1 + lado2 + lado3 > lado4 && lado1 + lado3 + lado4 > lado2 && lado2 + lado3 + lado4 > lado1)
                    {
                        resultado = lado1 + lado2 + lado3 + lado4;
                        lblResultado.Text = $"Perímetro do Quadrilátero: {resultado:F2}";
                    }
                    else
                    {
                        lblResultado.Text = "Quadrilátero Inválido";
                    }
                }
                else
                {
                    lblResultado.Text = "Por favor, insira valores válidos para os lados.";
                }
            }
        }
        private void ResetParametros()
        {
            txtP1.Text = "";
            txtP2.Text = "";
            txtP3.Text = "";
            txtP4.Text = "";
            txtP1.Visible = false;
            lblP1.Visible = false;
            txtP2.Visible = false;
            lblP2.Visible = false;
            txtP3.Visible = false;
            lblP3.Visible = false;
            txtP4.Visible = false;
            lblP4.Visible = false;
        }
    }
}