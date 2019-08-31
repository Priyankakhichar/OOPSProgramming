//-------------------------------------------------------------------------------------------------------------------------------
//<copyright file = "InventeryManupulations.cs" company ="Bridgelabz">
//Copyright © 2019 company ="Bridgelabz"
//</copyright>
//<creator name ="Priyanka khichar"/>
//
//-------------------------------------------------------------------------------------------------------------------------------
namespace OOPSProgramming.InventeryManagment
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// updating details of inventory
    /// </summary>
    public class InventeryManupulations
    {
        /// <summary>
        /// changing the name of paritcular object
        /// </summary>
        /// <param name="inventeryType"></param>
        /// <param name="itemName"></param>
        public static void ChangeName(string inventeryType, string itemName)
        {
            string newName;
            while (true)
            {
                Console.WriteLine("enter the new name for " + inventeryType);
                newName = Console.ReadLine();
                if (Utility.ContainsCharacter(newName))
                {
                    Console.WriteLine("character not allowed");
                    continue;
                }

                if (Utility.ContainsDigit(newName))
                {
                    Console.WriteLine("digits not allowed");
                    continue;
                }

                if (Utility.CheckString(newName))
                {
                    Console.WriteLine("you should specify name");
                    continue;
                }

                InventeryTypes inventeryTypes = InventeryFactory.ReadJsonFile();
                if (inventeryType.Equals("RICE"))
                {
                    List<RiceClass> riceList = inventeryTypes.RiceList;
                    foreach (RiceClass riceName in riceList)
                    {
                        if (riceName.Name.Equals(itemName))
                        {
                            riceName.Name = newName;
                            break;
                        }
                    }

                    WriteToFile.WriteDataToFile(inventeryTypes);
                    Console.WriteLine("data uploaded sussfully");
                }

                if (inventeryType.Equals("WHEAT"))
                {
                    List<WheatClass> wheatList = inventeryTypes.WheatList;
                    foreach (WheatClass wheatName in wheatList)
                    {
                        if (wheatName.Name.Equals(itemName))
                        {
                            wheatName.Name = newName;
                            break;
                        }
                    }

                    WriteToFile.WriteDataToFile(inventeryTypes);
                    Console.WriteLine("data uploaded successfuly");
                }

                if (inventeryType.Equals("PULSES"))
                {
                    List<PulsesClass> pulsesList = inventeryTypes.PulsesList;
                    foreach (PulsesClass pulsesName in pulsesList)
                    {
                        if (pulsesName.Name.Equals(itemName))
                        {
                            pulsesName.Name = newName;
                            break;
                        }
                    }

                    WriteToFile.WriteDataToFile(inventeryTypes);
                    Console.WriteLine("data uploaded successfully");
                }
            }
        }

        /// <summary>
        /// changing the weight of particular object
        /// </summary>
        /// <param name="inventeryType"></param>
        /// <param name="itemName"></param>
        public static void ChangeWeight(string inventeryType, string itemName)
        {
            double newWeight;
            InventeryTypes inventeryTypes = InventeryFactory.ReadJsonFile();
            while (true)
            {
                Console.WriteLine("Enter the Weight");
                string stringWeight = Console.ReadLine();

                try
                {
                    newWeight = Convert.ToDouble(stringWeight);
                    break;
                }
                catch (Exception)
                {
                    Console.WriteLine("Invalid Input For Weight");
                    continue;
                }
            }

            if (inventeryType.Equals("RICE"))
            {
                List<RiceClass> riceList = inventeryTypes.RiceList;
                foreach (RiceClass riceName in riceList)
                {
                    if (riceName.Name.Equals(itemName))
                    {
                        riceName.Weight = newWeight;
                        break;
                    }
                }

                WriteToFile.WriteDataToFile(inventeryTypes);
                Console.WriteLine("data uploaded successfully");
            }

            if (inventeryType.Equals("WHEAT"))
            {
                List<WheatClass> wheatList = inventeryTypes.WheatList;
                foreach (WheatClass wheat in wheatList)
                {
                    if (wheat.Name.Equals(itemName))
                    {
                        wheat.Weight = newWeight;
                        break;
                    }
                }

                WriteToFile.WriteDataToFile(inventeryTypes);
                Console.WriteLine("data uploaded successfully");
            }

            if (inventeryType.Equals("PULSES"))
            {
                List<PulsesClass> pulsesList = inventeryTypes.PulsesList;
                foreach (PulsesClass pulses in pulsesList)
                {
                    if (pulses.Name.Equals(itemName))
                    {
                        pulses.Weight = newWeight;
                        break;
                    }
                }

                WriteToFile.WriteDataToFile(inventeryTypes);
                Console.WriteLine("data uploaded successfully");
            }
        }

        /// <summary>
        /// changing the price of particular object
        /// </summary>
        /// <param name="inventeryTypes"></param>
        /// <param name="itemName"></param>
        public static void ChangePrice(string inventeryType, string itemName)
        {
            double newPricePerKG;
            InventeryTypes inventeryTypes = InventeryFactory.ReadJsonFile();

            while (true)
            {
                Console.WriteLine("Specify Price per Kg");
                string stringPrice = Console.ReadLine();
                try
                {
                    newPricePerKG = Convert.ToDouble(stringPrice);
                    break;
                }
                catch (Exception)
                {
                    Console.WriteLine("Invalid Input For Price Per KG");
                    continue;
                }
            }

            if (inventeryType.Equals("RICE"))
            {
                List<RiceClass> riceList = inventeryTypes.RiceList;

                foreach (RiceClass rice in riceList)
                {
                    if (rice.Name.Equals(itemName))
                    {
                        rice.PricePerKg = newPricePerKG;
                        break;
                    }
                }

                WriteToFile.WriteDataToFile(inventeryTypes);
                Console.WriteLine("Updated successfully");
            }

            if (inventeryType.Equals("WHEAT"))
            {
                List<WheatClass> wheatList = inventeryTypes.WheatList;

                foreach (WheatClass wheat in wheatList)
                {
                    if (wheat.Name.Equals(itemName))
                    {
                        wheat.PricePerKg = newPricePerKG;
                        break;
                    }
                }

                WriteToFile.WriteDataToFile(inventeryTypes);
                Console.WriteLine("Updated successfully");
            }

            if (inventeryType.Equals("PULSES"))
            {
                List<PulsesClass> pulseList = inventeryTypes.PulsesList;

                foreach (PulsesClass pulse in pulseList)
                {
                    if (pulse.Name.Equals(itemName))
                    {
                        pulse.PricePerKg = newPricePerKG;
                        break;
                    }
                }

                WriteToFile.WriteDataToFile(inventeryTypes);
                Console.WriteLine("Updated successfully");
            }
        }
    }
}
