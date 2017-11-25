using System.Collections.Generic;
using NUnit.Framework;
using TicTacToeCSharp.DTO;
using TicTacToeCSharp.Lib;

namespace TicTacToeCSharp.UnitTest
{
    [TestFixture]
    public class BoardAnalyserShould
    {
        [Test]
        public void ReturnIndexesOfAllUserInput()
        {
            var boardAnalyser = new BoardAnalyser();
            var board = new Board
            {
                Squares = new[]
                {
                    "X", "O", "",
                    "", "X", "O",
                    "", "", "X"
                },
                XIsNext = false
            };
            
            var actual = boardAnalyser.GetAllIndexesOfPlayerInput(board, "X");
            var expected = new List<int> { 0, 4, 8 };

            Assert.AreEqual(expected, actual);
        }
    }
}