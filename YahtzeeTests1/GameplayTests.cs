using Microsoft.VisualStudio.TestTools.UnitTesting;
using Yahtzee;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YahtzeeTests1
{
    [TestClass()]
    public class GameplayTests
    {
        /*
        [TestMethod()]
        public void GameplayTest()
        {
            // To determine whether dices rolled and selected are same
            // Arrange
            int[] expected = { 1, 2, 3, 4, 5 };
            List<int> notRandomNumbers = new List<int> { 1, 2, 3, 4, 5 };
            //IRandom random = new NotActuallyRandom(notRandomNumbers);
            NotActuallyRandom r = new NotActuallyRandom(notRandomNumbers);
            Gameplay gameplay1 = new Gameplay(r);

            // Act
            int[] actual = new int[5];
            for (int i = 0; i < 5; ++i)
            {
                actual[i] = gameplay1.getDiceValue(i);
            }

            // Assert
            Assert.AreEqual(expected[3], actual[3]);

        }
        */

        /* UPPER LEVEL TESTS */

        [TestMethod()]
        public void OnesTest()
        {
            // Arrange
            int expected = 5;                                                      //The Score we expect
            List<int> notRandomNumbers = new List<int> { 1, 1, 1,1, 1 };           //The face of Dices rolled
            Gameplay gameplay1 = new Gameplay();

            // Act
            for (int i = 0; i < 5; ++i)
            {
                gameplay1.setDiceValue(i, notRandomNumbers[i]);
            }
            gameplay1.scoreGenerator();
            int actual = gameplay1.currentScore[0];                                 // 0 index is Ones

            // Assert
            Assert.AreEqual(expected, actual);

        }

        [TestMethod()]
        public void TwosTest()
        {
            // Arrange
            int expected = 8;                                                      //The Score we expect
            List<int> notRandomNumbers = new List<int> { 2, 2, 2, 2, 5 };           //The face of Dices rolled
            Gameplay gameplay1 = new Gameplay();

            // Act
            for (int i = 0; i < 5; ++i)
            {
                gameplay1.setDiceValue(i, notRandomNumbers[i]);
            }
            gameplay1.scoreGenerator();
            int actual = gameplay1.currentScore[1];                                 // 1 index is Twos

            // Assert
            Assert.AreEqual(expected, actual);

        }

        [TestMethod()]
        public void ThreesTest()
        {
            // Arrange
            int expected = 15;                                                      //The Score we expect
            List<int> notRandomNumbers = new List<int> { 3, 3, 3, 3, 3 };           //The face of Dices rolled
            Gameplay gameplay1 = new Gameplay();

            // Act
            for (int i = 0; i < 5; ++i)
            {
                gameplay1.setDiceValue(i, notRandomNumbers[i]);
            }
            gameplay1.scoreGenerator();
            int actual = gameplay1.currentScore[2];                                 // 2 index is Threes

            // Assert
            Assert.AreEqual(expected, actual);

        }

        [TestMethod()]
        public void FoursTest()
        {
            // Arrange
            int expected = 8;                                                      //The Score we expect
            List<int> notRandomNumbers = new List<int> { 2, 4, 4, 3, 5 };           //The face of Dices rolled
            Gameplay gameplay1 = new Gameplay();

            // Act
            for (int i = 0; i < 5; ++i)
            {
                gameplay1.setDiceValue(i, notRandomNumbers[i]);
            }
            gameplay1.scoreGenerator();
            int actual = gameplay1.currentScore[3];                                 // 3 index is Fours

            // Assert
            Assert.AreEqual(expected, actual);

        }

        [TestMethod()]
        public void FivesTest()
        {
            // Arrange
            int expected = 15;                                                       //The Score we expect
            List<int> notRandomNumbers = new List<int> { 5, 4, 4, 5, 5 };           //The face of Dices rolled
            Gameplay gameplay1 = new Gameplay();

            // Act
            for (int i = 0; i < 5; ++i)
            {
                gameplay1.setDiceValue(i, notRandomNumbers[i]);
            }
            gameplay1.scoreGenerator();
            int actual = gameplay1.currentScore[4];                                 // 4 index is Fives

            // Assert
            Assert.AreEqual(expected, actual);

        }

        [TestMethod()]
        public void SixesTest()
        {
            // Arrange
            int expected = 12;                                                      //The Score we expect
            List<int> notRandomNumbers = new List<int> { 6, 2, 3, 6, 5 };           //The face of Dices rolled
            Gameplay gameplay1 = new Gameplay();

            // Act
            for (int i = 0; i < 5; ++i)
            {
                gameplay1.setDiceValue(i, notRandomNumbers[i]);
            }
            gameplay1.scoreGenerator();
            int actual = gameplay1.currentScore[5];                                 // 5 index is Sixes

            // Assert
            Assert.AreEqual(expected, actual);

        }


        /*  LOWER LEVEL TESTS */

        [TestMethod()]
        public void ThreeofKindTest()
        {
            // Arrange
            int expected = 10;                                                      //The Score we expect
            List<int> notRandomNumbers = new List<int> { 1, 1, 1, 2, 5 };           //The face of Dices rolled
            Gameplay gameplay1 = new Gameplay();

            // Act
            for(int i = 0; i < 5; ++i)
            {
                gameplay1.setDiceValue(i,notRandomNumbers[i]);
            }
            gameplay1.scoreGenerator();
            int actual = gameplay1.currentScore[7];                                 // 7 index is Three of a Kind

            // Assert
            Assert.AreEqual(expected, actual);

        }

        [TestMethod()]
        public void FourofKindTest()
        {
            // Arrange
            int expected = 9;                                                       //The Score we expect
            List<int> notRandomNumbers = new List<int> { 1, 1, 1, 1, 5 };           //The face of Dices rolled
            Gameplay gameplay1 = new Gameplay();

            // Act
            for (int i = 0; i < 5; ++i)
            {
                gameplay1.setDiceValue(i, notRandomNumbers[i]);
            }
            gameplay1.scoreGenerator();
            int actual = gameplay1.currentScore[8];                                 // 8 index is Four of a Kind

            // Assert
            Assert.AreEqual(expected, actual);

        }

        [TestMethod()]
        public void FullHouseTest()
        {
            // Arrange
            int expected = 25;                                                       //The Score we expect
            List<int> notRandomNumbers = new List<int> { 3, 3, 3, 6, 6 };           //The face of Dices rolled
            Gameplay gameplay1 = new Gameplay();

            // Act
            for (int i = 0; i < 5; ++i)
            {
                gameplay1.setDiceValue(i, notRandomNumbers[i]);
            }
            gameplay1.scoreGenerator();
            int actual = gameplay1.currentScore[6];                                 // 6 index is Full House

            // Assert
            Assert.AreEqual(expected, actual);

        }

        [TestMethod()]
        public void SmallStraightTest()
        {
            // Arrange
            int expected = 25;                                                       //The Score we expect
            List<int> notRandomNumbers = new List<int> { 1, 2, 3, 4, 5 };           //The face of Dices rolled
            Gameplay gameplay1 = new Gameplay();

            // Act
            for (int i = 0; i < 5; ++i)
            {
                gameplay1.setDiceValue(i, notRandomNumbers[i]);
            }
            gameplay1.scoreGenerator();
            int actual = gameplay1.currentScore[9];                                 // Small Straight

            // Assert
            Assert.AreEqual(expected, actual);

        }

        [TestMethod()]
        public void LargeStraightTest()
        {
            // Arrange
            int expected = 40;                                                       //The Score we expect
            List<int> notRandomNumbers = new List<int> { 1, 2, 3, 4, 5 };           //The face of Dices rolled
            Gameplay gameplay1 = new Gameplay();

            // Act
            for (int i = 0; i < 5; ++i)
            {
                gameplay1.setDiceValue(i, notRandomNumbers[i]);
            }
            gameplay1.scoreGenerator();
            int actual = gameplay1.currentScore[10];                                 // Large Straight

            // Assert
            Assert.AreEqual(expected, actual);

        }

        [TestMethod()]
        public void ChanceTest()
        {
            // Arrange
            int expected = 15;                                                       //The Score we expect
            List<int> notRandomNumbers = new List<int> { 1, 2, 3, 4, 5 };           //The face of Dices rolled
            Gameplay gameplay1 = new Gameplay();

            // Act
            for (int i = 0; i < 5; ++i)
            {
                gameplay1.setDiceValue(i, notRandomNumbers[i]);
            }
            gameplay1.scoreGenerator();
            int actual = gameplay1.currentScore[11];                                 // Chance

            // Assert
            Assert.AreEqual(expected, actual);

        }

        [TestMethod()]
        public void YahtzeeTest()
        {
            // Arrange
            int expected = 50;                                                       //The Score we expect
            List<int> notRandomNumbers = new List<int> { 6, 6, 6, 6, 6 };           //The face of Dices rolled
            Gameplay gameplay1 = new Gameplay();

            // Act
            for (int i = 0; i < 5; ++i)
            {
                gameplay1.setDiceValue(i, notRandomNumbers[i]);
            }
            gameplay1.scoreGenerator();
            int actual = gameplay1.currentScore[12];                                 // YAHTZEE

            // Assert
            Assert.AreEqual(expected, actual);

        }
    }
}