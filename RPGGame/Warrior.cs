namespace RPGGame
{
    public class Warrior : Character
    {
        public int ShieldDamage { get; private set; }
        private int TotalBoomerangDamage;

        public Warrior(string name) : base(name, 100, 15, 5) // (Health, Attack, Defense)
        {
            ShieldDamage = 10;
            TotalBoomerangDamage = 0;
        }

        public void ThrowBoomerangShield(Enemy enemy)
        {
            Console.WriteLine($"{Name} throws the shield like a boomerang, dealing {ShieldDamage} damage!");
            enemy.TakeDamage(ShieldDamage);
            TotalBoomerangDamage += ShieldDamage;

            if (TotalBoomerangDamage >= 50)
            {
                ActivateSuperPower();
                TotalBoomerangDamage = 0;
            }
        }

        private void ActivateSuperPower()
        {
            Console.WriteLine($"{Name} has unlocked the Super Power: Double Damage for 3 turns!");
        }
    }
}
