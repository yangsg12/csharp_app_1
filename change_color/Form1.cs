using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace change_color
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.BackColor = lbcolor.BackColor;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.ForeColor = lbcolor.BackColor;
        }

        private void hsbr_Scroll(object sender, ScrollEventArgs e)
        {
            lbcolor.BackColor = Color.FromArgb(hsbr.Value, hsbg.Value, hsbb.Value);
        }

        private void hsbb_Scroll(object sender, ScrollEventArgs e)
        {
            lbcolor.BackColor = Color.FromArgb(hsbr.Value, hsbg.Value, hsbb.Value);
        }

        private void hsbg_Scroll(object sender, ScrollEventArgs e)
        {
            lbcolor.BackColor = Color.FromArgb(hsbr.Value, hsbg.Value, hsbb.Value);
        }
    }
}
