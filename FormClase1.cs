using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Configuration;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TallerPractico
{
    public partial class FormClase1 : Form
    {
        public FormClase1()
        {
            InitializeComponent();
        }

        private void FormClase1_Load(object sender, EventArgs e)
        {
            
        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtEdad_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {   //En esta parte declaramos las variables que vamos a utilizar, estas ya anteriormente ingresadas por un textbox
            string Nombre = txtNombre.Text;
            int edad = Convert.ToInt32(txtEdad.Text);

            //Realizamos el if con la variable edad para saber si es mayor o menor de edad
            if (edad < 18)
            {
                MessageBox.Show("El usuario: "+Nombre+" Con "+edad+" años, es menor de edad ");
            }
            else
            {
                MessageBox.Show("El usuario: " + Nombre + " Con " + edad + " años, es mayor de edad ");
            }

        }
    }
}
