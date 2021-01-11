using DataStructure.Collections;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructure.Collections
{
    public interface IList<T> : IReadonlyCollection<T>
    {
        /// <summary>
        /// Adds an element at the first position of the list
        /// </summary>
        /// <param name="elem"></param>
        void AddFirst(T elem);
        /// <summary>
        /// Adds an element at the last position of the list
        /// </summary>
        /// <param name="elem"></param>
        void AddLast(T elem);
        /// <summary>
        /// Adds an element at the default position of the list
        /// </summary>
        /// <param name="elem"></param>
        void Add(T elem);
        /// <summary>
        /// Adds an element at the specified position of the list
        /// </summary>
        /// <param name="elem"></param>
        /// <param name="index"></param>
        void Add(T elem, int index);
        /// <summary>
        /// Adds an element at the default position of the list.
        /// If the element exists in the list, an exception is thrown
        /// </summary>
        /// <param name="elem"></param>
        void AddStrict(T elem);
        /// <summary>
        /// Adds an element at the specified position of the list.
        /// If the element exists in the list, an exception is thrown
        /// </summary>
        /// <param name="elem"></param>
        void AddStrict(T elem, int index);
        /// <summary>
        /// Removes the element at the first position of the list
        /// </summary>
        /// <param name="elem"></param>
        void RemoveFirst();
        /// <summary>
        /// Removes the element at the last position of the list
        /// </summary>
        /// <param name="elem"></param>
        void RemoveLast();
        /// <summary>
        /// Removes the first element that satisfies the condition.
        /// If no matching elements, nothing happens.
        /// </summary>
        /// <param name="elem"></param>
        void Remove(Func<bool, bool> func);
        /// <summary>
        /// Removes all elements that satisfy the condition
        /// If no matching elements, nothing happens.
        /// </summary>
        /// <param name="elem"></param>
        void RemoveAll(Func<bool, bool> func);
        /// <summary>
        /// Randomly switches the position of the list elements.
        /// </summary>
        void Shuffle();
        /// <summary>
        /// Sorts the list accordingly to the comparison function using the default algorithm
        /// </summary>
        /// <param name="func"></param>
        void Sort(Func<T, T, int> func);
        /// <summary>
        /// Sorts the list accordingly to the comparison function using the sortingAlgorithm algorithm
        /// </summary>
        /// <param name="sortingAlgorithm"></param>
        void Sort(Func<T, T, int> func, ESortingAlgorithm sortingAlgorithm);
    }
}
