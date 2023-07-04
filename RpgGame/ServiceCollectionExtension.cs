using Microsoft.Extensions.DependencyInjection;
using RpgGame.Services;
using RpgGame.Services.Interfaces;

namespace RpgGame;

public static class ServiceCollectionExtension
{
    public static void ConfigureServices(IServiceCollection services)
    {
        services.AddScoped<IFightService, FightService>();
        services.AddScoped<ITournamentService, TournamentService>();
    }
}