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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WindowsFormsApp1
{
    public partial class Form2 : Form
    {
        public string name;
        public int age;
        public string cmbCity;
        public string cmbGender;
        public CheckedListBox ch = new CheckedListBox();

        public Form2 (string name,int age, string cmbGender,string cmbCity,CheckedListBox c)
        {
            InitializeComponent();
            this.ch = c;
            this.name = name;
            this.age = age;
           this.cmbCity = cmbCity;
            this.cmbGender = cmbGender;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string message = ""; //Create a Container

            if (ch.CheckedItems.Count > 1)
            {
                string t = "";
                foreach (var item in ch.CheckedItems)
                {
                    t += item + "   ";
                }

                message = "Hello :" + name + "\n"
                    + "Your Age Is :" + age + "\n"
                    + "You From : " + cmbGender + "\n"
                    + "You Are : " + cmbCity + "\n" + "You Selected this courses :" + t; //Save info in 



               
              
            }
            else
            {

                message = "Hello :" + name + "\n"
                    + "Your Age Is :" + age + "\n"
                    + "You From : " + cmbGender + "\n"
                    + "You Are : " + cmbCity + "\n"
                    + "You Selected this courses :" + ch.SelectedItem;
                
               
            }

            // Clear the content of the file before writing new information
            File.WriteAllText("information.txt", "");

            // Write the message to the file "my data.txt"
            using (StreamWriter writer = new StreamWriter("information.txt", true))
            {
                writer.WriteLine(message);
            }

            // Read the contents of the file and set it to the RichTextBox
            ReadFileAndSetContent("information.txt");
        }

        private void Form2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }
        private void ReadFileAndSetContent(string filePath)
        {
            try
            {
                // Read the contents of the file using FileStream and StreamReader
                using (FileStream fileStream = new FileStream(filePath, FileMode.Open, FileAccess.Read))
                using (StreamReader streamReader = new StreamReader(fileStream))
                {
                    // Set the RichTextBox text to the content of the file
                    richTextBox1.Text = streamReader.ReadToEnd();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error reading the file: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void richbox_read_TextChanged(object sender, EventArgs e)
        {

        }
    }

    }

   

       

   
    
    

