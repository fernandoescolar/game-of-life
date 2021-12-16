namespace GameOfLife;

public interface ICellState
{
    bool IsMatch(Cell cell, Grid grid);
    bool State(Cell cell);
}
