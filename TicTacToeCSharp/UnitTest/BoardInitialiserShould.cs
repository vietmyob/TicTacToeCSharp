using NUnit.Framework;
using TicTacToeCSharp.Lib;

namespace TicTacToeCSharp.UnitTest
{
    [TestFixture]
    public class BoardInitialiserShould
    {
        [Test]
        public void ReturnEmptyBoard()
        {
            var boardInitialiser = new BoardInitialiser();
            var actual = boardInitialiser.Create();
            var expected = new[]
            {
                "", "", "",
                "", "", "",
                "", "", ""
            };
            Assert.AreEqual(expected, actual.Squares);
        }
    }
}