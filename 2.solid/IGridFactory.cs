namespace GameOfLife;

public interface IGridFactory
{
    IGrid Create(int height, int width);
}
