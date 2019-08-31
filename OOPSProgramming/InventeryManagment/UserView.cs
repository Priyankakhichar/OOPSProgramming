//-------------------------------------------------------------------------------------------------------------------------------
//<copyright file = "UserView.cs" company ="Bridgelabz">
//Copyright © 2019 company ="Bridgelabz"
//</copyright>
//<creator name ="Priyanka khichar"/>
//
//-------------------------------------------------------------------------------------------------------------------------------
namespace OOPSProgramming.InventeryManagment
{
    using System;

    /// <summary>
    /// displaying the details according to user requirement
    /// </summary>
   public class UserView
    {
        /// <summary>
        /// Inventery the management method.
        /// </summary>
        public void InventeryManagementMethod()
        {
            while (true)
            {
                Console.WriteLine("Select an inventery from below");
                Console.WriteLine("0.for exit");
                Console.WriteLine("1.For rice");
                Console.WriteLine("2.for Wheat");
                Console.WriteLine("3.for Pulses");
                string stringOption = Console.ReadLine();
                if (Utility.IsNumber(stringOption) == false)
                {
                    Console.WriteLine("note a valid input");
                    continue;
                }

                int ch = Convert.ToInt32(stringOption);
                switch (ch)
                {
                    case 0:
                        {
                            return;
                        }

                    case 1:
                        {
                            InventeryMenuView.InventeryMenuViews("RICE");
                            break;
                        }

                    case 2:
                        {
                            InventeryMenuView.InventeryMenuViews("WHEAT");
                            break;
                        }

                    case 3:
                        {
                            InventeryMenuView.InventeryMenuViews("PULSES");
                            break;
                        }
                }
            }
        }
    }
}
