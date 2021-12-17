namespace GameOfLife;

public class CellStateMachineFactory : ICellStateMachineFactory
{
    private readonly List<ICellState> _states;

    public CellStateMachineFactory(IEnumerable<ICellState> states)
    {
        _states = states.ToList();
    }

    public ICellStateMachine Create(ICellFactory cellFactory)
    {
        return new CellStateMachine(cellFactory, _states);
    }
}
