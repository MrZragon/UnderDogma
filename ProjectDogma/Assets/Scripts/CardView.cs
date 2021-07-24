using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CardView : MonoBehaviour
{
    public ScriptableCard thisAsset;//ָ��������Դ

    public Text nameText;//��������UI
    public Text desText;//��������UI

    public Image cardImage;
    public Image cardBGImage;

    public Text typeText;//��������UI

    public Text costText;//���Ʒ���UI


    private void Start()
    {
        DisplayCardUI();
    }

    /// <summary>
    /// ��ʾ����UI
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