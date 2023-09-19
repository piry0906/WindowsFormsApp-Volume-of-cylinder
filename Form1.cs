using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp_Volume_of_cylinder {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e) {
            if (double.TryParse(textBox1.Text, out double Radius) && double.TryParse(textBox2.Text, out double Height)) {
                const double pi = Math.PI;
                double Volume = pi * Math.Pow(Radius, 2) * Height;
                labelAnswer.Text = $"Volume of Cylinder is {Volume:N2}";
            }
            else {
                MessageBox.Show("Invalid data. Please enter valid numbers in the TextBoxes.");
            }
    
        }
    }
}
