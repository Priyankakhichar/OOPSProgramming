//-------------------------------------------------------------------------------------------------------------------------------
//<copyright file = "ILinkedList.cs" company ="Bridgelabz">
//Copyright © 2019 company ="Bridgelabz"
//</copyright>
//<creator name ="Priyanka khichar"/>
//
//-------------------------------------------------------------------------------------------------------------------------------
namespace OOPSProgramming.CommercialDataProcessing
{
    /// <summary>
    /// interface having all methods of linkedList
    /// </summary>
    /// <typeparam name="T">ShareList</typeparam>
    public interface ILinkedList<T>
    {
        /// <summary>
        /// Adds the specified word.
        /// </summary>
        /// <param name="word">The word.</param>
        void AddNodeAtLast(T word);

        /// <summary>
        /// Sizes this instance.
        /// </summary>
        /// <returns>size of list</returns>
        long Size();

        /// <summary>
        /// DeleteLast the specified word to delete.
        /// </summary>
        void DeleteLast();

        /// <summary>
        /// Inserts the specified data.
        /// </summary>
        /// <param name="data">The data.</param>
        /// <param name="position">The position.</param>
        /// <returns>returns true id data added successfully</returns>
        bool Insert(T data, long position);

        /// <summary>
        /// Prints this instance.
        /// </summary>
        void Print();

        /// <summary>
        /// Determines whether [contains] [the specified word].
        /// </summary>
        /// <param name="word">The word.</param>
        /// <returns>
        ///   <c>true</c> if [contains] [the specified word]; otherwise, <c>false</c>.
        /// </returns>
        bool Contains(T word);
    }
}
