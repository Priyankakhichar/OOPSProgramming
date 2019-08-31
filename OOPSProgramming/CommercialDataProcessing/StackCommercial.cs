//-------------------------------------------------------------------------------------------------------------------------------
//<copyright file = "StackCommercial.cs" company ="Bridgelabz">
//Copyright © 2019 company ="Bridgelabz"
//</copyright>
//<creator name ="Priyanka khichar"/>
//
//-------------------------------------------------------------------------------------------------------------------------------
namespace OOPSProgramming.CommercialDataProcessing
{
    using System;

    /// <summary>
    /// custom stack
    /// </summary>
    public class StackCommercial
    {
        /// <summary>
        /// The top
        /// </summary>
        private static int top;

        /// <summary>
        /// The maximum
        /// </summary>
        private static int maximum;

        /// <summary>
        /// My list
        /// </summary>
        private string[] myList;

        /// <summary>
        /// Stacks the commercial1.
        /// </summary>
        /// <param name="size">The size.</param>
        public void StackCommercial1(int size)
        {
            this.myList = new string[size];
            top = -1;
            maximum = size;
        }

        /// <summary>
        /// Pushes  into stack.
        /// </summary>
        /// <param name="data">The data.</param>
        public void PushIntoStack(string data)
        {
            try
            {
                if (top == (maximum - 1))
                {
                    Console.WriteLine("Stack is full");
                }
                else
                {
                    this.myList[++top] = data;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        /// <summary>
        /// Pops from stack.
        /// </summary>
        /// <returns>returning removed element value</returns>
        /// <exception cref="Exception">exception</exception>
        public string PopFromStack()
        {
            try
            {
                ////decresing top value after pushing 
                return this.myList[top--];
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        /// <summary>
        /// Prints the stack.
        /// </summary>
        public void PrintStack()
        {
            try
            {
              if (this.IsEmpty())
                {
                    Console.WriteLine("stack is empty");
                }
              else
                {
                    foreach (string i in this.myList)
                    {
                        Console.WriteLine("Element " + (top++) + i);
                    }
                }
            }
           catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        /// <summary>
        /// Determines whether this instance is empty.
        /// </summary>
        /// <returns>
        ///   <c>true</c> if this instance is empty; otherwise, <c>false</c>.
        /// </returns>
        public bool IsEmpty()
        {
            if (top == -1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
