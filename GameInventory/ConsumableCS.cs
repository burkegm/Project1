using System;
namespace GameInventory
{
    public class ConsumableCS : ItemCS
    {
        private int healtheffect;
        private int dosesRemaining;
        /// <summary>
        /// contructor of consumable class
        /// </summary>
        /// <param name="name">name of consumable</param>
        /// <param name="description">description of consumable</param>
        /// <param name="weight">weight of consumable</param>
        /// <param name="value">value of consumable</param>
        public ConsumableCS(string name, string description, double weight, double value) : base(name, description, weight, value)
        {

        }


    }
}

