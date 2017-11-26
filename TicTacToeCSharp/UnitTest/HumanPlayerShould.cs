using NUnit.Framework;
using TicTacToeCSharp.DTO;
using TicTacToeCSharp.Lib;

namespace TicTacToeCSharp.UnitTest
{
    [TestFixture]
    public class HumanPlayerShould
    {
        private Board _board;
        [SetUp]
        public void SetUp()
        {
            _board = new Board();
        }

        [Test]
        [TestCase(2)]
        [TestCase(5)]
        public void AddUserInput(int index)
        {
            var inputProcessor = new HumanPlayer(new InputChecker(), "O");
            inputProcessor.Move(_board, index);
            Assert.AreEqual("O", _board.Squares[index]);
        }
    }
}
