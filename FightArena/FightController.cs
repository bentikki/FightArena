using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FightArena
{
    class FightController
    {
        private Character winner;
        private Character loser;

        public Character Winner
        {
            get { return this.winner; }
        }

        public Character Loser
        {
            get { return this.loser; }
        }

        public void Fight(Character charOne, Character charTwo)
        {

            int whoStarts = new Random().Next(1, 3);

            bool endMatch = false;
            Character firstCharacter;
            Character secondCharacter;
            int rounds = 1;

            do
            {

                if (whoStarts == 1)
                {
                    firstCharacter = charOne;
                    secondCharacter = charTwo;
                }
                else
                {
                    firstCharacter = charTwo;
                    secondCharacter = charOne;
                }


                int attackValue = firstCharacter.Attack() - secondCharacter.Defence();

                if (attackValue <= 0)
                {
                    attackValue = 1;
                }
                secondCharacter.HitPoints = secondCharacter.HitPoints - attackValue;

                if (secondCharacter.HitPoints < 0 || firstCharacter.HitPoints < 0)
                {
                    if (firstCharacter.HitPoints > secondCharacter.HitPoints)
                    {
                        winner = firstCharacter;
                        loser = secondCharacter;
                    }
                    else
                    {
                        winner = secondCharacter;
                        loser = firstCharacter;
                    }

                    endMatch = true;
                }

                if (!endMatch)
                {
                    whoStarts = whoStarts == 1 ? 2 : 1;
                    rounds++;
                }

            } while (!endMatch);

        }





    }
}
