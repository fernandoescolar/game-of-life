namespace GameOfLife;

public class Game : IGame
{
    private readonly IGrid _grid;
    private readonly IDrawer _drawer;
    private readonly INextGenerationCalculator _calculator;
    private bool _active;

    public Game(IGrid grid, IDrawer drawer, INextGenerationCalculator calculator)
    {
        _grid = grid;
        _active = true;
        _drawer = drawer;
        _calculator = calculator;
    }

    public void Start()
    {
        Console.Clear();

        while (_active)
        {
            _drawer.Draw(_grid);
            _calculator.CalculateNextGeneration(_grid);
        }
    }

    public void Stop()
    {
        _active = false;
    }
}
