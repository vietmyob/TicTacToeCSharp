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
            };

            var actual = consoleRenderer.Render(board);
            var expected = "-|-|-" + Environment.NewLine +
                           "X|O| " + Environment.NewLine +
                           " |X|O" + Environment.NewLine +
                           " |X|O" + Environment.NewLine +
                           "-|-|-";
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void RenderBoardBasedOnItsInformationReTest()
        {
            var consoleRenderer = new BoardConsoleRenderer();
            var board = new Board
            {
                Squares = new[]
                {
                    "X", "O", "O",
                    "O", "X", "X",
                    "", "X", ""
                },
            };

            var actual = consoleRenderer.Render(board);
            var expected = "-|-|-" + Environment.NewLine +
                           "X|O|O" + Environment.NewLine +
                           "O|X|X" + Environment.NewLine +
                           " |X| " + Environment.NewLine +
                           "-|-|-";
            Assert.AreEqual(expected, actual);
        }
    }
}
