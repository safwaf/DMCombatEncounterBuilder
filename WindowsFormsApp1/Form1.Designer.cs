namespace WindowsFormsApp1
{
    partial class CombatEncounterBuilder
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
            this.MonsterSaveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.NameTextBox = new System.Windows.Forms.TextBox();
            this.SizeComboBox = new System.Windows.Forms.ComboBox();
            this.TypeComboBox = new System.Windows.Forms.ComboBox();
            this.AlignmentComboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.ChallengeRatingNumeric = new System.Windows.Forms.NumericUpDown();
            this.SpeedNumeric = new System.Windows.Forms.NumericUpDown();
            this.HitPointsNumeric = new System.Windows.Forms.NumericUpDown();
            this.ArmorClassNumeric = new System.Windows.Forms.NumericUpDown();
            this.label9 = new System.Windows.Forms.Label();
            this.StrengthNumeric = new System.Windows.Forms.NumericUpDown();
            this.DexterityNumeric = new System.Windows.Forms.NumericUpDown();
            this.CharismaNumeric = new System.Windows.Forms.NumericUpDown();
            this.WisdomNumeric = new System.Windows.Forms.NumericUpDown();
            this.IntelligenceNumeric = new System.Windows.Forms.NumericUpDown();
            this.ConstitutionNumeric = new System.Windows.Forms.NumericUpDown();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.SelectedActionComboBox = new System.Windows.Forms.ComboBox();
            this.label15 = new System.Windows.Forms.Label();
            this.ActionTextBox = new System.Windows.Forms.TextBox();
            this.ActionAddButton = new System.Windows.Forms.Button();
            this.ActionDescriptionTextBox = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.SelectedActionRemoveButton = new System.Windows.Forms.Button();
            this.SelectedActionDescriptionTextBox = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.NotesTextBox = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.SaveCreatureButton = new System.Windows.Forms.Button();
            this.IncompleteFormLabel = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.EncounterAddCreatureButton = new System.Windows.Forms.Button();
            this.EncounterCreaturesComboBox = new System.Windows.Forms.ComboBox();
            this.EncounterNameTextBox = new System.Windows.Forms.TextBox();
            this.EncounterDescriptionTextBox = new System.Windows.Forms.TextBox();
            this.SaveEncounterButton = new System.Windows.Forms.Button();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.EncounterLootTextBox = new System.Windows.Forms.TextBox();
            this.label24 = new System.Windows.Forms.Label();
            this.EncounterCreatureNameTextBox = new System.Windows.Forms.TextBox();
            this.EncounterRemoveCreatureButton = new System.Windows.Forms.Button();
            this.EncounterCreatureListView = new System.Windows.Forms.ListView();
            this.CreatureType = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Name = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            ((System.ComponentModel.ISupportInitialize)(this.ChallengeRatingNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SpeedNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.HitPointsNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ArmorClassNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.StrengthNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DexterityNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CharismaNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.WisdomNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.IntelligenceNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ConstitutionNumeric)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // NameTextBox
            // 
            this.NameTextBox.Location = new System.Drawing.Point(71, 13);
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.Size = new System.Drawing.Size(168, 20);
            this.NameTextBox.TabIndex = 0;
            // 
            // SizeComboBox
            // 
            this.SizeComboBox.FormattingEnabled = true;
            this.SizeComboBox.Items.AddRange(new object[] {
            "Tiny",
            "Small",
            "Medium",
            "Large",
            "Huge",
            "Gargantuan"});
            this.SizeComboBox.Location = new System.Drawing.Point(71, 40);
            this.SizeComboBox.Name = "SizeComboBox";
            this.SizeComboBox.Size = new System.Drawing.Size(168, 21);
            this.SizeComboBox.TabIndex = 1;
            // 
            // TypeComboBox
            // 
            this.TypeComboBox.FormattingEnabled = true;
            this.TypeComboBox.Items.AddRange(new object[] {
            "Aberration",
            "Beast",
            "Celestial",
            "Construct",
            "Dragon",
            "Elemental",
            "Fey",
            "Fiend",
            "Giant",
            "Humanoid",
            "Monstrosity",
            "Ooze",
            "Plant",
            "Undead",
            "Other"});
            this.TypeComboBox.Location = new System.Drawing.Point(71, 67);
            this.TypeComboBox.Name = "TypeComboBox";
            this.TypeComboBox.Size = new System.Drawing.Size(168, 21);
            this.TypeComboBox.TabIndex = 2;
            // 
            // AlignmentComboBox
            // 
            this.AlignmentComboBox.FormattingEnabled = true;
            this.AlignmentComboBox.Items.AddRange(new object[] {
            "Unaligned",
            "Lawful Good",
            "Neutral Good",
            "Chaotic Good",
            "Lawful Neutral",
            "True Neutral",
            "Chaotic Neutral",
            "Lawful Evil",
            "Neutral Evil",
            "Chaotic Evil"});
            this.AlignmentComboBox.Location = new System.Drawing.Point(71, 94);
            this.AlignmentComboBox.Name = "AlignmentComboBox";
            this.AlignmentComboBox.Size = new System.Drawing.Size(168, 21);
            this.AlignmentComboBox.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Size";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Type";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 97);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Alignment";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(319, 16);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Armor Class";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(319, 44);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "Hit Points";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(319, 71);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(38, 13);
            this.label7.TabIndex = 10;
            this.label7.Text = "Speed";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(319, 98);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(88, 13);
            this.label8.TabIndex = 11;
            this.label8.Text = "Challenge Rating";
            // 
            // ChallengeRatingNumeric
            // 
            this.ChallengeRatingNumeric.Location = new System.Drawing.Point(414, 95);
            this.ChallengeRatingNumeric.Name = "ChallengeRatingNumeric";
            this.ChallengeRatingNumeric.Size = new System.Drawing.Size(53, 20);
            this.ChallengeRatingNumeric.TabIndex = 12;
            // 
            // SpeedNumeric
            // 
            this.SpeedNumeric.Location = new System.Drawing.Point(414, 68);
            this.SpeedNumeric.Name = "SpeedNumeric";
            this.SpeedNumeric.Size = new System.Drawing.Size(53, 20);
            this.SpeedNumeric.TabIndex = 13;
            this.SpeedNumeric.Value = new decimal(new int[] {
            30,
            0,
            0,
            0});
            // 
            // HitPointsNumeric
            // 
            this.HitPointsNumeric.Location = new System.Drawing.Point(414, 41);
            this.HitPointsNumeric.Name = "HitPointsNumeric";
            this.HitPointsNumeric.Size = new System.Drawing.Size(53, 20);
            this.HitPointsNumeric.TabIndex = 14;
            // 
            // ArmorClassNumeric
            // 
            this.ArmorClassNumeric.Location = new System.Drawing.Point(414, 14);
            this.ArmorClassNumeric.Name = "ArmorClassNumeric";
            this.ArmorClassNumeric.Size = new System.Drawing.Size(53, 20);
            this.ArmorClassNumeric.TabIndex = 15;
            this.ArmorClassNumeric.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(12, 123);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(29, 13);
            this.label9.TabIndex = 16;
            this.label9.Text = "STR";
            // 
            // StrengthNumeric
            // 
            this.StrengthNumeric.Location = new System.Drawing.Point(47, 121);
            this.StrengthNumeric.Name = "StrengthNumeric";
            this.StrengthNumeric.Size = new System.Drawing.Size(36, 20);
            this.StrengthNumeric.TabIndex = 17;
            this.StrengthNumeric.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // DexterityNumeric
            // 
            this.DexterityNumeric.Location = new System.Drawing.Point(124, 121);
            this.DexterityNumeric.Name = "DexterityNumeric";
            this.DexterityNumeric.Size = new System.Drawing.Size(36, 20);
            this.DexterityNumeric.TabIndex = 18;
            this.DexterityNumeric.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // CharismaNumeric
            // 
            this.CharismaNumeric.Location = new System.Drawing.Point(431, 121);
            this.CharismaNumeric.Name = "CharismaNumeric";
            this.CharismaNumeric.Size = new System.Drawing.Size(36, 20);
            this.CharismaNumeric.TabIndex = 19;
            this.CharismaNumeric.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // WisdomNumeric
            // 
            this.WisdomNumeric.Location = new System.Drawing.Point(354, 121);
            this.WisdomNumeric.Name = "WisdomNumeric";
            this.WisdomNumeric.Size = new System.Drawing.Size(36, 20);
            this.WisdomNumeric.TabIndex = 20;
            this.WisdomNumeric.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // IntelligenceNumeric
            // 
            this.IntelligenceNumeric.Location = new System.Drawing.Point(278, 121);
            this.IntelligenceNumeric.Name = "IntelligenceNumeric";
            this.IntelligenceNumeric.Size = new System.Drawing.Size(36, 20);
            this.IntelligenceNumeric.TabIndex = 21;
            this.IntelligenceNumeric.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // ConstitutionNumeric
            // 
            this.ConstitutionNumeric.Location = new System.Drawing.Point(201, 121);
            this.ConstitutionNumeric.Name = "ConstitutionNumeric";
            this.ConstitutionNumeric.Size = new System.Drawing.Size(36, 20);
            this.ConstitutionNumeric.TabIndex = 22;
            this.ConstitutionNumeric.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(89, 123);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(29, 13);
            this.label10.TabIndex = 23;
            this.label10.Text = "DEX";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(166, 123);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(30, 13);
            this.label11.TabIndex = 24;
            this.label11.Text = "CON";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(243, 123);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(25, 13);
            this.label12.TabIndex = 25;
            this.label12.Text = "INT";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(319, 123);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(28, 13);
            this.label13.TabIndex = 26;
            this.label13.Text = "WIS";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(396, 123);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(29, 13);
            this.label14.TabIndex = 27;
            this.label14.Text = "CHA";
            // 
            // SelectedActionComboBox
            // 
            this.SelectedActionComboBox.FormattingEnabled = true;
            this.SelectedActionComboBox.Location = new System.Drawing.Point(15, 234);
            this.SelectedActionComboBox.Name = "SelectedActionComboBox";
            this.SelectedActionComboBox.Size = new System.Drawing.Size(100, 21);
            this.SelectedActionComboBox.TabIndex = 28;
            this.SelectedActionComboBox.SelectedIndexChanged += new System.EventHandler(this.SelectedActionComboBox_SelectedIndexChanged);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(12, 144);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(37, 13);
            this.label15.TabIndex = 29;
            this.label15.Text = "Action";
            // 
            // ActionTextBox
            // 
            this.ActionTextBox.Location = new System.Drawing.Point(15, 161);
            this.ActionTextBox.Name = "ActionTextBox";
            this.ActionTextBox.Size = new System.Drawing.Size(100, 20);
            this.ActionTextBox.TabIndex = 30;
            // 
            // ActionAddButton
            // 
            this.ActionAddButton.Location = new System.Drawing.Point(15, 188);
            this.ActionAddButton.Name = "ActionAddButton";
            this.ActionAddButton.Size = new System.Drawing.Size(100, 23);
            this.ActionAddButton.TabIndex = 31;
            this.ActionAddButton.Text = "Add Action";
            this.ActionAddButton.UseVisualStyleBackColor = true;
            this.ActionAddButton.Click += new System.EventHandler(this.ActionAddButton_Click);
            // 
            // ActionDescriptionTextBox
            // 
            this.ActionDescriptionTextBox.Location = new System.Drawing.Point(121, 161);
            this.ActionDescriptionTextBox.Multiline = true;
            this.ActionDescriptionTextBox.Name = "ActionDescriptionTextBox";
            this.ActionDescriptionTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.ActionDescriptionTextBox.Size = new System.Drawing.Size(344, 50);
            this.ActionDescriptionTextBox.TabIndex = 32;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(121, 144);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(60, 13);
            this.label16.TabIndex = 33;
            this.label16.Text = "Description";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(15, 218);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(56, 13);
            this.label17.TabIndex = 34;
            this.label17.Text = "Action List";
            // 
            // SelectedActionRemoveButton
            // 
            this.SelectedActionRemoveButton.Location = new System.Drawing.Point(15, 262);
            this.SelectedActionRemoveButton.Name = "SelectedActionRemoveButton";
            this.SelectedActionRemoveButton.Size = new System.Drawing.Size(100, 23);
            this.SelectedActionRemoveButton.TabIndex = 35;
            this.SelectedActionRemoveButton.Text = "Remove Action";
            this.SelectedActionRemoveButton.UseVisualStyleBackColor = true;
            // 
            // SelectedActionDescriptionTextBox
            // 
            this.SelectedActionDescriptionTextBox.Location = new System.Drawing.Point(121, 234);
            this.SelectedActionDescriptionTextBox.Multiline = true;
            this.SelectedActionDescriptionTextBox.Name = "SelectedActionDescriptionTextBox";
            this.SelectedActionDescriptionTextBox.ReadOnly = true;
            this.SelectedActionDescriptionTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.SelectedActionDescriptionTextBox.Size = new System.Drawing.Size(344, 50);
            this.SelectedActionDescriptionTextBox.TabIndex = 36;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(118, 218);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(60, 13);
            this.label18.TabIndex = 37;
            this.label18.Text = "Description";
            // 
            // NotesTextBox
            // 
            this.NotesTextBox.Location = new System.Drawing.Point(15, 306);
            this.NotesTextBox.Multiline = true;
            this.NotesTextBox.Name = "NotesTextBox";
            this.NotesTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.NotesTextBox.Size = new System.Drawing.Size(450, 50);
            this.NotesTextBox.TabIndex = 38;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(15, 288);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(64, 13);
            this.label19.TabIndex = 40;
            this.label19.Text = "Other Notes";
            // 
            // SaveCreatureButton
            // 
            this.SaveCreatureButton.Location = new System.Drawing.Point(15, 363);
            this.SaveCreatureButton.Name = "SaveCreatureButton";
            this.SaveCreatureButton.Size = new System.Drawing.Size(100, 23);
            this.SaveCreatureButton.TabIndex = 41;
            this.SaveCreatureButton.Text = "Save Creature";
            this.SaveCreatureButton.UseVisualStyleBackColor = true;
            this.SaveCreatureButton.Click += new System.EventHandler(this.SaveCreatureButton_Click);
            // 
            // IncompleteFormLabel
            // 
            this.IncompleteFormLabel.AutoSize = true;
            this.IncompleteFormLabel.ForeColor = System.Drawing.Color.Red;
            this.IncompleteFormLabel.Location = new System.Drawing.Point(121, 362);
            this.IncompleteFormLabel.Name = "IncompleteFormLabel";
            this.IncompleteFormLabel.Size = new System.Drawing.Size(0, 13);
            this.IncompleteFormLabel.TabIndex = 42;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Controls.Add(this.tabPage5);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(491, 423);
            this.tabControl1.TabIndex = 43;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.NotesTextBox);
            this.tabPage1.Controls.Add(this.NameTextBox);
            this.tabPage1.Controls.Add(this.SaveCreatureButton);
            this.tabPage1.Controls.Add(this.SizeComboBox);
            this.tabPage1.Controls.Add(this.label19);
            this.tabPage1.Controls.Add(this.TypeComboBox);
            this.tabPage1.Controls.Add(this.AlignmentComboBox);
            this.tabPage1.Controls.Add(this.label18);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.SelectedActionDescriptionTextBox);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.SelectedActionRemoveButton);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label17);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label16);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.ActionDescriptionTextBox);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.ActionAddButton);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.ActionTextBox);
            this.tabPage1.Controls.Add(this.label8);
            this.tabPage1.Controls.Add(this.label15);
            this.tabPage1.Controls.Add(this.ChallengeRatingNumeric);
            this.tabPage1.Controls.Add(this.SelectedActionComboBox);
            this.tabPage1.Controls.Add(this.SpeedNumeric);
            this.tabPage1.Controls.Add(this.label14);
            this.tabPage1.Controls.Add(this.HitPointsNumeric);
            this.tabPage1.Controls.Add(this.label13);
            this.tabPage1.Controls.Add(this.ArmorClassNumeric);
            this.tabPage1.Controls.Add(this.label12);
            this.tabPage1.Controls.Add(this.label9);
            this.tabPage1.Controls.Add(this.label11);
            this.tabPage1.Controls.Add(this.StrengthNumeric);
            this.tabPage1.Controls.Add(this.label10);
            this.tabPage1.Controls.Add(this.DexterityNumeric);
            this.tabPage1.Controls.Add(this.ConstitutionNumeric);
            this.tabPage1.Controls.Add(this.CharismaNumeric);
            this.tabPage1.Controls.Add(this.IntelligenceNumeric);
            this.tabPage1.Controls.Add(this.WisdomNumeric);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(483, 397);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Creature";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.EncounterRemoveCreatureButton);
            this.tabPage2.Controls.Add(this.EncounterCreatureNameTextBox);
            this.tabPage2.Controls.Add(this.label24);
            this.tabPage2.Controls.Add(this.EncounterLootTextBox);
            this.tabPage2.Controls.Add(this.label23);
            this.tabPage2.Controls.Add(this.label22);
            this.tabPage2.Controls.Add(this.label21);
            this.tabPage2.Controls.Add(this.label20);
            this.tabPage2.Controls.Add(this.EncounterAddCreatureButton);
            this.tabPage2.Controls.Add(this.EncounterCreaturesComboBox);
            this.tabPage2.Controls.Add(this.EncounterNameTextBox);
            this.tabPage2.Controls.Add(this.EncounterDescriptionTextBox);
            this.tabPage2.Controls.Add(this.SaveEncounterButton);
            this.tabPage2.Controls.Add(this.EncounterCreatureListView);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(483, 397);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Encounter";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // EncounterAddCreatureButton
            // 
            this.EncounterAddCreatureButton.Location = new System.Drawing.Point(372, 164);
            this.EncounterAddCreatureButton.Name = "EncounterAddCreatureButton";
            this.EncounterAddCreatureButton.Size = new System.Drawing.Size(105, 23);
            this.EncounterAddCreatureButton.TabIndex = 5;
            this.EncounterAddCreatureButton.Text = "Add Creature";
            this.EncounterAddCreatureButton.UseVisualStyleBackColor = true;
            this.EncounterAddCreatureButton.Click += new System.EventHandler(this.EncounterAddCreatureButton_Click);
            // 
            // EncounterCreaturesComboBox
            // 
            this.EncounterCreaturesComboBox.FormattingEnabled = true;
            this.EncounterCreaturesComboBox.Location = new System.Drawing.Point(122, 164);
            this.EncounterCreaturesComboBox.Name = "EncounterCreaturesComboBox";
            this.EncounterCreaturesComboBox.Size = new System.Drawing.Size(244, 21);
            this.EncounterCreaturesComboBox.TabIndex = 4;
            // 
            // EncounterNameTextBox
            // 
            this.EncounterNameTextBox.Location = new System.Drawing.Point(122, 10);
            this.EncounterNameTextBox.Name = "EncounterNameTextBox";
            this.EncounterNameTextBox.Size = new System.Drawing.Size(355, 20);
            this.EncounterNameTextBox.TabIndex = 3;
            // 
            // EncounterDescriptionTextBox
            // 
            this.EncounterDescriptionTextBox.Location = new System.Drawing.Point(122, 35);
            this.EncounterDescriptionTextBox.Multiline = true;
            this.EncounterDescriptionTextBox.Name = "EncounterDescriptionTextBox";
            this.EncounterDescriptionTextBox.Size = new System.Drawing.Size(355, 52);
            this.EncounterDescriptionTextBox.TabIndex = 2;
            // 
            // SaveEncounterButton
            // 
            this.SaveEncounterButton.Location = new System.Drawing.Point(6, 368);
            this.SaveEncounterButton.Name = "SaveEncounterButton";
            this.SaveEncounterButton.Size = new System.Drawing.Size(99, 23);
            this.SaveEncounterButton.TabIndex = 1;
            this.SaveEncounterButton.Text = "Save Encounter ";
            this.SaveEncounterButton.UseVisualStyleBackColor = true;
            this.SaveEncounterButton.Click += new System.EventHandler(this.SaveEncounterButton_Click);
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(483, 397);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Adventure";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // tabPage4
            // 
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(483, 397);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "tabPage4";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // tabPage5
            // 
            this.tabPage5.Location = new System.Drawing.Point(4, 22);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage5.Size = new System.Drawing.Size(483, 397);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "tabPage5";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(6, 13);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(90, 13);
            this.label20.TabIndex = 6;
            this.label20.Text = "Encounter Name:";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(6, 35);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(63, 13);
            this.label21.TabIndex = 7;
            this.label21.Text = "Description:";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(6, 164);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(52, 13);
            this.label22.TabIndex = 8;
            this.label22.Text = "Creatures";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(6, 96);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(71, 13);
            this.label23.TabIndex = 9;
            this.label23.Text = "Loot Reward:";
            // 
            // EncounterLootTextBox
            // 
            this.EncounterLootTextBox.Location = new System.Drawing.Point(122, 93);
            this.EncounterLootTextBox.Multiline = true;
            this.EncounterLootTextBox.Name = "EncounterLootTextBox";
            this.EncounterLootTextBox.Size = new System.Drawing.Size(355, 52);
            this.EncounterLootTextBox.TabIndex = 10;
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(6, 191);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(78, 13);
            this.label24.TabIndex = 11;
            this.label24.Text = "Creature Name";
            // 
            // EncounterCreatureNameTextBox
            // 
            this.EncounterCreatureNameTextBox.Location = new System.Drawing.Point(122, 188);
            this.EncounterCreatureNameTextBox.Name = "EncounterCreatureNameTextBox";
            this.EncounterCreatureNameTextBox.Size = new System.Drawing.Size(355, 20);
            this.EncounterCreatureNameTextBox.TabIndex = 12;
            // 
            // EncounterRemoveCreatureButton
            // 
            this.EncounterRemoveCreatureButton.Location = new System.Drawing.Point(372, 214);
            this.EncounterRemoveCreatureButton.Name = "EncounterRemoveCreatureButton";
            this.EncounterRemoveCreatureButton.Size = new System.Drawing.Size(105, 23);
            this.EncounterRemoveCreatureButton.TabIndex = 13;
            this.EncounterRemoveCreatureButton.Text = "Remove Creature";
            this.EncounterRemoveCreatureButton.UseVisualStyleBackColor = true;
            this.EncounterRemoveCreatureButton.Click += new System.EventHandler(this.EncounterRemoveCreatureButton_Click);
            // 
            // EncounterCreatureListView
            // 
            this.EncounterCreatureListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Name,
            this.CreatureType});
            this.EncounterCreatureListView.Location = new System.Drawing.Point(6, 214);
            this.EncounterCreatureListView.Name = "EncounterCreatureListView";
            this.EncounterCreatureListView.Size = new System.Drawing.Size(360, 148);
            this.EncounterCreatureListView.TabIndex = 0;
            this.EncounterCreatureListView.UseCompatibleStateImageBehavior = false;
            // 
            // CreatureType
            // 
            this.CreatureType.Text = "Creature";
            // 
            // Name
            // 
            this.Name.Text = "Name";
            // 
            // CombatEncounterBuilder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(515, 447);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.IncompleteFormLabel);
            //this.Name = "CombatEncounterBuilder";
            this.Text = "DM Tools - Combat Enounter Builder";
            ((System.ComponentModel.ISupportInitialize)(this.ChallengeRatingNumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SpeedNumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.HitPointsNumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ArmorClassNumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.StrengthNumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DexterityNumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CharismaNumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.WisdomNumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.IntelligenceNumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ConstitutionNumeric)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.SaveFileDialog MonsterSaveFileDialog;
        private System.Windows.Forms.TextBox NameTextBox;
        private System.Windows.Forms.ComboBox SizeComboBox;
        private System.Windows.Forms.ComboBox TypeComboBox;
        private System.Windows.Forms.ComboBox AlignmentComboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NumericUpDown ChallengeRatingNumeric;
        private System.Windows.Forms.NumericUpDown SpeedNumeric;
        private System.Windows.Forms.NumericUpDown HitPointsNumeric;
        private System.Windows.Forms.NumericUpDown ArmorClassNumeric;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.NumericUpDown StrengthNumeric;
        private System.Windows.Forms.NumericUpDown DexterityNumeric;
        private System.Windows.Forms.NumericUpDown CharismaNumeric;
        private System.Windows.Forms.NumericUpDown WisdomNumeric;
        private System.Windows.Forms.NumericUpDown IntelligenceNumeric;
        private System.Windows.Forms.NumericUpDown ConstitutionNumeric;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.ComboBox SelectedActionComboBox;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox ActionTextBox;
        private System.Windows.Forms.Button ActionAddButton;
        private System.Windows.Forms.TextBox ActionDescriptionTextBox;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Button SelectedActionRemoveButton;
        private System.Windows.Forms.TextBox SelectedActionDescriptionTextBox;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox NotesTextBox;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Button SaveCreatureButton;
        private System.Windows.Forms.Label IncompleteFormLabel;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Button EncounterAddCreatureButton;
        private System.Windows.Forms.ComboBox EncounterCreaturesComboBox;
        private System.Windows.Forms.TextBox EncounterNameTextBox;
        private System.Windows.Forms.TextBox EncounterDescriptionTextBox;
        private System.Windows.Forms.Button SaveEncounterButton;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.TextBox EncounterLootTextBox;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.TextBox EncounterCreatureNameTextBox;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Button EncounterRemoveCreatureButton;
        private System.Windows.Forms.ListView EncounterCreatureListView;
        private System.Windows.Forms.ColumnHeader Name;
        private System.Windows.Forms.ColumnHeader CreatureType;
    }
}

