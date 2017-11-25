using System;
using System.Collections.Generic;
using System.Linq;
using TicTacToeCSharp.DTO;

namespace TicTacToeCSharp.Lib
{
    public class ComputerPlayer
    {
        private readonly BoardAnalyser _boardAnalyser;
        private readonly List<List<int>> _winnerLines;
        private readonly Random _random;

        public ComputerPlayer()
        {
            _boardAnalyser = new BoardAnalyser();
            _winnerLines = new Config().WinnerLines;
            _random = new Random();
        }

        public int Solve(Board board, string humanPlayerSymbol)
        {
            var indexesOfAllUserInput = _boardAnalyser.GetAllIndexesOfPlayerInput(board, humanPlayerSymbol);
            var computerInput = BlockPossibleWinnerLine(indexesOfAllUserInput);
            return string.IsNullOrEmpty(board.Squares[computerInput]) ? computerInput : RandomGuess(board);
        }

        private int BlockPossibleWinnerLine(List<int> indexesOfAllUserInput)
        {
            var userWinnerLine =
                _winnerLines.First(winnerLines => !indexesOfAllUserInput.Except(winnerLines).Any());
            return userWinnerLine.Except(indexesOfAllUserInput).ToList()[0];
        }

        private int RandomGuess(Board board)
        {
            var emptySquares = _boardAnalyser.GetEmptySquares(board);

            return emptySquares.OrderBy(x => _random.Next(board.Squares.Length)).First();
        }   
    }
}