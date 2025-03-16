using System;

namespace CardDeckNamespace
{
    // I define the Rank enum, which represents the rank of a card, from Ace to King.
    public enum Rank
    {
        // enum class contains rank values for cards
        Ace,
        Two,
        Three,
        Four,
        Five,
        Six,
        Seven,
        Eight,
        Nine,
        Ten,
        Jack,
        Queen,
        King
    }

    // I also define the Suit enum, which represents the four suits of a card: Spades, Clubs, Hearts, and Diamonds.
    public enum Suit
    {
        // enum class that contains suits for cards
        Spades,
        Clubs,
        Hearts,
        Diamonds
    }

    public class Card
    {
        // I create private fields to store the rank and suit of the card.
        private Rank rank;
        private Suit suit;

        // I create a constructor that takes in the rank and suit and initializes the card.
        public Card(Rank rank, Suit suit)
        {
            this.rank = rank;
            this.suit = suit;
        }

        // I define a property for the rank of the card so it can be accessed easily.
        public Rank Rank { get { return rank; } }

        // I define a property for the suit of the card so it can be accessed easily.
        public Suit Suit { get { return suit; } }

        // Here, I add a method to flip the card over. (For now, this just prints that the card is flipped.)
        public void FlipOver()
        {
            // Implementation could change the card's face (not required for this simple version)
            // For now, we'll leave it empty or maybe print "Flipped"
            Console.WriteLine("The card is flipped.");
        }

        // I override the ToString method to provide a readable string representation of the card.
        public override string ToString()
        {
            return $"{rank} of {suit}";
        }
    }
}
