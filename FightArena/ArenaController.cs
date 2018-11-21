using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FightArena
{
    class ArenaController : DAL
    {
        private List<Character> contestantsList = new List<Character>();
        private List<Character> semiFinalsList = new List<Character>();
        private List<Character> finalsList = new List<Character>();
        private Character winner;

        //Properties to encapsulate
        public List<Character> ContestantsList
        {
            get { return this.contestantsList; }
        }
        public List<Character> SemiFinalsList
        {
            get { return this.semiFinalsList; }
        }
        public List<Character> FinalsList
        {
            get { return this.finalsList; }
        }
        public Character Winner
        {
            get { return this.winner; }
        }

        public ArenaController()
        {

            this.contestantsList = new DAL().GetContestants();

            FightOne();
            SemiFinalsBattle();
            Finals();
        }

        public void FightOne()
        {
            int firstFighter = 0;
            int secondFighter = 0;

            for (int i = 1; i <= contestantsList.Count() / 2; i++)
            {
                secondFighter = firstFighter + 1;

                FightController battle = new FightController();

                battle.Fight(contestantsList[firstFighter], contestantsList[secondFighter]);
                semiFinalsList.Add(battle.Winner);

                firstFighter = firstFighter + 2;
            }

        }

        public void SemiFinalsBattle()
        {
            int firstFighter = 0;
            int secondFighter = 0;

            for (int i = 1; i <= semiFinalsList.Count() / 2; i++)
            {
                secondFighter = firstFighter + 1;

                FightController battle = new FightController();

                battle.Fight(semiFinalsList[firstFighter], semiFinalsList[secondFighter]);

                finalsList.Add(battle.Winner);

                firstFighter = firstFighter + 2;
            }
        }


        public void Finals()
        {
            int firstFighter = 0;
            int secondFighter = 1;

            FightController battle = new FightController();

            battle.Fight(finalsList[firstFighter], finalsList[secondFighter]);

            winner = battle.Winner;

            
        }


    }
}
