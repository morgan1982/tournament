namespace TrackerUI
{
    partial class TournamentDashboardForm
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
            this.TournamentDashboardBtn = new System.Windows.Forms.Label();
            this.loadExistingTournamentLabel = new System.Windows.Forms.Label();
            this.loadExistingTournamentDropDown = new System.Windows.Forms.ComboBox();
            this.loadTournamentBtn = new System.Windows.Forms.Button();
            this.createTournamentButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TournamentDashboardBtn
            // 
            this.TournamentDashboardBtn.AutoSize = true;
            this.TournamentDashboardBtn.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TournamentDashboardBtn.Location = new System.Drawing.Point(136, 34);
            this.TournamentDashboardBtn.Name = "TournamentDashboardBtn";
            this.TournamentDashboardBtn.Size = new System.Drawing.Size(353, 45);
            this.TournamentDashboardBtn.TabIndex = 0;
            this.TournamentDashboardBtn.Text = "Tournament Dashboard";
            // 
            // loadExistingTournamentLabel
            // 
            this.loadExistingTournamentLabel.AutoSize = true;
            this.loadExistingTournamentLabel.Location = new System.Drawing.Point(186, 112);
            this.loadExistingTournamentLabel.Name = "loadExistingTournamentLabel";
            this.loadExistingTournamentLabel.Size = new System.Drawing.Size(252, 30);
            this.loadExistingTournamentLabel.TabIndex = 1;
            this.loadExistingTournamentLabel.Text = "Load Existing Tournament";
            // 
            // loadExistingTournamentDropDown
            // 
            this.loadExistingTournamentDropDown.FormattingEnabled = true;
            this.loadExistingTournamentDropDown.Location = new System.Drawing.Point(157, 170);
            this.loadExistingTournamentDropDown.Name = "loadExistingTournamentDropDown";
            this.loadExistingTournamentDropDown.Size = new System.Drawing.Size(310, 38);
            this.loadExistingTournamentDropDown.TabIndex = 2;
            // 
            // loadTournamentBtn
            // 
            this.loadTournamentBtn.Location = new System.Drawing.Point(208, 225);
            this.loadTournamentBtn.Name = "loadTournamentBtn";
            this.loadTournamentBtn.Size = new System.Drawing.Size(221, 53);
            this.loadTournamentBtn.TabIndex = 3;
            this.loadTournamentBtn.Text = "Load Tournament ";
            this.loadTournamentBtn.UseVisualStyleBackColor = true;
            // 
            // createTournamentButton
            // 
            this.createTournamentButton.Location = new System.Drawing.Point(181, 297);
            this.createTournamentButton.Name = "createTournamentButton";
            this.createTournamentButton.Size = new System.Drawing.Size(267, 79);
            this.createTournamentButton.TabIndex = 4;
            this.createTournamentButton.Text = "Create Tournament";
            this.createTournamentButton.UseVisualStyleBackColor = true;
            // 
            // TournamentDashboardForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(638, 408);
            this.Controls.Add(this.createTournamentButton);
            this.Controls.Add(this.loadTournamentBtn);
            this.Controls.Add(this.loadExistingTournamentDropDown);
            this.Controls.Add(this.loadExistingTournamentLabel);
            this.Controls.Add(this.TournamentDashboardBtn);
            this.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.Highlight;
            this.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.Name = "TournamentDashboardForm";
            this.Text = "TournamentDashboardForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label TournamentDashboardBtn;
        private System.Windows.Forms.Label loadExistingTournamentLabel;
        private System.Windows.Forms.ComboBox loadExistingTournamentDropDown;
        private System.Windows.Forms.Button loadTournamentBtn;
        private System.Windows.Forms.Button createTournamentButton;
    }
}