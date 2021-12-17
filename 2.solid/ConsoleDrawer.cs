namespace GameOfLife;

public class ConsoleDrawer: DrawerBase
{
    protected override void OnDraw(IGrid grid)
    {
        Console.SetCursorPosition(0, 0);
        base.OnDraw(grid);
    }

    protected override void DrawCell(int row, int column, ICell cell)
    {
        Console.Write(cell.State ? "*" : " ");
    }

    protected override void DrawLine(IGrid grid, int row)
    {
        base.DrawLine(grid, row);
        Console.Write("\n");
    }
}