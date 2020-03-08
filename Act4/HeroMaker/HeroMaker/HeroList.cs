using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeroMaker
{
    public static class HeroList
    {
        //creates a single public list that can be accessed everywhere, but there can only be one, so there is no "new" keyword possible
        //outside of right here           -------v-------
        public static List<Hero> listOfHeroes = new List<Hero>();
    }
}
