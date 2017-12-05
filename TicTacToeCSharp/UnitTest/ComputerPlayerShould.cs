using NUnit.Framework;
using TicTacToeCSharp.DTO;
using TicTacToeCSharp.Lib;

namespace TicTacToeCSharp.UnitTest
{
    [TestFixture]
    public class ComputerPlayerShould
    {
        [Test]
        public void ReturnEightToStopUserFromWinning()
        {
            var computer = new ComputerPlayer("X");
            var board = new Board(3)
            {
                Squares = new[]
                {
                    "", "", "",
                    "X", "X", "",
                    "O", "O", ""
                },
            };

            var computerMove = computer.Solve(board);
            Assert.AreEqual(8, computerMove);
        }

        [Test]
        public void ReturnSixToStopUserFromWinning()
        {
            var computer = new ComputerPlayer("X");
            var board = new Board(3)
            {
                Squares = new[]
                {
                    "O", "", "",
                    "O", "X", "X",
                    "", "", ""
                },
            };

            var computerMove = computer.Solve(board);
            Assert.AreEqual(6, computerMove);
        }

        [Test]
        public void ReturnTwoToStopUserFromWinning()
        {
            var computer = new ComputerPlayer("X");
            var board = new Board(3)
            {
                Squares = new[]
                {
                    "", "X", "",
                    "X", "O", "",
                    "O", "", ""
                },
            };

            var computerMove = computer.Solve(board);
            Assert.AreEqual(2, computerMove);
        }

        [Test]
        public void AddInputBasedOnIndex()
        {
            var computerPlayer = new ComputerPlayer("X");
            var board = new Board(3)
            {
                Squares = new[]
                {
                    "", "X", "",
                    "X", "O", "",
                    "O", "", ""
                },
            };

            computerPlayer.Move(board);
            Assert.AreEqual("X", board.Squares[2]);
        }
    }
}