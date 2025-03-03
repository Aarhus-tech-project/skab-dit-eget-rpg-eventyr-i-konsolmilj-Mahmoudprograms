using System;

namespace RPGGame
{
    public abstract class Character
    {
        public string Name { get; private set; }
        public int Health { get; protected set; }
        public int AttackPower { get; protected set; }
        public int Defense { get; protected set; }
        private bool isDefending = false;

        public Character(string name, int health, int attackPower, int defense)
        {
            Name = name;
            Health = health;
            AttackPower = attackPower;
            Defense = defense;
        }

        public virtual void Attack(Enemy enemy)
        {
            Console.WriteLine($"{Name} attacks {enemy.Name} for {AttackPower} damage!");
            enemy.TakeDamage(AttackPower);
        }

        public void Defend()
        {
            isDefending = true;
            Console.WriteLine($"{Name} is defending, reducing incoming damage.");
        }

        public void StopDefending()
        {
            isDefending = false;
        }

        public void TakeDamage(int damage)
        {
            if (isDefending)
            {
                damage /= 2; // Reduce damage by 50% when defending
            }

            Health -= damage;
            Console.WriteLine($"{Name} takes {damage} damage. Remaining health: {Health}");

            if (Health <= 0)
            {
                Console.WriteLine($"{Name} has been defeated!");
            }
        }

        public void UsePotion()


        {
            Health += 20;
            Console.WriteLine($"{Name} used a potion and restored 20 health! Current health: {Health}");
        }

        public void ShowStats()
        {
            Console.WriteLine($"Name: {Name}, Health: {Health}, Attack: {AttackPower}, Defense: {Defense}");
        }
    }
}
