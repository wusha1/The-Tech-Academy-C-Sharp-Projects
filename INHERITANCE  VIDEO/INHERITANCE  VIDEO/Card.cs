namespace TwentyOne
{
    public class Card
    {
        public Card()
        {
            Suit = "Spades";
            Face = "Two";
        }
        public Suit Suit { get; set; }
        public string Face { get; set; }
    }
    public enum Suit
    {
        Clubs=4, 
        Diamonds=10, 
        Hearts12,
        Spades=15
    }
}