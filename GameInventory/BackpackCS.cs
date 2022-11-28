using System;
namespace GameInventory
{
    
    public class BackpackCS
    {
        private List<ItemCS> contents;
        /// <summary>
        /// creates the list for the items
        /// </summary>
        public BackpackCS()
        {
            contents = new List<ItemCS>();
        }
        /// <summary>
        /// allows items to be addded to player inventory 
        /// </summary>
        /// <param name="item">items in the game</param>
        public void add(ItemCS item)
        {
            contents.Add(item);
        }
        /// <summary>
        /// lists out the weapons that the player has
        /// </summary>
        /// <returns>returns a list of weapons</returns>
        public string listWeapons()
        {
            string weapons = "";
            weapons += "\nWeapons--------------------------------------------------\n";
            foreach(ItemCS i in contents)
            {
                if (i is WeaponCS)
                {
                    weapons += i.toString();
                    weapons += "\n---------------------------------------------------------\n";
                }
            }

            return weapons;
        }
        /// <summary>
        /// lists out the clues the player has
        /// </summary>
        /// <returns>returns a list of clues</returns>
        public string listClues()
        {
            string clues = "";
            clues += "\nClues----------------------------------------------------\n";
            foreach(ItemCS i in contents)
            {
                if(i is ClueCS)
                {
                    clues += i.toString();
                    clues += "\n---------------------------------------------------------\n";
                }
               
            }
            return clues;
        }
        /// <summary>
        /// lists out the consumables the player has
        /// </summary>
        /// <returns>returns a list of consumables</returns>
        public string listConsumables()
        {
            string consumables = "";
            consumables += "\nConsumables----------------------------------------------\n";
            foreach(ItemCS i in contents)  
            {
                if (i is ConsumableCS)
                {
                    consumables += i.toString();
                    consumables += "\n---------------------------------------------------------\n";
                }
            }

            return consumables;

        }

    }
}

