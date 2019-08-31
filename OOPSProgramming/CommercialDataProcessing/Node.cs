//-------------------------------------------------------------------------------------------------------------------------------
//<copyright file = "Node.cs" company ="Bridgelabz">
//Copyright © 2019 company ="Bridgelabz"
//</copyright>
//<creator name ="Priyanka khichar"/>
//
//-------------------------------------------------------------------------------------------------------------------------------
namespace OOPSProgramming.CommercialDataProcessing
{
    /// <summary>
    /// containing node properties
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class Node<T>
    {
        /// <summary>
        /// The data
        /// </summary>
       private T data;

        /// <summary>
        /// The next
        /// </summary>
        private Node<T> next;

        /// <summary>
        /// The previous
        /// </summary>
        private Node<T> previous;

        /// <summary>
        /// The position
        /// </summary>
        private long position;

        /// <summary>
        /// Initializes a new instance of the <see cref="Node{T}"/> class.
        /// </summary>
        public Node()
        {
            this.next = null;
            this.previous = null;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Node{T}"/> class.
        /// </summary>
        /// <param name="data">The data.</param>
        /// <param name="next">The next.</param>
        public Node(T data, Node<T> next)
        {
            this.data = data;
            this.next = null;
            this.previous = null;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Node{T}"/> class.
        /// </summary>
        /// <param name="data">The data.</param>
        /// <param name="position">The position.</param>
        public Node(T data, long position)
        {
            this.position = position;
            this.data = data;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Node{T}"/> class.
        /// </summary>
        /// <param name="data">The data.</param>
        /// <param name="next">The next.</param>
        /// <param name="previous">The previous.</param>
        public Node(T data, Node<T> next, Node<T> previous)
        {
            this.data = data;
            this.next = null;
            this.previous = null;
        }

        /// <summary>
        /// Gets or sets the position.
        /// </summary>
        /// <value>
        /// The position.
        /// </value>
        public long Position
        {
            get
            {
                return this.position;
            }

            set
            {
                this.position = value;
            }
        }

        /// <summary>
        /// Sets the data.
        /// </summary>
        /// <param name="data">The data.</param>
        public void SetData(T data)
        {
            this.data = data;
        }

        /// <summary>
        /// Gets the data.
        /// </summary>
        /// <returns>returns data of particular node</returns>
        public T GetData()
        {
            return this.data;
        }

        /// <summary>
        /// Sets the next.
        /// </summary>
        /// <param name="next">The next.</param>
        public void SetNext(Node<T> next)
        {
            this.next = next;
        }

        /// <summary>
        /// Gets the next.
        /// </summary>
        /// <returns>returning next node</returns>
        public Node<T> GetNext()
        {
            return this.next;
        }

        /// <summary>
        /// Sets the previous.
        /// </summary>
        /// <param name="previous">The previous.</param>
        public void SetPrevious(Node<T> previous)
        {
            this.previous = previous;
        }

        /// <summary>
        /// Gets the previous.
        /// </summary>
        /// <returns>returning previous node</returns>
        public Node<T> GetPrevious()
        {
            return this.previous;
        }
    }
}
