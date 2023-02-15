using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blackjack
{
    public class Deck
    {
        private static Random random = new Random();


        public static Blackjack.Card DealCard()
        {
            return NewList().ElementAt(random.Next(0, 51));
        }

        public static List<Blackjack.Card> NewList()
        {
            var deck = new List<Card>();
            const char CLUBS = '\u2663';
            const char SPADE = '\u2660';
            const char HEARTS = '\u2665';
            const char DIAMONDS = '\u2666';

            // CLUBS CARDS ♣
            deck.Add(new Card(1, "A", CLUBS));
            deck.Add(new Card(2, "2", CLUBS));
            deck.Add(new Card(3, "3", CLUBS));
            deck.Add(new Card(4, "4", CLUBS));
            deck.Add(new Card(5, "5", CLUBS));
            deck.Add(new Card(6, "6", CLUBS));
            deck.Add(new Card(7, "7", CLUBS));
            deck.Add(new Card(8, "8", CLUBS));
            deck.Add(new Card(9, "9", CLUBS));
            deck.Add(new Card(10, "10", CLUBS));
            deck.Add(new Card(10, "J", CLUBS));
            deck.Add(new Card(10, "Q", CLUBS));
            deck.Add(new Card(10, "K", CLUBS));
            // SPADES CARDS ♠
            deck.Add(new Card(1, "A", SPADE));
            deck.Add(new Card(2, "2", SPADE));
            deck.Add(new Card(3, "3", SPADE));
            deck.Add(new Card(4, "4", SPADE));
            deck.Add(new Card(5, "5", SPADE));
            deck.Add(new Card(6, "6", SPADE));
            deck.Add(new Card(7, "7", SPADE));
            deck.Add(new Card(8, "8", SPADE));
            deck.Add(new Card(9, "9", SPADE));
            deck.Add(new Card(10, "10", SPADE));
            deck.Add(new Card(10, "J", SPADE));
            deck.Add(new Card(10, "Q", SPADE));
            deck.Add(new Card(10, "K", SPADE));
            // HEARTS CARDS ♥
            deck.Add(new Card(1, "A", HEARTS));
            deck.Add(new Card(2, "2", HEARTS));
            deck.Add(new Card(3, "3", HEARTS));
            deck.Add(new Card(4, "4", HEARTS));
            deck.Add(new Card(5, "5", HEARTS));
            deck.Add(new Card(6, "6", HEARTS));
            deck.Add(new Card(7, "7", HEARTS));
            deck.Add(new Card(8, "8", HEARTS));
            deck.Add(new Card(9, "9", HEARTS));
            deck.Add(new Card(10, "10", HEARTS));
            deck.Add(new Card(10, "J", HEARTS));
            deck.Add(new Card(10, "Q", HEARTS));
            deck.Add(new Card(10, "K", HEARTS));
            // DIAMONDS CARDS ♦
            deck.Add(new Card(1, "A", DIAMONDS));
            deck.Add(new Card(2, "2", DIAMONDS));
            deck.Add(new Card(3, "3", DIAMONDS));
            deck.Add(new Card(4, "4", DIAMONDS));
            deck.Add(new Card(5, "5", DIAMONDS));
            deck.Add(new Card(6, "6", DIAMONDS));
            deck.Add(new Card(7, "7", DIAMONDS));
            deck.Add(new Card(8, "8", DIAMONDS));
            deck.Add(new Card(9, "9", DIAMONDS));
            deck.Add(new Card(10, "10", DIAMONDS));
            deck.Add(new Card(10, "J", DIAMONDS));
            deck.Add(new Card(10, "Q", DIAMONDS));
            deck.Add(new Card(10, "K", DIAMONDS));

            return deck;

            /*var firstItem = deck.ElementAt(6);
            Console.Write(firstItem.value);
            Console.Write(firstItem.suit);*/
        }
    }
}
