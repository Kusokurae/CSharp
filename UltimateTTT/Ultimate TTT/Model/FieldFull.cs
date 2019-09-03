using System;
using System.Windows.Forms;

namespace Ultimate_TTT.Model
{
    class FieldFull
    {
        public const int Length = 3;
        public TurnState TurnState = TurnState.Active;
        public TurnState[,] WinStates = new TurnState[3, 3];
        public string Winner = TurnSign.EmptySign;

        public Panel Panel { get; set; }
        public FieldInside[,] Fields { get; private set; }

        public FieldFull()
        {
            Fields = new FieldInside[Length, Length];
            for (int i = 0; i < Length; i++)
                for (int j = 0; j < Length; j++)
                    WinStates[i, j] = TurnState.Active;
        }


        public void GameStateCheck()
        {
            int row = 0;
            TurnState = TurnState.Active;
            for (row = 0; row < Length; row++)
                if (TurnState == TurnState.Active)
                {
                    TurnState = CheckRow(row);
                    if (TurnState != TurnState.Active)
                        break;

                    TurnState = CheckColumn(row);
                    if (TurnState != TurnState.Active)
                        break;
                }

            if (TurnState == TurnState.Active)
                TurnState = CheckDiagonal1();

            if (TurnState == TurnState.Active)
                TurnState = CheckDiagonal2();
        }

        private TurnState CheckRow(int row)
        {
            for (int j = 0; j < Length; j++)
            {
                TurnState fieldState = Fields[row, j].WinnerCheck();
                if (fieldState == TurnState.Active)
                    return TurnState.Active;
                WinStates[row, j] = fieldState;
            }
            if (WinStates[row, 0] == WinStates[row, 1] && WinStates[row, 1] == WinStates[row, 2])
                return WinStates[row, 0] == TurnState.WinX ? TurnState.WinX : TurnState.WinO;
            else
                return TurnState.Draw;
        }

        private TurnState CheckColumn(int column)
        {
            for (int j = 0; j < Length; j++)
            {
                TurnState fieldState = Fields[j, column].WinnerCheck();
                if (fieldState == TurnState.Active)
                    return TurnState.Active;
                WinStates[j, column] = fieldState;
            }
            if (WinStates[0, column] == WinStates[1, column] && WinStates[1, column] == WinStates[2, column])
                return WinStates[0, column] == TurnState.WinX ? TurnState.WinX : TurnState.WinO;
            else
                return TurnState.Draw;
        }

        private TurnState CheckDiagonal1()
        {
            for (int i = 0; i < Length; i++)
            {
                TurnState fieldState = Fields[i, i].WinnerCheck();
                if (fieldState == TurnState.Active)
                    return TurnState.Active;
                WinStates[i, i] = fieldState;
            }
            if (WinStates[0, 0] == WinStates[1, 1] && WinStates[1, 1] == WinStates[2, 2])
                return Fields[0, 0].WinnerCheck() == TurnState.WinX ? TurnState.WinX : TurnState.WinO;
            else
                return TurnState.Draw;
        }

        private TurnState CheckDiagonal2()
        {
            for (int i = 0; i < Length; i++)
            {
                TurnState fieldState = Fields[Length - i - 1, i].WinnerCheck();
                if (fieldState == TurnState.Active)
                    return TurnState.Active;
                WinStates[Length - i - 1, i] = fieldState;
            }
            if (WinStates[0, 2] == WinStates[1, 1] && WinStates[1, 1] == WinStates[2, 0])
                return WinStates[0, 2] == TurnState.WinX ? TurnState.WinX : TurnState.WinO;
            else
                return TurnState.Draw;
        }

        public void FieldEnable(int index)
        {
            for (int i = 0; i < Length; i++)
                for (int j = 0; j < Length; j++)
                    if (i * Length + j == index)
                    {
                        if (WinStates[i, j] == TurnState.Active)
                            Fields[i, j].FieldEnable();
                        if (WinStates[i, j] != TurnState.Active)
                            EnableAll(index);
                    }
        }

        private void EnableAll(int index)
        {
            for (int i = 0; i < Length; i++)
                for (int j = 0; j < Length; j++)
                    if (WinStates[i, j] == TurnState.Active)
                        Fields[i, j].FieldEnable();
        }

        public void FieldDisable()
        {
            for (int i = 0; i < Length; i++)
                for (int j = 0; j < Length; j++)
                    Fields[i, j].FieldDisable();
        }

        public string WinnerCheck()
        {
            Winner = TurnSign.EmptySign;
            for (int i = 0; i < Length; i++)
                if (WinStates[i, 0] == WinStates[i, 1] && WinStates[i, 1] == WinStates[i, 2])
                    switch (WinStates[i, 0])
                    {
                        case TurnState.WinX:
                            Winner = TurnSign.XSign;
                            return Winner;

                        case TurnState.WinO:
                            Winner = TurnSign.OSign;
                            return Winner;
                    }

            for (int j = 0; j < Length; j++)
                if (WinStates[0, j] == WinStates[1, j] && WinStates[1, j] == WinStates[2, j])
                    switch (WinStates[0, j])
                    {
                        case TurnState.WinX:
                            Winner = TurnSign.XSign;
                            return Winner;

                        case TurnState.WinO:
                            Winner = TurnSign.OSign;
                            return Winner;
                    }
            if (WinStates[0, 0] == WinStates[1, 1] && WinStates[1, 1] == WinStates[2, 2])
                switch (WinStates[0, 0])
                {
                    case TurnState.WinX:
                        Winner = TurnSign.XSign;
                        return Winner;

                    case TurnState.WinO:
                        Winner = TurnSign.OSign;
                        return Winner;
                }

            if (WinStates[0, 2] == WinStates[1, 1] && WinStates[1, 1] == WinStates[2, 0])
                switch (WinStates[0, 2])
                {
                    case TurnState.WinX:
                        Winner = TurnSign.XSign;
                        return Winner;

                    case TurnState.WinO:
                        
                        return Winner = TurnSign.OSign;
                    default:
                        return Winner = TurnSign.EmptySign;
                }
            return Winner;
        }

        public void GameEnd(string Winner)
        {
            if (Winner == TurnSign.XSign)
            {
                MessageBox.Show("Победил Х!");
                foreach (FieldInside field in Fields)
                    field.FieldDisable();
            }
            else if (Winner == TurnSign.OSign)
            {
                MessageBox.Show("Победил O!");
                foreach (FieldInside field in Fields)
                    field.FieldDisable();
            }
        }
        public void Initialize(EventHandler buttonClick, EventHandler buttonEnter, EventHandler buttonLeave)
        {
            Panel = new Panel
            {
                Location = new System.Drawing.Point(12, 43),
                Name = "BlockALL",
                Padding = new System.Windows.Forms.Padding(3),
                Size = new System.Drawing.Size(545, 554),
            };
            for (int i = 0; i < Length; i++)
            {
                for (int j = 0; j < Length; j++)
                {
                    Fields[i, j] = new FieldInside();
                    Fields[i, j].Initialize(i * Length + j, buttonClick, buttonEnter, buttonLeave);
                    Panel.Controls.Add(Fields[i, j].Panel);
                }
            }
        }

        public void Clear()
        {
            foreach (FieldInside field in Fields)
                field.Clear();
            for (int i = 0; i < Length; i++)
                for (int j = 0; j < Length; j++)
                    WinStates[i, j] = TurnState.Active;
        }
    }
}

//TODO Попробовать собрать FieldFull и FieldInside в один класс