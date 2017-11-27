using System;
using System.Collections.Generic;
using System.Linq;
using TicTacToeCSharp.DTO;
using TicTacToeCSharp.Interface;

namespace TicTacToeCSharp.Lib
{
    public class ComputerPlayer : IPlayer
    {
        private readonly BoardAnalyser _boardAnalyser;
        private readonly List<List<int>> _winnerLines;
        private readonly Random _random;
        private readonly string _symbol;
        private readonly int optimalMove = 4;

        public ComputerPlayer(string symbol)
        {
            _boardAnalyser = new BoardAnalyser();
            _winnerLines = new Config().WinnerLines;
            _random = new Random();
            _symbol = symbol;
        }

        public void Move(Board board, int index)
        {
            board.Squares[index] = _symbol;
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
                _winnerLines.Where(winnerLines => !indexesOfAllUserInput.Except(winnerLines).Any());
            return userWinnerLine.Any() ? userWinnerLine.First().Except(indexesOfAllUserInput).ToList()[0] : optimalMove;
        }

        private int RandomGuess(Board board)
        {
            var emptySquares = _boardAnalyser.GetEmptySquares(board);
            return string.IsNullOrEmpty(board.Squares[4]) ? 4 : emptySquares[_random.Next(emptySquares.Count)];
        }
    }
}