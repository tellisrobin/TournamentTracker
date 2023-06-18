namespace TrackerUI
{
    partial class TournamentDashboard
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
            createPrizeLabel = new Label();
            tournamentLabel1 = new Label();
            selectTournamentDropdown = new ComboBox();
            loadTournamentButton = new Button();
            createTounamentButton = new Button();
            SuspendLayout();
            // 
            // createPrizeLabel
            // 
            createPrizeLabel.AutoSize = true;
            createPrizeLabel.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point);
            createPrizeLabel.ForeColor = Color.DarkBlue;
            createPrizeLabel.Location = new Point(173, 67);
            createPrizeLabel.Margin = new Padding(5, 0, 5, 0);
            createPrizeLabel.Name = "createPrizeLabel";
            createPrizeLabel.Size = new Size(523, 65);
            createPrizeLabel.TabIndex = 28;
            createPrizeLabel.Text = "Tournament Dashboard";
            // 
            // tournamentLabel1
            // 
            tournamentLabel1.AutoSize = true;
            tournamentLabel1.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            tournamentLabel1.ForeColor = Color.DarkBlue;
            tournamentLabel1.Location = new Point(267, 181);
            tournamentLabel1.Margin = new Padding(5, 0, 5, 0);
            tournamentLabel1.Name = "tournamentLabel1";
            tournamentLabel1.Size = new Size(334, 38);
            tournamentLabel1.TabIndex = 29;
            tournamentLabel1.Text = "Load Existing Tournament";
            // 
            // selectTournamentDropdown
            // 
            selectTournamentDropdown.FormattingEnabled = true;
            selectTournamentDropdown.Location = new Point(156, 233);
            selectTournamentDropdown.Name = "selectTournamentDropdown";
            selectTournamentDropdown.Size = new Size(557, 40);
            selectTournamentDropdown.TabIndex = 30;
            // 
            // loadTournamentButton
            // 
            loadTournamentButton.Location = new Point(262, 301);
            loadTournamentButton.Name = "loadTournamentButton";
            loadTournamentButton.Size = new Size(339, 71);
            loadTournamentButton.TabIndex = 31;
            loadTournamentButton.Text = "Load Tournament";
            loadTournamentButton.UseVisualStyleBackColor = true;
            // 
            // createTounamentButton
            // 
            createTounamentButton.Location = new Point(200, 418);
            createTounamentButton.Name = "createTounamentButton";
            createTounamentButton.Size = new Size(468, 114);
            createTounamentButton.TabIndex = 32;
            createTounamentButton.Text = "Create Tournament";
            createTounamentButton.UseVisualStyleBackColor = true;
            // 
            // TournamentDashboard
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(868, 618);
            Controls.Add(createTounamentButton);
            Controls.Add(loadTournamentButton);
            Controls.Add(selectTournamentDropdown);
            Controls.Add(tournamentLabel1);
            Controls.Add(createPrizeLabel);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(4, 4, 4, 4);
            Name = "TournamentDashboard";
            Text = "TournamentDashboard";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label createPrizeLabel;
        private Label tournamentLabel1;
        private ComboBox selectTournamentDropdown;
        private Button loadTournamentButton;
        private Button createTounamentButton;
    }
}