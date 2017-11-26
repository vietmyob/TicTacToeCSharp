﻿using TicTacToeCSharp.DTO;

namespace TicTacToeCSharp.Interface
{
    public interface IChecker
    {
        void Validate(Board board, int userInput);
    }
}