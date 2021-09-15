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
    public partial class CreateDeckForm : MaterialSkin.Controls.MaterialForm
    {
        private List<CardModel> cards;
        private DeckModel newDeckModel = new DeckModel();

        public CreateDeckForm()
        {
            InitializeComponent();

            CreateDefaultDeck();

            WireUpLists();
        }

        private void CreateDefaultDeck()
        {
            newDeckModel.DeckName = "New Deck";
            deckNameTextBox.Text = newDeckModel.DeckName;

            //TODO Prevent duplicate deck names.

            GlobalConfig.Connection.CreateDeck(newDeckModel);
        }

        private void WireUpLists()
        {
            //TODO specify which deck cards are from
            //TODO is this code necessary?
            cards = GlobalConfig.Connection.GetCard_All().Where(x => x.DeckId == newDeckModel.Id).ToList();
            cardListBox.DataSource = cards;
            cardListBox.DisplayMember = "Prompt";
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            GlobalConfig.Connection.DeleteDeck(newDeckModel);

            Close();
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            newDeckModel.DeckName = deckNameTextBox.Text;

            if (newDeckModel.DeckName.Length > 0)
            {
                //TODO Prevent duplicate deck names.

                GlobalConfig.Connection.UpdateDeck(newDeckModel);

                Close();
            }
            else
            {
                MessageBox.Show("Please enter a name for your deck.");
            }

        }

        private void createNewCardButton_Click(object sender, EventArgs e)
        {
            using (var frm = new CreateCardForm(newDeckModel))
            {
                frm.StartPosition = FormStartPosition.CenterParent;
                frm.ShowDialog();
            }

            WireUpLists();
        }

        private void editSelectedButton_Click(object sender, EventArgs e)
        {
            CardModel model = (CardModel)cardListBox.SelectedItem;

            if (model != null)
            {
                using (var frm = new EditCardForm(model))
                {
                    frm.StartPosition = FormStartPosition.CenterParent;
                    frm.ShowDialog();
                }

                WireUpLists();
            }
            else
            {
                MessageBox.Show("No card selected");
            }
        }
        private void deleteSelectedButton_Click(object sender, EventArgs e)
        {
            CardModel model = (CardModel)cardListBox.SelectedItem;

            if (model != null)
            {
                GlobalConfig.Connection.DeleteCard(model);

                WireUpLists();
            }
            else
            {
                MessageBox.Show("No card selected");
            }
        }

        private void deckNameLabel_Click(object sender, EventArgs e)
        {

        }

        private void CreateDeck_Load(object sender, EventArgs e)
        {

        }
    }
}
