using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character_Model 
{
    private int AssetID;

    [Tooltip("���Ѫ��")]
    private int HP;
    public int hp
    {
        get
        {
            return HP;
        }
        set
        {
            HP = value;
        }
    }

    [Tooltip("�ƶ���")]
    private int MP;
    public int mp
    {
        get
        {
            return MP;
        }
        set
        {
            MP = value;
        }
    }

    [Tooltip("�ж���")]
    private int AP;
    public int ap
    {
        get
        {
            return AP;
        }
        set
        {
            AP = value;
        }
    }
}
