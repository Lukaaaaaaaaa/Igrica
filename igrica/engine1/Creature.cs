using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace engine1
{
    public class Creature
    {
        public int currentHP { get; set; }
        public int maxHP { get; set; }

        public Creature (int cHP, int mHP)
        {
            currentHP = cHP;
            maxHP = mHP;
        }
    }
}
