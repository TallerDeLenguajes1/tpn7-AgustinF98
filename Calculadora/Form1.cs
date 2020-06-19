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
        float num1, num2, resultado;
        char operador;
        Operaciones Operacion;

        public Calculadora()
        {
            InitializeComponent();
        }

        private void boton0_Click(object sender, EventArgs e)
        {
            if (tbMensaje.Text == Convert.ToString(resultado))
            {
                tbMensaje.Clear();
                tbMensaje.Text = tbMensaje.Text + "0";
            }
            else
            {
                tbMensaje.Text = tbMensaje.Text + "0";
            }
        }

        private void boton1_Click(object sender, EventArgs e)
        {
            if (tbMensaje.Text == Convert.ToString(resultado))
            {
                tbMensaje.Clear();
                tbMensaje.Text = tbMensaje.Text + "1";
            }
            else
            {
                tbMensaje.Text = tbMensaje.Text + "1";
            }
        }

        private void boton2_Click(object sender, EventArgs e)
        {
            if (tbMensaje.Text == Convert.ToString(resultado))
            {
                tbMensaje.Clear();
                tbMensaje.Text = tbMensaje.Text + "2";
            }
            else
            {
                tbMensaje.Text = tbMensaje.Text + "2";
            }
        }

        private void boton3_Click(object sender, EventArgs e)
        {
            if (tbMensaje.Text == Convert.ToString(resultado))
            {
                tbMensaje.Clear();
                tbMensaje.Text = tbMensaje.Text + "3";
            }
            else
            {
                tbMensaje.Text = tbMensaje.Text + "3";
            }
        }

        private void boton4_Click(object sender, EventArgs e)
        {
            if (tbMensaje.Text == Convert.ToString(resultado))
            {
                tbMensaje.Clear();
                tbMensaje.Text = tbMensaje.Text + "4";
            }
            else
            {
                tbMensaje.Text = tbMensaje.Text + "4";
            }
        }

        private void boton5_Click(object sender, EventArgs e)
        {
            if (tbMensaje.Text == Convert.ToString(resultado))
            {
                tbMensaje.Clear();
                tbMensaje.Text = tbMensaje.Text + "5";
            }
            else
            {
                tbMensaje.Text = tbMensaje.Text + "5";
            }
        }

        private void boton6_Click(object sender, EventArgs e)
        {
            if (tbMensaje.Text == Convert.ToString(resultado))
            {
                tbMensaje.Clear();
                tbMensaje.Text = tbMensaje.Text + "6";
            }
            else
            {
                tbMensaje.Text = tbMensaje.Text + "6";
            }
        }

        private void boton7_Click(object sender, EventArgs e)
        {
            if (tbMensaje.Text == Convert.ToString(resultado))
            {
                tbMensaje.Clear();
                tbMensaje.Text = tbMensaje.Text + "7";
            }
            else
            {
                tbMensaje.Text = tbMensaje.Text + "7";
            }
        }

        private void boton8_Click(object sender, EventArgs e)
        {
            if (tbMensaje.Text == Convert.ToString(resultado))
            {
                tbMensaje.Clear();
                tbMensaje.Text = tbMensaje.Text + "8";
            }
            else
            {
                tbMensaje.Text = tbMensaje.Text + "8";
            }
        }

        private void boton9_Click(object sender, EventArgs e)
        {
            if (tbMensaje.Text == Convert.ToString(resultado))
            {
                tbMensaje.Clear();
                tbMensaje.Text = tbMensaje.Text + "9";
            }
            else
            {
                tbMensaje.Text = tbMensaje.Text + "9";
            }
        }

        private void botonSuma_Click(object sender, EventArgs e) 
        { 
            operador = Convert.ToChar("+");
            num1 = float.Parse(tbMensaje.Text);
            tbMensaje.Text = tbMensaje.Text + " + ";
        }

        private void botonResta_Click(object sender, EventArgs e)
        {
            operador = Convert.ToChar("-");
            num1 = float.Parse(tbMensaje.Text);
            tbMensaje.Text = tbMensaje.Text + " - ";
        }

        private void botonMultiplicacion_Click(object sender, EventArgs e)
        {
            operador = Convert.ToChar("*");
            num1 = float.Parse(tbMensaje.Text);
            tbMensaje.Text = tbMensaje.Text + " * ";
        }

        private void botonDivision_Click(object sender, EventArgs e)
        {
            operador = Convert.ToChar("/");
            num1 = float.Parse(tbMensaje.Text);
            tbMensaje.Text = tbMensaje.Text + " / ";
        }

        private void botonPunto_Click(object sender, EventArgs e)
        {
            if(tbMensaje.Text.EndsWith(","))
            {
                tbMensaje.Text = tbMensaje.Text;
            }
            else
            {
                tbMensaje.Text = tbMensaje.Text + ",";
            }
        }

        private void botonLimpiar_Click(object sender, EventArgs e)
        {
            tbMensaje.Clear();
        }

        private void botonIgual_Click(object sender, EventArgs e)
        {
            string[] separadorNum;
            Operacion = new Operaciones();

            switch (operador)
            {
                case '+':
                    separadorNum = tbMensaje.Text.Split('+');
                    num2 = float.Parse(separadorNum[1]);
                    Operacion.Num1 = num1;
                    Operacion.Num2 = num2;
                    tbMensaje.Clear();
                    resultado = Operacion.Suma();
                    tbMensaje.Text = Convert.ToString(resultado);
                    break;
                case '-':
                    separadorNum = tbMensaje.Text.Split('-');
                    num2 = float.Parse(separadorNum[1]);
                    Operacion.Num1 = num1;
                    Operacion.Num2 = num2;
                    tbMensaje.Clear();
                    resultado = Operacion.Resta();
                    tbMensaje.Text = Convert.ToString(resultado);
                    break;
                case '*':
                    separadorNum = tbMensaje.Text.Split('*');
                    num2 = float.Parse(separadorNum[1]);
                    Operacion.Num1 = num1;
                    Operacion.Num2 = num2;
                    tbMensaje.Clear();
                    resultado = Operacion.Multiplicacion();
                    tbMensaje.Text = Convert.ToString(resultado);
                    break;
                case '/':
                    separadorNum = tbMensaje.Text.Split('/');
                    num2 = float.Parse(separadorNum[1]);
                    Operacion.Num1 = num1;
                    Operacion.Num2 = num2;
                    tbMensaje.Clear();
                    resultado = Operacion.Division();
                    tbMensaje.Text = Convert.ToString(resultado);
                    break;
            }
        }
    }
}
