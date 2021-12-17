namespace GameOfLife;

using Microsoft.Extensions.DependencyInjection;

public class Program
{
    private const int Heigth = 20;
    private const int Width = 40;

    public static void Main()
    {
        IServiceCollection serviceCollection = new ServiceCollection();
        Configure(serviceCollection);

        var serviceProvider = serviceCollection.BuildServiceProvider();
        using var scope = serviceProvider.CreateScope();
        var game = scope.ServiceProvider.GetRequiredService<IGame>();
        Run(game);
    }

    private static void Configure(IServiceCollection services)
    {
        services.AddScoped<IGame, Game>();
        services.AddScoped<IGridFactory, GridFactory>();
        services.AddScoped<ICellStateMachineFactory, CellStateMachineFactory>();
        services.AddScoped<ICellFactory, CellFactory>();
        services.AddScoped<ICellState, AliveAndLessThanTwoState>();
        services.AddScoped<ICellState, AliveAndGreaterThanThreeState>();
        services.AddScoped<ICellState, DeadAndThreeState>();
        services.AddScoped<ICellState, DefaultState>();
        services.AddScoped<IDrawer, ConsoleDrawer>();
        services.AddScoped<INextGenerationCalculator, NextGenerationCalculator>();
        services.AddScoped<IGrid>(sp => sp.GetRequiredService<IGridFactory>().Create(Width, Heigth));
    }

    private static void Run(IGame game)
    {
        game.Start();
    }
}
