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
            label1 = new Label();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            tournamentLabel1 = new Label();
            inputTeamNameBox = new TextBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            inputFirstName = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            selectTeamMemberDropdown = new ComboBox();
            addTeamMemberButton = new Button();
            addNewMemberBox = new GroupBox();
            createMemberButton = new Button();
            teamMembersListBox = new ListBox();
            deleteSelectedPlayerButton = new Button();
            createTeamButton = new Button();
            addNewMemberBox.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.DarkBlue;
            label1.Location = new Point(36, 21);
            label1.Margin = new Padding(5, 0, 5, 0);
            label1.Name = "label1";
            label1.Size = new Size(216, 48);
            label1.TabIndex = 11;
            label1.Text = "Create Team";
            // 
            // tournamentLabel1
            // 
            tournamentLabel1.AutoSize = true;
            tournamentLabel1.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            tournamentLabel1.ForeColor = Color.DarkBlue;
            tournamentLabel1.Location = new Point(27, 95);
            tournamentLabel1.Margin = new Padding(5, 0, 5, 0);
            tournamentLabel1.Name = "tournamentLabel1";
            tournamentLabel1.Size = new Size(164, 38);
            tournamentLabel1.TabIndex = 12;
            tournamentLabel1.Text = "Team Name";
            tournamentLabel1.Click += tournamentLabel1_Click;
            // 
            // inputTeamNameBox
            // 
            inputTeamNameBox.Location = new Point(237, 95);
            inputTeamNameBox.Name = "inputTeamNameBox";
            inputTeamNameBox.Size = new Size(555, 31);
            inputTeamNameBox.TabIndex = 13;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.DarkBlue;
            label2.Location = new Point(23, 152);
            label2.Margin = new Padding(5, 0, 5, 0);
            label2.Name = "label2";
            label2.Size = new Size(204, 38);
            label2.TabIndex = 14;
            label2.Text = "Select Member";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.DarkBlue;
            label3.Location = new Point(17, 42);
            label3.Margin = new Padding(5, 0, 5, 0);
            label3.Name = "label3";
            label3.Size = new Size(151, 38);
            label3.TabIndex = 15;
            label3.Text = "First Name";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = Color.DarkBlue;
            label4.Location = new Point(17, 90);
            label4.Margin = new Padding(5, 0, 5, 0);
            label4.Name = "label4";
            label4.Size = new Size(147, 38);
            label4.TabIndex = 16;
            label4.Text = "Last Name";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = Color.DarkBlue;
            label5.Location = new Point(17, 135);
            label5.Margin = new Padding(5, 0, 5, 0);
            label5.Name = "label5";
            label5.Size = new Size(190, 38);
            label5.TabIndex = 17;
            label5.Text = "Email Address";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label6.ForeColor = Color.DarkBlue;
            label6.Location = new Point(17, 183);
            label6.Margin = new Padding(5, 0, 5, 0);
            label6.Name = "label6";
            label6.Size = new Size(206, 38);
            label6.TabIndex = 18;
            label6.Text = "Phone Number";
            // 
            // inputFirstName
            // 
            inputFirstName.Location = new Point(258, 42);
            inputFirstName.Name = "inputFirstName";
            inputFirstName.Size = new Size(423, 31);
            inputFirstName.TabIndex = 19;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(258, 97);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(423, 31);
            textBox2.TabIndex = 20;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(258, 138);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(423, 31);
            textBox3.TabIndex = 21;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(258, 191);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(423, 31);
            textBox4.TabIndex = 22;
            // 
            // selectTeamMemberDropdown
            // 
            selectTeamMemberDropdown.FormattingEnabled = true;
            selectTeamMemberDropdown.Location = new Point(235, 152);
            selectTeamMemberDropdown.Name = "selectTeamMemberDropdown";
            selectTeamMemberDropdown.Size = new Size(557, 33);
            selectTeamMemberDropdown.TabIndex = 23;
            // 
            // addTeamMemberButton
            // 
            addTeamMemberButton.Location = new Point(326, 203);
            addTeamMemberButton.Name = "addTeamMemberButton";
            addTeamMemberButton.Size = new Size(180, 61);
            addTeamMemberButton.TabIndex = 24;
            addTeamMemberButton.Text = "Add Member";
            addTeamMemberButton.UseVisualStyleBackColor = true;
            // 
            // addNewMemberBox
            // 
            addNewMemberBox.Controls.Add(createMemberButton);
            addNewMemberBox.Controls.Add(label3);
            addNewMemberBox.Controls.Add(inputFirstName);
            addNewMemberBox.Controls.Add(textBox2);
            addNewMemberBox.Controls.Add(label6);
            addNewMemberBox.Controls.Add(textBox4);
            addNewMemberBox.Controls.Add(label4);
            addNewMemberBox.Controls.Add(textBox3);
            addNewMemberBox.Controls.Add(label5);
            addNewMemberBox.Location = new Point(23, 270);
            addNewMemberBox.Name = "addNewMemberBox";
            addNewMemberBox.Size = new Size(770, 319);
            addNewMemberBox.TabIndex = 25;
            addNewMemberBox.TabStop = false;
            addNewMemberBox.Text = "Add New Member";
            // 
            // createMemberButton
            // 
            createMemberButton.Location = new Point(303, 241);
            createMemberButton.Name = "createMemberButton";
            createMemberButton.Size = new Size(180, 61);
            createMemberButton.TabIndex = 26;
            createMemberButton.Text = "Create Member";
            createMemberButton.UseVisualStyleBackColor = true;
            // 
            // teamMembersListBox
            // 
            teamMembersListBox.FormattingEnabled = true;
            teamMembersListBox.ItemHeight = 25;
            teamMembersListBox.Location = new Point(881, 88);
            teamMembersListBox.Name = "teamMembersListBox";
            teamMembersListBox.Size = new Size(430, 504);
            teamMembersListBox.TabIndex = 26;
            // 
            // deleteSelectedPlayerButton
            // 
            deleteSelectedPlayerButton.FlatAppearance.BorderColor = Color.Silver;
            deleteSelectedPlayerButton.FlatAppearance.BorderSize = 5;
            deleteSelectedPlayerButton.FlatAppearance.MouseDownBackColor = Color.Silver;
            deleteSelectedPlayerButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(192, 192, 255);
            deleteSelectedPlayerButton.FlatStyle = FlatStyle.Flat;
            deleteSelectedPlayerButton.ForeColor = Color.Black;
            deleteSelectedPlayerButton.Location = new Point(1363, 193);
            deleteSelectedPlayerButton.Name = "deleteSelectedPlayerButton";
            deleteSelectedPlayerButton.Size = new Size(167, 118);
            deleteSelectedPlayerButton.TabIndex = 27;
            deleteSelectedPlayerButton.Text = "Delete Selected Member";
            deleteSelectedPlayerButton.UseVisualStyleBackColor = true;
            // 
            // createTeamButton
            // 
            createTeamButton.Location = new Point(524, 629);
            createTeamButton.Name = "createTeamButton";
            createTeamButton.Size = new Size(364, 61);
            createTeamButton.TabIndex = 28;
            createTeamButton.Text = "Create Team";
            createTeamButton.UseVisualStyleBackColor = true;
            // 
            // CreateTeamForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1589, 774);
            Controls.Add(createTeamButton);
            Controls.Add(deleteSelectedPlayerButton);
            Controls.Add(teamMembersListBox);
            Controls.Add(addNewMemberBox);
            Controls.Add(addTeamMemberButton);
            Controls.Add(selectTeamMemberDropdown);
            Controls.Add(label2);
            Controls.Add(inputTeamNameBox);
            Controls.Add(tournamentLabel1);
            Controls.Add(label1);
            Name = "CreateTeamForm";
            Text = "CreateTeamForm";
            addNewMemberBox.ResumeLayout(false);
            addNewMemberBox.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Label tournamentLabel1;
        private TextBox inputTeamNameBox;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox inputFirstName;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private ComboBox selectTeamMemberDropdown;
        private Button addTeamMemberButton;
        private GroupBox addNewMemberBox;
        private Button createMemberButton;
        private ListBox teamMembersListBox;
        private Button deleteSelectedPlayerButton;
        private Button createTeamButton;
    }
}