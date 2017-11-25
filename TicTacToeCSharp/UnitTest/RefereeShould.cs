using System.Collections.Generic;
using NUnit.Framework;
using TicTacToeCSharp.DTO;
using TicTacToeCSharp.Lib;

namespace TicTacToeCSharp.UnitTest
{
    [TestFixture]
    public class RefereeShould
    {
        private WinnerReferee _winnerReferee;
        [SetUp]
        public void SetUp()
        {
            _winnerReferee = new WinnerReferee();
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
            var actual = _winnerReferee.CheckWinner(board, "O");
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
            var actual = _winnerReferee.CheckWinner(board, "X");
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
            var actual = _winnerReferee.CheckWinner(board, "O");
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

            var boardAnalyser = new BoardAnalyser();

            var actual = boardAnalyser.GetAllIndexesOfPlayerInput(board, "X");
            var expected = new List<int>{ 0, 4, 8 };
            Assert.AreEqual(expected, actual);
        }
    }
}