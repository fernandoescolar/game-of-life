namespace GameOfLife;

public class CellStateMachine : ICellStateMachine
{
    private readonly ICellFactory _cellFactory;
    private readonly List<ICellState> _states;

    private ICell _cell;

    public CellStateMachine(ICellFactory cellFactory, IEnumerable<ICellState> states)
    {
        _cellFactory = cellFactory;
        _states = states.ToList();
    }

    public void Link(ICell cell)
    {
        _cell = cell;
    }

    public ICell NextGeneration(IGrid grid)
    {
        var state = _states.First(s => s.IsMatch(_cell, grid))
                           .State(_cell);

        return _cellFactory.Create(_cell.Row, _cell.Column, state);
    }
}
