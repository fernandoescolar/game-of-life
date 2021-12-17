namespace GameOfLife;

public class AliveAndLessThanTwoState : ICellState
{
    public bool IsMatch(ICell cell, IGrid grid)
    {
        return cell.State && grid.GetNeighbors(cell) < 2;
    }

    public bool State(ICell cell)
    {
        return false;
    }
}
