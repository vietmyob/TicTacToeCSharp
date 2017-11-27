using System;
using NUnit.Framework;
using TicTacToeCSharp.DTO;
using TicTacToeCSharp.Lib;

namespace TicTacToeCSharp.UnitTest
{
    [TestFixture]
    public class InputCheckerShould
    {
        private InputChecker _inputChecker;

        [SetUp]
        public void SetUp()
        {
            _inputChecker = new InputChecker();
        }

        [Test]
        public void ReturnErrorIfPositionIsNotEmpty()
        {
            var board = new Board(3)
            {
                Squares = new[]
                {
                    "", "O", "",
                    "", "", "",
                    "", "", ""
                }
            };
            var userInput = 1;
            var ex = Assert.Throws<Exception>(() => _inputChecker.CheckPosition(board, userInput));
            Assert.That(ex.Message, Is.EqualTo("Selected postion is not empty"));
        }

        [Test]
        public void ReturnErrorIfInputIsOutOfIndex()
        {
            var board = new Board(3)
            {
                Squares = new[]
                {
                    "", "O", "",
                    "", "", "",
                    "", "", ""
                }
            };
            var userInput = 9;
            var ex = Assert.Throws<Exception>(() => _inputChecker.IsWithinBoardRange(board, userInput));
            Assert.That(ex.Message, Is.EqualTo("Selected postion is outside of board range"));
        }
    }
}
