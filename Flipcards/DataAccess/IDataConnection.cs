using System.Collections.Generic;
using System.ComponentModel;
using FlipCards.Models;

namespace Flipcards.DataAccess
{
    public interface IDataConnection
    {
        DeckModel CreateDeck(DeckModel model);
        CardModel CreateCard(CardModel model);

        List<DeckModel> GetDeck_All();
        List<CardModel> GetCard_All();
        void DeleteDeck(DeckModel model);
        void DeleteCard(CardModel model);
        void UpdateDeck(DeckModel model);
        void UpdateCard(CardModel model);
    }
}
