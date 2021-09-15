namespace Flipcards
{
    partial class CreateCardForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreateCardForm));
            this.cancelButton = new System.Windows.Forms.Button();
            this.okButton = new System.Windows.Forms.Button();
            this.cardPromptTextBox = new System.Windows.Forms.TextBox();
            this.promptLabel = new System.Windows.Forms.Label();
            this.cardAnswerTextBox = new System.Windows.Forms.TextBox();
            this.answerLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(200, 155);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 8;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // okButton
            // 
            this.okButton.Location = new System.Drawing.Point(119, 155);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(75, 23);
            this.okButton.TabIndex = 7;
            this.okButton.Text = "OK";
            this.okButton.UseVisualStyleBackColor = true;
            this.okButton.Click += new System.EventHandler(this.okButton_Click);
            // 
            // cardPromptTextBox
            // 
            this.cardPromptTextBox.Location = new System.Drawing.Point(69, 82);
            this.cardPromptTextBox.Name = "cardPromptTextBox";
            this.cardPromptTextBox.Size = new System.Drawing.Size(303, 20);
            this.cardPromptTextBox.TabIndex = 10;
            // 
            // promptLabel
            // 
            this.promptLabel.AutoSize = true;
            this.promptLabel.BackColor = System.Drawing.Color.Transparent;
            this.promptLabel.Location = new System.Drawing.Point(25, 84);
            this.promptLabel.Name = "promptLabel";
            this.promptLabel.Size = new System.Drawing.Size(43, 13);
            this.promptLabel.TabIndex = 9;
            this.promptLabel.Text = "Prompt:";
            // 
            // cardAnswerTextBox
            // 
            this.cardAnswerTextBox.Location = new System.Drawing.Point(69, 117);
            this.cardAnswerTextBox.Name = "cardAnswerTextBox";
            this.cardAnswerTextBox.Size = new System.Drawing.Size(303, 20);
            this.cardAnswerTextBox.TabIndex = 13;
            // 
            // answerLabel
            // 
            this.answerLabel.AutoSize = true;
            this.answerLabel.BackColor = System.Drawing.Color.Transparent;
            this.answerLabel.Location = new System.Drawing.Point(25, 119);
            this.answerLabel.Name = "answerLabel";
            this.answerLabel.Size = new System.Drawing.Size(45, 13);
            this.answerLabel.TabIndex = 12;
            this.answerLabel.Text = "Answer:";
            // 
            // CreateCardForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(397, 197);
            this.Controls.Add(this.cardAnswerTextBox);
            this.Controls.Add(this.answerLabel);
            this.Controls.Add(this.cardPromptTextBox);
            this.Controls.Add(this.promptLabel);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.okButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CreateCardForm";
            this.Text = "Create Card";
            this.Load += new System.EventHandler(this.CreateCard_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button okButton;
        private System.Windows.Forms.TextBox cardPromptTextBox;
        private System.Windows.Forms.Label promptLabel;
        private System.Windows.Forms.TextBox cardAnswerTextBox;
        private System.Windows.Forms.Label answerLabel;
    }
}