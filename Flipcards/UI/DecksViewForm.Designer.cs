namespace Flipcards
{
    partial class DecksViewForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DecksViewForm));
            this.deckListBox = new System.Windows.Forms.ListBox();
            this.createNewDeckButton = new System.Windows.Forms.Button();
            this.editSelectedButton = new System.Windows.Forms.Button();
            this.deleteSelectedButton = new System.Windows.Forms.Button();
            this.launchDeckButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // deckListBox
            // 
            this.deckListBox.FormattingEnabled = true;
            this.deckListBox.Location = new System.Drawing.Point(44, 81);
            this.deckListBox.Name = "deckListBox";
            this.deckListBox.Size = new System.Drawing.Size(345, 264);
            this.deckListBox.TabIndex = 1;
            // 
            // createNewDeckButton
            // 
            this.createNewDeckButton.Location = new System.Drawing.Point(305, 33);
            this.createNewDeckButton.Name = "createNewDeckButton";
            this.createNewDeckButton.Size = new System.Drawing.Size(108, 23);
            this.createNewDeckButton.TabIndex = 2;
            this.createNewDeckButton.Text = "Create New Deck";
            this.createNewDeckButton.UseVisualStyleBackColor = true;
            this.createNewDeckButton.Click += new System.EventHandler(this.createNewDeckButton_Click);
            // 
            // editSelectedButton
            // 
            this.editSelectedButton.Location = new System.Drawing.Point(145, 360);
            this.editSelectedButton.Name = "editSelectedButton";
            this.editSelectedButton.Size = new System.Drawing.Size(95, 23);
            this.editSelectedButton.TabIndex = 3;
            this.editSelectedButton.Text = "Edit Selected";
            this.editSelectedButton.UseVisualStyleBackColor = true;
            this.editSelectedButton.Click += new System.EventHandler(this.editSelectedButton_Click);
            // 
            // deleteSelectedButton
            // 
            this.deleteSelectedButton.Location = new System.Drawing.Point(246, 360);
            this.deleteSelectedButton.Name = "deleteSelectedButton";
            this.deleteSelectedButton.Size = new System.Drawing.Size(95, 23);
            this.deleteSelectedButton.TabIndex = 4;
            this.deleteSelectedButton.Text = "Delete Selected";
            this.deleteSelectedButton.UseVisualStyleBackColor = true;
            this.deleteSelectedButton.Click += new System.EventHandler(this.deleteSelectedButton_Click);
            // 
            // launchDeckButton
            // 
            this.launchDeckButton.Location = new System.Drawing.Point(43, 360);
            this.launchDeckButton.Name = "launchDeckButton";
            this.launchDeckButton.Size = new System.Drawing.Size(96, 23);
            this.launchDeckButton.TabIndex = 5;
            this.launchDeckButton.Text = "Launch Selected";
            this.launchDeckButton.UseVisualStyleBackColor = true;
            this.launchDeckButton.Click += new System.EventHandler(this.launchDeckButton_Click);
            // 
            // DecksViewForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(432, 485);
            this.Controls.Add(this.launchDeckButton);
            this.Controls.Add(this.deleteSelectedButton);
            this.Controls.Add(this.editSelectedButton);
            this.Controls.Add(this.createNewDeckButton);
            this.Controls.Add(this.deckListBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "DecksViewForm";
            this.Text = "Your Decks";
            this.Load += new System.EventHandler(this.DecksViewForm_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ListBox deckListBox;
        private System.Windows.Forms.Button createNewDeckButton;
        private System.Windows.Forms.Button editSelectedButton;
        private System.Windows.Forms.Button deleteSelectedButton;
        private System.Windows.Forms.Button launchDeckButton;
    }
}

