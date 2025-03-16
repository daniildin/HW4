
![image](https://github.com/user-attachments/assets/9409b4d3-e52d-42f5-b1e6-158f961c0c3d)


# Card Deck Program

This is a simple card deck simulation program written in C#. It includes classes to represent a deck of cards, as well as individual cards with their rank and suit. The program supports shuffling, cutting, and drawing cards from the deck.

## Features

- **Card Class**: Represents a playing card with a rank (Ace, Two, Three, etc.) and a suit (Spades, Clubs, Hearts, Diamonds).
- **Deck Class**: Represents a standard deck of 52 cards, providing methods to shuffle, cut, and draw cards.
- **Shuffling**: Randomizes the order of cards in the deck.
- **Cutting**: Allows the deck to be split at a given index and reorders the cards.
- **Drawing**: Allows drawing cards from the top of the deck.

## How to Run

1. Clone this repository to your local machine.
2. Open the solution in Visual Studio or your preferred C# IDE.
3. Build the solution.
4. Run the `Program.cs` to see the simulation in action.

## Code Structure

- **Card.cs**: Contains the `Card` class and `Suit` & `Rank` enums.
- **Deck.cs**: Contains the `Deck` class, responsible for managing the deck of cards.
- **Program.cs**: The entry point of the application, where the deck is created, shuffled, cut, and cards are drawn.

## Example Output

```plaintext
Deck contains 52 cards.
Deck shuffled.
Deck cut at index 26
Top card is: Ace of Spades
Next card is: Two of Spades
Deck now contains 50 cards.

