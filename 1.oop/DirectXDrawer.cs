namespace GameOfLife;

public class DirectXDrawer : DrawerBase
{
    protected override void DrawCell(int x, int y, bool alive)
    {
        // draw in direct x buffer
    }

    protected override void BeforeDrawing()
    {
        // initialize directr X buffer
        base.BeforeDrawing();
    }

    protected override void AfterDrawing()
    {
        // flush direct x buffer
        base.AfterDrawing();
    }
}