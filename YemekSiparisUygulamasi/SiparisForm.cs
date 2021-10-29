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
    
    public partial class SiparisForm : Form
    {
        double bakiye;
        double mevcutbakiye;
        public SiparisForm()
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
                SiparisForm.ActiveForm.ControlBox = false;
            }
            else
            {
                label1.ForeColor = Color.Red;
                checkBox1.Text = "False";
                SiparisForm.ActiveForm.ControlBox = true;
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
                SiparisForm.ActiveForm.MinimizeBox = false;
            }
            else
            {
                label2.ForeColor = Color.Red;
                checkBox2.Text = "False";
                SiparisForm.ActiveForm.MinimizeBox = true;
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
                SiparisForm.ActiveForm.MaximizeBox = false;
            }
            else
            {
                label3.ForeColor = Color.Red;
                checkBox3.Text = "False";
                SiparisForm.ActiveForm.MaximizeBox = true;
            }
        }
        //Renk Seçici
        private void button1_Click(object sender, EventArgs e)
        {
            RenkSecici form2 = new RenkSecici();
           
            if (Application.OpenForms["Form2"] == null)
            {
               
                form2.StartPosition = FormStartPosition.CenterScreen;
                form2.Show();
               
             
            }
            else
            {
                MessageBox.Show("Renk Seçici Açık","Uyarı");
            }
           
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            bakiye = Convert.ToDouble(textBox1.Text);
            double bakiyetoplam = bakiye + mevcutbakiye;
            if (mevcutbakiye<=500&&bakiyetoplam <=500)
            {
                if (bakiye >= 1)
                {

                    if (textBox1.Text != "" && bakiye <= 500)
                    {

                        mevcutbakiye += bakiye;
                        label6.Text = mevcutbakiye.ToString();
                        textBox1.Clear();
                    }
                }
            }
            else
            {
                MessageBox.Show("500 Tl den Fazla Para Yüklenemez","Bilgilendirme");
            }
           
            
           
        }
    }
}
