namespace RpgGame.Skills;

public class IceArrow : Skill
{
    public IceArrow(int minDamage = 5, int maxDamage = 15, bool canBeMissed = true) : base(minDamage, maxDamage, canBeMissed)
    {
    }
}