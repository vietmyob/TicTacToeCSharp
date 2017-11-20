using NUnit.Framework;
using TicTacToeCSharp.DTO;
using TicTacToeCSharp.Lib;

namespace TicTacToeCSharp.UnitTest
{
    [TestFixture]
    public class ComputerShould
    {
        [Test]
        public void ReturnEightToStopUserFromWinning()
        {
            var computer = new Computer();
            var board = new Board
            {
                Squares = new[]
                {
                    "", "", "",
                    "X", "X", "",
                    "O", "O", ""
                },
                XIsNext = false
            };

            var computerMove = computer.Solve(board.Squares);
            Assert.AreEqual(8, computerMove);
        }
    }
}