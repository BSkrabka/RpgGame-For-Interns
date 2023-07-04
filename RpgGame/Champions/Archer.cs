using RpgGame.Skills;

namespace RpgGame.Champions;

public class Archer: Champion
{
    public Archer(string name, int hp = 130, int maxAttackDamage = 15, int missChance = 10) : base(name, hp, maxAttackDamage, missChance)
    {
    }

    public override void CreateSkillsPool()
    {
        Skills.Add(new IceArrow());
    }
}