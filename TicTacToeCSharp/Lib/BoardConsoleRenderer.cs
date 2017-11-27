using System;
using System.Text;
using TicTacToeCSharp.DTO;

namespace TicTacToeCSharp.Lib
{
    public class BoardConsoleRenderer
    {
        private readonly SquareConsoleRenderer _squareRenderer;
        public BoardConsoleRenderer()
        {
            _squareRenderer = new SquareConsoleRenderer();
        }

        public string Render(Board board)
        {
            var stringBuilder = new StringBuilder();
            stringBuilder.Append("-|-|-" + Environment.NewLine);

            for (var index = 0; index < board.Squares.Length; index++)
            {
                var nextIndex = index + 1;
                if (nextIndex % board.Size == 0)
                    stringBuilder.Append(_squareRenderer.Render(board.Squares[index]) + Environment.NewLine);
                else
                    stringBuilder.Append(_squareRenderer.Render(board.Squares[index]) + "|");
            }
            stringBuilder.Append("-|-|-" + Environment.NewLine);

            return stringBuilder.ToString();
        }
    }
}