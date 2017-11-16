using System.Linq;
using NUnit.Framework;
using TicTacToeCSharp.Lib;

namespace TicTacToeCSharp.UnitTest
{
    [TestFixture]
    public class InputProcessorShould
    {
        
        [Test]
        public void AddUserInput()
        {
            var board = Enumerable.Repeat("", 9).ToArray();
            var inputProcessor = new InputProcessor();
            inputProcessor.Add(board, 2);
            Assert.AreEqual("O", board[2]);
        }
    }
}
