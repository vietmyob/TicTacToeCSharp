namespace TicTacToeCSharp.Lib
{
    public class SquareConsoleRenderer
    {
        public string Render(string square)
        {
            return string.IsNullOrEmpty(square) ? " " : square;
        }
    }
}