using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Roy_U4_GradedTempature1
{
    public partial class TempConversion : Form
    {
        public TempConversion()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            int fahrenheit = Convert.ToInt32(Console.ReadLine());
        }

        private void convertButton_Click(object sender, EventArgs e)
        {
            double C;
            double F;

            F = double.Parse(txtFahrenheit.Text);
            C = 5.0 / 9.0 * (F - 32);
            lblCelsius.Text = C.ToString();

           
        }
    }
}
