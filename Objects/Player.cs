using System.Collections.Generic;

namespace GoFish.Objects
{
  public class Player
  {
    private static List<string> _deck;

    private string _name;
    private bool _isTurnPlayer;
    private List<string> _playerHand = new List<string>();  //we were missing " = new List<string>() "
    public Player(string name, bool newBool)
    {
      _name = name;
      _isTurnPlayer = newBool;
      Deck.BuildDeck();
      _deck = Deck.GetAllCards();
      this.DrawCard(5);
    }
    public void DrawCard(int cardsToDraw)
    {
      for(int i = 1; i <= cardsToDraw; i++)
      {
        _playerHand.Add(_deck[0]);
        this.RemoveCardFromDeck();
      }
    }
    public List<string> GetHand()
    {
      return _playerHand;
    }
    public string GetName()
    {
      return _name;
    }
    public bool IsTurnPlayer()
    {
      return _isTurnPlayer;
    }
    public void SetTurnPlayer(bool newBool)
    {
      _isTurnPlayer = newBool;
    }
    public List<string> GetDeck()
    {
      return _deck;
    }
    public void RemoveCardFromDeck()
    {
      _deck.RemoveAt(0);
    }
  }
}
