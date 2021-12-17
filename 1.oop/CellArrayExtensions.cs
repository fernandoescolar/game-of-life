namespace GameOfLife;

public static class CellArrayExtensions
{
    public static int GetNeighbors(this ICell[,] cells, int i, int j)
    {
        var neighbors = 0;
        for (int k = -1; k <= 1; k++)
        {
            for (int l = -1; l <= 1; l++)
            {
                if (k == 0 && l == 0) continue;
                if (i + k < 0 || i + k >= cells.GetLength(0)) continue;
                if (j + l < 0 || j + l >= cells.GetLength(1)) continue;
                neighbors += cells[i + k, j + l] ? 1 : 0;
            }
        }

        return neighbors;
    }
}
