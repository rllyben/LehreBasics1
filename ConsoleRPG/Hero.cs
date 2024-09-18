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
        private static int maxHealth { get; set; } = 100;
        private static int curHealth { get; set; } = 100;
        private static int lvl { get; set; } = 1;
        private static int damage { get; set; } = 1;
        private static float actionSpeed { get; set; } = 0.5F;

        public int MaxHealth()
        {
            return maxHealth;
        }
        public int CurrentHealth()
        {
            return curHealth;
        }
        public int Level()
        {
            return lvl;
        }
        public int Damage()
        {
            return damage;
        }
        public float ActionSpeed() 
        {
            return actionSpeed;
        }
        public void Healer()
        {
            curHealth = maxHealth;
        }

    }

}
