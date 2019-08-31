//-------------------------------------------------------------------------------------------------------------------------------
//<copyright file = "InventeryMainupulationView.cs" company ="Bridgelabz">
//Copyright © 2019 company ="Bridgelabz"
//</copyright>
//<creator name ="Priyanka khichar"/>
//
//-------------------------------------------------------------------------------------------------------------------------------
namespace OOPSProgramming.InventeryManagment
{
    using System;

    /// <summary>
    /// have methods for user view to mainupulate data
    /// </summary>
    public class InventeryMainupulationView
    {
        /// <summary>
        /// Inventeries the manupulation view.
        /// </summary>
        /// <param name="inventeryType">Type of the inventery.</param>
        public static void InventeryManupulationView(string inventeryType)
        {
            Console.WriteLine("please enter the item you want to edit");
            string name = Console.ReadLine();
            if (inventeryType.Equals("RICE"))
            {
                if (RiceClass.DoesObjectExist(name) == false)
                {
                    Console.WriteLine(name + " does not exist");
                    return;
                }
            }

            if (inventeryType.Equals("WHEAT"))
            {
                if (WheatClass.DoesObjectExist(name) == false)
                {
                    Console.WriteLine(name + " does not exist");
                    return;
                }
            }

            if (inventeryType.Equals("PULSES"))
            {
                if (PulsesClass.DoesObjectExist(name) == false)
                {
                    Console.WriteLine(name + " does not exist");
                    return;
                }
            }

            EditMenu(inventeryType, name);
        }

        /// <summary>
        /// Edits the menu.
        /// </summary>
        /// <param name="inventeryType">Type of the inventery.</param>
        /// <param name="itemName">Name of the item.</param>
        public static void EditMenu(string inventeryType, string itemName)
        {
            while (true)
            {
                Console.WriteLine("choose what do want to edit");
                Console.WriteLine("0. do not want to edit");
                Console.WriteLine("1. for name");
                Console.WriteLine("2. for weight");
                Console.WriteLine("3. for PricePerKg");
                string option = Console.ReadLine();
                switch (option)
                {
                    case "0":
                        {
                            return;
                        }

                    case "1":
                        {
                            InventeryManupulations.ChangeName(inventeryType, itemName);
                            break;
                        }

                    case "2":
                        {
                            InventeryManupulations.ChangeWeight(inventeryType, itemName);
                            break;
                        }

                    case "3":
                        {
                            InventeryManupulations.ChangePrice(inventeryType, itemName);
                            break;
                        }

                    default:
                        {
                            Console.WriteLine("invalid input");
                            break;
                        }
                }
            }
        }
    }
}
