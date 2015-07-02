using System;
using System.IO;
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
    public partial class Form1 : Form
    {
        string filename;
        public static string[] fileLines;
        public static List<string> fileNewLines = new List<string>();
        List<string> courseNames = new List<string>();

        public Form1()
        {
            InitializeComponent();
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //opens a new file
            SaveFileDialog newFile = new SaveFileDialog();
            newFile.Title = "Save Text File";
            newFile.Filter = "TXT files|*.txt";
            newFile.InitialDirectory = @"\courseBooking";
            //details for the dialog box, title, filter, and which directory to open

            if (newFile.ShowDialog() == DialogResult.OK)  //waits for OK button to be clicked
            {
                if (Path.GetExtension(newFile.FileName) == ".txt") //checks that you entered .txt extension, and then creates a new file
                {
                    File.Create(newFile.FileName);
                }

                else   //if extension is something different than .txt it's going to show the message box
                {
                    MessageBox.Show("File incorrect format or dialog cancelled", "Error 001", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //open an existing file and showes me courses in a list Box

            OpenFileDialog myDialog = new OpenFileDialog();
            myDialog.Title = "Open Text File";
            myDialog.Filter = "TXT files|*.txt";
            myDialog.InitialDirectory = @"\courseBooking";

            //if the user clicked OK then read from file
            listBox1.Items.Clear();
            courseNames.Clear();


            if (myDialog.ShowDialog() == DialogResult.OK)   //waits for OK button to be clicked
            {
                filename = myDialog.FileName;
                fileLines = File.ReadAllLines(filename, Encoding.Default);    //array, elements are lines from file

                for (int i = 0; i < fileLines.Length; i++)
                {
                    fileLines[i] = fileLines[i].Trim('"');  //it moves " from begining and end of each line
                }

                for (int i = 0; i < fileLines.Length; i += 4)   //it loops through array od lines and adds every 4th line (names) to list 
                {
                    courseNames.Add(fileLines[i]);
                }

                courseNames = courseNames.Distinct().ToList<string>();  //moves course name duplicates

                foreach (string item in courseNames)
                {
                    listBox1.Items.Add(item);  //adding course names to listbox
                }

            }

            else   //if dialog is cancelled it will show message box
            {
                MessageBox.Show("File open error or dialog cancelled", "Error 002", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (fileLines != null && listBox1.SelectedIndex != -1)
            {
                Form2 form2 = new Form2();
                form2.Show();
            }
        }


        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //to save new course when it's entered

            try
            {
                //writting into the file which is already open 
                using (StreamWriter file = new StreamWriter(filename, false, Encoding.Default)) //false means that it's going to overwritte it 
                {
                    foreach (string line in fileLines)
                    {
                        file.WriteLine('"' + line + '"');
                    }
                    file.Close();
                }
            }

            catch (NullReferenceException)  //if you didn't open a file before than it will show message box
            {
                MessageBox.Show("No file to save.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            catch (FileNotFoundException)  // if it cann't find the file to writte in
            {
                MessageBox.Show("File save error.", "Error 003", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //opens a form for enter new course

            if (fileLines != null)
            {
                Form4 form4 = new Form4();
                form4.FormClosed += form4_FormClosed;
                form4.Show();
            }
            else
            {
                MessageBox.Show("No course file opened.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void form4_FormClosed(object sender, FormClosedEventArgs e)
        {
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
}
