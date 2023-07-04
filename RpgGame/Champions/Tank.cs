using RpgGame.Skills;

namespace RpgGame.Champions;

public class Tank : Champion
{
    public Tank(string name, int hp = 200, int maxAttackDamage = 7, int missChance = 30) : base(name, hp, maxAttackDamage, missChance)
    {
    }

    public override void CreateSkillsPool()
    {
        Skills.Add(new ShieldSlash());
    }
}