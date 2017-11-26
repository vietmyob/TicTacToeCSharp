using TicTacToeCSharp.DTO;
using TicTacToeCSharp.Interface;

namespace TicTacToeCSharp.Lib
{
    public class HumanPlayer : IPlayer
    {
        private readonly string _humanPlayerSymbol;
        private readonly IChecker _checker;

        public HumanPlayer(IChecker checker, string humanPlayerSymbol)
        {
            _humanPlayerSymbol = humanPlayerSymbol;
            _checker = checker;
        }

        public void Move(Board board, int index)
        {
            _checker.Validate(board, index);
            board.Squares[index] = _humanPlayerSymbol;
        }
    }
}