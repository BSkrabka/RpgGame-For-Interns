using Microsoft.Extensions.DependencyInjection;
using RpgGame;
using RpgGame.Services.Interfaces;

var serviceCollection = new ServiceCollection();
ServiceCollectionExtension.ConfigureServices(serviceCollection);
using var serviceProvider = serviceCollection.BuildServiceProvider();

var service = serviceProvider.GetService<ITournamentService>();

service.MakeTournament();
