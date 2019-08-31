//-------------------------------------------------------------------------------------------------------------------------------
//<copyright file = "Node.cs" company ="Bridgelabz">
//Copyright © 2019 company ="Bridgelabz"
//</copyright>
//<creator name ="Priyanka khichar"/>
//
//-------------------------------------------------------------------------------------------------------------------------------
namespace OOPSProgramming.DeckOfCards
{ 
    /// <summary>
    /// Node class
    /// </summary>
    /// <typeparam name="T"></typeparam>
    class Node<T>
    {
        /// <summary>
        /// generics type data
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
        /// <param name="next">The next.</param>
        /// <param name="previous">The previous.</param>
        public Node(T data, Node<T> next, Node<T> previous)
        {
            this.data = data;
            this.next = null;
            this.previous = null;
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
        /// <returns></returns>
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
        /// <returns></returns>
        public Node<T> GetNext()
        {
            return this.next;
        }

        /// <summary>
        /// Sets the previous.
        /// </summary>
        /// <param name="prev">The previous.</param>
        public void SetPrevious(Node<T> prev)
        {
            this.previous = prev;
        }
    }
}
