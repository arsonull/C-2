using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GUIMinesweeper
{
    class PlayerStats : IComparable<PlayerStats>
    {
        public string name { get; set; }
        public int time { get; set; }
        public int diff { get; set; }
        public int score { get; set; }

        public PlayerStats(string n, int t, int d)
        {
            this.name = n;
            this.time = t;
            this.diff = d;
            this.score = t / (d + 1);
        }

        public int CompareTo(PlayerStats stat)
        {
            if (this.score < stat.score)
            {
                return 1;
            }
            else if (this.score > stat.score)
            {
                return -1;
            }
            else
            {
                return 0;
            }
        }
    }
}
