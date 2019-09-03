using System;

namespace RPG.PlayerClasses
{
    // класс Разбойник
    public class Rogue : Player
    {
        // конструктор
        public Rogue()
            : base()
        {
            ClassName = "Rogue";
            SpecialName = "Shadow Strike";
            MaxHealth = 3516;
            Health = MaxHealth;
            Strength = 141;
            Magic = 117;
            Dexterity = 169;
            Spirit = 161;
        }
        // конструктор с именем
        public Rogue(string charName)
            : this()
        {
            Name = charName;
        }
        // переопределенный особый навык
        public override double Special(Entity target)
        {
            Random rng = new Random();
            double temp = 2 * (Math.Pow(Dexterity, 2) / target.Dexterity) * ((double)rng.Next(105, 150) / 100) * (1 + (Level % 100) / 100);
            double dmg = Math.Round(temp);

            if (dmg <= 0)
                dmg = 10;

            target.Health -= (int)(dmg * (1 - target.DmgReduce));
            if (target.Health < 0)
                target.Health = 0;
            DmgReduce = 0.7;
            return dmg;
        }
    }
}