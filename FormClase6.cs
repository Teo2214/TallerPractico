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
    public partial class FormClase6 : Form
    {
        public FormClase6()
        {
            InitializeComponent();
        }

        private void btnTablas_Click(object sender, EventArgs e)
        {   //Recibimos la variable Numero, y creamos la variable i, Resultado
            int Numero=Convert.ToInt32(txtNumero.Text);
            int i=1, Resultado=0;

            //realizamos un metodo if por si el usuario ingresa -1 muestre un mensaje de error 
            if (Numero == -1)
            {
                MessageBox.Show("Ingrese un valor valido");
            }

            //realizamos un metodo while para crear el ciclo de las tablas de multiplicar
            else
            {
                while (i <= 10)
                {
                    Resultado = Numero * i;
                    Convert.ToString(Resultado);
                    MessageBox.Show(Resultado.ToString()); 
                    i++;
                }
            }
            
        }
    }
}
