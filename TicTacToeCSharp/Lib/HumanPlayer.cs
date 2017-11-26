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

        public void Move(Board board, int index)
        {
            _checker.Validate(board, index);
            board.Squares[index] = _symbol;
        }
    }
}