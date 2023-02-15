using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blackjack
{
    class Program
    {
        static void Main(string[] args)
        {
            var dealerHand = new Hand();
            var playerHand = new Hand();
            var dealerDeck = dealerHand.handCards;
            var playerDeck = playerHand.handCards;

            dealerDeck.Add(Deck.DealCard());
            dealerDeck.Add(Deck.DealCard());
            playerDeck.Add(Deck.DealCard());
            playerDeck.Add(Deck.DealCard());

            bool victory;

            while (1 < 2)
            {
                int playerTotal = playerDeck.Sum(item => item.num);
                int dealerTotal = dealerDeck.Sum(item => item.num);
                Console.Write("Dealer's deck: " + dealerDeck[0].value + dealerDeck[0].suit + " [hidden]");
                Console.WriteLine("");
                Console.Write("Player's deck: ");
                foreach (Blackjack.Card var in playerDeck)
                {
                    Console.Write(var.value + var.suit + " ");
                }
                Console.WriteLine("\nPlayer's score: " + playerTotal);
                if ((playerDeck[0].num == 1 || playerDeck[1].num == 1) && (playerDeck[0].num == 10 || playerDeck[1].num == 10))
                {
                    playerTotal = playerTotal + 10;
                    victory = true;
                    break;
                }
                if ((dealerDeck[0].num == 1 || dealerDeck[1].num == 1) && (dealerDeck[0].num == 10 || dealerDeck[1].num == 10))
                {
                    dealerTotal = dealerTotal + 10;
                    victory = false;
                    break;
                }
                if (playerTotal > 21)
                {
                    victory = false;
                    break;
                }
                else if (playerTotal == 21)
                {
                    victory = true;
                    break;
                }
                Console.Write("\nDraw a card? (y/n) ");
                string answer = Console.ReadLine();
                if (answer == "y")
                {
                    playerDeck.Add(Deck.DealCard());
                }
                else if (answer == "n")
                {
                    if (playerTotal <= dealerTotal)
                    {
                        victory = false;
                        break;
                    }
                    else if (playerTotal > dealerTotal)
                    {
                        victory = true;
                        break;
                    }
                }
                else
                {
                    Console.WriteLine("\nInvalid answer");
                }
            }
            if (victory == true)
            {
                Console.WriteLine("\nYou win!");
            }
            else
            {
                Console.WriteLine("\nYou lose...");
            }
            Console.Write("Dealer's deck: ");
            foreach (Blackjack.Card var in dealerDeck)
            {
                Console.Write(var.value + var.suit + " ");
            }
            /* PRINT ALL THE CARDS
            for (int i = 0; i < deck.Count; i++)
            {
                Console.Write(deck[i].num);
                Console.Write(deck[i].suit + "\n");
            }
            */
            Console.ReadLine();
        }
    }
}