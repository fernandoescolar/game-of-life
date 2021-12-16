namespace GameOfLife;

public class DefaultState : ICellState
{
    public bool IsMatch(Cell cell, Grid grid)
    {
        return true;
    }

    public bool State(Cell cell)
    {
        return cell.State;
    }
}