using System;
using System.Collections.Generic;

namespace CardDeckNamespace
{
    public class Deck
    {
        // I create a list to store all the cards in the deck.
        List<Card> cards = new List<Card>();

        // The constructor initializes the deck with 52 cards (all combinations of rank and suit).
        public Deck()
        {
            foreach (Suit suit in Enum.GetValues(typeof(Suit)))
            {
                foreach (Rank rank in Enum.GetValues(typeof(Rank)))
                {
                    // I create a new card for each rank and suit combination and add it to the deck.
                    cards.Add(new Card(rank, suit));
                }
            }
        }

        // I create a property to get all the cards in the deck.
        public List<Card> Cards { get { return cards; } }

        // I implement a method to take the top card from the deck.
public Card TakeTopCard()
{
    // If there are no cards left, throw an exception instead of returning null.
    if (cards.Count == 0)
    {
        throw new InvalidOperationException("Cannot take a card from an empty deck.");
    }

    // Take the top card (the first card in the list) and remove it from the deck.
    Card topCard = cards[0];
    cards.RemoveAt(0);
    return topCard;
}


        // I implement a shuffle method to randomize the order of the cards in the deck.
        public void Shuffle()
        {
            Random rng = new Random();
            int n = cards.Count;
            while (n > 1)
            {
                n--;
                int k = rng.Next(n + 1);
                // I swap the cards at positions k and n.
                Card value = cards[k];
                cards[k] = cards[n];
                cards[n] = value;
            }
            Console.WriteLine("Deck shuffled.");
        }

        // I implement a method to cut the deck at a given index.
        public void Cut(int index)
        {
            // If the index is out of bounds, I print an error message and return.
            if (index < 0 || index >= cards.Count)
            {
                Console.WriteLine("Invalid index.");
                return;
            }

            // I split the deck into two parts and swap their positions.
            List<Card> topPart = cards.GetRange(0, index);
            List<Card> bottomPart = cards.GetRange(index, cards.Count - index);
            cards.Clear();
            cards.AddRange(bottomPart);
            cards.AddRange(topPart);
            Console.WriteLine("Deck cut at index " + index);
        }
    }
}
