//-------------------------------------------------------------------------------------------------------------------------------
//<copyright file = "ShareList.cs" company ="Bridgelabz">
//Copyright © 2019 company ="Bridgelabz"
//</copyright>
//<creator name ="Priyanka khichar"/>
//
//-------------------------------------------------------------------------------------------------------------------------------
namespace OOPSProgramming.CommercialDataProcessing
{
    /// <summary>
    /// share attributes
    /// </summary>
    public class ShareList
    {
        /// <summary>
        /// The number of shares
        /// </summary>
        private long numberOfShares;

        /// <summary>
        /// The price of share
        /// </summary>
        private double priceOfShare;

        /// <summary>
        /// The symbol
        /// </summary>
        private string symbol;

        /// <summary>
        /// The date time
        /// </summary>
        private string dateTime;

        /// <summary>
        /// Initializes a new instance of the <see cref="ShareList"/> class.
        /// </summary>
        /// <param name="numberOfShares">The number of shares.</param>
        /// <param name="priceOfShare">The price of share.</param>
        /// <param name="symbol">The symbol.</param>
        /// <param name="dateTime">The date time.</param>
        public ShareList(long numberOfShares, double priceOfShare, string symbol, string dateTime)
        {
            this.numberOfShares = numberOfShares;
            this.priceOfShare = priceOfShare;
            this.symbol = symbol;
            this.dateTime = dateTime;
        }

        /// <summary>
        /// Gets or sets the number of shares.
        /// </summary>
        /// <value>
        /// The number of shares.
        /// </value>
        public long NumberOfShares
        {
            get
            {
                return this.numberOfShares;
            }

            set
            {
                this.numberOfShares = value;
            }
        }

        /// <summary>
        /// Gets or sets the price of shares.
        /// </summary>
        /// <value>
        /// The price of shares.
        /// </value>
        public double PriceOfShares
        {
            get
            {
                return this.priceOfShare;
            }

            set
            {
                this.priceOfShare = value;
            }
        }

        /// <summary>
        /// Gets or sets the symbol.
        /// </summary>
        /// <value>
        /// The symbol.
        /// </value>
        public string Symbol
        {
            get
            {
                return this.symbol;
            }

            set
            {
                this.symbol = value;
            }
        }

        /// <summary>
        /// Gets or sets the date time.
        /// </summary>
        /// <value>
        /// The date time.
        /// </value>
        public string DateTime
        {
            get
            {
                return this.dateTime;
            }

            set
            {
                this.dateTime = value;
            }
        }
    }
}
