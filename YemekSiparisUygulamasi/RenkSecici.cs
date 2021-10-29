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
    public partial class RenkSecici : Form
    {
        public RenkSecici()
        {
            InitializeComponent();
            label1.BackColor = Color.Gray;
            label2.BackColor = Color.White;
            label3.BackColor = Color.Silver;
            
        }

      

        private void label1_Click(object sender, EventArgs e)
        {
            Application.OpenForms["Form1"].BackColor = Color.Gray;
        }

        private void label2_Click(object sender, EventArgs e)
        {
            Application.OpenForms["Form1"].BackColor = Color.White;
        }

        private void label3_Click(object sender, EventArgs e)
        {
            Application.OpenForms["Form1"].BackColor = Color.Silver;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.OpenForms["Form2"].Close();
        }
    }
}
