using System.Collections.Generic;
using NUnit.Framework;
using TicTacToeCSharp.DTO;
using TicTacToeCSharp.Lib;

namespace TicTacToeCSharp.UnitTest
{
    [TestFixture]
    public class RefereeShould
    {
        private Referee _referee;
        [SetUp]
        public void SetUp()
        {
            _referee = new Referee();
        }

        [Test]
        public void ReturnEmptyStringIfNoOneHasWonTheGame()
        {
            var squares = new[]
            {
                "X", "O", "",
                "", "X", "O",
                "", "X", "O"
            };
            var actual = _referee.CheckWinner(squares);
            Assert.AreEqual("", actual);
        }

        [Test]
        public void ReturnXIfXHasWonTheGame()
        {
            var squares = new[]
            {
                "X", "O", "",
                "", "X", "O",
                "", "", "X"
            };
            var actual = _referee.CheckWinner(squares);
            Assert.AreEqual("X", actual);
        }

        [Test]
        [Ignore("Building from top down")]
        public void ReturnIndexesOfAllUserInput()
        {
            var board = new Board
            {
                Squares = new[]
                {
                    "X", "O", "",
                    "", "X", "O",
                    "", "", "X"
                },
                XIsNext = false
            };

            var actual = _referee.GetIndexesOfAllCurrentUserInput(board);
            var expected = new List<int>{ 0, 4, 8 };
            Assert.AreEqual(expected, actual);
        }
    }
}