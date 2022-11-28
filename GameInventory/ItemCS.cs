using System;
namespace GameInventory
{
    /// <summary>
    /// Stores the items the play has
    /// </summary>
    public class ItemCS
    {
        protected string name;
        protected string description;
        protected double weight;
        protected double value;
        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="name">item name</param>
        /// <param name="description">item description</param>
        /// <param name="weight">item weight</param>
        /// <param name="value">item value</param>
        public ItemCS(string name, string description, double weight, double value)
        {
            this.name = name;
            this.description = description;
            this.weight = weight;
            this.value = value;
        }
        /// <summary>
        /// displays items
        /// </summary>
        /// <returns>returns a organized list of items</returns>
        public String toString()
        {
            return $"Item Name: {name} \nDescription: {description} \nWeight: {weight} \nValue {value} gold pieces";
        }
    }

}

