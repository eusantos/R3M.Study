using DataStructure.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructure.Collections.Sorting
{
    public interface ISortable<T>
    {
        void Sort(IList<T> target, Func<T, T, ETwoObjectsComparison> func);
    }
}
