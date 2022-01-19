using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace engine1
{
    public class Monster: Creature
    {
        public int ID { get; set; }
        public string name { get; set; }
        public int damage { get; set; }
        public int rewardCoin { get; set; }
        public int rewardXP { get; set; }

        public Monster(int cHP, int mHP, int id, string Name, int Damage, int rCoin, int rXP):base(cHP, mHP)
        {
            ID = id;
            name = Name;
            damage = Damage;
            rewardCoin = rCoin;
            rewardXP = rXP;
        }
    }
}
