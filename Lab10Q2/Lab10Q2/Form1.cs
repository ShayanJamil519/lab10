using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab10Q2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Button[] b = new Button[5];
            for (int i = 1; i <= b.Length - 1; i++)
            {
                b[i] = new Button();
                b[i].Text = "Button" + i;
                b[i].Size = new Size(130, 50);
                b[i].BackColor = Color.Red;
                b[i].ForeColor = Color.White;
                b[i].Left = 80 * i;
                b[i].Top = i * 80;
                this.Controls.Add(b[i]);
            }
        }
    }
}