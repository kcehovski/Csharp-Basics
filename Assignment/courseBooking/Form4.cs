using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace courseBooking
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //opens a form for enter new course
            Form4 form4 = new Form4();
            form4.Show();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //when I click it showes me a linked list of courses


        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //to save new course when it's entered
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }



    }
}
