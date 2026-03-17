using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_de_Bim
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                 MessageBox.Show("ERROR, ingrese un numero en el primer campo.");
            }

            if (textBox1.Text == "")
            {
                MessageBox.Show("ERROR, ingrese un numero en el primer campo.");
            }

            //checar si lo ingresado es un numero

            double num1, num2;

            if (!double.TryParse(textBox1.Text, out num1))
            {
                MessageBox.Show("ERROR, ingrese un numero valido en el primer campo.");
                return;
            }

            if (!double.TryParse(textBox2.Text, out num2))
            {
                MessageBox.Show("ERROR, ingrese un numero valido en el segundo campo.");
                return;
            }

            double resultado = num1 + num2;

            label3.Text = resultado.ToString();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
