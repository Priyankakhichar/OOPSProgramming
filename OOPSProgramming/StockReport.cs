//-------------------------------------------------------------------------------------------------------------------------------
//<copyright file = "StockReport.cs" company ="Bridgelabz">
//Copyright © 2019 company ="Bridgelabz"
//</copyright>
//<creator name ="Priyanka khichar"/>
//
//-------------------------------------------------------------------------------------------------------------------------------
namespace OOPSProgramming
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using Newtonsoft.Json;

    /// <summary>
    /// Stockes report
    /// </summary>
    public class StockReport
    {
        /// <summary>
        /// showing the report of Stocks.
        /// </summary>
        public static void StocksReports()
        {
            try
            {
                ////reading data from file
                using (StreamReader read = new StreamReader(@"C:\Users\Admin\source\repos\OOPSProgramming\OOPSProgramming\stocks.json"))
                {
                    ////reading json file from reader
                    var json = read.ReadToEnd();

                    ////converting json to .net type
                    var items = JsonConvert.DeserializeObject<List<Stocks>>(json);
                    Console.WriteLine("Name\t\tno Of share\t\tprice\t\tAmountOfSingleShare");

                    ////printing the items form json file
                    double totalValueOfAllShares = 0;
                    foreach (var item in items)
                    {
                        Console.WriteLine("{0}" + "\t\t" + "{1}" + "\t\t" + "{2}" + "\t\t" + "{3}", item.ShareName, item.NoOfShare, item.Price, PricePerShare(item.NoOfShare, item.Price));
                        totalValueOfAllShares += item.Price;
                    }
                    Console.WriteLine("total price of All stocks is: " + totalValueOfAllShares);
                }
            }
            catch (IOException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        /// <summary>
        /// Prices the per share.
        /// </summary>
        /// <param name="numberOfShares">The number of shares.</param>
        /// <param name="Price">The price.</param>
        /// <returns>price of Single share</returns>
        public static double PricePerShare(double numberOfShares, double price)
        {
            double valueOfShare = 0;
            try
            {
                valueOfShare = price / numberOfShares;
                return valueOfShare;
            }
            catch (ArithmeticException ex)
            {
                Console.WriteLine(ex.Message);
            }

            return valueOfShare;
        }
    }

    /// <summary>
    /// class that have getter and setter method
    /// </summary>
    public class Stocks
    {
        /// <summary>
        /// The share Name
        /// </summary>
        private string shareName;

        /// <summary>
        /// The no of shares
        /// </summary>
        private double noOfShare;

        /// <summary>
        /// The price
        /// </summary>
        private double price;

        /// <summary>
        /// Gets share name
        /// </summary>
        public string ShareName
        {
            get; set;
        }

        /// <summary>
        /// Gets shares no
        /// </summary>
        public double NoOfShare
        {
            get; set;
        }

        /// <summary>
        /// Gets share price
        /// </summary>
        public double Price
        {
            get; set;
        }
    }
}
