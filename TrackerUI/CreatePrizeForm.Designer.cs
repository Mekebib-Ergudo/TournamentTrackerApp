namespace TrackerUI
{
    partial class CreatePrizeForm
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
            CreatePrizeLable = new Label();
            PlaceNumberTextBox = new TextBox();
            PlaceNumberLabel = new Label();
            PlaceNametextBox = new TextBox();
            PlaceNamelabel = new Label();
            PlaceAmounttextBox = new TextBox();
            PlaceAmountlabel = new Label();
            PrizePercentagetextBox = new TextBox();
            PrizePercentagelabel = new Label();
            Orlabel = new Label();
            CreatePrizebutton = new Button();
            SuspendLayout();
            // 
            // CreatePrizeLable
            // 
            CreatePrizeLable.AutoSize = true;
            CreatePrizeLable.Font = new Font("Segoe UI Light", 27.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            CreatePrizeLable.ForeColor = SystemColors.Highlight;
            CreatePrizeLable.Location = new Point(231, 21);
            CreatePrizeLable.Name = "CreatePrizeLable";
            CreatePrizeLable.Size = new Size(209, 50);
            CreatePrizeLable.TabIndex = 12;
            CreatePrizeLable.Text = "Create Prize";
            // 
            // PlaceNumberTextBox
            // 
            PlaceNumberTextBox.Location = new Point(249, 91);
            PlaceNumberTextBox.Name = "PlaceNumberTextBox";
            PlaceNumberTextBox.Size = new Size(208, 35);
            PlaceNumberTextBox.TabIndex = 22;
            // 
            // PlaceNumberLabel
            // 
            PlaceNumberLabel.AutoSize = true;
            PlaceNumberLabel.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            PlaceNumberLabel.ForeColor = SystemColors.MenuHighlight;
            PlaceNumberLabel.Location = new Point(31, 88);
            PlaceNumberLabel.Name = "PlaceNumberLabel";
            PlaceNumberLabel.Size = new Size(183, 37);
            PlaceNumberLabel.TabIndex = 21;
            PlaceNumberLabel.Text = "Place Number";
            // 
            // PlaceNametextBox
            // 
            PlaceNametextBox.Location = new Point(249, 132);
            PlaceNametextBox.Name = "PlaceNametextBox";
            PlaceNametextBox.Size = new Size(208, 35);
            PlaceNametextBox.TabIndex = 24;
            // 
            // PlaceNamelabel
            // 
            PlaceNamelabel.AutoSize = true;
            PlaceNamelabel.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            PlaceNamelabel.ForeColor = SystemColors.MenuHighlight;
            PlaceNamelabel.Location = new Point(31, 129);
            PlaceNamelabel.Name = "PlaceNamelabel";
            PlaceNamelabel.Size = new Size(157, 37);
            PlaceNamelabel.TabIndex = 23;
            PlaceNamelabel.Text = "Place Name";
            // 
            // PlaceAmounttextBox
            // 
            PlaceAmounttextBox.Location = new Point(249, 173);
            PlaceAmounttextBox.Name = "PlaceAmounttextBox";
            PlaceAmounttextBox.Size = new Size(208, 35);
            PlaceAmounttextBox.TabIndex = 26;
            // 
            // PlaceAmountlabel
            // 
            PlaceAmountlabel.AutoSize = true;
            PlaceAmountlabel.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            PlaceAmountlabel.ForeColor = SystemColors.MenuHighlight;
            PlaceAmountlabel.Location = new Point(31, 170);
            PlaceAmountlabel.Name = "PlaceAmountlabel";
            PlaceAmountlabel.Size = new Size(181, 37);
            PlaceAmountlabel.TabIndex = 25;
            PlaceAmountlabel.Text = "Place Amount";
            // 
            // PrizePercentagetextBox
            // 
            PrizePercentagetextBox.Location = new Point(249, 255);
            PrizePercentagetextBox.Name = "PrizePercentagetextBox";
            PrizePercentagetextBox.Size = new Size(208, 35);
            PrizePercentagetextBox.TabIndex = 28;
            // 
            // PrizePercentagelabel
            // 
            PrizePercentagelabel.AutoSize = true;
            PrizePercentagelabel.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            PrizePercentagelabel.ForeColor = SystemColors.MenuHighlight;
            PrizePercentagelabel.Location = new Point(31, 252);
            PrizePercentagelabel.Name = "PrizePercentagelabel";
            PrizePercentagelabel.Size = new Size(212, 37);
            PrizePercentagelabel.TabIndex = 27;
            PrizePercentagelabel.Text = "Prize Percentage";
            // 
            // Orlabel
            // 
            Orlabel.AutoSize = true;
            Orlabel.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Orlabel.ForeColor = SystemColors.MenuHighlight;
            Orlabel.Location = new Point(194, 215);
            Orlabel.Name = "Orlabel";
            Orlabel.Size = new Size(68, 37);
            Orlabel.TabIndex = 29;
            Orlabel.Text = "-Or-";
            // 
            // CreatePrizebutton
            // 
            CreatePrizebutton.FlatAppearance.BorderColor = Color.Silver;
            CreatePrizebutton.FlatAppearance.MouseDownBackColor = Color.Teal;
            CreatePrizebutton.FlatAppearance.MouseOverBackColor = Color.SeaShell;
            CreatePrizebutton.FlatStyle = FlatStyle.Flat;
            CreatePrizebutton.ForeColor = SystemColors.Highlight;
            CreatePrizebutton.Location = new Point(249, 316);
            CreatePrizebutton.Name = "CreatePrizebutton";
            CreatePrizebutton.Size = new Size(208, 65);
            CreatePrizebutton.TabIndex = 30;
            CreatePrizebutton.Text = "Prize Button";
            CreatePrizebutton.UseVisualStyleBackColor = true;
            // 
            // CreatePrizeForm
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(628, 506);
            Controls.Add(CreatePrizebutton);
            Controls.Add(Orlabel);
            Controls.Add(PrizePercentagetextBox);
            Controls.Add(PrizePercentagelabel);
            Controls.Add(PlaceAmounttextBox);
            Controls.Add(PlaceAmountlabel);
            Controls.Add(PlaceNametextBox);
            Controls.Add(PlaceNamelabel);
            Controls.Add(PlaceNumberTextBox);
            Controls.Add(PlaceNumberLabel);
            Controls.Add(CreatePrizeLable);
            Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ForeColor = SystemColors.ButtonHighlight;
            Margin = new Padding(5, 6, 5, 6);
            Name = "CreatePrizeForm";
            Text = "Create Prize";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label CreatePrizeLable;
        private TextBox PlaceNumberTextBox;
        private Label PlaceNumberLabel;
        private TextBox PlaceNametextBox;
        private Label PlaceNamelabel;
        private TextBox PlaceAmounttextBox;
        private Label PlaceAmountlabel;
        private TextBox PrizePercentagetextBox;
        private Label PrizePercentagelabel;
        private Label Orlabel;
        private Button CreatePrizebutton;
    }
}