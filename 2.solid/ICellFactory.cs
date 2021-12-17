namespace GameOfLife;

public interface ICellFactory
{
    public ICell Create(int x, int y, bool state = false);
}
