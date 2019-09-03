namespace RPG.PlayerClasses.Upgrades
{
    // класс Рыцарь
    class Knight : Warrior
    {
        // конструктор
        public Knight()
            : base()
        {
            ClassName = "Knight";
            SpecialName = "Crimson Flash";
            MaxHealth = (int)(MaxHealth * 1.5);
            Health = MaxHealth;
            Strength = (int)(Strength * 1.5);
            Magic = (int)(Magic * 1.1);
            Dexterity = (int)(Dexterity * 1.2);
            Spirit = (int)(Spirit * 1.2);
            NotUpgraded = false;
        }
        // конструктор с именем
        public Knight(string charName)
            :this()
        {
            Name = charName;
        }
        // улучшение навыка из родителя
        public double UpSpecial(Entity target)
        {
            return 5 * Special(target);
        }
    }
}
