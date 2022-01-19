﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace engine1
{
    public class Weapon:Item
    {
        public int Damage { get; set; }

        public Weapon(int id, string Name, int damage) : base(Name, id)
        {
            Damage = damage;
        }
    }
}
