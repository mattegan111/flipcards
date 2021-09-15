using System;
using System.Collections.Generic;
using System.Text;

namespace FlipCards.Models
{
    public class DeckModel
    {
        public int Id { get; set; }
        public string DeckName { get; set; }

        public DeckModel(int id, string deckName)
        {
            Id = id;
            DeckName = deckName;
        }

        public DeckModel(string deckName)
        {
            DeckName = deckName;
        }

        public DeckModel(DeckModel model)
        {

        }

        public DeckModel()
        {

        }

    }
}
