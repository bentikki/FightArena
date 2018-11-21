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
                    List<Character> arenaList = new List<Character>
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

                    ArenaController arena = new ArenaController(arenaList);


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

                    Console.WriteLine("\nfinals");

                    foreach (var character in arena.FinalsList)
                    {
                        Console.WriteLine(character.Name);
                    }

                    Console.WriteLine("\nWinner is:");
                    Console.WriteLine(arena.GetWinner().Name);


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
