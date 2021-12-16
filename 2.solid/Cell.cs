namespace GameOfLife;

public record Cell
{
    private CellStateMachine _stateMachine;

    public Cell(int row, int column) : this(row, column, false)
    {
    }

    public Cell(int row, int column, bool state)
    {
        _stateMachine = new CellStateMachine(this);
        Row = row;
        Column = column;
        State = state;
    }

    public int Row { get; init; }

    public int Column { get; init; }

    public bool State { get; init; }

    public Cell NextGeneration(Grid grid)
        => _stateMachine.NextGeneration(grid);
}
