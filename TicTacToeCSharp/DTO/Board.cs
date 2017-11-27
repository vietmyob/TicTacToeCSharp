using System.Linq;

namespace TicTacToeCSharp.DTO
{
    public class Board
    {
        public string[] Squares;

        public Board(int size)
        {
            Squares = Enumerable.Repeat("", size * size).ToArray();
        }
    }
}
