using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TallerPractico
{
    public partial class FormClase2 : Form
    {
        public FormClase2()
        {
            InitializeComponent();
        }

        private void btnLadoM_Click(object sender, EventArgs e)
        {   //Luego de ingresar los lados, declaramos las variables
            double lado1=Convert.ToDouble(txtLado1.Text);
            double lado2=Convert.ToDouble(txtLado2.Text);
            double lado3 = Convert.ToDouble(txtLado3.Text);

            //Realizamos el metodo If para comprar la longitud de los lados y determinar el mayor 
            if (lado1 > lado2 && lado1>lado3)
            {
                MessageBox.Show("El lado 1 con el valor de: "+lado1+" es mayor a los demas lados");
            }

            else if (lado2 > lado1 && lado2 > lado3)
            {
                MessageBox.Show("El lado 2 con el valor de: " + lado2 + " es mayor a los demas lados");
            }

            else if (lado3 > lado1 && lado3 > lado2) 
            {
                MessageBox.Show("El lado 3 con el valor de: " + lado3 + " es mayor a los demas lados");
            }

            else
            {
                MessageBox.Show("Hay dos o mas lados mayores iguales");
            }
        }

        private void btnEquilatero_Click(object sender, EventArgs e)
        {   //Luego de ingresar los lados, declaramos las variables
            double lado1 = Convert.ToDouble(txtLado1.Text);
            double lado2 = Convert.ToDouble(txtLado2.Text);
            double lado3 = Convert.ToDouble(txtLado3.Text);

            //Hacemos el metodo if, en donde si todos los lados son iguales, se mostrará un mensaje de que el triangulo es equilatero 
            if (lado1==lado2 && lado1==lado3)
            {
                MessageBox.Show("Su triangulo es equilatero");
            }
            else
            {
                MessageBox.Show("Su triangulo no es equilatero");
            }
        }
    }
}
