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
            var computer = new ComputerPlayer("X");
            var board = new Board
            {
                Squares = new[]
                {
                    "", "", "",
                    "X", "X", "",
                    "O", "O", ""
                },
            };

            var computerMove = computer.Solve(board, "O");
            Assert.AreEqual(8, computerMove);
        }

        [Test]
        public void ReturnSixToStopUserFromWinning()
        {
            var computer = new ComputerPlayer("X");
            var board = new Board
            {
                Squares = new[]
                {
                    "O", "", "",
                    "O", "X", "X",
                    "", "", ""
                },
            };

            var computerMove = computer.Solve(board, "O");
            Assert.AreEqual(6, computerMove);
        }

        [Test]
        public void ReturnTwoToStopUserFromWinning()
        {
            var computer = new ComputerPlayer("X");
            var board = new Board
            {
                Squares = new[]
                {
                    "", "X", "",
                    "X", "O", "",
                    "O", "", ""
                },
            };

            var computerMove = computer.Solve(board, "O");
            Assert.AreEqual(2, computerMove);
        }
    }
}