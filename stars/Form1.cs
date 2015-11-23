using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace stars
{

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            StarField(100);
        }

        public void StarField(int length)
        {
            Graphics formGraphics = this.CreateGraphics();
            Random randNum = new Random();

            int red, green, blue;

            int x, y;

            for (int counter = 0; counter <= length; counter++)
            {
                x = randNum.Next(1, this.Width);
                y = randNum.Next(1, this.Height);
                red = randNum.Next(1, 256);
                green = randNum.Next(1, 256);
                blue = randNum.Next(1, 256);
                SolidBrush drawBrush = new SolidBrush(Color.FromArgb(red, green, blue, 0));
                formGraphics.FillEllipse(drawBrush, x, y, 25, 25);
                Thread.Sleep(100);
            }
        }

    }
}
