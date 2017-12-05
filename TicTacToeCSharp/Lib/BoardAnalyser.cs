using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting;
using TicTacToeCSharp.DTO;

namespace TicTacToeCSharp.Lib
{
    public class BoardAnalyser
    {
        public List<int> GetAllIndexesOfPlayerInput(Board board, string playerSymbol)
        {
            var indexesOfUserInputs = new List<int>();
            for (var i = 0; i < board.Squares.Length; i++)
            {
                if (board.Squares[i] == playerSymbol)
                {
                    indexesOfUserInputs.Add(i);
                }
            }
            return indexesOfUserInputs;
        }

        public string GetOtherPlayerSymBol(Board board, string currentPlayerSymbol)
        {
            var otherPlayerSymbol = board.Squares.Where(x => x != currentPlayerSymbol && !string.IsNullOrEmpty(x));
            return otherPlayerSymbol.Any() ? otherPlayerSymbol.First() : string.Empty;
        }

        public List<int> GetEmptySquares(Board board)
        {
            var emptySquares = new List<int>();
            for (var index = 0; index < board.Squares.Length; index++)
            {
                var square = board.Squares[index];
                if (string.IsNullOrEmpty(square))
                    emptySquares.Add(index);
            }
            return emptySquares;
        }
    }
}