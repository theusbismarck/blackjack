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
}
