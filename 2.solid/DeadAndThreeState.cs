namespace GameOfLife;

public class DeadAndThreeState : ICellState
{
    public bool IsMatch(Cell cell, Grid grid)
    {
        return !cell.State && grid.GetNeighbors(cell) == 3;
    }

    public bool State(Cell cell)
    {
        return true;
    }
}
