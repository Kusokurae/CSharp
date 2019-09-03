using System;

namespace RPG.PlayerClasses
{
    // класс Жрец
    public class Priest : Player
    {
        // конструктор
        public Priest()
            : base()
        {
            ClassName = "Priest";
            SpecialName = "Angelic Feather";
            MaxHealth = 3535;
            Health = MaxHealth;
            Strength = 83;
            Magic = 124;
            Dexterity = 128;
            Spirit = 173;
        }
        // конструктор с именем
        public Priest(string charName)
            : this()
        {
            Name = charName;
        }
        // переопределенный особый навык
        public override double Special(Entity target)
        {
            Random rng = new Random();
            double temp = (Math.Pow(Spirit, 2) / target.Spirit) * ((double)rng.Next(85, 100) / 100) * (1 + (Level % 100) / 100);
            double dmg = Math.Round(temp);

            if (dmg <= 0)
                dmg = 10;

            target.Health -= (int)(dmg * (1 - target.DmgReduce));
            if (target.Health < 0)
                target.Health = 0;
            Heal(4);
            return dmg;
        }
    }
}
