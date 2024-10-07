using System;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                bool isHidden = false;
                Console.WriteLine($"Hidden status: {isHidden}");

                string choise = Console.ReadLine();
                ChangeValue(ref isHidden);
            }
        }

        private static void ChangeValue(ref bool value)
        {
            value = !value;
        }
    }
}
