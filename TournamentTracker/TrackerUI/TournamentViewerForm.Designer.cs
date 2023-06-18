namespace TrackerUI
{
    partial class TournamentViewerForm
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
            tournamentLabel = new Label();
            tournamentNameLabel = new Label();
            roundLabel = new Label();
            team1ScoreLabel = new Label();
            team2ScoreLabel = new Label();
            scoreLabel1 = new Label();
            scoreLabel2 = new Label();
            team1ScoreBox = new TextBox();
            team2ScoreBox = new TextBox();
            versusLabel = new Label();
            roundDropdown = new ComboBox();
            unplayedOnlyCheckBox = new CheckBox();
            matchupListBox = new ListBox();
            scoreButton = new Button();
            SuspendLayout();
            // 
            // tournamentLabel
            // 
            tournamentLabel.AutoSize = true;
            tournamentLabel.ForeColor = Color.DarkBlue;
            tournamentLabel.Location = new Point(50, 18);
            tournamentLabel.Margin = new Padding(5, 0, 5, 0);
            tournamentLabel.Name = "tournamentLabel";
            tournamentLabel.Size = new Size(209, 48);
            tournamentLabel.TabIndex = 0;
            tournamentLabel.Text = "Tournament";
            // 
            // tournamentNameLabel
            // 
            tournamentNameLabel.AutoSize = true;
            tournamentNameLabel.ForeColor = Color.DarkBlue;
            tournamentNameLabel.Location = new Point(286, 18);
            tournamentNameLabel.Margin = new Padding(5, 0, 5, 0);
            tournamentNameLabel.Name = "tournamentNameLabel";
            tournamentNameLabel.Size = new Size(259, 48);
            tournamentNameLabel.TabIndex = 1;
            tournamentNameLabel.Text = "<Tournament>";
            // 
            // roundLabel
            // 
            roundLabel.AutoSize = true;
            roundLabel.ForeColor = Color.DarkBlue;
            roundLabel.Location = new Point(66, 99);
            roundLabel.Margin = new Padding(5, 0, 5, 0);
            roundLabel.Name = "roundLabel";
            roundLabel.Size = new Size(123, 48);
            roundLabel.TabIndex = 2;
            roundLabel.Text = "Round";
            // 
            // team1ScoreLabel
            // 
            team1ScoreLabel.AutoSize = true;
            team1ScoreLabel.ForeColor = Color.DarkBlue;
            team1ScoreLabel.Location = new Point(758, 173);
            team1ScoreLabel.Margin = new Padding(5, 0, 5, 0);
            team1ScoreLabel.Name = "team1ScoreLabel";
            team1ScoreLabel.Size = new Size(132, 48);
            team1ScoreLabel.TabIndex = 3;
            team1ScoreLabel.Text = "Team 1";
            team1ScoreLabel.UseMnemonic = false;
            // 
            // team2ScoreLabel
            // 
            team2ScoreLabel.AutoSize = true;
            team2ScoreLabel.ForeColor = Color.DarkBlue;
            team2ScoreLabel.Location = new Point(758, 420);
            team2ScoreLabel.Margin = new Padding(5, 0, 5, 0);
            team2ScoreLabel.Name = "team2ScoreLabel";
            team2ScoreLabel.Size = new Size(132, 48);
            team2ScoreLabel.TabIndex = 4;
            team2ScoreLabel.Text = "Team 2";
            team2ScoreLabel.UseMnemonic = false;
            // 
            // scoreLabel1
            // 
            scoreLabel1.AutoSize = true;
            scoreLabel1.ForeColor = Color.DarkBlue;
            scoreLabel1.Location = new Point(611, 232);
            scoreLabel1.Margin = new Padding(5, 0, 5, 0);
            scoreLabel1.Name = "scoreLabel1";
            scoreLabel1.Size = new Size(109, 48);
            scoreLabel1.TabIndex = 5;
            scoreLabel1.Text = "Score";
            scoreLabel1.UseMnemonic = false;
            // 
            // scoreLabel2
            // 
            scoreLabel2.AutoSize = true;
            scoreLabel2.ForeColor = Color.DarkBlue;
            scoreLabel2.Location = new Point(611, 499);
            scoreLabel2.Margin = new Padding(5, 0, 5, 0);
            scoreLabel2.Name = "scoreLabel2";
            scoreLabel2.Size = new Size(109, 48);
            scoreLabel2.TabIndex = 6;
            scoreLabel2.Text = "Score";
            scoreLabel2.UseMnemonic = false;
            // 
            // team1ScoreBox
            // 
            team1ScoreBox.Location = new Point(749, 232);
            team1ScoreBox.Name = "team1ScoreBox";
            team1ScoreBox.Size = new Size(233, 55);
            team1ScoreBox.TabIndex = 7;
            // 
            // team2ScoreBox
            // 
            team2ScoreBox.Location = new Point(749, 492);
            team2ScoreBox.Name = "team2ScoreBox";
            team2ScoreBox.Size = new Size(233, 55);
            team2ScoreBox.TabIndex = 8;
            // 
            // versusLabel
            // 
            versusLabel.AutoSize = true;
            versusLabel.ForeColor = Color.DarkBlue;
            versusLabel.Location = new Point(801, 343);
            versusLabel.Margin = new Padding(5, 0, 5, 0);
            versusLabel.Name = "versusLabel";
            versusLabel.Size = new Size(75, 48);
            versusLabel.TabIndex = 9;
            versusLabel.Text = "V/S";
            versusLabel.UseMnemonic = false;
            // 
            // roundDropdown
            // 
            roundDropdown.FormattingEnabled = true;
            roundDropdown.Location = new Point(228, 99);
            roundDropdown.Name = "roundDropdown";
            roundDropdown.Size = new Size(301, 56);
            roundDropdown.TabIndex = 10;
            // 
            // unplayedOnlyCheckBox
            // 
            unplayedOnlyCheckBox.AutoSize = true;
            unplayedOnlyCheckBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            unplayedOnlyCheckBox.ForeColor = Color.FromArgb(0, 0, 192);
            unplayedOnlyCheckBox.Location = new Point(228, 185);
            unplayedOnlyCheckBox.Name = "unplayedOnlyCheckBox";
            unplayedOnlyCheckBox.Size = new Size(198, 36);
            unplayedOnlyCheckBox.TabIndex = 11;
            unplayedOnlyCheckBox.Text = "Unplayed Only";
            unplayedOnlyCheckBox.UseVisualStyleBackColor = true;
            // 
            // matchupListBox
            // 
            matchupListBox.BorderStyle = BorderStyle.FixedSingle;
            matchupListBox.FormattingEnabled = true;
            matchupListBox.ItemHeight = 48;
            matchupListBox.Location = new Point(68, 230);
            matchupListBox.Name = "matchupListBox";
            matchupListBox.Size = new Size(535, 482);
            matchupListBox.TabIndex = 12;
            // 
            // scoreButton
            // 
            scoreButton.FlatAppearance.BorderColor = Color.Silver;
            scoreButton.FlatAppearance.BorderSize = 5;
            scoreButton.FlatAppearance.MouseDownBackColor = Color.Silver;
            scoreButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(192, 192, 255);
            scoreButton.FlatStyle = FlatStyle.Flat;
            scoreButton.ForeColor = Color.Black;
            scoreButton.Location = new Point(1012, 326);
            scoreButton.Name = "scoreButton";
            scoreButton.Size = new Size(142, 100);
            scoreButton.TabIndex = 13;
            scoreButton.Text = "Score";
            scoreButton.UseVisualStyleBackColor = true;
            // 
            // TournamentViewerForm
            // 
            AutoScaleDimensions = new SizeF(20F, 48F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1222, 731);
            Controls.Add(scoreButton);
            Controls.Add(matchupListBox);
            Controls.Add(unplayedOnlyCheckBox);
            Controls.Add(roundDropdown);
            Controls.Add(versusLabel);
            Controls.Add(team2ScoreBox);
            Controls.Add(team1ScoreBox);
            Controls.Add(scoreLabel2);
            Controls.Add(scoreLabel1);
            Controls.Add(team2ScoreLabel);
            Controls.Add(team1ScoreLabel);
            Controls.Add(roundLabel);
            Controls.Add(tournamentNameLabel);
            Controls.Add(tournamentLabel);
            Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(5, 6, 5, 6);
            Name = "TournamentViewerForm";
            Text = "Tournament Viewer";
            Load += TournamentViewerForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label tournamentLabel;
        private Label tournamentNameLabel;
        private Label roundLabel;
        private Label team1ScoreLabel;
        private Label team2ScoreLabel;
        private Label scoreLabel1;
        private Label scoreLabel2;
        private TextBox team1ScoreBox;
        private TextBox team2ScoreBox;
        private Label versusLabel;
        private ComboBox roundDropdown;
        private CheckBox unplayedOnlyCheckBox;
        private ListBox matchupListBox;
        private Button scoreButton;
    }
}