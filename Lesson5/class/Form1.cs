using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace @class
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Vehicle myCar = new Vehicle();
            myCar.Make = "DeLorean";
            myCar.Model = "Time Machine";
            myCar.ElapsedMilage = 9999969;
            myCar.MarketPrice = 1000000;

            //MessageBox.Show(myCar.MarketPrice.ToString());

            string result;
            result = myCar.Drive(30);
            MessageBox.Show(result);
        }
    }
}
