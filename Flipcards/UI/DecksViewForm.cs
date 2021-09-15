using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Flipcards.DataAccess;
using FlipCards.Models;

namespace Flipcards
{
    public partial class DecksViewForm : MaterialSkin.Controls.MaterialForm
    {
        private List<DeckModel> decks;
        public DecksViewForm()
        {
            InitializeComponent();

            WireUpLists();
        }

        public void WireUpLists()
        {
            decks = GlobalConfig.Connection.GetDeck_All();
            deckListBox.DataSource = decks;
            deckListBox.DisplayMember = "DeckName";
        }

        private void createNewDeckButton_Click(object sender, EventArgs e)
        {
            using (var frm = new CreateDeckForm())
            {
                frm.StartPosition = FormStartPosition.CenterParent;
                frm.ShowDialog();
            }

            WireUpLists();
        }

        private void deleteSelectedButton_Click(object sender, EventArgs e)
        {
            DeckModel model = (DeckModel) deckListBox.SelectedItem;

            if (model != null)
            {
                GlobalConfig.Connection.DeleteDeck(model);

                WireUpLists();
            }
            else
            {
                MessageBox.Show("No deck selected");
            }
        }

        private void DecksViewForm_Load(object sender, EventArgs e)
        {

        }

        private void editSelectedButton_Click(object sender, EventArgs e)
        {
            DeckModel model = (DeckModel)deckListBox.SelectedItem;

            if (model != null)
            {
                using (var frm = new EditDeckForm(model))
                {
                    frm.StartPosition = FormStartPosition.CenterParent;
                    frm.ShowDialog();
                }

                WireUpLists();
            }
            else
            {
                MessageBox.Show("No deck selected");
            }
        }

        private void launchDeckButton_Click(object sender, EventArgs e)
        {
            DeckModel model = (DeckModel)deckListBox.SelectedItem;

            if (model != null)
            {
                using (var frm = new LaunchDeckForm(model))
                {
                    frm.StartPosition = FormStartPosition.CenterParent;
                    frm.ShowDialog();
                }

                WireUpLists();
            }
            else
            {
                MessageBox.Show("No deck selected");
            }
        }
    }
}
