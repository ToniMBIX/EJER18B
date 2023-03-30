using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.MonthCalendar;

namespace EJER18B.models
{
    public class Triangulo
    {
        public string Lado1 { get; set; }
        public string Lado2 { get; set; }
        public string Lado3 { get; set; }
        public void Area()
        {
            double a = Convert.ToDouble(Lado1);
            double b = Convert.ToDouble(Lado2);
            double c = Convert.ToDouble(Lado3);

            double s = (a + b + c) / 2;
            double area = Math.Sqrt(s * (s - a) * (s - b) * (s - c));

            string mensaje = "El área de este triángulo es "+(area.ToString())+".";
            string titulo = "Área";
            MessageBox.Show(mensaje, titulo);
        }
        public void EsEquilatero()
        {
            double a = Convert.ToDouble(Lado1);
            double b = Convert.ToDouble(Lado2);
            double c = Convert.ToDouble(Lado3);
            if (a == b && a == c)
            {
                string mensaje = "El triángulo es equilátero.";
                MessageBox.Show(mensaje);
            }
            else
            {
                string mensaje = "El triángulo NO es equilátero.";
                MessageBox.Show(mensaje);
            }
        }
        public void LadoMayor()
        {
            double a = Convert.ToDouble(Lado1);
            double b = Convert.ToDouble(Lado2);
            double c = Convert.ToDouble(Lado3);
            if (a > b && a > c)
            {
                string mensaje = "El lado mayor del triángulo es: "+a;
                string titulo = "Lado Mayor";
                MessageBox.Show(mensaje, titulo);

            }
            if (b > a && b > c)
            {
                string mensaje = "El lado mayor del triángulo es: " + b;
                string titulo = "Lado Mayor";
                MessageBox.Show(mensaje, titulo);

            }
            else
            {
                string mensaje = "El lado mayor del triángulo es: " + c;
                string titulo = "Lado Mayor";
                MessageBox.Show(mensaje, titulo);

            }

        }
        public Triangulo(string lado1, string lado2, string lado3)
        {
            this.Lado1 = lado1;
            this.Lado2 = lado2;
            this.Lado3 = lado3;
        }
    }
}
