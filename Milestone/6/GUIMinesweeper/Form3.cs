using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUIMinesweeper
{
    public partial class Form3 : Form
    {
        public Form3(bool result, string time)
        {
            InitializeComponent();
            string source = @"D:\Work\highscores.txt";
            var lines = File.ReadAllLines(source).Take(5).ToList();
            scoreBox.DataSource = lines;
            timeLabel.Text = time;
            //If you win
            if (result)
            {
                resultLabel.Text = "You win!!";
                playButt.Text = "Play again?";
            }
            //if you lose
            else
            {
                resultLabel.Text = "You lose";
                playButt.Text = "Try again?";
            }
        }
        //Play again button starts form1 again
        private void playButt_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            this.Hide();
            f.Closed += (s, args) => this.Close();
            f.Show();
        }
    }
}
