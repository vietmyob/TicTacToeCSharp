namespace TicTacToeCSharp.Lib
{
    public class UserInputProcessor
    {
        public void Add(string[] board, int index)
        {
            board[index] = "O";
        }
    }
}