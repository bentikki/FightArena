using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FightArena
{
    class DAL
    {
        private List<Character> arenaList = new List<Character>
        {
            new Character("Kong Fu Harry", 2, 2, 5, 5, 120),
            new Character("Super Hunden Dino", 6, 8, 2, 8, 70),
            new Character("Hurtig Karl", 2, 5, 5, 5, 90), /* Needs Special */
            new Character("Gift Gunner", 1, 13, 5, 5, 90),
            new Character("Minimusen Mikkel", 9, 9, 27, 27, 40),
            new Character("Katten Tiger", 3, 6, 5, 5, 35), /* Needs Special*/
            new Character("Gummigeden Ivan", 6, 6, 8, 8, 70),
            new Character("Elgen Egon", 5, 11, 4, 4, 90),
        };

        public List<Character> GetContestants()
        {
            return arenaList;
        }


    }
}
