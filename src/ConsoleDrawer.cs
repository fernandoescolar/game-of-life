namespace GameOfLife;

public class ConsoleDrawer : DrawerBase
{
    protected override void DrawCell(int x, int y, bool alive)
    {
        if (x >= Console.BufferHeight)
        {
            Console.Write(" ");
        }
        if (y >= Console.BufferWidth)
        {
            Console.Write(" ");
        }
        Console.SetCursorPosition(y, x);
        Console.Write(alive ? "*" : " ");
    }

    protected override void AfterDrawing()
    {
        Console.Out.Flush();
        Thread.Sleep(500);
        base.AfterDrawing();
    }
}
