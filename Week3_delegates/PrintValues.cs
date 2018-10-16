using System;
using System.Globalization;

namespace Week3_delegates
{
    public class PrintValues
    {
        public delegate void Print(int value);

        public PrintValues()
        {            
            Print print_delegate;

            print_delegate = PrintNumber;
            print_delegate += PrintMoney;
            
            print_delegate(200);
        }

        public void PrintNumber(int num)
        {
            Console.WriteLine($"Number: {num,-12:N0}");
        }

        public void PrintMoney(int num)
        {
            Console.WriteLine($"Number: {num:C}");
        }
    }
}