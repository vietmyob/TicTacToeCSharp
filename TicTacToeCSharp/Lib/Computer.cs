using System;
using System.Collections.Generic;
using System.Linq;
using TicTacToeCSharp.DTO;

namespace TicTacToeCSharp.Lib
{
    public class Computer
    {
        private readonly Referee _referee;
        private readonly Random _random = new Random();

        public Computer()
        {
            _referee = new Referee();
        }

        public int Solve(Board board)
        {
            var indexesOfAllUserInput = _referee.GetIndexesOfAllUserInputs(board);
            var computerInput = BlockPossibleWinnerLine(indexesOfAllUserInput);
            return string.IsNullOrEmpty(board.Squares[computerInput]) ? computerInput : RandomGuess(board);
        }

        private int BlockPossibleWinnerLine(List<int> indexesOfAllUserInput)
        {
            var userWinnerLine =
                Config.WinnerLines.First(winnerLines => !indexesOfAllUserInput.Except(winnerLines).Any());
            return userWinnerLine.Except(indexesOfAllUserInput).ToList()[0];
        }

        private int RandomGuess(Board board)
        {
            var emptySquares = GetEmptySquares(board);

            return emptySquares.OrderBy(x => _random.Next()).First();
        }

        private List<int> GetEmptySquares(Board board)
        {
            var emptySquares = new List<int>();
            for (var index = 0; index < board.Squares.Length; index++)
            {
                var square = board.Squares[index];
                if (string.IsNullOrEmpty(square))
                    emptySquares.Add(index);
            }
            return emptySquares;
        }
    }
}