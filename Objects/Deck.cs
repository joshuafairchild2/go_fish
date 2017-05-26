using System.Collections.Generic;

namespace GoFish.Objects
{
  public class Deck
  {
    private static List<string> _deckOfCards;

    public static void BuildDeck()
    {
      List<string> suits = new List<string> {"clubs", "diamonds", "hearts", "spades"};
      _deckOfCards = new List<string>{};
      foreach(string suit in suits){
        for(int i=1; i<14; i++){
          _deckOfCards.Add($"{i} of {suit}");
        }
      }
    }
    public static List<string> GetAllCards()
    {
      return _deckOfCards;
    }
  }
}
