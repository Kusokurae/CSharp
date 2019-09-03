namespace RPG.EnemyClasses
{
    public class Werewolf : Enemy
    {
        public Werewolf()
            : base()
        {
            MaxHealth = 4489;
            Health = MaxHealth;
            Strength = 120;
            Dexterity = 153;
            Magic = 230;
            Spirit = 144;
            Level = 1;
        }
        public Werewolf(double mod)
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
