//-------------------------------------------------------------------------------------------------------------------------------
//<copyright file = "WheatClass.cs" company ="Bridgelabz">
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
    /// wheat properties
    /// </summary>
    public class WheatClass
    {
        /// <summary>
        /// The name
        /// </summary>
        private string name;

        /// <summary>
        /// The weight/
        /// </summary>
        private double weight;

        /// <summary>
        /// The price per kg
        /// </summary>
        private double pricePerKg;

        /// <summary>
        /// Initializes a new instance of the <see cref="WheatClass"/> class.
        /// </summary>
        /// <param name="name">The name.</param>
        /// <param name="weight">The weight.</param>
        /// <param name="pricePerKg">The price per kg.</param>
        public WheatClass(string name, double weight, double pricePerKg)
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
        /// 
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
        [JsonProperty("Weight")]
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
        /// Gets or sets the price per kg.
        /// </summary>
        /// <value>
        /// The price per kg.
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
        /// Creates the wheat object.
        /// </summary>
        /// <param name="name">The name.</param>
        /// <param name="weight">The weight.</param>
        /// <param name="price">The price.</param>
        public static void CreateWheatObject(string name, double weight, double price)
        {
            WheatClass wheat = new WheatClass(name, weight, price);
            InventeryTypes inventeryTypes = InventeryFactory.ReadJsonFile();
            inventeryTypes.WheatList.Add(wheat);
            WriteToFile.WriteDataToFile(inventeryTypes);
            Console.WriteLine("added data to the inventery successful");
        }

        /// <summary>
        /// Removes the wheat object.
        /// </summary>
        /// <param name="itemName">Name of the item.</param>
        public static void RemoveWheatObject(string itemName)
        {
            InventeryTypes inventeryTypes = InventeryFactory.ReadJsonFile();
            List<WheatClass> wheatList = inventeryTypes.WheatList;
            foreach (WheatClass wheat in wheatList)
            {
                if (wheat.Name.Equals(itemName))
                {
                    wheatList.Remove(wheat);
                    WriteToFile.WriteDataToFile(inventeryTypes);
                    Console.WriteLine("item " + itemName + "Removed successfuly");
                    Console.WriteLine("---------------------");
                    return;
                }
            }

            Console.WriteLine("item " + itemName + " to be removed is not found");
        }

        /// <summary>
        /// Does the object exist.
        /// </summary>
        /// <param name="name">The name.</param>
        /// <returns>returning true if object is exist</returns>
        public static bool DoesObjectExist(string name)
        {
            InventeryTypes inventeryTypes = InventeryFactory.ReadJsonFile();
            List<WheatClass> wheatList = inventeryTypes.WheatList;
            foreach (WheatClass wheat in wheatList)
            {
                if (wheat.Name.Equals(name))
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
            return "name" + this.name + " weight " + this.name + " pricePerKg " + this.pricePerKg;
        }
    }
}
