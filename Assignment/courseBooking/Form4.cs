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
        List<string> courseNames = new List<string>();


        public Form4()
        {
            InitializeComponent();
            this.Text = "Sofware Training";
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //opens a new file
            SaveFileDialog newFile = new SaveFileDialog();
            newFile.Title = "Save Text File";
            newFile.Filter = "TXT files|*.txt";
            newFile.InitialDirectory = @"\courseBooking";


            if (newFile.ShowDialog() != DialogResult.OK || newFile.FileName != "*.txt")
            {
                MessageBox.Show("File incorrect format or dialog cancelled", "Error 001", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                File.Create(newFile.FileName);
            }
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
        
            //open an existing file and showes me courses in a list Box

            listBox1.Visible = true;
            button2.Visible = true;

            OpenFileDialog myDialog = new OpenFileDialog();
            myDialog.Title = "Open Text File";
            myDialog.Filter = "All files|*.*";
            myDialog.InitialDirectory = @"\courseBooking";

            //if the user clicked OK then read from file

            if (myDialog.ShowDialog() != DialogResult.OK || myDialog.FileName != "*.txt")
            {
                MessageBox.Show("File open error or dialog cancelled", "Error 002", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else 
            {
                filename = myDialog.FileName;
                fileLines = File.ReadAllLines(filename);    //array

                for (int i = 0; i < fileLines.Length; i++)
                {
                    fileLines[i] = fileLines[i].Trim('"');  //it moves " from begining and end of each line
                }

                for (int i = 0; i < fileLines.Length; i += 4)   //it loops through array od lines and adds every 4th line (names) to list 
                {
                    courseNames.Add(fileLines[i]);
                }

                courseNames = courseNames.Distinct().ToList<string>();  //moves course name duplicates

                listBox1.Items.Clear(); //clear listBox from existing courses
                
                foreach (string item in courseNames)
                {
                    listBox1.Items.Add(item);
                }
            } 
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //to save new course when it's entered
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (fileLines != null && listBox1.SelectedIndex != -1)
            {
                Form2 form2 = new Form2();
                form2.Show();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DateTime result;
            CultureInfo provider = CultureInfo.InvariantCulture;
            
            try
            {
                result = DateTime.ParseExact(textBox2.Text, "dd/MM/yyyy", provider);

                string[] info = new string[4];
                info[0] = '"' + textBox1.Text + '"';
                info[1] = '"' + result.ToShortDateString() + '"';
                info[2] = '"' + "€" + textBox3.Text.ToString() + '"';
                info[3] = '"' + "FFFFFFFFFFFF" + '"' + "\n";

                foreach (string inf in info)
                {
                    using (StreamWriter file = new StreamWriter(@"C:\Users\blue4\Documents\vsprojects\Csharp-Basics\Assignment\courseBooking\Courses.txt", true))
                    {
                        file.WriteLine(inf);
                    }
                }

                textBox1.Clear();
                textBox2.Clear();
                textBox3.Clear();

            }

            catch (FormatException)
            {
                MessageBox.Show("Invalid Date", "Error 004", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }




    }
}
