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
    public partial class CreateCardForm : MaterialSkin.Controls.MaterialForm
    {
        private CardModel newCardModel = new CardModel();
        private DeckModel parentDeckModel;

        public CreateCardForm(DeckModel model)
        {
            InitializeComponent();

            parentDeckModel = model;
        }

        private void CreateCard_Load(object sender, EventArgs e)
        {

        }

        private void okButton_Click(object sender, EventArgs e)
        {
            newCardModel.Prompt = cardPromptTextBox.Text;
            newCardModel.Answer = cardAnswerTextBox.Text;
            newCardModel.DeckId = parentDeckModel.Id;

            if (newCardModel.Prompt.Length > 0 || newCardModel.Answer.Length > 0)
            {
                DataAccess.GlobalConfig.Connection.CreateCard(newCardModel);

                Close();
            }
            else
            {
                MessageBox.Show("Please complete all fields");
            }
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
