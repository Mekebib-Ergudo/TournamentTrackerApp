namespace TrackerUI
{
    partial class TournamentDashboardFrom
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
            TournamentDashboardLable = new Label();
            LoadExistingTournamentDashboardDropDown = new ComboBox();
            LoadExistingTournamentDashboardLabel = new Label();
            LoadTournamentButton = new Button();
            CreateTournamentbutton = new Button();
            SuspendLayout();
            // 
            // TournamentDashboardLable
            // 
            TournamentDashboardLable.AutoSize = true;
            TournamentDashboardLable.Font = new Font("Segoe UI Light", 27.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TournamentDashboardLable.ForeColor = SystemColors.Highlight;
            TournamentDashboardLable.Location = new Point(85, 30);
            TournamentDashboardLable.Name = "TournamentDashboardLable";
            TournamentDashboardLable.Size = new Size(385, 50);
            TournamentDashboardLable.TabIndex = 13;
            TournamentDashboardLable.Text = "Tournament Dashboard";
            // 
            // LoadExistingTournamentDashboardDropDown
            // 
            LoadExistingTournamentDashboardDropDown.FormattingEnabled = true;
            LoadExistingTournamentDashboardDropDown.Location = new Point(81, 144);
            LoadExistingTournamentDashboardDropDown.Name = "LoadExistingTournamentDashboardDropDown";
            LoadExistingTournamentDashboardDropDown.Size = new Size(393, 38);
            LoadExistingTournamentDashboardDropDown.TabIndex = 20;
            // 
            // LoadExistingTournamentDashboardLabel
            // 
            LoadExistingTournamentDashboardLabel.AutoSize = true;
            LoadExistingTournamentDashboardLabel.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LoadExistingTournamentDashboardLabel.ForeColor = SystemColors.MenuHighlight;
            LoadExistingTournamentDashboardLabel.Location = new Point(116, 92);
            LoadExistingTournamentDashboardLabel.Name = "LoadExistingTournamentDashboardLabel";
            LoadExistingTournamentDashboardLabel.Size = new Size(322, 37);
            LoadExistingTournamentDashboardLabel.TabIndex = 19;
            LoadExistingTournamentDashboardLabel.Text = "Load Existing Tournament";
            // 
            // LoadTournamentButton
            // 
            LoadTournamentButton.FlatAppearance.BorderColor = Color.Silver;
            LoadTournamentButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(102, 102, 102);
            LoadTournamentButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(242, 242, 242);
            LoadTournamentButton.FlatStyle = FlatStyle.Flat;
            LoadTournamentButton.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LoadTournamentButton.ForeColor = SystemColors.Highlight;
            LoadTournamentButton.Location = new Point(168, 198);
            LoadTournamentButton.Name = "LoadTournamentButton";
            LoadTournamentButton.Size = new Size(218, 58);
            LoadTournamentButton.TabIndex = 31;
            LoadTournamentButton.Text = "Load Tournament";
            LoadTournamentButton.UseVisualStyleBackColor = true;
            // 
            // CreateTournamentbutton
            // 
            CreateTournamentbutton.FlatAppearance.BorderColor = Color.Silver;
            CreateTournamentbutton.FlatAppearance.MouseDownBackColor = Color.FromArgb(102, 102, 102);
            CreateTournamentbutton.FlatAppearance.MouseOverBackColor = Color.FromArgb(242, 242, 242);
            CreateTournamentbutton.FlatStyle = FlatStyle.Flat;
            CreateTournamentbutton.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            CreateTournamentbutton.ForeColor = SystemColors.Highlight;
            CreateTournamentbutton.Location = new Point(130, 275);
            CreateTournamentbutton.Name = "CreateTournamentbutton";
            CreateTournamentbutton.Size = new Size(294, 58);
            CreateTournamentbutton.TabIndex = 32;
            CreateTournamentbutton.Text = "Create Tournament";
            CreateTournamentbutton.UseVisualStyleBackColor = true;
            // 
            // TournamentDashboardFrom
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(615, 436);
            Controls.Add(CreateTournamentbutton);
            Controls.Add(LoadTournamentButton);
            Controls.Add(LoadExistingTournamentDashboardDropDown);
            Controls.Add(LoadExistingTournamentDashboardLabel);
            Controls.Add(TournamentDashboardLable);
            Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ForeColor = SystemColors.ButtonHighlight;
            Margin = new Padding(5, 6, 5, 6);
            Name = "TournamentDashboardFrom";
            Text = "Tournament Dashboard";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label TournamentDashboardLable;
        private ComboBox LoadExistingTournamentDashboardDropDown;
        private Label LoadExistingTournamentDashboardLabel;
        private Button LoadTournamentButton;
        private Button CreateTournamentbutton;
    }
}