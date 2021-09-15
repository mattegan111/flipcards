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
    public partial class LaunchDeckForm : MaterialSkin.Controls.MaterialForm
    {
        private DeckModel _model = new DeckModel();
        private List<CardModel> allCards = new List<CardModel>();
        private List<CardModel> activeCard = new List<CardModel>();
        private Random rng = new Random();

        public LaunchDeckForm(DeckModel model)
        {
            InitializeComponent();

            _model = model;
            
            Text = $"Practicing: {_model.DeckName}";

            allCards = GlobalConfig.Connection.GetCard_All().Where(x => x.DeckId == _model.Id).ToList();

            LoadCard();
        }

        private void LoadCard()
        {
            Random ran = new Random();
            promptTextBox.Text = "";
            answerTextBox.Text = "";

            //allCards = Shuffle(allCards);

            if (activeCard.Count == 0)
            {
                activeCard.Add(allCards[ran.Next(allCards.Count - 1)]);
            }
            else
            {
                int indexNum = -1;

                while (indexNum == -1)
                {
                    indexNum = ran.Next(allCards.Count - 1);
                    if (allCards[indexNum] == activeCard[0])
                        indexNum = -1;
                }

                activeCard.Clear();
                activeCard.Add(allCards[indexNum]);
            }

            promptTextBox.Text = activeCard[0].Prompt;
        }

        private List<CardModel> Shuffle(List<CardModel> list)
        {
            int n = list.Count;
            while (n > 1)
            {
                n--;
                int k = rng.Next(n + 1);
                CardModel value = list[k];
                list[k] = list[n];
                list[n] = value;
            }

            return list;
        }

        private void LaunchDeckForm_Load(object sender, EventArgs e)
        {

        }

        private void revealAnswerButton_Click(object sender, EventArgs e)
        {
            answerTextBox.Text = activeCard[0].Answer;
        }

        private void nextCardButton_Click(object sender, EventArgs e)
        {
            LoadCard();
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
