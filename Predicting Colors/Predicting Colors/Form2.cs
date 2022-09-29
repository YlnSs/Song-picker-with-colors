using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Predicting_Colors
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text == "Blue")
            {
                label1.Text = ("The Weeknd In your eyes");
                label1.ForeColor = Color.Blue;

            }
            if(comboBox1.Text=="Green")
            {
                label1.Text = ("Drake Stayin Alive");
                label1.ForeColor = Color.Green;

            }
            if(comboBox1.Text=="Yellow")
            {
                label1.Text = ("The weeknd Pray For Me");
                label1.ForeColor = Color.Yellow;
            }
            if (comboBox1.Text =="Red")
            {
                label1.Text = ("J Cole No Role Modelz");
                label1.ForeColor = Color.Red;
            }
            if(comboBox1.Text=="Pink")
            {
                label1.Text = ("Maroon 5 Payphone");
                label1.ForeColor = Color.Pink;
            }
        }
    }
}
