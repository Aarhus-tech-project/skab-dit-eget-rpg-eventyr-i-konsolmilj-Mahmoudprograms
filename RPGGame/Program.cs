using System;

namespace RPGGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the RPG Game!");
            Console.WriteLine("Choose your character: \n1. Warrior \n2. SkullTrooper \n3. Kapiushon");
            Console.Write("Enter your choice: ");
            string choice = Console.ReadLine();

            Character player = null;

            switch (choice)
            {
                case "1":
                    player = new Warrior("Warrior");
                    break;
                case "2":
                    player = new SkullTrooper("SkullTrooper");
                    break;
                case "3":
                    player = new Kapiushon("Kapiushon");
                    break;
                default:
                    Console.WriteLine("Invalid choice! Defaulting to Warrior.");
                    player = new Warrior("Warrior");
                    break;
            }

            Console.WriteLine($"You have chosen {player.Name}!");

            // Create an enemy
            Enemy enemy = new Enemy("Goblin", 50, 10);
            Console.WriteLine($"A wild {enemy.Name} appears!");

            // Start Battle
            Battle(player, enemy);
        }

        static void Battle(Character player, Enemy enemy)
        {
            while (player.Health > 0 && enemy.Health > 0)
            {
                Console.WriteLine("\nWhat do you want to do?");
                Console.WriteLine("1. Attack");
                Console.WriteLine("2. Defend");
                Console.WriteLine("3. Use Potion");
                Console.WriteLine("4. Quit");
                Console.Write("Enter choice: ");
                string action = Console.ReadLine();

                switch (action)
                {
                    case "1":
                        player.Attack(enemy);
                        break;
                    case "2":
                        player.Defend();
                        break;
                    case "3":
                        player.UsePotion();
                        break;
                    case "4":
                        Console.WriteLine("Exiting battle...");
                        return;
                    default:
                        Console.WriteLine("Invalid choice, try again.");
                        continue;
                }

                // Enemy Attacks
                if (enemy.Health > 0)
                {
                    enemy.Attack(player);
                }

                player.StopDefending();
            }

            Console.WriteLine("Battle Over!");
        }
    }
}
