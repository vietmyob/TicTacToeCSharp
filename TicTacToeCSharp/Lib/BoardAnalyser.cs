using System.Collections.Generic;
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