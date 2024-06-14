namespace TrackerUI
{
    partial class CreateTeamForm
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
            TournamentNameTextBox = new TextBox();
            TeamNameLabel = new Label();
            CreateLable = new Label();
            AddTeamMemberButton = new Button();
            SelectTeamMemberDropDown = new ComboBox();
            SelectTeamMemeberLabel = new Label();
            AddNewMember = new GroupBox();
            FirstNametextBox = new TextBox();
            FirstNameLabel = new Label();
            LastNameTextBox = new TextBox();
            LastNameLabel = new Label();
            EmailtextBox = new TextBox();
            EmailLabel = new Label();
            CellPhonetextBox = new TextBox();
            PhoneNumberLabel = new Label();
            CreateMemberButton = new Button();
            TeamMemberrListBox = new ListBox();
            DeleteSelectedTeam = new Button();
            CreateTeamButton = new Button();
            AddNewMember.SuspendLayout();
            SuspendLayout();
            // 
            // TournamentNameTextBox
            // 
            TournamentNameTextBox.Location = new Point(31, 117);
            TournamentNameTextBox.Name = "TournamentNameTextBox";
            TournamentNameTextBox.Size = new Size(393, 35);
            TournamentNameTextBox.TabIndex = 13;
            // 
            // TeamNameLabel
            // 
            TeamNameLabel.AutoSize = true;
            TeamNameLabel.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TeamNameLabel.ForeColor = SystemColors.MenuHighlight;
            TeamNameLabel.Location = new Point(31, 66);
            TeamNameLabel.Name = "TeamNameLabel";
            TeamNameLabel.Size = new Size(157, 37);
            TeamNameLabel.TabIndex = 12;
            TeamNameLabel.Text = "Team Name";
            // 
            // CreateLable
            // 
            CreateLable.AutoSize = true;
            CreateLable.Font = new Font("Segoe UI Light", 27.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            CreateLable.ForeColor = SystemColors.Highlight;
            CreateLable.Location = new Point(333, 9);
            CreateLable.Name = "CreateLable";
            CreateLable.Size = new Size(213, 50);
            CreateLable.TabIndex = 11;
            CreateLable.Text = "Create Team";
            // 
            // AddTeamMemberButton
            // 
            AddTeamMemberButton.FlatAppearance.BorderColor = Color.Silver;
            AddTeamMemberButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(102, 102, 102);
            AddTeamMemberButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(242, 242, 242);
            AddTeamMemberButton.FlatStyle = FlatStyle.Flat;
            AddTeamMemberButton.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            AddTeamMemberButton.ForeColor = SystemColors.Highlight;
            AddTeamMemberButton.Location = new Point(92, 254);
            AddTeamMemberButton.Name = "AddTeamMemberButton";
            AddTeamMemberButton.Size = new Size(185, 45);
            AddTeamMemberButton.TabIndex = 19;
            AddTeamMemberButton.Text = "Add Member";
            AddTeamMemberButton.UseVisualStyleBackColor = true;
            // 
            // SelectTeamMemberDropDown
            // 
            SelectTeamMemberDropDown.FormattingEnabled = true;
            SelectTeamMemberDropDown.Location = new Point(31, 200);
            SelectTeamMemberDropDown.Name = "SelectTeamMemberDropDown";
            SelectTeamMemberDropDown.Size = new Size(393, 38);
            SelectTeamMemberDropDown.TabIndex = 18;
            // 
            // SelectTeamMemeberLabel
            // 
            SelectTeamMemeberLabel.AutoSize = true;
            SelectTeamMemeberLabel.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            SelectTeamMemeberLabel.ForeColor = SystemColors.MenuHighlight;
            SelectTeamMemeberLabel.Location = new Point(31, 160);
            SelectTeamMemeberLabel.Name = "SelectTeamMemeberLabel";
            SelectTeamMemeberLabel.Size = new Size(263, 37);
            SelectTeamMemeberLabel.TabIndex = 17;
            SelectTeamMemeberLabel.Text = "Select Team Member";
            // 
            // AddNewMember
            // 
            AddNewMember.Controls.Add(CreateMemberButton);
            AddNewMember.Controls.Add(CellPhonetextBox);
            AddNewMember.Controls.Add(PhoneNumberLabel);
            AddNewMember.Controls.Add(EmailtextBox);
            AddNewMember.Controls.Add(EmailLabel);
            AddNewMember.Controls.Add(LastNameTextBox);
            AddNewMember.Controls.Add(LastNameLabel);
            AddNewMember.Controls.Add(FirstNametextBox);
            AddNewMember.Controls.Add(FirstNameLabel);
            AddNewMember.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            AddNewMember.ForeColor = SystemColors.Highlight;
            AddNewMember.Location = new Point(31, 316);
            AddNewMember.Name = "AddNewMember";
            AddNewMember.Size = new Size(393, 313);
            AddNewMember.TabIndex = 20;
            AddNewMember.TabStop = false;
            AddNewMember.Text = "Add New Member";
            // 
            // FirstNametextBox
            // 
            FirstNametextBox.Location = new Point(165, 45);
            FirstNametextBox.Name = "FirstNametextBox";
            FirstNametextBox.Size = new Size(208, 43);
            FirstNametextBox.TabIndex = 20;
            // 
            // FirstNameLabel
            // 
            FirstNameLabel.AutoSize = true;
            FirstNameLabel.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FirstNameLabel.ForeColor = SystemColors.MenuHighlight;
            FirstNameLabel.Location = new Point(15, 42);
            FirstNameLabel.Name = "FirstNameLabel";
            FirstNameLabel.Size = new Size(144, 37);
            FirstNameLabel.TabIndex = 19;
            FirstNameLabel.Text = "First Name";
            // 
            // LastNameTextBox
            // 
            LastNameTextBox.Location = new Point(165, 97);
            LastNameTextBox.Name = "LastNameTextBox";
            LastNameTextBox.Size = new Size(208, 43);
            LastNameTextBox.TabIndex = 22;
            // 
            // LastNameLabel
            // 
            LastNameLabel.AutoSize = true;
            LastNameLabel.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LastNameLabel.ForeColor = SystemColors.MenuHighlight;
            LastNameLabel.Location = new Point(15, 94);
            LastNameLabel.Name = "LastNameLabel";
            LastNameLabel.Size = new Size(142, 37);
            LastNameLabel.TabIndex = 21;
            LastNameLabel.Text = "Last Name";
            // 
            // EmailtextBox
            // 
            EmailtextBox.Location = new Point(165, 145);
            EmailtextBox.Name = "EmailtextBox";
            EmailtextBox.Size = new Size(208, 43);
            EmailtextBox.TabIndex = 24;
            // 
            // EmailLabel
            // 
            EmailLabel.AutoSize = true;
            EmailLabel.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            EmailLabel.ForeColor = SystemColors.MenuHighlight;
            EmailLabel.Location = new Point(15, 145);
            EmailLabel.Name = "EmailLabel";
            EmailLabel.Size = new Size(82, 37);
            EmailLabel.TabIndex = 23;
            EmailLabel.Text = "Email";
            // 
            // CellPhonetextBox
            // 
            CellPhonetextBox.Location = new Point(165, 194);
            CellPhonetextBox.Name = "CellPhonetextBox";
            CellPhonetextBox.Size = new Size(208, 43);
            CellPhonetextBox.TabIndex = 26;
            // 
            // PhoneNumberLabel
            // 
            PhoneNumberLabel.AutoSize = true;
            PhoneNumberLabel.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            PhoneNumberLabel.ForeColor = SystemColors.MenuHighlight;
            PhoneNumberLabel.Location = new Point(15, 191);
            PhoneNumberLabel.Name = "PhoneNumberLabel";
            PhoneNumberLabel.Size = new Size(137, 37);
            PhoneNumberLabel.TabIndex = 25;
            PhoneNumberLabel.Text = "CellPhone";
            // 
            // CreateMemberButton
            // 
            CreateMemberButton.FlatAppearance.BorderColor = Color.Silver;
            CreateMemberButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(102, 102, 102);
            CreateMemberButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(242, 242, 242);
            CreateMemberButton.FlatStyle = FlatStyle.Flat;
            CreateMemberButton.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            CreateMemberButton.ForeColor = SystemColors.Highlight;
            CreateMemberButton.Location = new Point(87, 253);
            CreateMemberButton.Name = "CreateMemberButton";
            CreateMemberButton.Size = new Size(185, 45);
            CreateMemberButton.TabIndex = 27;
            CreateMemberButton.Text = "Create Member";
            CreateMemberButton.UseVisualStyleBackColor = true;
            // 
            // TeamMemberrListBox
            // 
            TeamMemberrListBox.BorderStyle = BorderStyle.FixedSingle;
            TeamMemberrListBox.FormattingEnabled = true;
            TeamMemberrListBox.ItemHeight = 30;
            TeamMemberrListBox.Location = new Point(465, 117);
            TeamMemberrListBox.Name = "TeamMemberrListBox";
            TeamMemberrListBox.Size = new Size(324, 512);
            TeamMemberrListBox.TabIndex = 21;
            // 
            // DeleteSelectedTeam
            // 
            DeleteSelectedTeam.FlatAppearance.BorderColor = Color.Silver;
            DeleteSelectedTeam.FlatAppearance.MouseDownBackColor = Color.FromArgb(102, 102, 102);
            DeleteSelectedTeam.FlatAppearance.MouseOverBackColor = Color.FromArgb(242, 242, 242);
            DeleteSelectedTeam.FlatStyle = FlatStyle.Flat;
            DeleteSelectedTeam.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            DeleteSelectedTeam.ForeColor = SystemColors.Highlight;
            DeleteSelectedTeam.Location = new Point(814, 289);
            DeleteSelectedTeam.Name = "DeleteSelectedTeam";
            DeleteSelectedTeam.Size = new Size(134, 45);
            DeleteSelectedTeam.TabIndex = 22;
            DeleteSelectedTeam.Text = "Delete";
            DeleteSelectedTeam.UseVisualStyleBackColor = true;
            // 
            // CreateTeamButton
            // 
            CreateTeamButton.FlatAppearance.BorderColor = Color.Silver;
            CreateTeamButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(102, 102, 102);
            CreateTeamButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(242, 242, 242);
            CreateTeamButton.FlatStyle = FlatStyle.Flat;
            CreateTeamButton.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            CreateTeamButton.ForeColor = SystemColors.Highlight;
            CreateTeamButton.Location = new Point(333, 649);
            CreateTeamButton.Name = "CreateTeamButton";
            CreateTeamButton.Size = new Size(267, 58);
            CreateTeamButton.TabIndex = 25;
            CreateTeamButton.Text = "Create Team";
            CreateTeamButton.UseVisualStyleBackColor = true;
            // 
            // CreateTeamForm
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(960, 715);
            Controls.Add(CreateTeamButton);
            Controls.Add(DeleteSelectedTeam);
            Controls.Add(TeamMemberrListBox);
            Controls.Add(AddNewMember);
            Controls.Add(AddTeamMemberButton);
            Controls.Add(SelectTeamMemberDropDown);
            Controls.Add(SelectTeamMemeberLabel);
            Controls.Add(TournamentNameTextBox);
            Controls.Add(TeamNameLabel);
            Controls.Add(CreateLable);
            Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(5, 6, 5, 6);
            Name = "CreateTeamForm";
            Text = "Create Team";
            AddNewMember.ResumeLayout(false);
            AddNewMember.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox TournamentNameTextBox;
        private Label TeamNameLabel;
        private Label CreateLable;
        private Button AddTeamMemberButton;
        private ComboBox SelectTeamMemberDropDown;
        private Label SelectTeamMemeberLabel;
        private GroupBox AddNewMember;
        private TextBox LastNameTextBox;
        private Label LastNameLabel;
        private TextBox FirstNametextBox;
        private Label FirstNameLabel;
        private TextBox CellPhonetextBox;
        private Label PhoneNumberLabel;
        private TextBox EmailtextBox;
        private Label EmailLabel;
        private Button CreateMemberButton;
        private ListBox TeamMemberrListBox;
        private Button DeleteSelectedTeam;
        private Button CreateTeamButton;
    }
}