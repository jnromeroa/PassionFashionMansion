using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class ItemUI : MonoBehaviour
{

    [SerializeField] Image iconImg;
    [SerializeField] TMP_Text nameTxt;
    [SerializeField] TMP_Text priceTxt;

    public void SetItem(Item item)
    {
        iconImg.sprite = item.icon;
        nameTxt.text = item.displayName;
        priceTxt.text = item.price.ToString("0000");
    }
}
