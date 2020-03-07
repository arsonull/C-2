using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MineSweeperGUI
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            int count = 1;

            int sX = 10;
            int sY = 10;
            int width = 40;
            int height = 40;
            int dist = 20;

            for (int r = 0; r < 10; r++)
            {
                for (int c = 0; c < 10; c++)
                {
                    Button butt = new Button();
                    butt.Name = Convert.ToString(count);
                    butt.Top = sX + (r * height + dist);
                    butt.Left = sY + (c * height + dist);
                    butt.Width = width; 
                    butt.Height = height;
                    butt.Click += MyButtonClick;
                    this.Controls.Add(butt);
                    count++;
                }
            }
        }

        void MyButtonClick(object sender, EventArgs e)
        {
            Button butt = sender as Button;

            butt.Text = butt.Name;
        }
    }
}
