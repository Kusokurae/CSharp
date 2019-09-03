using System;
using System.Windows.Forms;
using System.Drawing;

namespace Ultimate_TTT.Model
{
    class FieldInside : Panel
    {
        static Point[] locations = new Point[9];
        static FieldInside()
        {
            locations[0] = new Point(6, 6);
            locations[1] = new Point(187, 6);
            locations[2] = new Point(368, 6);
            locations[3] = new Point(6, 190);
            locations[4] = new Point(187, 190);
            locations[5] = new Point(368, 190);
            locations[6] = new Point(6, 374);
            locations[7] = new Point(187, 374);
            locations[8] = new Point(368, 374);
        }

        public const int Length = 3;
        public TurnState TurnState = TurnState.Active;

        public Panel Panel { get; set; }
        
        public Square[,] Squares { get; private set; }

        public FieldInside()
        {
            Squares = new Square[Length, Length];
        }

        public void FieldDisable()
        {
            for (int i = 0; i < Length; i++)
            {
                for (int j = 0; j < Length; j++)
                {
                    Squares[i, j].Enabled = false;
                }
            }
        }

        public void FieldEnable()
        {
            for (int i = 0; i < Length; i++)
            {
                for (int j = 0; j < Length; j++)
                {
                    if (Squares[i, j].Text == "")
                        Squares[i, j].Enabled = true;
                }
            }
        }

        public TurnState WinnerCheck()
        {
            TurnState = TurnState.Active;
            //int row = 0;
            for (int row = 0; row < Length; row++)
            {
                if (TurnState == TurnState.Active)
                {
                    TurnState = CheckRow(row);
                    if (TurnState != TurnState.Active)
                        break;

                    TurnState = CheckColumn(row);
                    if (TurnState != TurnState.Active)
                        break;
                }
            }

            if (TurnState == TurnState.Active)
                TurnState = CheckDiagonal1();

            if (TurnState == TurnState.Active)
                TurnState = CheckDiagonal2();

            return TurnState;
        }

        private TurnState CheckRow(int row)
        {
            for (int i = 0; i < Length; i++)
            {
                if (Squares[row, i].Value == TurnSign.EmptySign)
                {
                    return TurnState.Active;
                }
            }

            if (Squares[row, 0].Value == Squares[row, 1].Value && Squares[row, 1].Value == Squares[row, 2].Value)
            {
                return Squares[row, 0].Value == TurnSign.XSign ? TurnState.WinX : TurnState.WinO;
            }
            else
            {
                return TurnState.Draw;
            }
        }

        private TurnState CheckColumn(int column)
        {
            for (int i = 0; i < Length; i++)
            {
                if (Squares[i, column].Value == TurnSign.EmptySign)
                {
                    return TurnState.Active;
                }
            }

            if (Squares[0, column].Value == Squares[1, column].Value && Squares[1, column].Value == Squares[2, column].Value)
            {
                return Squares[0, column].Value == TurnSign.XSign ? TurnState.WinX : TurnState.WinO;
            }
            else
            {
                return TurnState.Draw;
            }
        }

        private TurnState CheckDiagonal1()
        {
            for (int i = 0; i < Length; i++)
            {
                if (Squares[i, i].Value == TurnSign.EmptySign)
                {
                    return TurnState.Active;
                }
            }
            if (Squares[0, 0].Value == Squares[1, 1].Value && Squares[1, 1].Value == Squares[2, 2].Value)
            {
                return Squares[0, 0].Value == TurnSign.XSign ? TurnState.WinX : TurnState.WinO;
            }
            else
            {
                return TurnState.Draw;
            }
        }

        private TurnState CheckDiagonal2()
        {
            for (int i = 0; i < Length; i++)
            {
                if (Squares[Length - i - 1, i].Value == TurnSign.EmptySign)
                {
                    return TurnState.Active;
                }
            }
            if (Squares[0, 2].Value == Squares[1, 1].Value && Squares[1, 1].Value == Squares[2, 0].Value)
            {
                return Squares[0, 2].Value == TurnSign.XSign ? TurnState.WinX : TurnState.WinO;
            }
            else
            {
                return TurnState.Draw;
            }
        }

        public void Initialize(int position, EventHandler buttonClick, EventHandler buttonEnter, EventHandler buttonLeave)
        {
            Panel = new Panel
            {
                Location = locations[position],
                Name = "Block" + position,
                Padding = new System.Windows.Forms.Padding(3),
                Size = new System.Drawing.Size(162, 163),
            };
            for (int i = 0; i < Length; i++)
            {
                for (int j = 0; j < Length; j++)
                {
                    Squares[i, j] = new Square();
                    Squares[i, j].Initialize(i * Length + j, buttonClick, buttonEnter, buttonLeave);
                    Panel.Controls.Add(Squares[i, j]);
                }
            }
        }

        public void Clear()
        {
            foreach (Square square in Squares)
            {
                square.Clear();
            }
            
        }
    }
}
