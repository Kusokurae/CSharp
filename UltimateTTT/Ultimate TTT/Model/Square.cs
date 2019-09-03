using System;
using System.Windows.Forms;
using System.Drawing;

namespace Ultimate_TTT.Model
{
    class Square : Button
    {
        static Point[] locations = new Point[9];
        static Square()
        {
            locations[0] = new Point(0, 0);
            locations[1] = new Point(56, 0);
            locations[2] = new Point(112, 0);
            locations[3] = new Point(0, 56);
            locations[4] = new Point(56, 56);
            locations[5] = new Point(112, 56);
            locations[6] = new Point(0, 112);
            locations[7] = new Point(56, 112);
            locations[8] = new Point(112, 112);
        }     

        public string Value { get; set; }

        public void SetSign(bool turn)
        {
            Value = turn ? TurnSign.XSign : TurnSign.OSign;
            this.Text = Value;
            this.Enabled = false;
        }

        public void Initialize(int position, EventHandler buttonClick, EventHandler buttonEnter, EventHandler buttonLeave)
        {
            Location = locations[position];
            Value = "";
            Name = Convert.ToString(position);
            Font = new System.Drawing.Font("Microsoft Sans Serif", 24.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            Size = new System.Drawing.Size(50, 50);
            UseVisualStyleBackColor = true;
            Click += new System.EventHandler(buttonClick);
            MouseEnter += new System.EventHandler(buttonEnter);
            MouseLeave += new System.EventHandler(buttonLeave);
            
        }

        public void Clear()
        {
            this.Enabled = true;
            this.ResetText();
<<<<<<< HEAD
            Value = "";
=======
            Value = TurnSign.EmptySign;
>>>>>>> b3be24030d16abd75c617e706166529b38e39a97
        }
    }
}