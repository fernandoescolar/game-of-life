namespace GameOfLife;

public class Cell
{
    public bool IsAlive { get; init; }

    public Cell Next(int neighbors)
        => new Cell
        {
            IsAlive = (IsAlive, neighbors) switch
            {
                (true, < 2) => false,
                (true, > 3) => false,
                (false, 3) => true,
                _ => IsAlive
            }
        };

    public static implicit operator bool(Cell cell) => cell.IsAlive;

    public static implicit operator Cell(bool alive) => new Cell { IsAlive = alive };
}