namespace RPG.EnemyClasses
{
    public class Drow : Enemy
    {
        public Drow()
            : base()
        {
            MaxHealth = 4789;
            Health = MaxHealth;
            Strength = 205;
            Dexterity = 190;
            Magic = 167;
            Spirit = 175;
            Level = 1;
        }
        public Drow(double mod)
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
