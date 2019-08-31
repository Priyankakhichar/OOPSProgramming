//-------------------------------------------------------------------------------------------------------------------------------
//<copyright file = "WriteToFile.cs" company ="Bridgelabz">
//Copyright © 2019 company ="Bridgelabz"
//</copyright>
//<creator name ="Priyanka khichar"/>
//
//-------------------------------------------------------------------------------------------------------------------------------
namespace OOPSProgramming.InventeryManagment
{
    using Newtonsoft.Json;

    /// <summary>
    /// having write fuction to write the string content in json file
    /// </summary>
    class WriteToFile
    {
        internal static AllFilePaths path = new AllFilePaths();

        /// <summary>
        /// Writes the data to file.
        /// </summary>
        /// <param name="inventoryTypes">The inventory types.</param>
        public static void WriteDataToFile(InventeryTypes inventoryTypes)
        {
            string JsonAddressBook = JsonConvert.SerializeObject(inventoryTypes);
            System.IO.File.WriteAllText(path.InventeryManagement, JsonAddressBook);
        }
    }
}
