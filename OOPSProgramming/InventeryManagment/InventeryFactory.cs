//-------------------------------------------------------------------------------------------------------------------------------
//<copyright file = "InventeryFactory.cs" company ="Bridgelabz">
//Copyright © 2019 company ="Bridgelabz"
//</copyright>
//<creator name ="Priyanka khichar"/>
//
//-------------------------------------------------------------------------------------------------------------------------------
namespace OOPSProgramming.InventeryManagment
{
    using System;
    using System.IO;
    using Newtonsoft.Json;

    /// <summary>
    /// having method to read json file
    /// </summary>
    class InventeryFactory
    {
        /// <summary>
        /// The path
        /// </summary>
        private static AllFilePaths path = new AllFilePaths();

        /// <summary>
        /// Reads the json file.
        /// </summary>
        /// <returns>returning the object of json file</returns>
        public static InventeryTypes ReadJsonFile()
        {
            if (File.Exists(path.InventeryManagement))
            {
                string jsonData = File.ReadAllText(path.InventeryManagement);
                InventeryTypes jsonArrayObject = JsonConvert.DeserializeObject<InventeryTypes>(jsonData);
                return jsonArrayObject;
            }
            else
            {
                Console.WriteLine("specified file path does not exist");
                return new InventeryTypes();
            }
        }
    }
}
