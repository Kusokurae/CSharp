using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace Ultimate_TTT.Model
{
    class FieldHide : Label
    {
        static Point[] locations = new Point[9];
        static FieldHide()
        {
            locations[0] = new Point(17, 42);
            locations[1] = new Point(198, 42);
            locations[2] = new Point(379, 42);
            locations[3] = new Point(17, 226);
            locations[4] = new Point(198, 226);
            locations[5] = new Point(379, 226);
            locations[6] = new Point(17, 410);
            locations[7] = new Point(198, 410);
            locations[8] = new Point(379, 410);
        }

        public void Initialize(int position)
        {
            AutoSize = true;
            BackColor = System.Drawing.Color.White;
            Enabled = true;
            Font = new System.Drawing.Font("Microsoft Sans Serif", 111.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            Location = locations[position];
            Name = Convert.ToString(position);
            Size = new System.Drawing.Size(172, 169);
            TabIndex = 2;
            Text = "";
            Visible = false;
        }

        public void Clear()
        {
            this.Visible = false;
<<<<<<< HEAD
            this.Text = "";
=======
            this.Text = TurnSign.EmptySign;
>>>>>>> b3be24030d16abd75c617e706166529b38e39a97
        }
    }
}
