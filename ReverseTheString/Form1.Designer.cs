namespace ReverseTheString
{
    partial class ReverseString
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
            this.InputBox = new System.Windows.Forms.TextBox();
            this.reverseButton = new System.Windows.Forms.Button();
            this.inputLabel = new System.Windows.Forms.Label();
            this.wordOutput = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // InputBox
            // 
            this.InputBox.Location = new System.Drawing.Point(22, 67);
            this.InputBox.Name = "InputBox";
            this.InputBox.Size = new System.Drawing.Size(294, 20);
            this.InputBox.TabIndex = 0;
            // 
            // reverseButton
            // 
            this.reverseButton.Location = new System.Drawing.Point(22, 102);
            this.reverseButton.Name = "reverseButton";
            this.reverseButton.Size = new System.Drawing.Size(104, 23);
            this.reverseButton.TabIndex = 1;
            this.reverseButton.Text = "reverse it!";
            this.reverseButton.UseVisualStyleBackColor = true;
            this.reverseButton.Click += new System.EventHandler(this.reverseButton_Click);
            // 
            // inputLabel
            // 
            this.inputLabel.AutoSize = true;
            this.inputLabel.Location = new System.Drawing.Point(22, 48);
            this.inputLabel.Name = "inputLabel";
            this.inputLabel.Size = new System.Drawing.Size(208, 13);
            this.inputLabel.TabIndex = 4;
            this.inputLabel.Text = "Please type what you want to be reversed!";
            // 
            // wordOutput
            // 
            this.wordOutput.AutoSize = true;
            this.wordOutput.Location = new System.Drawing.Point(25, 148);
            this.wordOutput.Name = "wordOutput";
            this.wordOutput.Size = new System.Drawing.Size(147, 13);
            this.wordOutput.TabIndex = 5;
            this.wordOutput.Text = "This will be the word reversed";
            // 
            // ReverseString
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(374, 255);
            this.Controls.Add(this.wordOutput);
            this.Controls.Add(this.inputLabel);
            this.Controls.Add(this.reverseButton);
            this.Controls.Add(this.InputBox);
            this.Name = "ReverseString";
            this.Text = "Reverse the String";
            this.Load += new System.EventHandler(this.ReverseString_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox InputBox;
        private System.Windows.Forms.Button reverseButton;
        private System.Windows.Forms.Label inputLabel;
        private System.Windows.Forms.Label wordOutput;
    }
}

