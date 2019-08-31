//-------------------------------------------------------------------------------------------------------------------------------
//<copyright file = "InputForInventery.cs" company ="Bridgelabz">
//Copyright © 2019 company ="Bridgelabz"
//</copyright>
//<creator name ="Priyanka khichar"/>
//
//-------------------------------------------------------------------------------------------------------------------------------
namespace OOPSProgramming.InventeryManagment
{
    using System;
    using System.Text.RegularExpressions;

    /// <summary>
    /// taking user input 
    /// </summary>
   public class InputForInventery
    {
        /// <summary>
        /// Takes the inputs for creating objects.
        /// </summary>
        /// <param name="inventeryTypes">The inventery types.</param>
        public static void TakeInputsForCreatingObjects(string inventeryTypes)
        {
            string name = null;
            double weight = 0.0;
            double pricePerKg = 0.0;
            while (true)
            {
                Console.WriteLine("please enter the name for " + inventeryTypes);
                name = Console.ReadLine();
                if (Utility.ContainsCharacter(name))
                {
                    Console.WriteLine("no character allowed");
                    continue;
                }

                if (!Utility.ContainsDigit(name))
                {
                    Console.WriteLine("digits not allowed ");
                    continue;
                }

                if (Utility.CheckString(name))
                {
                    Console.WriteLine("You should specify a name");
                }

                break;
            }

            while (true)
            {
                Console.WriteLine("plase enter the weight");
                string stringWeight = Console.ReadLine();
                try
                {
                    weight = Convert.ToDouble(stringWeight);
                    break;
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message + "invalid input for weight");
                }
            }

            while (true)
            {
                Console.WriteLine("plaese enter the price");
                string stringPrice = Console.ReadLine();
                try
                {
                    pricePerKg = Convert.ToDouble(stringPrice);
                    break;
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message + "input is not valid");
                }
            }

            if (inventeryTypes.Equals("RICE"))
            {
                RiceClass.CreateObjectOfRice(name, weight, pricePerKg);
            }

            if (inventeryTypes.Equals("WHEAT"))
            {
                WheatClass.CreateWheatObject(name, weight, pricePerKg);
            }

            if (inventeryTypes.Equals("PULSES"))
            {
                PulsesClass.CreatePulsesObject(name, weight, pricePerKg);
            }
        }

        /// <summary>
        /// Takes the input for removing object.
        /// </summary>
        /// <param name="inventeryTypes">The inventery types.</param>
        public static void TakeInputForRemovingObject(string inventeryTypes)
        {
          while (true)
            {
                Console.WriteLine("please enter the name, that you want to remove");
                string name = Console.ReadLine();
                if (!Regex.IsMatch(name, "^[a-zA-Z]+$"))
                {
                    Console.WriteLine("invalid input");
                    continue;
                }

                if (inventeryTypes.Equals("RICE"))
                {
                    RiceClass.RemoveRiceObject(name);
                }

                if (inventeryTypes.Equals("WHEAT"))
                {
                    WheatClass.RemoveWheatObject(name);
                }

                if (inventeryTypes.Equals("PULSES"))
                {
                    PulsesClass.RemovePulsesObject(name);
                }

                break;
            }           
        }
    }
}
