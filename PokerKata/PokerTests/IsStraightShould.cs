using Microsoft.VisualStudio.TestTools.UnitTesting;
using PokerKata;
using System.Collections.Generic;

namespace PokerTests
{
    [TestClass]
    public class IsStraightShould
    {
        [TestMethod]
        public void ReturnTrueWhenGivenFiveNumbersAllInRow()
        {
            var hand = new List<int>() { 9, 10, 11, 12, 13 };
            Assert.IsTrue(Poker.IsStraight(hand));
        }

        [TestMethod]
        public void ReturnFalseWhenGivenFiveNumbersNotInRow()
        {
            var hand = new List<int>() { 7, 10, 11, 12, 13 };
            Assert.IsFalse(Poker.IsStraight(hand));
        }

        [TestMethod]
        public void ReturnTrueWhenGivenFiveNumbersInRowWithAce()
        {
            var hand = new List<int>() {14, 2, 3, 4, 5 };
            Assert.IsTrue(Poker.IsStraight(hand));
        }
        
        [TestMethod]
        public void ReturnTrueWhenGivenNumbersAreNotInOrder()
        {
            var hand = new List<int>() { 2,7,8,5,10,9,11 };
            Assert.IsTrue(Poker.IsStraight(hand));
        }

        [TestMethod]
        public void ReturnTrueForAHighStraight()
        {
            var hand = new List<int>() { 14, 13, 12, 11, 10 };
            Assert.IsTrue(Poker.IsStraight(hand));
        }

    }
}
