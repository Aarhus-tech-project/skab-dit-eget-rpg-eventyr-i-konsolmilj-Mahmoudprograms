using System;

namespace RPGGame
{
    public class Enemy
    {
        public string Name { get; private set; }
        public int Health { get; private set; }
        public int AttackPower { get; private set; }

        public Enemy(string name, int health, int attackPower)
        {
            Name = name;
            Health = health;
            AttackPower = attackPower;
        }

        public void Attack(Character player)
        {
            Console.WriteLine($"{Name} attacks {player.Name} for {AttackPower} damage!");
            player.TakeDamage(AttackPower);
        }

        public void TakeDamage(int damage)
        {
            Health -= damage;
            Console.WriteLine($"{Name} takes {damage} damage. Remaining health: {Health}");

            if (Health <= 0)
            {
                Console.WriteLine($"{Name} has been defeated!");
            }
        }
    }
}
