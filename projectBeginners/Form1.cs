using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projectBeginners
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //1. Hello Katarina
            MessageBox.Show("Hello Katarina. You're awesome!");

            //2. string variable
            string letters = "ABCDEF";
        }

        private void button2_Click(object sender, EventArgs e)
        {

            //3. integer
            int number = int.Parse(textBox1.Text);

            if (number < 10)
            {
                MessageBox.Show("This number is too small");
            }
            else
            {
                MessageBox.Show("Number is not big enough");
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            //4. concatenated sentence
            MessageBox.Show(textBox2.Text + " " + textBox3.Text);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //5. combobox
            if (comboBox1.Text == "Norfolk")
            {
                MessageBox.Show("This is not an Irish county");
            }
            else
            {
                MessageBox.Show("This is an Irish county");
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            //6. list box
            switch (listBox1.SelectedItem.ToString())
            {
                case "Poker":
                    MessageBox.Show("This is not a sport");
                    break;

                default:
                    MessageBox.Show("You picked a sport");
                    break;
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            //7. sized array
            int[] numbers = new int[5];
            numbers[0] = 5;
            numbers[1] = 10;
            numbers[2] = 15;
            numbers[3] = 20;
            numbers[4] = 25;

            for (int i = 0; i < 5; i++)
            {
                MessageBox.Show(numbers[i].ToString());
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            //8. array
            string[] city = { "Kerry", "Dublin", "Norfolk", "Cork" };

            foreach (string c in city)
            {
                MessageBox.Show(c);
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            //9. Message box
            int i = 0;
            while (i<10)
            {
                MessageBox.Show("While statement " + i.ToString());
                i++;
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            //10.floating values

            float[] flo = { 5.5F, 6.6F, 7.7F, 8.8F, 9.9F };

            MessageBox.Show(flo[1].ToString());
        }

        private void button10_Click(object sender, EventArgs e)
        {
            //11.all values
            string outp = string.Empty;
            float[] flo = { 5.544F, 6.4676F, 7.9877F, 8.558F, 9.29F };

            foreach (float f in flo)
            {
                outp += Math.Round(f,2).ToString() + "  ";
            }

            MessageBox.Show(outp);
        }

        private void button11_Click(object sender, EventArgs e)
        {
            //12. vocalists
            string[] vocalists = new string[6];
            vocalists[0] = "Nina Simone (f)";
            vocalists[1] = "Killer Mike (m)";
            vocalists[2] = "El Producto (m)";
            vocalists[3] = "Lauren Mayberry (f)";
            vocalists[4] = "Gonjasufi (m)";
            vocalists[5] = "KiloWatts (m)";

            int male = 0; 
            int female = 0;
            string stringToCheck = "(m)";

            for (int i = 0; i < vocalists.Length; i++)
            {
                if (vocalists[i].Contains(stringToCheck))
                {
                    male += 1;
                }
                else
                {
                    female += 1;
                }

            }
            MessageBox.Show("There is " + male.ToString() + " males and " + female.ToString() + " females!");

        }



    }
}
