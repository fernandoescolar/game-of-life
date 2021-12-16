namespace GameOfLife;

public class GridFactory
{
    public Grid CreateGrid(int width, int height)
    {
        var grid = new Grid(width, height);
        var rnd = new Random();
        for (int i = 0; i < height; i++)
        {
            for (int j = 0; j < width; j++)
            {
                grid[i, j] = new Cell(i, j, rnd.NextDouble() < 0.2);
            }
        }

        return grid;
    }
}