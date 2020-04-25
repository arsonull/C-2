using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUIMinesweeper
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            label3.Text = Convert.ToString(diffBar.Value);
        }

        private void diffBar_Scroll(object sender, EventArgs e)
        {
            label3.Text = Convert.ToString(diffBar.Value);
        }

        private void playButt_Click(object sender, EventArgs e)
        {
            //Creating a board object using the user's choices
            Board game = new Board(Convert.ToInt16(sizeNum.Value));
            game.createBombs(diffBar.Value);
            game.checkNeighbors2();
            this.Hide();
            Form2 f = new Form2(game, diffBar.Value, nameBox.Text);
            f.Closed += (s, args) => this.Close();
            f.Show();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
