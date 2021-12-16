namespace GameOfLife;

public class Game
{
    private readonly Drawer _drawer;
    private readonly NextGenerationCalculator _calculator;

    private Grid _grid;
    private bool _active;

    public Game(Grid grid)
    {
        _grid = grid;
        _active = true;
        _drawer = new Drawer();
        _calculator = new NextGenerationCalculator();
    }

    public void Run()
    {
        Console.Clear();

        while (_active)
        {
            _drawer.Draw(_grid);
            _calculator.CalculateNextGeneration(_grid);
        }
    }
}
