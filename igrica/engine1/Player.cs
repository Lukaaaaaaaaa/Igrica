using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace engine1
{
    public class Player: Creature
    {
        public int coin { get; set; }
        public int xp { get; set; }
        public int level { get; set; }

        public Player (int cHP, int mHP, int Coin, int XP, int lvl) : base(cHP, mHP)
        {
            coin = Coin;
            xp = XP;
            level = lvl;
        }
    }
}
