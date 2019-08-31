//-------------------------------------------------------------------------------------------------------------------------------
//<copyright file = "FileOperation.cs" company ="Bridgelabz">
//Copyright © 2019 company ="Bridgelabz"
//</copyright>
//<creator name ="Priyanka khichar"/>
//
//-------------------------------------------------------------------------------------------------------------------------------
namespace OOPSProgramming.CommercialDataProcessing
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using Newtonsoft.Json;

    /// <summary>
    /// Reading List of Share from file
    /// </summary>
    internal class FileOperation
    {
        /// <summary>
        /// Reads List of Share
        /// </summary>
        /// <returns>returns shareList</returns>
       public static List<ShareList> ReadFromFile()
        {
            CommercialLinkedList<ShareList> sharedLinkedList = new CommercialLinkedList<ShareList>();
            if (File.Exists(@"C:\Users\Admin\source\repos\OOPSProgramming\OOPSProgramming\CommercialDataProcessing\StockAccount.json"))
            {
                string jsonData = File.ReadAllText(@"C:\Users\Admin\source\repos\OOPSProgramming\OOPSProgramming\CommercialDataProcessing\StockAccount.json");

                ////Getting List<CompanyShares> object from JsonFile.
                List<ShareList> jsonObjectArray = JsonConvert.DeserializeObject<List<ShareList>>(jsonData);

                ////Adding All the CompanyShares Object to CustomLinkedLsit.
                foreach (ShareList sl in jsonObjectArray)
                {
                    sharedLinkedList.AddNodeAtLast(sl);
                }

                return jsonObjectArray;
            }
            else
            {
                Console.WriteLine("specified File path does not exists");
                    return new List<ShareList>();
            }
        }

        /// <summary>
        /// Writes to file.
        /// </summary>
        /// <param name="shareList">The share list.</param>
        public static void WriteToFile(List<ShareList> shareList)
        {
            //// Converting Object to JSon String.
            string jsonData = JsonConvert.SerializeObject(shareList);
            System.IO.File.WriteAllText(@"C:\Users\Admin\source\repos\OOPSProgramming\OOPSProgramming\CommercialDataProcessing\StockAccount.json", jsonData);
        }

        /// <summary>
        /// Reads the stock symbol.
        /// </summary>
        /// <returns>returning stackSymbol</returns>
        public static StackCommercial ReadStockSymbol()
        {
            StackCommercial symbolStack = new StackCommercial();
            symbolStack.StackCommercial1(1000);

            ////getting list of stock list
            List<ShareList> stockList = ReadFromFile();

            ////pusihing all symbol to the custom stack
            foreach (ShareList list in stockList)
            {
                symbolStack.PushIntoStack(list.Symbol);
            }

            return symbolStack;
        }

        /// <summary>
        /// Writes the symbol.
        /// </summary>
        /// <param name="symbolStack">The symbol stack.</param>
        public static void WriteSymbol(StackCommercial symbolStack)
        {
            List<string> symbolList = new List<string>();
            while (!symbolStack.IsEmpty())
            {
                symbolList.Add(symbolStack.PopFromStack());
            }

            string jsonData = JsonConvert.SerializeObject(symbolList);
            System.IO.File.WriteAllText(@"C:\Users\Admin\source\repos\OOPSProgramming\OOPSProgramming\CommercialDataProcessing\StockAccount.json", jsonData);
        }
    }
}
