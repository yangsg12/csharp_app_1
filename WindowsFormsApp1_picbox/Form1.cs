using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1_picbox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private int picNo;
        private void Form1_Load(object sender, EventArgs e)
        {
            picNo = 0;
            timer1.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "图文件|*jpg";
            openFileDialog1.FilterIndex = 3;
            openFileDialog1.ShowDialog();
            listBox1.Items.Add(openFileDialog1.FileName);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            listBox1.SelectedIndex = picNo;
            string s = listBox1.SelectedItem.ToString();

            pictureBox1.Image = Image.FromFile(s);
            picNo = picNo + 1;
            if(picNo >= listBox1.Items.Count)
            {
                picNo = 0;
            }
        }
    }
}
