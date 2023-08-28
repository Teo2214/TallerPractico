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
    public partial class FormClase4 : Form
    {
        public FormClase4()
        {
            InitializeComponent();
        }

        private void btnPerimetro_Click(object sender, EventArgs e)
        {   //Recibimos el lado y declaramos la variable perimetro para realizar el metodo 
            double lado = Convert.ToDouble(txtLado.Text);
            double Perimetro;
            //Realizamos el metodo del perimetro 
            Perimetro = lado + lado + lado + lado;
            //Se muestra un mensaje del valor del perimetro 
            MessageBox.Show("El perimetro de su cuadrado es de: "+Perimetro);
        }

        private void btnSuperficie_Click(object sender, EventArgs e)
        {   //Recibimos el lado y declaramos la variable superficie para realizar el metodo
            double lado= Convert.ToDouble(txtLado.Text);
            double Superficie;
            //se realiza el metodo superficie 
            Superficie = lado * lado;
            //Se muestra un mensaje del valor de la superficie 
            MessageBox.Show("La superficie del cuadrado es de: "+Superficie+" unidades cuadradas");
        }
    }
}
