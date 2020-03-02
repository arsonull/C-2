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

        private void submit_Click(object sender, EventArgs e)
        {
            bool[] pow = {flyBox.Checked, supStrBox.Checked, auraBox.Checked, psyBox.Checked,
            eleBox.Checked, boomBox.Checked, godBox.Checked, supIntBox.Checked, teleBox.Checked,
            gravBox.Checked, timeBox.Checked, supSpdBox.Checked };
            String trans;
            if (publicRad.Checked)
            {
                trans = "Public Transport";
            }
            else if (abilitiesRad.Checked)
            {
                trans = "Uses abilities";
            }
            else
            {
                trans = "Private transportation";
            }
            String align = "";
            switch(alignSlider1.Value)
            {
                case 1:
                    align += "Lawful ";
                    break;
                case 2:
                    align += "Neutral ";
                    break;
                case 3:
                    align += "Chaotic ";
                    break;
            default:
                    break;
            }
            switch (alignSlider2.Value)
            {
                case 1:
                    align += "Good";
                    break;
                case 2:
                    align += "Neutral";
                    break;
                case 3:
                    align += "Evil";
                    break;
                default:
                    break;
            }
            int[] stat = {Convert.ToInt16(strStat.Value), Convert.ToInt16(dexStat.Value),
                Convert.ToInt16(conStat.Value), Convert.ToInt16(intStat.Value),
                Convert.ToInt16(wisStat.Value), Convert.ToInt16(chaStat.Value)};
            SuperHero hero = new SuperHero(nameBox.Text, pow, bDayPicker.Value, powerKnownPicker.Value,
                controlPicker.Value, countryListBox.Text, trans, align, stat, descBox.Text);
        }
    }
}
