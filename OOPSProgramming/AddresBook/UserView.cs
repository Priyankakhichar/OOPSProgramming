//-------------------------------------------------------------------------------------------------------------------------------
//<copyright file = "UserView.cs" company ="Bridgelabz">
//Copyright © 2019 company ="Bridgelabz"
//</copyright>
//<creator name ="Priyanka khichar"/>
//
//-------------------------------------------------------------------------------------------------------------------------------
namespace OOPSProgramming.AddresBook
{
    using System;

    /// <summary>
    /// contains the a single method to call another class methods and first page display 
    /// </summary>
    public class UserView
    {
        /// <summary>
        /// Displays the first page.
        /// </summary>
        public void DisplayFirstPage()
        {
            do
            {
                Console.WriteLine("please select any one option");
                Console.WriteLine("1. For Adding new Person Address to the book");
                Console.WriteLine("2. For Update any record ");
                Console.WriteLine("3. For Delete any record from the book");
                Console.WriteLine("4. Exit from the window");
                AddressBookInternalProcess process = new AddressBookInternalProcess();
                int option = Convert.ToInt32(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        process.AddDetails();
                        break;

                    case 2:
                        process.UpdateDetails();
                        break;

                    case 3:
                        process.DeleteRecord();
                        break;

                    case 4:
                        Environment.Exit(0);
                        break;  
                }

                Console.WriteLine("do you want to do more operations, please enter y/n...");
            }
            while (Console.ReadLine().Equals("y"));
        }
    }
}
