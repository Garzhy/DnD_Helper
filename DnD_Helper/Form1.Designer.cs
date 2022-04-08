
namespace DnD_Helper
{
    partial class DnD_Helper
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
            this.rdoAdvantage = new System.Windows.Forms.RadioButton();
            this.rdoDisadvantage = new System.Windows.Forms.RadioButton();
            this.grpModifiers = new System.Windows.Forms.GroupBox();
            this.rdoNone = new System.Windows.Forms.RadioButton();
            this.txtDiceNumber = new System.Windows.Forms.TextBox();
            this.cboDieSize = new System.Windows.Forms.ComboBox();
            this.btnRoll = new System.Windows.Forms.Button();
            this.lblPrompt = new System.Windows.Forms.Label();
            this.txtResult = new System.Windows.Forms.TextBox();
            this.lblResult = new System.Windows.Forms.Label();
            this.btnClearRoller = new System.Windows.Forms.Button();
            this.tbcTabs = new System.Windows.Forms.TabControl();
            this.tbpRoller = new System.Windows.Forms.TabPage();
            this.txtModifier = new System.Windows.Forms.TextBox();
            this.lblPlus = new System.Windows.Forms.Label();
            this.tbpHistory = new System.Windows.Forms.TabPage();
            this.btnClearHistory = new System.Windows.Forms.Button();
            this.lboHistory = new System.Windows.Forms.ListBox();
            this.tbpTracker = new System.Windows.Forms.TabPage();
            this.lblNotes = new System.Windows.Forms.Label();
            this.txtNotes = new System.Windows.Forms.TextBox();
            this.btnIncrementTracker4 = new System.Windows.Forms.Button();
            this.btnIncrementTracker3 = new System.Windows.Forms.Button();
            this.btnIncrementTracker2 = new System.Windows.Forms.Button();
            this.btnClearAllTrackers = new System.Windows.Forms.Button();
            this.btnClearTracker4 = new System.Windows.Forms.Button();
            this.btnClearTracker3 = new System.Windows.Forms.Button();
            this.btnClearTracker2 = new System.Windows.Forms.Button();
            this.btnClearTracker1 = new System.Windows.Forms.Button();
            this.btnDecrementTracker4 = new System.Windows.Forms.Button();
            this.btnDecrementTracker3 = new System.Windows.Forms.Button();
            this.btnDecrementTracker2 = new System.Windows.Forms.Button();
            this.btnDecrementTracker1 = new System.Windows.Forms.Button();
            this.btnIncrementTracker1 = new System.Windows.Forms.Button();
            this.txtTracker4Count = new System.Windows.Forms.TextBox();
            this.txtTracker3Count = new System.Windows.Forms.TextBox();
            this.txtTracker2Count = new System.Windows.Forms.TextBox();
            this.txtTracker1Count = new System.Windows.Forms.TextBox();
            this.ckbChecker3 = new System.Windows.Forms.CheckBox();
            this.ckbChecker2 = new System.Windows.Forms.CheckBox();
            this.ckbChecker1 = new System.Windows.Forms.CheckBox();
            this.txtChecker1 = new System.Windows.Forms.TextBox();
            this.txtChecker2 = new System.Windows.Forms.TextBox();
            this.txtChecker3 = new System.Windows.Forms.TextBox();
            this.txtTracker4 = new System.Windows.Forms.TextBox();
            this.txtTracker3 = new System.Windows.Forms.TextBox();
            this.txtTracker2 = new System.Windows.Forms.TextBox();
            this.txtTracker1 = new System.Windows.Forms.TextBox();
            this.grpModifiers.SuspendLayout();
            this.tbcTabs.SuspendLayout();
            this.tbpRoller.SuspendLayout();
            this.tbpHistory.SuspendLayout();
            this.tbpTracker.SuspendLayout();
            this.SuspendLayout();
            // 
            // rdoAdvantage
            // 
            this.rdoAdvantage.AutoSize = true;
            this.rdoAdvantage.Location = new System.Drawing.Point(6, 48);
            this.rdoAdvantage.Name = "rdoAdvantage";
            this.rdoAdvantage.Size = new System.Drawing.Size(97, 21);
            this.rdoAdvantage.TabIndex = 1;
            this.rdoAdvantage.Text = "Advantage";
            this.rdoAdvantage.UseVisualStyleBackColor = true;
            // 
            // rdoDisadvantage
            // 
            this.rdoDisadvantage.AutoSize = true;
            this.rdoDisadvantage.Location = new System.Drawing.Point(6, 75);
            this.rdoDisadvantage.Name = "rdoDisadvantage";
            this.rdoDisadvantage.Size = new System.Drawing.Size(116, 21);
            this.rdoDisadvantage.TabIndex = 2;
            this.rdoDisadvantage.Text = "Disadvantage";
            this.rdoDisadvantage.UseVisualStyleBackColor = true;
            // 
            // grpModifiers
            // 
            this.grpModifiers.Controls.Add(this.rdoNone);
            this.grpModifiers.Controls.Add(this.rdoAdvantage);
            this.grpModifiers.Controls.Add(this.rdoDisadvantage);
            this.grpModifiers.Location = new System.Drawing.Point(12, 53);
            this.grpModifiers.Name = "grpModifiers";
            this.grpModifiers.Size = new System.Drawing.Size(246, 105);
            this.grpModifiers.TabIndex = 2;
            this.grpModifiers.TabStop = false;
            this.grpModifiers.Text = "Modifiers";
            // 
            // rdoNone
            // 
            this.rdoNone.AutoSize = true;
            this.rdoNone.Checked = true;
            this.rdoNone.Location = new System.Drawing.Point(6, 21);
            this.rdoNone.Name = "rdoNone";
            this.rdoNone.Size = new System.Drawing.Size(63, 21);
            this.rdoNone.TabIndex = 0;
            this.rdoNone.TabStop = true;
            this.rdoNone.Text = "None";
            this.rdoNone.UseVisualStyleBackColor = true;
            // 
            // txtDiceNumber
            // 
            this.txtDiceNumber.Location = new System.Drawing.Point(12, 25);
            this.txtDiceNumber.Name = "txtDiceNumber";
            this.txtDiceNumber.Size = new System.Drawing.Size(69, 22);
            this.txtDiceNumber.TabIndex = 3;
            // 
            // cboDieSize
            // 
            this.cboDieSize.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboDieSize.FormattingEnabled = true;
            this.cboDieSize.Items.AddRange(new object[] {
            "d2",
            "d3",
            "d4",
            "d6",
            "d8",
            "d10",
            "d12",
            "d20",
            "d100"});
            this.cboDieSize.Location = new System.Drawing.Point(85, 25);
            this.cboDieSize.Name = "cboDieSize";
            this.cboDieSize.Size = new System.Drawing.Size(66, 24);
            this.cboDieSize.TabIndex = 4;
            // 
            // btnRoll
            // 
            this.btnRoll.Location = new System.Drawing.Point(264, 25);
            this.btnRoll.Name = "btnRoll";
            this.btnRoll.Size = new System.Drawing.Size(75, 23);
            this.btnRoll.TabIndex = 5;
            this.btnRoll.Text = "Roll!";
            this.btnRoll.UseVisualStyleBackColor = true;
            this.btnRoll.Click += new System.EventHandler(this.Roll_Dice);
            // 
            // lblPrompt
            // 
            this.lblPrompt.AutoSize = true;
            this.lblPrompt.Location = new System.Drawing.Point(9, 5);
            this.lblPrompt.Name = "lblPrompt";
            this.lblPrompt.Size = new System.Drawing.Size(36, 17);
            this.lblPrompt.TabIndex = 6;
            this.lblPrompt.Text = "Roll:";
            // 
            // txtResult
            // 
            this.txtResult.Location = new System.Drawing.Point(9, 181);
            this.txtResult.Name = "txtResult";
            this.txtResult.ReadOnly = true;
            this.txtResult.Size = new System.Drawing.Size(332, 22);
            this.txtResult.TabIndex = 7;
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Location = new System.Drawing.Point(9, 161);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(52, 17);
            this.lblResult.TabIndex = 8;
            this.lblResult.Text = "Result:";
            // 
            // btnClearRoller
            // 
            this.btnClearRoller.Location = new System.Drawing.Point(264, 54);
            this.btnClearRoller.Name = "btnClearRoller";
            this.btnClearRoller.Size = new System.Drawing.Size(75, 105);
            this.btnClearRoller.TabIndex = 9;
            this.btnClearRoller.Text = "Clear";
            this.btnClearRoller.UseVisualStyleBackColor = true;
            this.btnClearRoller.Click += new System.EventHandler(this.Clear_Roll_Page);
            // 
            // tbcTabs
            // 
            this.tbcTabs.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbcTabs.Controls.Add(this.tbpRoller);
            this.tbcTabs.Controls.Add(this.tbpHistory);
            this.tbcTabs.Controls.Add(this.tbpTracker);
            this.tbcTabs.Location = new System.Drawing.Point(2, 1);
            this.tbcTabs.Name = "tbcTabs";
            this.tbcTabs.SelectedIndex = 0;
            this.tbcTabs.Size = new System.Drawing.Size(357, 236);
            this.tbcTabs.TabIndex = 10;
            // 
            // tbpRoller
            // 
            this.tbpRoller.Controls.Add(this.txtModifier);
            this.tbpRoller.Controls.Add(this.lblPlus);
            this.tbpRoller.Controls.Add(this.btnClearRoller);
            this.tbpRoller.Controls.Add(this.grpModifiers);
            this.tbpRoller.Controls.Add(this.lblResult);
            this.tbpRoller.Controls.Add(this.txtDiceNumber);
            this.tbpRoller.Controls.Add(this.txtResult);
            this.tbpRoller.Controls.Add(this.cboDieSize);
            this.tbpRoller.Controls.Add(this.lblPrompt);
            this.tbpRoller.Controls.Add(this.btnRoll);
            this.tbpRoller.Location = new System.Drawing.Point(4, 25);
            this.tbpRoller.Name = "tbpRoller";
            this.tbpRoller.Padding = new System.Windows.Forms.Padding(3);
            this.tbpRoller.Size = new System.Drawing.Size(349, 207);
            this.tbpRoller.TabIndex = 0;
            this.tbpRoller.Text = "Roller";
            this.tbpRoller.UseVisualStyleBackColor = true;
            // 
            // txtModifier
            // 
            this.txtModifier.Location = new System.Drawing.Point(179, 25);
            this.txtModifier.Name = "txtModifier";
            this.txtModifier.Size = new System.Drawing.Size(79, 22);
            this.txtModifier.TabIndex = 11;
            // 
            // lblPlus
            // 
            this.lblPlus.AutoSize = true;
            this.lblPlus.Location = new System.Drawing.Point(157, 28);
            this.lblPlus.Name = "lblPlus";
            this.lblPlus.Size = new System.Drawing.Size(16, 17);
            this.lblPlus.TabIndex = 10;
            this.lblPlus.Text = "+";
            // 
            // tbpHistory
            // 
            this.tbpHistory.Controls.Add(this.btnClearHistory);
            this.tbpHistory.Controls.Add(this.lboHistory);
            this.tbpHistory.Location = new System.Drawing.Point(4, 25);
            this.tbpHistory.Name = "tbpHistory";
            this.tbpHistory.Padding = new System.Windows.Forms.Padding(3);
            this.tbpHistory.Size = new System.Drawing.Size(349, 207);
            this.tbpHistory.TabIndex = 1;
            this.tbpHistory.Text = "Roll History";
            this.tbpHistory.UseVisualStyleBackColor = true;
            // 
            // btnClearHistory
            // 
            this.btnClearHistory.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClearHistory.Location = new System.Drawing.Point(271, 52);
            this.btnClearHistory.Name = "btnClearHistory";
            this.btnClearHistory.Size = new System.Drawing.Size(75, 105);
            this.btnClearHistory.TabIndex = 1;
            this.btnClearHistory.Text = "Clear";
            this.btnClearHistory.UseVisualStyleBackColor = true;
            this.btnClearHistory.Click += new System.EventHandler(this.Clear_History_Page);
            // 
            // lboHistory
            // 
            this.lboHistory.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lboHistory.FormattingEnabled = true;
            this.lboHistory.ItemHeight = 16;
            this.lboHistory.Location = new System.Drawing.Point(3, 3);
            this.lboHistory.Name = "lboHistory";
            this.lboHistory.Size = new System.Drawing.Size(255, 196);
            this.lboHistory.TabIndex = 0;
            // 
            // tbpTracker
            // 
            this.tbpTracker.Controls.Add(this.lblNotes);
            this.tbpTracker.Controls.Add(this.txtNotes);
            this.tbpTracker.Controls.Add(this.btnIncrementTracker4);
            this.tbpTracker.Controls.Add(this.btnIncrementTracker3);
            this.tbpTracker.Controls.Add(this.btnIncrementTracker2);
            this.tbpTracker.Controls.Add(this.btnClearAllTrackers);
            this.tbpTracker.Controls.Add(this.btnClearTracker4);
            this.tbpTracker.Controls.Add(this.btnClearTracker3);
            this.tbpTracker.Controls.Add(this.btnClearTracker2);
            this.tbpTracker.Controls.Add(this.btnClearTracker1);
            this.tbpTracker.Controls.Add(this.btnDecrementTracker4);
            this.tbpTracker.Controls.Add(this.btnDecrementTracker3);
            this.tbpTracker.Controls.Add(this.btnDecrementTracker2);
            this.tbpTracker.Controls.Add(this.btnDecrementTracker1);
            this.tbpTracker.Controls.Add(this.btnIncrementTracker1);
            this.tbpTracker.Controls.Add(this.txtTracker4Count);
            this.tbpTracker.Controls.Add(this.txtTracker3Count);
            this.tbpTracker.Controls.Add(this.txtTracker2Count);
            this.tbpTracker.Controls.Add(this.txtTracker1Count);
            this.tbpTracker.Controls.Add(this.ckbChecker3);
            this.tbpTracker.Controls.Add(this.ckbChecker2);
            this.tbpTracker.Controls.Add(this.ckbChecker1);
            this.tbpTracker.Controls.Add(this.txtChecker1);
            this.tbpTracker.Controls.Add(this.txtChecker2);
            this.tbpTracker.Controls.Add(this.txtChecker3);
            this.tbpTracker.Controls.Add(this.txtTracker4);
            this.tbpTracker.Controls.Add(this.txtTracker3);
            this.tbpTracker.Controls.Add(this.txtTracker2);
            this.tbpTracker.Controls.Add(this.txtTracker1);
            this.tbpTracker.Location = new System.Drawing.Point(4, 25);
            this.tbpTracker.Name = "tbpTracker";
            this.tbpTracker.Size = new System.Drawing.Size(349, 207);
            this.tbpTracker.TabIndex = 2;
            this.tbpTracker.Text = "Tracker";
            this.tbpTracker.UseVisualStyleBackColor = true;
            // 
            // lblNotes
            // 
            this.lblNotes.AutoSize = true;
            this.lblNotes.Location = new System.Drawing.Point(143, 129);
            this.lblNotes.Name = "lblNotes";
            this.lblNotes.Size = new System.Drawing.Size(89, 17);
            this.lblNotes.TabIndex = 27;
            this.lblNotes.Text = "Other Notes:";
            // 
            // txtNotes
            // 
            this.txtNotes.Location = new System.Drawing.Point(146, 149);
            this.txtNotes.Multiline = true;
            this.txtNotes.Name = "txtNotes";
            this.txtNotes.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtNotes.Size = new System.Drawing.Size(140, 55);
            this.txtNotes.TabIndex = 26;
            // 
            // btnIncrementTracker4
            // 
            this.btnIncrementTracker4.Location = new System.Drawing.Point(146, 87);
            this.btnIncrementTracker4.Name = "btnIncrementTracker4";
            this.btnIncrementTracker4.Size = new System.Drawing.Size(56, 23);
            this.btnIncrementTracker4.TabIndex = 17;
            this.btnIncrementTracker4.Text = "Add";
            this.btnIncrementTracker4.UseVisualStyleBackColor = true;
            this.btnIncrementTracker4.Click += new System.EventHandler(this.Increment_Decrement);
            // 
            // btnIncrementTracker3
            // 
            this.btnIncrementTracker3.Location = new System.Drawing.Point(146, 59);
            this.btnIncrementTracker3.Name = "btnIncrementTracker3";
            this.btnIncrementTracker3.Size = new System.Drawing.Size(56, 23);
            this.btnIncrementTracker3.TabIndex = 12;
            this.btnIncrementTracker3.Text = "Add";
            this.btnIncrementTracker3.UseVisualStyleBackColor = true;
            this.btnIncrementTracker3.Click += new System.EventHandler(this.Increment_Decrement);
            // 
            // btnIncrementTracker2
            // 
            this.btnIncrementTracker2.Location = new System.Drawing.Point(146, 31);
            this.btnIncrementTracker2.Name = "btnIncrementTracker2";
            this.btnIncrementTracker2.Size = new System.Drawing.Size(56, 23);
            this.btnIncrementTracker2.TabIndex = 7;
            this.btnIncrementTracker2.Text = "Add";
            this.btnIncrementTracker2.UseVisualStyleBackColor = true;
            this.btnIncrementTracker2.Click += new System.EventHandler(this.Increment_Decrement);
            // 
            // btnClearAllTrackers
            // 
            this.btnClearAllTrackers.Location = new System.Drawing.Point(292, 126);
            this.btnClearAllTrackers.Name = "btnClearAllTrackers";
            this.btnClearAllTrackers.Size = new System.Drawing.Size(54, 78);
            this.btnClearAllTrackers.TabIndex = 19;
            this.btnClearAllTrackers.Text = "Clear All";
            this.btnClearAllTrackers.UseVisualStyleBackColor = true;
            this.btnClearAllTrackers.Click += new System.EventHandler(this.Clear_Tracker);
            // 
            // btnClearTracker4
            // 
            this.btnClearTracker4.Location = new System.Drawing.Point(292, 87);
            this.btnClearTracker4.Name = "btnClearTracker4";
            this.btnClearTracker4.Size = new System.Drawing.Size(54, 23);
            this.btnClearTracker4.TabIndex = 19;
            this.btnClearTracker4.Text = "Clear";
            this.btnClearTracker4.UseVisualStyleBackColor = true;
            this.btnClearTracker4.Click += new System.EventHandler(this.Clear_Tracker);
            // 
            // btnClearTracker3
            // 
            this.btnClearTracker3.Location = new System.Drawing.Point(292, 59);
            this.btnClearTracker3.Name = "btnClearTracker3";
            this.btnClearTracker3.Size = new System.Drawing.Size(54, 23);
            this.btnClearTracker3.TabIndex = 14;
            this.btnClearTracker3.Text = "Clear";
            this.btnClearTracker3.UseVisualStyleBackColor = true;
            this.btnClearTracker3.Click += new System.EventHandler(this.Clear_Tracker);
            // 
            // btnClearTracker2
            // 
            this.btnClearTracker2.Location = new System.Drawing.Point(292, 31);
            this.btnClearTracker2.Name = "btnClearTracker2";
            this.btnClearTracker2.Size = new System.Drawing.Size(54, 23);
            this.btnClearTracker2.TabIndex = 9;
            this.btnClearTracker2.Text = "Clear";
            this.btnClearTracker2.UseVisualStyleBackColor = true;
            this.btnClearTracker2.Click += new System.EventHandler(this.Clear_Tracker);
            // 
            // btnClearTracker1
            // 
            this.btnClearTracker1.Location = new System.Drawing.Point(292, 3);
            this.btnClearTracker1.Name = "btnClearTracker1";
            this.btnClearTracker1.Size = new System.Drawing.Size(54, 23);
            this.btnClearTracker1.TabIndex = 4;
            this.btnClearTracker1.Text = "Clear";
            this.btnClearTracker1.UseVisualStyleBackColor = true;
            this.btnClearTracker1.Click += new System.EventHandler(this.Clear_Tracker);
            // 
            // btnDecrementTracker4
            // 
            this.btnDecrementTracker4.Location = new System.Drawing.Point(208, 87);
            this.btnDecrementTracker4.Name = "btnDecrementTracker4";
            this.btnDecrementTracker4.Size = new System.Drawing.Size(78, 23);
            this.btnDecrementTracker4.TabIndex = 18;
            this.btnDecrementTracker4.Text = "Subtract";
            this.btnDecrementTracker4.UseVisualStyleBackColor = true;
            this.btnDecrementTracker4.Click += new System.EventHandler(this.Increment_Decrement);
            // 
            // btnDecrementTracker3
            // 
            this.btnDecrementTracker3.Location = new System.Drawing.Point(208, 59);
            this.btnDecrementTracker3.Name = "btnDecrementTracker3";
            this.btnDecrementTracker3.Size = new System.Drawing.Size(78, 23);
            this.btnDecrementTracker3.TabIndex = 13;
            this.btnDecrementTracker3.Text = "Subtract";
            this.btnDecrementTracker3.UseVisualStyleBackColor = true;
            this.btnDecrementTracker3.Click += new System.EventHandler(this.Increment_Decrement);
            // 
            // btnDecrementTracker2
            // 
            this.btnDecrementTracker2.Location = new System.Drawing.Point(208, 31);
            this.btnDecrementTracker2.Name = "btnDecrementTracker2";
            this.btnDecrementTracker2.Size = new System.Drawing.Size(78, 23);
            this.btnDecrementTracker2.TabIndex = 8;
            this.btnDecrementTracker2.Text = "Subtract";
            this.btnDecrementTracker2.UseVisualStyleBackColor = true;
            this.btnDecrementTracker2.Click += new System.EventHandler(this.Increment_Decrement);
            // 
            // btnDecrementTracker1
            // 
            this.btnDecrementTracker1.Location = new System.Drawing.Point(208, 3);
            this.btnDecrementTracker1.Name = "btnDecrementTracker1";
            this.btnDecrementTracker1.Size = new System.Drawing.Size(78, 23);
            this.btnDecrementTracker1.TabIndex = 3;
            this.btnDecrementTracker1.Text = "Subtract";
            this.btnDecrementTracker1.UseVisualStyleBackColor = true;
            this.btnDecrementTracker1.Click += new System.EventHandler(this.Increment_Decrement);
            // 
            // btnIncrementTracker1
            // 
            this.btnIncrementTracker1.Location = new System.Drawing.Point(146, 3);
            this.btnIncrementTracker1.Name = "btnIncrementTracker1";
            this.btnIncrementTracker1.Size = new System.Drawing.Size(56, 23);
            this.btnIncrementTracker1.TabIndex = 2;
            this.btnIncrementTracker1.Text = "Add";
            this.btnIncrementTracker1.UseVisualStyleBackColor = true;
            this.btnIncrementTracker1.Click += new System.EventHandler(this.Increment_Decrement);
            // 
            // txtTracker4Count
            // 
            this.txtTracker4Count.Location = new System.Drawing.Point(99, 87);
            this.txtTracker4Count.Name = "txtTracker4Count";
            this.txtTracker4Count.Size = new System.Drawing.Size(41, 22);
            this.txtTracker4Count.TabIndex = 16;
            // 
            // txtTracker3Count
            // 
            this.txtTracker3Count.Location = new System.Drawing.Point(99, 59);
            this.txtTracker3Count.Name = "txtTracker3Count";
            this.txtTracker3Count.Size = new System.Drawing.Size(41, 22);
            this.txtTracker3Count.TabIndex = 11;
            // 
            // txtTracker2Count
            // 
            this.txtTracker2Count.Location = new System.Drawing.Point(99, 31);
            this.txtTracker2Count.Name = "txtTracker2Count";
            this.txtTracker2Count.Size = new System.Drawing.Size(41, 22);
            this.txtTracker2Count.TabIndex = 6;
            // 
            // txtTracker1Count
            // 
            this.txtTracker1Count.Location = new System.Drawing.Point(99, 3);
            this.txtTracker1Count.Name = "txtTracker1Count";
            this.txtTracker1Count.Size = new System.Drawing.Size(41, 22);
            this.txtTracker1Count.TabIndex = 1;
            // 
            // ckbChecker3
            // 
            this.ckbChecker3.AutoSize = true;
            this.ckbChecker3.Location = new System.Drawing.Point(99, 184);
            this.ckbChecker3.Name = "ckbChecker3";
            this.ckbChecker3.Size = new System.Drawing.Size(18, 17);
            this.ckbChecker3.TabIndex = 25;
            this.ckbChecker3.UseVisualStyleBackColor = true;
            // 
            // ckbChecker2
            // 
            this.ckbChecker2.AutoSize = true;
            this.ckbChecker2.Location = new System.Drawing.Point(99, 156);
            this.ckbChecker2.Name = "ckbChecker2";
            this.ckbChecker2.Size = new System.Drawing.Size(18, 17);
            this.ckbChecker2.TabIndex = 23;
            this.ckbChecker2.UseVisualStyleBackColor = true;
            // 
            // ckbChecker1
            // 
            this.ckbChecker1.AutoSize = true;
            this.ckbChecker1.Location = new System.Drawing.Point(99, 128);
            this.ckbChecker1.Name = "ckbChecker1";
            this.ckbChecker1.Size = new System.Drawing.Size(18, 17);
            this.ckbChecker1.TabIndex = 21;
            this.ckbChecker1.UseVisualStyleBackColor = true;
            // 
            // txtChecker1
            // 
            this.txtChecker1.Location = new System.Drawing.Point(3, 126);
            this.txtChecker1.Name = "txtChecker1";
            this.txtChecker1.Size = new System.Drawing.Size(90, 22);
            this.txtChecker1.TabIndex = 20;
            this.txtChecker1.Text = "Bardic Insp.";
            // 
            // txtChecker2
            // 
            this.txtChecker2.Location = new System.Drawing.Point(3, 154);
            this.txtChecker2.Name = "txtChecker2";
            this.txtChecker2.Size = new System.Drawing.Size(90, 22);
            this.txtChecker2.TabIndex = 22;
            // 
            // txtChecker3
            // 
            this.txtChecker3.Location = new System.Drawing.Point(3, 182);
            this.txtChecker3.Name = "txtChecker3";
            this.txtChecker3.Size = new System.Drawing.Size(90, 22);
            this.txtChecker3.TabIndex = 24;
            // 
            // txtTracker4
            // 
            this.txtTracker4.Location = new System.Drawing.Point(3, 87);
            this.txtTracker4.Name = "txtTracker4";
            this.txtTracker4.Size = new System.Drawing.Size(90, 22);
            this.txtTracker4.TabIndex = 15;
            this.txtTracker4.Text = "Storm Rune";
            // 
            // txtTracker3
            // 
            this.txtTracker3.Location = new System.Drawing.Point(3, 59);
            this.txtTracker3.Name = "txtTracker3";
            this.txtTracker3.Size = new System.Drawing.Size(90, 22);
            this.txtTracker3.TabIndex = 10;
            this.txtTracker3.Text = "Godbrand";
            // 
            // txtTracker2
            // 
            this.txtTracker2.Location = new System.Drawing.Point(3, 31);
            this.txtTracker2.Name = "txtTracker2";
            this.txtTracker2.Size = new System.Drawing.Size(90, 22);
            this.txtTracker2.TabIndex = 5;
            this.txtTracker2.Text = "Rage";
            // 
            // txtTracker1
            // 
            this.txtTracker1.Location = new System.Drawing.Point(3, 3);
            this.txtTracker1.Name = "txtTracker1";
            this.txtTracker1.Size = new System.Drawing.Size(90, 22);
            this.txtTracker1.TabIndex = 0;
            this.txtTracker1.Text = "Giant\'s Might";
            // 
            // DnD_Helper
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(361, 239);
            this.Controls.Add(this.tbcTabs);
            this.Name = "DnD_Helper";
            this.Text = "D&D Helper";
            this.grpModifiers.ResumeLayout(false);
            this.grpModifiers.PerformLayout();
            this.tbcTabs.ResumeLayout(false);
            this.tbpRoller.ResumeLayout(false);
            this.tbpRoller.PerformLayout();
            this.tbpHistory.ResumeLayout(false);
            this.tbpTracker.ResumeLayout(false);
            this.tbpTracker.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RadioButton rdoAdvantage;
        private System.Windows.Forms.RadioButton rdoDisadvantage;
        private System.Windows.Forms.GroupBox grpModifiers;
        private System.Windows.Forms.TextBox txtDiceNumber;
        private System.Windows.Forms.ComboBox cboDieSize;
        private System.Windows.Forms.Button btnRoll;
        private System.Windows.Forms.Label lblPrompt;
        private System.Windows.Forms.TextBox txtResult;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.RadioButton rdoNone;
        private System.Windows.Forms.Button btnClearRoller;
        private System.Windows.Forms.TabControl tbcTabs;
        private System.Windows.Forms.TabPage tbpRoller;
        private System.Windows.Forms.TabPage tbpHistory;
        private System.Windows.Forms.ListBox lboHistory;
        private System.Windows.Forms.Button btnClearHistory;
        private System.Windows.Forms.TextBox txtModifier;
        private System.Windows.Forms.Label lblPlus;
        private System.Windows.Forms.TabPage tbpTracker;
        private System.Windows.Forms.TextBox txtTracker4Count;
        private System.Windows.Forms.TextBox txtTracker3Count;
        private System.Windows.Forms.TextBox txtTracker2Count;
        private System.Windows.Forms.TextBox txtTracker1Count;
        private System.Windows.Forms.CheckBox ckbChecker3;
        private System.Windows.Forms.CheckBox ckbChecker2;
        private System.Windows.Forms.CheckBox ckbChecker1;
        private System.Windows.Forms.TextBox txtChecker1;
        private System.Windows.Forms.TextBox txtChecker2;
        private System.Windows.Forms.TextBox txtChecker3;
        private System.Windows.Forms.TextBox txtTracker4;
        private System.Windows.Forms.TextBox txtTracker3;
        private System.Windows.Forms.TextBox txtTracker2;
        private System.Windows.Forms.TextBox txtTracker1;
        private System.Windows.Forms.Button btnIncrementTracker4;
        private System.Windows.Forms.Button btnIncrementTracker3;
        private System.Windows.Forms.Button btnIncrementTracker2;
        private System.Windows.Forms.Button btnIncrementTracker1;
        private System.Windows.Forms.Button btnClearTracker1;
        private System.Windows.Forms.Button btnDecrementTracker1;
        private System.Windows.Forms.Button btnClearTracker4;
        private System.Windows.Forms.Button btnClearTracker3;
        private System.Windows.Forms.Button btnClearTracker2;
        private System.Windows.Forms.Button btnDecrementTracker4;
        private System.Windows.Forms.Button btnDecrementTracker3;
        private System.Windows.Forms.Button btnDecrementTracker2;
        private System.Windows.Forms.Button btnClearAllTrackers;
        private System.Windows.Forms.Label lblNotes;
        private System.Windows.Forms.TextBox txtNotes;
    }
}

