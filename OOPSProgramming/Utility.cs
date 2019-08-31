//-------------------------------------------------------------------------------------------------------------------------------
//<copyright file = "Utility.cs" company ="Bridgelabz">
//Copyright © 2019 company ="Bridgelabz"
//</copyright>
//<creator name ="Priyanka khichar"/>
//
//-------------------------------------------------------------------------------------------------------------------------------
namespace OOPSProgramming
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Text.RegularExpressions;
    using Newtonsoft.Json;

    /// <summary>
    /// having the common methods for all project classes
    /// </summary>
    public class Utility
    {
        /// <summary>
        /// collecting data from json file
        /// </summary>
        public static void LoadJson()
        {
            try
            {
                ///reading data from file
                using (StreamReader read = new StreamReader(@"C:\Users\Admin\source\repos\OOPSProgramming\OOPSProgramming\Inventory.json"))
                {
                    var json = read.ReadToEnd();
                    Console.WriteLine(json);

                    ///converting json to .net type
                    var items = JsonConvert.DeserializeObject<List<Inventory>>(json);
                    Console.WriteLine("Name\tweight\tpricePerkg\tAmount");
                    foreach (var item in items)
                    {
                        Console.WriteLine("{0}" + "\t" + "{1}" + "\t" + "{2}" + "\t\t" + "{3}", item.Name, item.Weight, item.Price, item.Price * item.Weight);
                    }
                }
            }
            catch (IOException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        /// <summary>
        /// Reads the string.
        /// </summary>
        /// <returns></returns>
        public static string ReadString()
        {
            return Console.ReadLine();
        }

        /// <summary>
        /// Reads the int.
        /// </summary>
        /// <returns></returns>
        public static int ReadInt()
        {
            return Convert.ToInt32(Console.ReadLine());
        }

        /// <summary>
        /// Reads the data.
        /// </summary>
        public static void ReadData()
        {
            string firstName, lastName, mobileNumber;
            bool flag = false;
            ////validation for User Input
            do
            {
                ////take the first name from user
                Console.WriteLine("ENTER THE FIRST NAME");
                firstName = Console.ReadLine();
                if (!Regex.IsMatch(firstName, @"[a-zA-z]"))
                {
                    Console.WriteLine("Enterd Wrong Input,Please Enter Correct FirstName");
                    flag = true;
                }
            }
            while (flag);
            do
            {
                ////Take the last name from user
                Console.WriteLine("ENTER THE LAST NAME");
                lastName = Console.ReadLine();
                if (!Regex.IsMatch(lastName, @"[a-zA-z]"))
                {
                    Console.WriteLine("Enterd Wrong Input,Please Enter Correct LastName");
                    flag = true;
                }
            }
            while (flag);
            do
            {
                ////Take the mobile number from user
                Console.WriteLine("ENTER THE VALID MOBILE NUMBER");
                mobileNumber = Console.ReadLine();

                ////it is matching with input mobile number that digits is in 0 to 9 and rang is 10digits.
                if (!Regex.IsMatch(mobileNumber, "^[0-9]{10}$"))
                {
                    Console.WriteLine("Enterd Wrong Input,Please Enter Correct mobileNumber");
                    flag = true;
                }
            }
            while (flag);
        }

        /// <summary>
        /// Displays if match is found
        /// </summary>
        /// <param name="message">The message.</param>
        /// <param name="expression">The expression.</param>
        /// <param name="pattern">The pattern.</param>
        /// <returns>returning new string</returns>
        public static string DisplayIfMatch(string message, string expression, string pattern)
        {
            ////creating regex class object for passing pattern
            Regex rgx = new Regex(pattern);
            string newString = rgx.Replace(message, expression);
            return newString;
        }

        /// <summary>
        /// Determines whether the specified user name contains character.
        /// </summary>
        /// <param name="userName">Name of the user.</param>
        /// <returns>
        ///   <c>true</c> if the specified user name contains character; otherwise, <c>false</c>.
        /// </returns>
        /// <exception cref="Exception"></exception>
        public static bool ContainsCharacter(string userName)
        {
            try
            {
                char[] userNameCharacter = userName.ToCharArray();
                for (int i = 0; i < userNameCharacter.Length; i++)
                {
                    if (!char.IsLetterOrDigit(userNameCharacter[i]))
                    {
                        return true;
                    }
                }

                return false;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        /// <summary>
        /// Determines whether the specified user name contains digit.
        /// </summary>
        /// <param name="userName">Name of the user.</param>
        /// <returns>
        ///   <c>true</c> if the specified user name contains digit; otherwise, <c>false</c>.
        /// </returns>
        /// <exception cref="Exception">throwing exception if somthing unconditional happens</exception>
        public static bool ContainsDigit(string userName)
        {
            try
            {
                char[] userNameCharacter = userName.ToCharArray();
                for (int i = 0; i < userNameCharacter.Length; i++)
                {
                    if (!char.IsDigit(userNameCharacter[i]))
                    {
                        return true;
                    }
                }

                return false;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        /// <summary>
        /// Checks the string.
        /// </summary>
        /// <param name="name">The name.</param>
        /// <returns></returns>
        /// <exception cref="Exception">if the given input is other than string it will throw exception</exception>
        public static bool CheckString(string name)
        {
            try
            {
                name = name.Trim();
                if (string.IsNullOrEmpty(name))
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        /// <summary>
        /// Determines whether the specified input is number.
        /// </summary>
        /// <param name="input">The input.</param>
        /// <returns>
        ///   <c>true</c> if the specified input is number; otherwise, <c>false</c>.
        /// </returns>
        /// <exception cref="Exception">it will throw exception if the input number is not a number</exception>
        public static bool IsNumber(string input)
        {
            try
            {
                for (int i = 0; i < input.Length; i++)
                {
                    if (char.IsDigit(input[i]) == false)
                    {
                        return false;
                    }   
                }

                return true;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
