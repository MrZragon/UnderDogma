using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character_Model 
{
    private int AssetID;

    [Tooltip("玩家血量")]
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

    [Tooltip("移动点")]
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

    [Tooltip("行动点")]
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
