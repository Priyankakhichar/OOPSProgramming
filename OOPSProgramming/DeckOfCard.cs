//-------------------------------------------------------------------------------------------------------------------------------
//<copyright file = "DeckOfCard.cs" company ="Bridgelabz">
//Copyright © 2019 company ="Bridgelabz"
//</copyright>
//<creator name ="Priyanka khichar"/>
//
//-------------------------------------------------------------------------------------------------------------------------------
namespace OOPSProgramming
{
    using System;

    /// <summary>
    /// Deck Of cards
    /// </summary>
    public class DeckOfCard
    {
        /// <summary>
        /// The suits array
        /// </summary>
        private string[] suits = { "Clubs", "Diamonds", "Hearts", "Spades" };

        /// <summary>
        /// The ranks array
        /// </summary>
        private string[] ranks = { "2", "3", "4", "5", "6", "7", "8", "9", "10", "Jack", "Queen", "King", "Ace" };

        /// <summary>
        /// The cards array
        /// </summary>
        private string[] cards = new string[4 * 13];

        /// <summary>
        /// The distribute cards array for distributing cards
        /// </summary>
        private string[,] distributCards = new string[4, 13];

        /// <summary>
        /// Decks the of cards for storing the suits and ranks in a single array
        /// </summary>
        public void DeckOfCards()
        {
            int count = 0;
            for (int suit = 0; suit < this.suits.Length; suit++)
            {
                for (int rank = 0; rank < this.ranks.Length; rank++)
                {
                    this.cards[count++] = this.suits[suit] + " " + this.ranks[rank];
                }
            }

            this.ShuffleOfCards();
        }

        /// <summary>
        /// Shuffles of cards.
        /// </summary>
        public void ShuffleOfCards()
        {
            Random random = new Random();
            for (int card = 0; card < this.cards.Length; card++)
            {
                string temp = this.cards[card];
                int randomCard = random.Next(52);
                this.cards[card] = this.cards[randomCard];
                this.cards[randomCard] = temp;
            }
        }

        /// <summary>
        /// Distributes the cards and storing in a 2D array
        /// </summary>
        public void DistributeCards()
        {
            int count = 0;
            for (int player = 0; player < 4; player++)
            {
                for (int card = 0; card < 9; card++)
                {
                    this.distributCards[player, card] = this.cards[count++];
                }
            }

            this.DisplayCards();
        }

        /// <summary>
        /// Displays the cards.
        /// </summary>
        public void DisplayCards()
        {
            for (int player = 0; player < 4; player++)
            {
                Console.WriteLine("player " + (player + 1) + " cards is :=> ");
                for (int card = 0; card < 9; card++)
                {
                    Console.Write(this.distributCards[player, card] + "   ");
                }

                Console.WriteLine("\n");
            }
        }
    }
}
