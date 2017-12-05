using System;
using TicTacToeCSharp.DTO;
using TicTacToeCSharp.Interface;

namespace TicTacToeCSharp.Lib
{
    public class HumanPlayer : IPlayer
    {
        private readonly string _symbol;
        private readonly IChecker _checker;

        public HumanPlayer(IChecker checker, string symbol)
        {
            _symbol = symbol;
            _checker = checker;
        }

        public void Move(Board board)
        {
            Console.WriteLine("Your turn:");
            var humanMove = Console.ReadLine();
            var parsedMove = int.Parse(humanMove);
            _checker.Validate(board, parsedMove);
            board.Squares[parsedMove] = _symbol;
        }
    }
}