using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace YemekSiparisUygulamasi
{
    
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
            label1.ForeColor = Color.Red;
            label2.ForeColor = Color.Red;
            label3.ForeColor = Color.Red;
            label1.Text = "ControlBox";
            label2.Text = "MinimizeBox";
            label3.Text = "MaximizeBox";
            checkBox1.Text = "False";
            checkBox2.Text = "False";
            checkBox3.Text = "False";


        }
        //ControlBox
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
           
            bool cb1 = checkBox1.Checked;
            if (cb1==true)
            {
                label1.ForeColor = Color.Green;
                checkBox1.Text = "True";
                Form1.ActiveForm.ControlBox = false;
            }
            else
            {
                label1.ForeColor = Color.Red;
                checkBox1.Text = "False";
                Form1.ActiveForm.ControlBox = true;
            }
        }
        //MinimizeBox
        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            
            bool cb2 = checkBox2.Checked;
            if (cb2 == true)
            {
                label2.ForeColor = Color.Green;
                checkBox2.Text = "True";
                Form1.ActiveForm.MinimizeBox = false;
            }
            else
            {
                label2.ForeColor = Color.Red;
                checkBox2.Text = "False";
                Form1.ActiveForm.MinimizeBox = true;
            }
        }
        //MaximizeBox
        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
           
            bool cb3 = checkBox3.Checked;
            if (cb3 == true)
            {
                label3.ForeColor = Color.Green;
                checkBox3.Text = "True";
                Form1.ActiveForm.MaximizeBox = false;
            }
            else
            {
                label3.ForeColor = Color.Red;
                checkBox3.Text = "False";
                Form1.ActiveForm.MaximizeBox = true;
            }
        }
        //Renk Seçici
        private void button1_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
           
            if (Application.OpenForms["Form2"] == null)
            {
               
                form2.StartPosition = FormStartPosition.CenterScreen;
                form2.Show();
               
             
            }
            else
            {
                MessageBox.Show("Form Açık","Uyarı");
            }
           
           
        }

       
    }
}
