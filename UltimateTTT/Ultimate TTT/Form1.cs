using System;
using System.Windows.Forms;
using Ultimate_TTT.Model;

namespace Ultimate_TTT
{
    public partial class UTTT : Form
    {
        public UTTT()
        {
            InitializeComponent();
            _fieldFull = new FieldFull();
            InitializeField();
        }

        FieldFull _fieldFull;

        private void InitializeField()
        {
            _fieldFull.Initialize(ButtonClick, ButtonEnter, ButtonLeave);
            Controls.Add(_fieldFull.Panel);
        }

        bool turn = true;

        private void ButtonClick(object sender, EventArgs e)
        {
            Square b = sender as Square;
            b.SetSign(turn);
            turn = !turn;
            _fieldFull.GameStateCheck();
            TurnName.Text = turn ? "Ход X" : "Ход O";
            _fieldFull.FieldDisable();
            _fieldFull.FieldEnable(Int32.Parse(b.Name));
            _fieldFull.WinnerCheck();
            _fieldFull.GameEnd(_fieldFull.Winner);
        }

        private void ButtonEnter(object sender, EventArgs e)
        {
            Square b = sender as Square;
            if (b.Enabled)
            {
                b.Text = turn ? TurnSign.XSign : TurnSign.OSign;
            }
        }

        private void ButtonLeave(object sender, EventArgs e)
        {
            Square b = sender as Square;
            if (b.Enabled)
            {
                b.Text = "";
            }
        }

        private void New_game(object sender, EventArgs e)
        {
            _fieldFull.Clear();
            TurnName.Text = "Ход X";
            turn = true;
        }
    }
}