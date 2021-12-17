namespace GameOfLife;

public record Cell : ICell
{
    private ICellStateMachine _stateMachine;

    public Cell(int row, int column, ICellStateMachine stateMachine) : this(row, column, false, stateMachine)
    {
    }

    public Cell(int row, int column, bool state, ICellStateMachine stateMachine)
    {
        _stateMachine = stateMachine;
        Row = row;
        Column = column;
        State = state;

        stateMachine.Link(this);
    }

    public int Row { get; init; }

    public int Column { get; init; }

    public bool State { get; init; }

    public ICell NextGeneration(IGrid grid)
        => _stateMachine.NextGeneration(grid);
}
