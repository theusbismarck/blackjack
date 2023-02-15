using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blackjack
{
    public class Card
    {
        public int num;
        public string value;
        public char suit;

        public Card(int aNum, string aValue, char aSuit)
        {
            num = aNum;
            value = aValue;
            suit = aSuit;
        }
    }
    public class Deck
    {
        private static Random random = new Random();


        public static Blackjack.Card DealCard()
        {
            return NewList().ElementAt(random.Next(0,51));
        }

        public static List<Blackjack.Card> NewList()
        {
            var deck = new List<Card>();

            // CLUBS CARDS ♣
            deck.Add(new Card(1, "A", '\u2663'));
            deck.Add(new Card(2, "2", '\u2663'));
            deck.Add(new Card(3, "3", '\u2663'));
            deck.Add(new Card(4, "4", '\u2663'));
            deck.Add(new Card(5, "5", '\u2663'));
            deck.Add(new Card(6, "6", '\u2663'));
            deck.Add(new Card(7, "7", '\u2663'));
            deck.Add(new Card(8, "8", '\u2663'));
            deck.Add(new Card(9, "9", '\u2663'));
            deck.Add(new Card(10, "10", '\u2663'));
            deck.Add(new Card(10, "J", '\u2663'));
            deck.Add(new Card(10, "Q", '\u2663'));
            deck.Add(new Card(10, "K", '\u2663'));
            // SPADES CARDS ♠
            deck.Add(new Card(1, "A", '\u2660'));
            deck.Add(new Card(2, "2", '\u2660'));
            deck.Add(new Card(3, "3", '\u2660'));
            deck.Add(new Card(4, "4", '\u2660'));
            deck.Add(new Card(5, "5", '\u2660'));
            deck.Add(new Card(6, "6", '\u2660'));
            deck.Add(new Card(7, "7", '\u2660'));
            deck.Add(new Card(8, "8", '\u2660'));
            deck.Add(new Card(9, "9", '\u2660'));
            deck.Add(new Card(10, "10", '\u2660'));
            deck.Add(new Card(10, "J", '\u2660'));
            deck.Add(new Card(10, "Q", '\u2660'));
            deck.Add(new Card(10, "K", '\u2660'));
            // HEARTS CARDS ♥
            deck.Add(new Card(1, "A", '\u2665'));
            deck.Add(new Card(2, "2", '\u2665'));
            deck.Add(new Card(3, "3", '\u2665'));
            deck.Add(new Card(4, "4", '\u2665'));
            deck.Add(new Card(5, "5", '\u2665'));
            deck.Add(new Card(6, "6", '\u2665'));
            deck.Add(new Card(7, "7", '\u2665'));
            deck.Add(new Card(8, "8", '\u2665'));
            deck.Add(new Card(9, "9", '\u2665'));
            deck.Add(new Card(10, "10", '\u2665'));
            deck.Add(new Card(10, "J", '\u2665'));
            deck.Add(new Card(10, "Q", '\u2665'));
            deck.Add(new Card(10, "K", '\u2665'));
            // DIAMONDS CARDS ♦
            deck.Add(new Card(1, "A", '\u2666'));
            deck.Add(new Card(2, "2", '\u2666'));
            deck.Add(new Card(3, "3", '\u2666'));
            deck.Add(new Card(4, "4", '\u2666'));
            deck.Add(new Card(5, "5", '\u2666'));
            deck.Add(new Card(6, "6", '\u2666'));
            deck.Add(new Card(7, "7", '\u2666'));
            deck.Add(new Card(8, "8", '\u2666'));
            deck.Add(new Card(9, "9", '\u2666'));
            deck.Add(new Card(10, "10", '\u2666'));
            deck.Add(new Card(10, "J", '\u2666'));
            deck.Add(new Card(10, "Q", '\u2666'));
            deck.Add(new Card(10, "K", '\u2666'));

            return deck;

            /*var firstItem = deck.ElementAt(6);
            Console.Write(firstItem.value);
            Console.Write(firstItem.suit);*/
        }
    }
    public class Hand
    {
        public int score = 0;
        public List<Card> handCards = new List<Card>();
    }
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
            } else
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
