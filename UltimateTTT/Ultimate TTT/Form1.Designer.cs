namespace Ultimate_TTT
{
    partial class UTTT
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.Menu = new System.Windows.Forms.MenuStrip();
            this.newGameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TurnName = new System.Windows.Forms.Label();
            this.Menu.SuspendLayout();
            this.SuspendLayout();
            // 
            // Menu
            // 
<<<<<<< HEAD
=======
            this.Menu.ImageScalingSize = new System.Drawing.Size(24, 24);
>>>>>>> b3be24030d16abd75c617e706166529b38e39a97
            this.Menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newGameToolStripMenuItem});
            this.Menu.Location = new System.Drawing.Point(0, 0);
            this.Menu.Name = "Menu";
<<<<<<< HEAD
            this.Menu.Size = new System.Drawing.Size(567, 24);
=======
            this.Menu.Padding = new System.Windows.Forms.Padding(9, 3, 0, 3);
            this.Menu.Size = new System.Drawing.Size(850, 35);
>>>>>>> b3be24030d16abd75c617e706166529b38e39a97
            this.Menu.TabIndex = 0;
            this.Menu.Text = "menuStrip1";
            // 
            // newGameToolStripMenuItem
            // 
            this.newGameToolStripMenuItem.Name = "newGameToolStripMenuItem";
<<<<<<< HEAD
            this.newGameToolStripMenuItem.Size = new System.Drawing.Size(83, 20);
=======
            this.newGameToolStripMenuItem.Size = new System.Drawing.Size(121, 29);
>>>>>>> b3be24030d16abd75c617e706166529b38e39a97
            this.newGameToolStripMenuItem.Text = "Новая Игра";
            this.newGameToolStripMenuItem.Click += new System.EventHandler(this.New_game);
            // 
            // TurnName
            // 
            this.TurnName.AutoSize = true;
            this.TurnName.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
<<<<<<< HEAD
            this.TurnName.Location = new System.Drawing.Point(209, 633);
            this.TurnName.Name = "TurnName";
            this.TurnName.Size = new System.Drawing.Size(161, 55);
=======
            this.TurnName.Location = new System.Drawing.Point(303, 910);
            this.TurnName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.TurnName.Name = "TurnName";
            this.TurnName.Size = new System.Drawing.Size(237, 82);
>>>>>>> b3be24030d16abd75c617e706166529b38e39a97
            this.TurnName.TabIndex = 1;
            this.TurnName.Text = "Ход X";
            // 
            // UTTT
            // 
<<<<<<< HEAD
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(567, 697);
            this.Controls.Add(this.TurnName);
            this.Controls.Add(this.Menu);
            this.MainMenuStrip = this.Menu;
            this.Name = "UTTT";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
=======
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(850, 1050);
            this.Controls.Add(this.TurnName);
            this.Controls.Add(this.Menu);
            this.MainMenuStrip = this.Menu;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "UTTT";
            this.ShowIcon = false;
>>>>>>> b3be24030d16abd75c617e706166529b38e39a97
            this.Text = "Ultimate Tic-Tic-Toe";
            this.Menu.ResumeLayout(false);
            this.Menu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip Menu;
        private System.Windows.Forms.ToolStripMenuItem newGameToolStripMenuItem;
        private System.Windows.Forms.Label TurnName;
    }
}

