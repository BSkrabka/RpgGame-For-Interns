using RpgGame.Champions;
using RpgGame.Skills;

namespace RpgGame.Services.Interfaces;

public interface IFightService
{
    int CalculateDamage(Champion champion);
    bool IsAttackMissed(int missChance);
    int CalculateBasicAttack(int maxDamage);
    int CalculateSpecialAttack(Skill skill, int missChance);
    bool IsSpacialAttack();
}