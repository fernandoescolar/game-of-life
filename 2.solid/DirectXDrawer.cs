namespace GameOfLife;

public class DirectXDrawer : ComplexDrawerBase
{
    protected override void AfterDrawing(IGrid grid)
    {
        // flush video buffer
    }

    protected override void BeforeDrawing(IGrid grid)
    {
        // create a video buffer
    }

    protected override void DrawCell(int row, int column, ICell cell)
    {
        // write in video buffer
    }
}

