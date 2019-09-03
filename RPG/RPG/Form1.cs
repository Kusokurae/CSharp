using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Xml;
using System.Xml.Serialization;
using RPG.PlayerClasses;

namespace RPG
{
    public partial class Form_Menu : Form
    {
        public Form_Menu()
        {
            InitializeComponent();
            CenterToScreen();
        }

        private void Btn_CreateChar_Click(object sender, EventArgs e)
        {
            FormCharCreator formCharCreator = new FormCharCreator();
            formCharCreator.Show();
        }

        private void Btn_LoadGame_Click(object sender, EventArgs e)
        {
            Player player = new Player();
            LoadChar(ref player);
            FormGameplay formGameplay = new FormGameplay(player);
            formGameplay.Show();
        }
        private static string GetFolder()
        {
            string folder = "D:\\";
            folder = Path.Combine(folder, "RPG\\");
            return folder;
        }
        private void LoadChar(ref Player player)
        {
            Type type = typeof(Player);
            //try
            //{
            //    using (Stream stream = File.OpenRead(PlayerSettingsFile(player, ref type)))
            //    {
            //        XmlSerializer xmlSerializer = new XmlSerializer(type);
            //        xmlSerializer.Serialize(stream, player);
            //    }
            //}
            //catch (UnauthorizedAccessException)
            //{
            string fileName = "";
            DirectoryInfo dir = new DirectoryInfo(GetFolder());
            foreach (FileInfo file in dir.GetFiles())
                fileName = file.Name;
            string filePath = Path.GetFullPath(GetFolder() + fileName);
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(Player));
            using (Stream stream = File.OpenRead(filePath))
            {
                switch (Path.GetFileNameWithoutExtension(fileName))
                {
                    case "Warrior":
                        xmlSerializer = new XmlSerializer(typeof(Warrior));
                        player = new Warrior();
                        player = (Warrior)xmlSerializer.Deserialize(stream);
                        break;
                    case "Mage":
                        xmlSerializer = new XmlSerializer(typeof(Mage));
                        player = new Mage();
                        player = (Mage)xmlSerializer.Deserialize(stream);
                        break;
                    case "Rogue":
                        xmlSerializer = new XmlSerializer(typeof(Rogue));
                        player = new Rogue();
                        player = (Rogue)xmlSerializer.Deserialize(stream);
                        break;
                    case "Priest":
                        xmlSerializer = new XmlSerializer(typeof(Priest));
                        player = new Priest();
                        player = (Priest)xmlSerializer.Deserialize(stream);
                        MessageBox.Show(player.GetType().Name);
                        break;
                }
            }
            //}
            // return player;
        }
    }
}
