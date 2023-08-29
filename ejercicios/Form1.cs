using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ejercicios
{
    public partial class Form1 : Form
    {
        String[][] tiposConversores = new string [][] {
        new String[]{"Pie cuadrado " , "Vara Caudrada ", "Yarda Cuadrada ", "Metro Cuadrado", "Tareas", "Manzana", "Hectárea" }, //Pie Cuadrado
        
        }; 
        public Form1()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnconvertirconversores_Click(object sender, EventArgs e)
        {
            int de = 0, a = 0 ;
            double cantidad , respuesta ;

            de = cbodeconversores.SelectedIndex;
            a = cboaconversores.SelectedIndex;

            cantidad = double.Parse(txtcantidadconversores.Text);

            double[] area = { 1, 1.431, 0.111111, 0.092903, 0.0015903307888, 7000, 0.92903000000 }; //Area
          
        

            respuesta = area[a] / area [de] * cantidad;

            lblrespuestasconversores.Text = "Respuesta: " + Math.Round(  respuesta, 3 );


        }

        private void cbotipoconversores_TextChanged(object sender, EventArgs e)
        {
            cbodeconversores.Items.Clear();
            cbodeconversores.Items.AddRange(tiposConversores[cbotipoconversores.SelectedIndex]);

            cboaconversores.Items.Clear();
            cboaconversores.Items.AddRange(tiposConversores[cbotipoconversores.SelectedIndex]);
        }

        private void lblcantidadconverores_Click(object sender, EventArgs e)
        {

        }

        private void lblrespuestasconversores_Click(object sender, EventArgs e)
        {

        }

        private void txtcantidadconversores_TextChanged(object sender, EventArgs e)
        {

        }

        private void cbotipoconversores_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lbltipoconversores_Click(object sender, EventArgs e)
        {

        }
    }
}
