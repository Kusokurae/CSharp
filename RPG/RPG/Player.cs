using System;

namespace RPG
{
    // Класс Игрок
    public class Player : Entity
    {
        private int gold, exp, neededExp; // золото(очки), текущий и необходимый опыт
        private string name; // имя
        private bool notUpgraded = true; // есть ли улчшенный класс

        public int Gold { get => gold; set => gold = value; }
        public int Exp { get => exp; set => exp = value; }
        public int NeededExp { get => neededExp; set => neededExp = value; }
        public string Name { get => name; set => name = value; }
        public bool NotUpgraded { get => notUpgraded; set => notUpgraded = value; }
        // конструктор
        public Player()
            : base()
        {
            ClassName = "Player";
            Name = "";
            Gold = 0;
            Level = 1;
            NeededExp = 100;
            Exp = 0;
            NotUpgraded = true;
        }
        // конструктор с именем игрока
        public Player(string charName)
            : this()
        {
            Name = charName;
        }
        // повышение уровня
        public void LevelUp()
        {
            Random rng = new Random();
            Level++;
            Exp -= NeededExp;
            // кап уровня
            if(Level < 99)
                NeededExp = (int)Math.Ceiling(1000 * Math.Pow(1.1, Level + rng.Next(0, 3)));
            //Увелчение характеристик
            MaxHealth = (int)Math.Ceiling(MaxHealth * 1.1 + rng.Next(0, 11));
            Health = MaxHealth;
            Strength = (int)Math.Ceiling(Strength * 1.1 + rng.Next(0, 11));
            Magic = (int)Math.Ceiling(Magic * 1.1 + rng.Next(0, 11));
            Dexterity = (int)Math.Ceiling(Dexterity * 1.1 + rng.Next(0, 11));
            Spirit = (int)Math.Ceiling(Spirit * 1.1 + rng.Next(0, 11));
        }
        // переопределенный метод(переопределяется далее для конкретных игровых классов)
        public override double Special(Entity target)
        {
            return 0;
        }
    }
}
