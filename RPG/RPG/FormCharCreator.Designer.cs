namespace RPG
{
    partial class FormCharCreator
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Lbl_CharName = new System.Windows.Forms.Label();
            this.Txt_CharName = new System.Windows.Forms.TextBox();
            this.Cbo_CharClass = new System.Windows.Forms.ComboBox();
            this.Lbl_CharClass = new System.Windows.Forms.Label();
            this.Btn_SaveChar = new System.Windows.Forms.Button();
            this.Lbl_Strength = new System.Windows.Forms.Label();
            this.Lbl_Dexterity = new System.Windows.Forms.Label();
            this.Lbl_Magic = new System.Windows.Forms.Label();
            this.Lbl_Spirit = new System.Windows.Forms.Label();
            this.Lbl_StrValue = new System.Windows.Forms.Label();
            this.Lbl_DexValue = new System.Windows.Forms.Label();
            this.Lbl_MagValue = new System.Windows.Forms.Label();
            this.Lbl_SprValue = new System.Windows.Forms.Label();
            this.Lbl_HealthValue = new System.Windows.Forms.Label();
            this.Lbl_Health = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Lbl_CharName
            // 
            this.Lbl_CharName.AutoSize = true;
            this.Lbl_CharName.Location = new System.Drawing.Point(13, 13);
            this.Lbl_CharName.Name = "Lbl_CharName";
            this.Lbl_CharName.Size = new System.Drawing.Size(84, 13);
            this.Lbl_CharName.TabIndex = 0;
            this.Lbl_CharName.Text = "Character Name";
            this.Lbl_CharName.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // Txt_CharName
            // 
            this.Txt_CharName.Location = new System.Drawing.Point(103, 10);
            this.Txt_CharName.Name = "Txt_CharName";
            this.Txt_CharName.Size = new System.Drawing.Size(100, 20);
            this.Txt_CharName.TabIndex = 1;
            // 
            // Cbo_CharClass
            // 
            this.Cbo_CharClass.FormattingEnabled = true;
            this.Cbo_CharClass.Items.AddRange(new object[] {
            "Warrior",
            "Mage",
            "Rogue",
            "Priest"});
            this.Cbo_CharClass.Location = new System.Drawing.Point(100, 52);
            this.Cbo_CharClass.Name = "Cbo_CharClass";
            this.Cbo_CharClass.Size = new System.Drawing.Size(121, 21);
            this.Cbo_CharClass.TabIndex = 2;
            this.Cbo_CharClass.SelectedIndexChanged += new System.EventHandler(this.Cbo_CharClass_SelectedIndexChanged);
            // 
            // Lbl_CharClass
            // 
            this.Lbl_CharClass.AutoSize = true;
            this.Lbl_CharClass.Location = new System.Drawing.Point(13, 55);
            this.Lbl_CharClass.Name = "Lbl_CharClass";
            this.Lbl_CharClass.Size = new System.Drawing.Size(81, 13);
            this.Lbl_CharClass.TabIndex = 3;
            this.Lbl_CharClass.Text = "Character Class";
            // 
            // Btn_SaveChar
            // 
            this.Btn_SaveChar.Location = new System.Drawing.Point(12, 258);
            this.Btn_SaveChar.Name = "Btn_SaveChar";
            this.Btn_SaveChar.Size = new System.Drawing.Size(106, 43);
            this.Btn_SaveChar.TabIndex = 4;
            this.Btn_SaveChar.Text = "Save Character";
            this.Btn_SaveChar.UseVisualStyleBackColor = true;
            this.Btn_SaveChar.Click += new System.EventHandler(this.Btn_SaveChar_Click);
            // 
            // Lbl_Strength
            // 
            this.Lbl_Strength.AutoSize = true;
            this.Lbl_Strength.Location = new System.Drawing.Point(16, 130);
            this.Lbl_Strength.Name = "Lbl_Strength";
            this.Lbl_Strength.Size = new System.Drawing.Size(50, 13);
            this.Lbl_Strength.TabIndex = 5;
            this.Lbl_Strength.Text = "Strength:";
            // 
            // Lbl_Dexterity
            // 
            this.Lbl_Dexterity.AutoSize = true;
            this.Lbl_Dexterity.Location = new System.Drawing.Point(16, 156);
            this.Lbl_Dexterity.Name = "Lbl_Dexterity";
            this.Lbl_Dexterity.Size = new System.Drawing.Size(51, 13);
            this.Lbl_Dexterity.TabIndex = 6;
            this.Lbl_Dexterity.Text = "Dexterity:";
            // 
            // Lbl_Magic
            // 
            this.Lbl_Magic.AutoSize = true;
            this.Lbl_Magic.Location = new System.Drawing.Point(16, 183);
            this.Lbl_Magic.Name = "Lbl_Magic";
            this.Lbl_Magic.Size = new System.Drawing.Size(36, 13);
            this.Lbl_Magic.TabIndex = 7;
            this.Lbl_Magic.Text = "Magic";
            // 
            // Lbl_Spirit
            // 
            this.Lbl_Spirit.AutoSize = true;
            this.Lbl_Spirit.Location = new System.Drawing.Point(16, 210);
            this.Lbl_Spirit.Name = "Lbl_Spirit";
            this.Lbl_Spirit.Size = new System.Drawing.Size(33, 13);
            this.Lbl_Spirit.TabIndex = 8;
            this.Lbl_Spirit.Text = "Spirit:";
            // 
            // Lbl_StrValue
            // 
            this.Lbl_StrValue.AutoSize = true;
            this.Lbl_StrValue.Location = new System.Drawing.Point(100, 130);
            this.Lbl_StrValue.Name = "Lbl_StrValue";
            this.Lbl_StrValue.Size = new System.Drawing.Size(0, 13);
            this.Lbl_StrValue.TabIndex = 9;
            // 
            // Lbl_dexValue
            // 
            this.Lbl_DexValue.AutoSize = true;
            this.Lbl_DexValue.Location = new System.Drawing.Point(100, 156);
            this.Lbl_DexValue.Name = "Lbl_dexValue";
            this.Lbl_DexValue.Size = new System.Drawing.Size(0, 13);
            this.Lbl_DexValue.TabIndex = 10;
            // 
            // Lbl_MagValue
            // 
            this.Lbl_MagValue.AutoSize = true;
            this.Lbl_MagValue.Location = new System.Drawing.Point(100, 183);
            this.Lbl_MagValue.Name = "Lbl_MagValue";
            this.Lbl_MagValue.Size = new System.Drawing.Size(0, 13);
            this.Lbl_MagValue.TabIndex = 11;
            // 
            // Lbl_SprValue
            // 
            this.Lbl_SprValue.AutoSize = true;
            this.Lbl_SprValue.Location = new System.Drawing.Point(100, 210);
            this.Lbl_SprValue.Name = "Lbl_SprValue";
            this.Lbl_SprValue.Size = new System.Drawing.Size(0, 13);
            this.Lbl_SprValue.TabIndex = 12;
            // 
            // Lbl_HealthValue
            // 
            this.Lbl_HealthValue.AutoSize = true;
            this.Lbl_HealthValue.Location = new System.Drawing.Point(100, 102);
            this.Lbl_HealthValue.Name = "Lbl_HealthValue";
            this.Lbl_HealthValue.Size = new System.Drawing.Size(0, 13);
            this.Lbl_HealthValue.TabIndex = 14;
            // 
            // Lbl_Health
            // 
            this.Lbl_Health.AutoSize = true;
            this.Lbl_Health.Location = new System.Drawing.Point(16, 102);
            this.Lbl_Health.Name = "Lbl_Health";
            this.Lbl_Health.Size = new System.Drawing.Size(41, 13);
            this.Lbl_Health.TabIndex = 13;
            this.Lbl_Health.Text = "Health:";
            // 
            // FormCharCreator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(280, 313);
            this.Controls.Add(this.Lbl_HealthValue);
            this.Controls.Add(this.Lbl_Health);
            this.Controls.Add(this.Lbl_SprValue);
            this.Controls.Add(this.Lbl_MagValue);
            this.Controls.Add(this.Lbl_DexValue);
            this.Controls.Add(this.Lbl_StrValue);
            this.Controls.Add(this.Lbl_Spirit);
            this.Controls.Add(this.Lbl_Magic);
            this.Controls.Add(this.Lbl_Dexterity);
            this.Controls.Add(this.Lbl_Strength);
            this.Controls.Add(this.Btn_SaveChar);
            this.Controls.Add(this.Lbl_CharClass);
            this.Controls.Add(this.Cbo_CharClass);
            this.Controls.Add(this.Txt_CharName);
            this.Controls.Add(this.Lbl_CharName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FormCharCreator";
            this.Text = "Create Your Character";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Lbl_CharName;
        private System.Windows.Forms.TextBox Txt_CharName;
        private System.Windows.Forms.ComboBox Cbo_CharClass;
        private System.Windows.Forms.Label Lbl_CharClass;
        private System.Windows.Forms.Button Btn_SaveChar;
        private System.Windows.Forms.Label Lbl_Strength;
        private System.Windows.Forms.Label Lbl_Dexterity;
        private System.Windows.Forms.Label Lbl_Magic;
        private System.Windows.Forms.Label Lbl_Spirit;
        private System.Windows.Forms.Label Lbl_StrValue;
        private System.Windows.Forms.Label Lbl_DexValue;
        private System.Windows.Forms.Label Lbl_MagValue;
        private System.Windows.Forms.Label Lbl_SprValue;
        private System.Windows.Forms.Label Lbl_HealthValue;
        private System.Windows.Forms.Label Lbl_Health;
    }
}