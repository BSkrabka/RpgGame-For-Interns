using RpgGame.Skills;

namespace RpgGame.Champions;

public class Warrior : Champion
{
    public Warrior(string name, int hp = 150, int maxAttackDamage = 11, int missChance = 10) : base(name, hp, maxAttackDamage, missChance)
    {
    }

    public override void CreateSkillsPool()
    {
        Skills.Add(new HeavenlySword());
    }
}