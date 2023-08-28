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
    public partial class FormClase5 : Form
    {
        public FormClase5()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {   //Recibimos el nombre y el sueldo, los declaramos 
            String Nombre=txtNombre.Text;
            Double Sueldo=Convert.ToDouble(txtSueldo.Text);
            //con este primer boton revelamos la información del empleado 
            MessageBox.Show("El nombre del empleado es: "+Nombre+" y su sueldo es de: "+Sueldo+"$");

        }

        private void button2_Click(object sender, EventArgs e)
        {
            String Nombre = txtNombre.Text;
            double Sueldo = Convert.ToDouble(txtSueldo.Text);

            //Realizamos el metdo if en este boton, para determinar si el sueldo cumple con el requisito de pagar impuestos
            if (Sueldo > 3000) 
            {
                MessageBox.Show("segun el sueldo ingresado usted debe de pagar impuestos");
            }

            else
            {
                MessageBox.Show("Segun el sueldo ingresado usted no debe de pagar impuestos");
            }
        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
