using System;
using System.Collections.Generic;
using System.Text;

namespace FlipCards.Models
{
    public class CardModel
    {
        public int Id { get; set; }
        public string Prompt { get; set; }
        public string Answer { get; set; }
        public int DeckId { get; set; }
    }
}
