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
    public partial class FormClase3 : Form
    {
        public FormClase3()
        {
            InitializeComponent();
        }

        private void btnCuadrante_Click(object sender, EventArgs e)
        {   //Recibimos el valor de X y Y en el plano simulado 
            double EjeX = Convert.ToDouble(txtEjeX.Text);
            double EjeY = Convert.ToDouble(txtEjeY.Text);

            //Aplicamos el metodo if, que segun el metodo matematico, nos ubicará en el cuadrante 
            if (EjeX >0 && EjeY > 0)
            {
                MessageBox.Show("El punto se encuentra en el primer cuadrante");
            }

            else if (EjeX < 0 && EjeY > 0)
            {
                MessageBox.Show("El punto se encuentra en el segundo cuadrante");
            }

            else if (EjeX < 0 && EjeY < 0)
            {
                MessageBox.Show("El punto se encuentra en el tercer cuadrante");
            }

            else
            {
                MessageBox.Show("El punto se encuentra en el cuarto cuadrante");
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
