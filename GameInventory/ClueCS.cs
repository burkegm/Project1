using System;
namespace GameInventory
{
    public class ClueCS : ItemCS
    {

        private string personIncriminated;
        private bool accuracy;

       
        /// <summary>
        /// contructor for the clue class
        /// </summary>
        /// <param name="name">name of clue</param>
        /// <param name="description">description clue</param>
        /// <param name="weight">weight of clue</param>
        /// <param name="value">value of clue</param>
        public ClueCS(string name, string description, double weight, double value) : base(name, description, weight, value)
        {
            
        }
        
            

   

    }
}

