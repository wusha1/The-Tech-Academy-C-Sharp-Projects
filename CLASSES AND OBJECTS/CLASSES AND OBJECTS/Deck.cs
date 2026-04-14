using System;
using System.Collections.Generic;

namespace TwentyOne
{
    public class Deck
    {
        public List<Card> Cards { get; set; }

        public Deck()
        {
            Cards = new List<Card>();

            List<string> suits = new List<string>()
            {
                "Clubs", "Hearts", "Diamonds", "Spades"
            };

            List<string> faces = new List<string>()
            {
                "Two", "Three", "Four", "Five", "Six", "Seven",
                "Eight", "Nine", "Ten", "Jack", "Queen", "King", "Ace"
            };

            foreach (string face in faces)
            {
                foreach (string suit in suits)
                {
                    Card card = new Card
                    {
                        Suit = suit,
                        Face = face
                    };

                    Cards.Add(card);
                }
            }
        }

        public void Shuffle(int times = 1)
        {
            Random random = new Random();

            for (int i = 0; i < times; i++)
            {
                List<Card> tempList = new List<Card>();

                while (Cards.Count > 0)
                {
                    int randomIndex = random.Next(0, Cards.Count);
                    tempList.Add(Cards[randomIndex]);
                    Cards.RemoveAt(randomIndex);
                }

                Cards = tempList;
            }
        }
    }
}