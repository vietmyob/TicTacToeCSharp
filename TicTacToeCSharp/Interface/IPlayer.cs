using TicTacToeCSharp.DTO;

namespace TicTacToeCSharp.Interface
{
    public interface IPlayer
    {
        void Move(Board board, int index);
    }
}