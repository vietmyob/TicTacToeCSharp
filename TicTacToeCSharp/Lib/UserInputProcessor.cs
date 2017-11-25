using TicTacToeCSharp.Interface;

namespace TicTacToeCSharp.Lib
{
    public class UserInputProcessor
    {
        private readonly IChecker _checker;

        public UserInputProcessor(IChecker checker)
        {
            _checker = checker;
        }

        public void Add(string[] board, int index, string humanPlayerSymbol)
        {
            _checker.Validate(board, index);
            board[index] = humanPlayerSymbol;
        }
    }
}