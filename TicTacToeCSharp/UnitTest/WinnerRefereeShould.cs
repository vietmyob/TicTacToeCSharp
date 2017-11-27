using System.Collections.Generic;
using NUnit.Framework;
using TicTacToeCSharp.DTO;
using TicTacToeCSharp.Lib;

namespace TicTacToeCSharp.UnitTest
{
    [TestFixture]
    public class WinnerRefereeShould
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
            var board = new Board(3)
            {
                Squares = new[]
                {
                    "X", "O", "",
                    "", "X", "O",
                    "", "X", "O"
                },
            };
            var actual = _winnerReferee.CheckWinner(board, "O");
            Assert.AreEqual("", actual);
        }

        [Test]
        public void ReturnXIfXHasWonTheGame()
        {
            var board = new Board(3)
            {
                Squares = new[]
                {
                    "X", "O", "",
                    "", "X", "O",
                    "", "", "X"
                },
            };
            var actual = _winnerReferee.CheckWinner(board, "X");
            Assert.AreEqual("X", actual);
        }

        [Test]
        public void ReturnOIfOHasWonTheGame()
        {
            var board = new Board(3)
            {
                Squares = new[]
                {
                    "X", "O", "X",
                    "", "O", "X",
                    "", "O", ""
                },
            };
            var actual = _winnerReferee.CheckWinner(board, "O");
            Assert.AreEqual("O", actual);
        }
    }
}