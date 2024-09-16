using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleRPG
{
    public class Hero
    {
        public required string name { get; set; }
        public int maxHealth { get; set; } = 100;
        public int curHealth { get; set; } = 100;
        public int lvl { get; set; } = 1;
        public int damage { get; set; } = 1;
        public float actionSpeed { get; set; } = 0.5F;

    }

}
