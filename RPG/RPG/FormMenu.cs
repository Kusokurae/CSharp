/*********************************************************************************
 *                         К У Р С О В О Й   П Р О Е К Т                         *
 *                     И Г Р А  "П О Ш А Г О В А Я   Р П Г"                      *
 *-------------------------------------------------------------------------------*
 * Project Name  : RPG                                                           *
 * Project Type  : Windows Forms Application                                     *
 * File Name     : FormMenu.cs, FormCharCreator.cs, FormGameplay.cs,             *
 *                 Entity.cs, Player.cs, Warrior.cs, Mage.cs, Rogue.cs, Priest.cs*
 *                 Knight.cs, ArchMage.cs, HighPriest.cs, Thief.cs, Enemy.cs,    *
 *                 Necromant.cs, Werewolf.cs, Drow.cs                            *
 * Language      : Visual C# MS VS 2017                                          *
 * Programmer(s) : Афонин С.Д. М3О-210б-17                                       *
 * Modified By   :                                                               *
 * Created       : 08.04.2019                                                    *
 * Last Revision : 27.05.2019                                                    *
 * Comment(s)    : Основная форма, вызываемые:                                   *
 *********************************************************************************/
using System;
using System.Windows.Forms;

namespace RPG
{
    public partial class Form_Menu : Form
    {
        public Form_Menu()
        {
            InitializeComponent();
            CenterToScreen();
        }
        // кнопка перехода к меню создания персонажа
        private void Btn_CreateChar_Click(object sender, EventArgs e)
        {
            FormCharCreator formCharCreator = new FormCharCreator();
            formCharCreator.Show();
        }
        // кнопка переход к игре и загрузка персонажа
        private void Btn_LoadGame_Click(object sender, EventArgs e)
        {
            FormGameplay formGameplay = new FormGameplay();
            formGameplay.Show();
        }
    }
}
