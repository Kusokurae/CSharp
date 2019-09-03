using RPG.PlayerClasses;
using System;
using System.IO;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace RPG
{
    public partial class FormCharCreator : Form
    {
        public FormCharCreator()
        {
            InitializeComponent();
            CenterToScreen();
        }
        // кнопка сохранение персонажа
        private void Btn_SaveChar_Click(object sender, EventArgs e)
        {
            // если есть имя
            if (Txt_CharName.Text != "")
            {
                Player player = new Player();
                // если выбран класс
                if (Cbo_CharClass.Text != "")
                {
                    switch (Cbo_CharClass.Text)
                    {
                        case "Warrior":
                            player = new Warrior(Txt_CharName.Text);
                            break;
                        case "Mage":
                            player = new Mage(Txt_CharName.Text);
                            break;
                        case "Rogue":
                            player = new Rogue(Txt_CharName.Text);
                            break;
                        case "Priest":
                            player = new Priest(Txt_CharName.Text);
                            break;
                        default:
                            break;
                    }
                    ShowStats(player);
                    SaveChar(player);
                    this.Close();
                }
                else MessageBox.Show("You must choose a class!");
            }
            else MessageBox.Show("You must choose a name!");
        }
        // всплывающее окно с сохраненным персонажем
        private void ShowStats(Player player)
        {
            string output = player.Name;
            output += "\nClass: " + player.GetType().Name.ToString();
            output += "\nLevel: " + player.Level;
            output += "\nHealth: " + player.Health;
            output += "\nStrength: " + player.Strength;
            output += "\nDexterity: " + player.Dexterity;
            output += "\nMagic: " + player.Magic;
            output += "\nSpirit: " + player.Spirit;
            MessageBox.Show(output, "Your character");
        }
        // получение папки для сохранения
        private static string GetFolder()
        {
            string folder = Path.GetFullPath("D:\\RPG\\");
            // если папки нет - создать, если есть, и там уже есть сейв-файл заменить(удалив старый)
            if (!Directory.Exists(folder))
                Directory.CreateDirectory(folder);
            else
            {
                DirectoryInfo dir = new DirectoryInfo(folder);
                foreach (FileInfo file in dir.GetFiles())
                    file.Delete();
            }
            return folder;
        }
        // сохранение созданного персонажа(сериализация)
        private void SaveChar(Entity player)
        {
            using (Stream stream = File.Create(GetFolder() + player.GetType().Name + ".xml"))
            {
                XmlSerializer xmlSerializer = new XmlSerializer(player.GetType());
                xmlSerializer.Serialize(stream, player);
            }
        }
        // если сменили класс в списке
        private void Cbo_CharClass_SelectedIndexChanged(object sender, EventArgs e)
        {
            Player player = new Player();
            switch (Cbo_CharClass.Text)
            {
                case "Warrior":
                    player = new Warrior();
                    break;
                case "Mage":
                    player = new Mage();
                    break;
                case "Rogue":
                    player = new Rogue();
                    break;
                case "Priest":
                    player = new Priest();
                    break;
                default:
                    break;
            }
            StatsOnForm(player);
        }
        // обновление полей характеристик при выборе класса
        private void StatsOnForm(Player player)
        {
            Lbl_HealthValue.Text = player.Health.ToString();
            Lbl_StrValue.Text = player.Strength.ToString();
            Lbl_MagValue.Text = player.Magic.ToString();
            Lbl_DexValue.Text = player.Dexterity.ToString();
            Lbl_SprValue.Text = player.Spirit.ToString();
        }
    }
}
