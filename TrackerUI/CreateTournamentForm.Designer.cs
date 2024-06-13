namespace TrackerUI
{
    partial class CreateTournamentForm
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
            CreatetournamentNamelabel = new Label();
            TournamentNameTextBox = new TextBox();
            TeamNameLabel = new Label();
            EntryFeeTextBox = new TextBox();
            EntryFeeabel = new Label();
            SelectTeamDropDown = new ComboBox();
            SelectTeamLabel = new Label();
            CreateTeamLinkLabel = new LinkLabel();
            AddTeamButton = new Button();
            CreatePrizeButton = new Button();
            TournamentPlayerListBox = new ListBox();
            TournamentPlayerLabel = new Label();
            DeleteSelectedPlayer = new Button();
            DeleteSelectedPrize = new Button();
            PrizesLabel = new Label();
            PrizesListBox = new ListBox();
            CreateTournamentButton = new Button();
            SuspendLayout();
            // 
            // CreatetournamentNamelabel
            // 
            CreatetournamentNamelabel.AutoSize = true;
            CreatetournamentNamelabel.Font = new Font("Segoe UI Light", 27.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            CreatetournamentNamelabel.ForeColor = SystemColors.Highlight;
            CreatetournamentNamelabel.Location = new Point(12, 18);
            CreatetournamentNamelabel.Name = "CreatetournamentNamelabel";
            CreatetournamentNamelabel.Size = new Size(317, 50);
            CreatetournamentNamelabel.TabIndex = 1;
            CreatetournamentNamelabel.Text = "Create Tournament";
            // 
            // TournamentNameTextBox
            // 
            TournamentNameTextBox.Location = new Point(35, 137);
            TournamentNameTextBox.Name = "TournamentNameTextBox";
            TournamentNameTextBox.Size = new Size(312, 35);
            TournamentNameTextBox.TabIndex = 10;
            TournamentNameTextBox.TextChanged += TeamOneScoreTextBox_TextChanged;
            // 
            // TeamNameLabel
            // 
            TeamNameLabel.AutoSize = true;
            TeamNameLabel.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TeamNameLabel.ForeColor = SystemColors.MenuHighlight;
            TeamNameLabel.Location = new Point(35, 85);
            TeamNameLabel.Name = "TeamNameLabel";
            TeamNameLabel.Size = new Size(236, 37);
            TeamNameLabel.TabIndex = 9;
            TeamNameLabel.Text = "Tournament Name";
            // 
            // EntryFeeTextBox
            // 
            EntryFeeTextBox.Location = new Point(164, 204);
            EntryFeeTextBox.Name = "EntryFeeTextBox";
            EntryFeeTextBox.Size = new Size(183, 35);
            EntryFeeTextBox.TabIndex = 12;
            EntryFeeTextBox.Text = "0";
            // 
            // EntryFeeabel
            // 
            EntryFeeabel.AutoSize = true;
            EntryFeeabel.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            EntryFeeabel.ForeColor = SystemColors.MenuHighlight;
            EntryFeeabel.Location = new Point(35, 201);
            EntryFeeabel.Name = "EntryFeeabel";
            EntryFeeabel.Size = new Size(132, 37);
            EntryFeeabel.TabIndex = 11;
            EntryFeeabel.Text = "Entry Fee ";
            // 
            // SelectTeamDropDown
            // 
            SelectTeamDropDown.FormattingEnabled = true;
            SelectTeamDropDown.Location = new Point(35, 309);
            SelectTeamDropDown.Name = "SelectTeamDropDown";
            SelectTeamDropDown.Size = new Size(312, 38);
            SelectTeamDropDown.TabIndex = 14;
            // 
            // SelectTeamLabel
            // 
            SelectTeamLabel.AutoSize = true;
            SelectTeamLabel.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            SelectTeamLabel.ForeColor = SystemColors.MenuHighlight;
            SelectTeamLabel.Location = new Point(35, 269);
            SelectTeamLabel.Name = "SelectTeamLabel";
            SelectTeamLabel.Size = new Size(156, 37);
            SelectTeamLabel.TabIndex = 13;
            SelectTeamLabel.Text = "Select Team";
            // 
            // CreateTeamLinkLabel
            // 
            CreateTeamLinkLabel.AutoSize = true;
            CreateTeamLinkLabel.Location = new Point(226, 275);
            CreateTeamLinkLabel.Name = "CreateTeamLinkLabel";
            CreateTeamLinkLabel.Size = new Size(121, 30);
            CreateTeamLinkLabel.TabIndex = 15;
            CreateTeamLinkLabel.TabStop = true;
            CreateTeamLinkLabel.Text = "Create New";
            // 
            // AddTeamButton
            // 
            AddTeamButton.FlatAppearance.BorderColor = Color.Silver;
            AddTeamButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(102, 102, 102);
            AddTeamButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(242, 242, 242);
            AddTeamButton.FlatStyle = FlatStyle.Flat;
            AddTeamButton.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            AddTeamButton.ForeColor = SystemColors.Highlight;
            AddTeamButton.Location = new Point(79, 368);
            AddTeamButton.Name = "AddTeamButton";
            AddTeamButton.Size = new Size(201, 45);
            AddTeamButton.TabIndex = 16;
            AddTeamButton.Text = "Add Team ";
            AddTeamButton.UseVisualStyleBackColor = true;
            // 
            // CreatePrizeButton
            // 
            CreatePrizeButton.FlatAppearance.BorderColor = Color.Silver;
            CreatePrizeButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(102, 102, 102);
            CreatePrizeButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(242, 242, 242);
            CreatePrizeButton.FlatStyle = FlatStyle.Flat;
            CreatePrizeButton.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            CreatePrizeButton.ForeColor = SystemColors.Highlight;
            CreatePrizeButton.Location = new Point(79, 430);
            CreatePrizeButton.Name = "CreatePrizeButton";
            CreatePrizeButton.Size = new Size(201, 45);
            CreatePrizeButton.TabIndex = 17;
            CreatePrizeButton.Text = "Create Prize";
            CreatePrizeButton.UseVisualStyleBackColor = true;
            // 
            // TournamentPlayerListBox
            // 
            TournamentPlayerListBox.BorderStyle = BorderStyle.FixedSingle;
            TournamentPlayerListBox.FormattingEnabled = true;
            TournamentPlayerListBox.ItemHeight = 30;
            TournamentPlayerListBox.Location = new Point(431, 137);
            TournamentPlayerListBox.Name = "TournamentPlayerListBox";
            TournamentPlayerListBox.Size = new Size(318, 152);
            TournamentPlayerListBox.TabIndex = 18;
            // 
            // TournamentPlayerLabel
            // 
            TournamentPlayerLabel.AutoSize = true;
            TournamentPlayerLabel.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TournamentPlayerLabel.ForeColor = SystemColors.MenuHighlight;
            TournamentPlayerLabel.Location = new Point(492, 85);
            TournamentPlayerLabel.Name = "TournamentPlayerLabel";
            TournamentPlayerLabel.Size = new Size(182, 37);
            TournamentPlayerLabel.TabIndex = 19;
            TournamentPlayerLabel.Text = "Team | Players";
            // 
            // DeleteSelectedPlayer
            // 
            DeleteSelectedPlayer.FlatAppearance.BorderColor = Color.Silver;
            DeleteSelectedPlayer.FlatAppearance.MouseDownBackColor = Color.FromArgb(102, 102, 102);
            DeleteSelectedPlayer.FlatAppearance.MouseOverBackColor = Color.FromArgb(242, 242, 242);
            DeleteSelectedPlayer.FlatStyle = FlatStyle.Flat;
            DeleteSelectedPlayer.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            DeleteSelectedPlayer.ForeColor = SystemColors.Highlight;
            DeleteSelectedPlayer.Location = new Point(778, 193);
            DeleteSelectedPlayer.Name = "DeleteSelectedPlayer";
            DeleteSelectedPlayer.Size = new Size(134, 45);
            DeleteSelectedPlayer.TabIndex = 20;
            DeleteSelectedPlayer.Text = "Delete";
            DeleteSelectedPlayer.UseVisualStyleBackColor = true;
            // 
            // DeleteSelectedPrize
            // 
            DeleteSelectedPrize.FlatAppearance.BorderColor = Color.Silver;
            DeleteSelectedPrize.FlatAppearance.MouseDownBackColor = Color.FromArgb(102, 102, 102);
            DeleteSelectedPrize.FlatAppearance.MouseOverBackColor = Color.FromArgb(242, 242, 242);
            DeleteSelectedPrize.FlatStyle = FlatStyle.Flat;
            DeleteSelectedPrize.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            DeleteSelectedPrize.ForeColor = SystemColors.Highlight;
            DeleteSelectedPrize.Location = new Point(778, 424);
            DeleteSelectedPrize.Name = "DeleteSelectedPrize";
            DeleteSelectedPrize.Size = new Size(134, 45);
            DeleteSelectedPrize.TabIndex = 23;
            DeleteSelectedPrize.Text = "Delete Selected Prize";
            DeleteSelectedPrize.UseVisualStyleBackColor = true;
            // 
            // PrizesLabel
            // 
            PrizesLabel.AutoSize = true;
            PrizesLabel.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            PrizesLabel.ForeColor = SystemColors.MenuHighlight;
            PrizesLabel.Location = new Point(492, 310);
            PrizesLabel.Name = "PrizesLabel";
            PrizesLabel.Size = new Size(182, 37);
            PrizesLabel.TabIndex = 22;
            PrizesLabel.Text = "Team | Players";
            // 
            // PrizesListBox
            // 
            PrizesListBox.BorderStyle = BorderStyle.FixedSingle;
            PrizesListBox.FormattingEnabled = true;
            PrizesListBox.ItemHeight = 30;
            PrizesListBox.Location = new Point(431, 368);
            PrizesListBox.Name = "PrizesListBox";
            PrizesListBox.Size = new Size(318, 152);
            PrizesListBox.TabIndex = 21;
            // 
            // CreateTournamentButton
            // 
            CreateTournamentButton.FlatAppearance.BorderColor = Color.Silver;
            CreateTournamentButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(102, 102, 102);
            CreateTournamentButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(242, 242, 242);
            CreateTournamentButton.FlatStyle = FlatStyle.Flat;
            CreateTournamentButton.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            CreateTournamentButton.ForeColor = SystemColors.Highlight;
            CreateTournamentButton.Location = new Point(287, 557);
            CreateTournamentButton.Name = "CreateTournamentButton";
            CreateTournamentButton.Size = new Size(253, 58);
            CreateTournamentButton.TabIndex = 24;
            CreateTournamentButton.Text = "Create Tournament";
            CreateTournamentButton.UseVisualStyleBackColor = true;
            // 
            // CreateTournamentForm
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(984, 645);
            Controls.Add(CreateTournamentButton);
            Controls.Add(DeleteSelectedPrize);
            Controls.Add(PrizesLabel);
            Controls.Add(PrizesListBox);
            Controls.Add(DeleteSelectedPlayer);
            Controls.Add(TournamentPlayerLabel);
            Controls.Add(TournamentPlayerListBox);
            Controls.Add(CreatePrizeButton);
            Controls.Add(AddTeamButton);
            Controls.Add(CreateTeamLinkLabel);
            Controls.Add(SelectTeamDropDown);
            Controls.Add(SelectTeamLabel);
            Controls.Add(EntryFeeTextBox);
            Controls.Add(EntryFeeabel);
            Controls.Add(TournamentNameTextBox);
            Controls.Add(TeamNameLabel);
            Controls.Add(CreatetournamentNamelabel);
            Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(5, 6, 5, 6);
            Name = "CreateTournamentForm";
            Text = "Create Tournament";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label CreatetournamentNamelabel;
        private TextBox TournamentNameTextBox;
        private Label TeamNameLabel;
        private TextBox EntryFeeTextBox;
        private Label EntryFeeabel;
        private ComboBox SelectTeamDropDown;
        private Label SelectTeamLabel;
        private LinkLabel CreateTeamLinkLabel;
        private Button AddTeamButton;
        private Button CreatePrizeButton;
        private ListBox TournamentPlayerListBox;
        private Label TournamentPlayerLabel;
        private Button DeleteSelectedPlayer;
        private Button DeleteSelectedPrize;
        private Label PrizesLabel;
        private ListBox PrizesListBox;
        private Button CreateTournamentButton;
    }
}