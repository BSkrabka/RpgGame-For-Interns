using RpgGame.Champions;

namespace RpgGame.Services.Interfaces;

public interface ITournamentService
{
    void CreateTournamentQueue();
    void RunTournament();
}