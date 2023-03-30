using EJER18B.models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EJER18B
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Triangulo triangulo = new Triangulo(boxLado1.Text, boxLado2.Text, boxLado3.Text);
            buttonEquilatero.Enabled= true;
            buttonLadoMayor.Enabled = true;
            buttonArea.Enabled = true;
        }

        private void buttonEquilatero_Click(object sender, EventArgs e)
        {
            Triangulo triangulo = new Triangulo(boxLado1.Text, boxLado2.Text, boxLado3.Text);
            triangulo.EsEquilatero();
        }

        private void buttonLadoMayor_Click(object sender, EventArgs e)
        {
            Triangulo triangulo = new Triangulo(boxLado1.Text, boxLado2.Text, boxLado3.Text);
            triangulo.LadoMayor();
        }

        private void buttonArea_Click(object sender, EventArgs e)
        {
            Triangulo triangulo = new Triangulo(boxLado1.Text, boxLado2.Text, boxLado3.Text);
            triangulo.Area();   
        }
    }
}
