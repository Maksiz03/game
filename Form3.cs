using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace age
{
    public partial class Form3 : Syncfusion.Windows.Forms.Office2010Form
    {
        public Form3()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Hide();
            Form11 назад = new Form11();
            назад.ShowDialog();
            Close();
        }
    }
}
