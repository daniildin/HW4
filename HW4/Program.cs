using System;
using CardDeckNamespace; // I import the namespace for Card and Deck classes

class Program
{
    static void Main(string[] args)
    {
        // I create a new deck of cards.
        Deck deck = new Deck();
        
        // I display the number of cards in the deck.
        Console.WriteLine("Deck contains " + deck.Cards.Count + " cards.");

        // I shuffle the deck to randomize the order of the cards.
        deck.Shuffle();
        
        // I cut the deck at the 26th card (splitting it into two halves).
        deck.Cut(26); // Cutting the deck in half
        
        // I take the top card from the deck and display it.
        Card topCard = deck.TakeTopCard();
        if (topCard != null)
        {
            Console.WriteLine("Top card is: " + topCard);
        }

        // I take another card from the deck to show that it updates after taking a card.
        Card anotherCard = deck.TakeTopCard();
        if (anotherCard != null)
        {
            Console.WriteLine("Next card is: " + anotherCard);
        }

        // Finally, I display how many cards are left in the deck.
        Console.WriteLine("Deck now contains " + deck.Cards.Count + " cards.");
    }
}
