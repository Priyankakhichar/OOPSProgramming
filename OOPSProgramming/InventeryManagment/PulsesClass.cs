//-------------------------------------------------------------------------------------------------------------------------------
//<copyright file = "PulsesClass.cs" company ="Bridgelabz">
//Copyright © 2019 company ="Bridgelabz"
//</copyright>
//<creator name ="Priyanka khichar"/>
//
//-------------------------------------------------------------------------------------------------------------------------------
namespace OOPSProgramming.InventeryManagment
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    /// <summary>
    /// pulses properties
    /// </summary>
    public class PulsesClass
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
        /// The price per kg
        /// </summary>
        private double pricePerKg;

        /// <summary>
        /// Initializes a new instance of the <see cref="PulsesClass"/> class.
        /// </summary>
        /// <param name="name">The name.</param>
        /// <param name="weight">The weight.</param>
        /// <param name="pricePerKg">The price per kg.</param>
        public PulsesClass(string name, double weight, double pricePerKg)
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
        /// Creates the pulses object.
        /// </summary>
        /// <param name="name">The name.</param>
        /// <param name="weight">The weight.</param>
        /// <param name="pricePerKg">The price per kg.</param>
        public static void CreatePulsesObject(string name, double weight, double pricePerKg)
        {
            PulsesClass pulses = new PulsesClass(name, weight, pricePerKg);
            InventeryTypes inventeryTypes = InventeryFactory.ReadJsonFile();
            inventeryTypes.PulsesList.Add(pulses);
            WriteToFile.WriteDataToFile(inventeryTypes);
            Console.WriteLine("added data to inventory successfully");
        }

        /// <summary>
        /// Removes the pulses object.
        /// </summary>
        /// <param name="itemName">Name of the item.</param>
        public static void RemovePulsesObject(string itemName)
        {
            InventeryTypes inventoryTypes = InventeryFactory.ReadJsonFile();
            List<PulsesClass> pulseList = inventoryTypes.PulsesList;
            foreach (PulsesClass pulse in pulseList)
            {
                if (pulse.Name.Equals(itemName))
                {
                    pulseList.Remove(pulse);
                    WriteToFile.WriteDataToFile(inventoryTypes);
                    Console.WriteLine("Item " + itemName + "removed Successfully");
                    Console.WriteLine("--------------------------------------------");
                    return;
                }
            }

            Console.WriteLine("Item " + itemName + "to be removed not found");
        }

        /// <summary>
        /// Does the object exist.
        /// </summary>
        /// <param name="itemName">Name of the item.</param>
        /// <returns>returning true if object is exist else returning false</returns>
        public static bool DoesObjectExist(string itemName)
        {
            InventeryTypes inventery = InventeryFactory.ReadJsonFile();
            List<PulsesClass> pulseList = inventery.PulsesList;
            foreach (PulsesClass pulse in pulseList)
            {
                if (pulse.name.Equals(itemName))
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
            return "name" + this.name + "weight" + this.weight + "pricePerKg" + this.pricePerKg;
        }
    }
}
