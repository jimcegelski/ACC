using System.Collections.Generic;

namespace PokerKata
{
    public class Poker
    {
        public static bool IsStraight(List<int> hand)
        {
            hand = InitializeHand(hand);
            var cardsInOrder = 0;
            for(int i = 0; i < hand.Count-1; i++)
            {
                if (hand[i] == hand[i + 1] - 1)
                {
                    cardsInOrder++;
                }
            }
            return cardsInOrder >= 4;
        }

        public static List<int> InitializeHand(List<int> hand)
        {
            for (int i = 0; i < hand.Count - 1; i++)
            {
                if (hand[i] == 14) hand[i] = 1;
            }
            hand.Sort();
            return hand;
        }

        public static List<int> InitializeHand2(List<int> hand)
        {
            var newHand = new List<int>();
            foreach(int card in hand)
            {
                if (card == 14) newHand.Add(1);
                newHand.Add(card);
            }
            newHand.Sort();
            return newHand;
        }
    }
}
