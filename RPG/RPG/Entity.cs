using System;

namespace RPG
{
    // абстрактный класс Сущность
    public abstract class Entity
    {
        // характеристики(сила, магия, ловкость, дух, теущее и макс. здоровье)
        private int strength, magic, dexterity, spirit, health, maxHealth;
        private int level; // уровень
        private double dmgReduce; // уменьшение урона(для защиты)
        private string className, specialName;// имя класса и особого навыка

        public int Strength { get => strength; set => strength = value; }
        public int Magic { get => magic; set => magic = value; }
        public int Dexterity { get => dexterity; set => dexterity = value; }
        public int Spirit { get => spirit; set => spirit = value; }
        public int Health { get => health; set => health = value; }
        public int MaxHealth { get => maxHealth; set => maxHealth = value; }
        public int Level { get => level; set => level = value; }
        public double DmgReduce { get => dmgReduce; set => dmgReduce = value; }
        public string ClassName { get => className; set => className = value; }
        public string SpecialName { get => specialName; set => specialName = value; }
        // конструктор
        public Entity()
        {
            ClassName = "";
            MaxHealth = 0;
            Health = MaxHealth;
            Strength = 0;
            Magic = 0;
            Dexterity = 0;
            Spirit = 0;
            Level = 0;
            DmgReduce = 0;
        }
        // атака(цель, модификатор)
        public double Attack(Entity target, int mod = 1)
        {
            Random rng = new Random();
            double temp = 2 * mod * (Math.Pow(Strength,2) / target.Dexterity) * ((double)rng.Next(95, 105) / 100) * (1 + (level % 100) / 100);
            double dmg = Math.Round(temp);

            if (dmg <= 0)
                dmg = 10;

            target.Health -= (int)(dmg * (1 - target.dmgReduce));
            if (target.Health < 0)
                target.Health = 0;
            return dmg; // возращаем урон
        }
        // лечение(модификатор)
        public int Heal(int mod = 1)
        {
            Random rng = new Random();
            var healAmount = rng.Next(150, 400)+(Spirit/2 + Magic/10)*rng.Next(10, 40)/10;

            Health += healAmount*mod;

            if (Health > MaxHealth)
                Health = MaxHealth;
            return healAmount; // возвращаем кол-во восстановленного здоровья
        }
        // защита(модификатор)
        public void Defend(int mod = 1)
        {
            Random rng = new Random();
            dmgReduce = mod * (double)rng.Next(40, 60)/100;
        }
        // особый навык(переопределяется для каждого игрового класса)
        public abstract double Special(Entity target);
    }
}
