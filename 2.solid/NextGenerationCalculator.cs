namespace GameOfLife;

public class NextGenerationCalculator
{
    public void CalculateNextGeneration(Grid grid)
    {
        var next = new Cell[grid.Height, grid.Width];
        for (int i = 0; i < grid.Height; i++)
        {
            for (int j = 0; j < grid.Width; j++)
            {
                next[i, j] = grid[i, j].NextGeneration(grid);
            }
        }

        grid.UpdateState(next);
    }
}