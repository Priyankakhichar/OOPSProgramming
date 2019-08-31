//-------------------------------------------------------------------------------------------------------------------------------
//<copyright file = "UserView.cs" company ="Bridgelabz">
//Copyright © 2019 company ="Bridgelabz"
//</copyright>
//<creator name ="Priyanka khichar"/>
//
//-------------------------------------------------------------------------------------------------------------------------------
namespace OOPSProgramming.CommercialDataProcessing
{
    using System;

    /// <summary>
    /// first page for display purpose
    /// </summary>
    public class UserView
    {
        /// <summary>
        /// Shares the processing.
        /// </summary>
        public void ShareProcessing()
        {
            while (true)
            {
                StockAccount stockDetails = new StockAccount();
                Console.WriteLine("please enter the below acccording to your choice");
                Console.WriteLine("0. for exit from the window");
                Console.WriteLine("1. for Buy Share");
                Console.WriteLine("2. for Sell share");
                Console.WriteLine("3. for Display existing share");
                Console.WriteLine("4. Display the symbol of Purchased shares");
                string stringOption = Console.ReadLine();
                if (Utility.CheckString(stringOption))
                {
                    Console.WriteLine("input not valid");
                    continue;
                }

                if (Utility.ContainsCharacter(stringOption))
                {
                    Console.WriteLine("character not allwoed");
                    continue;
                }

                int option = Convert.ToInt32(stringOption);
                switch (option)
                {
                    case 0: Environment.Exit(0);
                            break;

                    case 1: InputData.TakeInputFromUser(option);
                            break;

                    case 2: InputData.TakeInputFromUser(option);
                            break;

                    case 3: stockDetails.PrintReport();
                            break;

                    case 4: stockDetails.PrintSymbols();
                            break;

                    default:
                            return;
                }
            }
        }
    }
}
