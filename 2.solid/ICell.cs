namespace GameOfLife;

public interface ICell
{
    int Row { get; init; }

    int Column { get; init; }

    bool State { get; init; }

    ICell NextGeneration(IGrid grid);
}
