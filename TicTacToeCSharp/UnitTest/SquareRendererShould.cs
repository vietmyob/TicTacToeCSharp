using NUnit.Framework;
using TicTacToeCSharp.Lib;

namespace TicTacToeCSharp.UnitTest
{
    [TestFixture]
    public class SquareRendererShould
    {
        private SquareConsoleRenderer _squareConsoleRenderer;

        [SetUp]
        public void SetUp()
        {
            _squareConsoleRenderer = new SquareConsoleRenderer();
        }

        [TestCase(" ", "")]
        [TestCase("X", "X")]
        public void RenderSquaresBasedOnValue(string expected, string squareValue)
        {
            var actual = _squareConsoleRenderer.Render(squareValue);
            Assert.AreEqual(expected, actual);
        }
    }
}