
//����ű�������ս�������пɼ���λ��״̬

/// <summary>
/// ս����ͼ����λ״̬
/// </summary>
public enum BattleGridStatus
{
    Normal,//ͨ��
    Burning,//ȼ��
    Obstacle,//�ϰ���
    Flag,//�������ڵ�
    //�д�����
}


/// <summary>
/// ������Ϊ��ͼ
/// </summary>
public enum EnemyBehavioralIntention
{
    Unknown,//δ֪
    Attack,//����
    Defense,//���������軤�ܣ�
    AttackAndDenfense,//���ؼ汸
    AccumulatePower,//����
    //�д�����
}


/// <summary>
/// ��ɫ״̬
/// </summary>
public enum CharacterStatus
{
    BeInspired,//����
    ShieldProtection,//���ܱ���

    Poisoning,//�ж�
    Burning,//ȼ��
    //�д�����
}


/// <summary>
/// �˺�����
/// </summary>
public enum DamageType
{
    Normal,//����
    TrueDamage,//��ʵ�˺������ӻ��ܣ�
    PassiveInjury,//�����˺�
    //�д�����
}