using RpgGame.Skills;

namespace RpgGame.Champions;

public class Priest: Champion
{
    public Priest(string name, int hp = 80, int maxAttackDamage = 17, int missChance = 0) : base(name, hp, maxAttackDamage, missChance)
    {
    }

    public override void CreateSkillsPool()
    {
        Skills.Add(new HolyBall());
    }
}