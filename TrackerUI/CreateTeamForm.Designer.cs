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
            SuspendLayout();
            // 
            // TournamentNameTextBox
            // 
            TournamentNameTextBox.Location = new Point(35, 128);
            TournamentNameTextBox.Name = "TournamentNameTextBox";
            TournamentNameTextBox.Size = new Size(312, 35);
            TournamentNameTextBox.TabIndex = 13;
            // 
            // TeamNameLabel
            // 
            TeamNameLabel.AutoSize = true;
            TeamNameLabel.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TeamNameLabel.ForeColor = SystemColors.MenuHighlight;
            TeamNameLabel.Location = new Point(35, 76);
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
            CreateLable.Location = new Point(12, 9);
            CreateLable.Name = "CreateLable";
            CreateLable.Size = new Size(213, 50);
            CreateLable.TabIndex = 11;
            CreateLable.Text = "Create Team";
            // 
            // CreateTeamForm
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(771, 514);
            Controls.Add(TournamentNameTextBox);
            Controls.Add(TeamNameLabel);
            Controls.Add(CreateLable);
            Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(5, 6, 5, 6);
            Name = "CreateTeamForm";
            Text = "Create Team";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox TournamentNameTextBox;
        private Label TeamNameLabel;
        private Label CreateLable;
    }
}