using System;
using NUnit.Framework;
using TicTacToeCSharp.Lib;

namespace TicTacToeCSharp.UnitTest
{
    [TestFixture]
    public class InputCheckerShould
    {
        [Test]
        public void ReturnErrorIfPositionIsNotEmpty()
        {
            var board = new[]
            {
                "", "O", "",
                "", "", "",
                "", "", ""
            };
            var userInput = 1;
            var inputChecker = new InputChecker();
            var ex = Assert.Throws<Exception>(() => inputChecker.CheckPosition(board, userInput));
            Assert.That(ex.Message, Is.EqualTo("Selected postion is not empty"));
        }
    }
}
