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
    public partial class FormClase7 : Form
    {
        public FormClase7()
        {
            InitializeComponent();
        }

        private void btnRevelar_Click(object sender, EventArgs e)
        {
            //Declaramos variables y recibimos valor de los numeros 
            int Numero1=Convert.ToInt32(txtNumero1.Text);
            int Numero2=Convert.ToInt32(txtNumero2.Text);
            int Numero3=Convert.ToInt32(txtNumero3.Text);

            //Realizamos un if en donde pondremos las diferentes posibilidades de mayor y menor 
            if (Numero1 > Numero2 && Numero1>Numero3)
            {
                if (Numero2 < Numero3)
                {
                    MessageBox.Show("El numero mayor es el numero 1 y el numero menor es el numero 2");
                }
                else if (Numero2 > Numero3)
                {
                    MessageBox.Show("El numero mayor es el numero 1 y el numero menor es el numero 3");
                }
            }

            else if (Numero2 > Numero1 && Numero2 > Numero3)
            {
                if (Numero1 < Numero3)
                {
                    MessageBox.Show("El numero mayor es el numero 2 y el numero menor es el numero 1");
                }
                else if (Numero1 > Numero3)
                {
                    MessageBox.Show("El numero mayor es el numero 2 y el numero menor es el numero 3");
                }
            }

            else if (Numero3 > Numero2 && Numero3 > Numero1)
            {
                if (Numero2 < Numero1)
                {
                    MessageBox.Show("El numero mayor es el numero 3 y el numero menor es el numero 2");
                }
                else if (Numero2 > Numero1)
                {
                    MessageBox.Show("El numero mayor es el numero 3 y el numero menor es el numero 1");
                }
            }
        }
    }
}
