using System.Linq;

namespace TicTacToeCSharp.DTO
{
    public class Board
    {
        public string[] Squares;
        public readonly int Size;

        public Board(int size)
        {
            Size = size;
            Squares = Enumerable.Repeat("", Size * Size).ToArray();
        }
    }
}
