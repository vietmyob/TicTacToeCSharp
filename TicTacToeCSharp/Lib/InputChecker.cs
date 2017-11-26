using System;
using TicTacToeCSharp.DTO;
using TicTacToeCSharp.Interface;

namespace TicTacToeCSharp.Lib
{
    public class InputChecker : IChecker
    {
        public void Validate(Board board, int userInput)
        {
            CheckPosition(board, userInput);
            IsWithinBoardRange(board, userInput);
        }

        public void CheckPosition(Board board, int userInput)
        {
            if(!string.IsNullOrEmpty(board.Squares[userInput]))
                throw new Exception("Selected postion is not empty");
        }

        public void IsWithinBoardRange(Board board, int userInput)
        {
            if (userInput < 0 || userInput > board.Squares.Length - 1)
                throw new Exception("Selected postion is outside of board range");
        }
    }
}