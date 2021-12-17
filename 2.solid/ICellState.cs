namespace GameOfLife;

public interface ICellState
{
    bool IsMatch(ICell cell, IGrid grid);
    bool State(ICell cell);
}
