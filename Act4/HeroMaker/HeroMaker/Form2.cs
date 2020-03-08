using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HeroMaker
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            //Creating a binding source to bind the herobox to the public list
            BindingSource bind = new BindingSource();
            bind.DataSource = HeroList.listOfHeroes;
            heroBox.DataSource = bind;
            //hero box displays the name property from the hero object
            heroBox.DisplayMember = "name";
        }

        private void search_Click(object sender, EventArgs e)
        {
            //go to a new create Form and hide this form
            Form1 f = new Form1();
            f.Show();
            this.Hide();
        }

        private void heroBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            //changes the summary box text to whatever the summary is of the choice you pick, when you pick it.
            summBox.Text = heroBox.SelectedItem.ToString();
        }
    }
}
