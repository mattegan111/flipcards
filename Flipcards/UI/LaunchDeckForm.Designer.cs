namespace Flipcards
{
    partial class LaunchDeckForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LaunchDeckForm));
            this.revealAnswerButton = new System.Windows.Forms.Button();
            this.nextCardButton = new System.Windows.Forms.Button();
            this.promptTextBox = new System.Windows.Forms.TextBox();
            this.answerTextBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // revealAnswerButton
            // 
            this.revealAnswerButton.Location = new System.Drawing.Point(120, 310);
            this.revealAnswerButton.Name = "revealAnswerButton";
            this.revealAnswerButton.Size = new System.Drawing.Size(105, 23);
            this.revealAnswerButton.TabIndex = 0;
            this.revealAnswerButton.Text = "Reveal Answer";
            this.revealAnswerButton.UseVisualStyleBackColor = true;
            this.revealAnswerButton.Click += new System.EventHandler(this.revealAnswerButton_Click);
            // 
            // nextCardButton
            // 
            this.nextCardButton.Location = new System.Drawing.Point(231, 310);
            this.nextCardButton.Name = "nextCardButton";
            this.nextCardButton.Size = new System.Drawing.Size(75, 23);
            this.nextCardButton.TabIndex = 4;
            this.nextCardButton.Text = "Next Card";
            this.nextCardButton.UseVisualStyleBackColor = true;
            this.nextCardButton.Click += new System.EventHandler(this.nextCardButton_Click);
            // 
            // promptTextBox
            // 
            this.promptTextBox.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.promptTextBox.Location = new System.Drawing.Point(56, 82);
            this.promptTextBox.Multiline = true;
            this.promptTextBox.Name = "promptTextBox";
            this.promptTextBox.ReadOnly = true;
            this.promptTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.promptTextBox.Size = new System.Drawing.Size(321, 108);
            this.promptTextBox.TabIndex = 8;
            // 
            // answerTextBox
            // 
            this.answerTextBox.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.answerTextBox.Location = new System.Drawing.Point(56, 196);
            this.answerTextBox.Multiline = true;
            this.answerTextBox.Name = "answerTextBox";
            this.answerTextBox.ReadOnly = true;
            this.answerTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.answerTextBox.Size = new System.Drawing.Size(321, 108);
            this.answerTextBox.TabIndex = 9;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(176, 357);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 10;
            this.button1.Text = "Exit";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // LaunchDeckForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(432, 485);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.answerTextBox);
            this.Controls.Add(this.promptTextBox);
            this.Controls.Add(this.nextCardButton);
            this.Controls.Add(this.revealAnswerButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "LaunchDeckForm";
            this.Text = "Practicing:";
            this.Load += new System.EventHandler(this.LaunchDeckForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button revealAnswerButton;
        private System.Windows.Forms.Button nextCardButton;
        private System.Windows.Forms.TextBox promptTextBox;
        private System.Windows.Forms.TextBox answerTextBox;
        private System.Windows.Forms.Button button1;
    }
}