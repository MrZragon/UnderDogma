
//这个脚本包含了战斗中所有可见单位的状态

/// <summary>
/// 战斗地图网格单位状态
/// </summary>
public enum BattleGridStatus
{
    Normal,//通常
    Burning,//燃烧
    Obstacle,//障碍物
    Flag,//旗帜所在地
    //有待补充
}


/// <summary>
/// 敌人行为意图
/// </summary>
public enum EnemyBehavioralIntention
{
    Unknown,//未知
    Attack,//攻击
    Defense,//防御（给予护盾）
    AttackAndDenfense,//攻守兼备
    AccumulatePower,//蓄力
    //有待补充
}


/// <summary>
/// 角色状态
/// </summary>
public enum CharacterStatus
{
    BeInspired,//鼓舞
    ShieldProtection,//护盾保护

    Poisoning,//中毒
    Burning,//燃烧
    //有待补充
}


/// <summary>
/// 伤害类型
/// </summary>
public enum DamageType
{
    Normal,//常规
    TrueDamage,//真实伤害（无视护盾）
    PassiveInjury,//被动伤害
    //有待补充
}