using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeroMaker
{
    class SuperHero
    {
        private String name { get; set; }
        private bool[] abilities { get; set; }
        private DateTime bDay { get; set; }
        private DateTime aware { get; set; }
        private DateTime control { get; set; }
        private String country { get; set; }
        private String transport { get; set; }
        private String alignment { get; set; }
        private int[] stats { get; set; }
        private String desc { get; set; }

        public SuperHero(String n, bool[] pow, DateTime b, DateTime awar, DateTime cont, String coun, String trans, String align, int[] stat, String des)
        {
            this.name = n;
            this.abilities = pow;
            this.bDay = b;
            this.aware = awar;
            this.control = cont;
            this.country = coun;
            this.transport = trans;
            this.alignment = align;
            this.stats = stat;
            this.desc = des;
        }
    }
    
}
