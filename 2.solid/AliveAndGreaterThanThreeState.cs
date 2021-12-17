namespace GameOfLife;

public class AliveAndGreaterThanThreeState : ICellState
{
    public bool IsMatch(ICell cell, IGrid grid)
    {
        return cell.State && grid.GetNeighbors(cell) > 3;
    }

    public bool State(ICell cell)
    {
        return false;
    }
}
