using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Globalization;

namespace courseBooking
{
    public partial class Form4 : Form
    {
        string filename;
        public static string[] fileLines;
        public static List<string> fileNewLines = new List<string>();
        List<string> courseNames = new List<string>();


        public Form4()
        {
            InitializeComponent();
            this.Text = "New course";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DateTime result;
            CultureInfo provider = CultureInfo.InvariantCulture;
            
            try
            {
                //checking that date is in format "dd/MM/yyyy"
                result = DateTime.ParseExact(textBox2.Text, "dd/MM/yyyy", provider);

                foreach (string item in Form1.fileLines)
                {
                    Form1.fileNewLines.Add(item);
                }

                string[] info = new string[4];
                info[0] = textBox1.Text;
                info[1] = result.ToShortDateString();
                info[2] = "€" + textBox3.Text.ToString();
                info[3] = "FFFFFFFFFFFF";

                foreach (string inf in info)
                {
                    Form1.fileNewLines.Add(inf);
                }

                textBox1.Clear();
                textBox2.Clear();
                textBox3.Clear();

            }

            catch (FormatException) //if date is not in format that we gave it then it shows the message box
            {
                MessageBox.Show("Invalid Date", "Error 004", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Form4_FormClosed(object sender, FormClosedEventArgs e)
        {
            Form1.fileLines = Form1.fileNewLines.ToArray();
            Form1.fileNewLines.Clear();
            
        }
    }
}
