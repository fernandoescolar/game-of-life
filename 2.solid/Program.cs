namespace GameOfLife;

public class Program
{
    private const int Heigth = 20;
    private const int Width = 40;

    public static void Main()
    {
        var factory = new GridFactory();
        var cells = factory.CreateGrid(Width, Heigth);

        var game = new Game(cells);
        game.Run();
    }
}
