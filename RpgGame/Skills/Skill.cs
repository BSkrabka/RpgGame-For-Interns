namespace RpgGame.Skills;

public abstract class Skill
{
    public int MinDamage { get; set; }
    public int MaxDamage { get; set; }
    public bool CanBeMissed { get; set; }

    protected Skill(int minDamage, int maxDamage, bool canBeMissed)
    {
        MinDamage = minDamage;
        MaxDamage = maxDamage;
        CanBeMissed = canBeMissed;
    }
}