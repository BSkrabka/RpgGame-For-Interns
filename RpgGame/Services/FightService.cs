using RpgGame.Champions;
using RpgGame.Services.Interfaces;
using RpgGame.Skills;

namespace RpgGame.Services;

public class FightService : IFightService
{
    private const int SpecialAttackChance = 10;

    public int CalculateDamage(Champion champion)
    {
        if (IsSpacialAttack())
        {
            return CalculateSpecialAttack(GetRandomSkill(champion.Skills), champion.MissChance);
        }

        return IsAttackMissed(champion.MissChance) ? 0 : CalculateBasicAttack(champion.MaxAttackDamage);
    }

    public bool IsAttackMissed(int missChance)
    {
        return CreateRandomValue() <= missChance;
    }

    public int CalculateBasicAttack(int maxDamage)
    {
        return CreateRandomValue(maxDamage);
    }

    public int CalculateSpecialAttack(Skill skill, int missChance)
    {
        if(skill.CanBeMissed && IsAttackMissed(missChance))
            return 0;

        var random = new Random();
        return random.Next(skill.MinDamage, skill.MaxDamage);
    }

    public bool IsSpacialAttack()
    {
        return CreateRandomValue() < SpecialAttackChance;
    }

    private static int CreateRandomValue(int value = 100)
    {
        var random = new Random();
        return random.Next(value);
    }

    private static Skill GetRandomSkill(List<Skill> skills)
    {
        var random = new Random();

        return skills[random.Next(skills.Count)];
    }
}