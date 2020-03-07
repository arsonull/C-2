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
        public string getName()
        {
            return name;
        }
    }
}
