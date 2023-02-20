using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Instalaciondeentorno

{
    public partial class Form1 : Form
    {
        Bitmap ima1;
        public Form1()
        {
            InitializeComponent();

            ima1 = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            pictureBox1.Image= ima1;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Bitmap bmp = new Bitmap(textBox1.Text);
            pictureBox1.Image = bmp;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Graphics.FromImage(ima1).DrawLine(Pens.Yellow, 0, 0, 150, 50);
            pictureBox1.Refresh();
        }
    }
}
