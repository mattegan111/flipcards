namespace Flipcards
{
    partial class CreateDeckForm
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
            this.okButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.deckNameLabel = new System.Windows.Forms.Label();
            this.deckNameTextBox = new System.Windows.Forms.TextBox();
            this.cardListBox = new System.Windows.Forms.ListBox();
            this.editSelectedButton = new System.Windows.Forms.Button();
            this.deleteSelectedButton = new System.Windows.Forms.Button();
            this.createNewCardButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // okButton
            // 
            this.okButton.Location = new System.Drawing.Point(136, 432);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(75, 23);
            this.okButton.TabIndex = 0;
            this.okButton.Text = "OK";
            this.okButton.UseVisualStyleBackColor = true;
            this.okButton.Click += new System.EventHandler(this.okButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(217, 432);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 1;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // deckNameLabel
            // 
            this.deckNameLabel.AutoSize = true;
            this.deckNameLabel.BackColor = System.Drawing.Color.Transparent;
            this.deckNameLabel.Location = new System.Drawing.Point(41, 84);
            this.deckNameLabel.Name = "deckNameLabel";
            this.deckNameLabel.Size = new System.Drawing.Size(38, 13);
            this.deckNameLabel.TabIndex = 2;
            this.deckNameLabel.Text = "Name:";
            this.deckNameLabel.Click += new System.EventHandler(this.deckNameLabel_Click);
            // 
            // deckNameTextBox
            // 
            this.deckNameTextBox.Location = new System.Drawing.Point(85, 82);
            this.deckNameTextBox.Name = "deckNameTextBox";
            this.deckNameTextBox.Size = new System.Drawing.Size(303, 20);
            this.deckNameTextBox.TabIndex = 3;
            // 
            // cardListBox
            // 
            this.cardListBox.FormattingEnabled = true;
            this.cardListBox.Location = new System.Drawing.Point(44, 110);
            this.cardListBox.Name = "cardListBox";
            this.cardListBox.Size = new System.Drawing.Size(345, 264);
            this.cardListBox.TabIndex = 7;
            // 
            // editSelectedButton
            // 
            this.editSelectedButton.Location = new System.Drawing.Point(44, 381);
            this.editSelectedButton.Name = "editSelectedButton";
            this.editSelectedButton.Size = new System.Drawing.Size(95, 23);
            this.editSelectedButton.TabIndex = 8;
            this.editSelectedButton.Text = "Edit Selected";
            this.editSelectedButton.UseVisualStyleBackColor = true;
            this.editSelectedButton.Click += new System.EventHandler(this.editSelectedButton_Click);
            // 
            // deleteSelectedButton
            // 
            this.deleteSelectedButton.Location = new System.Drawing.Point(145, 381);
            this.deleteSelectedButton.Name = "deleteSelectedButton";
            this.deleteSelectedButton.Size = new System.Drawing.Size(95, 23);
            this.deleteSelectedButton.TabIndex = 9;
            this.deleteSelectedButton.Text = "Delete Selected";
            this.deleteSelectedButton.UseVisualStyleBackColor = true;
            this.deleteSelectedButton.Click += new System.EventHandler(this.deleteSelectedButton_Click);
            // 
            // createNewCardButton
            // 
            this.createNewCardButton.Location = new System.Drawing.Point(305, 33);
            this.createNewCardButton.Name = "createNewCardButton";
            this.createNewCardButton.Size = new System.Drawing.Size(108, 23);
            this.createNewCardButton.TabIndex = 10;
            this.createNewCardButton.Text = "Create New Card";
            this.createNewCardButton.UseVisualStyleBackColor = true;
            this.createNewCardButton.Click += new System.EventHandler(this.createNewCardButton_Click);
            // 
            // CreateDeckForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(432, 485);
            this.Controls.Add(this.createNewCardButton);
            this.Controls.Add(this.deleteSelectedButton);
            this.Controls.Add(this.editSelectedButton);
            this.Controls.Add(this.cardListBox);
            this.Controls.Add(this.deckNameTextBox);
            this.Controls.Add(this.deckNameLabel);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.okButton);
            this.Name = "CreateDeckForm";
            this.Text = "Create Deck";
            this.Load += new System.EventHandler(this.CreateDeck_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button okButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Label deckNameLabel;
        private System.Windows.Forms.TextBox deckNameTextBox;
        private System.Windows.Forms.ListBox cardListBox;
        private System.Windows.Forms.Button editSelectedButton;
        private System.Windows.Forms.Button deleteSelectedButton;
        private System.Windows.Forms.Button createNewCardButton;
    }
}