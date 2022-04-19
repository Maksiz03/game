using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace age
{
    public partial class Form11 : Syncfusion.Windows.Forms.Office2010Form
    {
        public Form11()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Hide();
            Form3 книга = new Form3();
            книга.ShowDialog();
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Hide();
            Form2 город = new Form2();
            город.ShowDialog();
            Close();
        }
    }
}
