namespace RPG.PlayerClasses
{
    // Класс Воин
    public class Warrior : Player
    {
        // конструктор
        public Warrior()
            : base()
        {
            ClassName = "Warrior";
            SpecialName = "Perfect Void";
            MaxHealth = 4016;
            Health = MaxHealth;
            Strength = 165;
            Magic = 132;
            Dexterity = 159;
            Spirit = 155;
        }
        // конструктор с именем
        public Warrior(string charName)
            : this()
        {
            Name = charName;
        }
        // переопределенный особый навык
        public override double Special(Entity target)
        {
            return Attack(target, 3);
        }
    }
}
