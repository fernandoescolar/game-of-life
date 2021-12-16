namespace GameOfLife;

public class CellStateMachine
{
    private readonly Cell _cell;
    private readonly List<ICellState> _states;

    public CellStateMachine(Cell cell)
    {
        _cell = cell;
        _states = new List<ICellState>
        {
            new AliveAndLessThanTwoState(),
            new AliveAndGreaterThanThreeState(),
            new DeadAndThreeState(),
            new DefaultState()
        };
    }

    public Cell NextGeneration(Grid grid)
    {
        var state = _states.First(s => s.IsMatch(_cell, grid))
                           .State(_cell);

        return _cell with { State = state };
    }
}
