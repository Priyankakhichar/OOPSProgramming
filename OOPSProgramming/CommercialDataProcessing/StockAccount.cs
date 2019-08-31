//-------------------------------------------------------------------------------------------------------------------------------
//<copyright file = "StockAccount.cs" company ="Bridgelabz">
//Copyright © 2019 company ="Bridgelabz"
//</copyright>
//<creator name ="Priyanka khichar"/>
//
//-------------------------------------------------------------------------------------------------------------------------------
namespace OOPSProgramming.CommercialDataProcessing
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// stockAccount has the method like buy and sell
    /// </summary>
    /// <seealso cref="OOPSProgramming.CommercialDataProcessing.IStockDetails" />
    public class StockAccount : IStockDetails
    {
        /// <summary>
        /// The commercial linked list
        /// </summary>
        private CommercialLinkedList<ShareList> commercialLinkedList = new CommercialLinkedList<ShareList>();

        /// <summary>
        /// Buys the share.
        /// </summary>
        /// <param name="numberOfShare">number of share</param>
        /// <param name="priceOfShare">The price of share.</param>
        /// <param name="symbol">The symbol</param>
        public void BuyShare(long numberOfShare, double priceOfShare, string symbol)
        {
            List<ShareList> shareList = FileOperation.ReadFromFile();
            foreach (ShareList list1 in shareList)
            {
                if (list1.Symbol.Equals(symbol))
                {
                    Console.WriteLine("you have already bought this share with " + symbol);
                    return;
                }
            }

            string dataTime = DateTime.Now.ToString();

            ////creating the object of share list
            ShareList list = new ShareList(numberOfShare, priceOfShare, symbol, dataTime);

            ////adding list to the file
            shareList.Add(list);

            ////writing the updated list to the file
            FileOperation.WriteToFile(shareList);

            Console.WriteLine("share added to your account");
        }

        /// <summary>
        /// Prints the report.
        /// </summary>
        public void PrintReport()
        {
            double totalValueOfStocks = 0;

            ////reading the share list from file
            List<ShareList> shareList = FileOperation.ReadFromFile();

            ////printing the report in details
            foreach (ShareList share in shareList)
            {
                Console.WriteLine(share.NumberOfShares + "\t" + share.PriceOfShares + "\t" + share.Symbol + "\t" + share.DateTime);
                Console.WriteLine("total value of share is " + (share.NumberOfShares * share.PriceOfShares));
                totalValueOfStocks = totalValueOfStocks + (share.NumberOfShares * share.PriceOfShares);
            }

            Console.WriteLine("Total value of all stocks is " + totalValueOfStocks);
        }

        /// <summary>
        /// Saves the share.
        /// </summary>
        /// <param name="fileName">Name of the file.</param>
        /// <exception cref="NotImplementedException">throwing exception if something unconditional happens</exception>
        public void SaveShare(string fileName)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Sells the of share.
        /// </summary>
        /// <param name="symbol">The symbol.</param>
        public void SellsOfShare(string symbol)
        {
            ////reading the shareList from file
            List<ShareList> shareList = FileOperation.ReadFromFile();
            foreach (ShareList list in shareList)
            {
                ////condition to check wether selling share symbol is available or not
                if (list.Symbol.Equals(symbol))
                {
                    ////removing the share from list
                    shareList.Remove(list);
                    Console.WriteLine("share is remved with " + symbol);

                    ////writing updated list to the file
                    FileOperation.WriteToFile(shareList);
                    return;
                }
            }

            Console.WriteLine("stock with " + symbol + " does not exist");
        }

        /// <summary>
        /// Values the of.
        /// </summary>
        /// <exception cref="NotImplementedException">throwing exception if something unconditional happens</exception>
        public void ValueOf()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Stackaccount the specified fileName.
        /// </summary>
        /// <param name="fileName">Name of the file.</param>
        /// <exception cref="NotImplementedException">throwing exception if something unconditional happens</exception>
        public void Stackaccount(string fileName)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Prints the symbols.
        /// </summary>
        public void PrintSymbols()
        {
            StackCommercial symbolStack = FileOperation.ReadStockSymbol();
            Console.WriteLine("your currently purchased symbols are ");
            while (!symbolStack.IsEmpty())
            {
                Console.WriteLine(symbolStack.PopFromStack() + " ");
            }
        }

        /// <summary>
        /// Values the of stocks.
        /// </summary>
        /// <returns> value of stocks</returns>
        /// <exception cref="NotImplementedException">throwing exception if something unconditional happens</exception>
        public double ValueOfStocks()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Stocks the detail.
        /// </summary>
        /// <param name="fileName">Name of the file.</param>
        /// <exception cref="NotImplementedException">throwing exception</exception>
        void IStockDetails.StocksDetail(string fileName)
        {
            throw new NotImplementedException();
        }
    }
}
