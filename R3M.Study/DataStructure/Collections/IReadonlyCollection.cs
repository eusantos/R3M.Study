using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructure.Collections
{
    /// <summary>
    /// Represents a collection whose structure cannot be modified. 
    /// No insertions or deletions allowed.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public interface IReadonlyCollection<T> : IEnumerable<T>
    {
        /// <summary>
        /// Returns the number of elements this collection has
        /// </summary>
        int Count();
        /// <summary>
        /// Counts the number of elements that satisfies the input parameter this collection has.
        /// </summary>
        /// <param name="func"></param>
        /// <returns></returns>
        int Count(Func<bool, bool> func);
        /// <summary>
        /// Verifies whether the collection is empty
        /// </summary>
        /// <returns></returns>
        bool Empty();
        /// <summary>
        /// Returns the element at the specified index
        /// </summary>
        /// <param name="index">A zero-based number representing the element index</param>
        /// <returns></returns>
        T At(int index);
        /// <summary>
        /// Returns the first element of this collection
        /// </summary>
        /// <returns></returns>
        T First();
        /// <summary>
        /// Returns the last element of this collection
        /// </summary>
        /// <returns></returns>
        T Last();
        /// <summary>
        /// Verifies whether this collection is sorted using the param function as comparer.
        /// </summary>
        /// <returns></returns>
        bool Sorted(Func<bool, bool> func);
        /// <summary>
        /// Performs a binary search in this collection using the param function as comparer.
        /// Use this method if you're sure the collection is sorted.
        /// </summary>
        /// <param name="func"></param>
        /// <returns></returns>
        bool BinarySearch(Func<bool, bool> func);
        /// <summary>
        /// Returns the index of the first element found. If no matching records, -1 is returned.
        /// </summary>
        /// <param name="func"></param>
        /// <returns></returns>
        int IndexOf(Func<bool, bool> func);
        /// <summary>
        /// Returns the indexes of all elements found. If no matching records, an empty collection is returned.
        /// </summary>
        /// <param name="func"></param>
        /// <returns></returns>
        IReadonlyCollection<int> IndexesOf(Func<bool, bool> func);
        /// <summary>
        /// Returns the element that satisfies the input condition
        /// </summary>
        /// <param name="func"></param>
        /// <returns></returns>
        T Elem(Func<bool, bool> func);
    }
}
