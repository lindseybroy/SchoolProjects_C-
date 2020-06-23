using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Roy_FinalExam_1
{
    public partial class Form1 : Form
    {
        Color color;
        public Form1()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            



        }

        private void button1_Click(object sender, EventArgs e)
        {
            string SelectedColor = comboBox1.Text;

            if (SelectedColor == "Red")
                color = Color.Red;
            else if (SelectedColor == "Green")
                color = Color.Green;
            else if (SelectedColor == "Blue")
                color = Color.Blue;


            if (radioButton1.Checked == true)
                this.BackColor = color;
            else
                this.BackColor = DefaultBackColor;

            if (radioButton2.Checked == true)
                comboBox1.ForeColor = color;
            else
                comboBox1.ForeColor = Color.White;
        }
    }


}


