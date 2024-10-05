using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TugasEventHandling
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonLabel_Click(object sender, EventArgs e)
        {
            label1.Text = ((Button)sender).Text + " clicked";
        }


        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            label2.Text = ((TextBox)sender).Text;
        }

        private void label3_MouseEnter(object sender, EventArgs e)
        {
            label3.BackColor = Color.SlateGray;
            label3.ForeColor = Color.White;
            label3.BorderStyle = BorderStyle.Fixed3D;
        }
        
        
        private void label3_MouseLeave(object sender, EventArgs e)
        {
            label3.BackColor = DefaultBackColor;
            label3.ForeColor = DefaultForeColor;
            label3.BorderStyle = BorderStyle.None;
        }
    }
}