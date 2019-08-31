//-------------------------------------------------------------------------------------------------------------------------------
//<copyright file = "LinkedListQueue.cs" company ="Bridgelabz">
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
    /// Queue using Linked List
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class LinkedListQueue<T>
    {
        /// <summary>
        /// The list1
        /// </summary>
        public List<T> list1 = new List<T>();

        /// <summary>
        /// The head
        /// </summary>
        private Node<T> head;

        /// <summary>
        /// The node count
        /// </summary>
        private int nodeCount;

        /// <summary>
        /// The value
        /// </summary>
        private T val;

        /// <summary>
        /// Initializes a new instance of the <see cref="LinkedListQueue{T}"/> class.
        /// </summary>
        public LinkedListQueue()
        {
            this.head = null;
            this.nodeCount = 0;
        }

        /// <summary>
        /// Sizes this instance.
        /// </summary>
        /// <returns>size of the list</returns>
        public int Size()
        {
            Node<T> current = this.head;
            if (current == null)
            {
                Console.WriteLine("Queue is empty");
            }
            else
            {
                while (current != null)
                {
                    this.nodeCount++;
                    current = current.GetNext();
                }
            }

            return this.nodeCount;
        }

        /// <summary>
        /// Adding the node at the last.
        /// </summary>
        /// <param name="value">The value.</param>
        public void AddLast(T value)
        {
            Node<T> newNode = new Node<T>(value, null);
            if (this.head == null)
            {
                this.head = newNode;
                this.nodeCount++;
            }
            else
            {
                Node<T> currentNode = this.head;
                while (currentNode.GetNext() != null)
                {
                    currentNode = currentNode.GetNext();
                }

                currentNode.SetNext(newNode);
                this.head = newNode;
                this.nodeCount++;
            }
        }

        /// <summary>
        /// Adds the node to last with existing list.
        /// </summary>
        /// <param name="list">The list.</param>
        /// <param name="value">The value.</param>
        /// <param name="list1">The list1.</param>
        /// <returns>updated list</returns>
        public LinkedListQueue<T> AddLast1(List<T> list, T value, LinkedListQueue<T> list1)
        {
            try
            {
                if (this.head == null)
                {
                    Node<T> newNode = new Node<T>(value, null);
                    this.head = newNode;
                    this.nodeCount++;
                    return list1;
                }
                else
                {
                    Node<T> newNode = new Node<T>();
                    Node<T> current = this.head;
                    while (current.GetNext() != null)
                    {
                        current = current.GetNext();
                    }

                    current.SetNext(newNode);
                    this.head = newNode;
                    this.nodeCount++;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            return list1;
        }

        /// <summary>
        /// Adds the first.
        /// </summary>
        /// <param name="list">The list.</param>
        /// <param name="data">The data.</param>
        /// <returns>returning the updated list</returns>
        public LinkedListQueue<T> AddFirst(LinkedListQueue<T> list, T data)
        {
            try
            {
                if (this.head == null)
                {
                    Node<T> newNode = new Node<T>(data, null);
                    this.head = newNode;
                    return list;
                }
                else
                {
                    Node<T> newNode = new Node<T>(data, null);
                    newNode.SetNext(this.head);
                    this.head = newNode;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            return list;
        }

        /// <summary>
        /// Adds the first1.
        /// </summary>
        /// <param name="list">The list.</param>
        /// <param name="data">The data.</param>
        /// <param name="list1">The list1.</param>
        /// <returns>returning the updated list</returns>
        public LinkedListQueue<T> AddFirst1(List<T> list, T data, LinkedListQueue<T> list1)
        {
            try
            {
                if (this.head == null)
                {
                    Node<T> newNode = new Node<T>(data, null);
                    this.head = newNode;
                    return list1;
                }
                else
                {
                    Node<T> newNode = new Node<T>(data, null);
                    newNode.SetNext(this.head);
                    this.head = newNode;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            return list1;
        }

        /// <summary>
        /// Adds the player in the list.
        /// </summary>
        /// <param name="list">The list.</param>
        /// <returns>returning the updated list</returns>
        public List<T> AddPlayer(LinkedListQueue<T> list)
        {
            try
            {
                Node<T> newNode = new Node<T>();
                newNode = this.head;
               while (newNode != null)
                {
                    this.list1.Add(newNode.GetData());
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            } 

            return this.list1;
        }

        /// <summary>
        /// Pushes the specified list.
        /// </summary>
        /// <param name="list">The list.</param>
        /// <param name="data">The data.</param>
        public void Push(LinkedListQueue<T> list, T data)
        {
            this.AddFirst(list, data);
        }

        /// <summary>
        /// Pops this instance.
        /// </summary>
        /// <returns>returning true if first element is deleted else returning false</returns>
        public bool Pop()
        {
            return this.DeleteFirst();
        }

        /// <summary>
        /// Deletes the first.
        /// </summary>
        /// <returns>returning true if node has been deleted else false</returns>
        public bool DeleteFirst()
        {
                if (this.head == null)
                {
                    Console.WriteLine("list is empty");
                    return false;
                }
                else if (this.head.GetNext() == null)
                {
                    this.head = null;
                    return true;
                }
                else
                {
                    Node<T> currentNode = this.head;
                    this.head = this.head.GetNext();
                    return true;
                }
        }

        /// <summary>
        /// Deletes the first1.
        /// </summary>
        /// <returns>returning the deleted value</returns>
        public T DeleteFirst1()
        {
            Node<T> currentNode = this.head;
            T val = currentNode.GetData();
            this.head = currentNode.GetNext();
            return val;
        }

        /// <summary>
        /// Deletes the last.
        /// </summary>
        public void DeleteLast()
        {
            Node<T> currentNode = this.head;
            if (currentNode == null)
            {
                Console.WriteLine("list is empty");
            }
            else if (this.head.GetNext() == null)
            {
                this.head = null;
                return;
            }
            else
            {
                while (currentNode.GetNext().GetNext() != null)
                {
                    currentNode = currentNode.GetNext();
                }

                currentNode.SetNext(null);
                return;
            } 
        }

        /// <summary>
        /// Deletes at specifice position.
        /// </summary>
        /// <param name="data">The data.</param>
        public void DeleteAtSpecificePosition(T data)
        {
            Node<T> currentNode = this.head;
            if (currentNode == null)
            {
                Console.WriteLine("list is already empty");
                return;
            }

            while (currentNode != null)
            {
               if (currentNode == this.head && currentNode.GetData().Equals(data))
                {
                    this.head = currentNode.GetNext();
                    GC.Collect();
                    break;
                }
                else if (currentNode.GetNext().GetData().Equals(data))
                {
                    currentNode.SetNext(currentNode.GetNext().GetNext());
                    GC.Collect();
                    break;
                }
                else
                {
                    currentNode = currentNode.GetNext();
                }
            }
        }

        /// <summary>
        /// Prints this instance.
        /// </summary>
        public void Print()
        {
            try
            {
                if (this.head == null)
                {
                    Console.WriteLine("list is empty");
                    return;
                }
                else
                {
                    Node<T> currentNode = this.head;
                    while (currentNode != null)
                    {
                        Console.WriteLine(currentNode.GetData());
                        currentNode = currentNode.GetNext();
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        /// <summary>
        /// Determines whether this instance contains the object.
        /// </summary>
        /// <param name="data">The data.</param>
        /// <returns>
        ///   <c>true</c> if [contains] [the specified data]; otherwise, <c>false</c>.
        /// </returns>
        /// <exception cref="Exception"></exception>
        public bool Contains(T data)
        {
            try
            {
                if (this.head == null)
                {
                    this.DeleteFirst1();
                    return true;
                }

                Node<T> currentNode = this.head;
                while (currentNode != null)
                {
                    if (currentNode.GetData().Equals(data))
                    {
                        return true;
                    }

                    currentNode = currentNode.GetNext();
                }

                return false;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        /// <summary>
        /// Writes to file.
        /// </summary>
        /// <returns>new string</returns>
        public string WriteToFile()
        {
            string string1 = null;
            Node<T> temp = this.head;
            while (temp != null)
            {
                ////adding all node values to the string
                string1 += temp.GetData() + "\n";
                temp = temp.GetNext();
            }

            return string1;
        }
    }
}
