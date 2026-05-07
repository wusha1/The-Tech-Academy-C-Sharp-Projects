namespace TwentyOne
{
    public class Card
    {
        public string Suit { get; set; }
        public string Face { get; set; }

        public override string ToString()
        {
            return Face + " of " + Suit;
        }
    }
}