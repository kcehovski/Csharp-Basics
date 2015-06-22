using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IfElse
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text != "Kaja")
            {
                if (comboBox1.Text == "Kata")
                {
                    MessageBox.Show("You picked Kata");
                }
                else
                {
                    MessageBox.Show("I'm not sure who you picked.");
                }
            }
            else
            {
                MessageBox.Show("You picked Kaja");
            }
        }
    }
}
