using System;
namespace GameInventory
{

    public class DriverCS
    {
        /// <summary>
        /// main method that
        /// </summary>
        /// <param name="args"></param>
        static void main(String[] args)
        {

            BackpackCS mybackpack = new BackpackCS();

            mybackpack.add(new ClueCS("Letter", "A threatening letter from Fred", .1, 0));
            mybackpack.add(new WeaponCS("Sword", "A bright shiny sword", 10.0, 25.0));
            mybackpack.add(new ConsumableCS("Aspirin", "A little something for your aching head", .5, 1.0));
            mybackpack.add(new ConsumableCS("Chocolate cake", "Delicious cake", 2.0, 7.5));
            mybackpack.add(new WeaponCS("Battle Axe", "A wicked looking battle axe", 15.0, 35.0));
            mybackpack.add(new ClueCS("Shirt", "A bloody shirt", 2.0, 0));
            mybackpack.add(new WeaponCS("Pole Arm", "A heavy stick for hitting things", 8.0, 10.0));
            mybackpack.add(new ConsumableCS("Bandages", "A box of assorted bandages", .6, 1.0));



        }

    }




}

