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
    }
}