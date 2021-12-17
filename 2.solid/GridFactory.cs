namespace GameOfLife;

public class GridFactory : IGridFactory
{
    private readonly ICellFactory _cellFactory;

    public GridFactory(ICellFactory cellFactory)
    {
        _cellFactory = cellFactory;
    }

    public IGrid Create(int width, int height)
    {
        var grid = new Grid(width, height);
        var rnd = new Random();
        for (int i = 0; i < height; i++)
        {
            for (int j = 0; j < width; j++)
            {
                grid[i, j] = _cellFactory.Create(i, j, rnd.NextDouble() < 0.2);
            }
        }

        return grid;
    }
}