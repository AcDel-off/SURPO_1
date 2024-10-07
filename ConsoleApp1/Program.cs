using System;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool isHidden = false;
            Console.WriteLine($"Hidden status: {isHidden}");

            Console.WriteLine($"1. Change Hidden status\n2. Exit");
            string choise = Console.ReadLine();

            switch ( choise )
            {
                case "1":
                    isHidden = !isHidden;
                    Console.WriteLine($"Hidden status: {isHidden}");
                    break;
                case "2":
                    break;
                default:
                    Console.WriteLine("Not right command");
                    break;
            }
        }
    }
}
