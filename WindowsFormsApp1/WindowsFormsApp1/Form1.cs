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

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string Sup_name = textName.Text;
            int Sup_Age =int.Parse(TextAge.Text);
            string cmb_City = cmbCity.Text;
            string cmb_Gender = cmbGender.Text;

            MessageBox.Show("The information has been Saved Sucssefully");

            Form2 form = new Form2(Sup_name,Sup_Age,cmb_City,cmb_Gender,ChklCourses ); //نعمل اوبجيكت نسخه من فورم 2
            form.ShowDialog();// نستخدمها لعرض فورم 2
        
        }

        private void cmbGender_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cmbCity_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
