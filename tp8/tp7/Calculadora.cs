using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tp7
{
    class Calculadora
    {
        private string dato1, resultado =null;
        private string operador;

        public string Dato1 { get => dato1; set => dato1 = value; }
        public string Resultado { get => resultado; set => resultado = value; }
        public string Operador { get => operador; set => operador = value; }

        public string calculo(string Resultado, string Operador, string Dato1)
        {
            double a, b;
            b = Convert.ToDouble(Dato1);
            a = Convert.ToDouble(Resultado);

            switch (Operador)
            {
                case "+":
                    a += b;
                    break;
                case "-":
                    a -= b;
                    break;
                case "*":
                    a *= b;
                    break;
                case "/":
                    a /= b;
                    break;
            }

            return Convert.ToString(a);
        }


    }
}
