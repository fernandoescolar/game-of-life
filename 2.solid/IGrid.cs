namespace GameOfLife;

public interface IGrid
{
    int Height { get; }

    int Width { get; }

    ICell this[int x, int y] { get; set; }

    int GetNeighbors(ICell cell);

    void UpdateState(ICell[,] cells);
}
