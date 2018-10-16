using System;

namespace Week2b_generics
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int[] test_array = {
                1, 2, 3, 4
            };

            CountArray(test_array);
        }

        static void CountArray<T>(T[] array)
        {
            int element_count = array.Length;
            Console.WriteLine($"De lengte van de array is {element_count}");
        }
    }
}
