using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonGo___Bag_validator
{
    enum item
    {
        potion,
        pokeball,
        berry,
        Louie
    }

    // @desc: Item Base class voor alle items in de program.
    // @author: Iliass Nassibane.
    // @date: 22-08-2016
    class Items
    {
        public int itemCode = 0;
        public string itemName = "";
        public item Itemtype;
        public int itemAmount = 0;

        // @desc: Operator voor de Item class, die ervoor zorgt dat de item object 
        // een specifieke item wordt voor de bag item.
        // @author: Iliass Nassibane.
        // @date: 18-08-2016
        public Items(int num)
        {
            switch(num)
            {
                case 1:
                    this.itemCode = 1;
                    this.itemName = "potion";
                    this.Itemtype = item.potion;
                    break;
                case 2:
                    this.itemCode = 2;
                    this.itemName = "pokeball";
                    this.Itemtype = item.pokeball;
                    break;
                case 3:
                    this.itemCode = 3;
                    this.itemName = "berry";
                    this.Itemtype = item.berry;
                    break;
                case 4:
                    this.itemCode = 4;
                    this.itemName = "Louie";
                    this.Itemtype = item.Louie;
                    break;
            }
        }

        // @desc: Get-Method om de huidige aantal van een specifieke item te kunnen verkrijgen.
        // @author: Iliass Nassibane.
        // @date: 22-08-2016.
        public int GetItemAmount()
        {
            return this.itemAmount;
        }
    }
}
