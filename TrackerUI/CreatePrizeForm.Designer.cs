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
            this.label1 = new System.Windows.Forms.Label();
            this.placeNumberLabel = new System.Windows.Forms.Label();
            this.placeNumberTextBox = new System.Windows.Forms.TextBox();
            this.prizeAmountTextBox = new System.Windows.Forms.TextBox();
            this.prizeAmountLabel = new System.Windows.Forms.Label();
            this.placeNameTextBox = new System.Windows.Forms.TextBox();
            this.placeNameLabel = new System.Windows.Forms.Label();
            this.prizePercentageTextBox = new System.Windows.Forms.TextBox();
            this.prizePercentageLabel = new System.Windows.Forms.Label();
            this.orLabel = new System.Windows.Forms.Label();
            this.createPrizeBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(189, 45);
            this.label1.TabIndex = 0;
            this.label1.Text = "Create Prize";
            // 
            // placeNumberLabel
            // 
            this.placeNumberLabel.AutoSize = true;
            this.placeNumberLabel.Location = new System.Drawing.Point(34, 98);
            this.placeNumberLabel.Name = "placeNumberLabel";
            this.placeNumberLabel.Size = new System.Drawing.Size(144, 30);
            this.placeNumberLabel.TabIndex = 1;
            this.placeNumberLabel.Text = "Place Number";
            // 
            // placeNumberTextBox
            // 
            this.placeNumberTextBox.Location = new System.Drawing.Point(214, 98);
            this.placeNumberTextBox.Name = "placeNumberTextBox";
            this.placeNumberTextBox.Size = new System.Drawing.Size(100, 35);
            this.placeNumberTextBox.TabIndex = 2;
            // 
            // prizeAmountTextBox
            // 
            this.prizeAmountTextBox.Location = new System.Drawing.Point(214, 211);
            this.prizeAmountTextBox.Name = "prizeAmountTextBox";
            this.prizeAmountTextBox.Size = new System.Drawing.Size(100, 35);
            this.prizeAmountTextBox.TabIndex = 4;
            // 
            // prizeAmountLabel
            // 
            this.prizeAmountLabel.AutoSize = true;
            this.prizeAmountLabel.Location = new System.Drawing.Point(34, 211);
            this.prizeAmountLabel.Name = "prizeAmountLabel";
            this.prizeAmountLabel.Size = new System.Drawing.Size(145, 30);
            this.prizeAmountLabel.TabIndex = 3;
            this.prizeAmountLabel.Text = "Prize Amount ";
            // 
            // placeNameTextBox
            // 
            this.placeNameTextBox.Location = new System.Drawing.Point(214, 155);
            this.placeNameTextBox.Name = "placeNameTextBox";
            this.placeNameTextBox.Size = new System.Drawing.Size(100, 35);
            this.placeNameTextBox.TabIndex = 6;
            // 
            // placeNameLabel
            // 
            this.placeNameLabel.AutoSize = true;
            this.placeNameLabel.Location = new System.Drawing.Point(34, 155);
            this.placeNameLabel.Name = "placeNameLabel";
            this.placeNameLabel.Size = new System.Drawing.Size(124, 30);
            this.placeNameLabel.TabIndex = 5;
            this.placeNameLabel.Text = "Place Name";
            // 
            // prizePercentageTextBox
            // 
            this.prizePercentageTextBox.Location = new System.Drawing.Point(214, 292);
            this.prizePercentageTextBox.Name = "prizePercentageTextBox";
            this.prizePercentageTextBox.Size = new System.Drawing.Size(100, 35);
            this.prizePercentageTextBox.TabIndex = 8;
            // 
            // prizePercentageLabel
            // 
            this.prizePercentageLabel.AutoSize = true;
            this.prizePercentageLabel.Location = new System.Drawing.Point(34, 292);
            this.prizePercentageLabel.Name = "prizePercentageLabel";
            this.prizePercentageLabel.Size = new System.Drawing.Size(161, 30);
            this.prizePercentageLabel.TabIndex = 7;
            this.prizePercentageLabel.Text = "PrizePercentage";
            // 
            // orLabel
            // 
            this.orLabel.AutoSize = true;
            this.orLabel.Location = new System.Drawing.Point(143, 257);
            this.orLabel.Name = "orLabel";
            this.orLabel.Size = new System.Drawing.Size(48, 30);
            this.orLabel.TabIndex = 9;
            this.orLabel.Text = "-or-";
            // 
            // createPrizeBtn
            // 
            this.createPrizeBtn.Location = new System.Drawing.Point(98, 377);
            this.createPrizeBtn.Name = "createPrizeBtn";
            this.createPrizeBtn.Size = new System.Drawing.Size(150, 76);
            this.createPrizeBtn.TabIndex = 10;
            this.createPrizeBtn.Text = "Create Prize";
            this.createPrizeBtn.UseVisualStyleBackColor = true;
            // 
            // CreatePrizeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(427, 552);
            this.Controls.Add(this.createPrizeBtn);
            this.Controls.Add(this.orLabel);
            this.Controls.Add(this.prizePercentageTextBox);
            this.Controls.Add(this.prizePercentageLabel);
            this.Controls.Add(this.placeNameTextBox);
            this.Controls.Add(this.placeNameLabel);
            this.Controls.Add(this.prizeAmountTextBox);
            this.Controls.Add(this.prizeAmountLabel);
            this.Controls.Add(this.placeNumberTextBox);
            this.Controls.Add(this.placeNumberLabel);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.Highlight;
            this.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.Name = "CreatePrizeForm";
            this.Text = "CreatePrizeForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label placeNumberLabel;
        private System.Windows.Forms.TextBox placeNumberTextBox;
        private System.Windows.Forms.TextBox prizeAmountTextBox;
        private System.Windows.Forms.Label prizeAmountLabel;
        private System.Windows.Forms.TextBox placeNameTextBox;
        private System.Windows.Forms.Label placeNameLabel;
        private System.Windows.Forms.TextBox prizePercentageTextBox;
        private System.Windows.Forms.Label prizePercentageLabel;
        private System.Windows.Forms.Label orLabel;
        private System.Windows.Forms.Button createPrizeBtn;
    }
}