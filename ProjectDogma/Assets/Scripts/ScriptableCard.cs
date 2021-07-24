using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Card", menuName = "Card")]
public class ScriptableCard : ScriptableObject
{
    public string cardName;//卡牌名称
    [TextArea(1,5)]
    public string cardDes;//卡牌描述

    public Sprite cardSprite;
    public Sprite cardBGSprite;

    public CardType cardType;//卡牌类型

    public int cardCost;//卡牌费用

    public bool isUnlock;//是否解锁
    //public int HoldingQuantity;//持有数量
}
