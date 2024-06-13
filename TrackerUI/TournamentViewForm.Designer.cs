namespace TrackerUI
{
    partial class TournamentViewForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            TournamentNameLabel = new Label();
            TournamentName = new Label();
            UnplayedOnlyCheckBox = new CheckBox();
            MatchUpListBox = new ListBox();
            TeamOneName = new Label();
            TeamTwoScoreTexBox = new TextBox();
            TeamTwoScoreLabel = new Label();
            TeamTwoName = new Label();
            VersusLabel = new Label();
            ScoreButton = new Button();
            SuspendLayout();
            // 
            // TournamentNameLabel
            // 
            TournamentNameLabel.AutoSize = true;
            TournamentNameLabel.Font = new Font("Segoe UI Light", 27.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TournamentNameLabel.ForeColor = SystemColors.Highlight;
            TournamentNameLabel.Location = new Point(12, 19);
            TournamentNameLabel.Name = "TournamentNameLabel";
            TournamentNameLabel.Size = new Size(214, 50);
            TournamentNameLabel.TabIndex = 0;
            TournamentNameLabel.Text = "Tournament:";
            // 
            // TournamentName
            // 
            TournamentName.AutoSize = true;
            TournamentName.Font = new Font("Segoe UI Light", 27.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TournamentName.ForeColor = SystemColors.Highlight;
            TournamentName.Location = new Point(210, 19);
            TournamentName.Name = "TournamentName";
            TournamentName.Size = new Size(150, 50);
            TournamentName.TabIndex = 1;
            TournamentName.Text = "<none>";
            // 
            // UnplayedOnlyCheckBox
            // 
            UnplayedOnlyCheckBox.AutoSize = true;
            UnplayedOnlyCheckBox.FlatStyle = FlatStyle.Flat;
            UnplayedOnlyCheckBox.Font = new Font("Segoe UI Light", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            UnplayedOnlyCheckBox.ForeColor = SystemColors.MenuHighlight;
            UnplayedOnlyCheckBox.Location = new Point(129, 141);
            UnplayedOnlyCheckBox.Name = "UnplayedOnlyCheckBox";
            UnplayedOnlyCheckBox.Size = new Size(205, 41);
            UnplayedOnlyCheckBox.TabIndex = 4;
            UnplayedOnlyCheckBox.Text = "Unplalyed Only";
            UnplayedOnlyCheckBox.UseVisualStyleBackColor = true;
            // 
            // MatchUpListBox
            // 
            MatchUpListBox.BorderStyle = BorderStyle.FixedSingle;
            MatchUpListBox.FormattingEnabled = true;
            MatchUpListBox.ItemHeight = 30;
            MatchUpListBox.Location = new Point(41, 213);
            MatchUpListBox.Name = "MatchUpListBox";
            MatchUpListBox.Size = new Size(319, 272);
            MatchUpListBox.TabIndex = 5;
            // 
            // TeamOneName
            // 
            TeamOneName.AutoSize = true;
            TeamOneName.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TeamOneName.ForeColor = SystemColors.MenuHighlight;
            TeamOneName.Location = new Point(443, 213);
            TeamOneName.Name = "TeamOneName";
            TeamOneName.Size = new Size(165, 37);
            TeamOneName.TabIndex = 6;
            TeamOneName.Text = "<team one>";
            // 
            // TeamTwoScoreTexBox
            // 
            TeamTwoScoreTexBox.Location = new Point(531, 428);
            TeamTwoScoreTexBox.Name = "TeamTwoScoreTexBox";
            TeamTwoScoreTexBox.Size = new Size(113, 35);
            TeamTwoScoreTexBox.TabIndex = 11;
            // 
            // TeamTwoScoreLabel
            // 
            TeamTwoScoreLabel.AutoSize = true;
            TeamTwoScoreLabel.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TeamTwoScoreLabel.ForeColor = SystemColors.MenuHighlight;
            TeamTwoScoreLabel.Location = new Point(443, 425);
            TeamTwoScoreLabel.Name = "TeamTwoScoreLabel";
            TeamTwoScoreLabel.Size = new Size(82, 37);
            TeamTwoScoreLabel.TabIndex = 10;
            TeamTwoScoreLabel.Text = "Score";
            // 
            // TeamTwoName
            // 
            TeamTwoName.AutoSize = true;
            TeamTwoName.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TeamTwoName.ForeColor = SystemColors.MenuHighlight;
            TeamTwoName.Location = new Point(443, 371);
            TeamTwoName.Name = "TeamTwoName";
            TeamTwoName.Size = new Size(165, 37);
            TeamTwoName.TabIndex = 9;
            TeamTwoName.Text = "<team two>";
            // 
            // VersusLabel
            // 
            VersusLabel.AutoSize = true;
            VersusLabel.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            VersusLabel.ForeColor = SystemColors.MenuHighlight;
            VersusLabel.Location = new Point(520, 325);
            VersusLabel.Name = "VersusLabel";
            VersusLabel.Size = new Size(66, 37);
            VersusLabel.TabIndex = 12;
            VersusLabel.Text = "-Vs-";
            // 
            // ScoreButton
            // 
            ScoreButton.FlatAppearance.BorderColor = Color.Silver;
            ScoreButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(102, 102, 102);
            ScoreButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(242, 242, 242);
            ScoreButton.FlatStyle = FlatStyle.Flat;
            ScoreButton.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ScoreButton.ForeColor = SystemColors.Highlight;
            ScoreButton.Location = new Point(675, 335);
            ScoreButton.Name = "ScoreButton";
            ScoreButton.Size = new Size(127, 45);
            ScoreButton.TabIndex = 13;
            ScoreButton.Text = "Score Button";
            ScoreButton.UseVisualStyleBackColor = true;
            // 
            // TournamentViewForm
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(857, 565);
            Controls.Add(ScoreButton);
            Controls.Add(VersusLabel);
            Controls.Add(TeamTwoScoreTexBox);
            Controls.Add(TeamTwoScoreLabel);
            Controls.Add(TeamTwoName);
            Controls.Add(TeamOneName);
            Controls.Add(MatchUpListBox);
            Controls.Add(UnplayedOnlyCheckBox);
            Controls.Add(TournamentName);
            Controls.Add(TournamentNameLabel);
            Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(5, 6, 5, 6);
            Name = "TournamentViewForm";
            RightToLeftLayout = true;
            Text = "TournamentViewer";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label TournamentNameLabel;
        private Label TournamentName;
        private CheckBox UnplayedOnlyCheckBox;
        private ListBox MatchUpListBox;
        private Label TeamOneName;
        private TextBox TeamTwoScoreTexBox;
        private Label TeamTwoScoreLabel;
        private Label TeamTwoName;
        private Label VersusLabel;
        private Button ScoreButton;
    }
}
