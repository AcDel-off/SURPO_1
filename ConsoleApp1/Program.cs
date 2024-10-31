using System;

namespace Enemy
{
    internal class Program
    {
        static bool isHidden = false;
        static int health = 100;
        static int attackingStrength = 10;

        static void Main(string[] args)
        {
            HiddenStatus();
            HealthLevel();
            AttackingStrength();
        }

        private static void HiddenStatus()
        {
            Console.WriteLine($"Hidden status: {isHidden}\n");

            while (true)
            {
                Console.WriteLine($"1. Change Hidden status\n2. Next step");
                string choise = Console.ReadLine();

                switch (choise)
                {
                    case "1":
                        isHidden = !isHidden;
                        Console.WriteLine($"Hidden status: {isHidden}");
                        break;
                    case "2":
                        return;
                    default:
                        Console.WriteLine("Not right command");
                        break;
                }
            }
        }

        private static void HealthLevel()
        {
            Console.WriteLine($"Health level: {health}\n");

            while (true)
            {
                Console.WriteLine($"1. Change health level\n2. Exit");
                string choise = Console.ReadLine();

                switch (choise)
                {
                    case "1":
                        try
                        {
                            health = int.Parse(Console.ReadLine());
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine(ex);
                            break;
                        }
                        Console.WriteLine($"Health level: {health}");
                        break;
                    case "2":
                        return;
                    default:
                        Console.WriteLine("Not right command");
                        break;
                }
            }
        }

        private static void AttackingStrength()
        {
            Console.WriteLine($"Attacking Strength: {attackingStrength}\n");

            while (true)
            {
                Console.WriteLine($"1. Change Attacking Strength\n2. Exit");
                string choise = Console.ReadLine();

                switch (choise)
                {
                    case "1":
                        try
                        {
                            attackingStrength = int.Parse(Console.ReadLine());
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine(ex);
                            break;
                        }
                        Console.WriteLine($"Attacking Strength: {attackingStrength}");
                        break;
                    case "2":
                        return;
                    default:
                        Console.WriteLine("Not right command");
                        break;
                }
            }
        }
    }

    public class Enemy
    {
        public int Id { get; }
        public string Name { get; set; }
        public int Health { get; set; }
        public Enemy(int id, string name)
        {
            Id = id;
            Name = name;
            Health = 100;
        }
    }
}
