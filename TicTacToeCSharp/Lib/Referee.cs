using System.Collections.Generic;
using TicTacToeCSharp.DTO;

namespace TicTacToeCSharp.Lib
{
    public class Referee
    {
        public string CheckWinner(string[] squares)
        {
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