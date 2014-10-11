using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppCalculadora1
{
    public partial class Form1 : Form
    {
        bool sigue = true, punto = true;
        string operacion, point;
        double num1, solucion, num2;


        public Form1()
        {
            InitializeComponent();
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            if (sigue)
            {
                txtResultado.Text = "";
                txtResultado.Text = "1";
                sigue = false;
                punto = true;
            }
            else
            {
                txtResultado.Text = txtResultado.Text + "1";

            }
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            if (sigue)
            {
                txtResultado.Text = "";
                txtResultado.Text = "2";
                sigue = false;
                punto = true;
            }
            else
            {
                txtResultado.Text = txtResultado.Text + "2";
            }
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            if (sigue)
            {
                txtResultado.Text = "";
                txtResultado.Text = "3";
                sigue = false;
                punto = true;
            }
            else
            {
                txtResultado.Text = txtResultado.Text + "3";
            }
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            if (sigue)
            {
                txtResultado.Text = "";
                txtResultado.Text = "4";
                sigue = false;
                punto = true;
            }
            else
            {
                txtResultado.Text = txtResultado.Text + "4";
            }
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            if (sigue)
            {
                txtResultado.Text = "";
                txtResultado.Text = "5";
                sigue = false;
                punto = true;
            }
            else
            {
                txtResultado.Text = txtResultado.Text + "5";
            }
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            if (sigue)
            {
                txtResultado.Text = "";
                txtResultado.Text = "6";
                sigue = false;
                punto = true;
            }
            else
            {
                txtResultado.Text = txtResultado.Text + "6";
            }
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            if (sigue)
            {
                txtResultado.Text = "";
                txtResultado.Text = "7";
                sigue = false;
                punto = true;
            }
            else
            {
                txtResultado.Text = txtResultado.Text + "7";
            }
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            if (sigue)
            {
                txtResultado.Text = "";
                txtResultado.Text = "8";
                sigue = false;
                punto = true;
            }
            else
            {
                txtResultado.Text = txtResultado.Text + "8";
            }
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            if (sigue)
            {
                txtResultado.Text = "";
                txtResultado.Text = "9";
                sigue = false;
                punto = true;
            }
            else
            {
                txtResultado.Text = txtResultado.Text + "9";
            }
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            if (sigue)
            {
                txtResultado.Text = "";
                txtResultado.Text = "0";
                sigue = false;
                punto = true;
            }
            else
            {
                txtResultado.Text = txtResultado.Text + "0";
            }
        }

        private void btnSuma_Click(object sender, EventArgs e)
        {
            operacion = "+";
            sigue = true;
            num1 = double.Parse(txtResultado.Text);
        }

        private void btnResta_Click(object sender, EventArgs e)
        {
            operacion = "-";
            sigue = true;
            num1 = double.Parse(txtResultado.Text);
        }

        private void btnMultiplicacion_Click(object sender, EventArgs e)
        {
            operacion = "*";
            sigue = true;
            num1 = double.Parse(txtResultado.Text);
        }

        private void btnDivision_Click(object sender, EventArgs e)
        {
            operacion = "/";
            sigue = true;
            num1 = double.Parse(txtResultado.Text);
        }

        private void btnIgual_Click(object sender, EventArgs e)
        {
            num2 = double.Parse(txtResultado.Text);
            sigue = true;
            switch (operacion)
            {
                case "+":
                    solucion = num1 + num2;
                    txtResultado.Text = solucion.ToString();
                    break;

                case "-":
                    solucion = num1 - num2;
                    txtResultado.Text = solucion.ToString();
                    break;

                case "*":
                    solucion = num1 * num2;
                    txtResultado.Text = solucion.ToString();
                    break;

                case "/":
                    solucion = num1 / num2;
                    txtResultado.Text = solucion.ToString();
                    break;
            }
        }

        private void btnBorrado_Click(object sender, EventArgs e)
        {
            txtResultado.Text = "";
        }

        private void btnPunto_Click(object sender, EventArgs e)
        {
            sigue = false;
            if (punto == true)
            {
                txtResultado.Text = txtResultado.Text + ",";
                punto = false;
            }
            else
            {
                return;
            }
        }

        private void txtResultado_TextChanged(object sender, EventArgs e)
        {
           
        }
    }
}