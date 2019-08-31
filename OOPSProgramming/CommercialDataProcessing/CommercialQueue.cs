//-------------------------------------------------------------------------------------------------------------------------------
//<copyright file = "CommercialQueue.cs" company ="Bridgelabz">
//Copyright © 2019 company ="Bridgelabz"
//</copyright>
//<creator name ="Priyanka khichar"/>
//
//-------------------------------------------------------------------------------------------------------------------------------
namespace OOPSProgramming.CommercialDataProcessing
{
    using System;

    /// <summary>
    /// having Queue methods 
    /// </summary>
   public class CommercialQueue
    {
        /// <summary>
        /// The queue maximum size
        /// </summary>
        private int queueMaxSize = 500;

        /// <summary>
        /// The front
        /// </summary>
        private int front = -1;

        /// <summary>
        /// The rear
        /// </summary>
        private int rear = -1;

        /// <summary>
        /// The queue array
        /// </summary>
        private string[] queueArray = new string[1000];

        /// <summary>
        /// The size
        /// </summary>
        private int size;

        /// <summary>
        /// Gets or sets the maximum size of the queue.
        /// </summary>
        /// <value>
        /// The maximum size of the queue.
        /// </value>
        public int QueueMaxSize
        {
            get
            {
                return this.queueMaxSize;
            }

            set
            {
                this.QueueMaxSize = value;
            }
        }

        /// <summary>
        /// Gets or sets the front.
        /// </summary>
        /// <value>
        /// The front.
        /// </value>
        public int Front
        {
            get
            {
                return this.front;
            }

            set
            {
                this.front = value;
            }
        }

        /// <summary>
        /// Gets or sets the rear.
        /// </summary>
        /// <value>
        /// The rear.
        /// </value>
        public int Rear
        {
            get
            {
                return this.rear;
            }

            set
            {
                this.rear = value;
            }
        }

        /// <summary>
        /// Gets or sets the size.
        /// </summary>
        /// <value>
        /// The size.
        /// </value>
        public int Size
        {
            get
            {
                return this.size;
            }

            set
            {
                this.size = value;
            }
        }

        /// <summary>
        /// Enqueues the specified data.
        /// </summary>
        /// <param name="data">The data.</param>
        /// <returns>returns true if element is added else returns false</returns>
        /// <exception cref="Exception">throwing exception if something unconditional happen</exception>
        public bool Enqueue(string data)
        {
            try
            {
                if (this.rear == this.queueMaxSize - 1)
                {
                    Console.WriteLine("Queue Overflow");
                    return false;
                }
                else
                {
                    if (this.front == -1)
                    {
                        this.front = 0;
                    }

                    //// adding from the rear ,hence increasing the value of rear when each element is added.
                    this.rear++; 
                    this.queueArray[this.rear] = data;
                    this.size++;
                    return true;
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        /// <summary>
        /// Dequeue this instance.
        /// </summary>
        /// <returns>returns true if element is added else returns false</returns>
        /// <exception cref="Exception">throwing exception if something unconditional happen</exception>
        public bool Dequeue()
        {
            try
            {
                ////Checks for underflow Condition
                if (this.front == -1 || this.front > this.rear)
                {
                    Console.WriteLine("Queue Underflow");
                    return false;
                }
                else
                {
                    Console.WriteLine(this.queueArray[this.front] + " removed from queue");
                    Console.WriteLine("remaining Balance = " + this.queueArray[this.front]);
                    this.front++;
                    this.size--;
                    return true;
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        /// <summary>
        /// Shows the elements.
        /// </summary>
        /// <exception cref="Exception">throwing exception if something unconditional happen</exception>
        public void ShowElements()
        {
            try
            {
                if (this.front == -1)
                {
                    Console.WriteLine("Queue is Empty");
                }
                else
                {
                    //// Irterates from the front to rear .
                    for (int i = this.front; i <= this.rear; i++)
                    {
                        Console.WriteLine(this.queueArray[i]);
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        /// <summary>
        /// Checks the size.
        /// </summary>
        /// <returns>sizeOfQueue</returns>
        /// <exception cref="Exception">throwing exception if something unconditional happen</exception>
        public int CheckSize()
        {
            try
            {
                return this.size;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
