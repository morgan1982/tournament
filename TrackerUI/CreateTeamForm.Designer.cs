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
            this.teamNameLabel = new System.Windows.Forms.Label();
            this.teamNamseLabel = new System.Windows.Forms.Label();
            this.selectTeamMemberLabel = new System.Windows.Forms.Label();
            this.teamNameTextBox = new System.Windows.Forms.TextBox();
            this.selectTeamMemberTextBox = new System.Windows.Forms.TextBox();
            this.addTeamBtn = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.createMemberBtn = new System.Windows.Forms.Button();
            this.teamMembersListBox = new System.Windows.Forms.ListBox();
            this.deleteMemberBtn = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // teamNameLabel
            // 
            this.teamNameLabel.AutoSize = true;
            this.teamNameLabel.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.teamNameLabel.Location = new System.Drawing.Point(21, 9);
            this.teamNameLabel.Name = "teamNameLabel";
            this.teamNameLabel.Size = new System.Drawing.Size(163, 37);
            this.teamNameLabel.TabIndex = 0;
            this.teamNameLabel.Text = "Create Team";
            // 
            // teamNamseLabel
            // 
            this.teamNamseLabel.AutoSize = true;
            this.teamNamseLabel.Location = new System.Drawing.Point(23, 78);
            this.teamNamseLabel.Name = "teamNamseLabel";
            this.teamNamseLabel.Size = new System.Drawing.Size(124, 30);
            this.teamNamseLabel.TabIndex = 1;
            this.teamNamseLabel.Text = "Team Name";
            // 
            // selectTeamMemberLabel
            // 
            this.selectTeamMemberLabel.AutoSize = true;
            this.selectTeamMemberLabel.Location = new System.Drawing.Point(28, 183);
            this.selectTeamMemberLabel.Name = "selectTeamMemberLabel";
            this.selectTeamMemberLabel.Size = new System.Drawing.Size(207, 30);
            this.selectTeamMemberLabel.TabIndex = 2;
            this.selectTeamMemberLabel.Text = "Select Team Member";
            // 
            // teamNameTextBox
            // 
            this.teamNameTextBox.Location = new System.Drawing.Point(28, 126);
            this.teamNameTextBox.Name = "teamNameTextBox";
            this.teamNameTextBox.Size = new System.Drawing.Size(197, 35);
            this.teamNameTextBox.TabIndex = 3;
            // 
            // selectTeamMemberTextBox
            // 
            this.selectTeamMemberTextBox.Location = new System.Drawing.Point(28, 231);
            this.selectTeamMemberTextBox.Name = "selectTeamMemberTextBox";
            this.selectTeamMemberTextBox.Size = new System.Drawing.Size(197, 35);
            this.selectTeamMemberTextBox.TabIndex = 4;
            // 
            // addTeamBtn
            // 
            this.addTeamBtn.Location = new System.Drawing.Point(69, 291);
            this.addTeamBtn.Name = "addTeamBtn";
            this.addTeamBtn.Size = new System.Drawing.Size(156, 56);
            this.addTeamBtn.TabIndex = 5;
            this.addTeamBtn.Text = "Add Member";
            this.addTeamBtn.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.createMemberBtn);
            this.groupBox1.Controls.Add(this.textBox4);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.textBox3);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.textBox2);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 372);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(466, 237);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Add New Member";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "First Name";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(143, 44);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 35);
            this.textBox1.TabIndex = 1;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(143, 92);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 35);
            this.textBox2.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 30);
            this.label2.TabIndex = 2;
            this.label2.Text = "Last Name";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(143, 142);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 35);
            this.textBox3.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 144);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 30);
            this.label3.TabIndex = 4;
            this.label3.Text = "Email";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(143, 192);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 35);
            this.textBox4.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 194);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 30);
            this.label4.TabIndex = 6;
            this.label4.Text = "Cellphone";
            // 
            // createMemberBtn
            // 
            this.createMemberBtn.Location = new System.Drawing.Point(264, 167);
            this.createMemberBtn.Name = "createMemberBtn";
            this.createMemberBtn.Size = new System.Drawing.Size(183, 64);
            this.createMemberBtn.TabIndex = 8;
            this.createMemberBtn.Text = "Create Member";
            this.createMemberBtn.UseVisualStyleBackColor = true;
            // 
            // teamMembersListBox
            // 
            this.teamMembersListBox.FormattingEnabled = true;
            this.teamMembersListBox.ItemHeight = 30;
            this.teamMembersListBox.Location = new System.Drawing.Point(527, 52);
            this.teamMembersListBox.Name = "teamMembersListBox";
            this.teamMembersListBox.Size = new System.Drawing.Size(286, 424);
            this.teamMembersListBox.TabIndex = 7;
            // 
            // deleteMemberBtn
            // 
            this.deleteMemberBtn.Location = new System.Drawing.Point(348, 52);
            this.deleteMemberBtn.Name = "deleteMemberBtn";
            this.deleteMemberBtn.Size = new System.Drawing.Size(158, 69);
            this.deleteMemberBtn.TabIndex = 8;
            this.deleteMemberBtn.Text = "Delete Selected";
            this.deleteMemberBtn.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(581, 539);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(232, 98);
            this.button1.TabIndex = 9;
            this.button1.Text = "Create Team";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // CreateTeamForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(845, 660);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.deleteMemberBtn);
            this.Controls.Add(this.teamMembersListBox);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.addTeamBtn);
            this.Controls.Add(this.selectTeamMemberTextBox);
            this.Controls.Add(this.teamNameTextBox);
            this.Controls.Add(this.selectTeamMemberLabel);
            this.Controls.Add(this.teamNamseLabel);
            this.Controls.Add(this.teamNameLabel);
            this.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.Highlight;
            this.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.Name = "CreateTeamForm";
            this.Text = "CreateTeamForm";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label teamNameLabel;
        private System.Windows.Forms.Label teamNamseLabel;
        private System.Windows.Forms.Label selectTeamMemberLabel;
        private System.Windows.Forms.TextBox teamNameTextBox;
        private System.Windows.Forms.TextBox selectTeamMemberTextBox;
        private System.Windows.Forms.Button addTeamBtn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button createMemberBtn;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox teamMembersListBox;
        private System.Windows.Forms.Button deleteMemberBtn;
        private System.Windows.Forms.Button button1;
    }
}