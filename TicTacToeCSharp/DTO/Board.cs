using System.Linq;

namespace TicTacToeCSharp.DTO
{
    public class Board
    {
        public string[] Squares;
        public bool XIsNext;

        public Board()
        {
            Squares = Enumerable.Repeat("", 9).ToArray();
            XIsNext = true;
        }
    }
}
