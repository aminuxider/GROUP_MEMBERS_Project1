namespace HigherLuck
{
    partial class Form1
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
            this.grpInit = new System.Windows.Forms.GroupBox();
            this.txtName2 = new System.Windows.Forms.TextBox();
            this.lblName2 = new System.Windows.Forms.Label();
            this.txtName1 = new System.Windows.Forms.TextBox();
            this.lblName1 = new System.Windows.Forms.Label();
            this.nudRounds = new System.Windows.Forms.NumericUpDown();
            this.lblRounds = new System.Windows.Forms.Label();
            this.grpAction = new System.Windows.Forms.GroupBox();
            this.lblRollInfo = new System.Windows.Forms.Label();
            this.pbDice = new System.Windows.Forms.PictureBox();
            this.btnRoll = new System.Windows.Forms.Button();
            this.lblTurn = new System.Windows.Forms.Label();
            this.lblRoundsLeft = new System.Windows.Forms.Label();
            this.lblRoundsCaption = new System.Windows.Forms.Label();
            this.grpAvatars = new System.Windows.Forms.GroupBox();
            this.rbAvatar4 = new System.Windows.Forms.RadioButton();
            this.rbAvatar3 = new System.Windows.Forms.RadioButton();
            this.rbAvatar2 = new System.Windows.Forms.RadioButton();
            this.rbAvatar1 = new System.Windows.Forms.RadioButton();
            this.btnSetup1 = new System.Windows.Forms.Button();
            this.btnSetup2 = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.grpPlayer1 = new System.Windows.Forms.GroupBox();
            this.lblPoints1 = new System.Windows.Forms.Label();
            this.lblPointCaption1 = new System.Windows.Forms.Label();
            this.pbPlayer1 = new System.Windows.Forms.PictureBox();
            this.grpPlayer2 = new System.Windows.Forms.GroupBox();
            this.lblPoints2 = new System.Windows.Forms.Label();
            this.lblPointCaption2 = new System.Windows.Forms.Label();
            this.pbPlayer2 = new System.Windows.Forms.PictureBox();
            this.btnStart = new System.Windows.Forms.Button();
            this.grpReport = new System.Windows.Forms.GroupBox();
            this.lstReport = new System.Windows.Forms.ListBox();
            this.btnShowResult = new System.Windows.Forms.Button();
            this.lblTeam = new System.Windows.Forms.Label();
            this.grpInit.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudRounds)).BeginInit();
            this.grpAction.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbDice)).BeginInit();
            this.grpAvatars.SuspendLayout();
            this.grpPlayer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbPlayer1)).BeginInit();
            this.grpPlayer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbPlayer2)).BeginInit();
            this.grpReport.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpInit
            // 
            this.grpInit.Controls.Add(this.txtName2);
            this.grpInit.Controls.Add(this.lblName2);
            this.grpInit.Controls.Add(this.txtName1);
            this.grpInit.Controls.Add(this.lblName1);
            this.grpInit.Controls.Add(this.nudRounds);
            this.grpInit.Controls.Add(this.lblRounds);
            this.grpInit.Location = new System.Drawing.Point(18, 18);
            this.grpInit.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grpInit.Name = "grpInit";
            this.grpInit.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grpInit.Size = new System.Drawing.Size(352, 200);
            this.grpInit.TabIndex = 0;
            this.grpInit.TabStop = false;
            this.grpInit.Text = "Initializations";
            // 
            // txtName2
            // 
            this.txtName2.Location = new System.Drawing.Point(195, 148);
            this.txtName2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtName2.MaxLength = 15;
            this.txtName2.Name = "txtName2";
            this.txtName2.Size = new System.Drawing.Size(133, 26);
            this.txtName2.TabIndex = 5;
            this.txtName2.TextChanged += new System.EventHandler(this.txtName_TextChanged);
            // 
            // lblName2
            // 
            this.lblName2.AutoSize = true;
            this.lblName2.Location = new System.Drawing.Point(18, 152);
            this.lblName2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblName2.Name = "lblName2";
            this.lblName2.Size = new System.Drawing.Size(157, 20);
            this.lblName2.TabIndex = 4;
            this.lblName2.Text = "Second Player Name";
            // 
            // txtName1
            // 
            this.txtName1.Location = new System.Drawing.Point(195, 97);
            this.txtName1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtName1.MaxLength = 15;
            this.txtName1.Name = "txtName1";
            this.txtName1.Size = new System.Drawing.Size(133, 26);
            this.txtName1.TabIndex = 3;
            this.txtName1.TextChanged += new System.EventHandler(this.txtName_TextChanged);
            // 
            // lblName1
            // 
            this.lblName1.AutoSize = true;
            this.lblName1.Location = new System.Drawing.Point(18, 102);
            this.lblName1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblName1.Name = "lblName1";
            this.lblName1.Size = new System.Drawing.Size(133, 20);
            this.lblName1.TabIndex = 2;
            this.lblName1.Text = "First Player Name";
            // 
            // nudRounds
            // 
            this.nudRounds.Location = new System.Drawing.Point(195, 40);
            this.nudRounds.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.nudRounds.Maximum = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.nudRounds.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.nudRounds.Name = "nudRounds";
            this.nudRounds.Size = new System.Drawing.Size(135, 26);
            this.nudRounds.TabIndex = 1;
            this.nudRounds.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // lblRounds
            // 
            this.lblRounds.AutoSize = true;
            this.lblRounds.Location = new System.Drawing.Point(18, 46);
            this.lblRounds.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRounds.Name = "lblRounds";
            this.lblRounds.Size = new System.Drawing.Size(65, 20);
            this.lblRounds.TabIndex = 0;
            this.lblRounds.Text = "Rounds";
            // 
            // grpAction
            // 
            this.grpAction.Controls.Add(this.lblRollInfo);
            this.grpAction.Controls.Add(this.pbDice);
            this.grpAction.Controls.Add(this.btnRoll);
            this.grpAction.Controls.Add(this.lblTurn);
            this.grpAction.Controls.Add(this.lblRoundsLeft);
            this.grpAction.Controls.Add(this.lblRoundsCaption);
            this.grpAction.Location = new System.Drawing.Point(18, 231);
            this.grpAction.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grpAction.Name = "grpAction";
            this.grpAction.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grpAction.Size = new System.Drawing.Size(352, 369);
            this.grpAction.TabIndex = 1;
            this.grpAction.TabStop = false;
            this.grpAction.Text = "Action";
            // 
            // lblRollInfo
            // 
            this.lblRollInfo.AutoEllipsis = true;
            this.lblRollInfo.Location = new System.Drawing.Point(9, 337);
            this.lblRollInfo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRollInfo.Name = "lblRollInfo";
            this.lblRollInfo.Size = new System.Drawing.Size(334, 25);
            this.lblRollInfo.TabIndex = 5;
            this.lblRollInfo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pbDice
            // 
            this.pbDice.Location = new System.Drawing.Point(104, 188);
            this.pbDice.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pbDice.Name = "pbDice";
            this.pbDice.Size = new System.Drawing.Size(144, 148);
            this.pbDice.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbDice.TabIndex = 4;
            this.pbDice.TabStop = false;
            // 
            // btnRoll
            // 
            this.btnRoll.BackColor = System.Drawing.Color.Gold;
            this.btnRoll.Enabled = false;
            this.btnRoll.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRoll.Location = new System.Drawing.Point(18, 132);
            this.btnRoll.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnRoll.Name = "btnRoll";
            this.btnRoll.Size = new System.Drawing.Size(316, 49);
            this.btnRoll.TabIndex = 3;
            this.btnRoll.Text = "ROLL";
            this.btnRoll.UseVisualStyleBackColor = false;
            this.btnRoll.Click += new System.EventHandler(this.btnRoll_Click);
            // 
            // lblTurn
            // 
            this.lblTurn.AutoEllipsis = true;
            this.lblTurn.BackColor = System.Drawing.Color.Black;
            this.lblTurn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTurn.ForeColor = System.Drawing.Color.White;
            this.lblTurn.Location = new System.Drawing.Point(18, 80);
            this.lblTurn.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTurn.Name = "lblTurn";
            this.lblTurn.Size = new System.Drawing.Size(316, 40);
            this.lblTurn.TabIndex = 2;
            this.lblTurn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblRoundsLeft
            // 
            this.lblRoundsLeft.AutoSize = true;
            this.lblRoundsLeft.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRoundsLeft.Location = new System.Drawing.Point(195, 38);
            this.lblRoundsLeft.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRoundsLeft.Name = "lblRoundsLeft";
            this.lblRoundsLeft.Size = new System.Drawing.Size(24, 25);
            this.lblRoundsLeft.TabIndex = 1;
            this.lblRoundsLeft.Text = "0";
            // 
            // lblRoundsCaption
            // 
            this.lblRoundsCaption.AutoSize = true;
            this.lblRoundsCaption.Location = new System.Drawing.Point(18, 40);
            this.lblRoundsCaption.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRoundsCaption.Name = "lblRoundsCaption";
            this.lblRoundsCaption.Size = new System.Drawing.Size(91, 20);
            this.lblRoundsCaption.TabIndex = 0;
            this.lblRoundsCaption.Text = "Rounds left";
            // 
            // grpAvatars
            // 
            this.grpAvatars.Controls.Add(this.rbAvatar4);
            this.grpAvatars.Controls.Add(this.rbAvatar3);
            this.grpAvatars.Controls.Add(this.rbAvatar2);
            this.grpAvatars.Controls.Add(this.rbAvatar1);
            this.grpAvatars.Location = new System.Drawing.Point(382, 18);
            this.grpAvatars.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grpAvatars.Name = "grpAvatars";
            this.grpAvatars.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grpAvatars.Size = new System.Drawing.Size(225, 403);
            this.grpAvatars.TabIndex = 2;
            this.grpAvatars.TabStop = false;
            this.grpAvatars.Text = "Avatars";
            // 
            // rbAvatar4
            // 
            this.rbAvatar4.Image = global::HigherLuck.Properties.Resources.Icon04;
            this.rbAvatar4.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.rbAvatar4.Location = new System.Drawing.Point(21, 300);
            this.rbAvatar4.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rbAvatar4.Name = "rbAvatar4";
            this.rbAvatar4.Size = new System.Drawing.Size(180, 80);
            this.rbAvatar4.TabIndex = 3;
            this.rbAvatar4.UseVisualStyleBackColor = true;
            // 
            // rbAvatar3
            // 
            this.rbAvatar3.Image = global::HigherLuck.Properties.Resources.Icon03;
            this.rbAvatar3.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.rbAvatar3.Location = new System.Drawing.Point(21, 212);
            this.rbAvatar3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rbAvatar3.Name = "rbAvatar3";
            this.rbAvatar3.Size = new System.Drawing.Size(180, 80);
            this.rbAvatar3.TabIndex = 2;
            this.rbAvatar3.UseVisualStyleBackColor = true;
            // 
            // rbAvatar2
            // 
            this.rbAvatar2.Image = global::HigherLuck.Properties.Resources.Icon02;
            this.rbAvatar2.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.rbAvatar2.Location = new System.Drawing.Point(21, 125);
            this.rbAvatar2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rbAvatar2.Name = "rbAvatar2";
            this.rbAvatar2.Size = new System.Drawing.Size(180, 80);
            this.rbAvatar2.TabIndex = 1;
            this.rbAvatar2.UseVisualStyleBackColor = true;
            // 
            // rbAvatar1
            // 
            this.rbAvatar1.Image = global::HigherLuck.Properties.Resources.Icon01;
            this.rbAvatar1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.rbAvatar1.Location = new System.Drawing.Point(21, 37);
            this.rbAvatar1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rbAvatar1.Name = "rbAvatar1";
            this.rbAvatar1.Size = new System.Drawing.Size(180, 80);
            this.rbAvatar1.TabIndex = 0;
            this.rbAvatar1.TabStop = true;
            this.rbAvatar1.UseVisualStyleBackColor = true;
            // 
            // btnSetup1
            // 
            this.btnSetup1.Enabled = false;
            this.btnSetup1.Location = new System.Drawing.Point(382, 434);
            this.btnSetup1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSetup1.Name = "btnSetup1";
            this.btnSetup1.Size = new System.Drawing.Size(225, 49);
            this.btnSetup1.TabIndex = 3;
            this.btnSetup1.Text = "Set Up First Player";
            this.btnSetup1.UseVisualStyleBackColor = true;
            this.btnSetup1.Click += new System.EventHandler(this.btnSetup1_Click);
            // 
            // btnSetup2
            // 
            this.btnSetup2.Enabled = false;
            this.btnSetup2.Location = new System.Drawing.Point(382, 492);
            this.btnSetup2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSetup2.Name = "btnSetup2";
            this.btnSetup2.Size = new System.Drawing.Size(225, 49);
            this.btnSetup2.TabIndex = 4;
            this.btnSetup2.Text = "Set Up Second Player";
            this.btnSetup2.UseVisualStyleBackColor = true;
            this.btnSetup2.Click += new System.EventHandler(this.btnSetup2_Click);
            // 
            // btnReset
            // 
            this.btnReset.BackColor = System.Drawing.Color.LightCoral;
            this.btnReset.Location = new System.Drawing.Point(382, 551);
            this.btnReset.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(225, 49);
            this.btnReset.TabIndex = 5;
            this.btnReset.Text = "RESET ALL";
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // grpPlayer1
            // 
            this.grpPlayer1.Controls.Add(this.lblPoints1);
            this.grpPlayer1.Controls.Add(this.lblPointCaption1);
            this.grpPlayer1.Controls.Add(this.pbPlayer1);
            this.grpPlayer1.Location = new System.Drawing.Point(620, 18);
            this.grpPlayer1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grpPlayer1.Name = "grpPlayer1";
            this.grpPlayer1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grpPlayer1.Size = new System.Drawing.Size(225, 194);
            this.grpPlayer1.TabIndex = 6;
            this.grpPlayer1.TabStop = false;
            this.grpPlayer1.Text = "First Player";
            // 
            // lblPoints1
            // 
            this.lblPoints1.AutoSize = true;
            this.lblPoints1.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPoints1.Location = new System.Drawing.Point(132, 65);
            this.lblPoints1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPoints1.Name = "lblPoints1";
            this.lblPoints1.Size = new System.Drawing.Size(63, 69);
            this.lblPoints1.TabIndex = 2;
            this.lblPoints1.Text = "0";
            // 
            // lblPointCaption1
            // 
            this.lblPointCaption1.AutoSize = true;
            this.lblPointCaption1.Location = new System.Drawing.Point(141, 40);
            this.lblPointCaption1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPointCaption1.Name = "lblPointCaption1";
            this.lblPointCaption1.Size = new System.Drawing.Size(45, 20);
            this.lblPointCaption1.TabIndex = 1;
            this.lblPointCaption1.Text = "Point";
            // 
            // pbPlayer1
            // 
            this.pbPlayer1.Image = global::HigherLuck.Properties.Resources.DefaultAvatar;
            this.pbPlayer1.Location = new System.Drawing.Point(15, 40);
            this.pbPlayer1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pbPlayer1.Name = "pbPlayer1";
            this.pbPlayer1.Size = new System.Drawing.Size(108, 111);
            this.pbPlayer1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbPlayer1.TabIndex = 0;
            this.pbPlayer1.TabStop = false;
            // 
            // grpPlayer2
            // 
            this.grpPlayer2.Controls.Add(this.lblPoints2);
            this.grpPlayer2.Controls.Add(this.lblPointCaption2);
            this.grpPlayer2.Controls.Add(this.pbPlayer2);
            this.grpPlayer2.Location = new System.Drawing.Point(620, 228);
            this.grpPlayer2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grpPlayer2.Name = "grpPlayer2";
            this.grpPlayer2.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grpPlayer2.Size = new System.Drawing.Size(225, 194);
            this.grpPlayer2.TabIndex = 7;
            this.grpPlayer2.TabStop = false;
            this.grpPlayer2.Text = "Second Player";
            // 
            // lblPoints2
            // 
            this.lblPoints2.AutoSize = true;
            this.lblPoints2.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPoints2.Location = new System.Drawing.Point(132, 65);
            this.lblPoints2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPoints2.Name = "lblPoints2";
            this.lblPoints2.Size = new System.Drawing.Size(63, 69);
            this.lblPoints2.TabIndex = 2;
            this.lblPoints2.Text = "0";
            // 
            // lblPointCaption2
            // 
            this.lblPointCaption2.AutoSize = true;
            this.lblPointCaption2.Location = new System.Drawing.Point(141, 40);
            this.lblPointCaption2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPointCaption2.Name = "lblPointCaption2";
            this.lblPointCaption2.Size = new System.Drawing.Size(45, 20);
            this.lblPointCaption2.TabIndex = 1;
            this.lblPointCaption2.Text = "Point";
            // 
            // pbPlayer2
            // 
            this.pbPlayer2.Image = global::HigherLuck.Properties.Resources.DefaultAvatar;
            this.pbPlayer2.Location = new System.Drawing.Point(15, 40);
            this.pbPlayer2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pbPlayer2.Name = "pbPlayer2";
            this.pbPlayer2.Size = new System.Drawing.Size(108, 111);
            this.pbPlayer2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbPlayer2.TabIndex = 0;
            this.pbPlayer2.TabStop = false;
            // 
            // btnStart
            // 
            this.btnStart.BackColor = System.Drawing.Color.LightGreen;
            this.btnStart.Enabled = false;
            this.btnStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStart.Location = new System.Drawing.Point(620, 434);
            this.btnStart.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(225, 166);
            this.btnStart.TabIndex = 8;
            this.btnStart.Text = "START";
            this.btnStart.UseVisualStyleBackColor = false;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // grpReport
            // 
            this.grpReport.Controls.Add(this.lstReport);
            this.grpReport.Location = new System.Drawing.Point(856, 18);
            this.grpReport.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grpReport.Name = "grpReport";
            this.grpReport.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grpReport.Size = new System.Drawing.Size(266, 403);
            this.grpReport.TabIndex = 9;
            this.grpReport.TabStop = false;
            this.grpReport.Text = "Report";
            // 
            // lstReport
            // 
            this.lstReport.FormattingEnabled = true;
            this.lstReport.HorizontalScrollbar = true;
            this.lstReport.ItemHeight = 20;
            this.lstReport.Location = new System.Drawing.Point(12, 31);
            this.lstReport.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.lstReport.Name = "lstReport";
            this.lstReport.Size = new System.Drawing.Size(240, 344);
            this.lstReport.TabIndex = 0;
            // 
            // btnShowResult
            // 
            this.btnShowResult.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnShowResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShowResult.Location = new System.Drawing.Point(856, 434);
            this.btnShowResult.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnShowResult.Name = "btnShowResult";
            this.btnShowResult.Size = new System.Drawing.Size(266, 166);
            this.btnShowResult.TabIndex = 10;
            this.btnShowResult.Text = "SHOW RESULT";
            this.btnShowResult.UseVisualStyleBackColor = false;
            this.btnShowResult.Click += new System.EventHandler(this.btnShowResult_Click);
            // 
            // lblTeam
            // 
            this.lblTeam.AutoSize = true;
            this.lblTeam.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTeam.Location = new System.Drawing.Point(18, 623);
            this.lblTeam.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTeam.Name = "lblTeam";
            this.lblTeam.Size = new System.Drawing.Size(269, 25);
            this.lblTeam.TabIndex = 11;
            this.lblTeam.Text = "Team: GROUP MEMBERS";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(1140, 677);
            this.Controls.Add(this.lblTeam);
            this.Controls.Add(this.btnShowResult);
            this.Controls.Add(this.grpReport);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.grpPlayer2);
            this.Controls.Add(this.grpPlayer1);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnSetup2);
            this.Controls.Add(this.btnSetup1);
            this.Controls.Add(this.grpAvatars);
            this.Controls.Add(this.grpAction);
            this.Controls.Add(this.grpInit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Higher Luck";
            this.grpInit.ResumeLayout(false);
            this.grpInit.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudRounds)).EndInit();
            this.grpAction.ResumeLayout(false);
            this.grpAction.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbDice)).EndInit();
            this.grpAvatars.ResumeLayout(false);
            this.grpPlayer1.ResumeLayout(false);
            this.grpPlayer1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbPlayer1)).EndInit();
            this.grpPlayer2.ResumeLayout(false);
            this.grpPlayer2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbPlayer2)).EndInit();
            this.grpReport.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpInit;
        private System.Windows.Forms.Label lblRounds;
        private System.Windows.Forms.NumericUpDown nudRounds;
        private System.Windows.Forms.Label lblName1;
        private System.Windows.Forms.TextBox txtName1;
        private System.Windows.Forms.Label lblName2;
        private System.Windows.Forms.TextBox txtName2;
        private System.Windows.Forms.GroupBox grpAction;
        private System.Windows.Forms.Label lblRoundsCaption;
        private System.Windows.Forms.Label lblRoundsLeft;
        private System.Windows.Forms.Label lblTurn;
        private System.Windows.Forms.Button btnRoll;
        private System.Windows.Forms.PictureBox pbDice;
        private System.Windows.Forms.Label lblRollInfo;
        private System.Windows.Forms.GroupBox grpAvatars;
        private System.Windows.Forms.RadioButton rbAvatar1;
        private System.Windows.Forms.RadioButton rbAvatar2;
        private System.Windows.Forms.RadioButton rbAvatar3;
        private System.Windows.Forms.RadioButton rbAvatar4;
        private System.Windows.Forms.Button btnSetup1;
        private System.Windows.Forms.Button btnSetup2;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.GroupBox grpPlayer1;
        private System.Windows.Forms.PictureBox pbPlayer1;
        private System.Windows.Forms.Label lblPointCaption1;
        private System.Windows.Forms.Label lblPoints1;
        private System.Windows.Forms.GroupBox grpPlayer2;
        private System.Windows.Forms.PictureBox pbPlayer2;
        private System.Windows.Forms.Label lblPointCaption2;
        private System.Windows.Forms.Label lblPoints2;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.GroupBox grpReport;
        private System.Windows.Forms.ListBox lstReport;
        private System.Windows.Forms.Button btnShowResult;
        private System.Windows.Forms.Label lblTeam;
    }
}
