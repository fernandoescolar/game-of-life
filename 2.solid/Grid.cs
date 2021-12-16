namespace GameOfLife;

public class Grid
{
    private Cell[,] _cells;

    public Grid(int width, int height)
    {
        _cells = new Cell[height, width];
    }

    public Cell this[int i, int j]
    {
        get { return _cells[i, j]; }
        set { _cells[i, j] = value; }
    }

    public int Height { get => _cells.GetLength(0); }

    public int Width { get => _cells.GetLength(1); }

    public int GetNeighbors(Cell cell)
    {
        var neighbors = 0;
        for (int k = -1; k <= 1; k++)
        {
            for (int l = -1; l <= 1; l++)
            {
                if (k == 0 && l == 0) continue;
                if (cell.Row + k < 0 ||cell.Row + k >= Height) continue;
                if (cell.Column + l < 0 || cell.Column + l >= Width) continue;
                neighbors += _cells[cell.Row + k, cell.Column + l].State ? 1 : 0;
            }
        }

        return neighbors;
    }

    public void UpdateState(Cell[,] cells)
    {
        _cells = cells;
    }
}
