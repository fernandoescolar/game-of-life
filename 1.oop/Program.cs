namespace GameOfLife;

public class Program
{
    static void Main(string[] args)
    {
        var drawer = new ConsoleDrawer();
        var game = new Game(drawer) { Heigth = 20, Width = 30 };
        game.Run();
    }
}