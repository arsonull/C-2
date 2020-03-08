using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeroMaker
{
    public class Hero
    {
        private string name;
        private bool[] abilities;
        private DateTime bDay;
        private DateTime aware;
        private DateTime control;
        private string country;
        private string transport;
        private string alignment;
        private int[] stats;
        private string desc;
        //very overloaded creator to allow for all data to be set from one method, rather than requiring a ton of setters
        public Hero(string n, bool[] pow, DateTime bd, DateTime awa, DateTime con, string orig,
            string trans, string align, int[] stat, string descript)
        {
            this.name = n;
            this.abilities = pow;
            this.bDay = bd;
            this.aware = awa;
            this.control = con;
            this.country = orig;
            this.transport = trans;
            this.alignment = align;
            this.stats = stat;
            this.desc = descript;
        }
        //get return a summary of the hero as a string
        public string getSummary()
        {
            string summ = "";
            summ += "Name: " + this.name + ". ";
            summ += "Powers: ";
            if (this.abilities[0]) { summ += "Flying "; }
            if (this.abilities[1]) { summ += "Super Strength "; }
            if (this.abilities[2]) { summ += "Aura Sense "; }
            if (this.abilities[3]) { summ += "Psychic Powers "; }
            if (this.abilities[4]) { summ += "Elementalist "; }
            if (this.abilities[5]) { summ += "Explosions "; }
            if (this.abilities[6]) { summ += "Creation "; }
            if (this.abilities[7]) { summ += "Super Intellect "; }
            if (this.abilities[8]) { summ += "Teleportation "; }
            if (this.abilities[9]) { summ += "Gravity "; }
            if (this.abilities[10]) { summ += "Time "; }
            if (this.abilities[11]) { summ += "Super Speed"; }
            summ += ".";

            return summ;
        }
        //used for testing
        public string getName()
        {
            return name;
        }
        //test to see if this works
        public override string ToString()
        {
            string summ = "";
            summ += "Name: " + this.name + ". ";
            summ += "Powers: ";
            if (this.abilities[0]) { summ += "Flying "; }
            if (this.abilities[1]) { summ += "Super Strength "; }
            if (this.abilities[2]) { summ += "Aura Sense "; }
            if (this.abilities[3]) { summ += "Psychic Powers "; }
            if (this.abilities[4]) { summ += "Elementalist "; }
            if (this.abilities[5]) { summ += "Explosions "; }
            if (this.abilities[6]) { summ += "Creation "; }
            if (this.abilities[7]) { summ += "Super Intellect "; }
            if (this.abilities[8]) { summ += "Teleportation "; }
            if (this.abilities[9]) { summ += "Gravity "; }
            if (this.abilities[10]) { summ += "Time "; }
            if (this.abilities[11]) { summ += "Super Speed"; }
            summ += ". Birthday: ";
            summ += this.bDay.ToString();
            summ += ". Aware of their power(s): " + this.aware.ToString() + ". Control over their power(s): " + this.control.ToString();
            summ += ". Comes from " + this.country + ".";
            summ += "Prefers " + this.transport + " for transportation.";
            summ += "They seem to have an alignment of " + this.alignment + ".";
            summ += "Stats are Str:" + Convert.ToString(this.stats[0]) + "; Dex:" + Convert.ToString(this.stats[1]) + "; Con:" +
                Convert.ToString(this.stats[2]) + "; Int:" + Convert.ToString(this.stats[3]) + "; Wis:" + Convert.ToString(this.stats[4]) +
                "; Cha:" + Convert.ToString(this.stats[5]) + ".";
            summ += "Official Description: " + this.desc;

            return summ;
        }
    }
}
