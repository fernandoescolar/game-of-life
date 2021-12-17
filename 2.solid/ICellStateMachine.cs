namespace GameOfLife;

public interface ICellStateMachine
{
    ICell NextGeneration(IGrid grid);

    void Link(ICell cell);
}
