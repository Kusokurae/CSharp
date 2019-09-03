namespace RPG.PlayerClasses.Upgrades
{
    // класс Верховный Жрец
    class HighPriest : Priest
    {
        // конструктор
        public HighPriest()
            : base()
        {
            ClassName = "High Priest";
            SpecialName = "Aqua Ensemble";
            MaxHealth = (int)(MaxHealth * 1.2);
            Health = MaxHealth;
            Strength = (int)(Strength * 1.2);
            Magic = (int)(Magic * 1.5);
            Dexterity = (int)(Dexterity * 1.2);
            Spirit = (int)(Spirit * 1.3);
            NotUpgraded = false;
        }
        // конструктор с именем
        public HighPriest(string charName)
            : this()
        {
            Name = charName;
        }
        // улучшение навыка из родителя
        public double UpSpecial(Entity target)
        {
            Heal(4);
            return 4 * Special(target);
        }
    }
}
