namespace GameOfLife;

public class ICell
{
    public bool IsAlive { get; init; }

    public ICell Next(int neighbors)
        => new ICell
        {
            IsAlive = (IsAlive, neighbors) switch
            {
                (true, < 2) => false,
                (true, > 3) => false,
                (false, 3) => true,
                _ => IsAlive
            }
        };

    public static implicit operator bool(ICell cell) => cell.IsAlive;

    public static implicit operator ICell(bool alive) => new ICell { IsAlive = alive };
}