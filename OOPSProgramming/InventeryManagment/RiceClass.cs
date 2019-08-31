//-------------------------------------------------------------------------------------------------------------------------------
//<copyright file = "RiceClass.cs" company ="Bridgelabz">
//Copyright © 2019 company ="Bridgelabz"
//</copyright>
//<creator name ="Priyanka khichar"/>
//
//-------------------------------------------------------------------------------------------------------------------------------
namespace OOPSProgramming.InventeryManagment
{
    using System;
    using System.Collections.Generic;
    using Newtonsoft.Json;

    /// <summary>
    /// rice properties
    /// </summary>
    public class RiceClass
    {
        /// <summary>
        /// The name
        /// </summary>
        private string name;

        /// <summary>
        /// The weight
        /// </summary>
        private double weight;

        /// <summary>
        /// The price
        /// </summary>
        private double pricePerKg;

        /// <summary>
        /// Initializes a new instance of the <see cref="RiceClass"/> class.
        /// </summary>
        /// <param name="name">The name.</param>
        /// <param name="weight">The weight.</param>
        /// <param name="pricePerKg">The price.</param>
        public RiceClass(string name, double weight, double pricePerKg)
        {
            this.name = name;
            this.weight = weight;
            this.pricePerKg = pricePerKg;
        }

        /// <summary>
        /// Gets or sets the name.
        /// </summary>
        /// <value>
        /// The name.
        /// </value>   
        [JsonProperty("name")]
        public string Name
        {
            get
            {
                return this.name;
            }

            set
            {
                this.name = value;
            }
        }

        /// <summary>
        /// Gets or sets the weight.
        /// </summary>
        /// <value>
        /// The weight.
        /// </value>
         [JsonProperty("weight")]
        public double Weight
        {
            get
            {
                return this.weight;
            }

            set
            {
                this.weight = value;
            }
        }

        /// <summary>
        /// Gets or sets the price.
        /// </summary>
        /// <value>
        /// The price.
        /// </value>
         [JsonProperty("PricePerKg")]
        public double PricePerKg
        {
            get
            {
                return this.pricePerKg;
            }

            set
            {
                this.pricePerKg = value;
            }
        }

        /// <summary>
        /// Creates the object of rice.
        /// </summary>
        /// <param name="name">The name.</param>
        /// <param name="weight">The weight.</param>
        /// <param name="price">The price.</param>
        public static void CreateObjectOfRice(string name, double weight, double price)
        {
            RiceClass rice = new RiceClass(name, weight, price);
            InventeryTypes inventeryTypes = InventeryFactory.ReadJsonFile();
            inventeryTypes.RiceList.Add(rice);
            WriteToFile.WriteDataToFile(inventeryTypes);
            Console.WriteLine("data successfully added");
        }

        /// <summary>
        /// Removes the specified item name.
        /// </summary>
        /// <param name="itemName">Name of the item.</param>
        public static void RemoveRiceObject(string itemName)
        {
            InventeryTypes inventeryType = InventeryFactory.ReadJsonFile();
            List<RiceClass> riceList = inventeryType.RiceList;
            foreach (RiceClass riceName in riceList)
            {
                if (riceName.Name.Equals(itemName))
                {
                    riceList.Remove(riceName);
                    WriteToFile.WriteDataToFile(inventeryType);
                    Console.WriteLine("item " + itemName + " has been removed from your list");
                    return;
                }
            }

            Console.WriteLine("item " + itemName + " not found in list");
        }

        /// <summary>
        /// Does the object exist.
        /// </summary>
        /// <param name="name">The name.</param>
        /// <returns>returning true if object is existed</returns>
        public static bool DoesObjectExist(string name)
        {
            InventeryTypes inventeryTypes = InventeryFactory.ReadJsonFile();
            List<RiceClass> riceList = inventeryTypes.RiceList;
            foreach (RiceClass riceName in riceList)
            {
                if (riceName.Name.Equals(name))
                {
                    return true;
                }
            }

            return false;
        }

        /// <summary>
        /// Converts to string.
        /// </summary>
        /// <returns>
        /// A <see cref="System.String" /> that represents this instance.
        /// </returns>
        public override string ToString()
        {
            return "name " + this.name + " weight " + this.weight + " pricePerKg" + this.pricePerKg;
        }
    }
}
