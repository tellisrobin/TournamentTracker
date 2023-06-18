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
            tournamentLabel1 = new Label();
            inputTournamentNameBox = new TextBox();
            entryFeeLabel = new Label();
            inputEntryFee = new TextBox();
            selectTeamLabel = new Label();
            selectTeamDropdown = new ComboBox();
            createNewTeamLink = new LinkLabel();
            addTeamButton = new Button();
            createPrizeButton = new Button();
            label1 = new Label();
            tournamentPlayerListBox = new ListBox();
            tournamentPlayersLabel = new Label();
            prizesLabel = new Label();
            deletePlayerButton = new Button();
            prizesListBox = new ListBox();
            deletePrizeButton = new Button();
            createTournamentButton = new Button();
            SuspendLayout();
            // 
            // tournamentLabel1
            // 
            tournamentLabel1.AutoSize = true;
            tournamentLabel1.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            tournamentLabel1.ForeColor = Color.DarkBlue;
            tournamentLabel1.Location = new Point(84, 69);
            tournamentLabel1.Margin = new Padding(5, 0, 5, 0);
            tournamentLabel1.Name = "tournamentLabel1";
            tournamentLabel1.Size = new Size(247, 38);
            tournamentLabel1.TabIndex = 1;
            tournamentLabel1.Text = "Tournament Name";
            // 
            // inputTournamentNameBox
            // 
            inputTournamentNameBox.Location = new Point(84, 114);
            inputTournamentNameBox.Name = "inputTournamentNameBox";
            inputTournamentNameBox.Size = new Size(557, 39);
            inputTournamentNameBox.TabIndex = 2;
            // 
            // entryFeeLabel
            // 
            entryFeeLabel.AutoSize = true;
            entryFeeLabel.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            entryFeeLabel.ForeColor = Color.DarkBlue;
            entryFeeLabel.Location = new Point(84, 188);
            entryFeeLabel.Margin = new Padding(5, 0, 5, 0);
            entryFeeLabel.Name = "entryFeeLabel";
            entryFeeLabel.Size = new Size(132, 38);
            entryFeeLabel.TabIndex = 3;
            entryFeeLabel.Text = "Entry Fee\r\n";
            // 
            // inputEntryFee
            // 
            inputEntryFee.Location = new Point(224, 188);
            inputEntryFee.Name = "inputEntryFee";
            inputEntryFee.Size = new Size(150, 39);
            inputEntryFee.TabIndex = 4;
            inputEntryFee.Text = "0";
            // 
            // selectTeamLabel
            // 
            selectTeamLabel.AutoSize = true;
            selectTeamLabel.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            selectTeamLabel.ForeColor = Color.DarkBlue;
            selectTeamLabel.Location = new Point(84, 263);
            selectTeamLabel.Margin = new Padding(5, 0, 5, 0);
            selectTeamLabel.Name = "selectTeamLabel";
            selectTeamLabel.Size = new Size(164, 38);
            selectTeamLabel.TabIndex = 5;
            selectTeamLabel.Text = "Select Team";
            // 
            // selectTeamDropdown
            // 
            selectTeamDropdown.FormattingEnabled = true;
            selectTeamDropdown.Location = new Point(84, 314);
            selectTeamDropdown.Name = "selectTeamDropdown";
            selectTeamDropdown.Size = new Size(557, 40);
            selectTeamDropdown.TabIndex = 6;
            // 
            // createNewTeamLink
            // 
            createNewTeamLink.AutoSize = true;
            createNewTeamLink.Location = new Point(465, 269);
            createNewTeamLink.Name = "createNewTeamLink";
            createNewTeamLink.Size = new Size(202, 32);
            createNewTeamLink.TabIndex = 7;
            createNewTeamLink.TabStop = true;
            createNewTeamLink.Text = "Create New Team";
            // 
            // addTeamButton
            // 
            addTeamButton.Location = new Point(84, 362);
            addTeamButton.Name = "addTeamButton";
            addTeamButton.Size = new Size(180, 61);
            addTeamButton.TabIndex = 8;
            addTeamButton.Text = "Add Team";
            addTeamButton.UseVisualStyleBackColor = true;
            // 
            // createPrizeButton
            // 
            createPrizeButton.Location = new Point(84, 444);
            createPrizeButton.Name = "createPrizeButton";
            createPrizeButton.Size = new Size(180, 61);
            createPrizeButton.TabIndex = 9;
            createPrizeButton.Text = "Create Prize";
            createPrizeButton.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.DarkBlue;
            label1.Location = new Point(84, 9);
            label1.Margin = new Padding(5, 0, 5, 0);
            label1.Name = "label1";
            label1.Size = new Size(322, 48);
            label1.TabIndex = 10;
            label1.Text = "Create Tournament";
            // 
            // tournamentPlayerListBox
            // 
            tournamentPlayerListBox.FormattingEnabled = true;
            tournamentPlayerListBox.ItemHeight = 32;
            tournamentPlayerListBox.Location = new Point(748, 84);
            tournamentPlayerListBox.Name = "tournamentPlayerListBox";
            tournamentPlayerListBox.Size = new Size(341, 196);
            tournamentPlayerListBox.TabIndex = 11;
            // 
            // tournamentPlayersLabel
            // 
            tournamentPlayersLabel.AutoSize = true;
            tournamentPlayersLabel.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            tournamentPlayersLabel.ForeColor = Color.DarkBlue;
            tournamentPlayersLabel.Location = new Point(748, 31);
            tournamentPlayersLabel.Margin = new Padding(5, 0, 5, 0);
            tournamentPlayersLabel.Name = "tournamentPlayersLabel";
            tournamentPlayersLabel.Size = new Size(193, 38);
            tournamentPlayersLabel.TabIndex = 12;
            tournamentPlayersLabel.Text = "Teams/Players";
            // 
            // prizesLabel
            // 
            prizesLabel.AutoSize = true;
            prizesLabel.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            prizesLabel.ForeColor = Color.DarkBlue;
            prizesLabel.Location = new Point(748, 297);
            prizesLabel.Margin = new Padding(5, 0, 5, 0);
            prizesLabel.Name = "prizesLabel";
            prizesLabel.Size = new Size(90, 38);
            prizesLabel.TabIndex = 13;
            prizesLabel.Text = "Prizes";
            // 
            // deletePlayerButton
            // 
            deletePlayerButton.FlatAppearance.BorderColor = Color.Silver;
            deletePlayerButton.FlatAppearance.BorderSize = 5;
            deletePlayerButton.FlatAppearance.MouseDownBackColor = Color.Silver;
            deletePlayerButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(192, 192, 255);
            deletePlayerButton.FlatStyle = FlatStyle.Flat;
            deletePlayerButton.ForeColor = Color.Black;
            deletePlayerButton.Location = new Point(1119, 126);
            deletePlayerButton.Name = "deletePlayerButton";
            deletePlayerButton.Size = new Size(167, 118);
            deletePlayerButton.TabIndex = 14;
            deletePlayerButton.Text = "Delete Selected Player";
            deletePlayerButton.UseVisualStyleBackColor = true;
            // 
            // prizesListBox
            // 
            prizesListBox.FormattingEnabled = true;
            prizesListBox.ItemHeight = 32;
            prizesListBox.Location = new Point(748, 340);
            prizesListBox.Name = "prizesListBox";
            prizesListBox.Size = new Size(341, 196);
            prizesListBox.TabIndex = 15;
            // 
            // deletePrizeButton
            // 
            deletePrizeButton.FlatAppearance.BorderColor = Color.Silver;
            deletePrizeButton.FlatAppearance.BorderSize = 5;
            deletePrizeButton.FlatAppearance.MouseDownBackColor = Color.Silver;
            deletePrizeButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(192, 192, 255);
            deletePrizeButton.FlatStyle = FlatStyle.Flat;
            deletePrizeButton.ForeColor = Color.Black;
            deletePrizeButton.Location = new Point(1119, 362);
            deletePrizeButton.Name = "deletePrizeButton";
            deletePrizeButton.Size = new Size(167, 117);
            deletePrizeButton.TabIndex = 16;
            deletePrizeButton.Text = "Delete Selected Prize";
            deletePrizeButton.UseVisualStyleBackColor = true;
            // 
            // createTournamentButton
            // 
            createTournamentButton.Location = new Point(342, 444);
            createTournamentButton.Name = "createTournamentButton";
            createTournamentButton.Size = new Size(364, 61);
            createTournamentButton.TabIndex = 17;
            createTournamentButton.Text = "Create Tournament";
            createTournamentButton.UseVisualStyleBackColor = true;
            // 
            // CreateTournamentForm
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1310, 576);
            Controls.Add(createTournamentButton);
            Controls.Add(deletePrizeButton);
            Controls.Add(prizesListBox);
            Controls.Add(deletePlayerButton);
            Controls.Add(prizesLabel);
            Controls.Add(tournamentPlayersLabel);
            Controls.Add(tournamentPlayerListBox);
            Controls.Add(label1);
            Controls.Add(createPrizeButton);
            Controls.Add(addTeamButton);
            Controls.Add(createNewTeamLink);
            Controls.Add(selectTeamDropdown);
            Controls.Add(selectTeamLabel);
            Controls.Add(inputEntryFee);
            Controls.Add(entryFeeLabel);
            Controls.Add(inputTournamentNameBox);
            Controls.Add(tournamentLabel1);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            ForeColor = Color.DodgerBlue;
            Margin = new Padding(4);
            Name = "CreateTournamentForm";
            Text = "CreateTournamentForm";
            Load += CreateTournamentForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label tournamentLabel1;
        private TextBox inputTournamentNameBox;
        private Label entryFeeLabel;
        private TextBox inputEntryFee;
        private Label selectTeamLabel;
        private ComboBox selectTeamDropdown;
        private LinkLabel createNewTeamLink;
        private Button addTeamButton;
        private Button createPrizeButton;
        private Label label1;
        private ListBox tournamentPlayerListBox;
        private Label tournamentPlayersLabel;
        private Label prizesLabel;
        private Button deletePlayerButton;
        private ListBox prizesListBox;
        private Button deletePrizeButton;
        private Button createTournamentButton;
    }
}