using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Arrays
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //1. sized array, set the size
            //string[] myArray = new string[2];
            //myArray[0] = "Lemons";
            //myArray[1] = "Bread";
            //MessageBox.Show(myArray[1]);


            //2. initialized array
            //string[] myArray = {"Lemons", "Bread", "Banana", "Orange"};
            //foreach (var nickname in myArray)
            //{
            //    MessageBox.Show(nickname);
            //}


            //3. for loop
            //string[] myArray = { "Lemons", "Bread", "Banana", "Orange" };
            //for (int i = 0; i < myArray.Length; i++)
            //{
            //    MessageBox.Show(i.ToString());
            //}


            //4. While loop
            //int i = 0;
            //while (i < int.Parse(textBox1.Text))
            //{
            //    i++;
            //}
            //MessageBox.Show("The final value was: " + i.ToString());


            //5.two nested for loops
            string[] myArray = { "Lemons", "Bread", "Banana", "Orange" };
            for (int i = 0; i < myArray.Length;)
            {
                foreach (var nickname in myArray)
                {
                    MessageBox.Show(i++ + " " + nickname);
                }
            }


            //6. loop through myArray
            //string[] myArray = { "Lemons", "Bread", "Banana", "Orange" };
            //for (int i = 0; i < myArray.Length; i++)
            //{
            //    if (myArray[i] == "Bread")
            //    {
            //        MessageBox.Show("Found Bread");
            //    }
            //}


            //7.for loop with switch
            //for (int i = 0; i < listBox1.SelectedItems.Count; i++)
            //{
            //    switch (listBox1.SelectedItems[i].ToString())
            //    {
            //        case "Foobar":
            //            MessageBox.Show("Foobar");
            //            break;
            //        case "Bazquirk":
            //            MessageBox.Show("Bazquirk");
            //            break;  
            //        case "Widgets":
            //            MessageBox.Show("Widgets");
            //            break;
            //        case "Gadgets":
            //            MessageBox.Show("Gadgets");
            //            break;
            //    }
            //}
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
