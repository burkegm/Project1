using System;
namespace GameInventory
{
    /// <summary>
    /// Class for the weapons 
    /// </summary>
    public class WeaponCS : ClueCS
    {
        private int damage;
        private DamageTypeCS damagetype;
        /// <summary>
        /// Constructor for the weapons class
        /// </summary>
        /// <param name="name">weapon name</param>
        /// <param name="description">weapon description</param>
        /// <param name="weight">weapon weight</param>
        /// <param name="value">weapon value</param>
        public WeaponCS(string name, string description, double weight, double value) : base(name, description, weight, value)
        {

        }

    }

}

