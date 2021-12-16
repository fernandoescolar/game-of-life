namespace GameOfLife;

public class AliveAndLessThanTwoState : ICellState
{
    public bool IsMatch(Cell cell, Grid grid)
    {
        return cell.State && grid.GetNeighbors(cell) < 2;
    }

    public bool State(Cell cell)
    {
        return false;
    }
}
