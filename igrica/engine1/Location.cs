using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace engine1
{
    public class Location
    {
        public string name { get; set; }
        public int ID { get; set; }

        public Location ( int id, string Name)
        {
            ID = id;
            name = Name;
        }
    }
}
