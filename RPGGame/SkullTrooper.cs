using System;

namespace RPGGame
{
    public class SkullTrooper : Character
    {
        private Random random;

        public SkullTrooper(string name) : base(name, 100, 10, 3) // (Health, Attack, Defense)
        {
            random = new Random();
        }

        public void ThrowSkull(Enemy enemy)
        {
            int damage = random.Next(5, 20); // Skull damage varies between 5 and 20
            Console.WriteLine($"{Name} throws a skull, dealing {damage} damage!");
            enemy.TakeDamage(damage);
        }

        public override void Attack(Enemy enemy)
        {
            ThrowSkull(enemy);
        }
    }
}
