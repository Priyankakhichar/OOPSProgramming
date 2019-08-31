//-------------------------------------------------------------------------------------------------------------------------------
//<copyright file = "AddressBook.cs" company ="Bridgelabz">
//Copyright © 2019 company ="Bridgelabz"
//</copyright>
//<creator name ="Priyanka khichar"/>
//
//-------------------------------------------------------------------------------------------------------------------------------
namespace OOPSProgramming.AddresBook
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using Newtonsoft.Json;

    /// <summary>
    /// getter and setter of AddressBook
    /// </summary>
    public class AddressBook
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
        /// The mobile no
        /// </summary>
        private string mobileNo;

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
        /// The zip
        /// </summary>
        private string zipCode;

        /// <summary>
        /// Initializes a new instance of the <see cref="AddressBook"/> class.
        /// </summary>
        public AddressBook()
        {
            this.firstName = null;
            this.lastName = null;
            this.mobileNo = null;
            this.address = null;
            this.city = null;
            this.state = null;
            this.zipCode = null;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AddressBook"/> class.
        /// </summary>
        /// <param name="firstName">The first name.</param>
        /// <param name="lastName">The last name.</param>
        /// <param name="mobileNo">The mobile no.</param>
        /// <param name="address">The address.</param>
        /// <param name="city">The city.</param>
        /// <param name="state">The state.</param>
        /// <param name="zipCode">The zip code.</param>
        public AddressBook(string firstName, string lastName, string mobileNo, string address, string city, string state, string zipCode)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.mobileNo = mobileNo;
            this.address = address;
            this.city = city;
            this.state = state;
            this.zipCode = zipCode;
        }

        /// <summary>
        /// Gets or sets the first name.
        /// </summary>
        /// <value>
        /// The first name.
        /// </value>
        public string FirstName
        {
            get
            {
               return this.firstName;
            }

            set
            {
                this.firstName = value;
            }
        }

        /// <summary>
        /// Gets or sets the last name.
        /// </summary>
        /// <value>
        /// The last name.
        /// </value>
        public string LastName
        {
            get
            {
                return this.lastName;
            }

            set
            {
                this.lastName = value;
            }
        }

        /// <summary>
        /// Gets or sets the mobile no.
        /// </summary>
        /// <value>
        /// The mobile no.
        /// </value>
        public string MobileNo
        {
            get
            {
                return this.mobileNo;
            }

            set
            {
                this.mobileNo = value;
            }
        }

        /// <summary>
        /// Gets or sets the address.
        /// </summary>
        /// <value>
        /// The address.
        /// </value>
        public string Address
        {
            get
            {
                return this.address;
            }

            set
            {
                this.address = value;
            }
        }

        /// <summary>
        /// Gets or sets the city.
        /// </summary>
        /// <value>
        /// The city.
        /// </value>
        public string City
        {
            get
            {
                return this.city;
            }

            set
            {
                this.city = value;
            }
        }

        /// <summary>
        /// Gets or sets the state.
        /// </summary>
        /// <value>
        /// The state.
        /// </value>
        public string State
        {
            get
            {
                return this.state;
            }

            set
            {
                this.state = value;
            }
        }

        /// <summary>
        /// Gets or sets the zip code.
        /// </summary>
        /// <value>
        /// The zip code.
        /// </value>
        public string ZipCode
        {
            get
            {
                return this.zipCode;
            }

            set
            {
                this.zipCode = value;
            }
        }

        /// <summary>
        /// Reads from file.
        /// </summary>
        public void ReadFromFile()
        {
            using (StreamReader reader = new StreamReader(@"C:\Users\Admin\source\repos\OOPSProgramming\OOPSProgramming\AddresBook\addressBook.json"))
            {
                string jsonFile = reader.ReadToEnd();
                List<AddressBook> list = JsonConvert.DeserializeObject<List<AddressBook>>(jsonFile);
                Console.WriteLine("FirstName \tlastName \tMobileNo \tAddress \tCity \tstate \tZipCode ");
                Console.WriteLine("======================================================================");
                foreach (AddressBook list1 in list)
                {
                    Console.WriteLine(list1.FirstName + "\t" + list1.LastName + "\t" + list1.MobileNo + "\t\t" + list1.Address + "\t" + list1.City + "\t" + list1.State + "\t" + list1.ZipCode);
                }
            }
        }     
    }
}
