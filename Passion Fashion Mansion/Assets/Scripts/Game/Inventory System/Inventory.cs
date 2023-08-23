using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour
{
    public static Inventory instance;
    public int money = 0;
    Item head;
    Item neck;
    Item torso;
    List<Item> items = new List<Item>();

    private void Awake()
    {
        instance = this;
    }
    public List<Item> GetItems()
    {
        return items;
    }
}
