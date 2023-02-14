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
            string[] dealerDeck = new string[2];
            dealerDeck[0] = Shuffle();
            dealerDeck[1] = Shuffle();

            string[] userDeck = {"[ ]", "[ ]", "[ ]", "[ ]", "[ ]", "[ ]", "[ ]", "[ ]", "[ ]"};

            userDeck[0] = Shuffle();
            userDeck[1] = Shuffle();

            int dealerScore = (Convert.ToInt16(TurnInt(dealerDeck[0])) + Convert.ToInt16(TurnInt(dealerDeck[1])));
            int userScore = (Convert.ToInt16(TurnInt(userDeck[0])) + Convert.ToInt16(TurnInt(userDeck[1])));

            string answer;
            int i = 1;
            bool victory = false;
            while (victory == false)
            {
                Console.WriteLine("Dealer's deck: " + dealerDeck[0] + " [ ]");
                Console.Write("Your deck: " + string.Join(", ", userDeck));
                if (userScore > 21)
                {
                    break;
                } else if (userScore == 21)
                {
                    Console.WriteLine("");
                    break;
                }
                if ((userDeck[0][0] == '1' || userDeck[1][0] == '1') && (userDeck[0][0] == 'A' || userDeck[1][0] == 'A'))
                {
                    userScore = userScore + 10;
                    Console.WriteLine("");
                    break;
                }
                i++;
                Console.Write("\nDraw a card? (y/n) ");
                answer = Console.ReadLine();
                if (answer == "n")
                {
                    break;
                }
                else if (answer == "y")
                {
                   userDeck[i] = Shuffle();
                   userScore = userScore + Convert.ToInt16(TurnInt(userDeck[i]));
                } else
                {
                    Console.WriteLine("Invalid answer");
                    i--;
                }
            }
            if (userScore > 21 || (dealerScore > userScore && dealerScore < 21))
            {
                Console.WriteLine("\n\nYou lose....");
            } else if (userScore == 21 || (userScore > dealerScore && userScore < 21))
            {
                Console.WriteLine("\nYou win!");
            } else if (userScore == dealerScore && userScore < 21)
            {
                Console.WriteLine("\nIt's a tie.");
            }
            Console.WriteLine("Dealer's deck: " + dealerDeck[0] + " " + dealerDeck[1]);
            Console.ReadLine();
        }

        private static Random rand = new Random();

        static string Shuffle() {
            string[,] cardGrid =
{ 
                // CLUBS ♣
                { "\u2663", "A", "2", "3", "4", "5", "6", "7", "8", "9", "10", "J", "Q", "K"},
                // SPADES ♠
                {"\u2660", "A", "2", "3", "4", "5", "6", "7", "8", "9", "10", "J", "Q", "K"},
                // DIAMONDS ♦
                {"\u2666", "A", "2", "3", "4", "5", "6", "7", "8", "9", "10", "J", "Q", "K"},
                // HEARTS ♥
                {"\u2665", "A", "2", "3", "4", "5", "6", "7", "8", "9", "10", "J", "Q", "K"}
            };

            int cardSuit = rand.Next(0, 4);
            return cardGrid[rand.Next(cardSuit, 4), rand.Next(1, 13)] + cardGrid[cardSuit, 0];
        }
        static string TurnInt(string cardValue)
        {
            if (cardValue == "10\u2663" || cardValue == "10\u2660" || cardValue ==  "10\u2666" || cardValue == "10\u2665") {
                cardValue = "X\u2663";
            }
            string cardNum = cardValue.Remove(cardValue.Length - 1, 1);
            switch (cardNum)
            {
                case "A":
                    cardNum = "1";
                    break;
                case "X":
                    cardNum = "10";
                    break;
                case "J":
                    cardNum = "10";
                    break;
                case "Q":
                    cardNum = "10";
                    break;
                case "K":
                    cardNum = "10";
                    break;
                case " ":
                    cardNum = "0";
                    break;

            }
            return cardNum;
        }
    }
}