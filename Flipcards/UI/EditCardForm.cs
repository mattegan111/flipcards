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
    public partial class EditCardForm : MaterialSkin.Controls.MaterialForm
    {
        private readonly CardModel _model;
        public EditCardForm(CardModel model)
        {
            InitializeComponent();

            _model = model;

            promptTextBox.Text = model.Prompt;
            answerTextBox.Text = model.Answer;
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            CardModel updatedModel = new CardModel();
            updatedModel.Prompt = promptTextBox.Text;
            updatedModel.Answer = answerTextBox.Text;
            updatedModel.Id = _model.Id;

            if (promptTextBox.Text.Length > 0 || answerTextBox.Text.Length > 0)
            {
                GlobalConfig.Connection.UpdateCard(updatedModel);

                Close();
            }
            else
            {
                MessageBox.Show("Please complete all fields");
            }
        }

        private void EditCardForm_Load(object sender, EventArgs e)
        {

        }
    }
}
