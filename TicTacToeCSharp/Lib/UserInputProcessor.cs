namespace TicTacToeCSharp.Lib
{
    public class UserInputProcessor
    {
        private readonly IChecker _checker;

        public UserInputProcessor()
        {
            _checker = new InputChecker();
        }

        public void Add(string[] board, int index)
        {
            _checker.Validate(board, index);
            board[index] = "O";
        }
    }
}