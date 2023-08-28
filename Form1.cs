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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnClase1_Click(object sender, EventArgs e)
        {
            ///REALIZADO POR:
            ///MATEO BOTERO ECHEVERRI
            ///TALLER 1
            ///LENGUAJE DE PROGRAMACIÓN ORIENTADO A OBJETOS 
            //Realizamos la acción de boton para llamar el formulario requerido
            //Boton 1 para clase 1, boton 2 para clase 2...
            FormClase1 clase1 = new FormClase1();
            clase1.Show();

        }

        private void btnClase2_Click(object sender, EventArgs e)
        {
            FormClase2 clase2 = new FormClase2();
            clase2.Show();
        }

        private void btnClase3_Click(object sender, EventArgs e)
        {
            FormClase3 clase3 = new FormClase3();
            clase3.Show();
        }

        private void btnClase4_Click(object sender, EventArgs e)
        {
            FormClase4 clase4 = new FormClase4();
            clase4.Show();
        }

        private void btnClase5_Click(object sender, EventArgs e)
        {
            FormClase5 clase5 = new FormClase5();
            clase5.Show();
        }

        private void btnClase6_Click(object sender, EventArgs e)
        {
            FormClase6 clase6 = new FormClase6();
            clase6.Show();
        }

        private void btnClase7_Click(object sender, EventArgs e)
        {
            FormClase7 clase7 = new FormClase7();
            clase7.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
