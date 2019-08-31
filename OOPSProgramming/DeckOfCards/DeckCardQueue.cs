//-------------------------------------------------------------------------------------------------------------------------------
//<copyright file = "DeckCardQueue.cs" company ="Bridgelabz">
//Copyright © 2019 company ="Bridgelabz"
//</copyright>
//<creator name ="Priyanka khichar"/>
//
//-------------------------------------------------------------------------------------------------------------------------------
namespace OOPSProgramming.DeckOfCards
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// Containing Queue methods for DeckOfCards
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class DeckCardQueue<T>
    {
        /// <summary>
        /// The list
        /// </summary>
        public LinkedListQueue<T> list = new LinkedListQueue<T>();

        /// <summary>
        /// Enqueues the specified list1.
        /// </summary>
        /// <param name="list1">The list1.</param>
        /// <param name="number">The number.</param>
        /// <returns></returns>
        public LinkedListQueue<T> Enqueue(List<T> list1, T number)
        {
            try
            {
                this.list = this.list.AddLast1(list1, number, this.list);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            return this.list;
        }

        /// <summary>
        /// Dequeue the specified list.
        /// </summary>
        /// <param name="list">The list.</param>
        /// <param name="list1">The list1.</param>
        /// <returns>returns the list</returns>
        public LinkedListQueue<T> Dequeue(LinkedListQueue<T> list, List<T> list1)
        {
            try
            {
                T number;

                ////remove top element from the linked list
                number = list.DeleteFirst1();

                ////add that removed node to the list
                list.AddFirst1(list1, number, list);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            return list;
        }
    }
}
