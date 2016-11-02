using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonGo___Bag_validator
{
    class PokeStop
    {
        public bool visited = false;

        public void pokestopVisited()
        {
            Console.WriteLine("PokeStop: I got twizted!");
        }

        public void pokestopNotVisited()
        {
            Console.WriteLine("PokeStop: Don't leave me, Senpai!");
        }
    }
}
