using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace age
{
    public partial class Menu : Syncfusion.Windows.Forms.Office2010Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        
        private void button1_Click(object sender, EventArgs e)
        {
            Hide();
            Form2 книга = new Form2();
            книга.ShowDialog();
            Close();
        }

        private void button1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            var localPosition = this.PointToClient(Cursor.Position);
        }
    }
}
