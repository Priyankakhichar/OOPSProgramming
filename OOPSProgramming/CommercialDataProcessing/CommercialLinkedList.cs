//-------------------------------------------------------------------------------------------------------------------------------
//<copyright file = "CommercialLinkedList.cs" company ="Bridgelabz">
//Copyright © 2019 company ="Bridgelabz"
//</copyright>
//<creator name ="Priyanka khichar"/>
//
//-------------------------------------------------------------------------------------------------------------------------------
namespace OOPSProgramming.CommercialDataProcessing
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// contains the linked List operation
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <seealso cref="OOPSProgramming.CommercialDataProcessing.ILinkedList{T}" />
    public class CommercialLinkedList<T> : ILinkedList<T>
    {
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
        /// The size
        /// </summary>
        private int size = 0;

        /// <summary>
        /// Initializes a new instance of the <see cref="CommercialLinkedList{T}"/> class.
        /// </summary>
        public CommercialLinkedList()
        {
            this.head = null;
            this.nodeCount = 0;
        }

        /// <summary>
        /// Gets the first node.
        /// </summary>
        /// <returns>returning the first node</returns>
        public Node<T> GetFirstNode()
        {
            return this.head;
        }

        /// <summary>
        /// Gets the last node.
        /// </summary>
        /// <returns>returning the last node</returns>
        public Node<T> GetLastNode()
        {
            Node<T> current = this.head;
            try
            {
                while (current.GetNext() != null)
                {
                    current = current.GetNext();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            return current;
        }

        /// <summary>
        /// Determines whether this instance is empty.
        /// </summary>
        /// <returns>
        ///   <c>true</c> if this instance is empty; otherwise, <c>false</c>.
        /// </returns>
        public bool IsEmpty()
        {
            return this.head == null;
        }

        /// <summary>
        /// Adds the node at last.
        /// </summary>
        /// <param name="data">The data.</param>
        public void AddNodeAtLast(T data)
        {
            try
            {
                if (this.head == null)
                {
                    Node<T> node = new Node<T>(data, null, null);
                    this.head = node;
                    this.nodeCount++;
                }
                else
                {
                    Node<T> current = this.head;
                    Node<T> newNode = new Node<T>(data, null);
                    while (current.GetNext() != null)
                    {
                        current = current.GetNext();
                    }

                    current.SetNext(newNode);
                    this.nodeCount++;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        /// <summary>
        /// Adds the node at last1.
        /// </summary>
        /// <param name="list">The list.</param>
        /// <param name="data">The data.</param>
        /// <param name="list1">The list1.</param>
        /// <returns>returning the commercial linked list</returns>
        public CommercialLinkedList<T> AddNodeAtLast1(List<T> list, T data, CommercialLinkedList<T> list1)
        {
            try
            {
                if (this.IsEmpty())
                {
                    this.head = new Node<T>(data, null, null);
                    this.nodeCount++;
                    return list1;
                }
                else
                {
                    Node<T> currentNode = this.head;
                    Node<T> newNode = new Node<T>(data, null);
                    while (currentNode.GetNext() != null)
                    {
                        currentNode = currentNode.GetNext();
                    }

                    currentNode.SetNext(newNode);
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
        /// Adds the node at first.
        /// </summary>
        /// <param name="data">The data.</param>
        /// <returns>return true if node contains that data else false</returns>
        public bool AddNodeAtFirst(T data)
        {
            try
            {
                if (this.IsEmpty())
                {
                    this.head = new Node<T>(data, null);
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

            return true;
        }

        /// <summary>
        /// Adds the node at first1.
        /// </summary>
        /// <param name="list">The list.</param>
        /// <param name="data">The data.</param>
        /// <param name="list1">The list1.</param>
        /// <returns>returning the list</returns>
        public CommercialLinkedList<T> AddNodeAtFirst1(List<T> list, T data, CommercialLinkedList<T> list1)
        {
            try
            {
                if (this.IsEmpty())
                {
                    this.head = new Node<T>(data, null);
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
        /// Pops this instance.
        /// </summary>
        /// <returns>returning true and false for Deleting first element</returns>
        public bool Pop()
        {
            return this.DeleteFirst();
        }

        /// <summary>
        /// Deletes the first.
        /// </summary>
        /// <returns>returning the status of Deleting first method</returns>
        public bool DeleteFirst()
        {
            if (this.IsEmpty())
            {
                Console.WriteLine("Linked list is already empty");
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
                Console.WriteLine(this.head.GetData());
                this.head = currentNode.GetNext();
                GC.Collect();
                return true;
            }
        }

        /// <summary>
        /// Sizes this instance.
        /// </summary>
        /// <returns>returning the size of list</returns>
        public long Size()
        {
            return this.size;
        }

        /// <summary>
        /// Deletes the first1.
        /// </summary>
        /// <returns>returning the deleted element</returns>
        public T DeleteFirst1()
        {
           Node<T> currentNode = this.head;
            T val = this.head.GetData();
            this.head = currentNode.GetNext();
            GC.Collect();
            return val;
        }

        /// <summary>
        /// Deletes the specified word to delete.
        /// </summary>
        public void DeleteLast()
        {
            if (this.IsEmpty())
            {
                Console.WriteLine("Linked list is already empty");
                return;
            }
            else if (this.head.GetNext() == null)
            {
                this.head = null;
                return;
            }
            else
            {
                Node<T> currentNode = this.head;
                while (currentNode.GetNext().GetNext() != null)
                {
                    currentNode = currentNode.GetNext();
                }

                currentNode.SetNext(null);
                return;
            }
        }

        /// <summary>
        /// Deletes at position.
        /// </summary>
        /// <param name="data">The data.</param>
        public void DeleteAtPosition(T data)
        {
            Node<T> currentNode = this.head;
            while (currentNode != null)
            {
                if (this.IsEmpty())
                {
                    Console.WriteLine("Linked list is already empty");
                    return;
                }
                else if (currentNode == this.head && currentNode.GetData().Equals(data))
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
                if (this.IsEmpty())
                {
                    Console.WriteLine("Linked list is empty");
                }
                else
                {
                    Node<T> currenrNode = this.head;
                    while (currenrNode != null)
                    {
                        Console.WriteLine(currenrNode.GetData() + string.Empty);
                        currenrNode = currenrNode.GetNext();
                    }

                    Console.WriteLine();
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
        /// <param name="word">The word.</param>
        /// <returns>
        /// <c>true</c> if [contains] [the specified word]; otherwise, <c>false</c>.
        /// </returns>
        /// <exception cref="Exception">throwing exception if unconditional happen</exception>
        public bool Contains(T word)
        {
            try
            {
                Node<T> currentNode = this.head;
                if (this.head == null)
                {
                    this.DeleteFirst1();
                    return true;
                }

                while (currentNode != null)
                {
                    if (currentNode.GetData().Equals(word))
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
        /// Inserts the specified data.
        /// </summary>
        /// <param name="data">The data.</param>
        /// <param name="pos">The position.</param>
        /// <returns>returning Insert status</returns>
        /// <exception cref="Exception">throwing exception</exception>
        public bool Insert(T data, long pos)
        {
            try
            {
                if (pos > this.size)
                {
                    Console.WriteLine("Specified position is greater than existing size");
                    return false;
                }
                else
                {
                    Node<T> newNode1 = new Node<T>(data, pos);

                    Node<T> temp = this.head;

                    for (int i = 0; i < pos - 1; i++)
                    {
                        temp = temp.GetNext();
                    }

                    Node<T> newNode2 = temp.GetNext();
                    temp.SetNext(newNode1);
                    newNode1.SetNext(newNode2);
                    temp = null;
                    this.size++;
                    this.Reposition();
                    return true;
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        /// <summary>
        /// Repositions this instance.
        /// </summary>
        public void Reposition()
        {
            try
            {
                Node<T> temp = this.head;

                int i = 0;

                while (temp != null)
                {
                    temp.Position = i++;
                    temp = temp.GetNext();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        /// <summary>
        /// Writes text to file.
        /// </summary>
        /// <returns>returning the string</returns>
        public string WriteToFile()
        {
            string string1 = null;
            Node<T> temp = this.head;
            while (temp != null)
            {
                string1 += temp.GetData() + "\n";
                temp = temp.GetNext();
            }

            return string1;
        }
    }
}
