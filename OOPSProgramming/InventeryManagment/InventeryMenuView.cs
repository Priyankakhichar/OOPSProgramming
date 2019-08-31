//-------------------------------------------------------------------------------------------------------------------------------
//<copyright file = "InventeryMenuView.cs" company ="Bridgelabz">
//Copyright © 2019 company ="Bridgelabz"
//</copyright>
//<creator name ="Priyanka khichar"/>
//
//-------------------------------------------------------------------------------------------------------------------------------
namespace OOPSProgramming.InventeryManagment
{
    using System;

    /// <summary>
    /// 
    /// </summary>
    class InventeryMenuView
    {
        /// <summary>
        /// Inventery the menu view.
        /// </summary>
        /// <param name="inventeryType">Type of the inventery.</param>
        public static void InventeryMenuViews(string inventeryType)
        {
            int option = 0;
            while (true)
            {
                Console.WriteLine("0.Go to back");
                Console.WriteLine("1.existing inventery objects " + inventeryType);
                Console.WriteLine("2.to remove an inventery type " + inventeryType + " item");
                Console.WriteLine("3.to Add " + inventeryType + " item");
                Console.WriteLine("4.to update " + inventeryType + " item");
                string stringOption = Console.ReadLine();
               if (Utility.IsNumber(stringOption) == false)
                {
                    Console.WriteLine("invalid input");
                    continue;
                }

                option = Convert.ToInt32(stringOption);
                switch (option)
                {
                    case 0:
                        {
                            return;
                        }

                    case 1:
                        {
                            InventeryManager.GetInventeryList(inventeryType);
                            break;
                        }

                    case 2:
                        {
                            InputForInventery.TakeInputForRemovingObject(inventeryType);
                            break;
                        }

                    case 3:
                        {
                            InputForInventery.TakeInputsForCreatingObjects(inventeryType);
                            break;
                        }

                    case 4:
                        {
                            InventeryMainupulationView.InventeryManupulationView(inventeryType);
                            break;
                        }
                }
            }
        }
    }
}
