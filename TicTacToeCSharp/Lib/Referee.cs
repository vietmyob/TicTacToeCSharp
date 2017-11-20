using System.Collections.Generic;
using System.Linq;
using TicTacToeCSharp.DTO;

namespace TicTacToeCSharp.Lib
{
    public class Referee
    {
        public string CheckWinner(Board board)
        {
            var indexesOfUserInputs = GetIndexesOfAllUserInputs(board);
            if (Config.WinnerLines.Any(winnerLine => indexesOfUserInputs.Contains(winnerLine[0]) &&
                                              indexesOfUserInputs.Contains(winnerLine[1]) &&
                                              indexesOfUserInputs.Contains(winnerLine[2])))
            {
                return board.XIsNext ? "O" : "X";
            }
            return string.Empty;
        }

        public List<int> GetIndexesOfAllUserInputs(Board board)
        {
            var mostRecentInput = board.XIsNext ? "O" : "X";
            var indexesOfUserInputs = new List<int>();
            for (var i = 0; i < board.Squares.Length; i++)
            {
                if (board.Squares[i] == mostRecentInput)
                {
                    indexesOfUserInputs.Add(i);
                }
            }
            return indexesOfUserInputs;
        }
    }
}