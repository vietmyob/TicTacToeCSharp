using NUnit.Framework;
using TicTacToeCSharp.Lib;

namespace TicTacToeCSharp.UnitTest
{
    [TestFixture]
    public class InputProcessorShould
    {
        private BoardInitialiser _boardInitialiser;
        [SetUp]
        public void SetUp()
        {
            _boardInitialiser = new BoardInitialiser();
        }

        [Test]
        [TestCase(2)]
        [TestCase(5)]
        public void AddUserInput(int index)
        {
            var board = _boardInitialiser.Create();
            var inputProcessor = new InputProcessor();
            inputProcessor.Add(board.Squares, index);
            Assert.AreEqual("O", board.Squares[index]);
        }
    }
}
