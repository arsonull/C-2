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
    public partial class Form2 : Form
    {
        private int total;
        private int time;
        private int count;
        private int size;
        private Board game;

        public Form2(Board g, int diff)
        {
            InitializeComponent();
            //setting the class Board for the form and other large scope variables, along with starting timer1
            game = g;
            size = game.size;
            total = diff * size;
            count = 0;
            timer1.Start();

            //constants for the dynamically created buttons to make the spaced out and look nice
            int sX = 10;
            int sY = 10;
            int width = 40;
            int height = 40;
            int dist = 20;

            //nested for loops to dynamically create buttons
            for (int r = 0; r < size; r++)
            {
                for (int c = 0; c < size; c++)
                {
                    Button butt = new Button();
                    //setting button name to their coordinates in relation to the game.grid
                    butt.Name = r + "," + c;
                    butt.Top = sX + (r * height + dist);
                    butt.Left = sY + (c * height + dist);
                    butt.Width = width;
                    butt.Height = height;
                    butt.MouseDown += MyButtonClick;
                    this.Controls.Add(butt);
                }
            }
            //int variable for where the edge of the board is
            int rightBord = 60 * size;
            //setting a label for the time, amount of bombs, and how many spaces you've cleared
            Label timeLabel = new Label();
            Point timePoint = new Point(rightBord,80);
            timeLabel.Location = timePoint;
            timeLabel.Name = "timeLabel";
            timeLabel.Text = time + " seconds";
            this.Controls.Add(timeLabel);
            Label bombAmount = new Label();
            Point amountPoint = new Point(rightBord, 120);
            bombAmount.Location = amountPoint;
            bombAmount.Text = "Bombs: " + Convert.ToString(total);
            this.Controls.Add(bombAmount);
            Label bombCount = new Label();
            Point bombPoint = new Point(rightBord, 160);
            bombCount.Name = "bombCount";
            bombCount.Text = Convert.ToString(count);
            bombCount.Location = bombPoint;
            this.Controls.Add(bombCount);
        }

        void MyButtonClick(object sender, EventArgs e)
        {
            //casting eventargs to a mouse event to get which button was clicked
            MouseEventArgs ee = (MouseEventArgs)e;
            Button butt = sender as Button;
            //getting the coordinates of the button pressed by splitting the name using a ',' delimiter
            string[] co = butt.Name.Split(',');
            //setting coordinates as ints to be used
            int x = Convert.ToInt16(co[0]);
            int y = Convert.ToInt16(co[1]);

            //switch for which button was pressed
            switch (ee.Button)
            {
                case MouseButtons.Left:
                    //if no flag
                    if (butt.Image == null)
                    {
                        if (game.grid[x,y].Live)
                        {
                            //Lost game
                            timer1.Stop();
                            Form3 f = new Form3(false, Convert.ToString(time));
                            f.Show();
                            this.Hide();
                        }
                        else
                        {
                            //use the floodfill to handle visiting and interacting with board
                            floodFill(x, y, butt);
                            //If cleared all spaces except for bombs, you win
                            if (count == (size * size) - total)
                            {
                                timer1.Stop();
                                this.Hide();
                                Form3 f = new Form3(true, Convert.ToString(time));
                                f.Closed += (s, args) => this.Close();
                                f.Show();
                            }
                        }
                    }
                    break;
                    //place flag on right click
                case MouseButtons.Right:
                    if (butt.Image == null && butt.Text == "")
                    {
                        butt.Image = Image.FromFile(@"C:\Users\spart\Documents\GitHub\C-2\Milestone\6\flag.jpg");
                    }
                    //butt.Text = "right";
                    break;
                default:
                    break;
            }
            //------------------------------Debugging for mousedown event-------------------------------------
            //if (ee.Button == System.Windows.Forms.MouseButtons.Right) { MessageBox.Show("Right click"); }
            //if (ee.Button == System.Windows.Forms.MouseButtons.Left) { MessageBox.Show("Left click"); }
            /*if (butt.Name == "1")
            {
                //Lost game
            }
            else
            {
                count++;
                butt.Text = butt.Name;
                if (count == total)
                {
                    //won game
                }
            }--------------------------------------------------------------------------------------------------*/
        }

        //recursive floodfill stolen from my board class and changed slightly
        public void floodFill(int r, int c, Button b)
        {
            if (r < 0 || c < 0) { return; }
            if (r >= size || c >= size) { return; }
            if (!game.grid[r, c].Live && game.grid[r, c].liveNeighbours == 0 && !game.grid[r, c].visited)
            {
                game.grid[r, c].visited = true;
                b.Text = Convert.ToString(game.grid[r, c].liveNeighbours);
                //setting strings for coordinate numbers, to later use for button names
                string r1 = Convert.ToString(r + 1);
                string r2 = Convert.ToString(r - 1);
                string c1 = Convert.ToString(c + 1);
                string c2 = Convert.ToString(c - 1);
                //getting each button that is being checked by selecting the button with the name that corresponds to the coordinates
                Button b1 = (Button)this.Controls[r1 + "," + Convert.ToString(c)];
                Button b2 = (Button)this.Controls[r2 + "," + Convert.ToString(c)];
                Button b3 = (Button)this.Controls[Convert.ToString(r) + "," + c1];
                Button b4 = (Button)this.Controls[Convert.ToString(r) + "," + c2];
                //call this function again for each cell being checked
                floodFill(r + 1, c, b1);
                floodFill(r - 1, c, b2);
                floodFill(r, c + 1, b3);
                floodFill(r, c - 1, b4);
                //updates the count of cells cleared and updates the label for it
                count++;
                Label t = (Label)this.Controls["bombCount"];
                t.Text = Convert.ToString(count);
                return;
            }
            else if (!game.grid[r, c].Live && !game.grid[r, c].visited)
            {
                //Does what the last block does but without the recursive quality
                game.grid[r, c].visited = true;
                b.Text = Convert.ToString(game.grid[r, c].liveNeighbours);
                count++;
                Label t = (Label)this.Controls["bombCount"];
                t.Text = Convert.ToString(count);
                return;
            }
            else
            {
                //exit the function if none of these if statements go
                return;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //update the time variable and the label for time
            time++;
            Label t = (Label)this.Controls["timeLabel"];
            t.Text = Convert.ToString(time);
        }
    }
}
