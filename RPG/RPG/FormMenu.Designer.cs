namespace RPG
{
    partial class Form_Menu
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
            this.Lbl_GameTitle = new System.Windows.Forms.Label();
            this.Btn_CreateChar = new System.Windows.Forms.Button();
            this.Btn_LoadGame = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Lbl_GameTitle
            // 
            this.Lbl_GameTitle.AutoSize = true;
            this.Lbl_GameTitle.BackColor = System.Drawing.Color.Transparent;
            this.Lbl_GameTitle.Font = new System.Drawing.Font("Monotype Corsiva", 26.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Lbl_GameTitle.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.Lbl_GameTitle.Location = new System.Drawing.Point(184, 36);
            this.Lbl_GameTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lbl_GameTitle.Name = "Lbl_GameTitle";
            this.Lbl_GameTitle.Size = new System.Drawing.Size(329, 53);
            this.Lbl_GameTitle.TabIndex = 0;
            this.Lbl_GameTitle.Text = "Name PlaceHolder";
            this.Lbl_GameTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Btn_CreateChar
            // 
            this.Btn_CreateChar.BackColor = System.Drawing.Color.AliceBlue;
            this.Btn_CreateChar.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.Btn_CreateChar.Location = new System.Drawing.Point(193, 213);
            this.Btn_CreateChar.Margin = new System.Windows.Forms.Padding(4);
            this.Btn_CreateChar.Name = "Btn_CreateChar";
            this.Btn_CreateChar.Size = new System.Drawing.Size(122, 53);
            this.Btn_CreateChar.TabIndex = 1;
            this.Btn_CreateChar.Text = "Create Character";
            this.Btn_CreateChar.UseVisualStyleBackColor = false;
            this.Btn_CreateChar.Click += new System.EventHandler(this.Btn_CreateChar_Click);
            // 
            // Btn_LoadGame
            // 
            this.Btn_LoadGame.BackColor = System.Drawing.Color.AliceBlue;
            this.Btn_LoadGame.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.Btn_LoadGame.Location = new System.Drawing.Point(391, 213);
            this.Btn_LoadGame.Margin = new System.Windows.Forms.Padding(4);
            this.Btn_LoadGame.Name = "Btn_LoadGame";
            this.Btn_LoadGame.Size = new System.Drawing.Size(122, 53);
            this.Btn_LoadGame.TabIndex = 2;
            this.Btn_LoadGame.Text = "Load Game";
            this.Btn_LoadGame.UseVisualStyleBackColor = false;
            this.Btn_LoadGame.Click += new System.EventHandler(this.Btn_LoadGame_Click);
            // 
            // Form_Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkBlue;
            this.BackgroundImage = global::RPG.Properties.Resources.MenuBackground;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(700, 436);
            this.Controls.Add(this.Btn_LoadGame);
            this.Controls.Add(this.Btn_CreateChar);
            this.Controls.Add(this.Lbl_GameTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form_Menu";
            this.Text = "Main Menu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Lbl_GameTitle;
        private System.Windows.Forms.Button Btn_CreateChar;
        private System.Windows.Forms.Button Btn_LoadGame;
    }
}

