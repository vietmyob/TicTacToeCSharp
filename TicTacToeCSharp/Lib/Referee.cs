using System.Collections.Generic;
using System.Linq;
using TicTacToeCSharp.DTO;

namespace TicTacToeCSharp.Lib
{
    public class Referee
    {
        public string CheckWinner(Board board)
        {
            var winnerLines = new List<List<int>>
            {
                new List<int>() {0, 1, 2},
                new List<int>() {3, 4, 5},
                new List<int>() {6, 7, 8},
                new List<int>() {0, 3, 6},
                new List<int>() {1, 4, 7},
                new List<int>() {2, 5, 8},
                new List<int>() {0, 4, 8},
                new List<int>() {2, 4, 6},
            };

            var indexesOfCurrentUserInput = GetIndexesOfAllCurrentUserInput(board);
            if (winnerLines.Any(winnerLine => indexesOfCurrentUserInput.Contains(winnerLine[0]) &&
                                              indexesOfCurrentUserInput.Contains(winnerLine[1]) &&
                                              indexesOfCurrentUserInput.Contains(winnerLine[2])))
            {
                return board.XIsNext ? "O" : "X";
            }
            return string.Empty;
        }

        public List<int> GetIndexesOfAllCurrentUserInput(Board board)
        {
            var mostRecentInput = board.XIsNext ? "O" : "X";
            var indexesOfCurrentUserInput = new List<int>();
            for (var i = 0; i < board.Squares.Length; i++)
            {
                if (board.Squares[i] == mostRecentInput)
                {
                    indexesOfCurrentUserInput.Add(i);
                }
            }
            return indexesOfCurrentUserInput;
        }
    }
}