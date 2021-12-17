namespace GameOfLife;

public abstract class DrawerBase : IDrawer
{
    public void Draw(IGrid grid)
        => OnDraw(grid);

    protected virtual void OnDraw(IGrid grid)
    {
        for (int i = 0; i < grid.Height; i++)
        {
            DrawLine(grid, i);
        }
    }

    protected virtual void DrawLine(IGrid grid, int row)
    {
        for (int i = 0; i < grid.Width; i++)
        {
            DrawCell(row, i, grid[row, i]);
        }
    }

    protected abstract void DrawCell(int row, int column, ICell cell);
}
