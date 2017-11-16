using System.Linq;
using NUnit.Framework;
using TicTacToeCSharp.Lib;

namespace TicTacToeCSharp.UnitTest
{
    [TestFixture]
    public class InputProcessorShould
    {
        
        [Test]
        [TestCase(2)]
        [TestCase(5)]
        public void AddUserInput(int index)
        {
            var board = Enumerable.Repeat("", 9).ToArray();
            var inputProcessor = new InputProcessor();
            inputProcessor.Add(board, index);
            Assert.AreEqual("O", board[index]);
        }
    }
}
