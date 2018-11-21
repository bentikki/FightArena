using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FightArena
{
    class Program
    {
        static void Main(string[] args)
        {

            do
            {
                try
                {

                    ArenaController arena = new ArenaController();

                    Console.WriteLine("Contestants:");

                    foreach (var character in arena.ContestantsList)
                    {
                        Console.WriteLine(character.Name);
                    }

                    Console.WriteLine("\nSemi finals");

                    foreach (var character in arena.SemiFinalsList)
                    {
                        Console.WriteLine(character.Name);
                    }

                    Console.WriteLine("\nFinals");

                    foreach (var character in arena.FinalsList)
                    {
                        Console.WriteLine(character.Name);
                    }

                    Console.WriteLine("\nWinner is:");
                    Console.WriteLine(arena.Winner.Name);


                    Console.ReadKey();
                }
                catch (Exception e)
                {

                    Console.WriteLine(e.Message);
                    Console.ReadKey();

                }


            } while (true);
            

        }
    }
}
