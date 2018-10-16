using System;

namespace Week3_delegates
{
    public sealed class Sorter<T> where T : IComparable
    {
        public delegate T[] Sort(T[] items);

        public Sorter()
        {
        }

        public static T[] BubbleSort(T[] items)
        {
            int i, j;
            T temp;

            if (items == null)
                throw new ArgumentException("'Items' cannot be null");

            for (i = items.Length - 1; i >= 0; i--)
            {
                for (j = 1; j <= i; j++)
                {
                    if (items[j - 1].CompareTo(items[j]) <= 0) continue;
                    
                    temp = items[j - 1];
                    items[j - 1] = items[j];
                    items[j] = temp;
                }
            }

            return items;
        }
    }
}