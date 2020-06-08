using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora
{
    public partial class Calculadora : Form
    {
        float num1, num2;
        char operador;
        Operaciones Operacion;

        public Calculadora()
        {
            InitializeComponent();
        }

        private void boton0_Click(object sender, EventArgs e)
        {
            tbMensaje.Text = tbMensaje.Text + "0";
        }

        private void boton1_Click(object sender, EventArgs e)
        {
            tbMensaje.Text = tbMensaje.Text + "1";
        }

        private void boton2_Click(object sender, EventArgs e)
        {
            tbMensaje.Text = tbMensaje.Text + "2";
        }

        private void boton3_Click(object sender, EventArgs e)
        {
            tbMensaje.Text = tbMensaje.Text + "3";
        }

        private void boton4_Click(object sender, EventArgs e)
        {
            tbMensaje.Text = tbMensaje.Text + "4";
        }

        private void boton5_Click(object sender, EventArgs e)
        {
            tbMensaje.Text = tbMensaje.Text + "5";
        }

        private void boton6_Click(object sender, EventArgs e)
        {
            tbMensaje.Text = tbMensaje.Text + "6";
        }

        private void boton7_Click(object sender, EventArgs e)
        {
            tbMensaje.Text = tbMensaje.Text + "7";
        }

        private void boton8_Click(object sender, EventArgs e)
        {
            tbMensaje.Text = tbMensaje.Text + "8";
        }

        private void boton9_Click(object sender, EventArgs e)
        {
            tbMensaje.Text = tbMensaje.Text + "9";
        }

        private void botonSuma_Click(object sender, EventArgs e) 
        { 
            operador = Convert.ToChar("+");
            num1 = float.Parse(tbMensaje.Text);
            tbMensaje.Clear();
        }

        private void botonResta_Click(object sender, EventArgs e)
        {
            operador = Convert.ToChar("-");
            num1 = float.Parse(tbMensaje.Text);
            tbMensaje.Clear();
        }

        private void botonMultiplicacion_Click(object sender, EventArgs e)
        {
            operador = Convert.ToChar("*");
            num1 = float.Parse(tbMensaje.Text);
            tbMensaje.Clear();
        }

        private void botonDivision_Click(object sender, EventArgs e)
        {
            operador = Convert.ToChar("/");
            num1 = float.Parse(tbMensaje.Text);
            tbMensaje.Clear();
        }

        private void botonPunto_Click(object sender, EventArgs e)
        {
            if(tbMensaje.Text.EndsWith("."))
            {
                tbMensaje.Text = tbMensaje.Text;
            }
            else
            {
                tbMensaje.Text = tbMensaje.Text + ".";
            }
        }

        private void botonLimpiar_Click(object sender, EventArgs e)
        {
            tbMensaje.Clear();
        }

        private void botonIgual_Click(object sender, EventArgs e)
        {
            num2 = float.Parse(tbMensaje.Text);
            Operacion = new Operaciones();

            switch (operador)
            {
                case '+':
                    tbMensaje.Clear();
                    Operacion.Num1 = num1;
                    Operacion.Num2 = num2;
                    tbMensaje.Text = Convert.ToString(Operacion.Suma());
                    break;
                case '-':
                    tbMensaje.Clear();
                    Operacion.Num1 = num1;
                    Operacion.Num2 = num2;
                    tbMensaje.Text = Convert.ToString(Operacion.Resta());
                    break;
                case '*':
                    tbMensaje.Clear();
                    Operacion.Num1 = num1;
                    Operacion.Num2 = num2;
                    tbMensaje.Text = Convert.ToString(Operacion.Multiplicacion());
                    break;
                case '/':
                    if (num2 != 0)
                    {
                        tbMensaje.Clear();
                        Operacion.Num1 = num1;
                        Operacion.Num2 = num2;
                        tbMensaje.Text = Convert.ToString(Operacion.Division());
                    }
                    else
                    {
                        tbMensaje.Text = "No se puede dividir entre 0";
                    }
                    break;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
