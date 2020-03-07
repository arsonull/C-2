using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeroMaker
{
    public class HeroList
    {
        private List<Hero> listOfHeroes { get; set; }

        public HeroList()
        { }
        public HeroList(Hero h)
        {
            this.listOfHeroes.Add(h);
        }
        public void addHero(Hero h)
        {
            this.listOfHeroes.Add(h);
        }
    }
}
