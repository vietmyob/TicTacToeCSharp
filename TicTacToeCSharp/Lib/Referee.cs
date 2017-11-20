using System.Collections.Generic;
using System.Linq;
using TicTacToeCSharp.DTO;

namespace TicTacToeCSharp.Lib
{
    public class Referee
    {
        public string CheckWinner(Board board)
        {
            var indexesOfCurrentUserInput = GetIndexesOfAllCurrentUserInput(board);
            if (WinnerLines.Lines.Any(winnerLine => indexesOfCurrentUserInput.Contains(winnerLine[0]) &&
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