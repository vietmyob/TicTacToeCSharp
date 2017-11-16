namespace TicTacToeCSharp.Lib
{
    public class InputProcessor
    {
        public void Add(string[] board, int index)
        {
            board[index] = "O";
        }
    }
}