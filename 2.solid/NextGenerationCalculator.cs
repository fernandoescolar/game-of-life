namespace GameOfLife;

public class NextGenerationCalculator : INextGenerationCalculator
{
    public void CalculateNextGeneration(IGrid grid)
    {
        var next = new ICell[grid.Height, grid.Width];
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