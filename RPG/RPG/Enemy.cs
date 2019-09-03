using System;

namespace RPG
{
    // Класс Враг
    public class Enemy : Entity
    {
        //конструктор(х-ки берем из родителя)
        public Enemy()
            : base()
        {
            Level = 1;
        }
        // Выбор действия противника
        public string Act(Player target, string action)
        {
            Random gen = new Random();
            int choice = gen.Next(1, 100);
            switch (choice % 9)
            {
                // атака
                case 1:
                case 4:
                    action = "Attack and inflicted " + Attack(target) + " damage!";
                    break;
                // лечение
                case 2:
                case 5:
                    action = "Heal and healed " + Heal() + " HP!";
                    break;
                // защита
                case 3:
                case 6:
                    Defend();
                    action = "Defend";
                    break;
                // бездействие(пропус хода)
                default:
                    break;
            }
            return action;
        }
        // переопределенный метод(переопределяется далее для конкретных игровых классов)
        public override double Special(Entity target)
        {
            return 0;
        }
    }
}
