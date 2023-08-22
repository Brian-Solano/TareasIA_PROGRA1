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
        new String[]{"Dolar","Euro", "Quetzal", "Lempira", "Cordoba", "Colon SV", "Colon CR", "Yenes", "Rupias India", "Libras Esterlinas" }, //Monedas
        new String[]{"Libra","Miligramo", "Gramo", "Onzas", "Tonelada Corta", "Tonelada", "Kilogramo", "Microgramo", "Tonelada Larga","Stone"},//Masa  
        new String[]{"Litro","Mililitro", "Galón", "Cuarto", "Onza Liquida", "Cucharada", "Cucharadita", "Metro Cúbico", "Pie Cúbico","Pulgada Cúbica"},//Volumen  
        new String[]{"Metro","Milimetro", "Centimetro", "Pulgada", "Pies", "Varas", "Yardas", "Kilometro", "Millas","Milla náutica"},//Longitud 
        new string[]{"Terabyte","Gigabyte", "Megabyte", "Kilobyte", "Byte", "Petabyte", "Megabit", "Bit", "Kilobit","Gigabit"},//Almanacenamiento
        new string[]{"Segundo","Minuto", "Hora", "Día", "Semana", "Mes", "Año", "Década", "Siglo","Milisegundo"},//Tiempo
        }; //Matriz Dentada.
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
            int de , a ;
            double cantidad , respuesta ;

            de = cbodeconversores.SelectedIndex;
            a = cboaconversores.SelectedIndex;

            cantidad = double.Parse(txtcantidadconversores.Text);

            double[][] monedas = {
             new double[]{1, 0.92,7.86, 24.66, 36.58, 8.75, 535.14, 145.47, 0.79, 83.29},//Monedas
             new double[]{1, 453592, 453.592, 16, 0.0005, 0.000453592, 0.453592, 4.536e+8, 0.000446429, 0.0714286 },//Masa
             new double[]{1, 1000, 0.264172, 1.05669, 33.814, 67.628, 202.884, 0.001, 0.0353147, 61.0237},//Volumen
             new double[]{1,1000, 100, 39.3701, 3.28084, 1.1963081929167, 1.09361, 0.001, 0.000621371,0.000539957 },//Longitud
             new double[]{1, 1000, 1000000, 1000000000, 1000000000000, 0.001, 8000000, 8000000000000, 8000000000, 8000 },//Almacenamiento
             new double[]{1, 60, 3600, 86400, 604800, 2.628000000, 3.1540000000, 3.15400000000, 3.154000000000, 0.001 }//Tiempo
        };

            respuesta = monedas[cbotipoconversores.SelectedIndex][a] / monedas[cbotipoconversores.SelectedIndex][de] * cantidad;

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
    }
}
