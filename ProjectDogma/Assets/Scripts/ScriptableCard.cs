using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Card", menuName = "Card")]
public class ScriptableCard : ScriptableObject
{
    public string cardName;//��������
    [TextArea(1,5)]
    public string cardDes;//��������

    public Sprite cardSprite;
    public Sprite cardBGSprite;

    public CardType cardType;//��������

    public int cardCost;//���Ʒ���

    public bool isUnlock;//�Ƿ����
    //public int HoldingQuantity;//��������
}
