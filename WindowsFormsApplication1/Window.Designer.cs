namespace WindowsFormsApplication1
{
    partial class Window
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.LblExperience = new System.Windows.Forms.Label();
            this.LblGold = new System.Windows.Forms.Label();
            this.LblHitPoints = new System.Windows.Forms.Label();
            this.LblLevel = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cboWeapons = new System.Windows.Forms.ComboBox();
            this.cboPotions = new System.Windows.Forms.ComboBox();
            this.btnWest = new System.Windows.Forms.Button();
            this.btnUsePotion = new System.Windows.Forms.Button();
            this.btnSouth = new System.Windows.Forms.Button();
            this.btnEast = new System.Windows.Forms.Button();
            this.btnNorth = new System.Windows.Forms.Button();
            this.btnUseWeapon = new System.Windows.Forms.Button();
            this.rtbMessages = new System.Windows.Forms.RichTextBox();
            this.rtbLocation = new System.Windows.Forms.RichTextBox();
            this.dgvInventory = new System.Windows.Forms.DataGridView();
            this.dgvQuests = new System.Windows.Forms.DataGridView();
            this.Area = new System.Windows.Forms.Label();
            this.Strength = new System.Windows.Forms.Label();
            this.Magic = new System.Windows.Forms.Label();
            this.Defense = new System.Windows.Forms.Label();
            this.Dexerity = new System.Windows.Forms.Label();
            this.LblStrength = new System.Windows.Forms.Label();
            this.LblMagic = new System.Windows.Forms.Label();
            this.LblDefense = new System.Windows.Forms.Label();
            this.LblDexerity = new System.Windows.Forms.Label();
            this.DexAdd = new System.Windows.Forms.Button();
            this.DefAdd = new System.Windows.Forms.Button();
            this.MagAdd = new System.Windows.Forms.Button();
            this.StrAdd = new System.Windows.Forms.Button();
            this.lb = new System.Windows.Forms.Label();
            this.LblLevelPoints = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInventory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvQuests)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Hit Points:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Gold:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Experience:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 100);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Level:";
            // 
            // LblExperience
            // 
            this.LblExperience.AutoSize = true;
            this.LblExperience.Location = new System.Drawing.Point(97, 73);
            this.LblExperience.Name = "LblExperience";
            this.LblExperience.Size = new System.Drawing.Size(13, 13);
            this.LblExperience.TabIndex = 4;
            this.LblExperience.Text = "0";
            // 
            // LblGold
            // 
            this.LblGold.AutoSize = true;
            this.LblGold.Location = new System.Drawing.Point(97, 45);
            this.LblGold.Name = "LblGold";
            this.LblGold.Size = new System.Drawing.Size(13, 13);
            this.LblGold.TabIndex = 5;
            this.LblGold.Text = "0";
            // 
            // LblHitPoints
            // 
            this.LblHitPoints.AutoSize = true;
            this.LblHitPoints.Location = new System.Drawing.Point(97, 19);
            this.LblHitPoints.Name = "LblHitPoints";
            this.LblHitPoints.Size = new System.Drawing.Size(13, 13);
            this.LblHitPoints.TabIndex = 6;
            this.LblHitPoints.Text = "0";
            // 
            // LblLevel
            // 
            this.LblLevel.AutoSize = true;
            this.LblLevel.Location = new System.Drawing.Point(97, 99);
            this.LblLevel.Name = "LblLevel";
            this.LblLevel.Size = new System.Drawing.Size(13, 13);
            this.LblLevel.TabIndex = 7;
            this.LblLevel.Text = "0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(617, 531);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Select Action";
            // 
            // cboWeapons
            // 
            this.cboWeapons.FormattingEnabled = true;
            this.cboWeapons.Location = new System.Drawing.Point(369, 559);
            this.cboWeapons.Name = "cboWeapons";
            this.cboWeapons.Size = new System.Drawing.Size(121, 21);
            this.cboWeapons.TabIndex = 9;
            // 
            // cboPotions
            // 
            this.cboPotions.FormattingEnabled = true;
            this.cboPotions.Location = new System.Drawing.Point(369, 593);
            this.cboPotions.Name = "cboPotions";
            this.cboPotions.Size = new System.Drawing.Size(121, 21);
            this.cboPotions.TabIndex = 10;
            // 
            // btnWest
            // 
            this.btnWest.Location = new System.Drawing.Point(412, 457);
            this.btnWest.Name = "btnWest";
            this.btnWest.Size = new System.Drawing.Size(75, 23);
            this.btnWest.TabIndex = 11;
            this.btnWest.Text = "West";
            this.btnWest.UseVisualStyleBackColor = true;
            this.btnWest.Click += new System.EventHandler(this.btnWest_Click);
            // 
            // btnUsePotion
            // 
            this.btnUsePotion.Location = new System.Drawing.Point(620, 593);
            this.btnUsePotion.Name = "btnUsePotion";
            this.btnUsePotion.Size = new System.Drawing.Size(75, 23);
            this.btnUsePotion.TabIndex = 12;
            this.btnUsePotion.Text = "Use";
            this.btnUsePotion.UseVisualStyleBackColor = true;
            this.btnUsePotion.Click += new System.EventHandler(this.btnUsePotion_Click);
            // 
            // btnSouth
            // 
            this.btnSouth.Location = new System.Drawing.Point(493, 487);
            this.btnSouth.Name = "btnSouth";
            this.btnSouth.Size = new System.Drawing.Size(75, 23);
            this.btnSouth.TabIndex = 13;
            this.btnSouth.Text = "South";
            this.btnSouth.UseVisualStyleBackColor = true;
            this.btnSouth.Click += new System.EventHandler(this.btnSouth_Click);
            // 
            // btnEast
            // 
            this.btnEast.Location = new System.Drawing.Point(573, 457);
            this.btnEast.Name = "btnEast";
            this.btnEast.Size = new System.Drawing.Size(75, 23);
            this.btnEast.TabIndex = 14;
            this.btnEast.Text = "East";
            this.btnEast.UseVisualStyleBackColor = true;
            this.btnEast.Click += new System.EventHandler(this.btnEast_Click);
            // 
            // btnNorth
            // 
            this.btnNorth.Location = new System.Drawing.Point(493, 433);
            this.btnNorth.Name = "btnNorth";
            this.btnNorth.Size = new System.Drawing.Size(75, 23);
            this.btnNorth.TabIndex = 15;
            this.btnNorth.Text = "North";
            this.btnNorth.UseVisualStyleBackColor = true;
            this.btnNorth.Click += new System.EventHandler(this.btnNorth_Click);
            // 
            // btnUseWeapon
            // 
            this.btnUseWeapon.Location = new System.Drawing.Point(620, 559);
            this.btnUseWeapon.Name = "btnUseWeapon";
            this.btnUseWeapon.Size = new System.Drawing.Size(75, 23);
            this.btnUseWeapon.TabIndex = 16;
            this.btnUseWeapon.Text = "Use";
            this.btnUseWeapon.UseVisualStyleBackColor = true;
            this.btnUseWeapon.Click += new System.EventHandler(this.btnUseWeapon_Click);
            // 
            // rtbMessages
            // 
            this.rtbMessages.Location = new System.Drawing.Point(347, 130);
            this.rtbMessages.Name = "rtbMessages";
            this.rtbMessages.ReadOnly = true;
            this.rtbMessages.Size = new System.Drawing.Size(360, 130);
            this.rtbMessages.TabIndex = 17;
            this.rtbMessages.Text = "";
            // 
            // rtbLocation
            // 
            this.rtbLocation.Location = new System.Drawing.Point(347, 19);
            this.rtbLocation.Name = "rtbLocation";
            this.rtbLocation.ReadOnly = true;
            this.rtbLocation.Size = new System.Drawing.Size(360, 39);
            this.rtbLocation.TabIndex = 18;
            this.rtbLocation.Text = "";
            // 
            // dgvInventory
            // 
            this.dgvInventory.AllowUserToAddRows = false;
            this.dgvInventory.AllowUserToDeleteRows = false;
            this.dgvInventory.AllowUserToResizeColumns = false;
            this.dgvInventory.AllowUserToResizeRows = false;
            this.dgvInventory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInventory.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvInventory.Enabled = false;
            this.dgvInventory.Location = new System.Drawing.Point(16, 130);
            this.dgvInventory.MultiSelect = false;
            this.dgvInventory.Name = "dgvInventory";
            this.dgvInventory.ReadOnly = true;
            this.dgvInventory.RowHeadersVisible = false;
            this.dgvInventory.Size = new System.Drawing.Size(312, 309);
            this.dgvInventory.TabIndex = 19;
            // 
            // dgvQuests
            // 
            this.dgvQuests.AllowUserToAddRows = false;
            this.dgvQuests.AllowUserToDeleteRows = false;
            this.dgvQuests.AllowUserToResizeColumns = false;
            this.dgvQuests.AllowUserToResizeRows = false;
            this.dgvQuests.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvQuests.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvQuests.Enabled = false;
            this.dgvQuests.Location = new System.Drawing.Point(16, 446);
            this.dgvQuests.MultiSelect = false;
            this.dgvQuests.Name = "dgvQuests";
            this.dgvQuests.ReadOnly = true;
            this.dgvQuests.RowHeadersVisible = false;
            this.dgvQuests.Size = new System.Drawing.Size(312, 189);
            this.dgvQuests.TabIndex = 20;
            // 
            // Area
            // 
            this.Area.AutoSize = true;
            this.Area.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Area.Location = new System.Drawing.Point(490, 3);
            this.Area.Name = "Area";
            this.Area.Size = new System.Drawing.Size(54, 15);
            this.Area.TabIndex = 21;
            this.Area.Text = "Location";
            // 
            // Strength
            // 
            this.Strength.AutoSize = true;
            this.Strength.Location = new System.Drawing.Point(407, 298);
            this.Strength.Name = "Strength";
            this.Strength.Size = new System.Drawing.Size(50, 13);
            this.Strength.TabIndex = 22;
            this.Strength.Text = "Strength:";
            // 
            // Magic
            // 
            this.Magic.AutoSize = true;
            this.Magic.Location = new System.Drawing.Point(407, 325);
            this.Magic.Name = "Magic";
            this.Magic.Size = new System.Drawing.Size(39, 13);
            this.Magic.TabIndex = 23;
            this.Magic.Text = "Magic:";
            // 
            // Defense
            // 
            this.Defense.AutoSize = true;
            this.Defense.Location = new System.Drawing.Point(407, 353);
            this.Defense.Name = "Defense";
            this.Defense.Size = new System.Drawing.Size(50, 13);
            this.Defense.TabIndex = 24;
            this.Defense.Text = "Defense:";
            // 
            // Dexerity
            // 
            this.Dexerity.AutoSize = true;
            this.Dexerity.Location = new System.Drawing.Point(407, 378);
            this.Dexerity.Name = "Dexerity";
            this.Dexerity.Size = new System.Drawing.Size(48, 13);
            this.Dexerity.TabIndex = 25;
            this.Dexerity.Text = "Dexerity:";
            // 
            // LblStrength
            // 
            this.LblStrength.AutoSize = true;
            this.LblStrength.Location = new System.Drawing.Point(497, 299);
            this.LblStrength.Name = "LblStrength";
            this.LblStrength.Size = new System.Drawing.Size(13, 13);
            this.LblStrength.TabIndex = 26;
            this.LblStrength.Text = "0";
            // 
            // LblMagic
            // 
            this.LblMagic.AutoSize = true;
            this.LblMagic.Location = new System.Drawing.Point(497, 325);
            this.LblMagic.Name = "LblMagic";
            this.LblMagic.Size = new System.Drawing.Size(13, 13);
            this.LblMagic.TabIndex = 27;
            this.LblMagic.Text = "0";
            // 
            // LblDefense
            // 
            this.LblDefense.AutoSize = true;
            this.LblDefense.Location = new System.Drawing.Point(497, 352);
            this.LblDefense.Name = "LblDefense";
            this.LblDefense.Size = new System.Drawing.Size(13, 13);
            this.LblDefense.TabIndex = 28;
            this.LblDefense.Text = "0";
            // 
            // LblDexerity
            // 
            this.LblDexerity.AutoSize = true;
            this.LblDexerity.Location = new System.Drawing.Point(497, 378);
            this.LblDexerity.Name = "LblDexerity";
            this.LblDexerity.Size = new System.Drawing.Size(13, 13);
            this.LblDexerity.TabIndex = 29;
            this.LblDexerity.Text = "0";
            // 
            // DexAdd
            // 
            this.DexAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DexAdd.Location = new System.Drawing.Point(536, 372);
            this.DexAdd.Name = "DexAdd";
            this.DexAdd.Size = new System.Drawing.Size(32, 24);
            this.DexAdd.TabIndex = 30;
            this.DexAdd.Text = "+";
            this.DexAdd.UseVisualStyleBackColor = true;
            this.DexAdd.Click += new System.EventHandler(this.DexAdd_Click);
            // 
            // DefAdd
            // 
            this.DefAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DefAdd.Location = new System.Drawing.Point(536, 346);
            this.DefAdd.Name = "DefAdd";
            this.DefAdd.Size = new System.Drawing.Size(32, 24);
            this.DefAdd.TabIndex = 31;
            this.DefAdd.Text = "+";
            this.DefAdd.UseVisualStyleBackColor = true;
            this.DefAdd.Click += new System.EventHandler(this.DefAdd_Click);
            // 
            // MagAdd
            // 
            this.MagAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MagAdd.Location = new System.Drawing.Point(536, 319);
            this.MagAdd.Name = "MagAdd";
            this.MagAdd.Size = new System.Drawing.Size(32, 24);
            this.MagAdd.TabIndex = 32;
            this.MagAdd.Text = "+";
            this.MagAdd.UseVisualStyleBackColor = true;
            this.MagAdd.Click += new System.EventHandler(this.MagAdd_Click);
            // 
            // StrAdd
            // 
            this.StrAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StrAdd.Location = new System.Drawing.Point(536, 291);
            this.StrAdd.Name = "StrAdd";
            this.StrAdd.Size = new System.Drawing.Size(32, 24);
            this.StrAdd.TabIndex = 33;
            this.StrAdd.Text = "+";
            this.StrAdd.UseVisualStyleBackColor = true;
            this.StrAdd.Click += new System.EventHandler(this.StrAdd_Click);
            // 
            // lb
            // 
            this.lb.AutoSize = true;
            this.lb.Location = new System.Drawing.Point(407, 273);
            this.lb.Name = "lb";
            this.lb.Size = new System.Drawing.Size(65, 13);
            this.lb.TabIndex = 34;
            this.lb.Text = "Level Points";
            // 
            // LblLevelPoints
            // 
            this.LblLevelPoints.AutoSize = true;
            this.LblLevelPoints.Location = new System.Drawing.Point(497, 273);
            this.LblLevelPoints.Name = "LblLevelPoints";
            this.LblLevelPoints.Size = new System.Drawing.Size(13, 13);
            this.LblLevelPoints.TabIndex = 35;
            this.LblLevelPoints.Text = "0";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label6.Location = new System.Drawing.Point(396, 539);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 17);
            this.label6.TabIndex = 52;
            this.label6.Text = "Weapon";
            // 
            // Window
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(719, 651);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.LblLevelPoints);
            this.Controls.Add(this.lb);
            this.Controls.Add(this.StrAdd);
            this.Controls.Add(this.MagAdd);
            this.Controls.Add(this.DefAdd);
            this.Controls.Add(this.DexAdd);
            this.Controls.Add(this.LblDexerity);
            this.Controls.Add(this.LblDefense);
            this.Controls.Add(this.LblMagic);
            this.Controls.Add(this.LblStrength);
            this.Controls.Add(this.Dexerity);
            this.Controls.Add(this.Defense);
            this.Controls.Add(this.Magic);
            this.Controls.Add(this.Strength);
            this.Controls.Add(this.Area);
            this.Controls.Add(this.dgvQuests);
            this.Controls.Add(this.dgvInventory);
            this.Controls.Add(this.rtbLocation);
            this.Controls.Add(this.rtbMessages);
            this.Controls.Add(this.btnUseWeapon);
            this.Controls.Add(this.btnNorth);
            this.Controls.Add(this.btnEast);
            this.Controls.Add(this.btnSouth);
            this.Controls.Add(this.btnUsePotion);
            this.Controls.Add(this.btnWest);
            this.Controls.Add(this.cboPotions);
            this.Controls.Add(this.cboWeapons);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.LblLevel);
            this.Controls.Add(this.LblHitPoints);
            this.Controls.Add(this.LblGold);
            this.Controls.Add(this.LblExperience);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Window";
            this.Text = "RPG WINDOW";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Window_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.dgvInventory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvQuests)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label LblExperience;
        private System.Windows.Forms.Label LblGold;
        private System.Windows.Forms.Label LblHitPoints;
        private System.Windows.Forms.Label LblLevel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cboWeapons;
        private System.Windows.Forms.ComboBox cboPotions;
        private System.Windows.Forms.Button btnWest;
        private System.Windows.Forms.Button btnUsePotion;
        private System.Windows.Forms.Button btnSouth;
        private System.Windows.Forms.Button btnEast;
        private System.Windows.Forms.Button btnNorth;
        private System.Windows.Forms.Button btnUseWeapon;
        private System.Windows.Forms.RichTextBox rtbMessages;
        private System.Windows.Forms.RichTextBox rtbLocation;
        private System.Windows.Forms.DataGridView dgvInventory;
        private System.Windows.Forms.DataGridView dgvQuests;
        private System.Windows.Forms.Label Area;
        private System.Windows.Forms.Label Strength;
        private System.Windows.Forms.Label Magic;
        private System.Windows.Forms.Label Defense;
        private System.Windows.Forms.Label Dexerity;
        private System.Windows.Forms.Label LblStrength;
        private System.Windows.Forms.Label LblMagic;
        private System.Windows.Forms.Label LblDefense;
        private System.Windows.Forms.Label LblDexerity;
        private System.Windows.Forms.Button DexAdd;
        private System.Windows.Forms.Button DefAdd;
        private System.Windows.Forms.Button MagAdd;
        private System.Windows.Forms.Button StrAdd;
        private System.Windows.Forms.Label lb;
        private System.Windows.Forms.Label LblLevelPoints;
        private System.Windows.Forms.Label label6;
    }
}

