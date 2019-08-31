//-------------------------------------------------------------------------------------------------------------------------------
//<copyright file = "IStockDetails.cs" company ="Bridgelabz">
//Copyright © 2019 company ="Bridgelabz"
//</copyright>
//<creator name ="Priyanka khichar"/>
//
//-------------------------------------------------------------------------------------------------------------------------------
namespace OOPSProgramming.CommercialDataProcessing
{
    /// <summary>
    /// interface for stockDetails
    /// </summary>
    public interface IStockDetails
    {
        /// <summary>
        /// Buys the share.
        /// </summary>
        /// <param name="priceOfShare">The price of share.</param>
        /// <param name="numberOfShare">The no of share.</param>
        /// <param name="symbol">The symbol.</param>
        void BuyShare(long numberOfShare, double priceOfShare, string symbol);

        /// <summary>
        /// Sells the of share.
        /// </summary>
        /// <param name="symbol">The symbol.</param>
        void SellsOfShare(string symbol);

        /// <summary>
        /// Saves the share.
        /// </summary>
        /// <param name="fileName">Name of the file.</param>
        void SaveShare(string fileName);

        /// <summary>
        /// Prints the report.
        /// </summary>
        void PrintReport();

        /// <summary>
        /// Values the of stocks.
        /// </summary>
        /// <returns>value of stocks</returns>
        double ValueOfStocks();

        /// <summary>
        /// Stocks the detail.
        /// </summary>
        /// <param name="fileName">Name of the file.</param>
        void StocksDetail(string fileName);

        /// <summary>
        /// Prints the symbols.
        /// </summary>
        void PrintSymbols();
    }
}
