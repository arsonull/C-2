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
        public Form2(List<Hero> heroes)
        {
            InitializeComponent();
            //heroes.ForEach(heroBox.Items.Add(heroes.name)
            /*foreach (Hero h in heroes)
            {
                heroBox.Items.Add(h.getName());
            }*/
            heroBox.DataSource = heroes;
        }

        private void search_Click(object sender, EventArgs e)
        {
            string hero = heroBox.Text;
            Hero heroObj = heroBox.Items[heroBox.SelectedIndex];
            
        }
    }
}
