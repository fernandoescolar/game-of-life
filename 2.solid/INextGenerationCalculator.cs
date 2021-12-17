namespace GameOfLife;

public interface INextGenerationCalculator
{
    void CalculateNextGeneration(IGrid grid);
}
