//-------------------------------------------------------------------------------------------------------------------------------
//<copyright file = "AddressBookInternalProcess.cs" company ="Bridgelabz">
//Copyright © 2019 company ="Bridgelabz"
//</copyright>
//<creator name ="Priyanka khichar"/>
//
//-------------------------------------------------------------------------------------------------------------------------------
namespace OOPSProgramming.AddresBook
{
    using System;
    using System.Collections.Generic;
    using System.Text.RegularExpressions;

    /// <summary>
    /// Address book details operation like add , remove, update
    /// </summary>
    public class AddressBookInternalProcess
    {
        /// <summary>
        /// The first name
        /// </summary>
        private string firstName;

        /// <summary>
        /// The last name
        /// </summary>
        private string lastName;

        /// <summary>
        /// The mobile number
        /// </summary>
        private string mobileNumber;

        /// <summary>
        /// The address
        /// </summary>
        private string address;

        /// <summary>
        /// The city
        /// </summary>
        private string city;

        /// <summary>
        /// The state
        /// </summary>
        private string state;

        /// <summary>
        /// The zip code
        /// </summary>
        private string zipCode;

        /// <summary>
        /// Adds the details.
        /// </summary>
        /// <exception cref="Exception">raise a exception if condition getting false</exception>
        public void AddDetails()
        {
            try
            {
                Console.WriteLine("please enter the first Name");
                this.firstName = Console.ReadLine();
                Console.WriteLine("please enter the last Name");
                this.lastName = Console.ReadLine();
                Console.WriteLine("please enter the Mobile number");
                string number = Console.ReadLine();
                this.mobileNumber = string.Empty;
                while (true)
                {
                    if (Regex.IsMatch(number, "^[0-9]+$"))
                    {
                        this.mobileNumber = number;
                        break;
                    }
                    else
                    {
                        Console.WriteLine("mobile number is invalid");
                    }
                }

                Console.WriteLine("please enter the Address");
                this.address = Console.ReadLine();
                Console.WriteLine("please enter the city");
                this.city = Console.ReadLine();
                Console.WriteLine("please enter the state");
                this.state = Console.ReadLine();
                Console.WriteLine("please enter the ZipCode");
                string code = Console.ReadLine();
                this.zipCode = string.Empty;
                while (true)
                {
                    if (Regex.IsMatch(code, "^[0-9]+$"))
                    {
                        this.zipCode = code;
                        break;
                    }
                    else
                    {
                        Console.WriteLine("invalid zipCode");
                    }
                }

                ////storing all the details in Address book object through Address constructor.
                AddressBook book = new AddressBook(this.firstName, this.lastName, this.mobileNumber, this.address, this.city, this.state, this.zipCode);

                 ////reading Address book data from the json file
                List<AddressBook> list = FileOperation.ReadJsonFile();

                ////adding the AddressBook object to the list
                list.Add(book);

                ////writing the list to the json file.
                FileOperation.WriteToFile(list);
                Console.WriteLine("data added successfully");
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        /// <summary>
        /// Updates the details.
        /// </summary>
        public void UpdateDetails()
        {
            try
            {
                Console.WriteLine("please enter which field you want to update");
                Console.WriteLine("1.for firstName");
                Console.WriteLine("2.for last Name");
                Console.WriteLine("3. for mobile no");
                Console.WriteLine("4. for address");
                Console.WriteLine("5. for city");
                Console.WriteLine("6. for state");
                Console.WriteLine("7. fro zipCode");
                int option = Convert.ToInt32(Console.ReadLine());
                switch (option)
                {
                    case 1: this.UpdateFirstName();
                        break;

                    case 2: this.UpdateLastName();
                        break;

                   case 3:
                        this.UpdateMobileNo();
                        break;

                    case 4: this.UpdateAddress();
                        break;

                    case 5: this.UpdateCity();
                        break;

                    case 6: this.UpdateState();
                        break;

                    case 7: this.UpdateZipCode();
                        break;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        /// <summary>
        /// Updates the first name.
        /// </summary>
        public void UpdateFirstName()
        {
            Console.WriteLine("please enter the name you want to update");
            string oldName = Console.ReadLine();
            Console.WriteLine("please enter the name you want to add");
            string newName = Console.ReadLine();
            List<AddressBook> addressList = FileOperation.ReadJsonFile();
            foreach (AddressBook list in addressList)
            {
                if (list.FirstName.Equals(oldName))
                {
                    list.FirstName = newName;
                }
            }

            FileOperation.WriteToFile(addressList);
            Console.WriteLine("your name is updated");
            Console.WriteLine("if you want to see you updated name .please enter 1 else enter other number");
            int userInput = Convert.ToInt32(Console.ReadLine());
            if (userInput == 1)
            {
                AddressBook book = new AddressBook();
                book.ReadFromFile();
            }
        }

        /// <summary>
        /// Updates the last name.
        /// </summary>
        public void UpdateLastName()
        {
            Console.WriteLine("please enter the old Name you want to replace");
            string oldName = Console.ReadLine();
            Console.WriteLine("please enter the new LastName");
            string newName = Console.ReadLine();
            List<AddressBook> addressList = FileOperation.ReadJsonFile();
            foreach (AddressBook list in addressList)
            {
                if (list.FirstName.Equals(oldName))
                {
                    list.LastName = newName;
                }
            }

            FileOperation.WriteToFile(addressList);
            Console.WriteLine("your name is updated");
            Console.WriteLine("if you want to see you updated name .please enter 1 else enter other number");
            int userInput = Convert.ToInt32(Console.ReadLine());
            if (userInput == 1)
            {
                AddressBook book = new AddressBook();
                book.ReadFromFile();
            }
        }

        /// <summary>
        /// Updates the mobile no.
        /// </summary>
        public void UpdateMobileNo()
        {
            Console.WriteLine("please enter the firstName for you want to update");
            string firstName = Console.ReadLine();
            Console.WriteLine("please enter the new MobileNo that you want to update");
            string newMobileNo = Console.ReadLine();
            List<AddressBook> addressList = FileOperation.ReadJsonFile();
            if (Regex.IsMatch(newMobileNo, "^[0-9]{10}"))
            {
                foreach (AddressBook list in addressList)
                {
                    if (list.FirstName.Equals(firstName))
                    {
                        list.MobileNo = newMobileNo;
                    }
                }
            }
            else
            {
                Console.WriteLine("invalid input");
                return;
            }
 
            FileOperation.WriteToFile(addressList);
            Console.WriteLine("your mobileNo is updated");
            Console.WriteLine("if you want to see you updated mobileNo .please enter 1 else enter other number");
            int userInput = Convert.ToInt32(Console.ReadLine());
            if (userInput == 1)
            {
                AddressBook book = new AddressBook();
                book.ReadFromFile();
            }
        }

        /// <summary>
        /// Update the address.
        /// </summary>
        public void UpdateAddress()
        {
            Console.WriteLine("plaese enter the firstName for you want to update address");
            string firstName = Console.ReadLine();
            Console.WriteLine("please enter the new address");
            string newAddress = Console.ReadLine();
            List<AddressBook> addressList = FileOperation.ReadJsonFile();
            foreach (AddressBook list in addressList)
            {
                if (list.FirstName.Equals(firstName))
                {
                    list.Address = newAddress;
                }
            }

            FileOperation.WriteToFile(addressList);
            Console.WriteLine("your address is updated");
            Console.WriteLine("if you want to see you updated address .please enter 1 else enter other number");
            int userInput = Convert.ToInt32(Console.ReadLine());
            if (userInput == 1)
            {
                AddressBook book = new AddressBook();
                book.ReadFromFile();
            }
        }

        /// <summary>
        /// Updates the city.
        /// </summary>
        public void UpdateCity()
        {
            Console.WriteLine("plaese enter the Firstname for you want to update city");
            string firstName = Console.ReadLine();
            Console.WriteLine("please enter the city you want to add ");
            string newCity = Console.ReadLine();
            List<AddressBook> addressBooks = FileOperation.ReadJsonFile();
            foreach (AddressBook list in addressBooks)
            {
                if (list.FirstName.Equals(firstName))
                {
                    list.City = newCity;
                }
            }

            FileOperation.WriteToFile(addressBooks);
            Console.WriteLine("your city is updated");
            Console.WriteLine("if you want to see you updated city .please enter 1 else enter other number");
            int userInput = Convert.ToInt32(Console.ReadLine());
            if (userInput == 1)
            {
                AddressBook book = new AddressBook();
                book.ReadFromFile();
            }
        }

        /// <summary>
        /// Updates the state.
        /// </summary>
        public void UpdateState()
        {
            Console.WriteLine("plaese enter the Firstname for you want to update city");
            string firstName = Console.ReadLine();
            Console.WriteLine("please enter the state you want to add ");
            string newState = Console.ReadLine();
            List<AddressBook> addressBooks = FileOperation.ReadJsonFile();
            foreach (AddressBook list in addressBooks)
            {
                if (list.FirstName.Equals(firstName))
                {
                    list.State = newState;
                }
            }

            FileOperation.WriteToFile(addressBooks);
            Console.WriteLine("your state is updated");
            Console.WriteLine("if you want to see you updated state .please enter 1 else enter other number");
            int userInput = Convert.ToInt32(Console.ReadLine());
            if (userInput == 1)
            {
                AddressBook book = new AddressBook();
                book.ReadFromFile();
            }
        }

        /// <summary>
        /// Updates the zip code.
        /// </summary>
        public void UpdateZipCode()
        {
            Console.WriteLine("plaese enter the Firstname for you want to update city");
            string firstName = Console.ReadLine();
            Console.WriteLine("please enter the ZipCode you want to add ");
            string newZipCode = Console.ReadLine();
            List<AddressBook> addressBooks = FileOperation.ReadJsonFile();
            foreach (AddressBook list in addressBooks)
            {
                if (list.FirstName.Equals(firstName))
                {
                    list.City = newZipCode;
                }
            }

            FileOperation.WriteToFile(addressBooks);
            Console.WriteLine("your zipCode is updated");
            Console.WriteLine("if you want to see you updated ZipCode .please enter 1 else enter other number");
            int userInput = Convert.ToInt32(Console.ReadLine());
            if (userInput == 1)
            {
                AddressBook book = new AddressBook();
                book.ReadFromFile();
            }
        }

        /// <summary>
        /// Deletes the record.
        /// </summary>
        public void DeleteRecord()
        {
            try
            {
                Console.WriteLine("please enter the name for you want to delete the records");
                string firstName = Console.ReadLine();
                List<AddressBook> addressList = FileOperation.ReadJsonFile();
                foreach (AddressBook list in addressList)
                {
                    if (list.FirstName.Equals(firstName))
                    {
                        addressList.Remove(list);
                    }
                }

                FileOperation.WriteToFile(addressList);
                Console.WriteLine("your record is successfully updated");
                Console.WriteLine("if you want to see you updated records .please enter 1 else enter other number");
                int userInput = Convert.ToInt32(Console.ReadLine());
                if (userInput == 1)
                {
                    AddressBook book = new AddressBook();
                    book.ReadFromFile();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
