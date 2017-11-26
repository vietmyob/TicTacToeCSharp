using System;
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
            return "-|-|-" + Environment.NewLine +
                   $"{_squareRenderer.Render(board.Squares[0])}|{_squareRenderer.Render(board.Squares[1])}|{_squareRenderer.Render(board.Squares[2])}" +
                   Environment.NewLine +
                   $"{_squareRenderer.Render(board.Squares[3])}|{_squareRenderer.Render(board.Squares[4])}|{_squareRenderer.Render(board.Squares[5])}" +
                   Environment.NewLine +
                   $"{_squareRenderer.Render(board.Squares[6])}|{_squareRenderer.Render(board.Squares[7])}|{_squareRenderer.Render(board.Squares[8])}" +
                   Environment.NewLine +
                   "-|-|-" + Environment.NewLine;
        }
    }
}