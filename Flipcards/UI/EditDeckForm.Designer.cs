namespace Flipcards
{
    partial class EditDeckForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditDeckForm));
            this.deckNameTextBox = new System.Windows.Forms.TextBox();
            this.deckNameLabel = new System.Windows.Forms.Label();
            this.cancelButton = new System.Windows.Forms.Button();
            this.okButton = new System.Windows.Forms.Button();
            this.createNewCardDeckButton = new System.Windows.Forms.Button();
            this.cardListBox = new System.Windows.Forms.ListBox();
            this.editSelectedButton = new System.Windows.Forms.Button();
            this.deleteSelected = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // deckNameTextBox
            // 
            this.deckNameTextBox.Location = new System.Drawing.Point(85, 82);
            this.deckNameTextBox.Name = "deckNameTextBox";
            this.deckNameTextBox.Size = new System.Drawing.Size(303, 20);
            this.deckNameTextBox.TabIndex = 10;
            // 
            // deckNameLabel
            // 
            this.deckNameLabel.AutoSize = true;
            this.deckNameLabel.BackColor = System.Drawing.Color.Transparent;
            this.deckNameLabel.Location = new System.Drawing.Point(41, 84);
            this.deckNameLabel.Name = "deckNameLabel";
            this.deckNameLabel.Size = new System.Drawing.Size(38, 13);
            this.deckNameLabel.TabIndex = 9;
            this.deckNameLabel.Text = "Name:";
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(217, 429);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 8;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // okButton
            // 
            this.okButton.Location = new System.Drawing.Point(136, 429);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(75, 23);
            this.okButton.TabIndex = 7;
            this.okButton.Text = "OK";
            this.okButton.UseVisualStyleBackColor = true;
            this.okButton.Click += new System.EventHandler(this.okButton_Click);
            // 
            // createNewCardDeckButton
            // 
            this.createNewCardDeckButton.Location = new System.Drawing.Point(305, 33);
            this.createNewCardDeckButton.Name = "createNewCardDeckButton";
            this.createNewCardDeckButton.Size = new System.Drawing.Size(108, 23);
            this.createNewCardDeckButton.TabIndex = 12;
            this.createNewCardDeckButton.Text = "Create New Card";
            this.createNewCardDeckButton.UseVisualStyleBackColor = true;
            this.createNewCardDeckButton.Click += new System.EventHandler(this.createNewCardDeckButton_Click);
            // 
            // cardListBox
            // 
            this.cardListBox.FormattingEnabled = true;
            this.cardListBox.Location = new System.Drawing.Point(44, 110);
            this.cardListBox.Name = "cardListBox";
            this.cardListBox.Size = new System.Drawing.Size(345, 264);
            this.cardListBox.TabIndex = 13;
            // 
            // editSelectedButton
            // 
            this.editSelectedButton.Location = new System.Drawing.Point(44, 381);
            this.editSelectedButton.Name = "editSelectedButton";
            this.editSelectedButton.Size = new System.Drawing.Size(95, 23);
            this.editSelectedButton.TabIndex = 14;
            this.editSelectedButton.Text = "Edit Selected";
            this.editSelectedButton.UseVisualStyleBackColor = true;
            this.editSelectedButton.Click += new System.EventHandler(this.editSelectedButton_Click);
            // 
            // deleteSelected
            // 
            this.deleteSelected.Location = new System.Drawing.Point(146, 381);
            this.deleteSelected.Name = "deleteSelected";
            this.deleteSelected.Size = new System.Drawing.Size(95, 23);
            this.deleteSelected.TabIndex = 15;
            this.deleteSelected.Text = "Delete Selected";
            this.deleteSelected.UseVisualStyleBackColor = true;
            this.deleteSelected.Click += new System.EventHandler(this.deleteSelected_Click);
            // 
            // EditDeckForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(432, 485);
            this.Controls.Add(this.deleteSelected);
            this.Controls.Add(this.editSelectedButton);
            this.Controls.Add(this.cardListBox);
            this.Controls.Add(this.createNewCardDeckButton);
            this.Controls.Add(this.deckNameTextBox);
            this.Controls.Add(this.deckNameLabel);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.okButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "EditDeckForm";
            this.Text = "Edit Deck";
            this.Load += new System.EventHandler(this.EditDeckForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox deckNameTextBox;
        private System.Windows.Forms.Label deckNameLabel;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button okButton;
        private System.Windows.Forms.Button createNewCardDeckButton;
        private System.Windows.Forms.ListBox cardListBox;
        private System.Windows.Forms.Button editSelectedButton;
        private System.Windows.Forms.Button deleteSelected;
    }
}