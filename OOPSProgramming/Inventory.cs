//-------------------------------------------------------------------------------------------------------------------------------
//<copyright file = "Inventory.cs" company ="Bridgelabz">
//Copyright © 2019 company ="Bridgelabz"
//</copyright>
//<creator name ="Priyanka khichar"/>
//
//-------------------------------------------------------------------------------------------------------------------------------
namespace OOPSProgramming
{
    /// <summary>
    /// class that have getter and setter method
    /// </summary>
    class Inventory
    {
        /// <summary>
       /// private varaiable of name.
      /// </summary>
        private string name;

        /// <summary>
        /// private varaiable of weight.
        /// </summary>
        private double weight;

        /// <summary>
        /// private varaiable of price.
        /// </summary>
        private double price;

        /// <summary>
        /// getting of Name 
        /// </summary>
        public string Name
        {
            get; set;
        }

        /// <summary>
        /// getting of Weight 
        /// </summary>
        public double Weight
        {
            get; set;
        }

        /// <summary>
        /// getting of Price 
        /// </summary>
        public double Price
        {
            get; set;
        }
    }
}
