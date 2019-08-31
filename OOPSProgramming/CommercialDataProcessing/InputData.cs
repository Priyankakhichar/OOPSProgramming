//-------------------------------------------------------------------------------------------------------------------------------
//<copyright file = "InputData.cs" company ="Bridgelabz">
//Copyright © 2019 company ="Bridgelabz"
//</copyright>
//<creator name ="Priyanka khichar"/>
//
//-------------------------------------------------------------------------------------------------------------------------------
namespace OOPSProgramming.CommercialDataProcessing
{
    using System;

    /// <summary>
    /// manageing data that have to take from user
    /// </summary>
    public class InputData
    {
        /// <summary>
        /// Takes the input from user.
        /// </summary>
        /// <param name="choosedOption">The choosed option.</param>
        public static void TakeInputFromUser(int choosedOption)
        {
            StockAccount stockDetails = new StockAccount();
            int numberOfshare = 0;
            int costOfShare = 0;
            string symbol = string.Empty;
            string dateTime = string.Empty;
            if (choosedOption == 1)
            {
                while (true)
                {
                    Console.WriteLine("please enter the number of shares");
                    string numberOfShares = Console.ReadLine();
                    if (Utility.IsNumber(numberOfShares) == false)
                    {
                        Console.WriteLine("invalid input");
                        continue;
                    }

                    numberOfshare = Convert.ToInt32(numberOfShares);
                    break;
                }

                while (true)
                {
                    Console.WriteLine("please enter the of CostOfShare");
                    string costOfShare1 = Console.ReadLine();
                    if (Utility.IsNumber(costOfShare1) == false)
                    {
                        Console.WriteLine("invalid input");
                        continue;
                    }

                    costOfShare = Convert.ToInt32(costOfShare);
                    break;
                }

                while (true)
                {
                    Console.WriteLine("please enter the symbol");
                    string stringSymbol = Console.ReadLine();
                    if (Utility.CheckString(stringSymbol))
                    {
                        Console.WriteLine("empty string not allwoed");
                        continue;
                    }

                    symbol = stringSymbol;
                    break;
                }

                stockDetails.BuyShare(numberOfshare, costOfShare, symbol);
            }

            if (choosedOption == 2)
            {
                while (true)
                {
                    Console.WriteLine("please enter the symbol for share");
                    string stringSymbol = Console.ReadLine();
                    if (Utility.IsNumber(stringSymbol) == true)
                    {
                        Console.WriteLine("number not allowed");
                        continue;
                    }

                    if (Utility.CheckString(stringSymbol))
                    {
                        Console.WriteLine("empty string not allowed");
                    }

                    symbol = stringSymbol;
                    stockDetails.SellsOfShare(symbol);
                    break;
                }
            }
        }
    }
}
