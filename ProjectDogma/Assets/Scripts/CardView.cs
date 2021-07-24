using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CardView : MonoBehaviour
{
    public ScriptableCard thisAsset;//指定卡牌资源

    public Text nameText;//卡牌名称UI
    public Text desText;//卡牌描述UI

    public Image cardImage;
    public Image cardBGImage;

    public Text typeText;//卡牌类型UI

    public Text costText;//卡牌费用UI


    private void Start()
    {
        DisplayCardUI();
    }

    /// <summary>
    /// 显示卡牌UI
    /// </summary>
    private void DisplayCardUI()
    {
        this.nameText.text = thisAsset.cardName;
        this.desText.text = thisAsset.cardDes;

        this.cardImage.sprite = thisAsset.cardSprite;
        this.cardBGImage.sprite = thisAsset.cardBGSprite;

        this.typeText.text = thisAsset.cardType.ToString();
        this.costText.text = thisAsset.cardCost.ToString();
    }
}
