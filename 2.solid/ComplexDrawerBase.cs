namespace GameOfLife;

public abstract class ComplexDrawerBase : DrawerBase
{
    protected override void OnDraw(IGrid grid)
    {
        BeforeDrawing(grid);
        base.OnDraw(grid);
        AfterDrawing(grid);
    }

    protected abstract void BeforeDrawing(IGrid grid);

    protected abstract void AfterDrawing(IGrid grid);
}
