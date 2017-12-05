using System.Collections.Generic;
using NUnit.Framework;
using TicTacToeCSharp.DTO;
using TicTacToeCSharp.Lib;

namespace TicTacToeCSharp.UnitTest
{
    [TestFixture]
    public class BoardAnalyserShould
    {
        private BoardAnalyser _boardAnalyser;

        [SetUp]
        public void SetUp()
        {
            _boardAnalyser = new BoardAnalyser();
        }
        [Test]
        public void ReturnIndexesOfAllUserInput()
        {
            var board = new Board(3)
            {
                Squares = new[]
                {
                    "X", "O", "",
                    "", "X", "O",
                    "", "", "X"
                },
            };
            
            var actual = _boardAnalyser.GetAllIndexesOfPlayerInput(board, "X");
            var expected = new List<int> { 0, 4, 8 };

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void ReturnOAsOtherPlayerSymbol()
        {
            var board = new Board(3)
            {
                Squares = new[]
                {
                    "X", "O", "",
                    "", "X", "O",
                    "", "", "X"
                },
            };
            var actual = _boardAnalyser.GetOtherPlayerSymBol(board, "X");
            Assert.AreEqual("O", actual);
        }
    }
}