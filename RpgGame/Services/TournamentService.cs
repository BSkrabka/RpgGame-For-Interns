using RpgGame.Champions;
using RpgGame.Services.Interfaces;

namespace RpgGame.Services;

public class TournamentService : ITournamentService
{
    private readonly IFightService _fightService;
    public List<Champion> Champions { get; set; } = new();

    public TournamentService(IFightService fightService)
    {
        CreateTournamentQueue();
        _fightService = fightService;
    }

    public void CreateTournamentQueue()
    {
        var championCount = GetNumberFromConsole(ConsoleMessages.CountMessage);

        for (int i = 0; i < championCount; i++)
        {
            CreateChampion();
        }
    }

    public void MakeTournament()
    {
        while (Champions.Count > 1)
        {
            var champions = GetFighters();
            var firstChampion = champions[0];
            var secondChampion = champions[1];

            while (true)
            {
                secondChampion.Hp -= _fightService.CalculateDamage(firstChampion);
                if (secondChampion.Hp <= 0)
                {
                    Champions.Remove(secondChampion);
                    Console.WriteLine($"{ConsoleMessages.RoundWinnerMessage} {firstChampion.Name}");

                    break;
                }
                firstChampion.Hp -= _fightService.CalculateDamage(secondChampion);

                if (firstChampion.Hp <= 0)
                {
                    Champions.Remove(firstChampion);
                    Console.WriteLine($"{ConsoleMessages.RoundWinnerMessage} {secondChampion.Name}");

                    break;
                }
            }
        }

        Console.WriteLine($"{ConsoleMessages.GameWinnerMessage} {Champions.First().GetType().Name} {Champions.First().Name}");
    }

    private List<Champion> GetFighters()
    {
        return new List<Champion>()
        {
            Champions.First(),
            Champions.Last()
        };
    }

    private void CreateChampion()
    {
        Console.WriteLine(ConsoleMessages.NameMessage);
        string name = Console.ReadLine();

        int specializationNumber = GetNumberFromConsole(ConsoleMessages.SpecializationMessage);

        switch (specializationNumber)
        {
            case 1:
                {
                    Champions.Add(new Archer(name));
                    break;
                }
            case 2:
                {
                    Champions.Add(new Priest(name));
                    break;
                }
            case 3:
                {
                    Champions.Add(new Tank(name));
                    break;
                }
            case 4:
                {
                    Champions.Add(new Warrior(name));
                    break;
                }
        }
    }

    private int GetNumberFromConsole(string message)
    {
        int number;
        string consoleInput;

        do
        {
            Console.WriteLine(message);
            consoleInput = Console.ReadLine();
        }
        while (!int.TryParse(consoleInput, out number));

        return number;
    }
}