//-------------------------------------------------------------------------------------------------------------------------------
//<copyright file = "Program.cs" company ="Bridgelabz">
//Copyright © 2019 company ="Bridgelabz"
//</copyright>
//<creator name ="Priyanka khichar"/>
//
//-------------------------------------------------------------------------------------------------------------------------------
namespace OOPSProgramming
{
    using System;

    /// <summary>
    /// having the 
    /// </summary>
   public class Program
    {
        /// <summary>
        /// Defines the entry point of the application.
        /// </summary>
        /// <param name="args">The arguments.</param>
        public static void Main(string[] args)
        {
            Console.WriteLine("1.Inventory");
            Console.WriteLine("2.RegularExpression");
            Console.WriteLine("3.StocksReport");
            Console.WriteLine("4.for inventery Management");
            Console.WriteLine("5.Commercial data processing");
            Console.WriteLine("6.DeckOfCards Using 2D Array");
            Console.WriteLine("7.DeckOfCards");
            Console.WriteLine("8.AddressBook");
            int choice;
            Console.WriteLine("please enter the choice");
            choice = Utility.ReadInt();
            do
            {
                switch (choice)
                {
                    case 1:
                        Utility.LoadJson();
                        break;

                    case 2:
                        RegularExpression.Replace();
                        break;

                    case 3:
                        StockReport.StocksReports();
                        break;

                    case 4:
                        InventeryManagment.UserView management = new InventeryManagment.UserView();
                        management.InventeryManagementMethod();
                        break;

                    case 5:
                        CommercialDataProcessing.UserView data = new CommercialDataProcessing.UserView();
                        data.ShareProcessing();
                        break;

                    case 6:
                        DeckOfCard card = new DeckOfCard();
                        card.DeckOfCards();
                        card.DistributeCards();
                        break;

                    case 7:
                        DeckOfCards.DeckOfCardUsingQueue cards = new DeckOfCards.DeckOfCardUsingQueue();
                        cards.InitializeDeckOfCardsUsingQueue();
                        break;

                    case 8: AddresBook.AddressBook book = new AddresBook.AddressBook();
                           book.ReadFromFile();
                           AddresBook.UserView view = new AddresBook.UserView();
                           view.DisplayFirstPage();
                           break;
                }

                Console.WriteLine("you want to run again ,please enter y/n ?");
            }
            while ("y".Equals(Console.ReadLine()) == true);
        }  
    }
}
