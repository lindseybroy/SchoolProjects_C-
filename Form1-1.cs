using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Roy_U4_Guided2
{
    public partial class LabelTest : Form
    {
        public LabelTest()
        {
            InitializeComponent();
        }

        private void displayPasswordButton_Click(object sender, EventArgs e)
        {
            displayPasswordLabel.Text = inputPasswordTextBox.Text;
        }
    }
}
