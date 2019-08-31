//-------------------------------------------------------------------------------------------------------------------------------
//<copyright file = "FileOperation.cs" company ="Bridgelabz">
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
    /// file reading writing operations
    /// </summary>
    public class FileOperation
    {
        /// <summary>
        /// Writes to file.
        /// </summary>
        /// <param name="addressList">The address list.</param>
        public static void WriteToFile(List<AddressBook> addressList)
        {
            string jsonAddressBook = JsonConvert.SerializeObject(addressList);
            System.IO.File.WriteAllText(@"C:\Users\Admin\source\repos\OOPSProgramming\OOPSProgramming\AddresBook\addressBook.json", jsonAddressBook);
        }

        /// <summary>
        /// Reads the JsonFile.
        /// </summary>
        /// <returns>returns object array</returns>
        public static List<AddressBook> ReadJsonFile()
        {
            if (File.Exists(@"C:\Users\Admin\source\repos\OOPSProgramming\OOPSProgramming\AddresBook\addressBook.json"))
            {
                string jsonData = File.ReadAllText(@"C:\Users\Admin\source\repos\OOPSProgramming\OOPSProgramming\AddresBook\addressBook.json");
                List<AddressBook> jsonArrayObject = JsonConvert.DeserializeObject<List<AddressBook>>(jsonData);
                return jsonArrayObject;
            }
            else
            {
                Console.WriteLine("specified file path does not exist");
                return new List<AddressBook>();
            }
        }
    }
}
