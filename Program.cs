using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonGo___Bag_validator
{
    class Program
    {
        // @desc: Bag related variables.
        public static Bag newBag = new Bag();
        public static bool capped = newBag.BagCapped;
        public static int bagCap = newBag.BagCap;

        // @desc: PokeStop related variables.
        public static PokeStop pokeStop = new PokeStop();

        // @desc: Loop related variables.
        public static bool switchTurned = pokeStop.visited;

        // @desc: Loop voor het runnen van de bagvalidator functionaliteit.
        // @author: Iliass Nassibane.
        // @date: 22-08-2016
        public static void loop()
        {
            while (!capped)
            {
                newBag.ShowCurrBag(); // Update de gebruiker over de huidige voorraad in zijn bag.

                Console.WriteLine(" ");
                Console.WriteLine("---------------------------------------------------");
                Console.WriteLine("|            A wild PokeStop appears!             |");
                Console.WriteLine("---------------------------------------------------");
                Console.WriteLine("Press any key to continue >>");
                Console.ReadKey();
                Console.WriteLine("");

                Console.WriteLine("---------------------------------------------------");
                Console.WriteLine("|           Will you engage this PokeStop?        |");
                Console.WriteLine("---------------------------------------------------");
                Console.WriteLine("Please answer with yes or no >>");

                bool answeredCorrectly = false;

                while (!answeredCorrectly)
                {
                    string userResponse = Console.ReadLine();
                    string Response = userResponse.ToLower();
                    if (Response == "yes")
                    {
                        switchTurned = true;
                        answeredCorrectly = true;
                        pokeStop.pokestopVisited();
                    }
                    else if (Response == "no")
                    {
                        Console.WriteLine("Fine! Then we'll have to find another one, don't we?");
                        answeredCorrectly = true;
                        pokeStop.pokestopNotVisited();
                    }
                    else
                    {
                        Console.WriteLine("You did not answer with a yes or a no, please follow the instructions");
                        Console.WriteLine("Press any key to continue >>");
                        Console.WriteLine("");
                    }
                }
                answeredCorrectly = false;

                // if de gebruiker de pokestop draait
                if (switchTurned)
                {
                    // 
                    if (bagCap >= 145)
                    {
                        newBag.AddArrayofItemstoBagFixed();
                    }
                    else
                    {
                        newBag.AddArrayofItemstoBag();
                    }
                }
                else
                {
                    Console.WriteLine("You chose to run away from the scary PokeStop!");
                    Console.WriteLine("Press any key to continue >>");
                    Console.ReadKey();
                    Console.WriteLine("");
                }
                switchTurned = false;
            }
            Console.WriteLine("Thanks for playing this clickbait sim, senpai!");
            Console.WriteLine("Press any key to continue >>");
            Console.ReadKey();
            Console.WriteLine("");
        }

        static void Main(string[] args)
        {
            Console.WriteLine("---------------------------------------------------");
            Console.WriteLine("|                                                 |");
            Console.WriteLine("|                PokeStop Simulator               |");
            Console.WriteLine("|                                                 |");
            Console.WriteLine("---------------------------------------------------");
            Console.WriteLine(" ");

            loop();
        }
    }
}
