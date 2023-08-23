using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "new Item", menuName = "ScriptableObjects/Item")]
public class Item : ScriptableObject
{
    public enum Category
    {
        HEAD,
        NECK,
        TORSO
    }
    public Sprite icon;
    public string displayName;
    public Category category;
    public int price;
    public Sprite sprite;
}
