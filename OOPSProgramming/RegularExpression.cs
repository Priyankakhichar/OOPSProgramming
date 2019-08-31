//-------------------------------------------------------------------------------------------------------------------------------
//<copyright file = "RegularExpression.cs" company ="Bridgelabz">
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
    using System.Text;
    using System.Text.RegularExpressions;
    using Newtonsoft.Json;

    /// <summary>
    /// replacing string using regular expression
    /// </summary>
    public class RegularExpression
    {
        /// <summary>
        /// Replacing the string
        /// </summary>
        public static void Replace()
        {
                string items = "Hello <<name>>, We have your full name as <<full name>> in our system. your contact number is 91-xxxxxxxxxx.Please,let us know in case of any clarification Thank you BridgeLabz dd/mm/yyyy";
                ////pattern for changing firstName
                string patternForName = "<<name>>";
                Console.WriteLine("please enter the first Name");
                string firstName = Utility.ReadString();

                ////using showmatch static method of regularexexpression class to replace the pattern with valid data
                items = Utility.DisplayIfMatch(items, firstName, patternForName);

                ////pattrern for changing full name
                string patternForFullName = "<<full name>>";
                Console.WriteLine("please enter the last Name");
                string lastName = Utility.ReadString();

                ////using showmatch static method of regularexexpression class to replace the pattern with valid data
                items = Utility.DisplayIfMatch(items, firstName + " " + lastName, patternForFullName);

                ////Pattern for changing mobile number from the sentence   
                string patternForMobileNo = "91-xxxxxxxxxx";
                Console.WriteLine("please enter the mobile number");
                string mobileNo = Utility.ReadString();

                ////using showmatch static method of regularexexpression class to replace the pattern with valid data
                items = Utility.DisplayIfMatch(items, "91" + " " + mobileNo, patternForMobileNo);
                string currentdate = "dd/mm/yyyy";
                string date = DateTime.Now.ToShortDateString();

                ////using showmatch static method of regularexexpression class to replace the pattern with valid data
                items = Utility.DisplayIfMatch(items, date.ToString(), currentdate);
                Console.WriteLine(items);
            }
        }
    }
