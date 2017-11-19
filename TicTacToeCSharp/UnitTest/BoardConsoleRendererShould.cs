using System;
using NUnit.Framework;
using TicTacToeCSharp.DTO;
using TicTacToeCSharp.Lib;

namespace TicTacToeCSharp.UnitTest
{
    [TestFixture]
    public class BoardConsoleRendererShould
    {
        [Test]
        public void RenderBoardBasedOnItsInformation()
        {
            var consoleRenderer = new BoardConsoleRenderer();
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

            var actual = consoleRenderer.Render(board);
            var expected = "-|-|-" + Environment.NewLine +
                           "X|O| " + Environment.NewLine +
                           " |X|O" + Environment.NewLine +
                           " |X|O" + Environment.NewLine +
                           "-|-|-";
            Assert.AreEqual(expected, actual);
        }
    }
}
