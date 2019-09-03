using System;

namespace RPG.PlayerClasses
{
    // класс Маг
    public class Mage : Player
    {
        // конструктор
        public Mage()
            : base()
        {
            ClassName = "Mage";
            SpecialName = "Eternal Ray"; 
            MaxHealth = 3640;
            Health = MaxHealth;
            Strength = 105;
            Magic = 164;
            Dexterity = 142;
            Spirit = 155;
        }
        // конструктор с именем
        public Mage(string charName)
            : this()
        {
            Name = charName;
        }
        // переопределенный особый навык
        public override double Special(Entity target)
        {
            Random rng = new Random();
            double temp = 3 * (Math.Pow(Magic, 2) / target.Spirit) * ((double)rng.Next(85, 100) / 100) * (1 + (Level % 100) / 100);
            double dmg = Math.Round(temp);

            if (dmg <= 0)
                dmg = 10;

            target.Health -= (int)(dmg * (1 - target.DmgReduce));
            if (target.Health < 0)
                target.Health = 0;
            return dmg;
        }
    }
}
