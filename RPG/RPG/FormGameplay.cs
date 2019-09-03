using RPG.EnemyClasses;
using RPG.PlayerClasses;
using RPG.PlayerClasses.Upgrades;
using System;
using System.Drawing;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace RPG
{
    public partial class FormGameplay : Form
    {
        private Player playerChar; // игрок
        private Enemy enemyChar = new Enemy(); // враг
        private string action = ""; // выбранное действие 
        private bool turn = true; // ход
        private Bitmap playerIdle, plyaerDying, playerDead; // спрайты игрока
        private Bitmap enemyIdle, enemyDying, enemyDead; // спрайты врага
        private int cooldown = 0; // откат особого навыка

        public FormGameplay()
        {
            InitializeComponent();
            CenterToScreen();
            LoadChar(ref playerChar);
            SetPlayer(playerChar);
            GenEnemy(ref enemyChar);
            PlayerStatus();
            EnemyStatus();
        }

        // загрузка игрока при запуске
        private void OnLoad(object sender, EventArgs e)
        {
            LoadChar(ref playerChar);
            cooldown = 0;
        }
        // сохранение игрока при закрытии
        private void OnClose(object sender, FormClosingEventArgs e)
        {
            SaveChar(playerChar);
        }
        // подготовка\обновление персонажа на экране
        private void SetPlayer(Player player)
        {
            Lbl_PlayerName.Text = player.Name + " the " + player.ClassName;
            PlayerHealth.Maximum = player.MaxHealth;
            PlayerHealth.Value = player.Health;
            label5.Text = player.MaxHealth.ToString();
            label6.Text = player.Health.ToString();
            EXPBar.Maximum = player.NeededExp;
            EXPBar.Value = player.Exp;
            label10.Text = player.Level.ToString();
        }
        // генерация противника
        private void GenEnemy(ref Enemy enemy, int mod = 1)
        {
            Random gen = new Random();
            int choice = gen.Next(1, 99);
            switch (choice % 3)
            {
                case 2:
                    enemy = new Werewolf(mod);
                    enemyIdle = Properties.Resources.idle_Wolf;
                    enemyDying = Properties.Resources.idle_Wolf;
                    enemyDead = Properties.Resources.idle_Wolf;
                    break;
                case 1:
                    enemy = new Drow(mod);
                    enemyIdle = Properties.Resources.idle_Drow;
                    enemyDying = Properties.Resources.dying_Drow;
                    enemyDead = Properties.Resources.dead_Drow;
                    break;
                default:
                    enemy = new Necromant(mod);
                    enemyIdle = Properties.Resources.idle_Necro;
                    enemyDying = Properties.Resources.dying_Necro;
                    enemyDead = Properties.Resources.dead_Necro;
                    break;
            }
            PB_Enemy.Image = enemyIdle;
            Lbl_EnemyName.Text = enemy.GetType().Name;
            EnemyHealth.Maximum = enemy.MaxHealth;
            label2.Text = enemy.MaxHealth.ToString();
            label1.Text = enemy.Health.ToString();
            label9.Text = enemy.Level.ToString();
        }
        // кнопка атаки
        private void Btn_Attack_Click(object sender, EventArgs e)
        {
            Attack(playerChar, enemyChar);
            EnemyTurn();
        }
        // кнопка защиты
        private void Btn_Defend_Click(object sender, EventArgs e)
        {
            Defend(playerChar);
            EnemyTurn();
        }
        // кнопка лечения
        private void Btn_Heal_Click(object sender, EventArgs e)
        {
            Heal(playerChar);
            EnemyTurn();
        }
        // кнопка особого навыка
        private void Btn_SpecialMove_Click(object sender, EventArgs e)
        {
            cooldown = 4;
            Special(playerChar, enemyChar);
            EnemyTurn();
            //Rewrite Specials w/o target usage
        }
        // атака
        private void Attack(Player attacker, Enemy target)
        {
            action = "Attack and inflicted " + attacker.Attack(target) + " damage!";
        }
        // лечение
        private void Heal(Player target)
        {
            action = "Heal and healed " + target.Heal() + " HP!";
        }
        // защита
        private void Defend(Entity target)
        {
            action = "Defend";
            target.Defend();
        }
        // особый навык
        private void Special(Player user, Entity target)
        {
            action = user.SpecialName + " and inflicted " + user.Special(target) + " damage!";
        }
        // обновление статуса противника
        private async void PlayerStatus()
        {
            PlayerHealth.Value = playerChar.Health;
            label6.Text = playerChar.Health.ToString();
            if (playerChar.Health <= playerChar.MaxHealth * 0.1)
            {
                PB_Player.Image = plyaerDying;
                if (playerChar.Health == 0)
                {
                    PB_Player.Image = playerDead;
                    MessageBox.Show("Game Over!\nYour score: " + playerChar.Gold);
                    await Task.Delay(1500);
                    this.Close();
                }
            }
            else
            {
                PB_Player.Image = playerIdle;
            }
            BattleLog(playerChar, enemyChar);
            ButtonSwitch();
            turn = !turn;
        }
        // обновление статуса противника
        private async void EnemyStatus()
        {
            EnemyHealth.Value = enemyChar.Health;
            label1.Text = enemyChar.Health.ToString();
            if (enemyChar.Health <= enemyChar.MaxHealth * 0.1)
            {
                PB_Enemy.Image = enemyDying;
                if (enemyChar.Health == 0)
                {
                    PB_Enemy.Image = enemyDead;
                    Random rng = new Random();
                    playerChar.Gold += (int)Math.Pow(enemyChar.Level * 100, 1.1);
                    Lbl_GoldVal.Text = playerChar.Gold.ToString();
                    playerChar.Exp += (int)Math.Pow(enemyChar.Level * 10, 1.1 + rng.NextDouble());
                    EXPBar.Value = (playerChar.Exp >= EXPBar.Maximum) ? EXPBar.Maximum : playerChar.Exp; ;
                    CheckLevelUp(playerChar);
                    await Task.Delay(1500);
                    GenEnemy(ref enemyChar, playerChar.Level);
                }
            }
            else
            {
                PB_Enemy.Image = enemyIdle;
            }
            BattleLog(playerChar, enemyChar);
            ButtonSwitch();
            turn = !turn;
        }
        //смена хода
        private async void EnemyTurn()
        {
            EnemyStatus();
            await Task.Delay(500);
            action = enemyChar.Act(playerChar, action);
            cooldown--;
            PlayerStatus();
        }
        // проверка на новый уровень
        private void CheckLevelUp(Player player)
        {
            if (player.Exp >= player.NeededExp)
            {
                player.LevelUp();
                SetPlayer(player);
                CheckNewClass(player);
            }
        }
        // проверка на улучшение класса
        private void CheckNewClass(Player player)
        {
            if (player.Level >= 50 && player.NotUpgraded)
            {
                player.NotUpgraded = false;
                switch (player.GetType().Name)
                {
                    case "Warrior":
                        player = new Knight(player.Name);
                        break;
                    case "Mage":
                        player = new ArchMage(player.Name);
                        break;
                    case "Rogue":
                        player = new Thief(player.Name);
                        break;
                    case "Priest":
                        player = new HighPriest(player.Name);
                        break;
                    default:
                        break;
                }
                MessageBox.Show("You got an upgrade!\nYour new class is " + player.ClassName);
                SetPlayer(player);
            }
        }
        // лог действий персонажей
        private void BattleLog(Player player, Enemy enemy) 
        {
            Lbl_Log1.Text = Lbl_Log2.Text;
            Lbl_Log2.Text = Lbl_Log3.Text;
            Lbl_Log3.Text = Lbl_Log4.Text;
            Lbl_Log4.Text = Lbl_Log5.Text;
            switch (turn)
            {
                case (true):
                    Lbl_Log5.Text = player.Name + " used " + action;
                    action = "";
                    break;
                default:
                    if (action == "")
                    {
                        Lbl_Log5.Text = enemy.GetType().Name + " did nothing";
                    }
                    else
                    {
                        Lbl_Log5.Text = enemy.GetType().Name + " used " + action;
                        action = "";
                    }
                    break;
            }
        }
        // переключение кнопок
        private void ButtonSwitch()
        {
            foreach (Button b in Pnl_Buttons.Controls)
                b.Enabled = !b.Enabled;
            if (cooldown >= 0) // проверка отката навыка
                Btn_SpecialMove.Enabled = false;
        }
        // сохранение игрока
        private void LoadChar(ref Player player)
        {
            string folder = Path.GetFullPath("D:\\RPG\\");
            string fileName = "";
            DirectoryInfo dir = new DirectoryInfo(folder);
            foreach (FileInfo file in dir.GetFiles())
                fileName = file.Name;
            string filePath = Path.GetFullPath(folder + fileName);
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(Player));
            using (Stream stream = File.OpenRead(filePath))
            {
                // определение класса загруженного персонажа, десериализация сейва, подгрузка спрайтов
                switch (Path.GetFileNameWithoutExtension(fileName))
                {
                    case "Warrior":
                        xmlSerializer = new XmlSerializer(typeof(Warrior));
                        player = new Warrior();
                        player = (Warrior)xmlSerializer.Deserialize(stream);
                        playerIdle = Properties.Resources.idle_Warrior;
                        plyaerDying = Properties.Resources.dying_Warrior;
                        playerDead = Properties.Resources.dead_Warrior;
                        break;
                    case "Mage":
                        xmlSerializer = new XmlSerializer(typeof(Mage));
                        player = new Mage();
                        player = (Mage)xmlSerializer.Deserialize(stream);
                        playerIdle = Properties.Resources.idle_Mage;
                        plyaerDying = Properties.Resources.dying_Mage;
                        playerDead = Properties.Resources.dead_Mage;
                        break;
                    case "Rogue":
                        xmlSerializer = new XmlSerializer(typeof(Rogue));
                        player = new Rogue();
                        player = (Rogue)xmlSerializer.Deserialize(stream);
                        playerIdle = Properties.Resources.idle_Rogue;
                        plyaerDying = Properties.Resources.dying_Rogue;
                        playerDead = Properties.Resources.dead_Rogue;
                        break;
                    case "Priest":
                        xmlSerializer = new XmlSerializer(typeof(Priest));
                        player = new Priest();
                        player = (Priest)xmlSerializer.Deserialize(stream);
                        playerIdle = Properties.Resources.idle_Priest;
                        plyaerDying = Properties.Resources.dying_Priest;
                        playerDead = Properties.Resources.dead_Priest;
                        break;
                    case "Archmage":
                        xmlSerializer = new XmlSerializer(typeof(ArchMage));
                        player = new ArchMage();
                        player = (ArchMage)xmlSerializer.Deserialize(stream);
                        playerIdle = Properties.Resources.idle_Mage;
                        plyaerDying = Properties.Resources.dying_Mage;
                        playerDead = Properties.Resources.dead_Mage;
                        break;
                    case "Knight":
                        xmlSerializer = new XmlSerializer(typeof(Knight));
                        player = new Knight();
                        player = (Knight)xmlSerializer.Deserialize(stream);
                        playerIdle = Properties.Resources.idle_Warrior;
                        plyaerDying = Properties.Resources.dying_Warrior;
                        playerDead = Properties.Resources.dead_Warrior;
                        break;
                    case "Thief":
                        xmlSerializer = new XmlSerializer(typeof(Thief));
                        player = new Thief();
                        player = (Thief)xmlSerializer.Deserialize(stream);
                        playerIdle = Properties.Resources.idle_Rogue;
                        plyaerDying = Properties.Resources.dying_Rogue;
                        playerDead = Properties.Resources.dead_Rogue;
                        break;
                    case "High Priest":
                        xmlSerializer = new XmlSerializer(typeof(HighPriest));
                        player = new HighPriest();
                        player = (HighPriest)xmlSerializer.Deserialize(stream);
                        playerIdle = Properties.Resources.idle_Priest;
                        plyaerDying = Properties.Resources.dying_Priest;
                        playerDead = Properties.Resources.dead_Priest;
                        break;
                }
            }
        }
        // сохранение игрока
        private void SaveChar(Player player)
        {
            // папка с сейв-файлом
            string folder = Path.GetDirectoryName("D\\RPG\\");
            DirectoryInfo dir = new DirectoryInfo(folder);
            foreach (FileInfo file in dir.GetFiles())
                file.Delete();
            // сериализация сейва в xml
            using (Stream stream = File.Create(folder + player.GetType().Name + ".xml"))
            {
                XmlSerializer xmlSerializer = new XmlSerializer(player.GetType());
                xmlSerializer.Serialize(stream, player);
            }
        }
    }
}
