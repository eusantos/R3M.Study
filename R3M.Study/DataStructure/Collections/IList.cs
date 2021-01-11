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
    }
}
