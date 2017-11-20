namespace TicTacToeCSharp.Lib
{
    public interface IChecker
    {
        void Validate(string[] board, int userInput);
    }
}