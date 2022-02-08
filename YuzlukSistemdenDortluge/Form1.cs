using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace YuzlukSistemdenDortluge
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            byte not;

            not = Convert.ToByte(textBox1.Text);


            if (not > 84)
                label2.Text = "Sonuç : 5";            
            else if (not > 69)
                label2.Text = "Sonuç : 4";
            else if (not > 59)
                label2.Text = "Sonuç : 3";
            else if (not > 49)
                label2.Text = "Sonuç : 2";
            else
                label2.Text = "Sonuç : 1";
        }
    }
}
