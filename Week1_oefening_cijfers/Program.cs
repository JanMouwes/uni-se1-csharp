using System;

namespace Week1_oefening_cijfers
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int[] cijfers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            int sum = 0;
            int count = 0;
            foreach (int cijfer in cijfers) {
                if (cijfer % 2 == 1)
                {
                    count++;
                    sum += cijfer;
                }
                Console.WriteLine(cijfer);
            }
            Console.WriteLine($"Average is {sum / count}");

        }
    }
}
