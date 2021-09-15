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
    public partial class EditDeckForm : MaterialSkin.Controls.MaterialForm
    {
        private readonly DeckModel _model;
        private List<CardModel> _currentCards;
        private List<CardModel> oldCards;
        private DeckModel newDeckModel = new DeckModel();


        public EditDeckForm(DeckModel model)
        {
            InitializeComponent();

            _model = model;
            deckNameTextBox.Text = _model.DeckName;
            oldCards = GlobalConfig.Connection.GetCard_All().Where(x => x.DeckId == _model.Id).ToList();

            WireUpLists();
        }

        private void WireUpLists()
        {
            _currentCards = GlobalConfig.Connection.GetCard_All().Where(x => x.DeckId == _model.Id).ToList();
            cardListBox.DataSource = _currentCards;
            cardListBox.DisplayMember = "Prompt";
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            List<int> allIds = new List<int>();
            List<int> keepIds = new List<int>();
            List<int> deleteIds = new List<int>();

            foreach (var card in _currentCards)
            {
                allIds.Add(card.Id);
            }

            foreach (var card in oldCards)
            {
                keepIds.Add(card.Id);
            }

            deleteIds = allIds.Except(keepIds).ToList();

            foreach (var id in deleteIds)
            {
                CardModel model = new CardModel();
                model.Id = id;
                GlobalConfig.Connection.DeleteCard(model);
            }

            Close();
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            newDeckModel.DeckName = deckNameTextBox.Text;
            newDeckModel.Id = _model.Id;

            if (deckNameTextBox.Text.Length > 0)
            {
                GlobalConfig.Connection.UpdateDeck(newDeckModel);

                Close();
            }
            else
            {
                MessageBox.Show("Please enter a name for your deck.");
            }
        }

        private void createNewCardDeckButton_Click(object sender, EventArgs e)
        {
            using (var frm = new CreateCardForm(_model))
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

        private void deleteSelected_Click(object sender, EventArgs e)
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

        private void EditDeckForm_Load(object sender, EventArgs e)
        {

        }
    }
}
