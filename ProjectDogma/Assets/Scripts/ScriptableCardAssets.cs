using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Card Asset", menuName = "Card Asset")]
public class ScriptableCardAssets : ScriptableObject
{
    public string cardName;//��������
    [TextArea(1,5)]
    public string cardDes;//��������

    public CardType cardType;//��������

    [Header("Card Sprites")]
    public Sprite cardSprite;//����ͼƬ
    public Sprite cardBGSprite;//���Ʊ���ͼƬ


    public int cardCost;//���Ʒ���

    public bool isUnlock;//�Ƿ����
    //public int HoldingQuantity;//��������
}
