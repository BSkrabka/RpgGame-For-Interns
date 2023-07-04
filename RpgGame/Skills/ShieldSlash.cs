namespace RpgGame.Skills;

public class ShieldSlash : Skill
{
    public ShieldSlash(int minDamage = 5, int maxDamage = 15, bool canBeMissed = true) : base(minDamage, maxDamage, canBeMissed)
    {
    }
}