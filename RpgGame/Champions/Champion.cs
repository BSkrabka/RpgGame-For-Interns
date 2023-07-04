using RpgGame.Skills;

namespace RpgGame.Champions;

public abstract class Champion
{
    public string Name { get; set; }
    public int Hp { get; set; }
    public int MaxAttackDamage { get; set; }
    public List<Skill> Skills { get; set; } = new();
    public int MissChance { get; set; }

    protected Champion(string name, int hp, int maxAttackDamage, int missChance)
    {
        Name = name;
        Hp = hp;
        MaxAttackDamage = maxAttackDamage;
        MissChance = missChance;
        CreateSkillsPool();
    }

    public abstract void CreateSkillsPool();
}