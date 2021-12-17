namespace GameOfLife;

public class CellFactory : ICellFactory
{
    private readonly ICellStateMachineFactory _stateMachineFactory;

    public CellFactory(ICellStateMachineFactory stateMachineFactory)
    {
        _stateMachineFactory = stateMachineFactory;
    }

    public ICell Create(int x, int y, bool state = false)
    {
        var stateMachine = _stateMachineFactory.Create(this);
        return new Cell(x, y, state, stateMachine);
    }
}