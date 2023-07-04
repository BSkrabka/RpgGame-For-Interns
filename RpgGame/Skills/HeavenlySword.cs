namespace RpgGame.Skills;

public class HeavenlySword : Skill
{
    public HeavenlySword(int minDamage = 5, int maxDamage = 15, bool canBeMissed = true) : base(minDamage, maxDamage, canBeMissed)
    {
    }
}