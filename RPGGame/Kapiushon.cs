using System;

namespace RPGGame
{
    public class Kapiushon : Character
    {
        private int normalArrows = 15;
        private int explosiveArrows = 10;
        private int mysteryArrows = 5;

        public Kapiushon(string name) : base(name, 100, 12, 2) // (Health, Attack, Defense)
        {
        }

        public void ShootArrow(Enemy enemy)
        {
            if (normalArrows > 0)
            {
                Console.WriteLine($"{Name} shoots a normal arrow, dealing 10 damage!");
                enemy.TakeDamage(10);
                normalArrows--;
            }
            else if (explosiveArrows > 0)
            {
                Console.WriteLine($"{Name} shoots an explosive arrow, dealing 20 damage!");
                enemy.TakeDamage(20);
                explosiveArrows--;
            }
            else if (mysteryArrows > 0)
            {
                Console.WriteLine($"{Name} shoots a mystery arrow, dealing 15 damage and confusing the enemy!");
                enemy.TakeDamage(15);
                mysteryArrows--;
            }
            else
            {
                Console.WriteLine($"{Name} has run out of arrows! You need to use your hands or bow.");
            }
        }

        public override void Attack(Enemy enemy)
        {
            ShootArrow(enemy);
        }
    }
}
