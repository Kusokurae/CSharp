namespace RPG.EnemyClasses
{
    public class Necromant : Enemy
    {
        public Necromant()
            : base()
        {
            MaxHealth = 4689;
            Health = MaxHealth;
            Strength = 132;
            Dexterity = 131;
            Magic = 220;
            Spirit = 200;
            Level = 1;
        }
        public Necromant(double mod)
            : this()
        {
            MaxHealth *= (int)(1 + mod / 100);
            Health = MaxHealth;
            Strength *= (int)(1 + mod / 100);
            Dexterity *= (int)(1 + mod / 100);
            Magic *= (int)(1 + mod / 100);
            Spirit *= (int)(1 + mod / 100);
            Level = (int)mod;
        }
        public override double Special(Entity target)
        {
            return 0;
        }
    }
}
