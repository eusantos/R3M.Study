using DataStructure.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructure.Collections.Sorting
{
    public class BubbleSort<T> : ISortable<T>
    {
        public void Sort(IList<T> target, Func<T, T, ETwoObjectsComparison> func)
        {
            if (target == null)
                throw new ArgumentNullException("target");
            if (target.Empty())
                return;

            bool switched;
            do
            {
                switched = false;
                for (int i = 0; i < target.Count() - 1; i++)
                {
                    if (func.Invoke(target.At(i), target.At(i + 1)) == ETwoObjectsComparison.FirstElementGreater)
                    {
                        target.Swap(i, i + 1);
                        switched = true;
                    }
                }
            } while (switched);
        }
    }
}
