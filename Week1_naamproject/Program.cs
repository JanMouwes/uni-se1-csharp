using System;

namespace Week1_naamproject
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Wat is je naam?");
            string name = Console.ReadLine();

            string returnString;
            switch (name) {
                case "Jan":
                    returnString = "baas";
                    break;
                default:
                    returnString = name;
                    break;
            }

            Console.WriteLine($"Hallo, {returnString}");
        }
    }
}
