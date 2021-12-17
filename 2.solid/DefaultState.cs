namespace GameOfLife;

public class DefaultState : ICellState
{
    public bool IsMatch(ICell cell, IGrid grid)
    {
        return true;
    }

    public bool State(ICell cell)
    {
        return cell.State;
    }
}