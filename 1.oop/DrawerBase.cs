namespace GameOfLife;

public abstract class DrawerBase : IDrawer
{
    public void Draw(Cell[,] cells)
    {
        BeforeDrawing();

        for (int i = 0; i < cells.GetLength(0); i++)
        {
            for (int j = 0; j < cells.GetLength(1); j++)
            {
                DrawCell(i, j, cells[i, j]);
            }
        }

        AfterDrawing();
    }

    protected virtual void BeforeDrawing()
    {
    }

    protected virtual void AfterDrawing()
    {
    }

    protected abstract void DrawCell(int x, int y, bool alive);
}