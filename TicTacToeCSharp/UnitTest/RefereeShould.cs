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
            var board = new Board
            {
                Squares = new[]
                {
                    "X", "O", "",
                    "", "X", "O",
                    "", "X", "O"
                },
                XIsNext = false
            };
            var actual = _referee.CheckWinner(board);
            Assert.AreEqual("", actual);
        }

        [Test]
        public void ReturnXIfXHasWonTheGame()
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
            var actual = _referee.CheckWinner(board);
            Assert.AreEqual("X", actual);
        }

        [Test]
        public void ReturnOIfOHasWonTheGame()
        {
            var board = new Board
            {
                Squares = new[]
                {
                    "X", "O", "X",
                    "", "O", "X",
                    "", "O", ""
                },
                XIsNext = true
            };
            var actual = _referee.CheckWinner(board);
            Assert.AreEqual("O", actual);
        }

        [Test]
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

            var actual = _referee.GetIndexesOfAllUserInputs(board);
            var expected = new List<int>{ 0, 4, 8 };
            Assert.AreEqual(expected, actual);
        }
    }
}