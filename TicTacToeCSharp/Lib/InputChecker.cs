using System;

namespace TicTacToeCSharp.Lib
{
    public class InputChecker
    {
        public void CheckPosition(string[] board, int userInput)
        {
            if(!string.IsNullOrEmpty(board[userInput]))
                throw new Exception("Selected postion is not empty");
        }

        public void IsWithinBoardRange(string[] board, int userInput)
        {
            if (userInput < 0 || userInput > board.Length - 1)
                throw new Exception("Selected postion is outside of board range");
        }
    }
}