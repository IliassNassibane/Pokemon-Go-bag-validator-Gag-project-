using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonGo___Bag_validator
{
    class Bag
    {
        public int BagLimit = 150;
        public int BagCap = 0;
        public bool BagCapped = false;


        // @desc: "Database" van de inhoud. Wordt tijdig geupdate door de 
        // @author: Iliass Nassibane.
        // @date: 22-08-2016
        /*
        ________________________________________
        |   ID      |  ItemNaam    |   aantal  |
        ----------------------------------------
        |   1       |  potion      |   0       |
        |   2       |  pokeball    |   0       |
        |   3       |  berry       |   0       |
        |   4       |  Louie       |   0       |
        ----------------------------------------
         */

        private static Items potion = new Items(1);
        private static Items pokeball = new Items(2);
        private static Items berry = new Items(3);
        private static Items Louie = new Items(4);

        Items[] BagCurrent = new Items[4]
        {
            potion,
            pokeball,
            berry,
            Louie
        };

        public void ShowCurrBag()
        {
            Console.WriteLine("Current Bag Content:");
            Console.WriteLine("_______________________________");
            for (int i = 0; i < BagCurrent.Length; i++)
            {
                Items Item = BagCurrent[i];
                string itemName = BagCurrent[i].itemName;
                int ItemAmount = Item.GetItemAmount();
                Console.WriteLine("- " + itemName + ": " + ItemAmount);
            }
            Console.WriteLine("_______________________________");
        }

        // @desc: Method voor het updaten van de items.BagCap property. 
        // @author: Iliass Nassibane.
        // @date: 22-08-2016
        public void updateBag()
        {
            this.BagCap++;
        }


        // @desc: Method voor het toevoegen van items. 
        // @author: Iliass Nassibane.
        // @date: 22-08-2016
        public void AddItemToBag(int num)
        {
            switch (num)
            {
                case 1:
                    potion.itemAmount++;
                    Console.WriteLine(" a Potion!");
                    break;
                case 2:
                    pokeball.itemAmount++;
                    Console.WriteLine(" a PokeBall!");
                    break;
                case 3:
                    berry.itemAmount++;
                    Console.WriteLine(" a Berry!");
                    break;
                case 4:
                    Louie.itemAmount++;
                    Console.WriteLine(" a Louie!");
                    break;
            }
        }

        // @desc: Method voor het toevoegen van items. 
        // @author: Iliass Nassibane.
        // @date: 22-08-2016
        public void AddArrayofItemstoBag()
        {
            Random rand = new Random();
            int randNumCommon = rand.Next(1, 6);
            Random rand2 = new Random();
            int randNumRare = rand.Next(6, 11);
            Random rand3 = new Random();
            int whichRand = rand.Next(1, 6);
            Random rand4 = new Random();
            int randItem = rand4.Next(1, 5);
            int itterationsTotal = 0;
            
            if (whichRand == 3)
            {
                for (int i = 0; i < randNumRare; i++)
                {
                    int sequenceNum = i + 1;
                    Console.WriteLine("");
                    Console.WriteLine(sequenceNum + ". Obtained:");
                    AddItemToBag(randItem);
                    this.BagCap++;
                    itterationsTotal++;
                    randItem = rand4.Next(1, 5);
                }
                Console.WriteLine("---------------------------------------------------");
                Console.WriteLine("|           You have received " + itterationsTotal + " items!      | ");
                Console.WriteLine("---------------------------------------------------");
                Console.WriteLine("Press any key to continue >>");
                Console.ReadKey();
            }
            else
            {
                for (int i = 0; i < randNumCommon; i++)
                {
                    int sequenceNum = i + 1;
                    Console.WriteLine("");
                    Console.WriteLine(sequenceNum + ". Obtained:");
                    AddItemToBag(randItem);
                    this.BagCap++;
                    itterationsTotal++;
                    randItem = rand4.Next(1, 5);
                }
                Console.WriteLine("---------------------------------------------------");
                Console.WriteLine("|           You have received " + itterationsTotal + " items!      | ");
                Console.WriteLine("---------------------------------------------------");
                Console.WriteLine("Press any key to continue >>");
                Console.ReadKey();
            }
        }

        public void AddArrayofItemstoBagFixed()
        {
            Random rand = new Random();
            int randItem = rand.Next(1, 5);
            int cap = this.BagCap;
            int limit = this.BagLimit;
            int num = limit - cap;
            int itterationsTotal = 0;

            for (int i = 0; i < num; i++)
            {
                int sequenceNum = i + 1;
                Console.WriteLine("");
                Console.WriteLine(sequenceNum + ". Obtained:");
                AddItemToBag(i);
                this.BagCap++;
                itterationsTotal++;
                randItem = rand.Next(1, 5);
            }
            Console.WriteLine("---------------------------------------------------");
            Console.WriteLine("|           You have received " + itterationsTotal + " items!      | ");
            Console.WriteLine("---------------------------------------------------");
            Console.WriteLine("Press any key to continue >>");
            Console.ReadKey();
        }
    }
}
