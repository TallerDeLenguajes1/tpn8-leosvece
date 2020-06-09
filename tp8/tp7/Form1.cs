using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tp7
{
    public partial class Form1 : Form
    {
        Calculadora calcular;
        bool bandera = true;
        DateTime fecha;
        string operacion;

        public Form1()
        {
            InitializeComponent();
            calcular = new Calculadora();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            pantalla.Text += cinco.Text;

        }

        private void button8_Click(object sender, EventArgs e)
        {
            pantalla.Text += cuatro.Text;

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
           /* calcular.Resultado = pantalla.Text;
            if (calcular.Resultado.Contains("+"))
            {
                string[] operadores = pantalla.Text.Split(Convert.ToChar("+"));
                pantalla.Clear();
                pantalla.Text = calcular.calculo(operadores[0], "+", operadores[1]);
            }
           */
        }

        private void button3_Click(object sender, EventArgs e)
        {
            pantalla.Text += siete.Text;

        }

        private void button13_Click(object sender, EventArgs e)
        {

            if (calcular.Resultado == null)
            {
                calcular.Resultado = pantalla.Text;
                calcular.Operador = "/";
                pantalla.Clear();
            }
            else
            {
                calcular.Dato1 = pantalla.Text;
                pantalla.Clear();
                calcular.Operador = "/";
                if (bandera == true)
                //if (calcular.Dato1 != null)
                {
                    calcular.Resultado = calcular.calculo(calcular.Resultado, calcular.Operador, calcular.Dato1);

                }
                calcular.Dato1 = null;
            }
        }

        private void button14_Click(object sender, EventArgs e)
        {
 
            if(calcular.Resultado == null)
            {
                fecha = DateTime.Now;
                operacion = pantalla.Text; 
                calcularPorTeclado(pantalla.Text);
                historial.Items.Add(fecha + "---->" + operacion + " = " +pantalla.Text); 
                
            }
            else
            {
                fecha = DateTime.Now;
                verificarYcalcular(pantalla.Text);
                operacion = calcular.Resultado + " " + calcular.Operador + " " + calcular.Dato1;
                calcular = new Calculadora();
                historial.Items.Add(fecha + "  ---->   " + operacion + " = " + pantalla.Text);
            }


            bandera = false;
 

            
        }

        private void button15_Click(object sender, EventArgs e)
        {
            pantalla.Text += cero.Text;

        }

        private void button16_Click(object sender, EventArgs e)
        {
            pantalla.Text += coma.Text;

        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (calcular.Resultado == null)
            {
                calcular.Resultado = pantalla.Text;
                calcular.Operador = "*";
                pantalla.Clear();
            }
            else
            {
                calcular.Dato1 = pantalla.Text;
                pantalla.Clear();
                calcular.Operador = "*";
                if (calcular.Dato1 != null)
                {
                    calcular.Resultado = calcular.calculo(calcular.Resultado, calcular.Operador, calcular.Dato1);

                }
                calcular.Dato1 = null;
            }

        }

        private void button10_Click(object sender, EventArgs e)
        {
            pantalla.Text += tres.Text;

        }

        private void button11_Click(object sender, EventArgs e)
        {
            pantalla.Text += dos.Text;

        }

        private void button12_Click(object sender, EventArgs e)
        {
            pantalla.Text += uno.Text;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (calcular.Resultado == null)
            {
                calcular.Resultado = pantalla.Text;
                calcular.Operador = "-";
                pantalla.Clear();
            }
            else
            {
                calcular.Dato1 = pantalla.Text;
                pantalla.Clear();
                calcular.Operador = "-";
                if (bandera == true)
                //if (calcular.Dato1 != null)
                {
                    calcular.Resultado = calcular.calculo(calcular.Resultado, calcular.Operador, calcular.Dato1);

                }
                calcular.Dato1 = null;
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            pantalla.Text += seis.Text;

        }

        private void button4_Click(object sender, EventArgs e)
        {
            
            if (calcular.Resultado == null)
            {
                calcular.Resultado = pantalla.Text;
                calcular.Operador = "+";
                pantalla.Clear();
            }
            else
            { 
              
                calcular.Dato1 = pantalla.Text;
                pantalla.Clear();
                calcular.Operador = "+";
                if(bandera == true)
                //if (calcular.Dato1 != null)
                {
                     calcular.Resultado = calcular.calculo(calcular.Resultado, calcular.Operador, calcular.Dato1);

                }
                bandera = true;
                //calcular.Dato1 = null;
            }



        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            pantalla.Clear();
            calcular.Resultado = null;
            calcular.Dato1 = null;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            pantalla.Text += ocho.Text;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            pantalla.Text += nueve.Text;

        }

        private void calcularPorTeclado(string pant)
        {
            if (pant.Contains('+'))
            {

                string[] arreglo = pant.Split('+');
                pantalla.Text = calcular.calculo(arreglo[0], "+", arreglo[1]);
            }
            if (pant.Contains('-'))
            {

                string[] arreglo = pant.Split('-');
                pantalla.Text = calcular.calculo(arreglo[0], "-", arreglo[1]);
            }
            if (pant.Contains('/'))
            {

                string[] arreglo = pant.Split('/');
                if (arreglo[1] == "0")
                {
                    pantalla.Text = "ERROR";
                }
                else
                {
                    pantalla.Text = calcular.calculo(arreglo[0], "/", arreglo[1]);
                }

            }
            if (pant.Contains('*'))
            {

                string[] arreglo = pant.Split('*');
                pantalla.Text = calcular.calculo(arreglo[0], "*", arreglo[1]);
            }





        }
        private void verificarYcalcular( string c)
        {
            calcular.Dato1 = c;
            if (calcular.Dato1 != null)
            {
                if (c == "0" && c == "/")
                {
                    pantalla.Text = "ERROR";
                }
                else
                {
                    pantalla.Text = calcular.calculo(calcular.Resultado, calcular.Operador, calcular.Dato1);
                }
            }
            calcular.Dato1 = null;
        }

        private void historial_SelectedIndexChanged(object sender, EventArgs e)
        {
            historial.Items.Remove(historial.SelectedItem);
        }
    }
}
