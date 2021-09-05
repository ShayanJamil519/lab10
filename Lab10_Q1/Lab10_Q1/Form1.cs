using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab10_Q1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            Graphics g = base.CreateGraphics();
            Pen p = new Pen(Color.Green);
            SolidBrush sb = new SolidBrush(Color.Red);
            g.Clear(Color.White);
            switch (comboBox1.SelectedIndex)
            {
                case 0:
                    g.DrawEllipse(p, 390, 200, 200, 200);
                    break;
                case 1:
                    g.FillEllipse(sb, 390, 200, 200, 200);
                    break;
                case 2:
                    g.DrawRectangle(p, 390, 200, 150, 150);
                    break;
                case 3:
                    g.FillRectangle(sb, 390, 200, 150, 150);
                    break;
                case 4:
                    g.DrawRectangle(p, 390, 200, 150, 80);
                    break;
                case 5:
                    g.FillRectangle(sb, 390, 200, 150, 80);
                    break;
                case 6:
                    g.DrawPie(p, 390, 200, 250, 250, 180, 45);
                    break;
                case 7:
                    g.FillPie(sb, 390, 200, 250, 250, 180, 45);
                    break;
            }
        }


    }
}
