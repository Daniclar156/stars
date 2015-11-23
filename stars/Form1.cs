using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            starfield(100);
        }

        public void starfield(int length)
        {
            Graphics formGraphics = this.CreateGraphics();
            Random randNum = new Random();

            int red, green, blue;
            red = randNum.Next(1, 256);
            green = randNum.Next(1, 256);
            blue = randNum.Next(1, 256);
            int x, y;
            x = randNum.Next(1, this.Width);
            y = randNum.Next(1, this.Width);

            SolidBrush drawBrush = new SolidBrush(Color.FromArgb(red, green, blue, 0));
            for (int counter = 0; counter <= length; counter++)
            {
               formGraphics.FillEllipse(drawBrush, x, y, 25, 25);
            }
        }

    }
}
