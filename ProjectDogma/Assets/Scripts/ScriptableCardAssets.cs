using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Card Asset", menuName = "Card Asset")]
public class ScriptableCardAssets : ScriptableObject
{
    public string cardName;//¿¨ÅÆÃû³Æ
    [TextArea(1,5)]
    public string cardDes;//¿¨ÅÆÃèÊö

    public CardType cardType;//¿¨ÅÆÀàĞÍ

    [Header("Card Sprites")]
    public Sprite cardSprite;//¿¨ÅÆÍ¼Æ¬
    public Sprite cardBGSprite;//¿¨ÅÆ±³¾°Í¼Æ¬


    public int cardCost;//¿¨ÅÆ·ÑÓÃ

    public bool isUnlock;//ÊÇ·ñ½âËø
    //public int HoldingQuantity;//³ÖÓĞÊıÁ¿
}
