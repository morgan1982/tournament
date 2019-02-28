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
            this.CreateTrounamentLabel = new System.Windows.Forms.Label();
            this.createTournamentTextBox = new System.Windows.Forms.TextBox();
            this.CreateTournamentLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SelectTeamDropDown = new System.Windows.Forms.ComboBox();
            this.createTeamLinkLabel = new System.Windows.Forms.LinkLabel();
            this.addNameBtn = new System.Windows.Forms.Button();
            this.createPrizeBtn = new System.Windows.Forms.Button();
            this.TournamentPlayersListBox = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.deletePlayerBtn = new System.Windows.Forms.Button();
            this.deletePrizeBtn = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.prizesListBox = new System.Windows.Forms.ListBox();
            this.createTournamentBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // CreateTrounamentLabel
            // 
            this.CreateTrounamentLabel.AutoSize = true;
            this.CreateTrounamentLabel.Location = new System.Drawing.Point(22, 22);
            this.CreateTrounamentLabel.Name = "CreateTrounamentLabel";
            this.CreateTrounamentLabel.Size = new System.Drawing.Size(190, 30);
            this.CreateTrounamentLabel.TabIndex = 0;
            this.CreateTrounamentLabel.Text = "Create Tournament";
            this.CreateTrounamentLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // createTournamentTextBox
            // 
            this.createTournamentTextBox.Location = new System.Drawing.Point(27, 114);
            this.createTournamentTextBox.Name = "createTournamentTextBox";
            this.createTournamentTextBox.Size = new System.Drawing.Size(263, 35);
            this.createTournamentTextBox.TabIndex = 1;
            // 
            // CreateTournamentLabel
            // 
            this.CreateTournamentLabel.AutoSize = true;
            this.CreateTournamentLabel.Location = new System.Drawing.Point(22, 81);
            this.CreateTournamentLabel.Name = "CreateTournamentLabel";
            this.CreateTournamentLabel.Size = new System.Drawing.Size(186, 30);
            this.CreateTournamentLabel.TabIndex = 2;
            this.CreateTournamentLabel.Text = "Tournament Name";
            this.CreateTournamentLabel.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 187);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 30);
            this.label1.TabIndex = 3;
            this.label1.Text = "Entry Fee";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(127, 187);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 35);
            this.textBox1.TabIndex = 4;
            this.textBox1.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 258);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 30);
            this.label2.TabIndex = 5;
            this.label2.Text = "Select Team";
            // 
            // SelectTeamDropDown
            // 
            this.SelectTeamDropDown.FormattingEnabled = true;
            this.SelectTeamDropDown.Location = new System.Drawing.Point(27, 303);
            this.SelectTeamDropDown.Name = "SelectTeamDropDown";
            this.SelectTeamDropDown.Size = new System.Drawing.Size(263, 38);
            this.SelectTeamDropDown.TabIndex = 6;
            // 
            // createTeamLinkLabel
            // 
            this.createTeamLinkLabel.AutoSize = true;
            this.createTeamLinkLabel.Location = new System.Drawing.Point(185, 258);
            this.createTeamLinkLabel.Name = "createTeamLinkLabel";
            this.createTeamLinkLabel.Size = new System.Drawing.Size(114, 30);
            this.createTeamLinkLabel.TabIndex = 7;
            this.createTeamLinkLabel.TabStop = true;
            this.createTeamLinkLabel.Text = "create new";
            // 
            // addNameBtn
            // 
            this.addNameBtn.Location = new System.Drawing.Point(27, 372);
            this.addNameBtn.Name = "addNameBtn";
            this.addNameBtn.Size = new System.Drawing.Size(149, 62);
            this.addNameBtn.TabIndex = 8;
            this.addNameBtn.Text = "Add Team";
            this.addNameBtn.UseVisualStyleBackColor = true;
            // 
            // createPrizeBtn
            // 
            this.createPrizeBtn.Location = new System.Drawing.Point(190, 372);
            this.createPrizeBtn.Name = "createPrizeBtn";
            this.createPrizeBtn.Size = new System.Drawing.Size(149, 62);
            this.createPrizeBtn.TabIndex = 9;
            this.createPrizeBtn.Text = "Create Prize";
            this.createPrizeBtn.UseVisualStyleBackColor = true;
            // 
            // TournamentPlayersListBox
            // 
            this.TournamentPlayersListBox.FormattingEnabled = true;
            this.TournamentPlayersListBox.ItemHeight = 30;
            this.TournamentPlayersListBox.Location = new System.Drawing.Point(388, 104);
            this.TournamentPlayersListBox.Name = "TournamentPlayersListBox";
            this.TournamentPlayersListBox.Size = new System.Drawing.Size(265, 154);
            this.TournamentPlayersListBox.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(383, 60);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(156, 30);
            this.label3.TabIndex = 11;
            this.label3.Text = "Teams / Players";
            // 
            // deletePlayerBtn
            // 
            this.deletePlayerBtn.Location = new System.Drawing.Point(679, 187);
            this.deletePlayerBtn.Name = "deletePlayerBtn";
            this.deletePlayerBtn.Size = new System.Drawing.Size(149, 72);
            this.deletePlayerBtn.TabIndex = 12;
            this.deletePlayerBtn.Text = "Delete Selected";
            this.deletePlayerBtn.UseVisualStyleBackColor = true;
            // 
            // deletePrizeBtn
            // 
            this.deletePrizeBtn.Location = new System.Drawing.Point(679, 393);
            this.deletePrizeBtn.Name = "deletePrizeBtn";
            this.deletePrizeBtn.Size = new System.Drawing.Size(149, 86);
            this.deletePrizeBtn.TabIndex = 15;
            this.deletePrizeBtn.Text = "Delete Selected";
            this.deletePrizeBtn.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(383, 311);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(156, 30);
            this.label4.TabIndex = 14;
            this.label4.Text = "Teams / Players";
            // 
            // prizesListBox
            // 
            this.prizesListBox.FormattingEnabled = true;
            this.prizesListBox.ItemHeight = 30;
            this.prizesListBox.Location = new System.Drawing.Point(388, 355);
            this.prizesListBox.Name = "prizesListBox";
            this.prizesListBox.Size = new System.Drawing.Size(265, 124);
            this.prizesListBox.TabIndex = 13;
            // 
            // createTournamentBtn
            // 
            this.createTournamentBtn.Location = new System.Drawing.Point(283, 533);
            this.createTournamentBtn.Name = "createTournamentBtn";
            this.createTournamentBtn.Size = new System.Drawing.Size(256, 62);
            this.createTournamentBtn.TabIndex = 16;
            this.createTournamentBtn.Text = "Create Tournament";
            this.createTournamentBtn.UseVisualStyleBackColor = true;
            // 
            // CreateTournamentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(911, 643);
            this.Controls.Add(this.createTournamentBtn);
            this.Controls.Add(this.deletePrizeBtn);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.prizesListBox);
            this.Controls.Add(this.deletePlayerBtn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TournamentPlayersListBox);
            this.Controls.Add(this.createPrizeBtn);
            this.Controls.Add(this.addNameBtn);
            this.Controls.Add(this.createTeamLinkLabel);
            this.Controls.Add(this.SelectTeamDropDown);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CreateTournamentLabel);
            this.Controls.Add(this.createTournamentTextBox);
            this.Controls.Add(this.CreateTrounamentLabel);
            this.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.Highlight;
            this.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.Name = "CreateTournamentForm";
            this.Text = "CreateTournamentForm";
            this.Load += new System.EventHandler(this.CreateTournamentForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label CreateTrounamentLabel;
        private System.Windows.Forms.TextBox createTournamentTextBox;
        private System.Windows.Forms.Label CreateTournamentLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox SelectTeamDropDown;
        private System.Windows.Forms.LinkLabel createTeamLinkLabel;
        private System.Windows.Forms.Button addNameBtn;
        private System.Windows.Forms.Button createPrizeBtn;
        private System.Windows.Forms.ListBox TournamentPlayersListBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button deletePlayerBtn;
        private System.Windows.Forms.Button deletePrizeBtn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox prizesListBox;
        private System.Windows.Forms.Button createTournamentBtn;
    }
}