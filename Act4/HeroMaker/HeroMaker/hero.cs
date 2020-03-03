using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeroMaker
{
    class Hero
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
    }
}
