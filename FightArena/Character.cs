using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FightArena
{
    class Character
    {
        private string name;
        private int attackMin;
        private int attackMax;
        private int defenseMin;
        private int defenseMax;
        private int hitPoints;

        public string Name
        {
            get { return this.name; }
        }
        public int HitPoints
        {
            get { return this.hitPoints; }
            set { this.hitPoints = value; }
        }

        public Character(string name, int attackMin, int attackMax, int defenseMin, int defenseMax, int hitPoints)
        {
            this.name = name;
            this.attackMin = attackMin;
            this.attackMax = attackMax;
            this.defenseMin = defenseMin;
            this.defenseMax = defenseMax;
            this.hitPoints = hitPoints;
        }

        //Gets a random number betweeen min and max attack value
        public int Attack()
        {
            int attackValue;
            Random r = new Random();
            attackValue = r.Next(attackMin, (attackMax + 1));

            return attackValue;
        }


        //Gets a random number betweeen min and max defence value
        public int Defence()
        {
            int defenceValue;
            Random r = new Random();
            defenceValue = r.Next(defenseMin, defenseMax);

            return defenceValue;
        }

    }
}
