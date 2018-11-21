using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FightArena
{
    class ArenaController
    {
        public List<Character> ContestantsList = new List<Character>();
        public List<Character> SemiFinalsList = new List<Character>();
        public List<Character> FinalsList = new List<Character>();

        private Character winner;


        public ArenaController(List<Character> contestants)
        {

            this.ContestantsList = contestants;

            FightOne();
            SemiFinalsBattle();
            Finals();
        }

        public Character GetWinner()
        {
            return this.winner;
        }

        public void FightOne()
        {
            int firstFighter = 0;
            int secondFighter = 0;

            for (int i = 1; i <= ContestantsList.Count() / 2; i++)
            {
                secondFighter = firstFighter + 1;

                FightController battle = new FightController();

                battle.Fight(ContestantsList[firstFighter], ContestantsList[secondFighter]);
                SemiFinalsList.Add(battle.Winner);

                firstFighter = firstFighter + 2;
            }

        }

        public void SemiFinalsBattle()
        {
            int firstFighter = 0;
            int secondFighter = 0;

            for (int i = 1; i <= SemiFinalsList.Count() / 2; i++)
            {
                secondFighter = firstFighter + 1;

                FightController battle = new FightController();

                battle.Fight(ContestantsList[firstFighter], ContestantsList[secondFighter]);

                FinalsList.Add(battle.Winner);

                firstFighter = firstFighter + 2;
            }
        }


        public void Finals()
        {
            int firstFighter = 0;
            int secondFighter = 1;

            FightController battle = new FightController();

            battle.Fight(ContestantsList[firstFighter], ContestantsList[secondFighter]);

            winner = battle.Winner;

            
        }


    }
}
