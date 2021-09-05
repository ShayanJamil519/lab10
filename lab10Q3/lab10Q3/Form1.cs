using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab10Q3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int imageIndex = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            if(imageIndex >=0 && imageIndex < 4 )
            {
                pictureBox1.Image = imageList1.Images[imageIndex];
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
               
            }
            imageIndex++;
            if (imageIndex == 4)
            {
                imageIndex = 0;
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }
    }
}
