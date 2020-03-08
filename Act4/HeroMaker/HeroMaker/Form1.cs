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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //sets all the properties. I felt a boolean array would be better for keeping track of which abilities a hero has
            bool[] powers = {flyBox.Checked, supStrBox.Checked, auraBox.Checked, psyBox.Checked,
            eleBox.Checked, boomBox.Checked, godBox.Checked, supIntBox.Checked, teleBox.Checked,
            gravBox.Checked, timeBox.Checked, supSpdBox.Checked};
            string align = "";
            //this turns the numerical values of the slider, and transfers them into string values adding into one singular string
            switch(Alignment1.Value)
            {
                case 1:
                    align += "Lawful";
                    break;
                case 2:
                    align += "Neutral";
                    break;
                case 3:
                    align += "Chaotic";
                    break;
                default:
                    break;
            }
            switch (Alignment2.Value)
            {
                case 1:
                    align += " Good";
                    break;
                case 2:
                    align += " Neutral";
                    break;
                case 3:
                    align += " Evil";
                    break;
                default:
                    break;
            }
            //an int[] array for stats. Could've done a double[] so i wouldn't have to convert each control, but int makes more sense
            //and I felt that it was giving in to C# to change my value to double and I'm stubborn
            int[] stat = {Convert.ToInt16(strStat.Value), Convert.ToInt16(dexStat.Value),
            Convert.ToInt16(conStat.Value), Convert.ToInt16(intStat.Value),
            Convert.ToInt16(wisStat.Value), Convert.ToInt16(chaStat.Value)};
            string trans;
            //Transfers a boolean radio button into a string for the transportation property
            if(publicTrans.Checked)
            {
                trans = "public transportation";
            }
            else if(powerTrans.Checked)
            {
                trans = "abilities";
            }
            else
            {
                trans = "private transportation";
            }
            //overloaded constructor looks crazy
            Hero hero = new Hero(nameBox.Text, powers, bDayPicker.Value, awareBox.Value,
                controlPicker.Value, originBox.Text, trans, align, stat, descBox.Text);
            //adds the new hero to the global list
            HeroList.listOfHeroes.Add(hero);
            //creates a new form2, then hides the current form.
            Form2 f = new Form2();
            f.Show();
            this.Hide();
            //this.Close();
        }
    }
}
