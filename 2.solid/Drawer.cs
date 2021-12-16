namespace GameOfLife;

public class Drawer
{
    public void Draw(Grid grid)
    {
        // draw cells
        Console.SetCursorPosition(0, 0);
        for (int i = 0; i < grid.Height; i++)
        {
            for (int j = 0; j < grid.Width; j++)
            {
                Console.Write(grid[i, j].State ? "*" : " ");
            }

            Console.Write("\n");
        }
    }
}