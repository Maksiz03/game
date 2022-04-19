using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;

using System.Text;
using System.Windows.Forms;

namespace age
{
    public partial class Form2 : Syncfusion.Windows.Forms.Office2007Form
    {
        public Form2()
        {
            InitializeComponent();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Hide();
            Form11 лаба = new Form11();
            лаба.ShowDialog();
            Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form2_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Hide();
            arena лаба = new arena();
            лаба.ShowDialog();
            Close();
        }
    }
}
