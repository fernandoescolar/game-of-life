namespace GameOfLife;

public interface ICellStateMachineFactory
{
    ICellStateMachine Create(ICellFactory cellFactory);
}
