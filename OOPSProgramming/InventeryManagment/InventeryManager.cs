//-------------------------------------------------------------------------------------------------------------------------------
//<copyright file = "InventeryManager.cs" company ="Bridgelabz">
//Copyright © 2019 company ="Bridgelabz"
//</copyright>
//<creator name ="Priyanka khichar"/>
//
//-------------------------------------------------------------------------------------------------------------------------------
namespace OOPSProgramming.InventeryManagment
{
    using System;
    using System.Collections.Generic;

    public class InventeryManager
    {
        /// <summary>
        /// Gets the inventery list.
        /// </summary>
        /// <param name="inverteryType">Type of the invertery.</param>
        public static void GetInventeryList(string inverteryType)
        {
            InventeryTypes inventeryTypes = InventeryFactory.ReadJsonFile();
            if (inventeryTypes.Equals(inverteryType))
            {
                List<RiceClass> riceList = inventeryTypes.RiceList;
                foreach (RiceClass rice in riceList)
                {
                    Console.WriteLine("Rice type");
                    Console.WriteLine("name " + rice.Name + "\tweight " + rice.Weight + "\tPricePerKg " + rice.PricePerKg);
                    Console.WriteLine("total price of " + rice.Name + " is " + (rice.Weight * rice.PricePerKg));
                    Console.WriteLine("-----------------------------------------------------");
                }

                return;
            }

            if (inventeryTypes.Equals(inverteryType))
            {
                List<WheatClass> wheatList = inventeryTypes.WheatList;
                foreach (WheatClass wheat in wheatList)
                {
                    Console.WriteLine("Wheat type");
                    Console.WriteLine("name " + wheat.Name + "\tweight" + wheat.Weight + "\tPricePerKg" + wheat.PricePerKg);
                    Console.WriteLine("total price of " + wheat.Name + " is " + (wheat.Weight * wheat.PricePerKg));
                    Console.WriteLine("--------------------------------------------------");
                }

                return;
            }

            if (inverteryType.Equals(inverteryType))
            {
                List<PulsesClass> pulsesList = inventeryTypes.PulsesList;
                foreach (PulsesClass pulses in pulsesList)
                {
                    Console.WriteLine("Pulses type");
                    Console.WriteLine("name " + pulses.Name + "\tweight " + pulses.Weight + "\tPricePerKg" + pulses.PricePerKg);
                    Console.WriteLine("total price of " + pulses.Name + " is " + (pulses.PricePerKg * pulses.Weight));
                    Console.WriteLine("--------------------------------------------------------");
                }

                return;
            }
        }
    }
}
