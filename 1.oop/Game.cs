namespace GameOfLife;

public class Game
{
    private readonly IDrawer _drawer;
    private Cell[,] _cells;
    private bool _active;

    public Game(IDrawer drawer)
    {
        _drawer = drawer;
        _cells  = new Cell[Heigth, Width];
        _active = true;
    }

    public int Heigth { get; init; } = 20;

    public int Width { get; init; } = 40;

    public bool IsRunning { get => _active; }

    public void Run()
    {
        InitializeCells();
        GameLoop();
    }

    private void InitializeCells()
    {
        var rnd = new Random();
        for (int i = 0; i < Heigth; i++)
        {
            for (int j = 0; j < Width; j++)
            {
                _cells[i, j] = rnd.NextDouble() < 0.2;
            }
        }
    }

    private void GameLoop()
    {
        while (_active)
        {
            _drawer.Draw(_cells);
            _cells = GetNextGeneration();
        }
    }

    private Cell[,] GetNextGeneration()
    {
        var next = new Cell[Heigth, Width];
        for (int i = 0; i < Heigth; i++)
        {
            for (int j = 0; j < Width; j++)
            {
                var neighbors = _cells.GetNeighbors(i, j);
                next[i, j] = _cells[i, j].Next(neighbors);
            }
        }

        return next;
    }
}
