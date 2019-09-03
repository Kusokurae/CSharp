namespace RPG.PlayerClasses.Upgrades
{
    // класс Вор
    class Thief : Rogue
    {
        // конструктор
        public Thief()
            : base()
        {
            ClassName = "Thief";
            SpecialName = "Twisted Fate";
            MaxHealth = (int)(MaxHealth * 1.2);
            Health = MaxHealth;
            Strength = (int)(Strength * 1.2);
            Magic = (int)(Magic * 1.1);
            Dexterity = (int)(Dexterity * 1.5);
            Spirit = (int)(Spirit * 1.3);
            NotUpgraded = false;
        }
        // конструктор с именем
        public Thief(string charName)
            : this()
        {
            Name = charName;
        }
        // улучшение навыка из родителя
        public double UpSpecial(Entity target)
        {
            double dmg = 4 * Special(target);
            DmgReduce = 0.9;
            return dmg;
        }
    }
}
