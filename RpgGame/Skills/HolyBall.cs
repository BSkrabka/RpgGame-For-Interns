namespace RpgGame.Skills;

public class HolyBall : Skill
{
    public HolyBall(int minDamage = 5, int maxDamage = 15, bool canBeMissed = true) : base(minDamage, maxDamage, canBeMissed)
    {
    }
}