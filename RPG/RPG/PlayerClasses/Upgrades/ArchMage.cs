namespace RPG.PlayerClasses.Upgrades
{
    // класс Верховный Маг
    class ArchMage : Mage
    {
        // конструктор
        public ArchMage()
            : base()
        {
            ClassName = "Archmage";
            SpecialName = "Ultima Fury";
            MaxHealth = (int)(MaxHealth * 1.1);
            Health = MaxHealth;
            Strength = (int)(Strength * 1.1);
            Magic = (int)(Magic * 1.5);
            Dexterity = (int)(Dexterity * 1.2);
            Spirit = (int)(Spirit * 1.3);
            NotUpgraded = false;
        }
        // конструктор с именем
        public ArchMage(string charName)
            : this()
        {
            Name = charName;
        }
        // улучшение навыка из родителя
        public double UpSpecial(Entity target)
        {
            return 4 * Special(target);
        }
    }
}
